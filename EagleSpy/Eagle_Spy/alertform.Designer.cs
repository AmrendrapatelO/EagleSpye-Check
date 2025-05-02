namespace Eagle_Spy
{
	// Token: 0x02000013 RID: 19
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class alertform : global::System.Windows.Forms.Form
	{
		// Token: 0x060001BC RID: 444 RVA: 0x00002538 File Offset: 0x00000738
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.alertimage = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.msglabel = new global::System.Windows.Forms.Label();
			this.closetimer = new global::System.Windows.Forms.Timer(this.components);
			this.backpanel = new global::DrakeUI.Framework.DrakeUITitlePanel();
			this.lidlamb = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.alertimage).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			this.backpanel.SuspendLayout();
			base.SuspendLayout();
			this.alertimage.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.alertimage.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.alertimage.Location = new global::System.Drawing.Point(16, 0);
			this.alertimage.Name = "alertimage";
			this.alertimage.Size = new global::System.Drawing.Size(44, 62);
			this.alertimage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.alertimage.TabIndex = 0;
			this.alertimage.TabStop = false;
			this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.pictureBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.pictureBox2.Location = new global::System.Drawing.Point(291, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(20, 62);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.PictureBox2_Click);
			this.msglabel.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.msglabel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.msglabel.Font = new global::System.Drawing.Font("Calibri", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.msglabel.ForeColor = global::System.Drawing.Color.White;
			this.msglabel.Location = new global::System.Drawing.Point(60, 0);
			this.msglabel.Name = "msglabel";
			this.msglabel.Size = new global::System.Drawing.Size(231, 62);
			this.msglabel.TabIndex = 2;
			this.msglabel.Text = "this is test msg";
			this.msglabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.closetimer.Interval = 40;
			this.closetimer.Tick += new global::System.EventHandler(this.Closetimer_Tick);
			this.backpanel.BackColor = global::System.Drawing.Color.Transparent;
			this.backpanel.Controls.Add(this.msglabel);
			this.backpanel.Controls.Add(this.pictureBox2);
			this.backpanel.Controls.Add(this.alertimage);
			this.backpanel.Controls.Add(this.lidlamb);
			this.backpanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.backpanel.FillColor = global::System.Drawing.Color.Black;
			this.backpanel.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.backpanel.ForeColor = global::System.Drawing.Color.White;
			this.backpanel.Location = new global::System.Drawing.Point(0, 0);
			this.backpanel.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.backpanel.Name = "backpanel";
			this.backpanel.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.backpanel.Size = new global::System.Drawing.Size(311, 62);
			this.backpanel.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.backpanel.TabIndex = 3;
			this.backpanel.Text = null;
			this.backpanel.TitleColor = global::System.Drawing.Color.Black;
			this.backpanel.TitleHeight = 0;
			this.backpanel.TitleInterval = 0;
			this.lidlamb.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lidlamb.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.lidlamb.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.lidlamb.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.lidlamb.ForeColor = global::System.Drawing.Color.Lime;
			this.lidlamb.Location = new global::System.Drawing.Point(0, 0);
			this.lidlamb.Margin = new global::System.Windows.Forms.Padding(2);
			this.lidlamb.Name = "lidlamb";
			this.lidlamb.RectColor = global::System.Drawing.Color.Transparent;
			this.lidlamb.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.lidlamb.Size = new global::System.Drawing.Size(16, 62);
			this.lidlamb.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.lidlamb.StyleCustomMode = true;
			this.lidlamb.Symbol = 61713;
			this.lidlamb.TabIndex = 3;
			this.lidlamb.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Lidlamb_MouseDown);
			this.lidlamb.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Lidlamb_MouseUp);
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.CausesValidation = false;
			base.ClientSize = new global::System.Drawing.Size(311, 62);
			base.ControlBox = false;
			base.Controls.Add(this.backpanel);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "alertform";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "AlertForm";
			((global::System.ComponentModel.ISupportInitialize)this.alertimage).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			this.backpanel.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000046 RID: 70
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label msglabel;

		// Token: 0x04000052 RID: 82
		internal global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000053 RID: 83
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("alertimage")]
		internal global::System.Windows.Forms.PictureBox alertimage;

		// Token: 0x04000054 RID: 84
		internal global::System.Windows.Forms.Timer closetimer;

		// Token: 0x04000055 RID: 85
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("backpanel")]
		internal global::DrakeUI.Framework.DrakeUITitlePanel backpanel;

		// Token: 0x04000056 RID: 86
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000057 RID: 87
		internal global::DrakeUI.Framework.DrakeUIButtonIcon lidlamb;
	}
}
