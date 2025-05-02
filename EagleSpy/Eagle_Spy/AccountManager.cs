using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class AccountManager : Form
	{
		// Token: 0x06000190 RID: 400 RVA: 0x0000AE74 File Offset: 0x00009074
		public AccountManager()
		{
			base.Load += this.AccountManager_Load;
			base.Activated += this.AngelAndroidForm_Activated;
			base.Deactivate += this.AngelAndroidForm_Deactivate;
			this.Title = "null";
			this.BoxTitlePaintEventArgsWait = false;
			this.InitializeComponent();
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000239F File Offset: 0x0000059F
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		private void AccountManager_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\1.ico");
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

		// Token: 0x06000195 RID: 405 RVA: 0x0000C178 File Offset: 0x0000A378
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
					"Accounts",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000C248 File Offset: 0x0000A448
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
				"Account Manager",
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"Accounts",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
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

		// Token: 0x06000198 RID: 408 RVA: 0x000023D5 File Offset: 0x000005D5
		private void AngelAndroidForm_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000023D5 File Offset: 0x000005D5
		private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000023D5 File Offset: 0x000005D5
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000023D5 File Offset: 0x000005D5
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000023D5 File Offset: 0x000005D5
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000023D5 File Offset: 0x000005D5
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600019E RID: 414
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600019F RID: 415
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060001A0 RID: 416 RVA: 0x000023E2 File Offset: 0x000005E2
		private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				AccountManager.ReleaseCapture();
				AccountManager.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		private void UpdateEnglish()
		{
			this.label2.Text = "Accounts";
			this.Column1.HeaderText = "Program";
			this.Column6.HeaderText = "Account";
			this.drakeUIButtonIcon1.Text = "Save As";
			this.drakeUIButtonIcon2.Text = "Save";
			this.drakeUIButtonIcon3.Text = "Saved Folder";
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000C518 File Offset: 0x0000A718
		private void UpdateChinese()
		{
			this.label2.Text = "账户";
			this.Column1.HeaderText = "程序";
			this.Column6.HeaderText = "账号";
			this.drakeUIButtonIcon1.Text = "另存为";
			this.drakeUIButtonIcon2.Text = "保存";
			this.drakeUIButtonIcon3.Text = "保存文件夹";
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000C588 File Offset: 0x0000A788
		private void UpdateRussian()
		{
			this.label2.Text = "Аккаунты";
			this.Column1.HeaderText = "Программа";
			this.Column6.HeaderText = "Аккаунт";
			this.drakeUIButtonIcon1.Text = "Сохранить как";
			this.drakeUIButtonIcon2.Text = "Сохранить";
			this.drakeUIButtonIcon3.Text = "Папка для сохранения";
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
		private void UpdateLanguage()
		{
			string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res", "Config", "Language.inf");
			if (File.Exists(text))
			{
				string text2 = File.ReadAllText(text);
				if (text2.Contains("English"))
				{
					this.UpdateEnglish();
					return;
				}
				if (text2.Contains("Russian"))
				{
					this.UpdateRussian();
					return;
				}
				if (text2.Contains("Chinese"))
				{
					this.UpdateChinese();
					return;
				}
				this.UpdateEnglish();
			}
		}

		// Token: 0x0400001C RID: 28
		public TcpClient Client;

		// Token: 0x0400001D RID: 29
		public Client classClient;

		// Token: 0x0400001E RID: 30
		public string Title;

		// Token: 0x0400001F RID: 31
		public string tmpFolderUSER;

		// Token: 0x04000020 RID: 32
		public string tmpClientName;

		// Token: 0x04000021 RID: 33
		public string tmpCountry;

		// Token: 0x04000022 RID: 34
		public string tmpAddressIP;

		// Token: 0x04000023 RID: 35
		private bool BoxTitlePaintEventArgsWait;
	}
}
