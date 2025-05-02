using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200005E RID: 94
	[DesignerGenerated]
	public partial class EditSocket : Form
	{
		// Token: 0x060005E3 RID: 1507 RVA: 0x00003C7C File Offset: 0x00001E7C
		public EditSocket()
		{
			base.Load += this.EditSocket_Load;
			this.RectInputText0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0008BD10 File Offset: 0x00089F10
		private void SpyStyle()
		{
			this.po.BackColor = SpySettings.DefaultColor_Background;
			this.po.ForeColor = SpySettings.DefaultColor_Foreground;
			checked
			{
				this.RectInputText0.Add(new Rectangle(this.po.Location.X - 1, this.po.Location.Y - 1, this.po.Width + 1, this.po.Height + 1));
				foreach (DataGridView dataGridView in this.PanelBOX.Controls.OfType<DataGridView>())
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
				foreach (Label label in this.PanelBOX.Controls.OfType<Label>())
				{
					label.ForeColor = SpySettings.DefaultColor_Foreground;
				}
				foreach (Button button in this.PanelBOX.Controls.OfType<Button>())
				{
					button.BackColor = SpySettings.DefaultColor_Foreground;
					button.ForeColor = SpySettings.DefaultColor_Background;
				}
				foreach (TextBox textBox in this.PanelBOX.Controls.OfType<TextBox>())
				{
					textBox.BackColor = SpySettings.DefaultColor_Background;
					textBox.ForeColor = SpySettings.DefaultColor_Foreground;
					this.RectInputText0.Add(new Rectangle(textBox.Location.X - 1, textBox.Location.Y - 1, textBox.Width + 1, textBox.Height + 1));
				}
				foreach (Panel panel in base.Controls.OfType<Panel>())
				{
					panel.BackColor = SpySettings.DefaultColor_Background;
				}
				this.Refresh();
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00003CB2 File Offset: 0x00001EB2
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0008BFEC File Offset: 0x0008A1EC
		private void EditSocket_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
			this.SpyStyle();
			this.TextIP.Text = Codes.GetIPAddress();
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0008C048 File Offset: 0x0008A248
		private void b_Add_Click(object sender, EventArgs e)
		{
			this.DGV0.Rows.Add(new object[] { this.TextIP.Text + ":" + Conversions.ToString(this.po.Value) });
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0008C094 File Offset: 0x0008A294
		private void b_del_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
					}
				}
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00003CE8 File Offset: 0x00001EE8
		private void btnUp_Click(object sender, EventArgs e)
		{
			this.Rowinsert(false);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00003CF1 File Offset: 0x00001EF1
		private void btnDown_Click(object sender, EventArgs e)
		{
			this.Rowinsert(true);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0008C0FC File Offset: 0x0008A2FC
		private void Rowinsert(bool isDown)
		{
			if (!((this.DGV0.SelectedRows.Count == 1) & (this.DGV0.Rows.Count != 1)))
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Value);
					if (isDown)
					{
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
						this.DGV0.Rows.Insert(this.DGV0.SelectedRows[i].Index + 1, new object[] { text });
						this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index + 1].Cells[0];
					}
					else if (this.DGV0.SelectedRows[i].Index != 0)
					{
						this.DGV0.Rows.Insert(this.DGV0.SelectedRows[i].Index - 1, new object[] { text });
						this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index - 1].Cells[0];
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index + 1);
						this.DGV0.CurrentCell = this.DGV0.Rows[this.DGV0.SelectedRows[i].Index - 1].Cells[0];
					}
				}
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000024CF File Offset: 0x000006CF
		private void OKY_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0008C32C File Offset: 0x0008A52C
		private void PanelBOX_Paint(object sender, PaintEventArgs e)
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

		// Token: 0x0400063C RID: 1596
		private List<Rectangle> RectInputText0;
	}
}
