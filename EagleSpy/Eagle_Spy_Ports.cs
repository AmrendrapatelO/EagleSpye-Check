using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000009 RID: 9
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
internal class Eagle_Spy_Ports
{
	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000114 RID: 276 RVA: 0x0000A26C File Offset: 0x0000846C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Eagle_Spy_Ports.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Eagle_Spy.Ports", typeof(Eagle_Spy_Ports).Assembly);
				Eagle_Spy_Ports.resourceMan = resourceManager;
			}
			return Eagle_Spy_Ports.resourceMan;
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000115 RID: 277 RVA: 0x000020DD File Offset: 0x000002DD
	// (set) Token: 0x06000116 RID: 278 RVA: 0x000020E4 File Offset: 0x000002E4
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Eagle_Spy_Ports.resourceCulture;
		}
		set
		{
			Eagle_Spy_Ports.resourceCulture = value;
		}
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000207B File Offset: 0x0000027B
	internal Eagle_Spy_Ports()
	{
	}

	// Token: 0x0400000F RID: 15
	private static ResourceManager resourceMan;

	// Token: 0x04000010 RID: 16
	private static CultureInfo resourceCulture;
}
