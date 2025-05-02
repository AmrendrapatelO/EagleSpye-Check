namespace Eagle_Spy
{
	// Token: 0x02000057 RID: 87
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EagleSpyMsgbox : global::System.Windows.Forms.Form
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x00089974 File Offset: 0x00087B74
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

		// Token: 0x060005C0 RID: 1472 RVA: 0x000899B4 File Offset: 0x00087BB4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.okbtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.nobtn = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.msgtext = new global::System.Windows.Forms.Label();
			this.titletext = new global::DrakeUI.Framework.DrakeUITitlePanel();
			this.picbox = new global::System.Windows.Forms.PictureBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.Panel1.SuspendLayout();
			this.titletext.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picbox).BeginInit();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel1.Controls.Add(this.okbtn);
			this.Panel1.Controls.Add(this.nobtn);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.Location = new global::System.Drawing.Point(0, 96);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(543, 32);
			this.Panel1.TabIndex = 0;
			this.okbtn.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.okbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.okbtn.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.okbtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.okbtn.ForeColor = global::System.Drawing.Color.Lime;
			this.okbtn.Location = new global::System.Drawing.Point(287, 7);
			this.okbtn.Margin = new global::System.Windows.Forms.Padding(2);
			this.okbtn.Name = "okbtn";
			this.okbtn.RectColor = global::System.Drawing.Color.Lime;
			this.okbtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.okbtn.Size = new global::System.Drawing.Size(33, 23);
			this.okbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.okbtn.TabIndex = 1;
			this.okbtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon2_Click);
			this.nobtn.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.nobtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.nobtn.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.nobtn.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.nobtn.ForeColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.nobtn.Location = new global::System.Drawing.Point(218, 6);
			this.nobtn.Margin = new global::System.Windows.Forms.Padding(2);
			this.nobtn.Name = "nobtn";
			this.nobtn.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.nobtn.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.nobtn.Size = new global::System.Drawing.Size(35, 23);
			this.nobtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.nobtn.Symbol = 61453;
			this.nobtn.TabIndex = 0;
			this.nobtn.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
			this.msgtext.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.msgtext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.msgtext.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.msgtext.Location = new global::System.Drawing.Point(42, 28);
			this.msgtext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.msgtext.Name = "msgtext";
			this.msgtext.Size = new global::System.Drawing.Size(501, 68);
			this.msgtext.TabIndex = 2;
			this.msgtext.Text = "you are the only responsible for using this program\r\nOnly install in phone you have permissions to";
			this.msgtext.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.titletext.Controls.Add(this.msgtext);
			this.titletext.Controls.Add(this.picbox);
			this.titletext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.titletext.FillColor = global::System.Drawing.Color.FromArgb(225, 245, 254);
			this.titletext.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.titletext.ForeColor = global::System.Drawing.Color.White;
			this.titletext.Location = new global::System.Drawing.Point(0, 0);
			this.titletext.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.titletext.Name = "titletext";
			this.titletext.Padding = new global::System.Windows.Forms.Padding(0, 28, 0, 0);
			this.titletext.RectColor = global::System.Drawing.Color.FromArgb(128, 255, 255);
			this.titletext.Size = new global::System.Drawing.Size(543, 96);
			this.titletext.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.titletext.TabIndex = 3;
			this.titletext.Text = "title";
			this.titletext.TitleColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.picbox.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.picbox.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.picbox.Location = new global::System.Drawing.Point(0, 28);
			this.picbox.Margin = new global::System.Windows.Forms.Padding(2);
			this.picbox.Name = "picbox";
			this.picbox.Size = new global::System.Drawing.Size(42, 68);
			this.picbox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picbox.TabIndex = 3;
			this.picbox.TabStop = false;
			this.Panel2.Controls.Add(this.titletext);
			this.Panel2.Controls.Add(this.Panel1);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(2);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(543, 128);
			this.Panel2.TabIndex = 3;
			this.Panel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
			this.Timer1.Interval = 500;
			this.Timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Cyan;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(543, 128);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "EagleSpyMsgbox";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Msgbox";
			base.TopMost = true;
			this.Panel1.ResumeLayout(false);
			this.titletext.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.picbox).EndInit();
			this.Panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000615 RID: 1557
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400061A RID: 1562
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
		internal global::System.Windows.Forms.Panel Panel1;

		// Token: 0x0400061B RID: 1563
		internal global::DrakeUI.Framework.DrakeUIButtonIcon nobtn;

		// Token: 0x0400061C RID: 1564
		internal global::DrakeUI.Framework.DrakeUIButtonIcon okbtn;

		// Token: 0x0400061D RID: 1565
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("msgtext")]
		internal global::System.Windows.Forms.Label msgtext;

		// Token: 0x0400061E RID: 1566
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("titletext")]
		internal global::DrakeUI.Framework.DrakeUITitlePanel titletext;

		// Token: 0x0400061F RID: 1567
		internal global::System.Windows.Forms.Panel Panel2;

		// Token: 0x04000620 RID: 1568
		internal global::System.Windows.Forms.Timer Timer1;

		// Token: 0x04000621 RID: 1569
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000622 RID: 1570
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("picbox")]
		internal global::System.Windows.Forms.PictureBox picbox;
	}
}
