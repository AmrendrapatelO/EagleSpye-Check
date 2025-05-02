namespace Eagle_Spy
{
	// Token: 0x0200003D RID: 61
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Dialog1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600042F RID: 1071 RVA: 0x00056DB4 File Offset: 0x00054FB4
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

		// Token: 0x06000430 RID: 1072 RVA: 0x00056DF4 File Offset: 0x00054FF4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Mytext = new global::System.Windows.Forms.TextBox();
			this.Mytitle = new global::System.Windows.Forms.Label();
			this.DrakeUITitlePanel1 = new global::DrakeUI.Framework.DrakeUITitlePanel();
			this.drakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.drakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.DrakeUITitlePanel1.SuspendLayout();
			base.SuspendLayout();
			this.Mytext.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Mytext.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Mytext.ForeColor = global::System.Drawing.Color.White;
			this.Mytext.Location = new global::System.Drawing.Point(23, 36);
			this.Mytext.Multiline = true;
			this.Mytext.Name = "Mytext";
			this.Mytext.Size = new global::System.Drawing.Size(263, 27);
			this.Mytext.TabIndex = 1;
			this.Mytitle.BackColor = global::System.Drawing.Color.Transparent;
			this.Mytitle.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Mytitle.Font = new global::System.Drawing.Font("Calibri", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Mytitle.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.Mytitle.Location = new global::System.Drawing.Point(0, 0);
			this.Mytitle.Name = "Mytitle";
			this.Mytitle.Size = new global::System.Drawing.Size(324, 33);
			this.Mytitle.TabIndex = 3;
			this.Mytitle.Text = "Text";
			this.Mytitle.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.DrakeUITitlePanel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DrakeUITitlePanel1.Controls.Add(this.drakeUIButtonIcon2);
			this.DrakeUITitlePanel1.Controls.Add(this.drakeUIButtonIcon1);
			this.DrakeUITitlePanel1.Controls.Add(this.Mytext);
			this.DrakeUITitlePanel1.Controls.Add(this.Mytitle);
			this.DrakeUITitlePanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DrakeUITitlePanel1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DrakeUITitlePanel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUITitlePanel1.ForeColor = global::System.Drawing.Color.White;
			this.DrakeUITitlePanel1.Location = new global::System.Drawing.Point(0, 0);
			this.DrakeUITitlePanel1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DrakeUITitlePanel1.Name = "DrakeUITitlePanel1";
			this.DrakeUITitlePanel1.RectColor = global::System.Drawing.Color.Blue;
			this.DrakeUITitlePanel1.Size = new global::System.Drawing.Size(324, 107);
			this.DrakeUITitlePanel1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUITitlePanel1.StyleCustomMode = true;
			this.DrakeUITitlePanel1.TabIndex = 6;
			this.DrakeUITitlePanel1.Text = null;
			this.DrakeUITitlePanel1.TitleColor = global::System.Drawing.Color.Red;
			this.DrakeUITitlePanel1.TitleHeight = 0;
			this.DrakeUITitlePanel1.TitleInterval = 0;
			this.drakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon2.FillColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.drakeUIButtonIcon2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon2.Location = new global::System.Drawing.Point(246, 66);
			this.drakeUIButtonIcon2.Name = "drakeUIButtonIcon2";
			this.drakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.drakeUIButtonIcon2.Size = new global::System.Drawing.Size(40, 35);
			this.drakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon2.TabIndex = 7;
			this.drakeUIButtonIcon2.Click += new global::System.EventHandler(this.drakeUIButtonIcon2_Click_1);
			this.drakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon1.FillColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.drakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon1.Location = new global::System.Drawing.Point(157, 67);
			this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
			this.drakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.drakeUIButtonIcon1.Size = new global::System.Drawing.Size(39, 35);
			this.drakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon1.Symbol = 61453;
			this.drakeUIButtonIcon1.TabIndex = 6;
			this.drakeUIButtonIcon1.Click += new global::System.EventHandler(this.drakeUIButtonIcon1_Click_1);
			this.guna2AnimateWindow1.TargetForm = this;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(324, 107);
			base.ControlBox = false;
			base.Controls.Add(this.DrakeUITitlePanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(324, 107);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(324, 107);
			base.Name = "Dialog1";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select";
			base.TopMost = true;
			this.DrakeUITitlePanel1.ResumeLayout(false);
			this.DrakeUITitlePanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000373 RID: 883
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000376 RID: 886
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Mytext")]
		internal global::System.Windows.Forms.TextBox Mytext;

		// Token: 0x04000377 RID: 887
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Mytitle")]
		internal global::System.Windows.Forms.Label Mytitle;

		// Token: 0x04000378 RID: 888
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x04000379 RID: 889
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x0400037A RID: 890
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon2;

		// Token: 0x0400037B RID: 891
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon1;

		// Token: 0x0400037C RID: 892
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUITitlePanel1")]
		internal global::DrakeUI.Framework.DrakeUITitlePanel DrakeUITitlePanel1;
	}
}
