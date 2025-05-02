using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000079 RID: 121
	[DesignerGenerated]
	public partial class LanguageSelector : Form
	{
		// Token: 0x060006FD RID: 1789 RVA: 0x0000459D File Offset: 0x0000279D
		public LanguageSelector()
		{
			base.Load += this.LanguageSelector_Load;
			this.SelectedLang = "";
			this.InitializeComponent();
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000045C8 File Offset: 0x000027C8
		private void Copydev_Click(object sender, EventArgs e)
		{
			this.SelectedLang = "AR";
			base.Close();
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000045DB File Offset: 0x000027DB
		private void DrakeUIButton1_Click(object sender, EventArgs e)
		{
			this.SelectedLang = "EN";
			base.Close();
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000045EE File Offset: 0x000027EE
		private void DrakeUIButton2_Click(object sender, EventArgs e)
		{
			this.SelectedLang = "CN";
			base.Close();
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00002423 File Offset: 0x00000623
		private void LanguageSelector_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400083A RID: 2106
		public string SelectedLang;
	}
}
