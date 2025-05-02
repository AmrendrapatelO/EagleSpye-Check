namespace Eagle_Spy
{
	// Token: 0x020000A8 RID: 168
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SMSManager : global::System.Windows.Forms.Form
	{
		// Token: 0x060008DB RID: 2267 RVA: 0x000DAB20 File Offset: 0x000D8D20
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

		// Token: 0x060008DC RID: 2268 RVA: 0x000DAB60 File Offset: 0x000D8D60
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
			this.Column7 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.ctx = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.PathsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OutboxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InboxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SentToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.QueuedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FailedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.PB = new global::System.Windows.Forms.ProgressBar();
			this.BoxTitle = new global::System.Windows.Forms.PictureBox();
			this.DrakeUIAvatar1 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.clinameinfo = new global::System.Windows.Forms.Label();
			this.ClientPic = new global::System.Windows.Forms.PictureBox();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.showtext = new global::System.Windows.Forms.TextBox();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
			this.ctx.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).BeginInit();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
			this.Panel1.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column6, this.Column9, this.Column7, this.Column2, this.Column3 });
			this.DGV0.ContextMenuStrip = this.ctx;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Calibri", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 7, 115);
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DGV0.DefaultCellStyle = dataGridViewCellStyle3;
			this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGV0.EnableHeadersVisualStyles = false;
			this.DGV0.GridColor = global::System.Drawing.Color.Blue;
			this.DGV0.Location = new global::System.Drawing.Point(0, 32);
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
			this.DGV0.Size = new global::System.Drawing.Size(522, 562);
			this.DGV0.TabIndex = 3;
			this.DGV0.CellClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.DGV0_CellClick);
			this.DGV0.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.DGV0_CellContentClick);
			this.DGV0.RowEnter += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.DGV0_RowEnter);
			this.DGV0.RowsAdded += new global::System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV0_RowsAdded);
			this.DGV0.RowsRemoved += new global::System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV0_RowsRemoved);
			this.DGV0.SelectionChanged += new global::System.EventHandler(this.DGV0_SelectionChanged);
			this.Column1.HeaderText = "address";
			this.Column1.Name = "Column1";
			this.Column1.Width = 65;
			this.Column6.HeaderText = "name";
			this.Column6.Name = "Column6";
			this.Column6.Width = 56;
			this.Column9.HeaderText = "date";
			this.Column9.Name = "Column9";
			this.Column9.Width = 51;
			this.Column7.HeaderText = "part";
			this.Column7.Name = "Column7";
			this.Column7.Width = 49;
			this.Column2.HeaderText = "path";
			this.Column2.Name = "Column2";
			this.Column2.Width = 51;
			this.Column3.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column3.FillWeight = 1f;
			this.Column3.HeaderText = "";
			this.Column3.MinimumWidth = 2;
			this.Column3.Name = "Column3";
			this.Column3.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.Column3.Width = 2;
			this.ctx.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.ctx.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.PathsToolStripMenuItem, this.SaveToolStripMenuItem, this.SaveAsToolStripMenuItem });
			this.ctx.Name = "ContextMenuStrip1";
			this.ctx.ShowImageMargin = false;
			this.ctx.Size = new global::System.Drawing.Size(90, 70);
			this.PathsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.AllToolStripMenuItem, this.OutboxToolStripMenuItem, this.InboxToolStripMenuItem, this.SentToolStripMenuItem, this.QueuedToolStripMenuItem, this.FailedToolStripMenuItem });
			this.PathsToolStripMenuItem.Name = "PathsToolStripMenuItem";
			this.PathsToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
			this.PathsToolStripMenuItem.Text = "Paths";
			this.AllToolStripMenuItem.Name = "AllToolStripMenuItem";
			this.AllToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.AllToolStripMenuItem.Text = "all";
			this.AllToolStripMenuItem.Click += new global::System.EventHandler(this.AllToolStripMenuItem_Click);
			this.OutboxToolStripMenuItem.Name = "OutboxToolStripMenuItem";
			this.OutboxToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.OutboxToolStripMenuItem.Text = "outbox";
			this.OutboxToolStripMenuItem.Click += new global::System.EventHandler(this.OutboxToolStripMenuItem_Click);
			this.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem";
			this.InboxToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.InboxToolStripMenuItem.Text = "inbox";
			this.InboxToolStripMenuItem.Click += new global::System.EventHandler(this.InboxToolStripMenuItem_Click);
			this.SentToolStripMenuItem.Name = "SentToolStripMenuItem";
			this.SentToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.SentToolStripMenuItem.Text = "sent";
			this.SentToolStripMenuItem.Click += new global::System.EventHandler(this.SentToolStripMenuItem_Click);
			this.QueuedToolStripMenuItem.Name = "QueuedToolStripMenuItem";
			this.QueuedToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.QueuedToolStripMenuItem.Text = "queued";
			this.QueuedToolStripMenuItem.Click += new global::System.EventHandler(this.QueuedToolStripMenuItem_Click);
			this.FailedToolStripMenuItem.Name = "FailedToolStripMenuItem";
			this.FailedToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.FailedToolStripMenuItem.Text = "failed";
			this.FailedToolStripMenuItem.Click += new global::System.EventHandler(this.FailedToolStripMenuItem_Click);
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			this.SaveToolStripMenuItem.Click += new global::System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcytrqa);
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(89, 22);
			this.SaveAsToolStripMenuItem.Text = "Save As";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Click += new global::System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsjufrswas);
			this.TOpacity.Interval = 1;
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			this.PB.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.PB.Location = new global::System.Drawing.Point(0, 594);
			this.PB.Name = "PB";
			this.PB.Size = new global::System.Drawing.Size(522, 10);
			this.PB.TabIndex = 6;
			this.BoxTitle.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.BoxTitle.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.BoxTitle.ErrorImage = null;
			this.BoxTitle.InitialImage = null;
			this.BoxTitle.Location = new global::System.Drawing.Point(0, 604);
			this.BoxTitle.Name = "BoxTitle";
			this.BoxTitle.Size = new global::System.Drawing.Size(522, 18);
			this.BoxTitle.TabIndex = 7;
			this.BoxTitle.TabStop = false;
			this.BoxTitle.Paint += new global::System.Windows.Forms.PaintEventHandler(this.BoxTitle_Paint);
			this.BoxTitle.Resize += new global::System.EventHandler(this.BoxTitle_Resize);
			this.DrakeUIAvatar1.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.DrakeUIAvatar1.BackColor = global::System.Drawing.Color.Transparent;
			this.DrakeUIAvatar1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIAvatar1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DrakeUIAvatar1.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.DrakeUIAvatar1.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DrakeUIAvatar1.Location = new global::System.Drawing.Point(211, 575);
			this.DrakeUIAvatar1.Margin = new global::System.Windows.Forms.Padding(2);
			this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
			this.DrakeUIAvatar1.Size = new global::System.Drawing.Size(42, 37);
			this.DrakeUIAvatar1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIAvatar1.Symbol = 61912;
			this.DrakeUIAvatar1.TabIndex = 9;
			this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Send SMS");
			this.DrakeUIAvatar1.Click += new global::System.EventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsqwsakartx);
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
			this.DrakeUIToolTip1.OwnerDraw = true;
			this.Panel2.BackColor = global::System.Drawing.Color.Black;
			this.Panel2.Controls.Add(this.clinameinfo);
			this.Panel2.Controls.Add(this.ClientPic);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.ForeColor = global::System.Drawing.Color.Red;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Margin = new global::System.Windows.Forms.Padding(2);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(522, 32);
			this.Panel2.TabIndex = 10;
			this.clinameinfo.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.clinameinfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.clinameinfo.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.clinameinfo.ForeColor = global::System.Drawing.Color.Lime;
			this.clinameinfo.Location = new global::System.Drawing.Point(32, 0);
			this.clinameinfo.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.clinameinfo.Name = "clinameinfo";
			this.clinameinfo.Size = new global::System.Drawing.Size(490, 32);
			this.clinameinfo.TabIndex = 12;
			this.clinameinfo.Text = "...";
			this.clinameinfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.clinameinfo.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.clinameinfo_MouseDown);
			this.ClientPic.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.ClientPic.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.ClientPic.Location = new global::System.Drawing.Point(0, 0);
			this.ClientPic.Margin = new global::System.Windows.Forms.Padding(2, 3, 2, 3);
			this.ClientPic.Name = "ClientPic";
			this.ClientPic.Size = new global::System.Drawing.Size(32, 32);
			this.ClientPic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ClientPic.TabIndex = 11;
			this.ClientPic.TabStop = false;
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel1.Controls.Add(this.guna2ControlBox1);
			this.Panel1.Controls.Add(this.label2);
			this.Panel1.Controls.Add(this.panel3);
			this.Panel1.Controls.Add(this.DrakeUIAvatar1);
			this.Panel1.Controls.Add(this.showtext);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Panel1.Font = new global::System.Drawing.Font("Calibri", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Panel1.ForeColor = global::System.Drawing.Color.White;
			this.Panel1.Location = new global::System.Drawing.Point(522, 0);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(287, 622);
			this.Panel1.TabIndex = 11;
			this.Panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(230, 3);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 74;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(52, 548);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(140, 19);
			this.label2.TabIndex = 10;
			this.label2.Text = "OPEN SMS SENDER";
			this.panel3.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 64);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new global::System.Drawing.Point(25, 64);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(200, 37);
			this.panel3.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(40, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(121, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "SMS Texts here !";
			this.showtext.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.showtext.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.showtext.Font = new global::System.Drawing.Font("Bahnschrift", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.showtext.ForeColor = global::System.Drawing.Color.White;
			this.showtext.Location = new global::System.Drawing.Point(0, 133);
			this.showtext.Margin = new global::System.Windows.Forms.Padding(2);
			this.showtext.Multiline = true;
			this.showtext.Name = "showtext";
			this.showtext.Size = new global::System.Drawing.Size(287, 399);
			this.showtext.TabIndex = 0;
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(809, 622);
			base.Controls.Add(this.DGV0);
			base.Controls.Add(this.PB);
			base.Controls.Add(this.BoxTitle);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new global::System.Drawing.Size(809, 622);
			this.MinimumSize = new global::System.Drawing.Size(809, 622);
			base.Name = "SMSManager";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			this.Text = "SMSManager";
			base.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ctx.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.BoxTitle).EndInit();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000A83 RID: 2691
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000A8C RID: 2700
		internal global::System.Windows.Forms.DataGridView DGV0;

		// Token: 0x04000A8D RID: 2701
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ctx")]
		internal global::System.Windows.Forms.ContextMenuStrip ctx;

		// Token: 0x04000A8E RID: 2702
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("PathsToolStripMenuItem")]
		internal global::System.Windows.Forms.ToolStripMenuItem PathsToolStripMenuItem;

		// Token: 0x04000A8F RID: 2703
		internal global::System.Windows.Forms.ToolStripMenuItem AllToolStripMenuItem;

		// Token: 0x04000A90 RID: 2704
		internal global::System.Windows.Forms.ToolStripMenuItem OutboxToolStripMenuItem;

		// Token: 0x04000A91 RID: 2705
		internal global::System.Windows.Forms.ToolStripMenuItem InboxToolStripMenuItem;

		// Token: 0x04000A92 RID: 2706
		internal global::System.Windows.Forms.ToolStripMenuItem SentToolStripMenuItem;

		// Token: 0x04000A93 RID: 2707
		internal global::System.Windows.Forms.ToolStripMenuItem QueuedToolStripMenuItem;

		// Token: 0x04000A94 RID: 2708
		internal global::System.Windows.Forms.ToolStripMenuItem FailedToolStripMenuItem;

		// Token: 0x04000A95 RID: 2709
		internal global::System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

		// Token: 0x04000A96 RID: 2710
		internal global::System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;

		// Token: 0x04000A97 RID: 2711
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x04000A98 RID: 2712
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("PB")]
		internal global::System.Windows.Forms.ProgressBar PB;

		// Token: 0x04000A99 RID: 2713
		internal global::System.Windows.Forms.PictureBox BoxTitle;

		// Token: 0x04000A9A RID: 2714
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column1")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;

		// Token: 0x04000A9B RID: 2715
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column6")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column6;

		// Token: 0x04000A9C RID: 2716
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column9")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column9;

		// Token: 0x04000A9D RID: 2717
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column7")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column7;

		// Token: 0x04000A9E RID: 2718
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column2")]
		internal global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;

		// Token: 0x04000A9F RID: 2719
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Column3")]
		internal global::System.Windows.Forms.DataGridViewImageColumn Column3;

		// Token: 0x04000AA0 RID: 2720
		internal global::DrakeUI.Framework.DrakeUIAvatar DrakeUIAvatar1;

		// Token: 0x04000AA1 RID: 2721
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("DrakeUIToolTip1")]
		internal global::DrakeUI.Framework.DrakeUIToolTip DrakeUIToolTip1;

		// Token: 0x04000AA2 RID: 2722
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel2")]
		internal global::System.Windows.Forms.Panel Panel2;

		// Token: 0x04000AA3 RID: 2723
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("clinameinfo")]
		internal global::System.Windows.Forms.Label clinameinfo;

		// Token: 0x04000AA4 RID: 2724
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("ClientPic")]
		internal global::System.Windows.Forms.PictureBox ClientPic;

		// Token: 0x04000AA5 RID: 2725
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("Panel1")]
		internal global::System.Windows.Forms.Panel Panel1;

		// Token: 0x04000AA6 RID: 2726
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000AA7 RID: 2727
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000AA8 RID: 2728
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000AA9 RID: 2729
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000AAA RID: 2730
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000AAB RID: 2731
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("showtext")]
		internal global::System.Windows.Forms.TextBox showtext;
	}
}
