using System;
using System.Drawing;
using System.Drawing.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200003A RID: 58
	[StandardModule]
	internal sealed class CustomFont
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x00003338 File Offset: 0x00001538
		public static Font LoadFont(string name, float size, FontStyle style)
		{
			CustomFont.privateFonts = new PrivateFontCollection();
			CustomFont.privateFonts.AddFontFile(reso.res_Path + "\\Fonts\\" + name);
			return new Font(CustomFont.privateFonts.Families[0], size, style);
		}

		// Token: 0x04000371 RID: 881
		private static PrivateFontCollection privateFonts;
	}
}
