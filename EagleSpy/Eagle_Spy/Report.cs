using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eagle_Spy.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy
{
	// Token: 0x02000094 RID: 148
	[DesignerGenerated]
	public partial class Report : Form
	{
		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x0000495E File Offset: 0x00002B5E
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x000CA7B0 File Offset: 0x000C89B0
		public virtual BackgroundWorker Bgworker
		{
			[CompilerGenerated]
			get
			{
				return this._Bgworker;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DoWorkEventHandler doWorkEventHandler = new DoWorkEventHandler(this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvvwwedsd);
				BackgroundWorker backgroundWorker = this._Bgworker;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork -= doWorkEventHandler;
				}
				this._Bgworker = value;
				backgroundWorker = this._Bgworker;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork += doWorkEventHandler;
				}
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000CA7F4 File Offset: 0x000C89F4
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				if (!base.DesignMode)
				{
					createParams.ExStyle |= 524288;
				}
				return createParams;
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000CA824 File Offset: 0x000C8A24
		public Report()
		{
			base.Load += this.CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvwevswefd;
			base.MouseClick += this.Report_MouseClick;
			base.Closing += this.Report_Closing;
			this.ColorBack = Color.Black;
			this.ColorFont = Color.FromArgb(157, 5, 17);
			this.sizeFontHeight = 5;
			this.sizeFontWidth = 5;
			this.sizeHeightSTOP = 9;
			this.timeOut = 15;
			this.InitializeComponent();
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000CA9B4 File Offset: 0x000C8BB4
		[DebuggerStepThrough]
		private void FadeIn(Form o, int interval = 80)
		{
			Report.VB_0024StateMachine_17_FadeIn vb_0024StateMachine_17_FadeIn = new Report.VB_0024StateMachine_17_FadeIn();
			vb_0024StateMachine_17_FadeIn._0024VB_0024Me = this;
			vb_0024StateMachine_17_FadeIn._0024VB_0024Local_o = o;
			vb_0024StateMachine_17_FadeIn._0024VB_0024Local_interval = interval;
			vb_0024StateMachine_17_FadeIn._0024State = -1;
			vb_0024StateMachine_17_FadeIn._0024Builder = AsyncVoidMethodBuilder.Create();
			vb_0024StateMachine_17_FadeIn._0024Builder.Start<Report.VB_0024StateMachine_17_FadeIn>(ref vb_0024StateMachine_17_FadeIn);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000CA9FC File Offset: 0x000C8BFC
		[DebuggerStepThrough]
		private void FadeOut(Form o, int interval = 80)
		{
			Report.VB_0024StateMachine_18_FadeOut vb_0024StateMachine_18_FadeOut = new Report.VB_0024StateMachine_18_FadeOut();
			vb_0024StateMachine_18_FadeOut._0024VB_0024Me = this;
			vb_0024StateMachine_18_FadeOut._0024VB_0024Local_o = o;
			vb_0024StateMachine_18_FadeOut._0024VB_0024Local_interval = interval;
			vb_0024StateMachine_18_FadeOut._0024State = -1;
			vb_0024StateMachine_18_FadeOut._0024Builder = AsyncVoidMethodBuilder.Create();
			vb_0024StateMachine_18_FadeOut._0024Builder.Start<Report.VB_0024StateMachine_18_FadeOut>(ref vb_0024StateMachine_18_FadeOut);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000CAA44 File Offset: 0x000C8C44
		public void AddItem(Bitmap img, string Text)
		{
			Report._Closure_0024__19_002D0 CS_0024_003C_003E8__locals0 = new Report._Closure_0024__19_002D0();
			CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
			CS_0024_003C_003E8__locals0._0024VB_0024Local_img = img;
			CS_0024_003C_003E8__locals0._0024VB_0024Local_Text = Text;
			Task task = new Task(delegate
			{
				CS_0024_003C_003E8__locals0._Lambda_0024__0();
			});
			task.RunSynchronously();
			task.Wait();
			task.Dispose();
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000CAAAC File Offset: 0x000C8CAC
		private object Add(Bitmap img, string Text)
		{
			object syncNotifications = Data.SyncNotifications;
			ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
			lock (syncNotifications)
			{
				if (this.Items.Count >= 60)
				{
					this.Items.RemoveAt(0);
				}
				try
				{
					Notifications notifications = new Notifications
					{
						FLAG = img,
						TEXT = Text
					};
					this.Items.Add(notifications);
					if ((this.Items.Count > 0) & !this.status)
					{
						this.MyShow();
					}
				}
				catch (InvalidOperationException)
				{
				}
			}
			return null;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000CAB58 File Offset: 0x000C8D58
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvwevswefd(object sender, EventArgs e)
		{
			this.MeHand = base.Handle;
			this.status = false;
			this.Items = new List<Notifications>();
			checked
			{
				int num = ((Operators.CompareString(SpySettings.LOCATION_NOTICETIGHT, "Right", false) != 0) ? 5 : (Screen.PrimaryScreen.WorkingArea.Width - base.Width));
				int num2 = Screen.PrimaryScreen.WorkingArea.Height - base.Height;
				base.Location = new Point(num, num2);
				this.Bgworker = new BackgroundWorker();
				if (!this.Bgworker.IsBusy)
				{
					this.Bgworker.RunWorkerAsync();
				}
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00004966 File Offset: 0x00002B66
		public void MyShow()
		{
			this.status = true;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0000496F File Offset: 0x00002B6F
		public void MyHide()
		{
			this.status = false;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000CABFC File Offset: 0x000C8DFC
		private void CraxsRatkfvuiorkenfudpajrsnCraxsRatsdsvvwwedsd(object sender, DoWorkEventArgs e)
		{
			List<Notifications>.Enumerator enumerator = default(List<Notifications>.Enumerator);
			checked
			{
				for (;;)
				{
					Thread.Sleep(1);
					try
					{
						Thread.Sleep(25);
						if ((this.Items.Count > 0) & this.status)
						{
							try
							{
								object syncNotifications = Data.SyncNotifications;
								ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
								lock (syncNotifications)
								{
									Bitmap bitmap = new Bitmap(base.Width, base.Height);
									Graphics graphics = Graphics.FromImage(bitmap);
									graphics.SmoothingMode = SmoothingMode.AntiAlias;
									graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
									graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
									graphics.CompositingQuality = CompositingQuality.GammaCorrected;
									graphics.CompositingMode = CompositingMode.SourceOver;
									foreach (Notifications notifications in this.Items)
									{
										if (notifications.sizeHeight <= this.sizeHeightSTOP)
										{
											notifications.sizeHeight = this.sizeHeightSTOP;
										}
										else
										{
											int count = this.Items.Count;
											if (count > 60)
											{
												notifications.sizeHeight = this.sizeHeightSTOP;
											}
											else if (count > 20)
											{
												notifications.sizeHeight += -14;
											}
											else if (count > 15)
											{
												notifications.sizeHeight += -8;
											}
											else if (count > 10)
											{
												notifications.sizeHeight += -4;
											}
											else if (count > 5)
											{
												notifications.sizeHeight += -2;
											}
											else
											{
												notifications.sizeHeight += -1;
											}
											if (notifications.sizeHeight <= this.sizeHeightSTOP)
											{
												notifications.sizeHeight = this.sizeHeightSTOP;
											}
										}
										SizeF sizeF = default(SizeF);
										int num = (int)Math.Round((double)(unchecked(graphics.MeasureString(notifications.TEXT, reso.f).Height + (float)this.sizeFontHeight)));
										Rectangle rectangle = new Rectangle(0, notifications.sizeHeight, base.Width, num);
										LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rectangle, this.ColorBack, this.ColorBack, LinearGradientMode.BackwardDiagonal);
										GraphicsPath graphicsPath = this.RoundRect(rectangle, (Operators.CompareString(SpySettings.NOTI_Round, "Yes", false) != 0) ? 1 : 12);
										graphics.FillPath(linearGradientBrush, graphicsPath);
										rectangle = new Rectangle(0, notifications.sizeHeight - this.sizeFontHeight, 0, 0);
										ControlPaint.DrawLockedFrame(graphics, rectangle, false);
										object[] array = new object[2];
										array[0] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(notifications.FLAG.Clone()));
										object[] array2 = array;
										Point point = new Point(base.Width - notifications.FLAG.Width - 7, notifications.sizeHeight + this.sizeFontHeight);
										array2[1] = point;
										NewLateBinding.LateCall(graphics, null, "DrawImage", array2, null, null, null, true);
										using (SolidBrush solidBrush = new SolidBrush(this.ColorFont))
										{
											graphics.DrawString(notifications.TEXT, reso.f, solidBrush, (float)this.sizeFontWidth, (float)(notifications.sizeHeight + this.sizeFontHeight));
										}
										if (notifications.sizeHeight > base.Height - 50)
										{
											break;
										}
									}
									try
									{
										for (;;)
										{
											IL_02FE:
											foreach (Notifications notifications2 in this.Items)
											{
												if (!notifications2.startTime)
												{
													notifications2.start = DateTime.Now.AddSeconds((double)this.timeOut);
													notifications2.startTime = true;
												}
												int num2 = DateTime.Compare(notifications2.start, DateTime.Now);
												if (num2 < 0)
												{
													this.Items.Remove(notifications2);
													goto IL_02FE;
												}
											}
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator).Dispose();
									}
									if ((this.Items.Count == 0) & this.status)
									{
										bitmap = null;
										this.MyHide();
									}
									graphics.Flush(FlushIntention.Sync);
									graphics.Dispose();
									this.UpdateWindow(bitmap);
								}
							}
							catch (Exception)
							{
							}
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000CB070 File Offset: 0x000C9270
		[DebuggerStepThrough]
		private void Report_MouseClick(object sender, MouseEventArgs e)
		{
			Report.VB_0024StateMachine_25_Report_MouseClick vb_0024StateMachine_25_Report_MouseClick = new Report.VB_0024StateMachine_25_Report_MouseClick();
			vb_0024StateMachine_25_Report_MouseClick._0024VB_0024Me = this;
			vb_0024StateMachine_25_Report_MouseClick._0024VB_0024Local_sender = sender;
			vb_0024StateMachine_25_Report_MouseClick._0024VB_0024Local_e = e;
			vb_0024StateMachine_25_Report_MouseClick._0024State = -1;
			vb_0024StateMachine_25_Report_MouseClick._0024Builder = AsyncVoidMethodBuilder.Create();
			vb_0024StateMachine_25_Report_MouseClick._0024Builder.Start<Report.VB_0024StateMachine_25_Report_MouseClick>(ref vb_0024StateMachine_25_Report_MouseClick);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000CB0B8 File Offset: 0x000C92B8
		private object AllClear()
		{
			object syncNotifications = Data.SyncNotifications;
			ObjectFlowControl.CheckForSyncLockOnValueType(syncNotifications);
			lock (syncNotifications)
			{
				this.Items.Clear();
				this.BitmapClean();
				this.MyHide();
			}
			return null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000CB110 File Offset: 0x000C9310
		public GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			checked
			{
				graphicsPath.AddArc(Rectangle.X + Rectangle.Width - Curve, Rectangle.Y, Curve, Curve, 270f, 90f);
				graphicsPath.AddArc(Rectangle.X + Rectangle.Width - Curve, Rectangle.Y + Rectangle.Height - Curve, Curve, Curve, 0f, 90f);
				graphicsPath.AddArc(Rectangle.X, Rectangle.Y + Rectangle.Height - Curve, Curve, Curve, 90f, 90f);
				graphicsPath.AddArc(Rectangle.X, Rectangle.Y, Curve, Curve, 180f, 90f);
				graphicsPath.CloseFigure();
				return graphicsPath;
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x000CB1D4 File Offset: 0x000C93D4
		public void BitmapClean()
		{
			if (!base.IsDisposed && base.Width > 0 && base.Height > 0)
			{
				Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb);
				this.UpdateWindow(bitmap);
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000CB21C File Offset: 0x000C941C
		public void UpdateWindow(Bitmap bm)
		{
			if (base.IsDisposed || base.Width <= 0 || base.Height <= 0)
			{
				return;
			}
			using (Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppPArgb))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					graphics.CompositingQuality = CompositingQuality.GammaCorrected;
					graphics.CompositingMode = CompositingMode.SourceOver;
					if (bm != null)
					{
						graphics.DrawImage(bm, new Rectangle(0, 0, bm.Width, bm.Height));
					}
					IntPtr dc = NativeMethods.GetDC(IntPtr.Zero);
					IntPtr intPtr = NativeMethods.CreateCompatibleDC(dc);
					IntPtr hbitmap = bitmap.GetHbitmap(Color.FromArgb(0));
					IntPtr intPtr2 = NativeMethods.SelectObject(intPtr, hbitmap);
					NativeMethods.BLENDFUNCTION blendfunction = new NativeMethods.BLENDFUNCTION(225);
					Point location = base.Location;
					Size size = bitmap.Size;
					Point empty = Point.Empty;
					NativeMethods.UpdateLayeredWindow(this.MeHand, dc, ref location, ref size, intPtr, ref empty, 0, ref blendfunction, 2);
					NativeMethods.SelectObject(intPtr, intPtr2);
					NativeMethods.DeleteObject(hbitmap);
					NativeMethods.DeleteDC(intPtr);
					NativeMethods.DeleteDC(dc);
				}
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00004978 File Offset: 0x00002B78
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (base.Created)
			{
				this.UpdateWindow(null);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00004990 File Offset: 0x00002B90
		protected override void OnLocationChanged(EventArgs e)
		{
			base.OnLocationChanged(e);
			if (base.Created)
			{
				this.UpdateWindow(null);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000049A8 File Offset: 0x00002BA8
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (base.Visible)
			{
				this.UpdateWindow(null);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000049C0 File Offset: 0x00002BC0
		private void Report_Closing(object sender, CancelEventArgs e)
		{
			if (this.Bgworker != null)
			{
				this.Bgworker.Dispose();
			}
		}

		// Token: 0x04000969 RID: 2409
		public List<Notifications> Items;

		// Token: 0x0400096B RID: 2411
		private IntPtr MeHand;

		// Token: 0x0400096C RID: 2412
		private Color ColorBack;

		// Token: 0x0400096D RID: 2413
		private Color ColorFont;

		// Token: 0x0400096E RID: 2414
		private int sizeFontHeight;

		// Token: 0x0400096F RID: 2415
		private int sizeFontWidth;

		// Token: 0x04000970 RID: 2416
		private int sizeHeightSTOP;

		// Token: 0x04000971 RID: 2417
		private int timeOut;

		// Token: 0x04000972 RID: 2418
		private bool status;

		// Token: 0x02000098 RID: 152
		[CompilerGenerated]
		internal sealed class _Closure_0024__19_002D0
		{
			// Token: 0x06000813 RID: 2067 RVA: 0x000049FA File Offset: 0x00002BFA
			[DebuggerHidden]
			internal void _Lambda_0024__R1()
			{
				this._Lambda_0024__0();
			}

			// Token: 0x06000814 RID: 2068 RVA: 0x00004A03 File Offset: 0x00002C03
			internal object _Lambda_0024__0()
			{
				return this._0024VB_0024Me.Add(this._0024VB_0024Local_img, this._0024VB_0024Local_Text);
			}

			// Token: 0x04000987 RID: 2439
			public Bitmap _0024VB_0024Local_img;

			// Token: 0x04000988 RID: 2440
			public string _0024VB_0024Local_Text;

			// Token: 0x04000989 RID: 2441
			public Report _0024VB_0024Me;
		}
	}
}
