using System;
using System.Windows.Forms;

namespace Eagle_Spy
{
	// Token: 0x02000088 RID: 136
	public class PBar : ProgressBar
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x000C10C8 File Offset: 0x000BF2C8
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.Style |= 4;
				return createParams;
			}
		}
	}
}
