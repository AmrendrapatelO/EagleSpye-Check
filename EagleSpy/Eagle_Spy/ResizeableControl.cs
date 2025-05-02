using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Eagle_Spy
{
	// Token: 0x0200009A RID: 154
	public class ResizeableControl
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00004A2A File Offset: 0x00002C2A
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x000CB694 File Offset: 0x000C9894
		internal Control mControl
		{
			[CompilerGenerated]
			get
			{
				return this._mControl;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler mouseEventHandler = new MouseEventHandler(this.mControl_MouseDown);
				MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.mControl_MouseUp);
				MouseEventHandler mouseEventHandler3 = new MouseEventHandler(this.mControl_MouseMove);
				EventHandler eventHandler = new EventHandler(this.mControl_MouseLeave);
				Control control = this._mControl;
				if (control != null)
				{
					control.MouseDown -= mouseEventHandler;
					control.MouseUp -= mouseEventHandler2;
					control.MouseMove -= mouseEventHandler3;
					control.MouseLeave -= eventHandler;
				}
				this._mControl = value;
				control = this._mControl;
				if (control != null)
				{
					control.MouseDown += mouseEventHandler;
					control.MouseUp += mouseEventHandler2;
					control.MouseMove += mouseEventHandler3;
					control.MouseLeave += eventHandler;
				}
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00004A32 File Offset: 0x00002C32
		public ResizeableControl(Control Control)
		{
			this.mMouseDown = false;
			this.mEdge = ResizeableControl.EdgeEnum.None;
			this.mWidth = 4;
			this.mOutlineDrawn = false;
			this.mControl = Control;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00004A5D File Offset: 0x00002C5D
		private void mControl_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.mMouseDown = true;
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00004A73 File Offset: 0x00002C73
		private void mControl_MouseUp(object sender, MouseEventArgs e)
		{
			this.mMouseDown = false;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000CB734 File Offset: 0x000C9934
		private void mControl_MouseMove(object sender, MouseEventArgs e)
		{
			Control control = (Control)sender;
			Graphics graphics = control.CreateGraphics();
			checked
			{
				switch (this.mEdge)
				{
				case ResizeableControl.EdgeEnum.None:
					if (this.mOutlineDrawn)
					{
						control.Refresh();
						this.mOutlineDrawn = false;
					}
					break;
				case ResizeableControl.EdgeEnum.Right:
					graphics.FillRectangle(Brushes.RoyalBlue, control.Width - this.mWidth, 0, control.Width, control.Height);
					this.mOutlineDrawn = true;
					break;
				case ResizeableControl.EdgeEnum.Left:
					graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, this.mWidth, control.Height);
					this.mOutlineDrawn = true;
					break;
				case ResizeableControl.EdgeEnum.Top:
					graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, control.Width, this.mWidth);
					this.mOutlineDrawn = true;
					break;
				case ResizeableControl.EdgeEnum.Bottom:
					graphics.FillRectangle(Brushes.RoyalBlue, 0, control.Height - this.mWidth, control.Width, this.mWidth);
					this.mOutlineDrawn = true;
					break;
				case ResizeableControl.EdgeEnum.TopLeft:
					graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, this.mWidth * 4, this.mWidth * 4);
					this.mOutlineDrawn = true;
					break;
				}
				if (this.mMouseDown & (this.mEdge > ResizeableControl.EdgeEnum.None))
				{
					control.SuspendLayout();
					switch (this.mEdge)
					{
					case ResizeableControl.EdgeEnum.Right:
						control.SetBounds(control.Left, control.Top, control.Width - (control.Width - e.X), control.Height);
						break;
					case ResizeableControl.EdgeEnum.Left:
						control.SetBounds(control.Left + e.X, control.Top, control.Width - e.X, control.Height);
						break;
					case ResizeableControl.EdgeEnum.Top:
						control.SetBounds(control.Left, control.Top + e.Y, control.Width, control.Height - e.Y);
						break;
					case ResizeableControl.EdgeEnum.Bottom:
						control.SetBounds(control.Left, control.Top, control.Width, control.Height - (control.Height - e.Y));
						break;
					case ResizeableControl.EdgeEnum.TopLeft:
						control.SetBounds(control.Left + e.X, control.Top + e.Y, control.Width, control.Height);
						break;
					}
					control.ResumeLayout();
					return;
				}
				bool flag = true;
				if ((e.X <= this.mWidth * 4) & (e.Y <= this.mWidth * 4))
				{
					control.Cursor = Cursors.SizeAll;
					this.mEdge = ResizeableControl.EdgeEnum.TopLeft;
					return;
				}
				if (flag == e.X <= this.mWidth)
				{
					control.Cursor = Cursors.VSplit;
					this.mEdge = ResizeableControl.EdgeEnum.Left;
					return;
				}
				if (flag == e.X > control.Width - (this.mWidth + 1))
				{
					control.Cursor = Cursors.VSplit;
					this.mEdge = ResizeableControl.EdgeEnum.Right;
					return;
				}
				if (flag == e.Y <= this.mWidth)
				{
					control.Cursor = Cursors.HSplit;
					this.mEdge = ResizeableControl.EdgeEnum.Top;
					return;
				}
				if (flag == e.Y > control.Height - (this.mWidth + 1))
				{
					control.Cursor = Cursors.HSplit;
					this.mEdge = ResizeableControl.EdgeEnum.Bottom;
					return;
				}
				control.Cursor = Cursors.Default;
				this.mEdge = ResizeableControl.EdgeEnum.None;
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000CBA90 File Offset: 0x000C9C90
		private void mControl_MouseLeave(object sender, EventArgs e)
		{
			Control control = (Control)sender;
			this.mEdge = ResizeableControl.EdgeEnum.None;
			control.Refresh();
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000CBAB4 File Offset: 0x000C9CB4
		internal static string LOAD_IMAGES(string v)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = new byte[32];
			byte[] array2 = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(v));
			Array.Copy(array2, 0, array, 0, 16);
			Array.Copy(array2, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array3 = Convert.FromBase64String("HCiHZ9y2uvml4p66X/Hqxw==");
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array3, 0, array3.Length));
		}

		// Token: 0x0400098C RID: 2444
		private bool mMouseDown;

		// Token: 0x0400098D RID: 2445
		public ResizeableControl.EdgeEnum mEdge;

		// Token: 0x0400098E RID: 2446
		private int mWidth;

		// Token: 0x0400098F RID: 2447
		private bool mOutlineDrawn;

		// Token: 0x0200009B RID: 155
		public enum EdgeEnum
		{
			// Token: 0x04000991 RID: 2449
			None,
			// Token: 0x04000992 RID: 2450
			Right,
			// Token: 0x04000993 RID: 2451
			Left,
			// Token: 0x04000994 RID: 2452
			Top,
			// Token: 0x04000995 RID: 2453
			Bottom,
			// Token: 0x04000996 RID: 2454
			TopLeft
		}
	}
}
