using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.My
{
	// Token: 0x020000DA RID: 218
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00007010 File Offset: 0x00005210
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00007022 File Offset: 0x00005222
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public StringCollection ListBoxItems
		{
			get
			{
				return (StringCollection)this["ListBoxItems"];
			}
			set
			{
				this["ListBoxItems"] = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00007075 File Offset: 0x00005275
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00007087 File Offset: 0x00005287
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public StringCollection ListBoxTracker
		{
			get
			{
				return (StringCollection)this["ListBoxTracker"];
			}
			set
			{
				this["ListBoxTracker"] = value;
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00007095 File Offset: 0x00005295
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}
	}
}
