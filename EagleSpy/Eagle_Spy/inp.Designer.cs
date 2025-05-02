namespace Eagle_Spy
{
	// Token: 0x0200006F RID: 111
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class inp : global::System.Windows.Forms.Form
	{
		// Token: 0x0600068F RID: 1679 RVA: 0x000B0C98 File Offset: 0x000AEE98
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

		// Token: 0x06000690 RID: 1680 RVA: 0x000B0CD8 File Offset: 0x000AEED8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.b_ok = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.InputText = new global::DrakeUI.Framework.DrakeUITextBox();
			this.BOXX = new global::System.Windows.Forms.Panel();
			this.CheckHidden = new global::System.Windows.Forms.CheckBox();
			this.CheckFolder = new global::System.Windows.Forms.CheckBox();
			this.LTitle = new global::System.Windows.Forms.Label();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1.SuspendLayout();
			this.BOXX.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.Panel1.Controls.Add(this.b_ok);
			this.Panel1.Controls.Add(this.InputText);
			this.Panel1.Controls.Add(this.BOXX);
			this.Panel1.Controls.Add(this.LTitle);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(432, 130);
			this.Panel1.TabIndex = 0;
			this.Panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			this.b_ok.BackColor = global::System.Drawing.Color.Transparent;
			this.b_ok.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.b_ok.FillColor = global::System.Drawing.Color.Transparent;
			this.b_ok.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.b_ok.FillPressColor = global::System.Drawing.Color.Black;
			this.b_ok.FillSelectedColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
			this.b_ok.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.b_ok.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b_ok.ForePressColor = global::System.Drawing.Color.FromArgb(254, 0, 0);
			this.b_ok.Location = new global::System.Drawing.Point(344, 95);
			this.b_ok.Name = "b_ok";
			this.b_ok.Radius = 10;
			this.b_ok.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.b_ok.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.b_ok.RectHoverColor = global::System.Drawing.Color.White;
			this.b_ok.RectPressColor = global::System.Drawing.Color.White;
			this.b_ok.RectSelectedColor = global::System.Drawing.Color.White;
			this.b_ok.Size = new global::System.Drawing.Size(79, 26);
			this.b_ok.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.b_ok.SymbolSize = 0;
			this.b_ok.TabIndex = 49;
			this.b_ok.Text = "OK";
			this.b_ok.Click += new global::System.EventHandler(this.B_ok_Click_1);
			this.InputText.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.InputText.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.InputText.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.InputText.ForeColor = global::System.Drawing.Color.White;
			this.InputText.Location = new global::System.Drawing.Point(14, 52);
			this.InputText.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.InputText.Maximum = 2147483647.0;
			this.InputText.Minimum = -2147483648.0;
			this.InputText.Name = "InputText";
			this.InputText.Padding = new global::System.Windows.Forms.Padding(5, 5, 5, 5);
			this.InputText.Radius = 10;
			this.InputText.RectColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.InputText.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.InputText.Size = new global::System.Drawing.Size(406, 27);
			this.InputText.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.InputText.StyleCustomMode = true;
			this.InputText.TabIndex = 44;
			this.InputText.TextAlignment = global::System.Drawing.ContentAlignment.TopCenter;
			this.InputText.Watermark = "";
			this.BOXX.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.BOXX.Controls.Add(this.CheckHidden);
			this.BOXX.Controls.Add(this.CheckFolder);
			this.BOXX.Location = new global::System.Drawing.Point(12, 95);
			this.BOXX.Name = "BOXX";
			this.BOXX.Size = new global::System.Drawing.Size(326, 23);
			this.BOXX.TabIndex = 4;
			this.BOXX.Visible = false;
			this.CheckHidden.AutoSize = true;
			this.CheckHidden.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.CheckHidden.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.CheckHidden.Location = new global::System.Drawing.Point(213, 0);
			this.CheckHidden.Name = "CheckHidden";
			this.CheckHidden.Size = new global::System.Drawing.Size(58, 23);
			this.CheckHidden.TabIndex = 1;
			this.CheckHidden.Text = "hidden";
			this.CheckHidden.UseVisualStyleBackColor = true;
			this.CheckFolder.AutoSize = true;
			this.CheckFolder.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.CheckFolder.ForeColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.CheckFolder.Location = new global::System.Drawing.Point(271, 0);
			this.CheckFolder.Name = "CheckFolder";
			this.CheckFolder.Size = new global::System.Drawing.Size(55, 23);
			this.CheckFolder.TabIndex = 0;
			this.CheckFolder.Text = "Folder";
			this.CheckFolder.UseVisualStyleBackColor = true;
			this.LTitle.AutoSize = true;
			this.LTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LTitle.ForeColor = global::System.Drawing.Color.Lime;
			this.LTitle.Location = new global::System.Drawing.Point(12, 23);
			this.LTitle.Name = "LTitle";
			this.LTitle.Size = new global::System.Drawing.Size(33, 20);
			this.LTitle.TabIndex = 1;
			this.LTitle.Text = "null";
			this.TOpacity.Interval = 1;
			this.TOpacity.Tick += new global::System.EventHandler(this.TOpacity_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(432, 130);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "inp";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "inp";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.BOXX.ResumeLayout(false);
			this.BOXX.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000772 RID: 1906
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000774 RID: 1908
		internal global::System.Windows.Forms.Panel Panel1;

		// Token: 0x04000775 RID: 1909
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("LTitle")]
		internal global::System.Windows.Forms.Label LTitle;

		// Token: 0x04000776 RID: 1910
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("BOXX")]
		internal global::System.Windows.Forms.Panel BOXX;

		// Token: 0x04000777 RID: 1911
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("CheckHidden")]
		internal global::System.Windows.Forms.CheckBox CheckHidden;

		// Token: 0x04000778 RID: 1912
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("CheckFolder")]
		internal global::System.Windows.Forms.CheckBox CheckFolder;

		// Token: 0x04000779 RID: 1913
		internal global::System.Windows.Forms.Timer TOpacity;

		// Token: 0x0400077A RID: 1914
		[global::System.Runtime.CompilerServices.AccessedThroughProperty("InputText")]
		internal global::DrakeUI.Framework.DrakeUITextBox InputText;

		// Token: 0x0400077B RID: 1915
		internal global::DrakeUI.Framework.DrakeUIButtonIcon b_ok;
	}
}
