using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000090 RID: 144
	[StandardModule]
	internal sealed class RefreshExplorer
	{
		// Token: 0x060007D4 RID: 2004
		[DllImport("shell32.dll")]
		public static extern void SHChangeNotify(RefreshExplorer.HChangeNotifyEventID wEventID, RefreshExplorer.HChangeNotifyFlags uFlags, IntPtr dwItem1, IntPtr dwItem2);

		// Token: 0x060007D5 RID: 2005 RVA: 0x00004913 File Offset: 0x00002B13
		public static void EnvRefresh()
		{
			RefreshExplorer.SHChangeNotify(RefreshExplorer.HChangeNotifyEventID.SHCNE_ASSOCCHANGED, RefreshExplorer.HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
		}

		// Token: 0x02000091 RID: 145
		[Flags]
		public enum HChangeNotifyFlags
		{
			// Token: 0x04000945 RID: 2373
			SHCNF_DWORD = 3,
			// Token: 0x04000946 RID: 2374
			SHCNF_IDLIST = 0,
			// Token: 0x04000947 RID: 2375
			SHCNF_PATHA = 1,
			// Token: 0x04000948 RID: 2376
			SHCNF_PATHW = 5,
			// Token: 0x04000949 RID: 2377
			SHCNF_PRINTERA = 2,
			// Token: 0x0400094A RID: 2378
			SHCNF_PRINTERW = 6,
			// Token: 0x0400094B RID: 2379
			SHCNF_FLUSH = 4096,
			// Token: 0x0400094C RID: 2380
			SHCNF_FLUSHNOWAIT = 8192
		}

		// Token: 0x02000092 RID: 146
		[Flags]
		public enum HChangeNotifyEventID
		{
			// Token: 0x0400094E RID: 2382
			SHCNE_ALLEVENTS = 2147483647,
			// Token: 0x0400094F RID: 2383
			SHCNE_ASSOCCHANGED = 134217728,
			// Token: 0x04000950 RID: 2384
			SHCNE_ATTRIBUTES = 2048,
			// Token: 0x04000951 RID: 2385
			SHCNE_CREATE = 2,
			// Token: 0x04000952 RID: 2386
			SHCNE_DELETE = 4,
			// Token: 0x04000953 RID: 2387
			SHCNE_DRIVEADD = 16,
			// Token: 0x04000954 RID: 2388
			SHCNE_DRIVEADDGUI = 65536,
			// Token: 0x04000955 RID: 2389
			SHCNE_DRIVEREMOVED = 128,
			// Token: 0x04000956 RID: 2390
			SHCNE_EXTENDED_EVENT = 67108864,
			// Token: 0x04000957 RID: 2391
			SHCNE_FREESPACE = 262144,
			// Token: 0x04000958 RID: 2392
			SHCNE_MEDIAINSERTED = 32,
			// Token: 0x04000959 RID: 2393
			SHCNE_MEDIAREMOVED = 64,
			// Token: 0x0400095A RID: 2394
			SHCNE_MKDIR = 8,
			// Token: 0x0400095B RID: 2395
			SHCNE_NETSHARE = 512,
			// Token: 0x0400095C RID: 2396
			SHCNE_NETUNSHARE = 1024,
			// Token: 0x0400095D RID: 2397
			SHCNE_RENAMEFOLDER = 131072,
			// Token: 0x0400095E RID: 2398
			SHCNE_RENAMEITEM = 1,
			// Token: 0x0400095F RID: 2399
			SHCNE_RMDIR = 16,
			// Token: 0x04000960 RID: 2400
			SHCNE_SERVERDISCONNECT = 16384,
			// Token: 0x04000961 RID: 2401
			SHCNE_UPDATEDIR = 4096,
			// Token: 0x04000962 RID: 2402
			SHCNE_UPDATEIMAGE = 32768
		}
	}
}
