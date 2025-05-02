using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200000E RID: 14
[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
internal class Eagle_Spy_Updater
{
	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000187 RID: 391 RVA: 0x0000AE10 File Offset: 0x00009010
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Eagle_Spy_Updater.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Eagle_Spy.Updater", typeof(Eagle_Spy_Updater).Assembly);
				Eagle_Spy_Updater.resourceMan = resourceManager;
			}
			return Eagle_Spy_Updater.resourceMan;
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000188 RID: 392 RVA: 0x00002390 File Offset: 0x00000590
	// (set) Token: 0x06000189 RID: 393 RVA: 0x00002397 File Offset: 0x00000597
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Eagle_Spy_Updater.resourceCulture;
		}
		set
		{
			Eagle_Spy_Updater.resourceCulture = value;
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x0600018A RID: 394 RVA: 0x0000AE4C File Offset: 0x0000904C
	internal static Bitmap PictureBox1_Image
	{
		get
		{
			object @object = Eagle_Spy_Updater.ResourceManager.GetObject("PictureBox1.Image", Eagle_Spy_Updater.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x0600018B RID: 395 RVA: 0x0000207B File Offset: 0x0000027B
	internal Eagle_Spy_Updater()
	{
	}

	// Token: 0x04000019 RID: 25
	private static ResourceManager resourceMan;

	// Token: 0x0400001A RID: 26
	private static CultureInfo resourceCulture;
}
