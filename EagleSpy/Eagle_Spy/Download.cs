﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000040 RID: 64
	[DesignerGenerated]
	public partial class Download : Form
	{
		// Token: 0x06000447 RID: 1095 RVA: 0x00058564 File Offset: 0x00056764
		public Download()
		{
			base.Load += this.Download_Load;
			base.Closing += this.Download_Closing;
			this.FileStream = null;
			this._stream = 0L;
			this.xName = "null";
			this.Title = "null";
			this.InitializeComponent();
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00058A64 File Offset: 0x00056C64
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

		// Token: 0x0600044B RID: 1099 RVA: 0x000034B8 File Offset: 0x000016B8
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00058B28 File Offset: 0x00056D28
		private void Download_Load(object sender, EventArgs e)
		{
			base.Location = checked(new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height));
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\7.ico");
			this.SpyStyle();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
			this.DGV0.DefaultCellStyle.Font = reso.f;
			this.TimeFinish.Interval = 1000;
			this.TimeFinish.Enabled = true;
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00058C00 File Offset: 0x00056E00
		private void Download_Closing(object sender, CancelEventArgs e)
		{
			this.TimeFinish.Enabled = false;
			if (this.classClient != null)
			{
				this.classClient.qit = true;
				this.classClient.Close(this.Client);
			}
			if (this.FileStream != null)
			{
				this.FileStream.Dispose();
				this.FileStream.Close();
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00058C5C File Offset: 0x00056E5C
		private void TimeFinish_Tick(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.Rows.Count > 0 && this._stream <= this.TotalSize && this._stream > 0L)
				{
					this.stop_time = DateAndTime.Now;
					this.elapsed_time = this.stop_time.Subtract(this.start_time);
					long num = (long)Math.Round(unchecked((double)(checked(this.TotalSize - this._stream)) * this.elapsed_time.TotalSeconds) / (double)this._stream);
					string text = Codes.ToTime(num);
					if (!text.Equals("0:0:0"))
					{
						DateTime dateTime = DateTime.Now;
						DateTime dateTime2 = Convert.ToDateTime(text);
						dateTime = dateTime.AddHours((double)dateTime2.Hour).AddMinutes((double)dateTime2.Minute).AddSeconds((double)dateTime2.Second);
						this.DGV0.Rows[3].Cells[1].Value = "[" + text + "]";
					}
				}
			}
		}

		// Token: 0x04000398 RID: 920
		public TcpClient Client;

		// Token: 0x04000399 RID: 921
		public Client classClient;

		// Token: 0x0400039A RID: 922
		public FileStream FileStream;

		// Token: 0x0400039B RID: 923
		public long _stream;

		// Token: 0x0400039C RID: 924
		public string xName;

		// Token: 0x0400039D RID: 925
		public long TotalSize;

		// Token: 0x0400039E RID: 926
		public TimeSpan elapsed_time;

		// Token: 0x0400039F RID: 927
		public DateTime start_time;

		// Token: 0x040003A0 RID: 928
		public DateTime stop_time;

		// Token: 0x040003A1 RID: 929
		public string DownFolder;

		// Token: 0x040003A2 RID: 930
		public string Title;
	}
}
