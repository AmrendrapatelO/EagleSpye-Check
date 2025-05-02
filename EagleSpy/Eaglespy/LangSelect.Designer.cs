namespace Eaglespy
{
	// Token: 0x020000F0 RID: 240
	public partial class LangSelect : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C07 RID: 3079 RVA: 0x00007660 File Offset: 0x00005860
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0010F504 File Offset: 0x0010D704
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.sButton1 = new global::Sipaa.Framework.SButton();
			this.sButton2 = new global::Sipaa.Framework.SButton();
			this.sButton3 = new global::Sipaa.Framework.SButton();
			this.label8 = new global::System.Windows.Forms.Label();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			base.SuspendLayout();
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.sButton1.BackColor = global::System.Drawing.Color.MediumSlateBlue;
			this.sButton1.BorderColor = global::System.Drawing.Color.PaleVioletRed;
			this.sButton1.BorderRadius = 6;
			this.sButton1.BorderSize = 0;
			this.sButton1.FlatAppearance.BorderSize = 0;
			this.sButton1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.sButton1.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sButton1.ForeColor = global::System.Drawing.Color.White;
			this.sButton1.Location = new global::System.Drawing.Point(205, 123);
			this.sButton1.Name = "sButton1";
			this.sButton1.Size = new global::System.Drawing.Size(150, 40);
			this.sButton1.TabIndex = 0;
			this.sButton1.Text = "Русский";
			this.sButton1.UseVisualStyleBackColor = false;
			this.sButton1.Click += new global::System.EventHandler(this.sButton1_Click);
			this.sButton2.BackColor = global::System.Drawing.Color.MediumSlateBlue;
			this.sButton2.BorderColor = global::System.Drawing.Color.PaleVioletRed;
			this.sButton2.BorderRadius = 6;
			this.sButton2.BorderSize = 0;
			this.sButton2.FlatAppearance.BorderSize = 0;
			this.sButton2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.sButton2.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sButton2.ForeColor = global::System.Drawing.Color.White;
			this.sButton2.Location = new global::System.Drawing.Point(24, 123);
			this.sButton2.Name = "sButton2";
			this.sButton2.Size = new global::System.Drawing.Size(150, 40);
			this.sButton2.TabIndex = 1;
			this.sButton2.Text = "中国人";
			this.sButton2.UseVisualStyleBackColor = false;
			this.sButton2.Click += new global::System.EventHandler(this.sButton2_Click);
			this.sButton3.BackColor = global::System.Drawing.Color.MediumSlateBlue;
			this.sButton3.BorderColor = global::System.Drawing.Color.PaleVioletRed;
			this.sButton3.BorderRadius = 6;
			this.sButton3.BorderSize = 0;
			this.sButton3.FlatAppearance.BorderSize = 0;
			this.sButton3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.sButton3.Font = new global::System.Drawing.Font("Bahnschrift SemiBold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sButton3.ForeColor = global::System.Drawing.Color.White;
			this.sButton3.Location = new global::System.Drawing.Point(110, 234);
			this.sButton3.Name = "sButton3";
			this.sButton3.Size = new global::System.Drawing.Size(150, 40);
			this.sButton3.TabIndex = 2;
			this.sButton3.Text = "English";
			this.sButton3.UseVisualStyleBackColor = false;
			this.sButton3.Click += new global::System.EventHandler(this.sButton3_Click);
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(85, 32);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(205, 28);
			this.label8.TabIndex = 209;
			this.label8.Text = "Language Select";
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(334, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 210;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(391, 352);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.sButton3);
			base.Controls.Add(this.sButton2);
			base.Controls.Add(this.sButton1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "LangSelect";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LangSelect";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000F79 RID: 3961
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000F7A RID: 3962
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000F7B RID: 3963
		private global::Sipaa.Framework.SButton sButton1;

		// Token: 0x04000F7C RID: 3964
		private global::Sipaa.Framework.SButton sButton2;

		// Token: 0x04000F7D RID: 3965
		private global::Sipaa.Framework.SButton sButton3;

		// Token: 0x04000F7E RID: 3966
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000F7F RID: 3967
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
	}
}
