using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200006F RID: 111
	[DesignerGenerated]
	public partial class inp : Form
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x000B14B4 File Offset: 0x000AF6B4
		private void translateme()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.CheckHidden.Text = Codes.Translate(this.CheckHidden.Text, "en", "zh");
					this.CheckFolder.Text = Codes.Translate(this.CheckFolder.Text, "en", "zh");
					return;
				}
			}
			else
			{
				this.CheckHidden.Text = Codes.Translate(this.CheckHidden.Text, "en", "ar");
				this.CheckFolder.Text = Codes.Translate(this.CheckFolder.Text, "en", "ar");
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000040BA File Offset: 0x000022BA
		public inp()
		{
			base.Load += this.inp_Load;
			this.RectInputText0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000040F0 File Offset: 0x000022F0
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00004126 File Offset: 0x00002326
		private void inp_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
			this.translateme();
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000024CF File Offset: 0x000006CF
		private void b_ok_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000B157C File Offset: 0x000AF77C
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

		// Token: 0x06000697 RID: 1687 RVA: 0x000024CF File Offset: 0x000006CF
		private void B_ok_Click_1(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x04000773 RID: 1907
		private List<Rectangle> RectInputText0;
	}
}
