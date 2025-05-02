namespace Eagle_Spy
{
	// Token: 0x02000041 RID: 65
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Drooper : global::System.Windows.Forms.Form
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x00058F14 File Offset: 0x00057114
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

		// Token: 0x06000451 RID: 1105 RVA: 0x00058F54 File Offset: 0x00057154
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.selectapkbtn = new global::System.Windows.Forms.Button();
			this.TapkText = new global::DrakeUI.Framework.DrakeUITextBox();
			this.BackgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.labelid = new global::System.Windows.Forms.Label();
			this.labelname = new global::System.Windows.Forms.Label();
			this.textpkgname = new global::DrakeUI.Framework.DrakeUITextBox();
			this.textappname = new global::DrakeUI.Framework.DrakeUITextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.logtext = new global::System.Windows.Forms.RichTextBox();
			this.WorkWorker = new global::System.ComponentModel.BackgroundWorker();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.label8 = new global::System.Windows.Forms.Label();
			this.guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2TextBox2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2TextBox3 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.apkicon = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.guna2TextBox4 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2TextBox5 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.sPanel1 = new global::Sipaa.Framework.SPanel();
			this.guna2TextBox6 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.pictureBox5 = new global::System.Windows.Forms.PictureBox();
			this.guna2TextBox7 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2TextBox8 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.apkicon).BeginInit();
			this.sPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
			base.SuspendLayout();
			this.selectapkbtn.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.selectapkbtn.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.selectapkbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectapkbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.selectapkbtn.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.selectapkbtn.Location = new global::System.Drawing.Point(332, 97);
			this.selectapkbtn.Margin = new global::System.Windows.Forms.Padding(2);
			this.selectapkbtn.Name = "selectapkbtn";
			this.selectapkbtn.Size = new global::System.Drawing.Size(91, 35);
			this.selectapkbtn.TabIndex = 47;
			this.selectapkbtn.Text = "Select Apk";
			this.selectapkbtn.UseVisualStyleBackColor = true;
			this.selectapkbtn.Click += new global::System.EventHandler(this.Selectapkbtn_Click);
			this.TapkText.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.TapkText.Enabled = false;
			this.TapkText.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.TapkText.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.TapkText.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.TapkText.ForeColor = global::System.Drawing.Color.White;
			this.TapkText.ForeDisableColor = global::System.Drawing.Color.White;
			this.TapkText.Location = new global::System.Drawing.Point(29, 48);
			this.TapkText.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TapkText.Maximum = 2147483647.0;
			this.TapkText.Minimum = -2147483648.0;
			this.TapkText.Name = "TapkText";
			this.TapkText.Padding = new global::System.Windows.Forms.Padding(5);
			this.TapkText.Radius = 10;
			this.TapkText.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TapkText.RectDisableColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TapkText.Size = new global::System.Drawing.Size(404, 27);
			this.TapkText.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.TapkText.StyleCustomMode = true;
			this.TapkText.TabIndex = 46;
			this.TapkText.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
			this.TapkText.Watermark = "Path";
			this.BackgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
			this.labelid.AutoSize = true;
			this.labelid.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.labelid.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.labelid.Location = new global::System.Drawing.Point(150, 222);
			this.labelid.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelid.Name = "labelid";
			this.labelid.Size = new global::System.Drawing.Size(92, 17);
			this.labelid.TabIndex = 50;
			this.labelid.Text = "Package Name";
			this.labelname.AutoSize = true;
			this.labelname.Font = new global::System.Drawing.Font("Calibri", 10f);
			this.labelname.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.labelname.Location = new global::System.Drawing.Point(150, 182);
			this.labelname.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelname.Name = "labelname";
			this.labelname.Size = new global::System.Drawing.Size(67, 17);
			this.labelname.TabIndex = 49;
			this.labelname.Text = "App Name";
			this.textpkgname.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textpkgname.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.textpkgname.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.textpkgname.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.textpkgname.ForeColor = global::System.Drawing.Color.White;
			this.textpkgname.ForeDisableColor = global::System.Drawing.Color.White;
			this.textpkgname.Location = new global::System.Drawing.Point(269, 218);
			this.textpkgname.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textpkgname.Maximum = 2147483647.0;
			this.textpkgname.Minimum = -2147483648.0;
			this.textpkgname.Name = "textpkgname";
			this.textpkgname.Padding = new global::System.Windows.Forms.Padding(5);
			this.textpkgname.Radius = 10;
			this.textpkgname.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.textpkgname.RectDisableColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.textpkgname.Size = new global::System.Drawing.Size(190, 27);
			this.textpkgname.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.textpkgname.StyleCustomMode = true;
			this.textpkgname.TabIndex = 48;
			this.textpkgname.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
			this.textpkgname.Watermark = "";
			this.textappname.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textappname.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.textappname.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.textappname.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.textappname.ForeColor = global::System.Drawing.Color.White;
			this.textappname.ForeDisableColor = global::System.Drawing.Color.White;
			this.textappname.Location = new global::System.Drawing.Point(269, 182);
			this.textappname.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textappname.Maximum = 2147483647.0;
			this.textappname.Minimum = -2147483648.0;
			this.textappname.Name = "textappname";
			this.textappname.Padding = new global::System.Windows.Forms.Padding(5);
			this.textappname.Radius = 10;
			this.textappname.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.textappname.RectDisableColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.textappname.Size = new global::System.Drawing.Size(190, 27);
			this.textappname.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.textappname.StyleCustomMode = true;
			this.textappname.TabIndex = 47;
			this.textappname.TextAlignment = global::System.Drawing.ContentAlignment.TopLeft;
			this.textappname.Watermark = "";
			this.textappname.TextChanged += new global::System.EventHandler(this.textappname_TextChanged);
			this.Button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Button1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.Button1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Button1.Location = new global::System.Drawing.Point(29, 249);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(2);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(94, 26);
			this.Button1.TabIndex = 48;
			this.Button1.Text = "icon";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.Button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Button2.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button2.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.Button2.ForeColor = global::System.Drawing.Color.Lime;
			this.Button2.Location = new global::System.Drawing.Point(79, 522);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(2);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(323, 51);
			this.Button2.TabIndex = 49;
			this.Button2.Text = "Build Dropper";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.Click += new global::System.EventHandler(this.Button2_Click);
			this.logtext.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.logtext.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.logtext.Font = new global::System.Drawing.Font("Calibri", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.logtext.ForeColor = global::System.Drawing.Color.MediumSpringGreen;
			this.logtext.Location = new global::System.Drawing.Point(79, 291);
			this.logtext.Margin = new global::System.Windows.Forms.Padding(2);
			this.logtext.Name = "logtext";
			this.logtext.ReadOnly = true;
			this.logtext.Size = new global::System.Drawing.Size(316, 213);
			this.logtext.TabIndex = 51;
			this.logtext.Text = "";
			this.WorkWorker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.WorkWorker_DoWork);
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(119, 9);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(199, 28);
			this.label8.TabIndex = 208;
			this.label8.Text = "Secure Dropper";
			this.guna2TextBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2TextBox1.BorderColor = global::System.Drawing.Color.DarkSlateGray;
			this.guna2TextBox1.BorderRadius = 10;
			this.guna2TextBox1.BorderThickness = 0;
			this.guna2TextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "Update now";
			this.guna2TextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.FillColor = global::System.Drawing.Color.Teal;
			this.guna2TextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2TextBox1.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Location = new global::System.Drawing.Point(529, 522);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderText = "";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.Size = new global::System.Drawing.Size(223, 31);
			this.guna2TextBox1.TabIndex = 214;
			this.guna2TextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.guna2TextBox2.BorderThickness = 0;
			this.guna2TextBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox2.DefaultText = "Update available";
			this.guna2TextBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox2.FillColor = global::System.Drawing.Color.FromArgb(45, 50, 80);
			this.guna2TextBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox2.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox2.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox2.Location = new global::System.Drawing.Point(4, 40);
			this.guna2TextBox2.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2TextBox2.Name = "guna2TextBox2";
			this.guna2TextBox2.PasswordChar = '\0';
			this.guna2TextBox2.PlaceholderText = "";
			this.guna2TextBox2.SelectedText = "";
			this.guna2TextBox2.Size = new global::System.Drawing.Size(183, 25);
			this.guna2TextBox2.TabIndex = 1;
			this.guna2TextBox3.BorderThickness = 0;
			this.guna2TextBox3.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox3.DefaultText = "To use this app, download the latest version";
			this.guna2TextBox3.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox3.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox3.FillColor = global::System.Drawing.Color.FromArgb(45, 50, 80);
			this.guna2TextBox3.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox3.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox3.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox3.Location = new global::System.Drawing.Point(1, 72);
			this.guna2TextBox3.Name = "guna2TextBox3";
			this.guna2TextBox3.PasswordChar = '\0';
			this.guna2TextBox3.PlaceholderText = "";
			this.guna2TextBox3.SelectedText = "";
			this.guna2TextBox3.Size = new global::System.Drawing.Size(245, 20);
			this.guna2TextBox3.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(48, 105);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(71, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "app name";
			this.pictureBox4.Image = global::Eagle_Spy_Applications.Screenshot_2024_03_18_191904;
			this.pictureBox4.Location = new global::System.Drawing.Point(53, 127);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(15, 15);
			this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			this.pictureBox3.BackColor = global::System.Drawing.Color.DarkGray;
			this.pictureBox3.Location = new global::System.Drawing.Point(8, 105);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(34, 37);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			this.pictureBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::Eagle_Spy_Applications.glogo;
			this.pictureBox2.Location = new global::System.Drawing.Point(0, -10);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(129, 55);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Eagle_Spy_Applications.modern_oval_notch_smartphone_realistic_mockup_Photoroom_png_Photoroom;
			this.pictureBox1.Location = new global::System.Drawing.Point(495, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(300, 583);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 212;
			this.pictureBox1.TabStop = false;
			this.apkicon.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.apkicon.Location = new global::System.Drawing.Point(29, 159);
			this.apkicon.Margin = new global::System.Windows.Forms.Padding(2);
			this.apkicon.Name = "apkicon";
			this.apkicon.Size = new global::System.Drawing.Size(94, 80);
			this.apkicon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.apkicon.TabIndex = 3;
			this.apkicon.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(74, 127);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(52, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Everyone";
			this.guna2TextBox4.BorderThickness = 0;
			this.guna2TextBox4.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox4.DefaultText = "What's New";
			this.guna2TextBox4.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox4.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox4.FillColor = global::System.Drawing.Color.FromArgb(45, 50, 80);
			this.guna2TextBox4.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox4.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox4.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox4.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox4.Location = new global::System.Drawing.Point(9, 156);
			this.guna2TextBox4.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.guna2TextBox4.Name = "guna2TextBox4";
			this.guna2TextBox4.PasswordChar = '\0';
			this.guna2TextBox4.PlaceholderText = "";
			this.guna2TextBox4.SelectedText = "";
			this.guna2TextBox4.Size = new global::System.Drawing.Size(167, 20);
			this.guna2TextBox4.TabIndex = 8;
			this.guna2TextBox5.BorderThickness = 0;
			this.guna2TextBox5.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox5.DefaultText = "Updated on feb 9, 2024";
			this.guna2TextBox5.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox5.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox5.FillColor = global::System.Drawing.Color.FromArgb(45, 50, 80);
			this.guna2TextBox5.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox5.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox5.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox5.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox5.Location = new global::System.Drawing.Point(8, 175);
			this.guna2TextBox5.Name = "guna2TextBox5";
			this.guna2TextBox5.PasswordChar = '\0';
			this.guna2TextBox5.PlaceholderText = "";
			this.guna2TextBox5.SelectedText = "";
			this.guna2TextBox5.Size = new global::System.Drawing.Size(202, 20);
			this.guna2TextBox5.TabIndex = 9;
			this.sPanel1.BackColor = global::System.Drawing.Color.FromArgb(45, 50, 80);
			this.sPanel1.BorderColor = global::System.Drawing.Color.PaleVioletRed;
			this.sPanel1.BorderRadius = 6;
			this.sPanel1.BorderSize = 0;
			this.sPanel1.Controls.Add(this.guna2TextBox5);
			this.sPanel1.Controls.Add(this.guna2TextBox2);
			this.sPanel1.Controls.Add(this.guna2TextBox4);
			this.sPanel1.Controls.Add(this.pictureBox2);
			this.sPanel1.Controls.Add(this.label2);
			this.sPanel1.Controls.Add(this.guna2TextBox3);
			this.sPanel1.Controls.Add(this.pictureBox4);
			this.sPanel1.Controls.Add(this.pictureBox3);
			this.sPanel1.Controls.Add(this.label1);
			this.sPanel1.ForeColor = global::System.Drawing.Color.White;
			this.sPanel1.Location = new global::System.Drawing.Point(516, 318);
			this.sPanel1.Name = "sPanel1";
			this.sPanel1.Size = new global::System.Drawing.Size(247, 201);
			this.sPanel1.TabIndex = 215;
			this.guna2TextBox6.AutoRoundedCorners = true;
			this.guna2TextBox6.BorderRadius = 15;
			this.guna2TextBox6.BorderThickness = 0;
			this.guna2TextBox6.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox6.DefaultText = "UPDATE";
			this.guna2TextBox6.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox6.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox6.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox6.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox6.FillColor = global::System.Drawing.Color.FromArgb(45, 50, 80);
			this.guna2TextBox6.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox6.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox6.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox6.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox6.Location = new global::System.Drawing.Point(567, 279);
			this.guna2TextBox6.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2TextBox6.Name = "guna2TextBox6";
			this.guna2TextBox6.PasswordChar = '\0';
			this.guna2TextBox6.PlaceholderText = "";
			this.guna2TextBox6.SelectedText = "";
			this.guna2TextBox6.Size = new global::System.Drawing.Size(133, 32);
			this.guna2TextBox6.TabIndex = 216;
			this.guna2TextBox6.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.pictureBox5.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.pictureBox5.Location = new global::System.Drawing.Point(610, 90);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new global::System.Drawing.Size(56, 54);
			this.pictureBox5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 217;
			this.pictureBox5.TabStop = false;
			this.guna2TextBox7.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2TextBox7.BorderThickness = 0;
			this.guna2TextBox7.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox7.DefaultText = "We have added numerous new features and fixed some bugs to make the app as comfortable as possible for you";
			this.guna2TextBox7.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox7.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox7.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox7.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox7.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2TextBox7.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox7.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox7.ForeColor = global::System.Drawing.Color.LightGray;
			this.guna2TextBox7.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox7.Location = new global::System.Drawing.Point(552, 179);
			this.guna2TextBox7.Multiline = true;
			this.guna2TextBox7.Name = "guna2TextBox7";
			this.guna2TextBox7.PasswordChar = '\0';
			this.guna2TextBox7.PlaceholderText = "";
			this.guna2TextBox7.SelectedText = "";
			this.guna2TextBox7.Size = new global::System.Drawing.Size(174, 92);
			this.guna2TextBox7.TabIndex = 218;
			this.guna2TextBox8.AutoRoundedCorners = true;
			this.guna2TextBox8.BorderRadius = 9;
			this.guna2TextBox8.BorderThickness = 0;
			this.guna2TextBox8.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox8.DefaultText = "Time for Updates!";
			this.guna2TextBox8.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox8.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox8.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox8.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox8.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2TextBox8.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox8.Font = new global::System.Drawing.Font("Segoe UI Semibold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox8.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox8.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox8.Location = new global::System.Drawing.Point(548, 151);
			this.guna2TextBox8.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2TextBox8.Name = "guna2TextBox8";
			this.guna2TextBox8.PasswordChar = '\0';
			this.guna2TextBox8.PlaceholderText = "";
			this.guna2TextBox8.SelectedText = "";
			this.guna2TextBox8.Size = new global::System.Drawing.Size(186, 21);
			this.guna2TextBox8.TabIndex = 220;
			this.guna2TextBox8.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.Red;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(764, -1);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 221;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(812, 604);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.guna2TextBox8);
			base.Controls.Add(this.guna2TextBox7);
			base.Controls.Add(this.pictureBox5);
			base.Controls.Add(this.guna2TextBox6);
			base.Controls.Add(this.sPanel1);
			base.Controls.Add(this.guna2TextBox1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.labelid);
			base.Controls.Add(this.TapkText);
			base.Controls.Add(this.labelname);
			base.Controls.Add(this.selectapkbtn);
			base.Controls.Add(this.textpkgname);
			base.Controls.Add(this.textappname);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.logtext);
			base.Controls.Add(this.apkicon);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "Drooper";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dropper";
			base.Load += new global::System.EventHandler(this.Drooper_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.apkicon).EndInit();
			this.sPanel1.ResumeLayout(false);
			this.sPanel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003A9 RID: 937
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003D0 RID: 976
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("TapkText")]
		internal global::DrakeUI.Framework.DrakeUITextBox TapkText;

		// Token: 0x040003D1 RID: 977
		internal global::System.ComponentModel.BackgroundWorker BackgroundWorker1;

		// Token: 0x040003D2 RID: 978
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("apkicon")]
		internal global::System.Windows.Forms.PictureBox apkicon;

		// Token: 0x040003D3 RID: 979
		internal global::System.Windows.Forms.Button selectapkbtn;

		// Token: 0x040003D4 RID: 980
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("labelid")]
		internal global::System.Windows.Forms.Label labelid;

		// Token: 0x040003D5 RID: 981
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("labelname")]
		internal global::System.Windows.Forms.Label labelname;

		// Token: 0x040003D6 RID: 982
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("textpkgname")]
		internal global::DrakeUI.Framework.DrakeUITextBox textpkgname;

		// Token: 0x040003D7 RID: 983
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("textappname")]
		internal global::DrakeUI.Framework.DrakeUITextBox textappname;

		// Token: 0x040003D8 RID: 984
		internal global::System.Windows.Forms.Button Button1;

		// Token: 0x040003D9 RID: 985
		internal global::System.Windows.Forms.Button Button2;

		// Token: 0x040003DA RID: 986
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("logtext")]
		internal global::System.Windows.Forms.RichTextBox logtext;

		// Token: 0x040003DB RID: 987
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x040003DC RID: 988
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040003DD RID: 989
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040003DE RID: 990
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;

		// Token: 0x040003DF RID: 991
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x040003E0 RID: 992
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;

		// Token: 0x040003E1 RID: 993
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;

		// Token: 0x040003E2 RID: 994
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x040003E3 RID: 995
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x040003E4 RID: 996
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003E5 RID: 997
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040003E6 RID: 998
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;

		// Token: 0x040003E7 RID: 999
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;

		// Token: 0x040003E8 RID: 1000
		private global::Sipaa.Framework.SPanel sPanel1;

		// Token: 0x040003E9 RID: 1001
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;

		// Token: 0x040003EA RID: 1002
		private global::System.Windows.Forms.PictureBox pictureBox5;

		// Token: 0x040003EB RID: 1003
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;

		// Token: 0x040003EC RID: 1004
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox8;

		// Token: 0x040003ED RID: 1005
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x040003EE RID: 1006
		internal global::System.ComponentModel.BackgroundWorker WorkWorker;
	}
}
