﻿namespace Eagle_Spy
{
	// Token: 0x020000A4 RID: 164
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SelfRemove : global::System.Windows.Forms.Form
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x000D29CC File Offset: 0x000D0BCC
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

		// Token: 0x06000891 RID: 2193 RVA: 0x000D2A0C File Offset: 0x000D0C0C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Label34 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.clientpic = new global::System.Windows.Forms.PictureBox();
			this.checkrecords = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.checkkeylogs = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.checktouch = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			((global::System.ComponentModel.ISupportInitialize)this.clientpic).BeginInit();
			base.SuspendLayout();
			this.Label34.AutoSize = true;
			this.Label34.BackColor = global::System.Drawing.Color.Transparent;
			this.Label34.Font = new global::System.Drawing.Font("Calibri", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label34.ForeColor = global::System.Drawing.Color.White;
			this.Label34.Location = new global::System.Drawing.Point(99, 161);
			this.Label34.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label34.Name = "Label34";
			this.Label34.Size = new global::System.Drawing.Size(148, 24);
			this.Label34.TabIndex = 66;
			this.Label34.Text = "Remove Records";
			this.Label34.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Calibri", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			this.Label1.Location = new global::System.Drawing.Point(99, 238);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(143, 24);
			this.Label1.TabIndex = 68;
			this.Label1.Text = "Remove keylogs";
			this.Label1.Visible = false;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Calibri", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.White;
			this.Label2.Location = new global::System.Drawing.Point(99, 314);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(148, 24);
			this.Label2.TabIndex = 70;
			this.Label2.Text = "Remove touches";
			this.Label2.Visible = false;
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(19, 196);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(363, 38);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.Symbol = 61944;
			this.DrakeUIButtonIcon1.TabIndex = 71;
			this.DrakeUIButtonIcon1.Text = "UNINSTALL NOW";
			this.DrakeUIButtonIcon1.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
			this.clientpic.Location = new global::System.Drawing.Point(175, 23);
			this.clientpic.Name = "clientpic";
			this.clientpic.Size = new global::System.Drawing.Size(50, 47);
			this.clientpic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.clientpic.TabIndex = 72;
			this.clientpic.TabStop = false;
			this.checkrecords.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checkrecords.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkrecords.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.checkrecords.Location = new global::System.Drawing.Point(21, 162);
			this.checkrecords.Name = "checkrecords";
			this.checkrecords.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checkrecords.Size = new global::System.Drawing.Size(45, 33);
			this.checkrecords.TabIndex = 73;
			this.checkrecords.Visible = false;
			this.checkkeylogs.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checkkeylogs.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkkeylogs.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.checkkeylogs.Location = new global::System.Drawing.Point(21, 240);
			this.checkkeylogs.Name = "checkkeylogs";
			this.checkkeylogs.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checkkeylogs.Size = new global::System.Drawing.Size(45, 33);
			this.checkkeylogs.TabIndex = 74;
			this.checkkeylogs.Visible = false;
			this.checktouch.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checktouch.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checktouch.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.checktouch.Location = new global::System.Drawing.Point(21, 316);
			this.checktouch.Name = "checktouch";
			this.checktouch.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checktouch.Size = new global::System.Drawing.Size(45, 33);
			this.checktouch.TabIndex = 75;
			this.checktouch.Visible = false;
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(28, 96);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(354, 54);
			this.label3.TabIndex = 76;
			this.label3.Text = "After Self Destruct, Virus will be completely remove\r\nFrom victim's phone and you will not have \r\naccess on this phone";
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.Red;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(359, 2);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 77;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 18f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(407, 255);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.checktouch);
			base.Controls.Add(this.checkkeylogs);
			base.Controls.Add(this.clientpic);
			base.Controls.Add(this.DrakeUIButtonIcon1);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Label34);
			base.Controls.Add(this.checkrecords);
			this.Font = new global::System.Drawing.Font("Bahnschrift", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new global::System.Drawing.Size(407, 255);
			this.MinimumSize = new global::System.Drawing.Size(407, 255);
			base.Name = "SelfRemove";
			base.ShowIcon = false;
			this.Text = "Self Remove";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.SelfRemove_Load_1);
			((global::System.ComponentModel.ISupportInitialize)this.clientpic).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A1A RID: 2586
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000A1C RID: 2588
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label34")]
		internal global::System.Windows.Forms.Label Label34;

		// Token: 0x04000A1D RID: 2589
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
		internal global::System.Windows.Forms.Label Label1;

		// Token: 0x04000A1E RID: 2590
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
		internal global::System.Windows.Forms.Label Label2;

		// Token: 0x04000A1F RID: 2591
		internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;

		// Token: 0x04000A20 RID: 2592
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("clientpic")]
		internal global::System.Windows.Forms.PictureBox clientpic;

		// Token: 0x04000A21 RID: 2593
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("checkrecords")]
		internal global::DrakeUI.Framework.DrakeUICheckBox checkrecords;

		// Token: 0x04000A22 RID: 2594
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("checkkeylogs")]
		internal global::DrakeUI.Framework.DrakeUICheckBox checkkeylogs;

		// Token: 0x04000A23 RID: 2595
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000A24 RID: 2596
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000A25 RID: 2597
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000A26 RID: 2598
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("checktouch")]
		internal global::DrakeUI.Framework.DrakeUICheckBox checktouch;
	}
}
