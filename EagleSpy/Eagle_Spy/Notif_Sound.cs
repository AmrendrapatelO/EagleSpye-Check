using System;
using System.Media;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000087 RID: 135
	[StandardModule]
	internal sealed class Notif_Sound
	{
		// Token: 0x06000761 RID: 1889 RVA: 0x000C109C File Offset: 0x000BF29C
		public static string getsoundpath()
		{
			string text = RegistryHandler.GET_SoundID();
			if (text == null)
			{
				text = "5";
			}
			return Notif_Sound.path_File.Replace("[id]", text);
		}

		// Token: 0x040008C4 RID: 2244
		public static bool multi = false;

		// Token: 0x040008C5 RID: 2245
		public static SoundPlayer aMedia;

		// Token: 0x040008C6 RID: 2246
		public static MultiSounds Snds = new MultiSounds();

		// Token: 0x040008C7 RID: 2247
		private static string path_File = reso.res_Path + "\\Audio\\[id].wav";

		// Token: 0x040008C8 RID: 2248
		public static int id = 0;
	}
}
