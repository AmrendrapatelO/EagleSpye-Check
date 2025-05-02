using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000036 RID: 54
	[DesignerGenerated]
	public partial class Color_Box0 : Form
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x00054008 File Offset: 0x00052208
		private void SpyStyle()
		{
			this.BoxTitle.BackColor = SpySettings.DefaultColor_Background;
			this.BackColor = SpySettings.DefaultColor_Background;
			foreach (Button button in base.Controls.OfType<Button>())
			{
				button.BackColor = SpySettings.DefaultColor_Foreground;
				button.ForeColor = SpySettings.DefaultColor_Background;
			}
			foreach (CheckBox checkBox in base.Controls.OfType<CheckBox>())
			{
				checkBox.BackColor = SpySettings.DefaultColor_Background;
				checkBox.ForeColor = SpySettings.DefaultColor_Foreground;
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000540D4 File Offset: 0x000522D4
		public Color_Box0()
		{
			base.Load += this.Color_Box0_Load;
			base.Activated += this.Color_Box0_Activated;
			base.Deactivate += this.Color_Box0_Deactivate;
			this.BoxTitlePaintEventArgsWait = false;
			this.Programmatically = false;
			this.default_color = Color.Yellow;
			this._new_color = Color.Yellow;
			this.p1 = new Point(0, 0);
			this.s_mouse1 = false;
			this.p0 = default(Point);
			this.s_mouse0 = false;
			this.TEXT_COLOR = "null";
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00054184 File Offset: 0x00052384
		private void Color_Box0_Load(object sender, EventArgs e)
		{
			this.SpyStyle();
			this.BTN_OK.Font = reso.f;
			base.TopMost = true;
			this.Programmatically = true;
			this.Bmp = new Bitmap(1, 1);
			this.G = Graphics.FromImage(this.Bmp);
			if (clrSAVE.po1 == default(Point))
			{
				this.p0 = new Point(1, 1);
			}
			else
			{
				this.p0 = clrSAVE.po1;
			}
			object[] array = new object[]
			{
				this.p0.X,
				this.p0.Y
			};
			this._Update0(array, this.C_Box2);
			this.C_Box2.Invalidate();
			if (clrSAVE.po2 == default(Point))
			{
				this.p1 = new Point(1, 1);
			}
			else
			{
				this.p1 = clrSAVE.po2;
			}
			object[] array2 = new object[]
			{
				this.p1.X,
				this.p1.Y
			};
			this._Update1(array2, this.C_Box0);
			this.C_Box0.Invalidate();
			this.Programmatically = false;
			this.BoxTitlePaintEventArgsWait = true;
		}

		// Token: 0x060003F0 RID: 1008
		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetKeyState(long nVirtKey);

		// Token: 0x060003F1 RID: 1009 RVA: 0x000542CC File Offset: 0x000524CC
		private void C_Box0_Paint(object sender, PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			Graphics graphics2 = graphics;
			Rectangle rectangle = new Rectangle(0, 0, this.C_Box0.Width, this.C_Box0.Height);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, Color.White, this.default_color, LinearGradientMode.Horizontal))
			{
				graphics2.FillRectangle(linearGradientBrush, rectangle);
			}
			Rectangle rectangle2 = new Rectangle(0, 0, this.C_Box0.Width, this.C_Box0.Height);
			checked
			{
				using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(rectangle2, Color.Transparent, Color.Black, LinearGradientMode.Vertical))
				{
					graphics2.FillRectangle(linearGradientBrush2, rectangle2);
					int num = this.C_Box0.Height - 7;
					graphics2.DrawLine(new Pen(Color.Black, 5f), 0, num, this.C_Box0.Width, num);
				}
				graphics2 = null;
				if (!(this.p1 == default(Point)))
				{
					e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
					Rectangle rectangle3 = ((!this.s_mouse1) ? new Rectangle(this.p1.X - 5, this.p1.Y - 5, 10, 10) : new Rectangle(this.p1.X - 7, this.p1.Y - 7, 14, 14));
					Pen pen = new Pen(Color.Black, 1f);
					if ((int)Math.Round((double)this.C_Box0.Height / 2.0) < this.p1.Y)
					{
						pen = new Pen(Color.White, 1f);
					}
					e.Graphics.DrawEllipse(pen, rectangle3);
					Bitmap bitmap = new Bitmap(this.C_Box0.ClientSize.Width, this.C_Box0.Height);
					this.C_Box0.DrawToBitmap(bitmap, this.C_Box0.ClientRectangle);
					if ((bitmap.Width > this.p1.X) & (bitmap.Height > this.p1.Y))
					{
						Color pixel = bitmap.GetPixel(this.p1.X, this.p1.Y);
						bitmap.Dispose();
						this._new_color = pixel;
					}
				}
				this.C_Box3.BackColor = this._new_color;
				this.Title(new object[]
				{
					this.C_Box3.BackColor.R,
					this.C_Box3.BackColor.G,
					this.C_Box3.BackColor.B
				});
				this.C_Box3.Refresh();
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000545AC File Offset: 0x000527AC
		private void C_Box0_MouseDown(object sender, MouseEventArgs e)
		{
			this.s_mouse1 = true;
			object[] array = new object[] { e.X, e.Y };
			this._Update1(array, this.C_Box0);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000545F0 File Offset: 0x000527F0
		private void _Update1(object[] e, Control c)
		{
			if ((this.s_mouse1 | this.Programmatically) && Conversions.ToBoolean(Operators.AndObject(checked(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(e[0], c.Width - 7, false)), Operators.NotObject(Operators.CompareObjectLess(e[0], 1, false))), Operators.NotObject(Operators.CompareObjectGreater(e[1], c.Height - 7, false)))), Operators.NotObject(Operators.CompareObjectLess(e[1], 1, false)))))
			{
				this.p1.X = Conversions.ToInteger(e[0]);
				this.p1.Y = Conversions.ToInteger(e[1]);
				clrSAVE.po2 = new Point(this.p1.X, this.p1.Y);
				Bitmap bitmap = new Bitmap(c.ClientSize.Width, c.Height);
				c.DrawToBitmap(bitmap, c.ClientRectangle);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(bitmap.Width, e[0], false), Operators.CompareObjectGreater(bitmap.Height, e[1], false))))
				{
					Color pixel = bitmap.GetPixel(Conversions.ToInteger(e[0]), Conversions.ToInteger(e[1]));
					bitmap.Dispose();
					this._new_color = pixel;
					c.Refresh();
				}
				c.Invalidate();
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00054758 File Offset: 0x00052958
		private void C_Box0_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.s_mouse1)
			{
				if (Operators.ConditionalCompareObjectEqual(this.C_Box0.Tag, null, false))
				{
					Cursor.Clip = this.C_Box0.RectangleToScreen(checked(new Rectangle(1, 1, this.C_Box0.Width - 7, this.C_Box0.Height - 7)));
					this.C_Box0.Tag = true;
				}
				object[] array = new object[] { e.X, e.Y };
				this._Update1(array, this.C_Box0);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000547F8 File Offset: 0x000529F8
		private void C_Box0_MouseUp(object sender, MouseEventArgs e)
		{
			this.s_mouse1 = false;
			Cursor.Clip = default(Rectangle);
			this.C_Box0.Tag = null;
			this.C_Box0.Invalidate();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00054834 File Offset: 0x00052A34
		private void C_Box2_Paint(object sender, PaintEventArgs e)
		{
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(new Point(0, 0), this.C_Box2.ClientSize), Color.Red, Color.Blue, 0f))
			{
				linearGradientBrush.InterpolationColors = new ColorBlend
				{
					Positions = new float[] { 0f, 0.1f, 0.284f, 0.5f, 0.668f, 0.9f, 1f },
					Colors = new Color[]
					{
						Color.Purple,
						Color.Red,
						Color.Yellow,
						Color.Lime,
						Color.Cyan,
						Color.Blue,
						Color.LightBlue
					}
				};
				e.Graphics.FillRectangle(linearGradientBrush, this.C_Box2.ClientRectangle);
			}
			if (!(this.p0 == default(Point)))
			{
				e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
				Rectangle rectangle = checked(new Rectangle(this.p0.X - 3, -1, 5, this.C_Box2.Height - 3));
				Pen pen = new Pen(Color.Black, 1f);
				e.Graphics.DrawRectangle(pen, rectangle);
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00054988 File Offset: 0x00052B88
		private void C_Box2_MouseDown(object sender, MouseEventArgs e)
		{
			this.s_mouse0 = true;
			object[] array = new object[] { e.X, e.Y };
			this._Update0(array, this.C_Box2);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000549CC File Offset: 0x00052BCC
		private void _Update0(object[] e, Control c)
		{
			if ((this.s_mouse0 | this.Programmatically) && Conversions.ToBoolean(Operators.AndObject(checked(Operators.AndObject(Operators.AndObject(Operators.NotObject(Operators.CompareObjectGreater(e[0], c.Width - 7, false)), Operators.NotObject(Operators.CompareObjectLess(e[0], 1, false))), Operators.NotObject(Operators.CompareObjectGreater(e[1], c.Height - 7, false)))), Operators.NotObject(Operators.CompareObjectLess(e[1], 1, false)))))
			{
				this.p0.X = Conversions.ToInteger(e[0]);
				this.p0.Y = Conversions.ToInteger(e[1]);
				clrSAVE.po1 = new Point(this.p0.X, this.p0.Y);
				Bitmap bitmap = new Bitmap(c.ClientSize.Width, c.Height);
				c.DrawToBitmap(bitmap, c.ClientRectangle);
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(bitmap.Width, e[0], false), Operators.CompareObjectGreater(bitmap.Height, e[1], false))))
				{
					Color pixel = bitmap.GetPixel(Conversions.ToInteger(e[0]), Conversions.ToInteger(e[1]));
					bitmap.Dispose();
					this.default_color = pixel;
					this.C_Box0.Invalidate();
				}
				c.Invalidate();
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00054B38 File Offset: 0x00052D38
		private void C_Box2_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.s_mouse0)
			{
				if (Operators.ConditionalCompareObjectEqual(this.C_Box2.Tag, null, false))
				{
					Cursor.Clip = this.C_Box2.RectangleToScreen(checked(new Rectangle(1, 1, this.C_Box2.Width - 7, this.C_Box2.Height - 7)));
					this.C_Box2.Tag = true;
				}
				object[] array = new object[] { e.X, e.Y };
				this._Update0(array, this.C_Box2);
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00054BD8 File Offset: 0x00052DD8
		private void C_Box2_MouseUp(object sender, MouseEventArgs e)
		{
			this.s_mouse0 = false;
			Cursor.Clip = default(Rectangle);
			this.C_Box2.Tag = null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00054C08 File Offset: 0x00052E08
		private void ti_Tick(object sender, EventArgs e)
		{
			try
			{
				this.G.CopyFromScreen(new Point((Size)Cursor.Position), Point.Empty, this.Bmp.Size);
				this.C_Box3.BackColor = Color.FromArgb((int)this.Bmp.GetPixel(0, 0).R, (int)this.Bmp.GetPixel(0, 0).G, (int)this.Bmp.GetPixel(0, 0).B);
				this.Title(new object[]
				{
					this.C_Box3.BackColor.R,
					this.C_Box3.BackColor.G,
					this.C_Box3.BackColor.B
				});
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00003215 File Offset: 0x00001415
		private void Title(object[] obj)
		{
			this.TEXT_COLOR = string.Format("RGB:({0},{1},{2})", RuntimeHelpers.GetObjectValue(obj[0]), RuntimeHelpers.GetObjectValue(obj[1]), RuntimeHelpers.GetObjectValue(obj[2]));
			this.BoxTitle.Refresh();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000324A File Offset: 0x0000144A
		private void CK1_MouseDown(object sender, MouseEventArgs e)
		{
			this.ti.Enabled = true;
			this.CK1.Checked = true;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00003264 File Offset: 0x00001464
		private void CK1_MouseUp(object sender, MouseEventArgs e)
		{
			this.ti.Enabled = false;
			this.CK1.Checked = false;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000024CF File Offset: 0x000006CF
		private void BTN_OK_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000327E File Offset: 0x0000147E
		private void Color_Box0_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000327E File Offset: 0x0000147E
		private void Color_Box0_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000327E File Offset: 0x0000147E
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002423 File Offset: 0x00000623
		private void C_Box0_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00054D00 File Offset: 0x00052F00
		private void BoxTitle_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.BoxTitlePaintEventArgsWait)
				{
					string text_COLOR = this.TEXT_COLOR;
					Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
					e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int)defaultColor_Foreground.R, (int)defaultColor_Foreground.G, (int)defaultColor_Foreground.B)), 0, 1, this.BoxTitle.Width, 1);
					Brush brush = new SolidBrush(SpySettings.DefaultColor_Foreground);
					Brush brush2 = new SolidBrush(Color.FromArgb(170, (int)this.BoxTitle.BackColor.R, (int)this.BoxTitle.BackColor.G, (int)this.BoxTitle.BackColor.B));
					Size size = TextRenderer.MeasureText(text_COLOR, reso.f);
					Rectangle rectangle = new Rectangle(0, 2, this.BoxTitle.Width, size.Height + 5);
					e.Graphics.FillRectangle(new Pen(brush2).Brush, rectangle);
					e.Graphics.DrawString(text_COLOR, reso.f, brush, 0f, 2f);
					Size size2 = TextRenderer.MeasureText("S", reso.f);
					if (this.BoxTitle.Height != size2.Height + 3)
					{
						this.BoxTitle.Height = size2.Height + 3;
					}
				}
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002423 File Offset: 0x00000623
		private void BoxTitle_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002423 File Offset: 0x00000623
		private void C_Box2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000336 RID: 822
		private bool BoxTitlePaintEventArgsWait;

		// Token: 0x04000337 RID: 823
		public bool Programmatically;

		// Token: 0x04000338 RID: 824
		public Color default_color;

		// Token: 0x04000339 RID: 825
		public Color _new_color;

		// Token: 0x0400033A RID: 826
		private Bitmap Bmp;

		// Token: 0x0400033B RID: 827
		private Graphics G;

		// Token: 0x0400033C RID: 828
		private const int VK_LBUTTON = 1;

		// Token: 0x0400033D RID: 829
		private Point p1;

		// Token: 0x0400033E RID: 830
		private bool s_mouse1;

		// Token: 0x0400033F RID: 831
		private Point p0;

		// Token: 0x04000340 RID: 832
		private bool s_mouse0;

		// Token: 0x04000341 RID: 833
		private string TEXT_COLOR;
	}
}
