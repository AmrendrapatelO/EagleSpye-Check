namespace Eaglespy
{
	// Token: 0x020000F7 RID: 247
	public partial class ServerManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C87 RID: 3207 RVA: 0x0000799D File Offset: 0x00005B9D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00117B04 File Offset: 0x00115D04
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.drakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.drakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.ServerStatusLabel = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2TextBox2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.drakeUIAvatar2 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.devname = new global::System.Windows.Forms.Label();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.drakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon2.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillPressColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillSelectedColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon2.Location = new global::System.Drawing.Point(250, 235);
			this.drakeUIButtonIcon2.Name = "drakeUIButtonIcon2";
			this.drakeUIButtonIcon2.RectColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.Green;
			this.drakeUIButtonIcon2.RectHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.RectPressColor = global::System.Drawing.Color.Green;
			this.drakeUIButtonIcon2.RectSelectedColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon2.Size = new global::System.Drawing.Size(80, 35);
			this.drakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon2.SymbolSize = 20;
			this.drakeUIButtonIcon2.TabIndex = 7;
			this.drakeUIButtonIcon2.Text = "Start";
			this.drakeUIButtonIcon2.Click += new global::System.EventHandler(this.drakeUIButtonIcon2_Click);
			this.drakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon1.Location = new global::System.Drawing.Point(80, 235);
			this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
			this.drakeUIButtonIcon1.RectColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.Maroon;
			this.drakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.drakeUIButtonIcon1.Size = new global::System.Drawing.Size(73, 35);
			this.drakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon1.Symbol = 61453;
			this.drakeUIButtonIcon1.SymbolSize = 20;
			this.drakeUIButtonIcon1.TabIndex = 6;
			this.drakeUIButtonIcon1.Text = "Stop";
			this.drakeUIButtonIcon1.Click += new global::System.EventHandler(this.drakeUIButtonIcon1_Click);
			this.ServerStatusLabel.AutoSize = true;
			this.ServerStatusLabel.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ServerStatusLabel.ForeColor = global::System.Drawing.Color.White;
			this.ServerStatusLabel.Location = new global::System.Drawing.Point(181, 89);
			this.ServerStatusLabel.Name = "ServerStatusLabel";
			this.ServerStatusLabel.Size = new global::System.Drawing.Size(64, 19);
			this.ServerStatusLabel.TabIndex = 8;
			this.ServerStatusLabel.Text = "Server";
			this.ServerStatusLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.pictureBox1.Image = global::Eagle_Spy_Applications.server_8385949;
			this.pictureBox1.Location = new global::System.Drawing.Point(172, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(83, 55);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(281, 31);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(35, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "label1";
			this.label1.Visible = false;
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(281, 44);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(35, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "label2";
			this.label2.Visible = false;
			this.guna2TextBox1.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2TextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2TextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2TextBox1.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Location = new global::System.Drawing.Point(46, 121);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderText = "";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.Size = new global::System.Drawing.Size(314, 24);
			this.guna2TextBox1.TabIndex = 12;
			this.guna2TextBox2.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.guna2TextBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox2.DefaultText = "";
			this.guna2TextBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.guna2TextBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.guna2TextBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.guna2TextBox2.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2TextBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2TextBox2.ForeColor = global::System.Drawing.Color.White;
			this.guna2TextBox2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2TextBox2.Location = new global::System.Drawing.Point(46, 183);
			this.guna2TextBox2.Name = "guna2TextBox2";
			this.guna2TextBox2.PasswordChar = '\0';
			this.guna2TextBox2.PlaceholderText = "";
			this.guna2TextBox2.SelectedText = "";
			this.guna2TextBox2.Size = new global::System.Drawing.Size(314, 24);
			this.guna2TextBox2.TabIndex = 13;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Bahnschrift", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(44, 104);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(60, 14);
			this.label3.TabIndex = 14;
			this.label3.Text = "Bot Token";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Bahnschrift", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(46, 163);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(45, 14);
			this.label4.TabIndex = 15;
			this.label4.Text = "Chat ID";
			this.drakeUIAvatar2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIAvatar2.FillColor = global::System.Drawing.Color.Transparent;
			this.drakeUIAvatar2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIAvatar2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIAvatar2.Location = new global::System.Drawing.Point(375, 143);
			this.drakeUIAvatar2.Name = "drakeUIAvatar2";
			this.drakeUIAvatar2.Size = new global::System.Drawing.Size(32, 34);
			this.drakeUIAvatar2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIAvatar2.Symbol = 61452;
			this.drakeUIAvatar2.SymbolSize = 25;
			this.drakeUIAvatar2.TabIndex = 17;
			this.drakeUIAvatar2.Text = "drakeUIAvatar2";
			this.drakeUIAvatar2.Click += new global::System.EventHandler(this.drakeUIAvatar2_Click);
			this.devname.AutoSize = true;
			this.devname.Font = new global::System.Drawing.Font("MS Reference Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.devname.ForeColor = global::System.Drawing.Color.White;
			this.devname.Location = new global::System.Drawing.Point(161, 215);
			this.devname.Name = "devname";
			this.devname.Size = new global::System.Drawing.Size(106, 16);
			this.devname.TabIndex = 18;
			this.devname.Text = "t.me/SystemAdminServer";
			this.devname.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(391, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 19;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(448, 299);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.devname);
			base.Controls.Add(this.drakeUIAvatar2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.guna2TextBox2);
			base.Controls.Add(this.guna2TextBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.ServerStatusLabel);
			base.Controls.Add(this.drakeUIButtonIcon2);
			base.Controls.Add(this.drakeUIButtonIcon1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "ServerManager";
			this.Text = "ServerManager";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.ServerManager_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000FC9 RID: 4041
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000FCA RID: 4042
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000FCB RID: 4043
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon2;

		// Token: 0x04000FCC RID: 4044
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon1;

		// Token: 0x04000FCD RID: 4045
		private global::System.Windows.Forms.Label ServerStatusLabel;

		// Token: 0x04000FCE RID: 4046
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000FCF RID: 4047
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000FD0 RID: 4048
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000FD1 RID: 4049
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;

		// Token: 0x04000FD2 RID: 4050
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000FD3 RID: 4051
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000FD4 RID: 4052
		private global::Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;

		// Token: 0x04000FD5 RID: 4053
		private global::DrakeUI.Framework.DrakeUIAvatar drakeUIAvatar2;

		// Token: 0x04000FD6 RID: 4054
		private global::System.Windows.Forms.Label devname;

		// Token: 0x04000FD7 RID: 4055
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
	}
}
