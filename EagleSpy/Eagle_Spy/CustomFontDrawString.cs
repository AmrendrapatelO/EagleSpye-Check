using System;
using System.Drawing;
using System.Drawing.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200003B RID: 59
	[StandardModule]
	internal sealed class CustomFontDrawString
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x00003371 File Offset: 0x00001571
		public static Font LoadFont(string name, float size, FontStyle style)
		{
			CustomFontDrawString.privateFonts = new PrivateFontCollection();
			CustomFontDrawString.privateFonts.AddFontFile(reso.res_Path + "\\Fonts\\" + name);
			return new Font(CustomFontDrawString.privateFonts.Families[0], size, style);
		}

		// Token: 0x04000372 RID: 882
		private static PrivateFontCollection privateFonts;
	}
}
