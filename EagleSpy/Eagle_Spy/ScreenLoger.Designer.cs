﻿namespace Eagle_Spy
{
	// Token: 0x0200009E RID: 158
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ScreenLoger : global::System.Windows.Forms.Form
	{
		// Token: 0x06000846 RID: 2118 RVA: 0x000CDC88 File Offset: 0x000CBE88
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

		// Token: 0x06000847 RID: 2119 RVA: 0x000CDCC8 File Offset: 0x000CBEC8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Logs = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.Logs.BackColor = global::System.Drawing.Color.Black;
			this.Logs.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.Logs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Logs.Font = new global::System.Drawing.Font("Microsoft PhagsPa", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Logs.ForeColor = global::System.Drawing.Color.White;
			this.Logs.Location = new global::System.Drawing.Point(0, 0);
			this.Logs.Multiline = true;
			this.Logs.Name = "Logs";
			this.Logs.ReadOnly = true;
			this.Logs.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.Logs.Size = new global::System.Drawing.Size(524, 601);
			this.Logs.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(524, 601);
			base.ControlBox = false;
			base.Controls.Add(this.Logs);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "ScreenLoger";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "ScreenLoger";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040009AA RID: 2474
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040009AB RID: 2475
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Logs")]
		internal global::System.Windows.Forms.TextBox Logs;
	}
}
