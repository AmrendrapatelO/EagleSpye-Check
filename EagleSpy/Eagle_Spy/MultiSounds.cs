using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200007F RID: 127
	public class MultiSounds
	{
		// Token: 0x06000744 RID: 1860 RVA: 0x0000473D File Offset: 0x0000293D
		public MultiSounds()
		{
			this.Snds = new Dictionary<string, string>();
			this.sndcnt = 0;
		}

		// Token: 0x06000745 RID: 1861
		[DllImport("winmm.dll")]
		private static extern int mciSendStringW([MarshalAs(UnmanagedType.LPTStr)] string lpszCommand, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpszReturnString, uint cchReturn, IntPtr hwndCallback);

		// Token: 0x06000746 RID: 1862 RVA: 0x000BEFD8 File Offset: 0x000BD1D8
		public bool AddSound(string SoundName, string SndFilePath)
		{
			if ((Operators.CompareString(SoundName.Trim(), "", false) == 0) | !File.Exists(SndFilePath))
			{
				return false;
			}
			if (MultiSounds.mciSendStringW("open \"" + SndFilePath + "\" alias Snd_" + this.sndcnt.ToString(), null, 0U, IntPtr.Zero) != 0)
			{
				return false;
			}
			this.Snds.Add(SoundName, "Snd_" + this.sndcnt.ToString());
			checked
			{
				this.sndcnt++;
				return true;
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000BF064 File Offset: 0x000BD264
		public bool Play(string SoundName)
		{
			if (!this.Snds.ContainsKey(SoundName))
			{
				return false;
			}
			MultiSounds.mciSendStringW("seek " + this.Snds[SoundName] + " to start", null, 0U, IntPtr.Zero);
			return MultiSounds.mciSendStringW("play " + this.Snds[SoundName], null, 0U, IntPtr.Zero) == 0;
		}

		// Token: 0x04000895 RID: 2197
		private Dictionary<string, string> Snds;

		// Token: 0x04000896 RID: 2198
		private int sndcnt;
	}
}
