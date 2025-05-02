using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000003 RID: 3
[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
internal class Eagle_Spy_Build
{
	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000986C File Offset: 0x00007A6C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Eagle_Spy_Build.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Eagle_Spy.Build", typeof(Eagle_Spy_Build).Assembly);
				Eagle_Spy_Build.resourceMan = resourceManager;
			}
			return Eagle_Spy_Build.resourceMan;
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002083 File Offset: 0x00000283
	// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000208A File Offset: 0x0000028A
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Eagle_Spy_Build.resourceCulture;
		}
		set
		{
			Eagle_Spy_Build.resourceCulture = value;
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x000098A8 File Offset: 0x00007AA8
	internal static Bitmap cusomupdateimg_Image
	{
		get
		{
			object @object = Eagle_Spy_Build.ResourceManager.GetObject("cusomupdateimg.Image", Eagle_Spy_Build.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060000C9 RID: 201 RVA: 0x000098D0 File Offset: 0x00007AD0
	internal static Bitmap PictureBox2_Image
	{
		get
		{
			object @object = Eagle_Spy_Build.ResourceManager.GetObject("PictureBox2.Image", Eagle_Spy_Build.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x060000CA RID: 202 RVA: 0x0000207B File Offset: 0x0000027B
	internal Eagle_Spy_Build()
	{
	}

	// Token: 0x04000003 RID: 3
	private static ResourceManager resourceMan;

	// Token: 0x04000004 RID: 4
	private static CultureInfo resourceCulture;
}
