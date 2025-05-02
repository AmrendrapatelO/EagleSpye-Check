using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000029 RID: 41
	[DesignerGenerated]
	public partial class CallPhone : Form
	{
		// Token: 0x06000329 RID: 809 RVA: 0x0004C62C File Offset: 0x0004A82C
		public CallPhone()
		{
			base.Load += this.CallPhone_Load;
			this._keyback = false;
			this._Call = "call";
			this.Title = "null";
			this.RectInputText0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002D58 File Offset: 0x00000F58
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0004C68C File Offset: 0x0004A88C
		private void CallPhone_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\18.ico");
			this.TextBox1.ContextMenuStrip = this.CMenu;
			int fontSize = MySettingsProperty.Settings.FontSize;
			if (CallPhone.IsFontInstalled("Wingdings 3"))
			{
				this.b_DEL.Font = new Font("Wingdings 3", (float)fontSize, FontStyle.Regular);
				this.b_DEL.Text = "…";
			}
			else
			{
				this.b_DEL.Text = "<";
			}
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0004C734 File Offset: 0x0004A934
		public static bool IsFontInstalled(string FontName)
		{
			bool flag;
			using (Font font = new Font(FontName, 10f))
			{
				flag = string.Compare(FontName, font.Name, StringComparison.InvariantCultureIgnoreCase) == 0;
			}
			return flag;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0004C77C File Offset: 0x0004A97C
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
			if (this.RectInputText0.Count <= 0)
			{
				return;
			}
			foreach (Rectangle rectangle in this.RectInputText0)
			{
				if (rectangle.Width > 0)
				{
					e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), rectangle);
				}
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002D8E File Offset: 0x00000F8E
		private void b1_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "1";
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002DAB File Offset: 0x00000FAB
		private void b2_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "2";
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002DC8 File Offset: 0x00000FC8
		private void b3_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "3";
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002DE5 File Offset: 0x00000FE5
		private void b4_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "4";
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002E02 File Offset: 0x00001002
		private void b5_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "5";
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002E1F File Offset: 0x0000101F
		private void b6_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "6";
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002E3C File Offset: 0x0000103C
		private void b7_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "7";
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002E59 File Offset: 0x00001059
		private void b8_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "8";
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002E76 File Offset: 0x00001076
		private void b9_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "9";
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002E93 File Offset: 0x00001093
		private void b0_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "0";
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0004C808 File Offset: 0x0004AA08
		private void b_DEL_Click(object sender, EventArgs e)
		{
			if (this.TextBox1.Text.Length > 0)
			{
				this.TextBox1.Text = this.TextBox1.Text.Remove(checked(this.TextBox1.Text.Length - 1));
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002EB0 File Offset: 0x000010B0
		private void B_star_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "*";
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002ECD File Offset: 0x000010CD
		private void B_hash_Click(object sender, EventArgs e)
		{
			TextBox textBox = this.TextBox1;
			textBox.Text += "#";
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002423 File Offset: 0x00000623
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002423 File Offset: 0x00000623
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0004C858 File Offset: 0x0004AA58
		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this._keyback)
			{
				e.Handled = false;
				return;
			}
			string text = "0123456789,*#+";
			if (!text.Contains(e.KeyChar.ToString()))
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002EEA File Offset: 0x000010EA
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Back)
			{
				this._keyback = true;
				return;
			}
			this._keyback = false;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002F04 File Offset: 0x00001104
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TextBox1.Cut();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002F11 File Offset: 0x00001111
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TextBox1.Copy();
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0004C898 File Offset: 0x0004AA98
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = "0123456789,*#+";
			if (MyProject.Computer.Clipboard.ContainsText())
			{
				string text2 = MyProject.Computer.Clipboard.GetText();
				if (text2.Length <= 1500)
				{
					string text3 = text2;
					string text4 = text3;
					foreach (char c in text4)
					{
						if (!text.ToString().Contains(Conversions.ToString(c)))
						{
							return;
						}
					}
				}
			}
			this.TextBox1.Paste();
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002F1E File Offset: 0x0000111E
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			this._Call = "call";
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002F1E File Offset: 0x0000111E
		private void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			this._Call = "call";
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x0400029F RID: 671
		private bool _keyback;

		// Token: 0x040002A0 RID: 672
		public string _Call;

		// Token: 0x040002A1 RID: 673
		public string Title;

		// Token: 0x040002A2 RID: 674
		private List<Rectangle> RectInputText0;
	}
}
