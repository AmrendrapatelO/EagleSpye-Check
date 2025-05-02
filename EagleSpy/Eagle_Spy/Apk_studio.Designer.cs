namespace Eagle_Spy
{
	// Token: 0x02000015 RID: 21
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Apk_studio : global::System.Windows.Forms.Form
	{
		// Token: 0x060001CC RID: 460 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000DC14 File Offset: 0x0000BE14
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.workdirtext = new global::DrakeUI.Framework.DrakeUITextBox();
			this.selectapkbtn = new global::System.Windows.Forms.Button();
			this.TargetApktext = new global::DrakeUI.Framework.DrakeUITextBox();
			this.titlespanel = new global::System.Windows.Forms.Panel();
			this.vernamtext = new global::System.Windows.Forms.Label();
			this.vercodtext = new global::System.Windows.Forms.Label();
			this.pkgtext = new global::System.Windows.Forms.Label();
			this.nametext = new global::System.Windows.Forms.Label();
			this.BackgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.protectworker = new global::System.ComponentModel.BackgroundWorker();
			this.deworker = new global::System.ComponentModel.BackgroundWorker();
			this.COworker = new global::System.ComponentModel.BackgroundWorker();
			this.logtext = new global::DrakeUI.Framework.DrakeUIRichTextBox();
			this.loadingbar = new global::DrakeUI.Framework.DrakeUILoadingBar();
			this.guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientButton2 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientButton3 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2GradientButton4 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.drakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.savebtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.label8 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.probtn = new global::System.Windows.Forms.Button();
			this.cobtn = new global::System.Windows.Forms.Button();
			this.sinbtn = new global::System.Windows.Forms.Button();
			this.debtn = new global::System.Windows.Forms.Button();
			this.apkicon = new global::System.Windows.Forms.PictureBox();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.titlespanel.SuspendLayout();
			this.logtext.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.apkicon).BeginInit();
			base.SuspendLayout();
			this.workdirtext.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.workdirtext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.workdirtext.Enabled = false;
			this.workdirtext.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.workdirtext.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.workdirtext.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.workdirtext.ForeColor = global::System.Drawing.Color.White;
			this.workdirtext.ForeDisableColor = global::System.Drawing.Color.White;
			this.workdirtext.Location = new global::System.Drawing.Point(336, 112);
			this.workdirtext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.workdirtext.Maximum = 2147483647.0;
			this.workdirtext.Minimum = -2147483648.0;
			this.workdirtext.Name = "workdirtext";
			this.workdirtext.Padding = new global::System.Windows.Forms.Padding(5);
			this.workdirtext.Radius = 10;
			this.workdirtext.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.workdirtext.RectDisableColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.workdirtext.Size = new global::System.Drawing.Size(316, 27);
			this.workdirtext.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.workdirtext.StyleCustomMode = true;
			this.workdirtext.TabIndex = 46;
			this.workdirtext.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
			this.workdirtext.Watermark = "";
			this.selectapkbtn.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.selectapkbtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.selectapkbtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.selectapkbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectapkbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.selectapkbtn.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.selectapkbtn.Location = new global::System.Drawing.Point(306, 55);
			this.selectapkbtn.Margin = new global::System.Windows.Forms.Padding(2);
			this.selectapkbtn.Name = "selectapkbtn";
			this.selectapkbtn.Size = new global::System.Drawing.Size(98, 27);
			this.selectapkbtn.TabIndex = 45;
			this.selectapkbtn.Text = "Browse...";
			this.selectapkbtn.UseVisualStyleBackColor = false;
			this.selectapkbtn.Click += new global::System.EventHandler(this.Selectapkbtn_Click);
			this.TargetApktext.AllowDrop = true;
			this.TargetApktext.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.TargetApktext.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.TargetApktext.Enabled = false;
			this.TargetApktext.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.TargetApktext.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.TargetApktext.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.TargetApktext.ForeColor = global::System.Drawing.Color.White;
			this.TargetApktext.ForeDisableColor = global::System.Drawing.Color.White;
			this.TargetApktext.Location = new global::System.Drawing.Point(10, 55);
			this.TargetApktext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TargetApktext.Maximum = 2147483647.0;
			this.TargetApktext.Minimum = -2147483648.0;
			this.TargetApktext.Name = "TargetApktext";
			this.TargetApktext.Padding = new global::System.Windows.Forms.Padding(5);
			this.TargetApktext.Radius = 10;
			this.TargetApktext.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TargetApktext.RectDisableColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TargetApktext.Size = new global::System.Drawing.Size(290, 27);
			this.TargetApktext.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.TargetApktext.StyleCustomMode = true;
			this.TargetApktext.TabIndex = 44;
			this.TargetApktext.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
			this.TargetApktext.Watermark = "";
			this.TargetApktext.TextChanged += new global::System.EventHandler(this.TargetApktext_TextChanged);
			this.titlespanel.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.titlespanel.Controls.Add(this.vernamtext);
			this.titlespanel.Controls.Add(this.vercodtext);
			this.titlespanel.Controls.Add(this.pkgtext);
			this.titlespanel.Controls.Add(this.nametext);
			this.titlespanel.Enabled = false;
			this.titlespanel.Location = new global::System.Drawing.Point(132, 335);
			this.titlespanel.Margin = new global::System.Windows.Forms.Padding(2);
			this.titlespanel.Name = "titlespanel";
			this.titlespanel.Size = new global::System.Drawing.Size(211, 81);
			this.titlespanel.TabIndex = 50;
			this.vernamtext.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.vernamtext.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.vernamtext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.vernamtext.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.vernamtext.Location = new global::System.Drawing.Point(0, 57);
			this.vernamtext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.vernamtext.Name = "vernamtext";
			this.vernamtext.Size = new global::System.Drawing.Size(211, 19);
			this.vernamtext.TabIndex = 51;
			this.vernamtext.Text = "Version Name:";
			this.vernamtext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.vernamtext.Click += new global::System.EventHandler(this.Andtotext_Click);
			this.vercodtext.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.vercodtext.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.vercodtext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.vercodtext.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.vercodtext.Location = new global::System.Drawing.Point(0, 38);
			this.vercodtext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.vercodtext.Name = "vercodtext";
			this.vercodtext.Size = new global::System.Drawing.Size(211, 19);
			this.vercodtext.TabIndex = 50;
			this.vercodtext.Text = "Version Code:";
			this.vercodtext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.vercodtext.Click += new global::System.EventHandler(this.Andtotext_Click);
			this.pkgtext.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pkgtext.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pkgtext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.pkgtext.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.pkgtext.Location = new global::System.Drawing.Point(0, 19);
			this.pkgtext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.pkgtext.Name = "pkgtext";
			this.pkgtext.Size = new global::System.Drawing.Size(211, 19);
			this.pkgtext.TabIndex = 49;
			this.pkgtext.Text = "Package Name:";
			this.pkgtext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.pkgtext.Click += new global::System.EventHandler(this.Andtotext_Click);
			this.nametext.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.nametext.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.nametext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.nametext.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.nametext.Location = new global::System.Drawing.Point(0, 0);
			this.nametext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.nametext.Name = "nametext";
			this.nametext.Size = new global::System.Drawing.Size(211, 19);
			this.nametext.TabIndex = 48;
			this.nametext.Text = "App Name:";
			this.nametext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.nametext.Click += new global::System.EventHandler(this.Andtotext_Click);
			this.BackgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
			this.protectworker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.Protectworker_DoWork);
			this.deworker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.Deworker_DoWork);
			this.COworker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.COworker_DoWork);
			this.logtext.AutoScroll = true;
			this.logtext.AutoWordSelection = true;
			this.logtext.Controls.Add(this.loadingbar);
			this.logtext.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.logtext.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.logtext.ForeColor = global::System.Drawing.Color.Lime;
			this.logtext.Location = new global::System.Drawing.Point(336, 148);
			this.logtext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.logtext.Name = "logtext";
			this.logtext.Padding = new global::System.Windows.Forms.Padding(2);
			this.logtext.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.logtext.Size = new global::System.Drawing.Size(322, 384);
			this.logtext.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.logtext.TabIndex = 57;
			this.logtext.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.loadingbar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.loadingbar.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.loadingbar.Location = new global::System.Drawing.Point(120, 140);
			this.loadingbar.Name = "loadingbar";
			this.loadingbar.Size = new global::System.Drawing.Size(92, 85);
			this.loadingbar.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.loadingbar.TabIndex = 210;
			this.loadingbar.Text = "drakeUILoadingBar1";
			this.loadingbar.Visible = false;
			this.guna2GradientButton1.AutoRoundedCorners = true;
			this.guna2GradientButton1.BorderRadius = 12;
			this.guna2GradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton1.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientButton1.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton1.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton1.Location = new global::System.Drawing.Point(3, 486);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.Size = new global::System.Drawing.Size(154, 26);
			this.guna2GradientButton1.TabIndex = 58;
			this.guna2GradientButton1.Text = "AndroidManifest";
			this.guna2GradientButton1.Click += new global::System.EventHandler(this.guna2GradientButton1_Click);
			this.guna2GradientButton2.AutoRoundedCorners = true;
			this.guna2GradientButton2.BorderRadius = 12;
			this.guna2GradientButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton2.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientButton2.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton2.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton2.Location = new global::System.Drawing.Point(170, 486);
			this.guna2GradientButton2.Name = "guna2GradientButton2";
			this.guna2GradientButton2.Size = new global::System.Drawing.Size(154, 26);
			this.guna2GradientButton2.TabIndex = 59;
			this.guna2GradientButton2.Text = "Apktool.yml";
			this.guna2GradientButton3.AutoRoundedCorners = true;
			this.guna2GradientButton3.BorderRadius = 12;
			this.guna2GradientButton3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton3.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton3.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientButton3.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientButton3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton3.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton3.Location = new global::System.Drawing.Point(0, 544);
			this.guna2GradientButton3.Name = "guna2GradientButton3";
			this.guna2GradientButton3.Size = new global::System.Drawing.Size(154, 26);
			this.guna2GradientButton3.TabIndex = 60;
			this.guna2GradientButton3.Text = "Permissions";
			this.guna2GradientButton3.Click += new global::System.EventHandler(this.guna2GradientButton3_Click);
			this.guna2GradientButton4.AutoRoundedCorners = true;
			this.guna2GradientButton4.BorderRadius = 12;
			this.guna2GradientButton4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton4.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton4.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientButton4.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientButton4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton4.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton4.Location = new global::System.Drawing.Point(170, 544);
			this.guna2GradientButton4.Name = "guna2GradientButton4";
			this.guna2GradientButton4.Size = new global::System.Drawing.Size(154, 26);
			this.guna2GradientButton4.TabIndex = 61;
			this.guna2GradientButton4.Text = "Main Activity Smali";
			this.guna2GradientButton4.Click += new global::System.EventHandler(this.guna2GradientButton4_Click);
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.drakeUIButtonIcon3.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.drakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon3.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon3.FillDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.FillHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.FillPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.FillSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.Font = new global::System.Drawing.Font("Candara", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.drakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon3.ForeDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.ForePressColor = global::System.Drawing.Color.Aqua;
			this.drakeUIButtonIcon3.ForeSelectedColor = global::System.Drawing.Color.MediumSpringGreen;
			this.drakeUIButtonIcon3.Location = new global::System.Drawing.Point(444, 79);
			this.drakeUIButtonIcon3.Name = "drakeUIButtonIcon3";
			this.drakeUIButtonIcon3.RectColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.drakeUIButtonIcon3.Size = new global::System.Drawing.Size(208, 25);
			this.drakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon3.StyleCustomMode = true;
			this.drakeUIButtonIcon3.Symbol = 61564;
			this.drakeUIButtonIcon3.TabIndex = 64;
			this.drakeUIButtonIcon3.Text = "Go to folder";
			this.drakeUIButtonIcon3.TipsColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.drakeUIButtonIcon3.Click += new global::System.EventHandler(this.drakeUIButtonIcon3_Click);
			this.savebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.savebtn.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.savebtn.FillDisableColor = global::System.Drawing.Color.Empty;
			this.savebtn.FillHoverColor = global::System.Drawing.Color.Empty;
			this.savebtn.FillPressColor = global::System.Drawing.Color.Empty;
			this.savebtn.FillSelectedColor = global::System.Drawing.Color.Empty;
			this.savebtn.Font = new global::System.Drawing.Font("Candara", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.savebtn.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.savebtn.ForeDisableColor = global::System.Drawing.Color.Empty;
			this.savebtn.ForePressColor = global::System.Drawing.Color.Aqua;
			this.savebtn.ForeSelectedColor = global::System.Drawing.Color.MediumSpringGreen;
			this.savebtn.Location = new global::System.Drawing.Point(17, 436);
			this.savebtn.Name = "savebtn";
			this.savebtn.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.savebtn.RectDisableColor = global::System.Drawing.Color.Empty;
			this.savebtn.RectHoverColor = global::System.Drawing.Color.Empty;
			this.savebtn.RectPressColor = global::System.Drawing.Color.Empty;
			this.savebtn.RectSelectedColor = global::System.Drawing.Color.Empty;
			this.savebtn.RectSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.savebtn.Size = new global::System.Drawing.Size(94, 26);
			this.savebtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.savebtn.StyleCustomMode = true;
			this.savebtn.Symbol = 61611;
			this.savebtn.TabIndex = 65;
			this.savebtn.Text = "Save icon";
			this.savebtn.TipsColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.savebtn.Click += new global::System.EventHandler(this.savebtn_Click);
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(226, 9);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(127, 28);
			this.label8.TabIndex = 209;
			this.label8.Text = "Apk Tools";
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.button2.BackgroundImage = global::Eagle_Spy_Applications.UnZip;
			this.button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.button2.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.button2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.button2.Location = new global::System.Drawing.Point(10, 213);
			this.button2.Margin = new global::System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(80, 85);
			this.button2.TabIndex = 55;
			this.button2.Text = "Extract";
			this.button2.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = false;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.button1.BackgroundImage = global::Eagle_Spy_Applications.Zipalign;
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.button1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.button1.Location = new global::System.Drawing.Point(220, 213);
			this.button1.Margin = new global::System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(80, 85);
			this.button1.TabIndex = 54;
			this.button1.Text = "ZipAlign";
			this.button1.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = false;
			this.probtn.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.probtn.BackgroundImage = global::Eagle_Spy_Applications.protectapk;
			this.probtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.probtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.probtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.probtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.probtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.probtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.probtn.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.probtn.ImageAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.probtn.Location = new global::System.Drawing.Point(116, 213);
			this.probtn.Margin = new global::System.Windows.Forms.Padding(2);
			this.probtn.Name = "probtn";
			this.probtn.Size = new global::System.Drawing.Size(80, 85);
			this.probtn.TabIndex = 53;
			this.probtn.Text = "Protect";
			this.probtn.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.probtn.UseVisualStyleBackColor = false;
			this.probtn.Click += new global::System.EventHandler(this.Button5_Click);
			this.cobtn.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.cobtn.BackgroundImage = global::Eagle_Spy_Applications.Compile;
			this.cobtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.cobtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.cobtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.cobtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.cobtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.cobtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.cobtn.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.cobtn.Location = new global::System.Drawing.Point(116, 99);
			this.cobtn.Margin = new global::System.Windows.Forms.Padding(2);
			this.cobtn.Name = "cobtn";
			this.cobtn.Size = new global::System.Drawing.Size(80, 85);
			this.cobtn.TabIndex = 52;
			this.cobtn.Text = "Compile";
			this.cobtn.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.cobtn.UseVisualStyleBackColor = false;
			this.cobtn.Click += new global::System.EventHandler(this.Button4_Click);
			this.sinbtn.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.sinbtn.BackgroundImage = global::Eagle_Spy_Applications.sign;
			this.sinbtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.sinbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.sinbtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.sinbtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.sinbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.sinbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.sinbtn.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.sinbtn.Location = new global::System.Drawing.Point(220, 99);
			this.sinbtn.Margin = new global::System.Windows.Forms.Padding(2);
			this.sinbtn.Name = "sinbtn";
			this.sinbtn.Size = new global::System.Drawing.Size(80, 85);
			this.sinbtn.TabIndex = 51;
			this.sinbtn.Text = "Sign Apk";
			this.sinbtn.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.sinbtn.UseVisualStyleBackColor = false;
			this.sinbtn.Click += new global::System.EventHandler(this.Button3_Click);
			this.debtn.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.debtn.BackgroundImage = global::Eagle_Spy_Applications.Decompile;
			this.debtn.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.debtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.debtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.debtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.debtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.debtn.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.debtn.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.debtn.ImageAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.debtn.Location = new global::System.Drawing.Point(10, 98);
			this.debtn.Margin = new global::System.Windows.Forms.Padding(2);
			this.debtn.Name = "debtn";
			this.debtn.Size = new global::System.Drawing.Size(80, 85);
			this.debtn.TabIndex = 49;
			this.debtn.Text = "Decompile";
			this.debtn.TextAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.debtn.UseVisualStyleBackColor = false;
			this.debtn.Click += new global::System.EventHandler(this.Button2_Click);
			this.apkicon.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.apkicon.Location = new global::System.Drawing.Point(10, 323);
			this.apkicon.Margin = new global::System.Windows.Forms.Padding(2);
			this.apkicon.Name = "apkicon";
			this.apkicon.Size = new global::System.Drawing.Size(109, 103);
			this.apkicon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.apkicon.TabIndex = 0;
			this.apkicon.TabStop = false;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.Red;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(627, 3);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 210;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(674, 594);
			base.Controls.Add(this.cobtn);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.savebtn);
			base.Controls.Add(this.drakeUIButtonIcon3);
			base.Controls.Add(this.guna2GradientButton4);
			base.Controls.Add(this.guna2GradientButton3);
			base.Controls.Add(this.guna2GradientButton2);
			base.Controls.Add(this.guna2GradientButton1);
			base.Controls.Add(this.logtext);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.probtn);
			base.Controls.Add(this.sinbtn);
			base.Controls.Add(this.debtn);
			base.Controls.Add(this.titlespanel);
			base.Controls.Add(this.workdirtext);
			base.Controls.Add(this.apkicon);
			base.Controls.Add(this.TargetApktext);
			base.Controls.Add(this.selectapkbtn);
			this.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "Apk_studio";
			this.Text = "Apk Studio";
			base.Load += new global::System.EventHandler(this.Apk_studio_Load);
			this.titlespanel.ResumeLayout(false);
			this.logtext.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.apkicon).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000060 RID: 96
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000067 RID: 103
		internal global::DrakeUI.Framework.DrakeUITextBox TargetApktext;

		// Token: 0x04000068 RID: 104
		internal global::System.Windows.Forms.Button selectapkbtn;

		// Token: 0x04000069 RID: 105
		internal global::System.Windows.Forms.PictureBox apkicon;

		// Token: 0x0400006A RID: 106
		internal global::System.ComponentModel.BackgroundWorker BackgroundWorker1;

		// Token: 0x0400006B RID: 107
		internal global::System.Windows.Forms.Button debtn;

		// Token: 0x0400006C RID: 108
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("workdirtext")]
		internal global::DrakeUI.Framework.DrakeUITextBox workdirtext;

		// Token: 0x0400006D RID: 109
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("titlespanel")]
		internal global::System.Windows.Forms.Panel titlespanel;

		// Token: 0x0400006E RID: 110
		internal global::System.Windows.Forms.Label pkgtext;

		// Token: 0x0400006F RID: 111
		internal global::System.Windows.Forms.Label nametext;

		// Token: 0x04000070 RID: 112
		internal global::System.Windows.Forms.Label vernamtext;

		// Token: 0x04000071 RID: 113
		internal global::System.Windows.Forms.Label vercodtext;

		// Token: 0x04000072 RID: 114
		internal global::System.Windows.Forms.Button sinbtn;

		// Token: 0x04000073 RID: 115
		internal global::System.Windows.Forms.Button cobtn;

		// Token: 0x04000074 RID: 116
		internal global::System.Windows.Forms.Button probtn;

		// Token: 0x04000075 RID: 117
		internal global::System.ComponentModel.BackgroundWorker protectworker;

		// Token: 0x04000076 RID: 118
		internal global::System.ComponentModel.BackgroundWorker deworker;

		// Token: 0x04000077 RID: 119
		internal global::System.ComponentModel.BackgroundWorker COworker;

		// Token: 0x04000078 RID: 120
		internal global::System.Windows.Forms.Button button1;

		// Token: 0x04000079 RID: 121
		internal global::System.Windows.Forms.Button button2;

		// Token: 0x0400007A RID: 122
		private global::DrakeUI.Framework.DrakeUIRichTextBox logtext;

		// Token: 0x0400007B RID: 123
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;

		// Token: 0x0400007C RID: 124
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;

		// Token: 0x0400007D RID: 125
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;

		// Token: 0x0400007E RID: 126
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;

		// Token: 0x0400007F RID: 127
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000080 RID: 128
		private global::DrakeUI.Framework.DrakeUIButtonIcon savebtn;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000082 RID: 130
		private global::DrakeUI.Framework.DrakeUILoadingBar loadingbar;

		// Token: 0x04000083 RID: 131
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000084 RID: 132
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon3;
	}
}
