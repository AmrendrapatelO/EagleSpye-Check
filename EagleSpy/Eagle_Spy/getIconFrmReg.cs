using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000067 RID: 103
	[StandardModule]
	internal sealed class getIconFrmReg
	{
		// Token: 0x06000663 RID: 1635
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, ref getIconFrmReg.SHFILEINFO psfi, int cbFileInfo, int uFlags);

		// Token: 0x06000664 RID: 1636
		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool DestroyIcon(IntPtr hIcon);

		// Token: 0x06000665 RID: 1637 RVA: 0x000ADA18 File Offset: 0x000ABC18
		public static Bitmap GetFileIcon(string fileExt)
		{
			int num = ((Operators.CompareString(SpySettings.FM_IC_Size, "Large", false) != 0) ? 1 : 0);
			getIconFrmReg.SHFILEINFO shfileinfo = default(getIconFrmReg.SHFILEINFO);
			shfileinfo.szDisplayName = new string('\0', 260);
			shfileinfo.szTypeName = new string('\0', 80);
			getIconFrmReg.SHGetFileInfo(fileExt, 128, ref shfileinfo, Marshal.SizeOf<getIconFrmReg.SHFILEINFO>(shfileinfo), 256 | num | 16);
			Bitmap bitmap = Icon.FromHandle(shfileinfo.hIcon).ToBitmap();
			getIconFrmReg.DestroyIcon(shfileinfo.hIcon);
			return bitmap;
		}

		// Token: 0x06000666 RID: 1638
		[DllImport("shell32.dll")]
		private static extern int SHGetFileInfoW([MarshalAs(UnmanagedType.LPTStr)] [In] string pszPath, int dwFileAttributes, ref getIconFrmReg.SHFILEINFOW psfi, int cbFileInfo, int uFlags);

		// Token: 0x06000667 RID: 1639 RVA: 0x000ADAA0 File Offset: 0x000ABCA0
		public static Bitmap GetIcon(string PathName, bool LargeIco)
		{
			getIconFrmReg.SHFILEINFOW shfileinfow = default(getIconFrmReg.SHFILEINFOW);
			if (LargeIco)
			{
				getIconFrmReg.SHGetFileInfoW(PathName, 0, ref shfileinfow, Marshal.SizeOf<getIconFrmReg.SHFILEINFOW>(shfileinfow), 256);
			}
			else
			{
				getIconFrmReg.SHGetFileInfoW(PathName, 0, ref shfileinfow, Marshal.SizeOf<getIconFrmReg.SHFILEINFOW>(shfileinfow), 257);
			}
			Bitmap bitmap = Icon.FromHandle(shfileinfow.hIcon).ToBitmap();
			getIconFrmReg.DestroyIcon(shfileinfow.hIcon);
			return bitmap;
		}

		// Token: 0x04000721 RID: 1825
		private const int MAX_PATH = 260;

		// Token: 0x04000722 RID: 1826
		private const int SHGFI_ICON = 256;

		// Token: 0x04000723 RID: 1827
		private const int SHGFI_USEFILEATTRIBUTES = 16;

		// Token: 0x04000724 RID: 1828
		private const int FILE_ATTRIBUTE_NORMAL = 128;

		// Token: 0x04000725 RID: 1829
		private const int SHGFI_LARGEICON = 0;

		// Token: 0x04000726 RID: 1830
		private const int SHGFI_SMALLICON = 1;

		// Token: 0x02000068 RID: 104
		private struct SHFILEINFO
		{
			// Token: 0x04000727 RID: 1831
			public IntPtr hIcon;

			// Token: 0x04000728 RID: 1832
			public int iIcon;

			// Token: 0x04000729 RID: 1833
			public int dwAttributes;

			// Token: 0x0400072A RID: 1834
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szDisplayName;

			// Token: 0x0400072B RID: 1835
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szTypeName;
		}

		// Token: 0x02000069 RID: 105
		public enum IconSize
		{
			// Token: 0x0400072D RID: 1837
			SHGFI_LARGEICON,
			// Token: 0x0400072E RID: 1838
			SHGFI_SMALLICON
		}

		// Token: 0x0200006A RID: 106
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct SHFILEINFOW
		{
			// Token: 0x0400072F RID: 1839
			public IntPtr hIcon;

			// Token: 0x04000730 RID: 1840
			public int iIcon;

			// Token: 0x04000731 RID: 1841
			public int dwAttributes;

			// Token: 0x04000732 RID: 1842
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szDisplayName;

			// Token: 0x04000733 RID: 1843
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szTypeName;
		}
	}
}
