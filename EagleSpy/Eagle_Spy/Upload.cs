using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
	// Token: 0x020000AC RID: 172
	[DesignerGenerated]
	public partial class Upload : Form
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x000DD624 File Offset: 0x000DB824
		public Upload()
		{
			base.Load += this.Upload_Load;
			base.Closing += this.Upload_Closing;
			this.FileStream = null;
			this.Upstream = 0L;
			this._stream = 0L;
			this.Title = "null";
			this.InitializeComponent();
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00058A64 File Offset: 0x00056C64
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

		// Token: 0x0600090C RID: 2316 RVA: 0x0000513C File Offset: 0x0000333C
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000DDB38 File Offset: 0x000DBD38
		private void Upload_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\16.ico");
			this.SpyStyle();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
			this.DGV0.DefaultCellStyle.Font = reso.f;
			this.TimeFinish.Interval = 100;
			this.TimeFinish.Enabled = true;
			if ((this.FileStream == null) & (this.Upstream == 0L))
			{
				this.FileStream = new FileStream(this.SPL[3], FileMode.Open, FileAccess.Read);
			}
			if (this.Bgworker == null)
			{
				this.Bgworker = new BackgroundWorker();
			}
			if (!this.Bgworker.IsBusy)
			{
				this.Bgworker.RunWorkerAsync();
			}
			else
			{
				if (this.FileStream != null)
				{
					this.FileStream.Dispose();
					this.FileStream.Close();
				}
				this.classClient.Close(this.Client);
				base.Close();
			}
			this.Progr.Interval = 10;
			this.Progr.Enabled = true;
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000DDC78 File Offset: 0x000DBE78
		private void worker_DoWork(object sender, DoWorkEventArgs e)
		{
			byte[] array = new byte[4097];
			if (this.FileStream != null)
			{
				int num;
				do
				{
					num = this.FileStream.Read(array, 0, array.Length);
					if (num > 0)
					{
						checked
						{
							try
							{
								if (this.Client.Client.Connected)
								{
									this.Client.Client.Poll(infoServer.Microseconds, SelectMode.SelectWrite);
									this.Client.Client.SendBufferSize = array.Length;
									this.Client.GetStream().Write(array, 0, num);
									this._stream += unchecked((long)num);
									this.Upstream += unchecked((long)array.Length);
									this.classClient.MyServer.BytesSent += unchecked((long)array.Length);
								}
							}
							catch (Exception)
							{
								break;
							}
						}
						if (this.Upstream == (long)Conversions.ToInteger(this.SPL[1]))
						{
							break;
						}
					}
					Thread.Sleep(1);
				}
				while (num > 0);
			}
			if (this.FileStream != null)
			{
				this.FileStream.Dispose();
				this.FileStream.Close();
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000DDD94 File Offset: 0x000DBF94
		private void Upload_Closing(object sender, CancelEventArgs e)
		{
			this.TimeFinish.Enabled = false;
			this.Progr.Enabled = false;
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
			if (this.Bgworker != null)
			{
				try
				{
					this.Bgworker.Dispose();
					this.Bgworker.CancelAsync();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000DDE30 File Offset: 0x000DC030
		private void TimeFinish_Tick(object sender, EventArgs e)
		{
			if (this.DGV0.Rows.Count <= 0)
			{
				return;
			}
			checked
			{
				if (this._stream < this.TotalSize)
				{
					if (this._stream > 0L)
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
							this.DGV0.Rows[4].Cells[1].Value = string.Format("[{0}] [{1}]", text, dateTime.ToString("h:mm:ss"));
							return;
						}
					}
				}
				else
				{
					base.Close();
				}
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00005172 File Offset: 0x00003372
		private void Progr_Tick(object sender, EventArgs e)
		{
			if ((this._stream != 0L) | (this._stream > (long)this.ProgressBar1.Maximum))
			{
				this.ProgressBar1.Value = checked((int)this._stream);
			}
		}

		// Token: 0x04000AD6 RID: 2774
		public TcpClient Client;

		// Token: 0x04000AD7 RID: 2775
		public Client classClient;

		// Token: 0x04000AD8 RID: 2776
		public FileStream FileStream;

		// Token: 0x04000AD9 RID: 2777
		public long Upstream;

		// Token: 0x04000ADA RID: 2778
		public long _stream;

		// Token: 0x04000ADB RID: 2779
		public long TotalSize;

		// Token: 0x04000ADC RID: 2780
		public TimeSpan elapsed_time;

		// Token: 0x04000ADD RID: 2781
		public DateTime start_time;

		// Token: 0x04000ADE RID: 2782
		public DateTime stop_time;

		// Token: 0x04000ADF RID: 2783
		public string[] SPL;

		// Token: 0x04000AE0 RID: 2784
		public string Title;

		// Token: 0x04000AE8 RID: 2792
		internal BackgroundWorker Bgworker;
	}
}
