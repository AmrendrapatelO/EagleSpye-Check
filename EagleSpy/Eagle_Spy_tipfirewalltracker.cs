using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200000D RID: 13
[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
internal class Eagle_Spy_tipfirewalltracker
{
	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000181 RID: 385 RVA: 0x0000ADAC File Offset: 0x00008FAC
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (Eagle_Spy_tipfirewalltracker.resourceMan == null)
			{
				ResourceManager resourceManager = new ResourceManager("Eagle_Spy.tipfirewalltracker", typeof(Eagle_Spy_tipfirewalltracker).Assembly);
				Eagle_Spy_tipfirewalltracker.resourceMan = resourceManager;
			}
			return Eagle_Spy_tipfirewalltracker.resourceMan;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000182 RID: 386 RVA: 0x0000236B File Offset: 0x0000056B
	// (set) Token: 0x06000183 RID: 387 RVA: 0x00002372 File Offset: 0x00000572
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return Eagle_Spy_tipfirewalltracker.resourceCulture;
		}
		set
		{
			Eagle_Spy_tipfirewalltracker.resourceCulture = value;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000184 RID: 388 RVA: 0x0000237A File Offset: 0x0000057A
	internal static string FWtext_Text
	{
		get
		{
			return Eagle_Spy_tipfirewalltracker.ResourceManager.GetString("FWtext.Text", Eagle_Spy_tipfirewalltracker.resourceCulture);
		}
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000185 RID: 389 RVA: 0x0000ADE8 File Offset: 0x00008FE8
	internal static Bitmap PictureBox1_Image
	{
		get
		{
			object @object = Eagle_Spy_tipfirewalltracker.ResourceManager.GetObject("PictureBox1.Image", Eagle_Spy_tipfirewalltracker.resourceCulture);
			return (Bitmap)@object;
		}
	}

	// Token: 0x06000186 RID: 390 RVA: 0x0000207B File Offset: 0x0000027B
	internal Eagle_Spy_tipfirewalltracker()
	{
	}

	// Token: 0x04000017 RID: 23
	private static ResourceManager resourceMan;

	// Token: 0x04000018 RID: 24
	private static CultureInfo resourceCulture;
}
