namespace Eaglespy
{
	// Token: 0x020000DF RID: 223
	public partial class About : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B5F RID: 2911 RVA: 0x0000735C File Offset: 0x0000555C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x000F70F0 File Offset: 0x000F52F0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.drakeUIScrollingText1 = new global::DrakeUI.Framework.DrakeUIScrollingText();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2BorderlessForm1.AnimationType = global::Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
			this.guna2BorderlessForm1.BorderRadius = 15;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Blue;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.drakeUIScrollingText1.FillColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			this.drakeUIScrollingText1.Font = new global::System.Drawing.Font("OCR A Extended", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.drakeUIScrollingText1.ForeColor = global::System.Drawing.Color.Cyan;
			this.drakeUIScrollingText1.Location = new global::System.Drawing.Point(50, 356);
			this.drakeUIScrollingText1.Name = "drakeUIScrollingText1";
			this.drakeUIScrollingText1.RectColor = global::System.Drawing.Color.FromArgb(0, 9, 46);
			this.drakeUIScrollingText1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.drakeUIScrollingText1.Size = new global::System.Drawing.Size(436, 35);
			this.drakeUIScrollingText1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.drakeUIScrollingText1.TabIndex = 0;
			this.drakeUIScrollingText1.Text = "Eagle Spy V4 by @SystemAdminServer";
			this.pictureBox1.Image = global::Eagle_Spy_Applications.sssss;
			this.pictureBox1.Location = new global::System.Drawing.Point(266, 71);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(236, 251);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Algerian", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Cyan;
			this.label1.Location = new global::System.Drawing.Point(21, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(497, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Best Android Rat All the time";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Algerian", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Cyan;
			this.label2.Location = new global::System.Drawing.Point(44, 108);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(191, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "EagleSpy V4";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Algerian", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Cyan;
			this.label3.Location = new global::System.Drawing.Point(142, 430);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(249, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "t.me/SystemAdminServer";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Algerian", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.Cyan;
			this.label4.Location = new global::System.Drawing.Point(85, 162);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(78, 32);
			this.label4.TabIndex = 5;
			this.label4.Text = "V4.0";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Algerian", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.Cyan;
			this.label5.Location = new global::System.Drawing.Point(35, 222);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(209, 32);
			this.label5.TabIndex = 6;
			this.label5.Text = "@SystemAdminServer";
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(512, -3);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 7;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(9, 1, 46);
			base.ClientSize = new global::System.Drawing.Size(546, 471);
			base.Controls.Add(this.guna2ControlBox1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.drakeUIScrollingText1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "About";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000E75 RID: 3701
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000E76 RID: 3702
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000E77 RID: 3703
		private global::DrakeUI.Framework.DrakeUIScrollingText drakeUIScrollingText1;

		// Token: 0x04000E78 RID: 3704
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000E79 RID: 3705
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000E7A RID: 3706
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000E7B RID: 3707
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000E7C RID: 3708
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000E7D RID: 3709
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000E7E RID: 3710
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
	}
}
