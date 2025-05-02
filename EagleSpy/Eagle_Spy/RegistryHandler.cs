using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Eagle_Spy
{
	// Token: 0x02000093 RID: 147
	[StandardModule]
	internal sealed class RegistryHandler
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x000C9DD4 File Offset: 0x000C7FD4
		public static void iniliz()
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				try
				{
					if (registryKey2 == null)
					{
						registryKey2 = registryKey.CreateSubKey(RegistryHandler.mainpath);
					}
				}
				catch (Exception)
				{
				}
				registryKey2.Close();
				registryKey.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x000C9E40 File Offset: 0x000C8040
		public static string Get_EMAIL()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("EmailV6"));
						if (objectValue != null)
						{
							return Codes.AES_Decrypt(registryKey2.GetValue("EmailV6").ToString(), "W3Ndxet0sdZYtqykGiGCeiIMDoF");
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000C9EE4 File Offset: 0x000C80E4
		public static void Set_EMAIL(string key)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				RegistryHandler.Set_OldEmail(key);
				registryKey2.SetValue("EmailV6", Codes.Encrypt(key, "W3Ndxet0sdZYtqykGiGCeiIMDoF"));
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000C9F48 File Offset: 0x000C8148
		public static void Set_OldEmail(string key)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				registryKey2.SetValue("Email", key);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000C9F9C File Offset: 0x000C819C
		public static string getworning()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("wrn"));
						if (objectValue != null)
						{
							return registryKey2.GetValue("wrn").ToString();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000CA038 File Offset: 0x000C8238
		public static void setworning(string key)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				registryKey2.SetValue("wrn", key);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000CA08C File Offset: 0x000C828C
		public static string getwtipanti()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("tipanti"));
						if (objectValue != null)
						{
							return registryKey2.GetValue("tipanti").ToString();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000CA128 File Offset: 0x000C8328
		public static void settipanti(string key)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				registryKey2.SetValue("tipanti", key);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000CA17C File Offset: 0x000C837C
		public static string Get_ID_ASSIST()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("ID"));
						if (objectValue != null)
						{
							return registryKey2.GetValue("ID").ToString();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000CA218 File Offset: 0x000C8418
		public static void Set_ID_ASSIST(string key)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				registryKey2.SetValue("ID", key);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000CA26C File Offset: 0x000C846C
		public static string GET_FTtip()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("TipFT"));
						if (objectValue != null)
						{
							return registryKey2.GetValue("TipFT").ToString();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000CA308 File Offset: 0x000C8508
		public static void Set_FTtip(string key)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				registryKey2.SetValue("TipFT", key);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000CA35C File Offset: 0x000C855C
		public static string Get_Language()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("UserLanguage"));
						if (objectValue != null)
						{
							return registryKey2.GetValue("UserLanguage").ToString();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000CA3F8 File Offset: 0x000C85F8
		public static void Set_Language(string key)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				registryKey2.SetValue("UserLanguage", key);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000CA44C File Offset: 0x000C864C
		public static string GET_Tip(string id)
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(id));
						if (objectValue != null)
						{
							return registryKey2.GetValue(id).ToString();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000CA4E0 File Offset: 0x000C86E0
		public static void SET_Tip(string key, string id)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				registryKey2.SetValue(id, key);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000CA530 File Offset: 0x000C8730
		public static string GET_SoundID()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(RegistryHandler.Selectedsound));
						if (objectValue != null)
						{
							return registryKey2.GetValue(RegistryHandler.Selectedsound).ToString();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000CA4E0 File Offset: 0x000C86E0
		public static void SET_qulity(string key, string id)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				registryKey2.SetValue(id, key);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000CA5CC File Offset: 0x000C87CC
		public static string GET_qulity()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue(RegistryHandler.Selectedqulity));
						if (objectValue != null)
						{
							return registryKey2.GetValue(RegistryHandler.Selectedqulity).ToString();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000CA668 File Offset: 0x000C8868
		public static void SET_SoundID(string id)
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true);
				registryKey2.SetValue(RegistryHandler.Selectedsound, id);
				registryKey2.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000CA6BC File Offset: 0x000C88BC
		public static string passkey()
		{
			try
			{
				using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey registryKey2 = registryKey.OpenSubKey(RegistryHandler.mainpath, true))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("SK"));
						if (objectValue != null)
						{
							return registryKey2.GetValue("SK").ToString();
						}
					}
				}
			}
			catch (Exception)
			{
			}
			return "";
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000CA75C File Offset: 0x000C895C
		public static void SetUserHandleLimit()
		{
			try
			{
				string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows";
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text, true);
				registryKey.SetValue("USERProcessHandleQuota", 18000, RegistryValueKind.DWord);
				registryKey.Close();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000963 RID: 2403
		private static string mainpath = "Software\\\\EagleSpy";

		// Token: 0x04000964 RID: 2404
		public static string ShowScrenShotTip = "STIP";

		// Token: 0x04000965 RID: 2405
		public static string ShowScrenReadTip = "SRETIP";

		// Token: 0x04000966 RID: 2406
		public static string Selectedsound = "SOUND";

		// Token: 0x04000967 RID: 2407
		public static string Selectedqulity = "Quality";
	}
}
