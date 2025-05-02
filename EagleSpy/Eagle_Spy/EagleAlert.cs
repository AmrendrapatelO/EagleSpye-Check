using System;
using System.Drawing;
using Eagle_Spy.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000045 RID: 69
	[StandardModule]
	internal sealed class EagleAlert
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x0005CD8C File Offset: 0x0005AF8C
		public static void ShowCustome(string msg, Bitmap img, Color backcolor, Color rondcolor)
		{
			try
			{
				new alertform(msg)
				{
					alertimage = 
					{
						Image = img
					}
				}.Show();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0005CDC8 File Offset: 0x0005AFC8
		public static void ShowSucess(string msg)
		{
			new alertform(msg)
			{
				alertimage = 
				{
					Image = Resources.sucess48px
				}
			}.Show();
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0005CDF4 File Offset: 0x0005AFF4
		public static void ShowWarning(string msg)
		{
			new alertform(msg)
			{
				alertimage = 
				{
					Image = Resources.warning48px
				}
			}.Show();
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0005CE20 File Offset: 0x0005B020
		public static void Showinformation(string msg)
		{
			new alertform(msg)
			{
				alertimage = 
				{
					Image = Resources.information48px
				}
			}.Show();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0005CE4C File Offset: 0x0005B04C
		public static void ShowError(string msg)
		{
			new alertform(msg)
			{
				alertimage = 
				{
					Image = Resources.error48px
				}
			}.Show();
		}
	}
}
