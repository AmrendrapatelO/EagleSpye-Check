using System;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000065 RID: 101
	[StandardModule]
	public sealed class GetCountryName2
	{
		// Token: 0x0600065F RID: 1631 RVA: 0x000AD8D8 File Offset: 0x000ABAD8
		public static string GetCountryName(string ipc)
		{
			string text = Data.GeoIP0.LookupCountryName(ipc.Trim());
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				if (Operators.CompareString(language, "AR", false) == 0)
				{
					text = Codes.Translate(text, "en", "ar");
				}
			}
			else
			{
				text = Codes.Translate(text, "en", "zh");
			}
			return text;
		}
	}
}
