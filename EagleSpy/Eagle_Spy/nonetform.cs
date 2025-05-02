using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000084 RID: 132
	[DesignerGenerated]
	public partial class nonetform : Form
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x00004784 File Offset: 0x00002984
		public nonetform()
		{
			base.Load += this.Nonetform_Load;
			this.InitializeComponent();
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000047A4 File Offset: 0x000029A4
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
		{
			base.Close();
			this.CraxsStyle();
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x000BF508 File Offset: 0x000BD708
		public void CraxsStyle()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				this.Label1.Text = "لا يوجد اتصال بالإنترنت.\r\n\r\nيرجى التحقق من الإنترنت الخاص بك وحاول مرة أخرى.";
				return;
			}
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.Label1.Text = "No internet Connection.\r\n\r\nPlease Check your internet and try again.";
				return;
			}
			this.Label1.Text = "没有网络连接。\r\n\r\n请检查您的互联网并重试。";
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000BF56C File Offset: 0x000BD76C
		private void Nonetform_Load(object sender, EventArgs e)
		{
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(checked(Screen.PrimaryScreen.WorkingArea.Width - base.Width) / 2, 0);
		}
	}
}
