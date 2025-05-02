namespace Eagle_Spy
{
	// Token: 0x0200008C RID: 140
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Ports : global::System.Windows.Forms.Form
	{
		// Token: 0x06000795 RID: 1941 RVA: 0x000C8494 File Offset: 0x000C6694
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

		// Token: 0x06000796 RID: 1942 RVA: 0x000C84D4 File Offset: 0x000C66D4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.notpass = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.loginworker = new global::System.ComponentModel.BackgroundWorker();
			this.KeyAuthRegister = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.notifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.Login = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.KeyAuthKey = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.KeyAuthUser = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.KeyAuthPass = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.ip = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.notpass.Text = "NotifyIcon1";
			this.notpass.Visible = true;
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
			this.DrakeUIToolTip1.OwnerDraw = true;
			this.loginworker.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.Loginworker_DoWork);
			this.KeyAuthRegister.Animated = true;
			this.KeyAuthRegister.AnimatedGIF = true;
			this.KeyAuthRegister.AutoRoundedCorners = true;
			this.KeyAuthRegister.BackColor = global::System.Drawing.Color.Transparent;
			this.KeyAuthRegister.BorderColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.KeyAuthRegister.BorderRadius = 14;
			this.KeyAuthRegister.BorderThickness = 2;
			this.KeyAuthRegister.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.KeyAuthRegister.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.KeyAuthRegister.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.KeyAuthRegister.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.KeyAuthRegister.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.KeyAuthRegister.FillColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.KeyAuthRegister.FillColor2 = global::System.Drawing.Color.Navy;
			this.KeyAuthRegister.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.KeyAuthRegister.ForeColor = global::System.Drawing.Color.White;
			this.KeyAuthRegister.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
			this.KeyAuthRegister.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.KeyAuthRegister.Location = new global::System.Drawing.Point(75, 229);
			this.KeyAuthRegister.Name = "KeyAuthRegister";
			this.KeyAuthRegister.Size = new global::System.Drawing.Size(103, 31);
			this.KeyAuthRegister.TabIndex = 55;
			this.KeyAuthRegister.Text = "Register";
			this.KeyAuthRegister.Click += new global::System.EventHandler(this.KeyAuthRegister_Click);
			this.Guna2BorderlessForm1.BorderRadius = 15;
			this.Guna2BorderlessForm1.ContainerControl = this;
			this.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.Guna2BorderlessForm1.ResizeForm = false;
			this.Guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.Guna2BorderlessForm1.TransparentWhileDrag = true;
			this.notifyIcon1.Text = "NotifyIcon1";
			this.notifyIcon1.Visible = true;
			this.TOpacity.Interval = 1;
			this.Login.Animated = true;
			this.Login.AutoRoundedCorners = true;
			this.Login.BackColor = global::System.Drawing.Color.Transparent;
			this.Login.BorderColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.Login.BorderRadius = 14;
			this.Login.BorderThickness = 2;
			this.Login.CheckedState.FillColor = global::System.Drawing.Color.Red;
			this.Login.CheckedState.FillColor2 = global::System.Drawing.Color.Red;
			this.Login.DisabledState.BorderColor = global::System.Drawing.Color.Red;
			this.Login.DisabledState.CustomBorderColor = global::System.Drawing.Color.Red;
			this.Login.DisabledState.FillColor = global::System.Drawing.Color.Red;
			this.Login.DisabledState.FillColor2 = global::System.Drawing.Color.Red;
			this.Login.DisabledState.ForeColor = global::System.Drawing.Color.White;
			this.Login.FillColor = global::System.Drawing.Color.Navy;
			this.Login.FillColor2 = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.Login.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Login.ForeColor = global::System.Drawing.Color.White;
			this.Login.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
			this.Login.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.Login.Location = new global::System.Drawing.Point(273, 229);
			this.Login.Name = "Login";
			this.Login.PressedColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Login.Size = new global::System.Drawing.Size(116, 31);
			this.Login.TabIndex = 63;
			this.Login.Text = "LOGIN";
			this.Login.Click += new global::System.EventHandler(this.Login_Click);
			this.KeyAuthKey.BackColor = global::System.Drawing.Color.Transparent;
			this.KeyAuthKey.BorderColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.KeyAuthKey.BorderRadius = 8;
			this.KeyAuthKey.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.KeyAuthKey.DefaultText = "";
			this.KeyAuthKey.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.KeyAuthKey.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.KeyAuthKey.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.KeyAuthKey.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.KeyAuthKey.FillColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.KeyAuthKey.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.KeyAuthKey.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.KeyAuthKey.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.KeyAuthKey.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.KeyAuthKey.Location = new global::System.Drawing.Point(50, 174);
			this.KeyAuthKey.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.KeyAuthKey.Name = "KeyAuthKey";
			this.KeyAuthKey.PasswordChar = '*';
			this.KeyAuthKey.PlaceholderForeColor = global::System.Drawing.Color.Aqua;
			this.KeyAuthKey.PlaceholderText = "Key";
			this.KeyAuthKey.SelectedText = "";
			this.KeyAuthKey.Size = new global::System.Drawing.Size(157, 25);
			this.KeyAuthKey.TabIndex = 53;
			this.KeyAuthKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.KeyAuthUser.BackColor = global::System.Drawing.Color.Transparent;
			this.KeyAuthUser.BorderColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.KeyAuthUser.BorderRadius = 8;
			this.KeyAuthUser.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.KeyAuthUser.DefaultText = "";
			this.KeyAuthUser.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.KeyAuthUser.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.KeyAuthUser.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.KeyAuthUser.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.KeyAuthUser.FillColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.KeyAuthUser.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.KeyAuthUser.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.KeyAuthUser.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.KeyAuthUser.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.KeyAuthUser.Location = new global::System.Drawing.Point(50, 101);
			this.KeyAuthUser.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.KeyAuthUser.Name = "KeyAuthUser";
			this.KeyAuthUser.PasswordChar = '\0';
			this.KeyAuthUser.PlaceholderForeColor = global::System.Drawing.Color.Aqua;
			this.KeyAuthUser.PlaceholderText = "User/Email";
			this.KeyAuthUser.SelectedText = "";
			this.KeyAuthUser.Size = new global::System.Drawing.Size(157, 25);
			this.KeyAuthUser.TabIndex = 54;
			this.KeyAuthUser.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.KeyAuthPass.BackColor = global::System.Drawing.Color.Transparent;
			this.KeyAuthPass.BorderColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.KeyAuthPass.BorderRadius = 8;
			this.KeyAuthPass.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.KeyAuthPass.DefaultText = "";
			this.KeyAuthPass.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.KeyAuthPass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.KeyAuthPass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.KeyAuthPass.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.KeyAuthPass.FillColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.KeyAuthPass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.KeyAuthPass.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.KeyAuthPass.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.KeyAuthPass.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.KeyAuthPass.Location = new global::System.Drawing.Point(50, 138);
			this.KeyAuthPass.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			this.KeyAuthPass.Name = "KeyAuthPass";
			this.KeyAuthPass.PasswordChar = '\0';
			this.KeyAuthPass.PlaceholderForeColor = global::System.Drawing.Color.Aqua;
			this.KeyAuthPass.PlaceholderText = "Password";
			this.KeyAuthPass.SelectedText = "";
			this.KeyAuthPass.Size = new global::System.Drawing.Size(157, 25);
			this.KeyAuthPass.TabIndex = 55;
			this.KeyAuthPass.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Eagle_Spy_Applications.sssss;
			this.pictureBox1.Location = new global::System.Drawing.Point(273, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(171, 178);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 64;
			this.pictureBox1.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Algerian", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Cyan;
			this.label3.Location = new global::System.Drawing.Point(23, 23);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(191, 32);
			this.label3.TabIndex = 67;
			this.label3.Text = "EagleSpy V4";
			this.ip.AutoSize = true;
			this.ip.Location = new global::System.Drawing.Point(12, 229);
			this.ip.Name = "ip";
			this.ip.Size = new global::System.Drawing.Size(0, 13);
			this.ip.TabIndex = 68;
			this.ip.Visible = false;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("OCR A Extended", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(282, 204);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(151, 13);
			this.label2.TabIndex = 69;
			this.label2.Text = "t.me/SystemAdminServer";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(19, 228);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 13);
			this.label1.TabIndex = 70;
			this.label1.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.BackgroundImage = global::Eagle_Spy_Applications.portbackground;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(486, 272);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.ip);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.KeyAuthRegister);
			base.Controls.Add(this.KeyAuthPass);
			base.Controls.Add(this.KeyAuthUser);
			base.Controls.Add(this.KeyAuthKey);
			base.Controls.Add(this.Login);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Ports";
			base.Opacity = 0.9;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ports";
			base.Load += new global::System.EventHandler(this.Ports_Load);
			base.Click += new global::System.EventHandler(this.Ports_Click);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000920 RID: 2336
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000921 RID: 2337
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000922 RID: 2338
		private global::System.Windows.Forms.Label ip;

		// Token: 0x04000923 RID: 2339
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000924 RID: 2340
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000930 RID: 2352
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("notpass")]
		internal global::System.Windows.Forms.NotifyIcon notpass;

		// Token: 0x04000931 RID: 2353
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIToolTip1")]
		internal global::DrakeUI.Framework.DrakeUIToolTip DrakeUIToolTip1;

		// Token: 0x04000932 RID: 2354
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ToolTip1")]
		internal global::System.Windows.Forms.Timer Timer1;

		// Token: 0x04000933 RID: 2355
		internal global::Guna.UI2.WinForms.Guna2GradientButton KeyAuthRegister;

		// Token: 0x04000934 RID: 2356
		internal global::Guna.UI2.WinForms.Guna2BorderlessForm Guna2BorderlessForm1;

		// Token: 0x04000935 RID: 2357
		internal global::Guna.UI2.WinForms.Guna2GradientButton Login;

		// Token: 0x04000936 RID: 2358
		internal global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x04000937 RID: 2359
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x04000938 RID: 2360
		internal global::Guna.UI2.WinForms.Guna2TextBox KeyAuthPass;

		// Token: 0x04000939 RID: 2361
		internal global::Guna.UI2.WinForms.Guna2TextBox KeyAuthUser;

		// Token: 0x0400093A RID: 2362
		internal global::Guna.UI2.WinForms.Guna2TextBox KeyAuthKey;

		// Token: 0x0400093B RID: 2363
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400093C RID: 2364
		internal global::System.ComponentModel.BackgroundWorker loginworker;
	}
}
