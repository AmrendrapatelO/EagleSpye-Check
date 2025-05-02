namespace Eagle_Spy
{
	// Token: 0x02000010 RID: 16
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AccountManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000191 RID: 401 RVA: 0x0000AED8 File Offset: 0x000090D8
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

		// Token: 0x06000192 RID: 402 RVA: 0x0000AF18 File Offset: 0x00009118
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
			this.Column2 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.PB = new global::System.Windows.Forms.ProgressBar();
			this.BoxTitle = new global::System.Windows.Forms.PictureBox();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.drakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.drakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.drakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
			this.ctxMenu.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
			this.guna2Panel1.SuspendLayout();
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
			this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
			this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Consolas", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 7, 115);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column6, this.Column2 });
			this.DGV0.ContextMenuStrip = this.ctxMenu;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 7, 115);
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
			this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGV0.EnableHeadersVisualStyles = false;
			this.DGV0.GridColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.DGV0.Location = new global::System.Drawing.Point(3, 33);
			this.DGV0.Name = "DGV0";
			this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
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
			this.DGV0.Size = new global::System.Drawing.Size(427, 454);
			this.DGV0.TabIndex = 3;
			this.DGV0.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
			this.DGV0.RowsRemoved += new global::System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
			this.DGV0.SelectionChanged += new global::System.EventHandler(this.DGV0_SelectionChanged);
			this.Column1.HeaderText = "Program";
			this.Column1.Name = "Column1";
			this.Column1.Width = 72;
			this.Column6.HeaderText = "Account";
			this.Column6.Name = "Column6";
			this.Column6.Width = 72;
			this.Column2.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column2.FillWeight = 1f;
			this.Column2.HeaderText = "";
			this.Column2.MinimumWidth = 2;
			this.Column2.Name = "Column2";
			this.Column2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Column2.Width = 2;
			this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem });
			this.ctxMenu.Name = "ctxMenu";
			this.ctxMenu.ShowImageMargin = false;
			this.ctxMenu.Size = new global::System.Drawing.Size(90, 48);
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			this.SaveToolStripMenuItem.Click += new global::System.EventHandler(this.SaveToolStripMenuItem_Click);
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
			this.SaveAsToolStripMenuItem.Text = "Save As";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Click += new global::System.EventHandler(this.SaveAsToolStripMenuItem_Click);
			this.TOpacity.Interval = 1;
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.PB.BackColor = global::System.Drawing.Color.Navy;
			this.PB.Location = new global::System.Drawing.Point(3, 524);
			this.PB.Name = "PB";
			this.PB.Size = new global::System.Drawing.Size(427, 5);
			this.PB.TabIndex = 6;
			this.BoxTitle.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.BoxTitle.ErrorImage = null;
			this.BoxTitle.InitialImage = null;
			this.BoxTitle.Location = new global::System.Drawing.Point(0, 532);
			this.BoxTitle.Name = "BoxTitle";
			this.BoxTitle.Size = new global::System.Drawing.Size(434, 10);
			this.BoxTitle.TabIndex = 7;
			this.BoxTitle.TabStop = false;
			this.BoxTitle.Paint += new global::System.Windows.Forms.PaintEventHandler(this.BoxTitle_Paint);
			this.BoxTitle.Resize += new global::System.EventHandler(this.BoxTitle_Resize);
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.guna2Panel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2Panel1.BorderColor = global::System.Drawing.Color.Navy;
			this.guna2Panel1.BorderRadius = 15;
			this.guna2Panel1.BorderThickness = 1;
			this.guna2Panel1.Controls.Add(this.drakeUIButtonIcon3);
			this.guna2Panel1.Controls.Add(this.drakeUIButtonIcon2);
			this.guna2Panel1.Controls.Add(this.drakeUIButtonIcon1);
			this.guna2Panel1.Controls.Add(this.guna2Panel2);
			this.guna2Panel1.Controls.Add(this.DGV0);
			this.guna2Panel1.Controls.Add(this.PB);
			this.guna2Panel1.Controls.Add(this.BoxTitle);
			this.guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.guna2Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(434, 542);
			this.guna2Panel1.TabIndex = 8;
			this.drakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon3.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon3.FillDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.FillHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.FillPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.FillSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.Font = new global::System.Drawing.Font("Candara", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.drakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon3.ForeDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.ForePressColor = global::System.Drawing.Color.Aqua;
			this.drakeUIButtonIcon3.ForeSelectedColor = global::System.Drawing.Color.MediumSpringGreen;
			this.drakeUIButtonIcon3.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.drakeUIButtonIcon3.Location = new global::System.Drawing.Point(43, 493);
			this.drakeUIButtonIcon3.Name = "drakeUIButtonIcon3";
			this.drakeUIButtonIcon3.RectColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon3.RectSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.drakeUIButtonIcon3.Size = new global::System.Drawing.Size(102, 25);
			this.drakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon3.StyleCustomMode = true;
			this.drakeUIButtonIcon3.Symbol = 61564;
			this.drakeUIButtonIcon3.TabIndex = 13;
			this.drakeUIButtonIcon3.Text = "Saved Folder";
			this.drakeUIButtonIcon3.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.drakeUIButtonIcon3.TipsColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.drakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon2.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.FillHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.FillPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.FillSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.Font = new global::System.Drawing.Font("Candara", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.drakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon2.ForeDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.ForePressColor = global::System.Drawing.Color.Aqua;
			this.drakeUIButtonIcon2.ForeSelectedColor = global::System.Drawing.Color.MediumSpringGreen;
			this.drakeUIButtonIcon2.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.drakeUIButtonIcon2.Location = new global::System.Drawing.Point(196, 495);
			this.drakeUIButtonIcon2.Name = "drakeUIButtonIcon2";
			this.drakeUIButtonIcon2.RectColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.RectHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.RectPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.RectSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon2.RectSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.drakeUIButtonIcon2.Size = new global::System.Drawing.Size(56, 25);
			this.drakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon2.StyleCustomMode = true;
			this.drakeUIButtonIcon2.Symbol = 61639;
			this.drakeUIButtonIcon2.TabIndex = 12;
			this.drakeUIButtonIcon2.Text = "Save";
			this.drakeUIButtonIcon2.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.drakeUIButtonIcon2.TipsColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.drakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.Font = new global::System.Drawing.Font("Candara", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.drakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.drakeUIButtonIcon1.ForeDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.ForePressColor = global::System.Drawing.Color.Aqua;
			this.drakeUIButtonIcon1.ForeSelectedColor = global::System.Drawing.Color.MediumSpringGreen;
			this.drakeUIButtonIcon1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.drakeUIButtonIcon1.Location = new global::System.Drawing.Point(327, 495);
			this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
			this.drakeUIButtonIcon1.RectColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.Empty;
			this.drakeUIButtonIcon1.RectSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
			this.drakeUIButtonIcon1.Size = new global::System.Drawing.Size(69, 25);
			this.drakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon1.StyleCustomMode = true;
			this.drakeUIButtonIcon1.Symbol = 61639;
			this.drakeUIButtonIcon1.TabIndex = 11;
			this.drakeUIButtonIcon1.Text = "Save As";
			this.drakeUIButtonIcon1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.drakeUIButtonIcon1.TipsColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.guna2Panel2.BackColor = global::System.Drawing.Color.FromArgb(10, 0, 36);
			this.guna2Panel2.Controls.Add(this.guna2ControlBox1);
			this.guna2Panel2.Controls.Add(this.label2);
			this.guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.guna2Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new global::System.Drawing.Size(434, 30);
			this.guna2Panel2.TabIndex = 8;
			this.guna2Panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseDown);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.label2.Location = new global::System.Drawing.Point(145, 2);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(97, 24);
			this.label2.TabIndex = 15;
			this.label2.Text = "Accounts";
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.FromArgb(10, 0, 36);
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(377, -1);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 16;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(434, 542);
			base.Controls.Add(this.guna2Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "AccountManager";
			base.Opacity = 0.0;
			this.Text = "AccountManager";
			base.Load += new global::System.EventHandler(this.AccountManager_Load);
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ctxMenu.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001B RID: 27
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000024 RID: 36
		internal global::System.Windows.Forms.DataGridView DGV0;

		// Token: 0x04000025 RID: 37
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctxMenu")]
		internal global::System.Windows.Forms.ContextMenuStrip ctxMenu;

		// Token: 0x04000026 RID: 38
		internal global::System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

		// Token: 0x04000027 RID: 39
		internal global::System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

		// Token: 0x04000028 RID: 40
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x04000029 RID: 41
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("PB")]
		internal global::System.Windows.Forms.ProgressBar PB;

		// Token: 0x0400002A RID: 42
		internal global::System.Windows.Forms.PictureBox BoxTitle;

		// Token: 0x0400002B RID: 43
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column1")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x0400002C RID: 44
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column6")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column6;

		// Token: 0x0400002D RID: 45
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x0400002E RID: 46
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x0400002F RID: 47
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel2;

		// Token: 0x04000030 RID: 48
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon1;

		// Token: 0x04000031 RID: 49
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon3;

		// Token: 0x04000032 RID: 50
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon2;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000034 RID: 52
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000035 RID: 53
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column2")]
		internal global::System.Windows.Forms.DataGridViewImageColumn Column2;
	}
}
