namespace Eagle_Spy
{
	// Token: 0x0200009F RID: 159
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ScreenReader : global::System.Windows.Forms.Form
	{
		// Token: 0x0600084B RID: 2123 RVA: 0x000CDEA0 File Offset: 0x000CC0A0
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

		// Token: 0x0600084C RID: 2124 RVA: 0x000CDEE0 File Offset: 0x000CC0E0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.drakeUIGradientPanel1 = new global::DrakeUI.Framework.DrakeUIGradientPanel();
			this.sButton3 = new global::Sipaa.Framework.SButton();
			this.sButton2 = new global::Sipaa.Framework.SButton();
			this.sButton1 = new global::Sipaa.Framework.SButton();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.drakeUIButtonIcon5 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.label1 = new global::System.Windows.Forms.Label();
			this.DrakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.disablebtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.enablebtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.viewpanel = new global::Sipaa.Framework.SPanel();
			this.textBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.drakeUIGradientPanel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			base.SuspendLayout();
			this.drakeUIGradientPanel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIGradientPanel1.Controls.Add(this.sButton3);
			this.drakeUIGradientPanel1.Controls.Add(this.sButton2);
			this.drakeUIGradientPanel1.Controls.Add(this.sButton1);
			this.drakeUIGradientPanel1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIGradientPanel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIGradientPanel1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIGradientPanel1.ForeDisableColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIGradientPanel1.Location = new global::System.Drawing.Point(5, 611);
			this.drakeUIGradientPanel1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.drakeUIGradientPanel1.Name = "drakeUIGradientPanel1";
			this.drakeUIGradientPanel1.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIGradientPanel1.RectDisableColor = global::System.Drawing.Color.Red;
			this.drakeUIGradientPanel1.Size = new global::System.Drawing.Size(616, 38);
			this.drakeUIGradientPanel1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIGradientPanel1.TabIndex = 25;
			this.drakeUIGradientPanel1.Text = null;
			this.sButton3.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.sButton3.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.sButton3.BorderRadius = 6;
			this.sButton3.BorderSize = 2;
			this.sButton3.FlatAppearance.BorderSize = 0;
			this.sButton3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.sButton3.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sButton3.ForeColor = global::System.Drawing.Color.White;
			this.sButton3.Location = new global::System.Drawing.Point(428, 7);
			this.sButton3.Name = "sButton3";
			this.sButton3.Size = new global::System.Drawing.Size(84, 28);
			this.sButton3.TabIndex = 5;
			this.sButton3.Text = "Save";
			this.sButton3.UseVisualStyleBackColor = false;
			this.sButton3.Click += new global::System.EventHandler(this.sButton3_Click);
			this.sButton2.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.sButton2.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.sButton2.BorderRadius = 6;
			this.sButton2.BorderSize = 2;
			this.sButton2.FlatAppearance.BorderSize = 0;
			this.sButton2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.sButton2.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sButton2.ForeColor = global::System.Drawing.Color.White;
			this.sButton2.Location = new global::System.Drawing.Point(192, 4);
			this.sButton2.Name = "sButton2";
			this.sButton2.Size = new global::System.Drawing.Size(84, 28);
			this.sButton2.TabIndex = 4;
			this.sButton2.Text = "Stop";
			this.sButton2.UseVisualStyleBackColor = false;
			this.sButton2.Click += new global::System.EventHandler(this.sButton2_Click);
			this.sButton1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.sButton1.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.sButton1.BorderRadius = 6;
			this.sButton1.BorderSize = 2;
			this.sButton1.FlatAppearance.BorderSize = 0;
			this.sButton1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.sButton1.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sButton1.ForeColor = global::System.Drawing.Color.White;
			this.sButton1.Location = new global::System.Drawing.Point(12, 4);
			this.sButton1.Name = "sButton1";
			this.sButton1.Size = new global::System.Drawing.Size(84, 28);
			this.sButton1.TabIndex = 3;
			this.sButton1.Text = "Start";
			this.sButton1.UseVisualStyleBackColor = false;
			this.sButton1.Click += new global::System.EventHandler(this.sButton1_Click);
			this.Panel2.BackColor = global::System.Drawing.Color.Black;
			this.Panel2.Controls.Add(this.panel3);
			this.Panel2.Controls.Add(this.DrakeUIButtonIcon2);
			this.Panel2.Controls.Add(this.disablebtn);
			this.Panel2.Controls.Add(this.enablebtn);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(632, 38);
			this.Panel2.TabIndex = 0;
			this.panel3.Controls.Add(this.guna2ControlBox1);
			this.panel3.Controls.Add(this.drakeUIButtonIcon5);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new global::System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(632, 38);
			this.panel3.TabIndex = 23;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.Red;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(604, 1);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(25, 26);
			this.guna2ControlBox1.TabIndex = 2;
			this.drakeUIButtonIcon5.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon5.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.drakeUIButtonIcon5.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon5.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon5.FillHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon5.FillPressColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon5.FillSelectedColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon5.ForeDisableColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon5.ForeHoverColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon5.ForePressColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon5.ForeSelectedColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon5.Location = new global::System.Drawing.Point(0, 0);
			this.drakeUIButtonIcon5.Name = "drakeUIButtonIcon5";
			this.drakeUIButtonIcon5.Radius = 10;
			this.drakeUIButtonIcon5.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon5.RectDisableColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon5.RectHoverColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon5.RectPressColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon5.RectSelectedColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon5.Size = new global::System.Drawing.Size(632, 30);
			this.drakeUIButtonIcon5.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon5.Symbol = 61965;
			this.drakeUIButtonIcon5.TabIndex = 1;
			this.drakeUIButtonIcon5.Text = "Screen Texts Reader";
			this.drakeUIButtonIcon5.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.drakeUIButtonIcon5_MouseDown);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Bahnschrift", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(76, 5);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(195, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Screen Text Reader";
			this.DrakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon2.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon2.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon2.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon2.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.DrakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon2.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon2.Location = new global::System.Drawing.Point(147, 12);
			this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
			this.DrakeUIButtonIcon2.Radius = 25;
			this.DrakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon2.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon2.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon2.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon2.Size = new global::System.Drawing.Size(129, 26);
			this.DrakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon2.Symbol = 57469;
			this.DrakeUIButtonIcon2.TabIndex = 22;
			this.DrakeUIButtonIcon2.Text = "Clear";
			this.DrakeUIButtonIcon2.Click += new global::System.EventHandler(this.DrakeUIButtonIcon2_Click);
			this.disablebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.disablebtn.FillColor = global::System.Drawing.Color.Black;
			this.disablebtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.disablebtn.FillPressColor = global::System.Drawing.Color.Black;
			this.disablebtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.disablebtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.disablebtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.disablebtn.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.disablebtn.Location = new global::System.Drawing.Point(282, 12);
			this.disablebtn.Name = "disablebtn";
			this.disablebtn.Radius = 25;
			this.disablebtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.disablebtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.disablebtn.RectHoverColor = global::System.Drawing.Color.White;
			this.disablebtn.RectPressColor = global::System.Drawing.Color.White;
			this.disablebtn.RectSelectedColor = global::System.Drawing.Color.White;
			this.disablebtn.Size = new global::System.Drawing.Size(129, 26);
			this.disablebtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.disablebtn.Symbol = 61534;
			this.disablebtn.TabIndex = 21;
			this.disablebtn.Text = "Disable";
			this.disablebtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
			this.enablebtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.enablebtn.FillColor = global::System.Drawing.Color.Black;
			this.enablebtn.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.enablebtn.FillPressColor = global::System.Drawing.Color.Black;
			this.enablebtn.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.enablebtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.enablebtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.enablebtn.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.enablebtn.Location = new global::System.Drawing.Point(12, 12);
			this.enablebtn.Name = "enablebtn";
			this.enablebtn.Radius = 25;
			this.enablebtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.enablebtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.enablebtn.RectHoverColor = global::System.Drawing.Color.White;
			this.enablebtn.RectPressColor = global::System.Drawing.Color.White;
			this.enablebtn.RectSelectedColor = global::System.Drawing.Color.White;
			this.enablebtn.Size = new global::System.Drawing.Size(129, 26);
			this.enablebtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.enablebtn.Symbol = 61671;
			this.enablebtn.TabIndex = 20;
			this.enablebtn.Text = "Enable";
			this.Timer1.Interval = 1000;
			this.Timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.viewpanel.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.viewpanel.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.viewpanel.BorderRadius = 6;
			this.viewpanel.BorderSize = 1;
			this.viewpanel.ForeColor = global::System.Drawing.Color.White;
			this.viewpanel.Location = new global::System.Drawing.Point(3, 33);
			this.viewpanel.Name = "viewpanel";
			this.viewpanel.Size = new global::System.Drawing.Size(346, 570);
			this.viewpanel.TabIndex = 26;
			this.viewpanel.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Viewpanel_MouseDown);
			this.viewpanel.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Viewpanel_MouseMove);
			this.viewpanel.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Viewpanel_MouseUp);
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.textBox1.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.textBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textBox1.DefaultText = "";
			this.textBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textBox1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.textBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.textBox1.Location = new global::System.Drawing.Point(358, 33);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '\0';
			this.textBox1.PlaceholderText = "";
			this.textBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.SelectedText = "";
			this.textBox1.Size = new global::System.Drawing.Size(266, 570);
			this.textBox1.TabIndex = 27;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(632, 652);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.viewpanel);
			base.Controls.Add(this.drakeUIGradientPanel1);
			base.Controls.Add(this.Panel2);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new global::System.Drawing.Size(632, 652);
			this.MinimumSize = new global::System.Drawing.Size(632, 652);
			base.Name = "ScreenReader";
			base.ShowIcon = false;
			this.Text = "Text Reader";
			base.Load += new global::System.EventHandler(this.ScreenReader_Load);
			this.drakeUIGradientPanel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040009AC RID: 2476
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040009B7 RID: 2487
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
		internal global::System.Windows.Forms.Panel Panel2;

		// Token: 0x040009B8 RID: 2488
		internal global::DrakeUI.Framework.DrakeUIButtonIcon disablebtn;

		// Token: 0x040009B9 RID: 2489
		internal global::DrakeUI.Framework.DrakeUIButtonIcon enablebtn;

		// Token: 0x040009BA RID: 2490
		internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon2;

		// Token: 0x040009BB RID: 2491
		internal global::System.Windows.Forms.Timer Timer1;

		// Token: 0x040009BC RID: 2492
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x040009BD RID: 2493
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040009BE RID: 2494
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon5;

		// Token: 0x040009BF RID: 2495
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;

		// Token: 0x040009C0 RID: 2496
		private global::Sipaa.Framework.SButton sButton1;

		// Token: 0x040009C1 RID: 2497
		private global::Sipaa.Framework.SButton sButton3;

		// Token: 0x040009C2 RID: 2498
		private global::Sipaa.Framework.SButton sButton2;

		// Token: 0x040009C3 RID: 2499
		private global::Sipaa.Framework.SPanel viewpanel;

		// Token: 0x040009C4 RID: 2500
		private global::Guna.UI2.WinForms.Guna2TextBox textBox1;

		// Token: 0x040009C5 RID: 2501
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x040009C6 RID: 2502
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x040009C7 RID: 2503
		private global::DrakeUI.Framework.DrakeUIGradientPanel drakeUIGradientPanel1;
	}
}
