using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200000C RID: 12
[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
internal class Eagle_Spy_Settings
{
	// Token: 0x17000168 RID: 360
	// (get) Token: 0x0600017C RID: 380 RVA: 0x0000AD48 File Offset: 0x00008F48
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Eagle_Spy_Settings.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Eagle_Spy.Settings", typeof(Eagle_Spy_Settings).Assembly);
				Eagle_Spy_Settings.resourceMan = resourceManager;
			}
			return Eagle_Spy_Settings.resourceMan;
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x0600017D RID: 381 RVA: 0x0000235C File Offset: 0x0000055C
	// (set) Token: 0x0600017E RID: 382 RVA: 0x00002363 File Offset: 0x00000563
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Eagle_Spy_Settings.resourceCulture;
		}
		set
		{
			Eagle_Spy_Settings.resourceCulture = value;
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x0600017F RID: 383 RVA: 0x0000AD84 File Offset: 0x00008F84
	internal static Bitmap DataGridViewCellStyle10_NullValue
	{
		get
		{
			object @object = Eagle_Spy_Settings.ResourceManager.GetObject("DataGridViewCellStyle10.NullValue", Eagle_Spy_Settings.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x06000180 RID: 384 RVA: 0x0000207B File Offset: 0x0000027B
	internal Eagle_Spy_Settings()
	{
	}

	// Token: 0x04000015 RID: 21
	private static ResourceManager resourceMan;

	// Token: 0x04000016 RID: 22
	private static CultureInfo resourceCulture;
}
