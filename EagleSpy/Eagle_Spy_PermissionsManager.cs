using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x02000008 RID: 8
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
internal class Eagle_Spy_PermissionsManager
{
	// Token: 0x17000102 RID: 258
	// (get) Token: 0x0600010E RID: 270 RVA: 0x0000A1E0 File Offset: 0x000083E0
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Eagle_Spy_PermissionsManager.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Eagle_Spy.PermissionsManager", typeof(Eagle_Spy_PermissionsManager).Assembly);
				Eagle_Spy_PermissionsManager.resourceMan = resourceManager;
			}
			return Eagle_Spy_PermissionsManager.resourceMan;
		}
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x0600010F RID: 271 RVA: 0x000020CE File Offset: 0x000002CE
	// (set) Token: 0x06000110 RID: 272 RVA: 0x000020D5 File Offset: 0x000002D5
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Eagle_Spy_PermissionsManager.resourceCulture;
		}
		set
		{
			Eagle_Spy_PermissionsManager.resourceCulture = value;
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000111 RID: 273 RVA: 0x0000A21C File Offset: 0x0000841C
	internal static Bitmap PictureBox1_Image
	{
		get
		{
			object @object = Eagle_Spy_PermissionsManager.ResourceManager.GetObject("PictureBox1.Image", Eagle_Spy_PermissionsManager.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000112 RID: 274 RVA: 0x0000A244 File Offset: 0x00008444
	internal static Bitmap PictureBox2_Image
	{
		get
		{
			object @object = Eagle_Spy_PermissionsManager.ResourceManager.GetObject("PictureBox2.Image", Eagle_Spy_PermissionsManager.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000207B File Offset: 0x0000027B
	internal Eagle_Spy_PermissionsManager()
	{
	}

	// Token: 0x0400000D RID: 13
	private static ResourceManager resourceMan;

	// Token: 0x0400000E RID: 14
	private static CultureInfo resourceCulture;
}
