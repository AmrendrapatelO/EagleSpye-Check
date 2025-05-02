using System;
using System.Drawing;
using Eagle_Spy.My;

namespace Eagle_Spy
{
	// Token: 0x02000086 RID: 134
	public sealed class Notifications
	{
		// Token: 0x06000760 RID: 1888 RVA: 0x000047C1 File Offset: 0x000029C1
		public Notifications()
		{
			this.sizeHeight = MyProject.Forms.Report.Height;
		}

		// Token: 0x040008BF RID: 2239
		public Bitmap FLAG;

		// Token: 0x040008C0 RID: 2240
		public string TEXT;

		// Token: 0x040008C1 RID: 2241
		public int sizeHeight;

		// Token: 0x040008C2 RID: 2242
		public DateTime start;

		// Token: 0x040008C3 RID: 2243
		public bool startTime;
	}
}
