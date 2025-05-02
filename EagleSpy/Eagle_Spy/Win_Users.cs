using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x020000B1 RID: 177
	[DesignerGenerated]
	public partial class Win_Users : Form
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x0000525B File Offset: 0x0000345B
		public Win_Users()
		{
			base.Load += this.Win_Users_Load;
			base.Closing += this.Win_Users_Closing;
			this.InitializeComponent();
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000E743C File Offset: 0x000E563C
		private void Win_Users_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\1.ico");
			this.DGV0.ContextMenuStrip = this.ctxz;
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
			this.DGV0.DefaultCellStyle.Font = reso.f;
			this.SpyStyle();
			this.MYTEXT();
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00058A64 File Offset: 0x00056C64
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
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0000528D File Offset: 0x0000348D
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000052C3 File Offset: 0x000034C3
		private void Win_Users_Closing(object sender, CancelEventArgs e)
		{
			MyProject.Forms.CraxsRatMain.WU = null;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002423 File Offset: 0x00000623
		private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000052D5 File Offset: 0x000034D5
		public void MYTEXT()
		{
			this.Text = "Users (" + Conversions.ToString(this.DGV0.Rows.Count) + ")";
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000E74C8 File Offset: 0x000E56C8
		private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (this.DGV0.Rows.Count > 0 && e.RowIndex != -1)
			{
				string text = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[2].Value);
				string text2 = reso.res_Path + "\\Users\\" + text;
				if (Directory.Exists(text2))
				{
					Process.Start(text2);
					return;
				}
				this.DGV0.Rows.RemoveAt(e.RowIndex);
				this.MYTEXT();
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000E755C File Offset: 0x000E575C
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
					string text2 = reso.res_Path + "\\Users\\" + text;
					if (Directory.Exists(text2))
					{
						Process.Start(text2);
					}
					else
					{
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
						this.MYTEXT();
					}
				}
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000E762C File Offset: 0x000E582C
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value);
					string text2 = reso.res_Path + "\\Users\\" + text;
					this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
					this.MYTEXT();
					if (Directory.Exists(text2))
					{
						try
						{
							Directory.Delete(text2, true);
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
	}
}
