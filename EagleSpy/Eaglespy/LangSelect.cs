using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Eagle_Spy;
using Guna.UI2.WinForms;
using Sipaa.Framework;

namespace Eaglespy
{
	// Token: 0x020000F0 RID: 240
	public partial class LangSelect : Form
	{
		// Token: 0x06000C03 RID: 3075 RVA: 0x00007652 File Offset: 0x00005852
		public LangSelect()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0010F3E4 File Offset: 0x0010D5E4
		private void sButton2_Click(object sender, EventArgs e)
		{
			string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res", "Config");
			string text2 = Path.Combine(text, "Language.inf");
			string text3 = "Chinese";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllText(text2, text3);
			EagleAlert.ShowSucess("中文精选");
			base.Close();
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0010F444 File Offset: 0x0010D644
		private void sButton1_Click(object sender, EventArgs e)
		{
			string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res", "Config");
			string text2 = Path.Combine(text, "Language.inf");
			string text3 = "Russian";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllText(text2, text3);
			EagleAlert.ShowSucess("Русский избранный");
			base.Close();
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0010F4A4 File Offset: 0x0010D6A4
		private void sButton3_Click(object sender, EventArgs e)
		{
			string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res", "Config");
			string text2 = Path.Combine(text, "Language.inf");
			string text3 = "English";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			File.WriteAllText(text2, text3);
			EagleAlert.ShowSucess("English selected");
			base.Close();
		}
	}
}
