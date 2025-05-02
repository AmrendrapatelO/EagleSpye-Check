using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.My
{
	// Token: 0x020000D2 RID: 210
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00005B4C File Offset: 0x00003D4C
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00005B54 File Offset: 0x00003D54
		public object StartupPath { get; internal set; }

		// Token: 0x060009F3 RID: 2547 RVA: 0x00005B5D File Offset: 0x00003D5D
		[STAThread]
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static void Main(string[] Args)
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			MyProject.Application.Run(Args);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x000F5E54 File Offset: 0x000F4054
		public string ExceptionToString(Exception ex)
		{
			string text = "-------------------------------------------------------------------";
			string text2 = "ERROR:\r\n" + text + "\r\n";
			string text3 = ex.Message + "\r\n" + text + "\r\n";
			string text4 = ex.StackTrace + "\r\n" + text + "\r\n";
			string text5 = ex.InnerException.Message + "\r\n" + text + "\r\n";
			string text6 = ex.InnerException.StackTrace + "\r\n" + text + "\r\n";
			string text7 = "";
			int count = ex.Data.Keys.Count;
			checked
			{
				for (int i = 0; i <= count; i++)
				{
					text7 = Conversions.ToString(Operators.ConcatenateObject(text7, Operators.ConcatenateObject(ex.Data[RuntimeHelpers.GetObjectValue(ex.Data.Keys.Cast<object>().ElementAtOrDefault(i))], "\r\n")));
				}
				string text8 = text7 + "\r\n" + text + "\r\n";
				return string.Concat(new string[] { text2, text3, text4, text5, text6, text8 });
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000F5FA4 File Offset: 0x000F41A4
		private void MyApplication_Startup(object sender, StartupEventArgs e)
		{
			try
			{
				if (Directory.Exists(Path.GetTempPath() + "CP"))
				{
					Directory.Delete(Path.GetTempPath() + "CP", true);
				}
			}
			catch (Exception ex)
			{
			}
			try
			{
				if (Directory.Exists(Path.GetTempPath() + "UPATER"))
				{
					Directory.Delete(Path.GetTempPath() + "UPATER", true);
				}
			}
			catch (Exception ex2)
			{
			}
			try
			{
				if (File.Exists(Path.GetTempPath() + "UPATER.zip"))
				{
					File.Delete(Path.GetTempPath() + "UPATER.zip");
				}
			}
			catch (Exception ex3)
			{
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000F608C File Offset: 0x000F428C
		private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
		{
			if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt"))
			{
				File.Create(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt").Dispose();
			}
			string message = e.Exception.Message;
			string source = e.Exception.Source;
			string name = e.Exception.TargetSite.Name;
			string message2 = e.Exception.InnerException.Message;
			string stackTrace = e.Exception.StackTrace;
			string text = this.ExceptionToString(e.Exception);
			File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt", string.Concat(new string[]
			{
				"\r\n",
				message,
				"\r\n                                            \r\n",
				source,
				"\r\n                                              \r\n",
				DateTime.Now.ToString(),
				"\r\n                                               \r\n",
				name,
				"\r\n                                               \r\n",
				stackTrace,
				"\r\n                                               \r\n\r\n                                               \r\n",
				text,
				"\r\n                                               \r\n",
				message2,
				"\r\n----------------End--------------"
			}));
			Interaction.MsgBox("Unhandled Exception \r\n Try Send Error logs to Developer at   :\r\n" + AppDomain.CurrentDomain.BaseDirectory.ToString() + "Errorlogs.txt", MsgBoxStyle.OkOnly, null);
			e.ExitApplication = true;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000F6220 File Offset: 0x000F4420
		[DebuggerStepThrough]
		public MyApplication()
			: base(AuthenticationMode.Windows)
		{
			base.Startup += this.MyApplication_Startup;
			base.UnhandledException += this.MyApplication_UnhandledException;
			base.IsSingleInstance = false;
			base.EnableVisualStyles = true;
			base.SaveMySettingsOnExit = true;
			base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00005B74 File Offset: 0x00003D74
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			base.MainForm = MyProject.Forms.CraxsRatMain;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00005B86 File Offset: 0x00003D86
		[DebuggerStepThrough]
		protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
		{
			base.MinimumSplashScreenDisplayTime = 0;
			return base.OnInitialize(commandLineArgs);
		}
	}
}
