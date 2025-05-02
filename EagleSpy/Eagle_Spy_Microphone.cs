using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000007 RID: 7
[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
internal class Eagle_Spy_Microphone
{
	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000109 RID: 265 RVA: 0x0000A17C File Offset: 0x0000837C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Eagle_Spy_Microphone.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Eagle_Spy.Microphone", typeof(Eagle_Spy_Microphone).Assembly);
				Eagle_Spy_Microphone.resourceMan = resourceManager;
			}
			return Eagle_Spy_Microphone.resourceMan;
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x0600010A RID: 266 RVA: 0x000020BF File Offset: 0x000002BF
	// (set) Token: 0x0600010B RID: 267 RVA: 0x000020C6 File Offset: 0x000002C6
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Eagle_Spy_Microphone.resourceCulture;
		}
		set
		{
			Eagle_Spy_Microphone.resourceCulture = value;
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x0600010C RID: 268 RVA: 0x0000A1B8 File Offset: 0x000083B8
	internal static ImageListStreamer ImageList1_ImageStream
	{
		get
		{
			object @object = Eagle_Spy_Microphone.ResourceManager.GetObject("ImageList1.ImageStream", Eagle_Spy_Microphone.resourceCulture);
			return (ImageListStreamer)@object;
		}
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0000207B File Offset: 0x0000027B
	internal Eagle_Spy_Microphone()
	{
	}

	// Token: 0x0400000B RID: 11
	private static ResourceManager resourceMan;

	// Token: 0x0400000C RID: 12
	private static CultureInfo resourceCulture;
}
