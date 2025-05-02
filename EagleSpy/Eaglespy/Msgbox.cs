using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;

namespace Eaglespy
{
	// Token: 0x020000F2 RID: 242
	public partial class Msgbox : Form
	{
		// Token: 0x06000C4D RID: 3149 RVA: 0x00007786 File Offset: 0x00005986
		public Msgbox()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00007794 File Offset: 0x00005994
		private void UpdateEnglish()
		{
			this.HeaderText.Text = "Captured lock data Remove";
			this.DescText.Text = "By allowing you delete current captured lock screen  can recapture the lock screen if it did not captured correctly, Are you sure?";
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000077B6 File Offset: 0x000059B6
		private void UpdateChinese()
		{
			this.HeaderText.Text = "删除已捕获的锁定数据";
			this.DescText.Text = "通过允许您删除当前捕获的锁定屏幕，如果未正确捕获，则可以重新捕获锁定屏幕。 您确定吗？";
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000077D8 File Offset: 0x000059D8
		private void UpdateRussian()
		{
			this.HeaderText.Text = "Удалить захваченные данные экрана блокировки";
			this.DescText.Text = "Разрешив удалить текущий захваченный экран блокировки, вы можете повторно захватить экран блокировки, если он не был захвачен правильно. Вы уверены?";
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0011432C File Offset: 0x0011252C
		private void UpdateLanguage()
		{
			string text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "res", "Config", "Language.inf");
			if (File.Exists(text))
			{
				string text2 = File.ReadAllText(text);
				if (text2.Contains("English"))
				{
					this.UpdateEnglish();
					return;
				}
				if (text2.Contains("Russian"))
				{
					this.UpdateRussian();
					return;
				}
				if (text2.Contains("Chinese"))
				{
					this.UpdateChinese();
					return;
				}
				this.UpdateEnglish();
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000077FA File Offset: 0x000059FA
		private void drakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			this.BodyText1 = this.HeaderText.Text;
			this.MessageText1 = this.DescText.Text;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x000033FD File Offset: 0x000015FD
		private void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0000782B File Offset: 0x00005A2B
		private void Msgbox_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
		}

		// Token: 0x04000FA3 RID: 4003
		public string BodyText1;

		// Token: 0x04000FA4 RID: 4004
		public string MessageText1;
	}
}
