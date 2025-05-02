using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Eagle_Spy
{
	// Token: 0x0200009D RID: 157
	public class RTB : RichTextBox
	{
		// Token: 0x06000841 RID: 2113 RVA: 0x00004AE9 File Offset: 0x00002CE9
		public RTB()
		{
			base.SetStyle(ControlStyles.EnableNotifyMessage, true);
			RTB.HideCaret(base.Handle);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00004B09 File Offset: 0x00002D09
		protected override void WndProc(ref Message m)
		{
			if (m.Msg != 522 || !this.ctrlPressed)
			{
				base.WndProc(ref m);
			}
			RTB.HideCaret(base.Handle);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00004B33 File Offset: 0x00002D33
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control)
			{
				this.ctrlPressed = true;
			}
			base.OnKeyDown(e);
			RTB.HideCaret(base.Handle);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00004B5C File Offset: 0x00002D5C
		protected override void OnKeyUp(KeyEventArgs e)
		{
			this.ctrlPressed = false;
			base.OnKeyUp(e);
			RTB.HideCaret(base.Handle);
		}

		// Token: 0x06000845 RID: 2117
		[DllImport("user32.dll")]
		public static extern bool HideCaret(IntPtr hwnd);

		// Token: 0x040009A8 RID: 2472
		private bool ctrlPressed;

		// Token: 0x040009A9 RID: 2473
		private const int WM_MOUSEWHEEL = 522;
	}
}
