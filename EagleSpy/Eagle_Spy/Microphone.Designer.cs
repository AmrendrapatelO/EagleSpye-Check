﻿namespace Eagle_Spy
{
	// Token: 0x0200007E RID: 126
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Microphone : global::System.Windows.Forms.Form
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x000BC920 File Offset: 0x000BAB20
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

		// Token: 0x0600072A RID: 1834 RVA: 0x000BC960 File Offset: 0x000BAB60
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bIN = new global::System.Windows.Forms.Button();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.DrakeUILampLED1 = new global::DrakeUI.Framework.DrakeUILampLED();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.OutHZ = new global::System.Windows.Forms.ComboBox();
			this.OutBoxSource = new global::System.Windows.Forms.ComboBox();
			this.b_sta = new global::System.Windows.Forms.Button();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.DeviceSOurVictim = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.inHZ = new global::System.Windows.Forms.ComboBox();
			this.InBoxSource = new global::System.Windows.Forms.ComboBox();
			this.LAB_ERR = new global::System.Windows.Forms.Label();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.TabControl1 = new global::System.Windows.Forms.TabControl();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.TabPage2 = new global::System.Windows.Forms.TabPage();
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			base.SuspendLayout();
			this.bIN.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.bIN.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.bIN.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.bIN.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.bIN.Location = new global::System.Drawing.Point(3, 207);
			this.bIN.Name = "bIN";
			this.bIN.Size = new global::System.Drawing.Size(504, 42);
			this.bIN.TabIndex = 1;
			this.bIN.Tag = "0";
			this.bIN.Text = "Run";
			this.bIN.UseVisualStyleBackColor = false;
			this.bIN.Click += new global::System.EventHandler(this.bIN_Click);
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel1.Controls.Add(this.DrakeUILampLED1);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.OutHZ);
			this.Panel1.Controls.Add(this.OutBoxSource);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			this.Panel1.Location = new global::System.Drawing.Point(3, 3);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(504, 206);
			this.Panel1.TabIndex = 23;
			this.DrakeUILampLED1.Color = global::System.Drawing.Color.Lime;
			this.DrakeUILampLED1.Location = new global::System.Drawing.Point(452, 3);
			this.DrakeUILampLED1.Name = "DrakeUILampLED1";
			this.DrakeUILampLED1.On = false;
			this.DrakeUILampLED1.Size = new global::System.Drawing.Size(47, 44);
			this.DrakeUILampLED1.TabIndex = 21;
			this.DrakeUILampLED1.Text = "DrakeUILampLED1";
			this.Button1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Button1.Location = new global::System.Drawing.Point(232, 149);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(161, 34);
			this.Button1.TabIndex = 20;
			this.Button1.Tag = "o";
			this.Button1.Text = "Start Recording Saver";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Click += new global::System.EventHandler(this.Button1_Click_1);
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Label1.Location = new global::System.Drawing.Point(86, 47);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(124, 17);
			this.Label1.TabIndex = 16;
			this.Label1.Text = "Client Microphone :";
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Label2.Location = new global::System.Drawing.Point(114, 105);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(96, 17);
			this.Label2.TabIndex = 18;
			this.Label2.Text = "Audio Quality :";
			this.OutHZ.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.OutHZ.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.OutHZ.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.OutHZ.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.OutHZ.FormattingEnabled = true;
			this.OutHZ.Items.AddRange(new object[] { "8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)" });
			this.OutHZ.Location = new global::System.Drawing.Point(232, 102);
			this.OutHZ.Name = "OutHZ";
			this.OutHZ.Size = new global::System.Drawing.Size(140, 23);
			this.OutHZ.TabIndex = 17;
			this.OutBoxSource.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.OutBoxSource.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.OutBoxSource.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.OutBoxSource.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.OutBoxSource.FormattingEnabled = true;
			this.OutBoxSource.Items.AddRange(new object[] { "DEFAULT", "MIC", "RECOGNITION", "COMMUNICATION", "CAMCORDER" });
			this.OutBoxSource.Location = new global::System.Drawing.Point(232, 47);
			this.OutBoxSource.Name = "OutBoxSource";
			this.OutBoxSource.Size = new global::System.Drawing.Size(140, 23);
			this.OutBoxSource.TabIndex = 15;
			this.OutBoxSource.SelectedIndexChanged += new global::System.EventHandler(this.OutBoxSource_SelectedIndexChanged);
			this.b_sta.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.b_sta.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.b_sta.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b_sta.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b_sta.Location = new global::System.Drawing.Point(3, 209);
			this.b_sta.Name = "b_sta";
			this.b_sta.Size = new global::System.Drawing.Size(504, 40);
			this.b_sta.TabIndex = 14;
			this.b_sta.Tag = "2";
			this.b_sta.Text = "Stop Microphone";
			this.b_sta.UseVisualStyleBackColor = false;
			this.b_sta.Click += new global::System.EventHandler(this.b_sta_Click);
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel2.Controls.Add(this.pictureBox2);
			this.Panel2.Controls.Add(this.Label5);
			this.Panel2.Controls.Add(this.Label4);
			this.Panel2.Controls.Add(this.DeviceSOurVictim);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.inHZ);
			this.Panel2.Controls.Add(this.InBoxSource);
			this.Panel2.Controls.Add(this.LAB_ERR);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.ForeColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			this.Panel2.Location = new global::System.Drawing.Point(3, 3);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(504, 246);
			this.Panel2.TabIndex = 24;
			this.pictureBox2.Image = global::Eagle_Spy_Applications.icons8_public_speaking_64;
			this.pictureBox2.Location = new global::System.Drawing.Point(11, 63);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(63, 71);
			this.pictureBox2.TabIndex = 28;
			this.pictureBox2.TabStop = false;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label5.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Label5.Location = new global::System.Drawing.Point(80, 27);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(105, 17);
			this.Label5.TabIndex = 27;
			this.Label5.Text = "PC Microphone :";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label4.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Label4.Location = new global::System.Drawing.Point(80, 78);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(99, 17);
			this.Label4.TabIndex = 26;
			this.Label4.Text = "Client Speaker :";
			this.DeviceSOurVictim.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DeviceSOurVictim.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.DeviceSOurVictim.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.DeviceSOurVictim.Font = new global::System.Drawing.Font("Calibri", 8f, global::System.Drawing.FontStyle.Bold);
			this.DeviceSOurVictim.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.DeviceSOurVictim.FormattingEnabled = true;
			this.DeviceSOurVictim.Items.AddRange(new object[] { "CALL", "MUSIC" });
			this.DeviceSOurVictim.Location = new global::System.Drawing.Point(256, 78);
			this.DeviceSOurVictim.Name = "DeviceSOurVictim";
			this.DeviceSOurVictim.Size = new global::System.Drawing.Size(176, 21);
			this.DeviceSOurVictim.TabIndex = 23;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label3.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Label3.Location = new global::System.Drawing.Point(83, 128);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(96, 17);
			this.Label3.TabIndex = 18;
			this.Label3.Text = "Audio Quality :";
			this.inHZ.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.inHZ.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.inHZ.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.inHZ.Font = new global::System.Drawing.Font("Calibri", 8f, global::System.Drawing.FontStyle.Bold);
			this.inHZ.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.inHZ.FormattingEnabled = true;
			this.inHZ.Items.AddRange(new object[] { "8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)" });
			this.inHZ.Location = new global::System.Drawing.Point(256, 128);
			this.inHZ.Name = "inHZ";
			this.inHZ.Size = new global::System.Drawing.Size(176, 21);
			this.inHZ.TabIndex = 17;
			this.InBoxSource.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.InBoxSource.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.InBoxSource.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.InBoxSource.Font = new global::System.Drawing.Font("Calibri", 8f, global::System.Drawing.FontStyle.Bold);
			this.InBoxSource.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.InBoxSource.FormattingEnabled = true;
			this.InBoxSource.Location = new global::System.Drawing.Point(256, 27);
			this.InBoxSource.Name = "InBoxSource";
			this.InBoxSource.Size = new global::System.Drawing.Size(176, 21);
			this.InBoxSource.TabIndex = 15;
			this.InBoxSource.SelectedIndexChanged += new global::System.EventHandler(this.InBoxSource_SelectedIndexChanged);
			this.LAB_ERR.AutoSize = true;
			this.LAB_ERR.Location = new global::System.Drawing.Point(501, 30);
			this.LAB_ERR.Name = "LAB_ERR";
			this.LAB_ERR.Size = new global::System.Drawing.Size(20, 17);
			this.LAB_ERR.TabIndex = 25;
			this.LAB_ERR.Text = "...";
			this.LAB_ERR.Visible = false;
			this.TOpacity.Interval = 1;
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TabControl1.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.TabControl1.ImageList = this.ImageList1;
			this.TabControl1.ItemSize = new global::System.Drawing.Size(255, 32);
			this.TabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new global::System.Drawing.Size(518, 292);
			this.TabControl1.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.TabControl1.TabIndex = 19;
			this.TabPage1.BackColor = global::System.Drawing.Color.Black;
			this.TabPage1.Controls.Add(this.Panel1);
			this.TabPage1.Controls.Add(this.b_sta);
			this.TabPage1.ImageKey = "headphones-removebg-preview.png";
			this.TabPage1.Location = new global::System.Drawing.Point(4, 36);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new global::System.Drawing.Size(510, 252);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Listen";
			this.TabPage2.Controls.Add(this.bIN);
			this.TabPage2.Controls.Add(this.Panel2);
			this.TabPage2.ImageKey = "microphone.png";
			this.TabPage2.Location = new global::System.Drawing.Point(4, 36);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new global::System.Drawing.Size(510, 252);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Speak";
			this.TabPage2.UseVisualStyleBackColor = true;
			this.ImageList1.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ImageList1.ImageSize = new global::System.Drawing.Size(16, 16);
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(518, 292);
			base.Controls.Add(this.TabControl1);
			this.ForeColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(534, 331);
			this.MinimumSize = new global::System.Drawing.Size(534, 331);
			base.Name = "Microphone";
			base.Opacity = 0.0;
			this.Text = "Microphone";
			base.Load += new global::System.EventHandler(this.Microphone_Load);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400086D RID: 2157
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400087C RID: 2172
		internal global::System.Windows.Forms.Button bIN;

		// Token: 0x0400087D RID: 2173
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
		internal global::System.Windows.Forms.Panel Panel1;

		// Token: 0x0400087E RID: 2174
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
		internal global::System.Windows.Forms.Label Label2;

		// Token: 0x0400087F RID: 2175
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("OutHZ")]
		internal global::System.Windows.Forms.ComboBox OutHZ;

		// Token: 0x04000880 RID: 2176
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
		internal global::System.Windows.Forms.Label Label1;

		// Token: 0x04000881 RID: 2177
		internal global::System.Windows.Forms.ComboBox OutBoxSource;

		// Token: 0x04000882 RID: 2178
		internal global::System.Windows.Forms.Button b_sta;

		// Token: 0x04000883 RID: 2179
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
		internal global::System.Windows.Forms.Panel Panel2;

		// Token: 0x04000884 RID: 2180
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("DeviceSOurVictim")]
		internal global::System.Windows.Forms.ComboBox DeviceSOurVictim;

		// Token: 0x04000885 RID: 2181
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label3")]
		internal global::System.Windows.Forms.Label Label3;

		// Token: 0x04000886 RID: 2182
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("inHZ")]
		internal global::System.Windows.Forms.ComboBox inHZ;

		// Token: 0x04000887 RID: 2183
		internal global::System.Windows.Forms.ComboBox InBoxSource;

		// Token: 0x04000888 RID: 2184
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x04000889 RID: 2185
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("LAB_ERR")]
		internal global::System.Windows.Forms.Label LAB_ERR;

		// Token: 0x0400088A RID: 2186
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabControl1")]
		internal global::System.Windows.Forms.TabControl TabControl1;

		// Token: 0x0400088B RID: 2187
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage1")]
		internal global::System.Windows.Forms.TabPage TabPage1;

		// Token: 0x0400088C RID: 2188
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("TabPage2")]
		internal global::System.Windows.Forms.TabPage TabPage2;

		// Token: 0x0400088D RID: 2189
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ImageList1")]
		internal global::System.Windows.Forms.ImageList ImageList1;

		// Token: 0x0400088E RID: 2190
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label5")]
		internal global::System.Windows.Forms.Label Label5;

		// Token: 0x0400088F RID: 2191
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label4")]
		internal global::System.Windows.Forms.Label Label4;

		// Token: 0x04000890 RID: 2192
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUILampLED1")]
		internal global::DrakeUI.Framework.DrakeUILampLED DrakeUILampLED1;

		// Token: 0x04000891 RID: 2193
		internal global::System.Windows.Forms.Button Button1;

		// Token: 0x04000893 RID: 2195
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
