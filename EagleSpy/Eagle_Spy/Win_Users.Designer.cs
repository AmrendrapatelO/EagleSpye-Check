﻿namespace Eagle_Spy
{
	// Token: 0x020000B1 RID: 177
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Win_Users : global::System.Windows.Forms.Form
	{
		// Token: 0x06000945 RID: 2373 RVA: 0x000E6E44 File Offset: 0x000E5044
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

		// Token: 0x06000946 RID: 2374 RVA: 0x000E6E84 File Offset: 0x000E5084
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.DGV0 = new global::System.Windows.Forms.DataGridView();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.ctxz = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.OpenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
			this.ctxz.SuspendLayout();
			base.SuspendLayout();
			this.DGV0.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.DGV0_CellContentClick);
			this.DGV0.CellMouseDoubleClick += new global::System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV0_CellMouseDoubleClick);
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.OpenToolStripMenuItem.Click += new global::System.EventHandler(this.OpenToolStripMenuItem_Click);
			this.DeleteToolStripMenuItem.Click += new global::System.EventHandler(this.DeleteToolStripMenuItem_Click);
			this.DGV0.AllowUserToAddRows = false;
			this.DGV0.AllowUserToDeleteRows = false;
			this.DGV0.AllowUserToResizeColumns = false;
			this.DGV0.AllowUserToResizeRows = false;
			this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DGV0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGV0.BackgroundColor = global::System.Drawing.Color.Black;
			this.DGV0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column6, this.Column3, this.Column2 });
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
			this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGV0.EnableHeadersVisualStyles = false;
			this.DGV0.GridColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.DGV0.Location = new global::System.Drawing.Point(0, 0);
			this.DGV0.Name = "DGV0";
			this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DGV0.RowHeadersVisible = false;
			this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV0.Size = new global::System.Drawing.Size(393, 338);
			this.DGV0.TabIndex = 4;
			this.Column1.HeaderText = "Name";
			this.Column1.Name = "Column1";
			this.Column1.Width = 61;
			this.Column6.HeaderText = "IP";
			this.Column6.Name = "Column6";
			this.Column6.Width = 40;
			this.Column3.HeaderText = "UUID";
			this.Column3.Name = "Column3";
			this.Column3.Width = 54;
			this.Column2.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column2.FillWeight = 1f;
			this.Column2.HeaderText = "";
			this.Column2.MinimumWidth = 2;
			this.Column2.Name = "Column2";
			this.Column2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Column2.Width = 2;
			this.TOpacity.Interval = 1;
			this.ctxz.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.OpenToolStripMenuItem, this.DeleteToolStripMenuItem });
			this.ctxz.Name = "ctxz";
			this.ctxz.ShowImageMargin = false;
			this.ctxz.Size = new global::System.Drawing.Size(156, 70);
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.OpenToolStripMenuItem.Text = "Open";
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.DeleteToolStripMenuItem.Text = "Delete";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(393, 338);
			base.Controls.Add(this.DGV0);
			base.Name = "Win_Users";
			base.Opacity = 0.0;
			this.Text = "Win_Users";
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ctxz.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000B56 RID: 2902
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000B57 RID: 2903
		internal global::System.Windows.Forms.DataGridView DGV0;

		// Token: 0x04000B58 RID: 2904
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column1")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x04000B59 RID: 2905
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column6")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column6;

		// Token: 0x04000B5A RID: 2906
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column3")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column3;

		// Token: 0x04000B5B RID: 2907
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column2")]
		internal global::System.Windows.Forms.DataGridViewImageColumn Column2;

		// Token: 0x04000B5C RID: 2908
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x04000B5D RID: 2909
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctxz")]
		internal global::System.Windows.Forms.ContextMenuStrip ctxz;

		// Token: 0x04000B5E RID: 2910
		internal global::System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;

		// Token: 0x04000B5F RID: 2911
		internal global::System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
	}
}
