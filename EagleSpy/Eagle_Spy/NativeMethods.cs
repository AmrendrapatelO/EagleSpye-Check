using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Eagle_Spy
{
	// Token: 0x02000081 RID: 129
	public class NativeMethods
	{
		// Token: 0x0600074A RID: 1866
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref Point pptDst, ref Size psize, IntPtr hdcSrc, ref Point pptSrc, int crKey, ref NativeMethods.BLENDFUNCTION pblend, int dwFlags);

		// Token: 0x0600074B RID: 1867
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr GetDC(IntPtr hWnd);

		// Token: 0x0600074C RID: 1868
		[DllImport("gdi32.dll")]
		internal static extern IntPtr CreateCompatibleDC(IntPtr dc);

		// Token: 0x0600074D RID: 1869
		[DllImport("gdi32.dll")]
		internal static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObj);

		// Token: 0x0600074E RID: 1870
		[DllImport("gdi32.dll")]
		internal static extern IntPtr DeleteDC(IntPtr dc);

		// Token: 0x0600074F RID: 1871
		[DllImport("gdi32.dll")]
		internal static extern IntPtr DeleteObject(IntPtr hObj);

		// Token: 0x04000897 RID: 2199
		internal const int WS_EX_LAYERED = 524288;

		// Token: 0x04000898 RID: 2200
		internal const int AC_SRC_OVER = 0;

		// Token: 0x04000899 RID: 2201
		internal const int AC_SRC_ALPHA = 1;

		// Token: 0x0400089A RID: 2202
		internal const int ULW_ALPHA = 2;

		// Token: 0x02000082 RID: 130
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct BLENDFUNCTION
		{
			// Token: 0x06000751 RID: 1873 RVA: 0x0000475F File Offset: 0x0000295F
			public BLENDFUNCTION(byte alpha)
			{
				this = default(NativeMethods.BLENDFUNCTION);
				this.BlendOp = 0;
				this.BlendFlags = 0;
				this.SourceConstantAlpha = alpha;
				this.AlphaFormat = 1;
			}

			// Token: 0x0400089B RID: 2203
			public byte BlendOp;

			// Token: 0x0400089C RID: 2204
			public byte BlendFlags;

			// Token: 0x0400089D RID: 2205
			public byte SourceConstantAlpha;

			// Token: 0x0400089E RID: 2206
			public byte AlphaFormat;
		}

		// Token: 0x02000083 RID: 131
		internal struct RECT
		{
			// Token: 0x0400089F RID: 2207
			public int Left;

			// Token: 0x040008A0 RID: 2208
			public int Top;

			// Token: 0x040008A1 RID: 2209
			public int Right;

			// Token: 0x040008A2 RID: 2210
			public int Bottom;
		}
	}
}
