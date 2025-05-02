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
	// Token: 0x0200006B RID: 107
	[DesignerGenerated]
	public partial class Icons : Form
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x00003F4F File Offset: 0x0000214F
		public Icons()
		{
			base.Load += this.Icons_Load;
			this.InitializeComponent();
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x000ADFBC File Offset: 0x000AC1BC
		private void SpyStyle()
		{
			foreach (DataGridView dataGridView in base.Controls.OfType<DataGridView>())
			{
				dataGridView.BackgroundColor = SpySettings.DefaultColor_Background;
				dataGridView.BackColor = SpySettings.DefaultColor_Background;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
				dataGridView.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background;
				dataGridView.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background;
				dataGridView.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
				dataGridView.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground;
				dataGridView.Columns[0].DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Background;
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00003F6F File Offset: 0x0000216F
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000AE0A0 File Offset: 0x000AC2A0
		private void Icons_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\4.ico");
			this.SpyStyle();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
			this.DGV0.DefaultCellStyle.Font = reso.f;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00003CFA File Offset: 0x00001EFA
		private void DGV0_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (e.RowIndex1 == 0)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00003FA5 File Offset: 0x000021A5
		private void DGV0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				this.id = e.RowIndex;
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002423 File Offset: 0x00000623
		private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x04000735 RID: 1845
		public int id;
	}
}
