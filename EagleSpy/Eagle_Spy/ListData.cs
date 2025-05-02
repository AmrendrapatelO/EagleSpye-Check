using System;
using System.Net.Sockets;
using System.Threading;
using Eagle_Spy.sockets;

namespace Eagle_Spy
{
	// Token: 0x0200007A RID: 122
	public sealed class ListData
	{
		// Token: 0x06000704 RID: 1796 RVA: 0x00004601 File Offset: 0x00002801
		public ListData(Client ParametersClient, byte[] ParametersByte, object[] ParametersObject, TcpClient ParametersTcpClient)
		{
			this.WaitDataHandler = new ManualResetEvent(false);
			this.wait = false;
			this.ClassClient = ParametersClient;
			this.bByte = ParametersByte;
			this.SizeData = ParametersObject;
			this.TcpClient = ParametersTcpClient;
		}

		// Token: 0x04000843 RID: 2115
		public bool wait;

		// Token: 0x04000844 RID: 2116
		public ManualResetEvent WaitDataHandler;

		// Token: 0x04000845 RID: 2117
		public byte[] bByte;

		// Token: 0x04000846 RID: 2118
		public Client ClassClient;

		// Token: 0x04000847 RID: 2119
		public object[] SizeData;

		// Token: 0x04000848 RID: 2120
		public TcpClient TcpClient;
	}
}
