using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.My
{
	// Token: 0x020000DC RID: 220
	[HideModuleName]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[StandardModule]
	internal sealed class MySettingsProperty
	{
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x000070E6 File Offset: 0x000052E6
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
