using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200003D RID: 61
	[DesignerGenerated]
	public partial class Dialog1 : Form
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x000033AA File Offset: 0x000015AA
		public Dialog1()
		{
			base.Load += this.Dialog1_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002423 File Offset: 0x00000623
		private void translateme()
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002423 File Offset: 0x00000623
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000033CA File Offset: 0x000015CA
		private void Dialog1_Load(object sender, EventArgs e)
		{
			this.Mytitle.Text = this.Title;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000033DD File Offset: 0x000015DD
		private void drakeUIButtonIcon2_Click_1(object sender, EventArgs e)
		{
			this.TheText = this.Mytext.Text;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000033FD File Offset: 0x000015FD
		private void drakeUIButtonIcon1_Click_1(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x04000374 RID: 884
		public string Title;

		// Token: 0x04000375 RID: 885
		public string TheText;
	}
}
