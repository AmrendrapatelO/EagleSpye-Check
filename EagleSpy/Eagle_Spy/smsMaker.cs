using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x020000A7 RID: 167
	[DesignerGenerated]
	public partial class smsMaker : Form
	{
		// Token: 0x060008CD RID: 2253 RVA: 0x00004EFB File Offset: 0x000030FB
		public smsMaker()
		{
			base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud;
			this.InitializeComponent();
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000034A9 File Offset: 0x000016A9
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00004F1B File Offset: 0x0000311B
		private void DrakeUIButtonIcon1_click(object sender, EventArgs e)
		{
			if (!this.checkall.Checked && this.numslist.Items.Count == 0)
			{
				Interaction.MsgBox("Add Phone Number to list First", MsgBoxStyle.OkOnly, null);
				return;
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00004F57 File Offset: 0x00003157
		private void Phonetext_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Strings.Asc(e.KeyChar) != 8 && ((Strings.Asc(e.KeyChar) < 48) | (Strings.Asc(e.KeyChar) > 57)))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002423 File Offset: 0x00000623
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud(object sender, EventArgs e)
		{
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002423 File Offset: 0x00000623
		private void Checkall_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000DA7C8 File Offset: 0x000D89C8
		private void Addnum_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.phonetext.Text) | string.IsNullOrWhiteSpace(this.phonetext.Text))
			{
				Interaction.MsgBox("Enter Phone Number First", MsgBoxStyle.OkOnly, null);
				return;
			}
			this.numslist.Items.Add(this.phonetext.Text);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000DA824 File Offset: 0x000D8A24
		private void Remnum_Click(object sender, EventArgs e)
		{
			if (this.numslist.Items.Count == 0)
			{
				Interaction.MsgBox("Add Phone Number to list First", MsgBoxStyle.OkOnly, null);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.numslist.SelectedItem, null, "Count", new object[0], null, null, null), 0, false))
			{
				Interaction.MsgBox("select number from list to remove", MsgBoxStyle.OkOnly, null);
				return;
			}
			object obj = null;
			object obj2 = null;
			if (!ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, Operators.SubtractObject(NewLateBinding.LateGet(this.numslist.SelectedItem, null, "Count", new object[0], null, null, null), 1), 1, ref obj2, ref obj))
			{
				return;
			}
			do
			{
				try
				{
					this.numslist.Items.Remove(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(this.numslist.SelectedItem, new object[] { obj }, null)));
				}
				catch (Exception)
				{
				}
			}
			while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000DA924 File Offset: 0x000D8B24
		private void Selectlist_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = "Open a Text File";
			openFileDialog.Filter = "Text Files|*.txt";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			checked
			{
				try
				{
					string fileName = openFileDialog.FileName;
					if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrWhiteSpace(fileName))
					{
						string[] array = File.ReadAllLines(fileName);
						if (array.Length != 0)
						{
							int num = array.Length - 1;
							for (int i = 0; i <= num; i++)
							{
								string text = array[i].Replace(" ", "");
								if (Versioned.IsNumeric(text))
								{
									this.numslist.Items.Add(text);
								}
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x000DA9E8 File Offset: 0x000D8BE8
		private void Checkall_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkall.Checked)
			{
				this.phonetext.Text = "";
				this.phonetext.Enabled = false;
				this.numslist.Items.Clear();
				this.numslist.Enabled = false;
				this.selectlist.Enabled = false;
				this.addnum.Enabled = false;
				this.remnum.Enabled = false;
				return;
			}
			this.phonetext.Text = "";
			this.phonetext.Enabled = true;
			this.numslist.Enabled = true;
			this.selectlist.Enabled = true;
			this.addnum.Enabled = true;
			this.remnum.Enabled = false;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x000034A9 File Offset: 0x000016A9
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}
	}
}
