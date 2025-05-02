namespace Eagle_Spy
{
	// Token: 0x02000046 RID: 70
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Eaglepopup : global::System.Windows.Forms.Form
	{
		// Token: 0x0600047D RID: 1149 RVA: 0x0005CE78 File Offset: 0x0005B078
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

		// Token: 0x0600047E RID: 1150 RVA: 0x0005CEB8 File Offset: 0x0005B0B8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.checkbutton = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.notifitext = new global::System.Windows.Forms.TextBox();
			this.ToolTips = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			base.SuspendLayout();
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(190, 11);
			this.DrakeUIButtonIcon1.Margin = new global::System.Windows.Forms.Padding(2);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.Radius = 15;
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(54, 24);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.StyleCustomMode = true;
			this.DrakeUIButtonIcon1.Symbol = 61639;
			this.DrakeUIButtonIcon1.TabIndex = 2;
			this.ToolTips.SetToolTip(this.DrakeUIButtonIcon1, "Save");
			this.DrakeUIButtonIcon1.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
			this.checkbutton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkbutton.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.checkbutton.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.checkbutton.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.checkbutton.Location = new global::System.Drawing.Point(300, 11);
			this.checkbutton.Margin = new global::System.Windows.Forms.Padding(2);
			this.checkbutton.Name = "checkbutton";
			this.checkbutton.Radius = 15;
			this.checkbutton.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.checkbutton.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.checkbutton.Size = new global::System.Drawing.Size(54, 24);
			this.checkbutton.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.checkbutton.Symbol = 61453;
			this.checkbutton.TabIndex = 1;
			this.ToolTips.SetToolTip(this.checkbutton, "Clear & Close");
			this.checkbutton.Click += new global::System.EventHandler(this.Checkbutton_Click);
			this.notifitext.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.notifitext.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.notifitext.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.notifitext.ForeColor = global::System.Drawing.Color.White;
			this.notifitext.Location = new global::System.Drawing.Point(12, 60);
			this.notifitext.Multiline = true;
			this.notifitext.Name = "notifitext";
			this.notifitext.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.notifitext.Size = new global::System.Drawing.Size(341, 244);
			this.notifitext.TabIndex = 2;
			this.notifitext.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ToolTips.BackColor = global::System.Drawing.Color.Black;
			this.ToolTips.ForeColor = global::System.Drawing.Color.White;
			this.ToolTips.OwnerDraw = true;
			this.ToolTips.RectColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new global::System.Drawing.Size(365, 341);
			base.Controls.Add(this.DrakeUIButtonIcon1);
			base.Controls.Add(this.checkbutton);
			base.Controls.Add(this.notifitext);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			this.MaximumSize = new global::System.Drawing.Size(365, 341);
			this.MinimumSize = new global::System.Drawing.Size(365, 341);
			base.Name = "Eaglepopup";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Notification";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003F3 RID: 1011
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003F5 RID: 1013
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("notifitext")]
		internal global::System.Windows.Forms.TextBox notifitext;

		// Token: 0x040003F6 RID: 1014
		internal global::DrakeUI.Framework.DrakeUIButtonIcon checkbutton;

		// Token: 0x040003F7 RID: 1015
		internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;

		// Token: 0x040003F8 RID: 1016
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ToolTips")]
		internal global::DrakeUI.Framework.DrakeUIToolTip ToolTips;

		// Token: 0x040003F9 RID: 1017
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
	}
}
