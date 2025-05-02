using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000005 RID: 5
[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
internal class Eagle_Spy_EagleSettings
{
	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060000CF RID: 207 RVA: 0x00009934 File Offset: 0x00007B34
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Eagle_Spy_EagleSettings.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Eagle_Spy.EagleSettings", typeof(Eagle_Spy_EagleSettings).Assembly);
				Eagle_Spy_EagleSettings.resourceMan = resourceManager;
			}
			return Eagle_Spy_EagleSettings.resourceMan;
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060000D0 RID: 208 RVA: 0x000020A1 File Offset: 0x000002A1
	// (set) Token: 0x060000D1 RID: 209 RVA: 0x000020A8 File Offset: 0x000002A8
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Eagle_Spy_EagleSettings.resourceCulture;
		}
		set
		{
			Eagle_Spy_EagleSettings.resourceCulture = value;
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x00009970 File Offset: 0x00007B70
	internal static Bitmap PictureBox3_Image
	{
		get
		{
			object @object = Eagle_Spy_EagleSettings.ResourceManager.GetObject("PictureBox3.Image", Eagle_Spy_EagleSettings.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060000D3 RID: 211 RVA: 0x00009998 File Offset: 0x00007B98
	internal static Bitmap PictureBox5_Image
	{
		get
		{
			object @object = Eagle_Spy_EagleSettings.ResourceManager.GetObject("PictureBox5.Image", Eagle_Spy_EagleSettings.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x060000D4 RID: 212 RVA: 0x000099C0 File Offset: 0x00007BC0
	internal static Bitmap PictureBox6_Image
	{
		get
		{
			object @object = Eagle_Spy_EagleSettings.ResourceManager.GetObject("PictureBox6.Image", Eagle_Spy_EagleSettings.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0000207B File Offset: 0x0000027B
	internal Eagle_Spy_EagleSettings()
	{
	}

	// Token: 0x04000007 RID: 7
	private static ResourceManager resourceMan;

	// Token: 0x04000008 RID: 8
	private static CultureInfo resourceCulture;
}
