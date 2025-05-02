using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200000B RID: 11
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Eagle_Spy_ScreenShoter
{
	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000177 RID: 375 RVA: 0x0000ACE4 File Offset: 0x00008EE4
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Eagle_Spy_ScreenShoter.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Eagle_Spy.ScreenShoter", typeof(Eagle_Spy_ScreenShoter).Assembly);
				Eagle_Spy_ScreenShoter.resourceMan = resourceManager;
			}
			return Eagle_Spy_ScreenShoter.resourceMan;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000178 RID: 376 RVA: 0x0000234D File Offset: 0x0000054D
	// (set) Token: 0x06000179 RID: 377 RVA: 0x00002354 File Offset: 0x00000554
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Eagle_Spy_ScreenShoter.resourceCulture;
		}
		set
		{
			Eagle_Spy_ScreenShoter.resourceCulture = value;
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x0600017A RID: 378 RVA: 0x0000AD20 File Offset: 0x00008F20
	internal static Bitmap Panel6_BackgroundImage
	{
		get
		{
			object @object = Eagle_Spy_ScreenShoter.ResourceManager.GetObject("Panel6.BackgroundImage", Eagle_Spy_ScreenShoter.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000207B File Offset: 0x0000027B
	internal Eagle_Spy_ScreenShoter()
	{
	}

	// Token: 0x04000013 RID: 19
	private static ResourceManager resourceMan;

	// Token: 0x04000014 RID: 20
	private static CultureInfo resourceCulture;
}
