using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200003F RID: 63
	[DesignerGenerated]
	public partial class DialogPloice : Form
	{
		// Token: 0x0600043D RID: 1085 RVA: 0x0000342C File Offset: 0x0000162C
		public DialogPloice()
		{
			base.Load += this.DialogPloice_Load;
			this.ARTEXT = "انا قرأت ما موجود اعلاه , وموافق على الشروط";
			this.ENTEXT = "I read all text above, And Accepted All";
			this.IsArab = false;
			this.InitializeComponent();
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00003469 File Offset: 0x00001669
		private void OK_Button_Click(object sender, EventArgs e)
		{
			if (this.Acccheck.Checked)
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
			if (this.IsArab)
			{
				Interaction.MsgBox("قم بالموافقة على الشروط اولا!", MsgBoxStyle.OkOnly, null);
				return;
			}
			Interaction.MsgBox("Accepte Privacy Policy First!", MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000034A9 File Offset: 0x000016A9
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000583E8 File Offset: 0x000565E8
		private void DialogPloice_Load(object sender, EventArgs e)
		{
			this.StartNow = DateAndTime.Now.AddSeconds(15.0);
			this.Timer1.Start();
			this.OK_Button.Enabled = false;
			this.Cancel_Button.Enabled = false;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00058434 File Offset: 0x00056634
		private void Button2_Click(object sender, EventArgs e)
		{
			this.IsArab = true;
			this.MainText.Text = "";
			this.Acccheck.Text = this.ARTEXT;
			this.OK_Button.Text = "موافق";
			this.Cancel_Button.Text = "كلا";
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0005848C File Offset: 0x0005668C
		private void Button1_Click(object sender, EventArgs e)
		{
			this.IsArab = false;
			this.MainText.Text = "";
			this.Acccheck.Text = this.ENTEXT;
			this.OK_Button.Text = "OK";
			this.Cancel_Button.Text = "Cancel";
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000584E4 File Offset: 0x000566E4
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (DateTime.Compare(this.StartNow, DateAndTime.Now) < 0)
			{
				this.OK_Button.Enabled = true;
				this.Cancel_Button.Enabled = true;
				this.Text = " Privacy Policy & Terms of Service";
				this.Timer1.Stop();
				return;
			}
			this.Text = " Privacy Policy & Terms of Service - " + (checked(this.StartNow.Second - DateAndTime.Now.Second)).ToString();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002423 File Offset: 0x00000623
		private void DialogPloice_Load_1(object sender, EventArgs e)
		{
		}

		// Token: 0x04000385 RID: 901
		private string ARTEXT;

		// Token: 0x04000386 RID: 902
		private string ENTEXT;

		// Token: 0x04000387 RID: 903
		private bool IsArab;

		// Token: 0x04000388 RID: 904
		private DateTime StartNow;
	}
}
