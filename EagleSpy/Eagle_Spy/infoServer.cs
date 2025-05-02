using System;
using System.Collections.Generic;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200006E RID: 110
	[StandardModule]
	internal sealed class infoServer
	{
		// Token: 0x0400076E RID: 1902
		public static string PORTS = string.Empty;

		// Token: 0x0400076F RID: 1903
		public static int KeySize = 8;

		// Token: 0x04000770 RID: 1904
		public static int Microseconds = -1;

		// Token: 0x04000771 RID: 1905
		public static List<Client> WorkerRemove = new List<Client>();
	}
}
