using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x020000B2 RID: 178
	[ToolboxBitmap("ZoomPictureBox.bmp")]
	[DesignerGenerated]
	public class ZoomPictureBox : UserControl
	{
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00005301 File Offset: 0x00003501
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00005309 File Offset: 0x00003509
		[Category("_ZoomPictureBox")]
		public Image Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				this._Image = value;
				this.InitializeImage();
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00005318 File Offset: 0x00003518
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00005320 File Offset: 0x00003520
		[Category("_ZoomPictureBox")]
		[DefaultValue(0)]
		public ZoomPictureBox.ZoomType ZoomMode
		{
			get
			{
				return this._ZoomMode;
			}
			set
			{
				this._ZoomMode = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00005329 File Offset: 0x00003529
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00005331 File Offset: 0x00003531
		[Browsable(false)]
		public double ZoomFactor
		{
			get
			{
				return this._ZoomFactor;
			}
			set
			{
				this._ZoomFactor = this.ValidateZoomFactor(value);
				base.Invalidate(this._ImageBounds);
				this._ImageBounds = this.GetZoomedBounds();
				base.Invalidate(this._ImageBounds);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00005364 File Offset: 0x00003564
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00005371 File Offset: 0x00003571
		[Browsable(false)]
		public Point ImagePosition
		{
			get
			{
				return this._ImageBounds.Location;
			}
			set
			{
				this._ImageBounds.Location = value;
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x000E7710 File Offset: 0x000E5910
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0000537F File Offset: 0x0000357F
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000E7750 File Offset: 0x000E5950
		public ZoomPictureBox()
		{
			this.MouseWheelDivisor = 4000;
			this.MinimumImageWidth = 100;
			this.MinimumImageHeight = 100;
			this.MaximumZoomFactor = 16.0;
			this.EnableMouseWheelZooming = true;
			this.EnableMouseDragging = true;
			this._ZoomMode = ZoomPictureBox.ZoomType.MousePosition;
			this.InitializeComponent();
			this.DoubleBuffered = true;
			this.BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
			base.Size = new Size(200, 200);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00005393 File Offset: 0x00003593
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (this.EnableMouseDragging && e.Button == MouseButtons.Left)
			{
				this._startDrag = e.Location;
				this._dragging = true;
			}
			base.OnMouseDown(e);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x000E77D0 File Offset: 0x000E59D0
		protected override void OnMouseMove(MouseEventArgs e)
		{
			checked
			{
				if (this._dragging)
				{
					base.Invalidate(this._ImageBounds);
					this._ImageBounds.X = this._ImageBounds.X + (e.X - this._startDrag.X);
					this._ImageBounds.Y = this._ImageBounds.Y + (e.Y - this._startDrag.Y);
					this._startDrag = e.Location;
					base.Invalidate(this._ImageBounds);
				}
				base.OnMouseMove(e);
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x000053C4 File Offset: 0x000035C4
		protected override void OnMouseUp(MouseEventArgs e)
		{
			if (this._dragging)
			{
				this._dragging = false;
				base.Invalidate();
			}
			base.OnMouseUp(e);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x000053E2 File Offset: 0x000035E2
		protected override void OnMouseEnter(EventArgs e)
		{
			base.Select();
			base.OnMouseEnter(e);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000E7858 File Offset: 0x000E5A58
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			if (this.EnableMouseWheelZooming && base.Bounds.Contains(base.PointToClient(Control.MousePosition)))
			{
				double num = this._ZoomFactor;
				num *= 1.0 + (double)e.Delta / (double)this.MouseWheelDivisor;
				this.ZoomFactor = num;
			}
			base.OnMouseWheel(e);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x000E78BC File Offset: 0x000E5ABC
		protected override void OnPaint(PaintEventArgs pe)
		{
			if (this._ZoomFactor > 4.0)
			{
				pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
				pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
			}
			else
			{
				pe.Graphics.InterpolationMode = InterpolationMode.Default;
			}
			if (this._Image != null)
			{
				pe.Graphics.DrawImage(this._Image, this._ImageBounds);
			}
			base.OnPaint(pe);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000053F1 File Offset: 0x000035F1
		protected override void OnParentChanged(EventArgs e)
		{
			this.InitializeImage();
			base.OnParentChanged(e);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00005400 File Offset: 0x00003600
		private void InitializeImage()
		{
			if (this._Image != null)
			{
				this.ZoomFactor = this.FitImageToControl();
				this._ImageBounds = this.CenterImageBounds();
			}
			base.Invalidate();
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000E7928 File Offset: 0x000E5B28
		private double ValidateZoomFactor(double zoom)
		{
			zoom = Math.Min(zoom, this.MaximumZoomFactor);
			checked
			{
				if (this._Image != null)
				{
					if ((int)Math.Round(unchecked((double)this._Image.Width * zoom)) < this.MinimumImageWidth)
					{
						zoom = (double)this.MinimumImageWidth / (double)this._Image.Width;
					}
					if ((int)Math.Round(unchecked((double)this._Image.Height * zoom)) < this.MinimumImageHeight)
					{
						zoom = (double)this.MinimumImageHeight / (double)this._Image.Height;
					}
				}
				return zoom;
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00005428 File Offset: 0x00003628
		public void RefreshLocation()
		{
			this.InitializeImage();
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000E79B0 File Offset: 0x000E5BB0
		private double FitImageToControl()
		{
			if (base.ClientSize == Size.Empty)
			{
				return 1.0;
			}
			double num = (double)this._Image.Width / (double)this._Image.Height;
			double num2 = (double)base.ClientSize.Width / (double)base.ClientSize.Height;
			if (num > num2)
			{
				return (double)base.ClientSize.Width / (double)this._Image.Width;
			}
			return (double)base.ClientSize.Height / (double)this._Image.Height;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000E7A50 File Offset: 0x000E5C50
		private Rectangle CenterImageBounds()
		{
			checked
			{
				int num = (int)Math.Round(unchecked((double)this._Image.Width * this._ZoomFactor));
				int num2 = (int)Math.Round(unchecked((double)this._Image.Height * this._ZoomFactor));
				int num3 = (base.ClientSize.Width - num) / 2;
				int num4 = (base.ClientSize.Height - num2) / 2;
				return new Rectangle(num3, num4, num, num2);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000E7AC4 File Offset: 0x000E5CC4
		private Rectangle GetZoomedBounds()
		{
			Rectangle rectangle = default(Rectangle);
			checked
			{
				try
				{
					if (this._Image == null)
					{
						rectangle = Rectangle.Empty;
						return rectangle;
					}
					if (this._ImageBounds == Rectangle.Empty)
					{
						this._ImageBounds = this.CenterImageBounds();
					}
					Point point = this.FindZoomCenter(this._ZoomMode);
					double num = (double)this._ImageBounds.Width / (double)this._Image.Width;
					double num2 = this._ZoomFactor / num;
					this._ImageBounds.Width = (int)Math.Round(unchecked((double)this._ImageBounds.Width * num2));
					this._ImageBounds.Height = (int)Math.Round(unchecked((double)this._ImageBounds.Height * num2));
					Point point2 = default(Point);
					point2.X = (int)Math.Round(unchecked((double)point.X * num2));
					point2.Y = (int)Math.Round(unchecked((double)point.Y * num2));
					this._ImageBounds.X = this._ImageBounds.X + (point.X - point2.X);
					this._ImageBounds.Y = this._ImageBounds.Y + (point.Y - point2.Y);
					rectangle = this._ImageBounds;
					return rectangle;
				}
				catch (Exception)
				{
				}
				return rectangle;
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000E7C24 File Offset: 0x000E5E24
		private Point FindZoomCenter(ZoomPictureBox.ZoomType type)
		{
			Point point = default(Point);
			checked
			{
				switch (type)
				{
				case ZoomPictureBox.ZoomType.MousePosition:
				{
					Point point2 = base.PointToClient(Control.MousePosition);
					point.X = point2.X - this._ImageBounds.X;
					point.Y = point2.Y - this._ImageBounds.Y;
					break;
				}
				case ZoomPictureBox.ZoomType.ControlCenter:
					point.X = base.Width / 2 - this._ImageBounds.X;
					point.Y = base.Height / 2 - this._ImageBounds.Y;
					break;
				case ZoomPictureBox.ZoomType.ImageCenter:
					point.X = this._ImageBounds.Width / 2;
					point.Y = this._ImageBounds.Height / 2;
					break;
				default:
					return Point.Empty;
				}
				return point;
			}
		}

		// Token: 0x04000B60 RID: 2912
		private IContainer components;

		// Token: 0x04000B61 RID: 2913
		public int MouseWheelDivisor;

		// Token: 0x04000B62 RID: 2914
		public int MinimumImageWidth;

		// Token: 0x04000B63 RID: 2915
		public int MinimumImageHeight;

		// Token: 0x04000B64 RID: 2916
		public double MaximumZoomFactor;

		// Token: 0x04000B65 RID: 2917
		public bool EnableMouseWheelZooming;

		// Token: 0x04000B66 RID: 2918
		public bool EnableMouseDragging;

		// Token: 0x04000B67 RID: 2919
		private Rectangle _ImageBounds;

		// Token: 0x04000B68 RID: 2920
		private double _ZoomFactor;

		// Token: 0x04000B69 RID: 2921
		private Image _Image;

		// Token: 0x04000B6A RID: 2922
		private Point _startDrag;

		// Token: 0x04000B6B RID: 2923
		private bool _dragging;

		// Token: 0x04000B6C RID: 2924
		private ZoomPictureBox.ZoomType _ZoomMode;

		// Token: 0x020000B3 RID: 179
		public enum ZoomType
		{
			// Token: 0x04000B6E RID: 2926
			MousePosition,
			// Token: 0x04000B6F RID: 2927
			ControlCenter,
			// Token: 0x04000B70 RID: 2928
			ImageCenter
		}
	}
}
