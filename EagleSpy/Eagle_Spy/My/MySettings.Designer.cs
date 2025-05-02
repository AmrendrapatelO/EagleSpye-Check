using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.My
{
	// Token: 0x020000DA RID: 218
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.7.0.0")]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x000F63B0 File Offset: 0x000F45B0
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += delegate(object sender, EventArgs e)
							{
								if (MyProject.Application.SaveMySettingsOnExit)
								{
									MySettingsProperty.Settings.Save();
								}
							};
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000068B2 File Offset: 0x00004AB2
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x000068C4 File Offset: 0x00004AC4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("7771>7772")]
		public string ports
		{
			get
			{
				return Conversions.ToString(this["ports"]);
			}
			set
			{
				this["ports"] = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x000068D2 File Offset: 0x00004AD2
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x000068E4 File Offset: 0x00004AE4
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		[UserScopedSetting]
		public string performance
		{
			get
			{
				return Conversions.ToString(this["performance"]);
			}
			set
			{
				this["performance"] = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000068F2 File Offset: 0x00004AF2
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00006904 File Offset: 0x00004B04
		[DebuggerNonUserCode]
		[DefaultSettingValue("UTF8")]
		[UserScopedSetting]
		public string encoding8
		{
			get
			{
				return Conversions.ToString(this["encoding8"]);
			}
			set
			{
				this["encoding8"] = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00006912 File Offset: 0x00004B12
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x00006924 File Offset: 0x00004B24
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string show_alert
		{
			get
			{
				return Conversions.ToString(this["show_alert"]);
			}
			set
			{
				this["show_alert"] = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00006932 File Offset: 0x00004B32
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x00006944 File Offset: 0x00004B44
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Right")]
		public string location
		{
			get
			{
				return Conversions.ToString(this["location"]);
			}
			set
			{
				this["location"] = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00006952 File Offset: 0x00004B52
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00006964 File Offset: 0x00004B64
		[DebuggerNonUserCode]
		[DefaultSettingValue("Just tell me")]
		[UserScopedSetting]
		public string disconnected
		{
			get
			{
				return Conversions.ToString(this["disconnected"]);
			}
			set
			{
				this["disconnected"] = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00006972 File Offset: 0x00004B72
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x00006984 File Offset: 0x00004B84
		[DefaultSettingValue("No")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string Auto_focus
		{
			get
			{
				return Conversions.ToString(this["Auto_focus"]);
			}
			set
			{
				this["Auto_focus"] = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00006992 File Offset: 0x00004B92
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x000069A4 File Offset: 0x00004BA4
		[DebuggerNonUserCode]
		[DefaultSettingValue("Normal")]
		[UserScopedSetting]
		public string Effects_CAM
		{
			get
			{
				return Conversions.ToString(this["Effects_CAM"]);
			}
			set
			{
				this["Effects_CAM"] = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x000069B2 File Offset: 0x00004BB2
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000069C4 File Offset: 0x00004BC4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Streets")]
		public string Style_Maps
		{
			get
			{
				return Conversions.ToString(this["Style_Maps"]);
			}
			set
			{
				this["Style_Maps"] = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x000069D2 File Offset: 0x00004BD2
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x000069E4 File Offset: 0x00004BE4
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string Saving_data
		{
			get
			{
				return Conversions.ToString(this["Saving_data"]);
			}
			set
			{
				this["Saving_data"] = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x000069F2 File Offset: 0x00004BF2
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x00006A04 File Offset: 0x00004C04
		[DefaultSettingValue("Auto")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string CAMQuality
		{
			get
			{
				return Conversions.ToString(this["CAMQuality"]);
			}
			set
			{
				this["CAMQuality"] = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00006A12 File Offset: 0x00004C12
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00006A24 File Offset: 0x00004C24
		[DebuggerNonUserCode]
		[DefaultSettingValue("Client")]
		[UserScopedSetting]
		public string build_text_name_victim
		{
			get
			{
				return Conversions.ToString(this["build_text_name_victim"]);
			}
			set
			{
				this["build_text_name_victim"] = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00006A32 File Offset: 0x00004C32
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00006A44 File Offset: 0x00004C44
		[DefaultSettingValue("CraxsApp")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string build_text_name_patch
		{
			get
			{
				return Conversions.ToString(this["build_text_name_patch"]);
			}
			set
			{
				this["build_text_name_patch"] = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00006A52 File Offset: 0x00004C52
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00006A64 File Offset: 0x00004C64
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1.0.0.0")]
		public string build_text_version
		{
			get
			{
				return Conversions.ToString(this["build_text_version"]);
			}
			set
			{
				this["build_text_version"] = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00006A72 File Offset: 0x00004C72
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00006A84 File Offset: 0x00004C84
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		public int build_text_sleep
		{
			get
			{
				return Conversions.ToInteger(this["build_text_sleep"]);
			}
			set
			{
				this["build_text_sleep"] = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00006A97 File Offset: 0x00004C97
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00006AA9 File Offset: 0x00004CA9
		[DebuggerNonUserCode]
		[DefaultSettingValue("7771")]
		[UserScopedSetting]
		public int build_text_port
		{
			get
			{
				return Conversions.ToInteger(this["build_text_port"]);
			}
			set
			{
				this["build_text_port"] = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00006ABC File Offset: 0x00004CBC
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00006ACE File Offset: 0x00004CCE
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool build_Checked_hide
		{
			get
			{
				return Conversions.ToBoolean(this["build_Checked_hide"]);
			}
			set
			{
				this["build_Checked_hide"] = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00006AE1 File Offset: 0x00004CE1
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00006AF3 File Offset: 0x00004CF3
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool build_Checked_icon
		{
			get
			{
				return Conversions.ToBoolean(this["build_Checked_icon"]);
			}
			set
			{
				this["build_Checked_icon"] = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00006B06 File Offset: 0x00004D06
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00006B18 File Offset: 0x00004D18
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool build_Checked_doze
		{
			get
			{
				return Conversions.ToBoolean(this["build_Checked_doze"]);
			}
			set
			{
				this["build_Checked_doze"] = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00006B2B File Offset: 0x00004D2B
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00006B3D File Offset: 0x00004D3D
		[DefaultSettingValue("null")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string build_path_icon
		{
			get
			{
				return Conversions.ToString(this["build_path_icon"]);
			}
			set
			{
				this["build_path_icon"] = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00006B4B File Offset: 0x00004D4B
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00006B5D File Offset: 0x00004D5D
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("null")]
		public string build_DGV_list
		{
			get
			{
				return Conversions.ToString(this["build_DGV_list"]);
			}
			set
			{
				this["build_DGV_list"] = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x000F6434 File Offset: 0x000F4634
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00006B6B File Offset: 0x00004D6B
		[DebuggerNonUserCode]
		[DefaultSettingValue("95, 95, 250")]
		[UserScopedSetting]
		public Color DefaultColorForeground
		{
			get
			{
				object obj = this["DefaultColorForeground"];
				if (obj == null)
				{
					return default(Color);
				}
				return (Color)obj;
			}
			set
			{
				this["DefaultColorForeground"] = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000F6460 File Offset: 0x000F4660
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00006B7E File Offset: 0x00004D7E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("50, 50, 50")]
		public Color DefaultColorBackground
		{
			get
			{
				object obj = this["DefaultColorBackground"];
				if (obj == null)
				{
					return default(Color);
				}
				return (Color)obj;
			}
			set
			{
				this["DefaultColorBackground"] = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00006B91 File Offset: 0x00004D91
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00006BA3 File Offset: 0x00004DA3
		[DebuggerNonUserCode]
		[DefaultSettingValue("9")]
		[UserScopedSetting]
		public int FontSize
		{
			get
			{
				return Conversions.ToInteger(this["FontSize"]);
			}
			set
			{
				this["FontSize"] = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00006BB6 File Offset: 0x00004DB6
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00006BC8 File Offset: 0x00004DC8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Regular")]
		public string FontStyle
		{
			get
			{
				return Conversions.ToString(this["FontStyle"]);
			}
			set
			{
				this["FontStyle"] = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00006BD6 File Offset: 0x00004DD6
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[DebuggerNonUserCode]
		[DefaultSettingValue("00110000")]
		[UserScopedSetting]
		public string EncryptionKey
		{
			get
			{
				return Conversions.ToString(this["EncryptionKey"]);
			}
			set
			{
				this["EncryptionKey"] = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x000F648C File Offset: 0x000F468C
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x00006BF6 File Offset: 0x00004DF6
		[UserScopedSetting]
		[DefaultSettingValue("Red")]
		[DebuggerNonUserCode]
		public Color DefaultColor_NewColorFiles
		{
			get
			{
				object obj = this["DefaultColor_NewColorFiles"];
				if (obj == null)
				{
					return default(Color);
				}
				return (Color)obj;
			}
			set
			{
				this["DefaultColor_NewColorFiles"] = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x000F64B8 File Offset: 0x000F46B8
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00006C09 File Offset: 0x00004E09
		[UserScopedSetting]
		[DefaultSettingValue("Blue")]
		[DebuggerNonUserCode]
		public Color DefaultColor_ColorTitles
		{
			get
			{
				object obj = this["DefaultColor_ColorTitles"];
				if (obj == null)
				{
					return default(Color);
				}
				return (Color)obj;
			}
			set
			{
				this["DefaultColor_ColorTitles"] = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00006C1C File Offset: 0x00004E1C
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00006C2E File Offset: 0x00004E2E
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("null")]
		public string BIND_Path
		{
			get
			{
				return Conversions.ToString(this["BIND_Path"]);
			}
			set
			{
				this["BIND_Path"] = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00006C3C File Offset: 0x00004E3C
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00006C4E File Offset: 0x00004E4E
		[UserScopedSetting]
		[DefaultSettingValue("null")]
		[DebuggerNonUserCode]
		public string BIND_EX
		{
			get
			{
				return Conversions.ToString(this["BIND_EX"]);
			}
			set
			{
				this["BIND_EX"] = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00006C5C File Offset: 0x00004E5C
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00006C6E File Offset: 0x00004E6E
		[DebuggerNonUserCode]
		[DefaultSettingValue("null")]
		[UserScopedSetting]
		public string intent
		{
			get
			{
				return Conversions.ToString(this["intent"]);
			}
			set
			{
				this["intent"] = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00006C7C File Offset: 0x00004E7C
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00006C8E File Offset: 0x00004E8E
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool NOTI_SOUND
		{
			get
			{
				return Conversions.ToBoolean(this["NOTI_SOUND"]);
			}
			set
			{
				this["NOTI_SOUND"] = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00006CA1 File Offset: 0x00004EA1
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00006CB3 File Offset: 0x00004EB3
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string Flags_Visible
		{
			get
			{
				return Conversions.ToString(this["Flags_Visible"]);
			}
			set
			{
				this["Flags_Visible"] = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00006CC1 File Offset: 0x00004EC1
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x00006CD3 File Offset: 0x00004ED3
		[DebuggerNonUserCode]
		[DefaultSettingValue("32px")]
		[UserScopedSetting]
		public string Flags_Size
		{
			get
			{
				return Conversions.ToString(this["Flags_Size"]);
			}
			set
			{
				this["Flags_Size"] = value;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00006CE1 File Offset: 0x00004EE1
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x00006CF3 File Offset: 0x00004EF3
		[UserScopedSetting]
		[DefaultSettingValue("Yes")]
		[DebuggerNonUserCode]
		public string Round
		{
			get
			{
				return Conversions.ToString(this["Round"]);
			}
			set
			{
				this["Round"] = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00006D01 File Offset: 0x00004F01
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00006D13 File Offset: 0x00004F13
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string SStatus_Visible
		{
			get
			{
				return Conversions.ToString(this["SStatus_Visible"]);
			}
			set
			{
				this["SStatus_Visible"] = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00006D21 File Offset: 0x00004F21
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00006D33 File Offset: 0x00004F33
		[DebuggerNonUserCode]
		[DefaultSettingValue("0123456789")]
		[UserScopedSetting]
		public string _Columns
		{
			get
			{
				return Conversions.ToString(this["_Columns"]);
			}
			set
			{
				this["_Columns"] = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00006D41 File Offset: 0x00004F41
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00006D53 File Offset: 0x00004F53
		[DefaultSettingValue("Small")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string FM_IC_Size
		{
			get
			{
				return Conversions.ToString(this["FM_IC_Size"]);
			}
			set
			{
				this["FM_IC_Size"] = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00006D61 File Offset: 0x00004F61
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00006D73 File Offset: 0x00004F73
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Yes")]
		public string Removing_Duplicates
		{
			get
			{
				return Conversions.ToString(this["Removing_Duplicates"]);
			}
			set
			{
				this["Removing_Duplicates"] = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00006D81 File Offset: 0x00004F81
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00006D93 File Offset: 0x00004F93
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("No")]
		public string _multi_sounds
		{
			get
			{
				return Conversions.ToString(this["_multi_sounds"]);
			}
			set
			{
				this["_multi_sounds"] = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00006DA1 File Offset: 0x00004FA1
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00006DB3 File Offset: 0x00004FB3
		[UserScopedSetting]
		[DefaultSettingValue("20")]
		[DebuggerNonUserCode]
		public int ImageQualty
		{
			get
			{
				return Conversions.ToInteger(this["ImageQualty"]);
			}
			set
			{
				this["ImageQualty"] = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00006DC6 File Offset: 0x00004FC6
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00006DD8 File Offset: 0x00004FD8
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string Cashpic
		{
			get
			{
				return Conversions.ToString(this["Cashpic"]);
			}
			set
			{
				this["Cashpic"] = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00006DE6 File Offset: 0x00004FE6
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[UserScopedSetting]
		[DefaultSettingValue("Yes")]
		[DebuggerNonUserCode]
		public string LOG
		{
			get
			{
				return Conversions.ToString(this["LOG"]);
			}
			set
			{
				this["LOG"] = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00006E06 File Offset: 0x00005006
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00006E18 File Offset: 0x00005018
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("PT1BQUFic2RGQURhY0FTQ1ZERVNEVnNkU0RSVlNEVkFFR1NTRkJSRUE=")]
		public string DKEY
		{
			get
			{
				return Conversions.ToString(this["DKEY"]);
			}
			set
			{
				this["DKEY"] = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00006E26 File Offset: 0x00005026
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00006E38 File Offset: 0x00005038
		[UserScopedSetting]
		[DefaultSettingValue("Yes")]
		[DebuggerNonUserCode]
		public string ShowAlertDis
		{
			get
			{
				return Conversions.ToString(this["ShowAlertDis"]);
			}
			set
			{
				this["ShowAlertDis"] = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00006E46 File Offset: 0x00005046
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00006E58 File Offset: 0x00005058
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string hidecoonstart
		{
			get
			{
				return Conversions.ToString(this["hidecoonstart"]);
			}
			set
			{
				this["hidecoonstart"] = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00006E66 File Offset: 0x00005066
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00006E78 File Offset: 0x00005078
		[DebuggerNonUserCode]
		[DefaultSettingValue("...")]
		[UserScopedSetting]
		public string inj_thost
		{
			get
			{
				return Conversions.ToString(this["inj_thost"]);
			}
			set
			{
				this["inj_thost"] = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00006E86 File Offset: 0x00005086
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00006E98 File Offset: 0x00005098
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("4444")]
		public string inj_tport
		{
			get
			{
				return Conversions.ToString(this["inj_tport"]);
			}
			set
			{
				this["inj_tport"] = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00006EA6 File Offset: 0x000050A6
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00006EB8 File Offset: 0x000050B8
		[DebuggerNonUserCode]
		[DefaultSettingValue("1234")]
		[UserScopedSetting]
		public string inj_tkey
		{
			get
			{
				return Conversions.ToString(this["inj_tkey"]);
			}
			set
			{
				this["inj_tkey"] = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00006EC6 File Offset: 0x000050C6
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00006ED8 File Offset: 0x000050D8
		[DefaultSettingValue("Client")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string inj_tnam
		{
			get
			{
				return Conversions.ToString(this["inj_tnam"]);
			}
			set
			{
				this["inj_tnam"] = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00006EE6 File Offset: 0x000050E6
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00006EF8 File Offset: 0x000050F8
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool requestmade
		{
			get
			{
				return Conversions.ToBoolean(this["requestmade"]);
			}
			set
			{
				this["requestmade"] = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00006F0B File Offset: 0x0000510B
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00006F1D File Offset: 0x0000511D
		[DefaultSettingValue("False")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool reportmade
		{
			get
			{
				return Conversions.ToBoolean(this["reportmade"]);
			}
			set
			{
				this["reportmade"] = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00006F30 File Offset: 0x00005130
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00006F42 File Offset: 0x00005142
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("System update")]
		public string NotifiTitle
		{
			get
			{
				return Conversions.ToString(this["NotifiTitle"]);
			}
			set
			{
				this["NotifiTitle"] = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00006F50 File Offset: 0x00005150
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00006F62 File Offset: 0x00005162
		[DebuggerNonUserCode]
		[DefaultSettingValue("New system software is available, Tap to learn more.")]
		[UserScopedSetting]
		public string NotifiText
		{
			get
			{
				return Conversions.ToString(this["NotifiText"]);
			}
			set
			{
				this["NotifiText"] = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00006F70 File Offset: 0x00005170
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00006F82 File Offset: 0x00005182
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("This App Request Accessibility Service:\r\n• Click on Enable\r\n• Go to Downloaded Service\r\n• Enable [MY-NAME]")]
		public string bodytext
		{
			get
			{
				return Conversions.ToString(this["bodytext"]);
			}
			set
			{
				this["bodytext"] = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00006F90 File Offset: 0x00005190
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00006FA2 File Offset: 0x000051A2
		[DebuggerNonUserCode]
		[DefaultSettingValue("...")]
		[UserScopedSetting]
		public string accessdiscribe
		{
			get
			{
				return Conversions.ToString(this["accessdiscribe"]);
			}
			set
			{
				this["accessdiscribe"] = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00006FB0 File Offset: 0x000051B0
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00006FC2 File Offset: 0x000051C2
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		[UserScopedSetting]
		public string live_sc_qulty
		{
			get
			{
				return Conversions.ToString(this["live_sc_qulty"]);
			}
			set
			{
				this["live_sc_qulty"] = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00006FD0 File Offset: 0x000051D0
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00006FE2 File Offset: 0x000051E2
		[DebuggerNonUserCode]
		[DefaultSettingValue("10")]
		[UserScopedSetting]
		public string live_fps_rec
		{
			get
			{
				return Conversions.ToString(this["live_fps_rec"]);
			}
			set
			{
				this["live_fps_rec"] = value;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00006FF0 File Offset: 0x000051F0
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00007002 File Offset: 0x00005202
		[DebuggerNonUserCode]
		[DefaultSettingValue("Yes")]
		[UserScopedSetting]
		public string checkupdatestart
		{
			get
			{
				return Conversions.ToString(this["checkupdatestart"]);
			}
			set
			{
				this["checkupdatestart"] = value;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00007030 File Offset: 0x00005230
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00007042 File Offset: 0x00005242
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool savepass
		{
			get
			{
				return Conversions.ToBoolean(this["savepass"]);
			}
			set
			{
				this["savepass"] = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00007055 File Offset: 0x00005255
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00007067 File Offset: 0x00005267
		[DebuggerNonUserCode]
		[DefaultSettingValue("450x300")]
		[UserScopedSetting]
		public string resolution
		{
			get
			{
				return Conversions.ToString(this["resolution"]);
			}
			set
			{
				this["resolution"] = value;
			}
		}

		// Token: 0x04000E6E RID: 3694
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000E6F RID: 3695
		private static bool addedHandler;

		// Token: 0x04000E70 RID: 3696
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
