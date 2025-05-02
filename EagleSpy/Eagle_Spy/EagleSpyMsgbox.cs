using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000057 RID: 87
	[DesignerGenerated]
	public partial class EagleSpyMsgbox : Form
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x0008993C File Offset: 0x00087B3C
		protected override CreateParams CreateParams
		{
			get
			{
				this.CheckAeroEnabled();
				CreateParams createParams = base.CreateParams;
				if (!this.aeroEnabled)
				{
					createParams.ClassStyle |= 131072;
					return createParams;
				}
				return createParams;
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0008A1B0 File Offset: 0x000883B0
		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			if (msg == 133)
			{
				int num = 2;
				if (this.aeroEnabled)
				{
					EagleSpyMsgbox.NativeMethods.DwmSetWindowAttribute(base.Handle, 2, ref num, 4);
					EagleSpyMsgbox.NativeStructs.MARGINS margins = default(EagleSpyMsgbox.NativeStructs.MARGINS);
					margins.bottomHeight = 1;
					margins.leftWidth = 1;
					margins.rightWidth = 1;
					margins.topHeight = 1;
					EagleSpyMsgbox.NativeMethods.DwmExtendFrameIntoClientArea(base.Handle, ref margins);
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0008A224 File Offset: 0x00088424
		private void CheckAeroEnabled()
		{
			if (Environment.OSVersion.Version.Major >= 6)
			{
				int num = 0;
				EagleSpyMsgbox.NativeMethods.DwmIsCompositionEnabled(ref num);
				this.aeroEnabled = num == 1;
				return;
			}
			this.aeroEnabled = false;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0008A260 File Offset: 0x00088460
		public EagleSpyMsgbox(string t, string m, bool no, Bitmap ico)
		{
			base.Load += this.CraxsMsgbox_Load;
			base.Paint += this.CraxsMsgbox_Paint;
			this.aeroEnabled = true;
			this.borderRadius = 30;
			this.borderSize = 3;
			this.borderColor = Color.Transparent;
			this.InitializeComponent();
			this.titletext.Text = t;
			this.msgtext.Text = m;
			if (!no)
			{
				this.nobtn.Visible = false;
			}
			this.picbox.Image = ico;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00003B6C File Offset: 0x00001D6C
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Yes;
			this.Timer1.Stop();
			base.Close();
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00003B86 File Offset: 0x00001D86
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			this.Timer1.Stop();
			base.Close();
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00003BA0 File Offset: 0x00001DA0
		private void CraxsMsgbox_Load(object sender, EventArgs e)
		{
			base.CenterToScreen();
			this.Timer1.Start();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0008A2F4 File Offset: 0x000884F4
		private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				return;
			}
			using (GraphicsPath roundedPath = this.GetRoundedPath(form.ClientRectangle, radius))
			{
				using (Pen pen = new Pen(borderColor, borderSize))
				{
					using (Matrix matrix = new Matrix())
					{
						graph.SmoothingMode = SmoothingMode.AntiAlias;
						form.Region = new global::System.Drawing.Region(roundedPath);
						if (borderSize >= 1f)
						{
							Rectangle clientRectangle = form.ClientRectangle;
							float num = 1f - (borderSize + 1f) / (float)clientRectangle.Width;
							float num2 = 1f - (borderSize + 1f) / (float)clientRectangle.Height;
							matrix.Scale(num, num2);
							matrix.Translate(borderSize / 1.6f, borderSize / 1.6f);
							graph.Transform = matrix;
							graph.DrawPath(pen, roundedPath);
						}
					}
				}
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0008A3F8 File Offset: 0x000885F8
		private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			float num = radius * 2f;
			graphicsPath.StartFigure();
			graphicsPath.AddArc((float)rect.X, (float)rect.Y, num, num, 180f, 90f);
			graphicsPath.AddArc((float)rect.Right - num, (float)rect.Y, num, num, 270f, 90f);
			graphicsPath.AddArc((float)rect.Right - num, (float)rect.Bottom - num, num, num, 0f, 90f);
			graphicsPath.AddArc((float)rect.X, (float)rect.Bottom - num, num, num, 90f, 90f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0008A4B0 File Offset: 0x000886B0
		private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
		{
			using (GraphicsPath roundedPath = this.GetRoundedPath(control.ClientRectangle, radius))
			{
				using (Pen pen = new Pen(borderColor, 1f))
				{
					graph.SmoothingMode = SmoothingMode.AntiAlias;
					control.Region = new global::System.Drawing.Region(roundedPath);
					graph.DrawPath(pen, roundedPath);
				}
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0008A528 File Offset: 0x00088728
		private void DrawPath(Rectangle rectForm, Graphics graphics, Color color)
		{
			using (GraphicsPath roundedPath = this.GetRoundedPath(rectForm, (float)this.borderRadius))
			{
				using (Pen pen = new Pen(color, 3f))
				{
					graphics.DrawPath(pen, roundedPath);
				}
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0008A58C File Offset: 0x0008878C
		private EagleSpyMsgbox.FormBoundsColors GetFormBoundsColors()
		{
			EagleSpyMsgbox.FormBoundsColors formBoundsColors = default(EagleSpyMsgbox.FormBoundsColors);
			using (Bitmap bitmap = new Bitmap(1, 1))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					Rectangle rectangle = new Rectangle(0, 0, 1, 1);
					rectangle.X = checked(base.Bounds.X - 1);
					rectangle.Y = base.Bounds.Y;
					graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
					formBoundsColors.TopLeftColor = bitmap.GetPixel(0, 0);
					rectangle.X = base.Bounds.Right;
					rectangle.Y = base.Bounds.Y;
					graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
					formBoundsColors.TopRightColor = bitmap.GetPixel(0, 0);
					rectangle.X = base.Bounds.X;
					rectangle.Y = base.Bounds.Bottom;
					graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
					formBoundsColors.BottomLeftColor = bitmap.GetPixel(0, 0);
					rectangle.X = base.Bounds.Right;
					rectangle.Y = base.Bounds.Bottom;
					graphics.CopyFromScreen(rectangle.Location, Point.Empty, rectangle.Size);
					formBoundsColors.BottomRightColor = bitmap.GetPixel(0, 0);
				}
			}
			return formBoundsColors;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0008A758 File Offset: 0x00088958
		private void CraxsMsgbox_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Rectangle clientRectangle = base.ClientRectangle;
			checked
			{
				int num = (int)Math.Round((double)clientRectangle.Width / 2.0);
				int num2 = (int)Math.Round((double)clientRectangle.Height / 2.0);
				EagleSpyMsgbox.FormBoundsColors formBoundsColors = this.GetFormBoundsColors();
				this.DrawPath(clientRectangle, e.Graphics, formBoundsColors.TopLeftColor);
				Rectangle rectangle = new Rectangle(clientRectangle.Right - num, clientRectangle.Y, num, num2);
				this.DrawPath(rectangle, e.Graphics, formBoundsColors.TopRightColor);
				Rectangle rectangle2 = new Rectangle(clientRectangle.X, clientRectangle.Bottom - num2, num, num2);
				this.DrawPath(rectangle2, e.Graphics, formBoundsColors.BottomLeftColor);
				Rectangle rectangle3 = new Rectangle(clientRectangle.Right - num, clientRectangle.Bottom - num2, num, num2);
				this.DrawPath(rectangle3, e.Graphics, formBoundsColors.BottomRightColor);
				this.FormRegionAndBorder(this, (float)this.borderRadius, e.Graphics, this.borderColor, (float)this.borderSize);
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00003BB3 File Offset: 0x00001DB3
		private void Panel2_Paint(object sender, PaintEventArgs e)
		{
			this.ControlRegionAndBorder(this.Panel2, (float)this.borderRadius - (float)this.borderSize / 2f, e.Graphics, this.borderColor);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00003BE2 File Offset: 0x00001DE2
		private void Timer1_Tick(object sender, EventArgs e)
		{
			base.TopMost = true;
			base.BringToFront();
		}

		// Token: 0x04000616 RID: 1558
		private bool aeroEnabled;

		// Token: 0x04000617 RID: 1559
		private int borderRadius;

		// Token: 0x04000618 RID: 1560
		private int borderSize;

		// Token: 0x04000619 RID: 1561
		private Color borderColor;

		// Token: 0x02000058 RID: 88
		public class NativeStructs
		{
			// Token: 0x02000059 RID: 89
			public struct MARGINS
			{
				// Token: 0x04000623 RID: 1571
				public int leftWidth;

				// Token: 0x04000624 RID: 1572
				public int rightWidth;

				// Token: 0x04000625 RID: 1573
				public int topHeight;

				// Token: 0x04000626 RID: 1574
				public int bottomHeight;
			}
		}

		// Token: 0x0200005A RID: 90
		public class NativeMethods
		{
			// Token: 0x060005D0 RID: 1488
			[DllImport("dwmapi")]
			public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref EagleSpyMsgbox.NativeStructs.MARGINS pMarInset);

			// Token: 0x060005D1 RID: 1489
			[DllImport("dwmapi")]
			internal static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

			// Token: 0x060005D2 RID: 1490
			[DllImport("dwmapi.dll")]
			public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
		}

		// Token: 0x0200005B RID: 91
		public class NativeConstants
		{
			// Token: 0x04000627 RID: 1575
			public const int CS_DROPSHADOW = 131072;

			// Token: 0x04000628 RID: 1576
			public const int WM_NCPAINT = 133;
		}

		// Token: 0x0200005C RID: 92
		private struct FormBoundsColors
		{
			// Token: 0x04000629 RID: 1577
			public Color TopLeftColor;

			// Token: 0x0400062A RID: 1578
			public Color TopRightColor;

			// Token: 0x0400062B RID: 1579
			public Color BottomLeftColor;

			// Token: 0x0400062C RID: 1580
			public Color BottomRightColor;
		}
	}
}
