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
	// Token: 0x02000037 RID: 55
	[DesignerGenerated]
	public partial class comptableform : Form
	{
		// Token: 0x06000407 RID: 1031 RVA: 0x0000328B File Offset: 0x0000148B
		public comptableform()
		{
			base.Load += this.Comptableform_Load;
			this.armsg = "اكتشف EagleSpy نظام تشغيل Windows غير متوافق ، إذا واجهت مشكلة في تسجيل الدخول ، فحاول الانتقال إلى Windows 10";
			this.cnmsg = "EagleSpy检测到不兼容的Windows操作系统，如果您遇到登录问题，请尝试转移到Windows 10";
			this.InitializeComponent();
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002D2D File Offset: 0x00000F2D
		private void Loginbtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002423 File Offset: 0x00000623
		private void Comptableform_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400034A RID: 842
		private string armsg;

		// Token: 0x0400034B RID: 843
		private string cnmsg;
	}
}
