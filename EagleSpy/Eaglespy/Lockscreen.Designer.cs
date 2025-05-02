namespace Eaglespy
{
	// Token: 0x020000F1 RID: 241
	public partial class Lockscreen : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C4B RID: 3147 RVA: 0x00007767 File Offset: 0x00005967
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x001120A4 File Offset: 0x001102A4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.drakeUIButtonIcon8 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.guna2TextBox2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.drakeUIButtonIcon6 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.drakeUIButtonIcon5 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2CustomGradientPanel3 = new global::Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.guna2GradientCircleButton10 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton11 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton12 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton7 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton8 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton9 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton4 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton5 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton6 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton3 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton2 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.guna2GradientCircleButton1 = new global::Guna.UI2.WinForms.Guna2GradientCircleButton();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.ip = new global::System.Windows.Forms.Label();
			this.guna2CustomGradientPanel3.SuspendLayout();
			base.SuspendLayout();
			this.guna2BorderlessForm1.BorderRadius = 5;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.drakeUIButtonIcon8.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon8.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon8.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon8.Location = new global::System.Drawing.Point(41, 335);
			this.drakeUIButtonIcon8.Name = "drakeUIButtonIcon8";
			this.drakeUIButtonIcon8.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon8.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.drakeUIButtonIcon8.Size = new global::System.Drawing.Size(145, 25);
			this.drakeUIButtonIcon8.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon8.TabIndex = 3;
			this.drakeUIButtonIcon8.Text = "Show phishing";
			this.drakeUIButtonIcon8.Click += new global::System.EventHandler(this.drakeUIButtonIcon8_Click);
			this.guna2TextBox2.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2TextBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox2.DefaultText = "Enter Lock screen pin";
			this.guna2TextBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox2.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2TextBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox2.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox2.Location = new global::System.Drawing.Point(13, 286);
			this.guna2TextBox2.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2TextBox2.Name = "guna2TextBox2";
			this.guna2TextBox2.PasswordChar = '\0';
			this.guna2TextBox2.PlaceholderText = "";
			this.guna2TextBox2.SelectedText = "";
			this.guna2TextBox2.Size = new global::System.Drawing.Size(226, 28);
			this.guna2TextBox2.TabIndex = 2;
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Bahnschrift", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.label8.Location = new global::System.Drawing.Point(71, 248);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(74, 18);
			this.label8.TabIndex = 0;
			this.label8.Text = "PIN LOCK";
			this.drakeUIButtonIcon6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon6.FillColor = global::System.Drawing.Color.Transparent;
			this.drakeUIButtonIcon6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon6.ForeColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon6.Location = new global::System.Drawing.Point(13, 174);
			this.drakeUIButtonIcon6.Name = "drakeUIButtonIcon6";
			this.drakeUIButtonIcon6.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon6.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.drakeUIButtonIcon6.Size = new global::System.Drawing.Size(72, 25);
			this.drakeUIButtonIcon6.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon6.Symbol = 61534;
			this.drakeUIButtonIcon6.SymbolSize = 20;
			this.drakeUIButtonIcon6.TabIndex = 4;
			this.drakeUIButtonIcon6.Text = "Stop";
			this.drakeUIButtonIcon6.Click += new global::System.EventHandler(this.drakeUIButtonIcon6_Click);
			this.drakeUIButtonIcon5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon5.FillColor = global::System.Drawing.Color.Transparent;
			this.drakeUIButtonIcon5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon5.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.drakeUIButtonIcon5.Location = new global::System.Drawing.Point(165, 174);
			this.drakeUIButtonIcon5.Name = "drakeUIButtonIcon5";
			this.drakeUIButtonIcon5.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon5.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.drakeUIButtonIcon5.Size = new global::System.Drawing.Size(74, 25);
			this.drakeUIButtonIcon5.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon5.TabIndex = 3;
			this.drakeUIButtonIcon5.Text = "Start";
			this.drakeUIButtonIcon5.Click += new global::System.EventHandler(this.drakeUIButtonIcon5_Click);
			this.guna2TextBox1.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2TextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "Draw pattern Lock";
			this.guna2TextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2TextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TextBox1.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Location = new global::System.Drawing.Point(13, 124);
			this.guna2TextBox1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderText = "";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.Size = new global::System.Drawing.Size(226, 25);
			this.guna2TextBox1.TabIndex = 2;
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Bahnschrift", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.label7.Location = new global::System.Drawing.Point(59, 93);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(113, 18);
			this.label7.TabIndex = 0;
			this.label7.Text = "PATTERN LOCK";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(135, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(151, 28);
			this.label1.TabIndex = 211;
			this.label1.Text = "LockScreen";
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton10);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton11);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton12);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton7);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton8);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton9);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton4);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton5);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton6);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton3);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton2);
			this.guna2CustomGradientPanel3.Controls.Add(this.guna2GradientCircleButton1);
			this.guna2CustomGradientPanel3.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2CustomGradientPanel3.FillColor2 = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.guna2CustomGradientPanel3.FillColor3 = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2CustomGradientPanel3.FillColor4 = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.guna2CustomGradientPanel3.Location = new global::System.Drawing.Point(251, 62);
			this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
			this.guna2CustomGradientPanel3.Size = new global::System.Drawing.Size(208, 315);
			this.guna2CustomGradientPanel3.TabIndex = 212;
			this.guna2GradientCircleButton10.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton10.BorderThickness = 1;
			this.guna2GradientCircleButton10.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton10.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton10.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton10.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton10.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton10.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton10.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton10.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton10.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton10.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton10.Location = new global::System.Drawing.Point(153, 254);
			this.guna2GradientCircleButton10.Name = "guna2GradientCircleButton10";
			this.guna2GradientCircleButton10.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton10.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton10.TabIndex = 11;
			this.guna2GradientCircleButton10.Text = "✔";
			this.guna2GradientCircleButton10.Click += new global::System.EventHandler(this.guna2GradientCircleButton10_Click);
			this.guna2GradientCircleButton11.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton11.BorderThickness = 1;
			this.guna2GradientCircleButton11.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton11.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton11.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton11.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton11.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton11.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton11.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton11.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton11.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton11.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton11.Location = new global::System.Drawing.Point(82, 254);
			this.guna2GradientCircleButton11.Name = "guna2GradientCircleButton11";
			this.guna2GradientCircleButton11.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton11.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton11.TabIndex = 10;
			this.guna2GradientCircleButton11.Text = "0";
			this.guna2GradientCircleButton11.Click += new global::System.EventHandler(this.guna2GradientCircleButton11_Click);
			this.guna2GradientCircleButton12.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton12.BorderThickness = 1;
			this.guna2GradientCircleButton12.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton12.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton12.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton12.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton12.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton12.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton12.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton12.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton12.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton12.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton12.Location = new global::System.Drawing.Point(12, 254);
			this.guna2GradientCircleButton12.Name = "guna2GradientCircleButton12";
			this.guna2GradientCircleButton12.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton12.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton12.TabIndex = 9;
			this.guna2GradientCircleButton12.Text = "X";
			this.guna2GradientCircleButton12.Click += new global::System.EventHandler(this.guna2GradientCircleButton12_Click);
			this.guna2GradientCircleButton7.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton7.BorderThickness = 1;
			this.guna2GradientCircleButton7.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton7.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton7.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton7.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton7.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton7.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton7.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton7.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton7.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton7.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton7.Location = new global::System.Drawing.Point(153, 177);
			this.guna2GradientCircleButton7.Name = "guna2GradientCircleButton7";
			this.guna2GradientCircleButton7.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton7.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton7.TabIndex = 8;
			this.guna2GradientCircleButton7.Text = "9";
			this.guna2GradientCircleButton7.Click += new global::System.EventHandler(this.guna2GradientCircleButton7_Click);
			this.guna2GradientCircleButton8.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton8.BorderThickness = 1;
			this.guna2GradientCircleButton8.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton8.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton8.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton8.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton8.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton8.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton8.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton8.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton8.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton8.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton8.Location = new global::System.Drawing.Point(82, 177);
			this.guna2GradientCircleButton8.Name = "guna2GradientCircleButton8";
			this.guna2GradientCircleButton8.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton8.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton8.TabIndex = 7;
			this.guna2GradientCircleButton8.Text = "8";
			this.guna2GradientCircleButton8.Click += new global::System.EventHandler(this.guna2GradientCircleButton8_Click);
			this.guna2GradientCircleButton9.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton9.BorderThickness = 1;
			this.guna2GradientCircleButton9.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton9.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton9.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton9.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton9.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton9.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton9.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton9.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton9.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton9.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton9.Location = new global::System.Drawing.Point(12, 177);
			this.guna2GradientCircleButton9.Name = "guna2GradientCircleButton9";
			this.guna2GradientCircleButton9.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton9.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton9.TabIndex = 6;
			this.guna2GradientCircleButton9.Text = "7";
			this.guna2GradientCircleButton9.Click += new global::System.EventHandler(this.guna2GradientCircleButton9_Click);
			this.guna2GradientCircleButton4.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton4.BorderThickness = 1;
			this.guna2GradientCircleButton4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton4.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton4.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton4.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton4.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton4.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton4.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton4.Location = new global::System.Drawing.Point(153, 93);
			this.guna2GradientCircleButton4.Name = "guna2GradientCircleButton4";
			this.guna2GradientCircleButton4.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton4.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton4.TabIndex = 5;
			this.guna2GradientCircleButton4.Text = "6";
			this.guna2GradientCircleButton4.Click += new global::System.EventHandler(this.guna2GradientCircleButton4_Click);
			this.guna2GradientCircleButton5.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton5.BorderThickness = 1;
			this.guna2GradientCircleButton5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton5.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton5.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton5.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton5.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton5.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton5.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton5.Location = new global::System.Drawing.Point(82, 93);
			this.guna2GradientCircleButton5.Name = "guna2GradientCircleButton5";
			this.guna2GradientCircleButton5.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton5.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton5.TabIndex = 4;
			this.guna2GradientCircleButton5.Text = "5";
			this.guna2GradientCircleButton5.Click += new global::System.EventHandler(this.guna2GradientCircleButton5_Click);
			this.guna2GradientCircleButton6.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton6.BorderThickness = 1;
			this.guna2GradientCircleButton6.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton6.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton6.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton6.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton6.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton6.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton6.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton6.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton6.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton6.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton6.Location = new global::System.Drawing.Point(12, 93);
			this.guna2GradientCircleButton6.Name = "guna2GradientCircleButton6";
			this.guna2GradientCircleButton6.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton6.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton6.TabIndex = 3;
			this.guna2GradientCircleButton6.Text = "4";
			this.guna2GradientCircleButton6.Click += new global::System.EventHandler(this.guna2GradientCircleButton6_Click);
			this.guna2GradientCircleButton3.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton3.BorderThickness = 1;
			this.guna2GradientCircleButton3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton3.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton3.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton3.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton3.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton3.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton3.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton3.Location = new global::System.Drawing.Point(153, 17);
			this.guna2GradientCircleButton3.Name = "guna2GradientCircleButton3";
			this.guna2GradientCircleButton3.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton3.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton3.TabIndex = 2;
			this.guna2GradientCircleButton3.Text = "3";
			this.guna2GradientCircleButton3.Click += new global::System.EventHandler(this.guna2GradientCircleButton3_Click);
			this.guna2GradientCircleButton2.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton2.BorderThickness = 1;
			this.guna2GradientCircleButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton2.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton2.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton2.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton2.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton2.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton2.Location = new global::System.Drawing.Point(82, 17);
			this.guna2GradientCircleButton2.Name = "guna2GradientCircleButton2";
			this.guna2GradientCircleButton2.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton2.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton2.TabIndex = 1;
			this.guna2GradientCircleButton2.Text = "2";
			this.guna2GradientCircleButton2.Click += new global::System.EventHandler(this.guna2GradientCircleButton2_Click);
			this.guna2GradientCircleButton1.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2GradientCircleButton1.BorderThickness = 1;
			this.guna2GradientCircleButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientCircleButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientCircleButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientCircleButton1.FillColor = global::System.Drawing.Color.MidnightBlue;
			this.guna2GradientCircleButton1.FillColor2 = global::System.Drawing.Color.Navy;
			this.guna2GradientCircleButton1.FocusedColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.guna2GradientCircleButton1.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2GradientCircleButton1.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientCircleButton1.Location = new global::System.Drawing.Point(12, 17);
			this.guna2GradientCircleButton1.Name = "guna2GradientCircleButton1";
			this.guna2GradientCircleButton1.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2GradientCircleButton1.Size = new global::System.Drawing.Size(45, 45);
			this.guna2GradientCircleButton1.TabIndex = 0;
			this.guna2GradientCircleButton1.Text = "1";
			this.guna2GradientCircleButton1.Click += new global::System.EventHandler(this.guna2GradientCircleButton1_Click);
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.Red;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(423, 8);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 213;
			this.ip.AutoSize = true;
			this.ip.Location = new global::System.Drawing.Point(321, 23);
			this.ip.Name = "ip";
			this.ip.Size = new global::System.Drawing.Size(35, 13);
			this.ip.TabIndex = 214;
			this.ip.Text = "label2";
			this.ip.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(471, 436);
			base.Controls.Add(this.ip);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.guna2CustomGradientPanel3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.guna2TextBox1);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.drakeUIButtonIcon6);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.drakeUIButtonIcon5);
			base.Controls.Add(this.guna2TextBox2);
			base.Controls.Add(this.drakeUIButtonIcon8);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Lockscreen";
			this.Text = " ";
			base.Load += new global::System.EventHandler(this.Lockscreen_Load);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Lockscreen_KeyDown);
			this.guna2CustomGradientPanel3.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F89 RID: 3977
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000F8A RID: 3978
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000F8B RID: 3979
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon8;

		// Token: 0x04000F8C RID: 3980
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;

		// Token: 0x04000F8D RID: 3981
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000F8E RID: 3982
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon6;

		// Token: 0x04000F8F RID: 3983
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon5;

		// Token: 0x04000F90 RID: 3984
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;

		// Token: 0x04000F91 RID: 3985
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000F92 RID: 3986
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000F93 RID: 3987
		private global::Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;

		// Token: 0x04000F94 RID: 3988
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton10;

		// Token: 0x04000F95 RID: 3989
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton11;

		// Token: 0x04000F96 RID: 3990
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton12;

		// Token: 0x04000F97 RID: 3991
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton7;

		// Token: 0x04000F98 RID: 3992
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton8;

		// Token: 0x04000F99 RID: 3993
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton9;

		// Token: 0x04000F9A RID: 3994
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton4;

		// Token: 0x04000F9B RID: 3995
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton5;

		// Token: 0x04000F9C RID: 3996
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton6;

		// Token: 0x04000F9D RID: 3997
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton3;

		// Token: 0x04000F9E RID: 3998
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton2;

		// Token: 0x04000F9F RID: 3999
		private global::Guna.UI2.WinForms.Guna2GradientCircleButton guna2GradientCircleButton1;

		// Token: 0x04000FA0 RID: 4000
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000FA1 RID: 4001
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000FA2 RID: 4002
		private global::System.Windows.Forms.Label ip;
	}
}
