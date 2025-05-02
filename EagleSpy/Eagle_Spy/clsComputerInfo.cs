using System;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace Eagle_Spy
{
	// Token: 0x02000030 RID: 48
	public class clsComputerInfo
	{
		// Token: 0x0600038E RID: 910 RVA: 0x000511AC File Offset: 0x0004F3AC
		public static string GetSerialNumber()
		{
			SelectQuery selectQuery = new SelectQuery("Win32_BaseBoard");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(selectQuery);
			string text = null;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					text = managementObject["SerialNumber"].ToString();
					return text;
				}
			}
			return text;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00051228 File Offset: 0x0004F428
		public static string GetProcessorID()
		{
			SelectQuery selectQuery = new SelectQuery("Win32_processor");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(selectQuery);
			string text = null;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					text = managementObject["processorId"].ToString();
					return text;
				}
			}
			return text;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000512A4 File Offset: 0x0004F4A4
		public static string GenerateHash(string input)
		{
			byte[] array = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input + clsComputerInfo.GetVolumeSerial("C")));
			return string.Concat(array.Select((byte b) => b.ToString("x2")));
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00051300 File Offset: 0x0004F500
		internal static string GetVolumeSerial(string strDriveLetter = "C")
		{
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + strDriveLetter + ":\"");
			managementObject.Get();
			return managementObject["VolumeSerialNumber"].ToString();
		}
	}
}
