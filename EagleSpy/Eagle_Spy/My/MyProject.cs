using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy.My
{
	// Token: 0x020000D4 RID: 212
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[StandardModule]
	internal sealed class MyProject
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00005B9E File Offset: 0x00003D9E
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00005BAA File Offset: 0x00003DAA
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00005BB6 File Offset: 0x00003DB6
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00005BC2 File Offset: 0x00003DC2
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00005BCE File Offset: 0x00003DCE
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000E33 RID: 3635
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000E34 RID: 3636
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000E35 RID: 3637
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000E36 RID: 3638
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000E37 RID: 3639
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x020000D5 RID: 213
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00005C0E File Offset: 0x00003E0E
			// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00005C27 File Offset: 0x00003E27
			public AccountManager AccountManager
			{
				[DebuggerHidden]
				get
				{
					this.m_AccountManager = MyProject.MyForms.Create__Instance__<AccountManager>(this.m_AccountManager);
					return this.m_AccountManager;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AccountManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AccountManager>(ref this.m_AccountManager);
					}
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00005C4C File Offset: 0x00003E4C
			// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00005C65 File Offset: 0x00003E65
			public AddNumber AddNumber
			{
				[DebuggerHidden]
				get
				{
					this.m_AddNumber = MyProject.MyForms.Create__Instance__<AddNumber>(this.m_AddNumber);
					return this.m_AddNumber;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AddNumber)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AddNumber>(ref this.m_AddNumber);
					}
				}
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00005C8A File Offset: 0x00003E8A
			// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00005CA3 File Offset: 0x00003EA3
			public Apk_studio Apk_studio
			{
				[DebuggerHidden]
				get
				{
					this.m_Apk_studio = MyProject.MyForms.Create__Instance__<Apk_studio>(this.m_Apk_studio);
					return this.m_Apk_studio;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Apk_studio)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Apk_studio>(ref this.m_Apk_studio);
					}
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00005CC8 File Offset: 0x00003EC8
			// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00005CE1 File Offset: 0x00003EE1
			public Applications Applications
			{
				[DebuggerHidden]
				get
				{
					this.m_Applications = MyProject.MyForms.Create__Instance__<Applications>(this.m_Applications);
					return this.m_Applications;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Applications)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Applications>(ref this.m_Applications);
					}
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00005D06 File Offset: 0x00003F06
			// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00005D1F File Offset: 0x00003F1F
			public AppsProperties AppsProperties
			{
				[DebuggerHidden]
				get
				{
					this.m_AppsProperties = MyProject.MyForms.Create__Instance__<AppsProperties>(this.m_AppsProperties);
					return this.m_AppsProperties;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AppsProperties)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AppsProperties>(ref this.m_AppsProperties);
					}
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00005D44 File Offset: 0x00003F44
			// (set) Token: 0x06000A0D RID: 2573 RVA: 0x00005D5D File Offset: 0x00003F5D
			public Build Build
			{
				[DebuggerHidden]
				get
				{
					this.m_Build = MyProject.MyForms.Create__Instance__<Build>(this.m_Build);
					return this.m_Build;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Build)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Build>(ref this.m_Build);
					}
				}
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00005D82 File Offset: 0x00003F82
			// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00005D9B File Offset: 0x00003F9B
			public CallPhone CallPhone
			{
				[DebuggerHidden]
				get
				{
					this.m_CallPhone = MyProject.MyForms.Create__Instance__<CallPhone>(this.m_CallPhone);
					return this.m_CallPhone;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CallPhone)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CallPhone>(ref this.m_CallPhone);
					}
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00005DC0 File Offset: 0x00003FC0
			// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00005DD9 File Offset: 0x00003FD9
			public CallsManager CallsManager
			{
				[DebuggerHidden]
				get
				{
					this.m_CallsManager = MyProject.MyForms.Create__Instance__<CallsManager>(this.m_CallsManager);
					return this.m_CallsManager;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CallsManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CallsManager>(ref this.m_CallsManager);
					}
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00005DFE File Offset: 0x00003FFE
			// (set) Token: 0x06000A13 RID: 2579 RVA: 0x00005E17 File Offset: 0x00004017
			public CameraManager CameraManager
			{
				[DebuggerHidden]
				get
				{
					this.m_CameraManager = MyProject.MyForms.Create__Instance__<CameraManager>(this.m_CameraManager);
					return this.m_CameraManager;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CameraManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CameraManager>(ref this.m_CameraManager);
					}
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00005E3C File Offset: 0x0000403C
			// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00005E55 File Offset: 0x00004055
			public ClipboardManager ClipboardManager
			{
				[DebuggerHidden]
				get
				{
					this.m_ClipboardManager = MyProject.MyForms.Create__Instance__<ClipboardManager>(this.m_ClipboardManager);
					return this.m_ClipboardManager;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ClipboardManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ClipboardManager>(ref this.m_ClipboardManager);
					}
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00005E7A File Offset: 0x0000407A
			// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00005E93 File Offset: 0x00004093
			public Color_Box0 Color_Box0
			{
				[DebuggerHidden]
				get
				{
					this.m_Color_Box0 = MyProject.MyForms.Create__Instance__<Color_Box0>(this.m_Color_Box0);
					return this.m_Color_Box0;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Color_Box0)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Color_Box0>(ref this.m_Color_Box0);
					}
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00005EB8 File Offset: 0x000040B8
			// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00005ED1 File Offset: 0x000040D1
			public comptableform comptableform
			{
				[DebuggerHidden]
				get
				{
					this.m_comptableform = MyProject.MyForms.Create__Instance__<comptableform>(this.m_comptableform);
					return this.m_comptableform;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_comptableform)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<comptableform>(ref this.m_comptableform);
					}
				}
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00005EF6 File Offset: 0x000040F6
			// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00005F0F File Offset: 0x0000410F
			public ContactsManager ContactsManager
			{
				[DebuggerHidden]
				get
				{
					this.m_ContactsManager = MyProject.MyForms.Create__Instance__<ContactsManager>(this.m_ContactsManager);
					return this.m_ContactsManager;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ContactsManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ContactsManager>(ref this.m_ContactsManager);
					}
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00005F34 File Offset: 0x00004134
			// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00005F4D File Offset: 0x0000414D
			public EagleSpyCallLogs craxscallslog
			{
				[DebuggerHidden]
				get
				{
					this.m_craxscallslog = MyProject.MyForms.Create__Instance__<EagleSpyCallLogs>(this.m_craxscallslog);
					return this.m_craxscallslog;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_craxscallslog)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EagleSpyCallLogs>(ref this.m_craxscallslog);
					}
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00005F72 File Offset: 0x00004172
			// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00005F8B File Offset: 0x0000418B
			public Eaglepopup Craxspopup
			{
				[DebuggerHidden]
				get
				{
					this.m_Craxspopup = MyProject.MyForms.Create__Instance__<Eaglepopup>(this.m_Craxspopup);
					return this.m_Craxspopup;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Craxspopup)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Eaglepopup>(ref this.m_Craxspopup);
					}
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00005FB0 File Offset: 0x000041B0
			// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00005FC9 File Offset: 0x000041C9
			public EagleSpyMain CraxsRatMain
			{
				[DebuggerHidden]
				get
				{
					this.m_CraxsRatMain = MyProject.MyForms.Create__Instance__<EagleSpyMain>(this.m_CraxsRatMain);
					return this.m_CraxsRatMain;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CraxsRatMain)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EagleSpyMain>(ref this.m_CraxsRatMain);
					}
				}
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00005FEE File Offset: 0x000041EE
			// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00006007 File Offset: 0x00004207
			public Dialog1 Dialog1
			{
				[DebuggerHidden]
				get
				{
					this.m_Dialog1 = MyProject.MyForms.Create__Instance__<Dialog1>(this.m_Dialog1);
					return this.m_Dialog1;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Dialog1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Dialog1>(ref this.m_Dialog1);
					}
				}
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0000602C File Offset: 0x0000422C
			// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00006045 File Offset: 0x00004245
			public Dialog2 Dialog2
			{
				[DebuggerHidden]
				get
				{
					this.m_Dialog2 = MyProject.MyForms.Create__Instance__<Dialog2>(this.m_Dialog2);
					return this.m_Dialog2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Dialog2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Dialog2>(ref this.m_Dialog2);
					}
				}
			}

			// Token: 0x17000196 RID: 406
			// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0000606A File Offset: 0x0000426A
			// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00006083 File Offset: 0x00004283
			public DialogPloice DialogPloice
			{
				[DebuggerHidden]
				get
				{
					this.m_DialogPloice = MyProject.MyForms.Create__Instance__<DialogPloice>(this.m_DialogPloice);
					return this.m_DialogPloice;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_DialogPloice)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DialogPloice>(ref this.m_DialogPloice);
					}
				}
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000060A8 File Offset: 0x000042A8
			// (set) Token: 0x06000A29 RID: 2601 RVA: 0x000060C1 File Offset: 0x000042C1
			public Download Download
			{
				[DebuggerHidden]
				get
				{
					this.m_Download = MyProject.MyForms.Create__Instance__<Download>(this.m_Download);
					return this.m_Download;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Download)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Download>(ref this.m_Download);
					}
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000060E6 File Offset: 0x000042E6
			// (set) Token: 0x06000A2B RID: 2603 RVA: 0x000060FF File Offset: 0x000042FF
			public Drooper Drooper
			{
				[DebuggerHidden]
				get
				{
					this.m_Drooper = MyProject.MyForms.Create__Instance__<Drooper>(this.m_Drooper);
					return this.m_Drooper;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Drooper)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Drooper>(ref this.m_Drooper);
					}
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00006124 File Offset: 0x00004324
			// (set) Token: 0x06000A2D RID: 2605 RVA: 0x0000613D File Offset: 0x0000433D
			public Editor Editor
			{
				[DebuggerHidden]
				get
				{
					this.m_Editor = MyProject.MyForms.Create__Instance__<Editor>(this.m_Editor);
					return this.m_Editor;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Editor)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Editor>(ref this.m_Editor);
					}
				}
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00006162 File Offset: 0x00004362
			// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0000617B File Offset: 0x0000437B
			public EditSocket EditSocket
			{
				[DebuggerHidden]
				get
				{
					this.m_EditSocket = MyProject.MyForms.Create__Instance__<EditSocket>(this.m_EditSocket);
					return this.m_EditSocket;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EditSocket)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EditSocket>(ref this.m_EditSocket);
					}
				}
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x06000A30 RID: 2608 RVA: 0x000061A0 File Offset: 0x000043A0
			// (set) Token: 0x06000A31 RID: 2609 RVA: 0x000061B9 File Offset: 0x000043B9
			public FileManager FileManager
			{
				[DebuggerHidden]
				get
				{
					this.m_FileManager = MyProject.MyForms.Create__Instance__<FileManager>(this.m_FileManager);
					return this.m_FileManager;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FileManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FileManager>(ref this.m_FileManager);
					}
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000A32 RID: 2610 RVA: 0x000061DE File Offset: 0x000043DE
			// (set) Token: 0x06000A33 RID: 2611 RVA: 0x000061F7 File Offset: 0x000043F7
			public Icons Icons
			{
				[DebuggerHidden]
				get
				{
					this.m_Icons = MyProject.MyForms.Create__Instance__<Icons>(this.m_Icons);
					return this.m_Icons;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Icons)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Icons>(ref this.m_Icons);
					}
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0000621C File Offset: 0x0000441C
			// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00006235 File Offset: 0x00004435
			public information information
			{
				[DebuggerHidden]
				get
				{
					this.m_information = MyProject.MyForms.Create__Instance__<information>(this.m_information);
					return this.m_information;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_information)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<information>(ref this.m_information);
					}
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0000625A File Offset: 0x0000445A
			// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00006273 File Offset: 0x00004473
			public inp inp
			{
				[DebuggerHidden]
				get
				{
					this.m_inp = MyProject.MyForms.Create__Instance__<inp>(this.m_inp);
					return this.m_inp;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_inp)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<inp>(ref this.m_inp);
					}
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00006298 File Offset: 0x00004498
			// (set) Token: 0x06000A39 RID: 2617 RVA: 0x000062B1 File Offset: 0x000044B1
			public Jector Jector
			{
				[DebuggerHidden]
				get
				{
					this.m_Jector = MyProject.MyForms.Create__Instance__<Jector>(this.m_Jector);
					return this.m_Jector;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Jector)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Jector>(ref this.m_Jector);
					}
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000062D6 File Offset: 0x000044D6
			// (set) Token: 0x06000A3B RID: 2619 RVA: 0x000062EF File Offset: 0x000044EF
			public Keylogger Keylogger
			{
				[DebuggerHidden]
				get
				{
					this.m_Keylogger = MyProject.MyForms.Create__Instance__<Keylogger>(this.m_Keylogger);
					return this.m_Keylogger;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Keylogger)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Keylogger>(ref this.m_Keylogger);
					}
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00006314 File Offset: 0x00004514
			// (set) Token: 0x06000A3D RID: 2621 RVA: 0x0000632D File Offset: 0x0000452D
			public LanguageSelector LanguageSelector
			{
				[DebuggerHidden]
				get
				{
					this.m_LanguageSelector = MyProject.MyForms.Create__Instance__<LanguageSelector>(this.m_LanguageSelector);
					return this.m_LanguageSelector;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_LanguageSelector)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<LanguageSelector>(ref this.m_LanguageSelector);
					}
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00006352 File Offset: 0x00004552
			// (set) Token: 0x06000A3F RID: 2623 RVA: 0x0000636B File Offset: 0x0000456B
			public LocationManager LocationManager
			{
				[DebuggerHidden]
				get
				{
					this.m_LocationManager = MyProject.MyForms.Create__Instance__<LocationManager>(this.m_LocationManager);
					return this.m_LocationManager;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_LocationManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<LocationManager>(ref this.m_LocationManager);
					}
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00006390 File Offset: 0x00004590
			// (set) Token: 0x06000A41 RID: 2625 RVA: 0x000063A9 File Offset: 0x000045A9
			public Microphone Microphone
			{
				[DebuggerHidden]
				get
				{
					this.m_Microphone = MyProject.MyForms.Create__Instance__<Microphone>(this.m_Microphone);
					return this.m_Microphone;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Microphone)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Microphone>(ref this.m_Microphone);
					}
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x06000A42 RID: 2626 RVA: 0x000063CE File Offset: 0x000045CE
			// (set) Token: 0x06000A43 RID: 2627 RVA: 0x000063E7 File Offset: 0x000045E7
			public nonetform nonetform
			{
				[DebuggerHidden]
				get
				{
					this.m_nonetform = MyProject.MyForms.Create__Instance__<nonetform>(this.m_nonetform);
					return this.m_nonetform;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_nonetform)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<nonetform>(ref this.m_nonetform);
					}
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0000640C File Offset: 0x0000460C
			// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00006425 File Offset: 0x00004625
			public PermissionsManager PermissionsManager
			{
				[DebuggerHidden]
				get
				{
					this.m_PermissionsManager = MyProject.MyForms.Create__Instance__<PermissionsManager>(this.m_PermissionsManager);
					return this.m_PermissionsManager;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PermissionsManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PermissionsManager>(ref this.m_PermissionsManager);
					}
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0000644A File Offset: 0x0000464A
			// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00006463 File Offset: 0x00004663
			public Ports Ports
			{
				[DebuggerHidden]
				get
				{
					this.m_Ports = MyProject.MyForms.Create__Instance__<Ports>(this.m_Ports);
					return this.m_Ports;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Ports)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Ports>(ref this.m_Ports);
					}
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00006488 File Offset: 0x00004688
			// (set) Token: 0x06000A49 RID: 2633 RVA: 0x000064A1 File Offset: 0x000046A1
			public Report Report
			{
				[DebuggerHidden]
				get
				{
					this.m_Report = MyProject.MyForms.Create__Instance__<Report>(this.m_Report);
					return this.m_Report;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Report)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Report>(ref this.m_Report);
					}
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06000A4A RID: 2634 RVA: 0x000064C6 File Offset: 0x000046C6
			// (set) Token: 0x06000A4B RID: 2635 RVA: 0x000064DF File Offset: 0x000046DF
			public ScreenLoger ScreenLoger
			{
				[DebuggerHidden]
				get
				{
					this.m_ScreenLoger = MyProject.MyForms.Create__Instance__<ScreenLoger>(this.m_ScreenLoger);
					return this.m_ScreenLoger;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ScreenLoger)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ScreenLoger>(ref this.m_ScreenLoger);
					}
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00006504 File Offset: 0x00004704
			// (set) Token: 0x06000A4D RID: 2637 RVA: 0x0000651D File Offset: 0x0000471D
			public ScreenReader ScreenReader
			{
				[DebuggerHidden]
				get
				{
					this.m_ScreenReader = MyProject.MyForms.Create__Instance__<ScreenReader>(this.m_ScreenReader);
					return this.m_ScreenReader;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ScreenReader)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ScreenReader>(ref this.m_ScreenReader);
					}
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00006542 File Offset: 0x00004742
			// (set) Token: 0x06000A4F RID: 2639 RVA: 0x0000655B File Offset: 0x0000475B
			public ScreenReaderV2 ScreenReaderV2
			{
				[DebuggerHidden]
				get
				{
					this.m_ScreenReaderV2 = MyProject.MyForms.Create__Instance__<ScreenReaderV2>(this.m_ScreenReaderV2);
					return this.m_ScreenReaderV2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ScreenReaderV2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ScreenReaderV2>(ref this.m_ScreenReaderV2);
					}
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00006580 File Offset: 0x00004780
			// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00006599 File Offset: 0x00004799
			public Button5 ScreenShoter
			{
				[DebuggerHidden]
				get
				{
					this.m_ScreenShoter = MyProject.MyForms.Create__Instance__<Button5>(this.m_ScreenShoter);
					return this.m_ScreenShoter;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ScreenShoter)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Button5>(ref this.m_ScreenShoter);
					}
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000065BE File Offset: 0x000047BE
			// (set) Token: 0x06000A53 RID: 2643 RVA: 0x000065D7 File Offset: 0x000047D7
			public SelfRemove SelfRemove
			{
				[DebuggerHidden]
				get
				{
					this.m_SelfRemove = MyProject.MyForms.Create__Instance__<SelfRemove>(this.m_SelfRemove);
					return this.m_SelfRemove;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SelfRemove)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SelfRemove>(ref this.m_SelfRemove);
					}
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x06000A54 RID: 2644 RVA: 0x000065FC File Offset: 0x000047FC
			// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00006615 File Offset: 0x00004815
			public Settings Settings
			{
				[DebuggerHidden]
				get
				{
					this.m_Settings = MyProject.MyForms.Create__Instance__<Settings>(this.m_Settings);
					return this.m_Settings;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Settings)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Settings>(ref this.m_Settings);
					}
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0000663A File Offset: 0x0000483A
			// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00006653 File Offset: 0x00004853
			public ShellTerminal ShellTerminal
			{
				[DebuggerHidden]
				get
				{
					this.m_ShellTerminal = MyProject.MyForms.Create__Instance__<ShellTerminal>(this.m_ShellTerminal);
					return this.m_ShellTerminal;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ShellTerminal)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ShellTerminal>(ref this.m_ShellTerminal);
					}
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00006678 File Offset: 0x00004878
			// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00006691 File Offset: 0x00004891
			public smsMaker smsMaker
			{
				[DebuggerHidden]
				get
				{
					this.m_smsMaker = MyProject.MyForms.Create__Instance__<smsMaker>(this.m_smsMaker);
					return this.m_smsMaker;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_smsMaker)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<smsMaker>(ref this.m_smsMaker);
					}
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x06000A5A RID: 2650 RVA: 0x000066B6 File Offset: 0x000048B6
			// (set) Token: 0x06000A5B RID: 2651 RVA: 0x000066CF File Offset: 0x000048CF
			public SMSManager SMSManager
			{
				[DebuggerHidden]
				get
				{
					this.m_SMSManager = MyProject.MyForms.Create__Instance__<SMSManager>(this.m_SMSManager);
					return this.m_SMSManager;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SMSManager)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SMSManager>(ref this.m_SMSManager);
					}
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x06000A5C RID: 2652 RVA: 0x000066F4 File Offset: 0x000048F4
			// (set) Token: 0x06000A5D RID: 2653 RVA: 0x0000670D File Offset: 0x0000490D
			public snapsdownloader snapsdownloader
			{
				[DebuggerHidden]
				get
				{
					this.m_snapsdownloader = MyProject.MyForms.Create__Instance__<snapsdownloader>(this.m_snapsdownloader);
					return this.m_snapsdownloader;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_snapsdownloader)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<snapsdownloader>(ref this.m_snapsdownloader);
					}
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00006732 File Offset: 0x00004932
			// (set) Token: 0x06000A5F RID: 2655 RVA: 0x0000674B File Offset: 0x0000494B
			public Upload Upload
			{
				[DebuggerHidden]
				get
				{
					this.m_Upload = MyProject.MyForms.Create__Instance__<Upload>(this.m_Upload);
					return this.m_Upload;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Upload)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Upload>(ref this.m_Upload);
					}
				}
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00006770 File Offset: 0x00004970
			// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00006789 File Offset: 0x00004989
			public WebViewMonitor WebViewMonitor
			{
				[DebuggerHidden]
				get
				{
					this.m_WebViewMonitor = MyProject.MyForms.Create__Instance__<WebViewMonitor>(this.m_WebViewMonitor);
					return this.m_WebViewMonitor;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_WebViewMonitor)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<WebViewMonitor>(ref this.m_WebViewMonitor);
					}
				}
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x06000A62 RID: 2658 RVA: 0x000067AE File Offset: 0x000049AE
			// (set) Token: 0x06000A63 RID: 2659 RVA: 0x000067C7 File Offset: 0x000049C7
			public Win_Users Win_Users
			{
				[DebuggerHidden]
				get
				{
					this.m_Win_Users = MyProject.MyForms.Create__Instance__<Win_Users>(this.m_Win_Users);
					return this.m_Win_Users;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Win_Users)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Win_Users>(ref this.m_Win_Users);
					}
				}
			}

			// Token: 0x06000A64 RID: 2660 RVA: 0x000F6274 File Offset: 0x000F4474
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance != null && !Instance.IsDisposed)
				{
					return Instance;
				}
				if (MyProject.MyForms.m_FormBeingCreated != null)
				{
					if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", Array.Empty<string>()));
					}
				}
				else
				{
					MyProject.MyForms.m_FormBeingCreated = new Hashtable();
				}
				MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
				TargetInvocationException ex = null;
				T t;
				object obj;
				TargetInvocationException ex4;
				bool flag;
				TargetInvocationException ex3;
				try
				{
					t = new T();
				}
				catch when (delegate
				{
					// Failed to create a 'catch-when' expression
					ex4 = obj as TargetInvocationException;
					if (ex4 == null)
					{
						flag = false;
					}
					else
					{
						ex3 = ex4;
						TargetInvocationException ex2 = ex3;
						flag = delegate
						{
							ex = ex2;
							return delegate
							{
								ProjectData.SetProjectError(ex);
								return ex.InnerException != null;
							}();
						}() > false;
					}
					endfilter(flag);
				})
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[] { CS$<>8__locals2.CS$<>8__locals1.ex.InnerException.Message });
					throw new InvalidOperationException(resourceString, CS$<>8__locals2.CS$<>8__locals1.ex.InnerException);
				}
				finally
				{
					MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
				}
				return t;
			}

			// Token: 0x06000A65 RID: 2661 RVA: 0x000067EC File Offset: 0x000049EC
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000A66 RID: 2662 RVA: 0x0000207B File Offset: 0x0000027B
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyForms()
			{
			}

			// Token: 0x06000A67 RID: 2663 RVA: 0x00006801 File Offset: 0x00004A01
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000A68 RID: 2664 RVA: 0x0000680F File Offset: 0x00004A0F
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000A69 RID: 2665 RVA: 0x00006817 File Offset: 0x00004A17
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000A6A RID: 2666 RVA: 0x00006823 File Offset: 0x00004A23
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000E38 RID: 3640
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x04000E39 RID: 3641
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AccountManager m_AccountManager;

			// Token: 0x04000E3A RID: 3642
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddNumber m_AddNumber;

			// Token: 0x04000E3B RID: 3643
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Apk_studio m_Apk_studio;

			// Token: 0x04000E3C RID: 3644
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Applications m_Applications;

			// Token: 0x04000E3D RID: 3645
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AppsProperties m_AppsProperties;

			// Token: 0x04000E3E RID: 3646
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Build m_Build;

			// Token: 0x04000E3F RID: 3647
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CallPhone m_CallPhone;

			// Token: 0x04000E40 RID: 3648
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CallsManager m_CallsManager;

			// Token: 0x04000E41 RID: 3649
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CameraManager m_CameraManager;

			// Token: 0x04000E42 RID: 3650
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ClipboardManager m_ClipboardManager;

			// Token: 0x04000E43 RID: 3651
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Color_Box0 m_Color_Box0;

			// Token: 0x04000E44 RID: 3652
			[EditorBrowsable(EditorBrowsableState.Never)]
			public comptableform m_comptableform;

			// Token: 0x04000E45 RID: 3653
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ContactsManager m_ContactsManager;

			// Token: 0x04000E46 RID: 3654
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EagleSpyCallLogs m_craxscallslog;

			// Token: 0x04000E47 RID: 3655
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Eaglepopup m_Craxspopup;

			// Token: 0x04000E48 RID: 3656
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EagleSpyMain m_CraxsRatMain;

			// Token: 0x04000E49 RID: 3657
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Dialog1 m_Dialog1;

			// Token: 0x04000E4A RID: 3658
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Dialog2 m_Dialog2;

			// Token: 0x04000E4B RID: 3659
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DialogPloice m_DialogPloice;

			// Token: 0x04000E4C RID: 3660
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Download m_Download;

			// Token: 0x04000E4D RID: 3661
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Drooper m_Drooper;

			// Token: 0x04000E4E RID: 3662
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Editor m_Editor;

			// Token: 0x04000E4F RID: 3663
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditSocket m_EditSocket;

			// Token: 0x04000E50 RID: 3664
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FileManager m_FileManager;

			// Token: 0x04000E51 RID: 3665
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Icons m_Icons;

			// Token: 0x04000E52 RID: 3666
			[EditorBrowsable(EditorBrowsableState.Never)]
			public information m_information;

			// Token: 0x04000E53 RID: 3667
			[EditorBrowsable(EditorBrowsableState.Never)]
			public inp m_inp;

			// Token: 0x04000E54 RID: 3668
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Jector m_Jector;

			// Token: 0x04000E55 RID: 3669
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Keylogger m_Keylogger;

			// Token: 0x04000E56 RID: 3670
			[EditorBrowsable(EditorBrowsableState.Never)]
			public LanguageSelector m_LanguageSelector;

			// Token: 0x04000E57 RID: 3671
			[EditorBrowsable(EditorBrowsableState.Never)]
			public LocationManager m_LocationManager;

			// Token: 0x04000E58 RID: 3672
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Microphone m_Microphone;

			// Token: 0x04000E59 RID: 3673
			[EditorBrowsable(EditorBrowsableState.Never)]
			public nonetform m_nonetform;

			// Token: 0x04000E5A RID: 3674
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PermissionsManager m_PermissionsManager;

			// Token: 0x04000E5B RID: 3675
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Ports m_Ports;

			// Token: 0x04000E5C RID: 3676
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Report m_Report;

			// Token: 0x04000E5D RID: 3677
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScreenLoger m_ScreenLoger;

			// Token: 0x04000E5E RID: 3678
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScreenReader m_ScreenReader;

			// Token: 0x04000E5F RID: 3679
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ScreenReaderV2 m_ScreenReaderV2;

			// Token: 0x04000E60 RID: 3680
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Button5 m_ScreenShoter;

			// Token: 0x04000E61 RID: 3681
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelfRemove m_SelfRemove;

			// Token: 0x04000E62 RID: 3682
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Settings m_Settings;

			// Token: 0x04000E63 RID: 3683
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ShellTerminal m_ShellTerminal;

			// Token: 0x04000E64 RID: 3684
			[EditorBrowsable(EditorBrowsableState.Never)]
			public smsMaker m_smsMaker;

			// Token: 0x04000E65 RID: 3685
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SMSManager m_SMSManager;

			// Token: 0x04000E66 RID: 3686
			[EditorBrowsable(EditorBrowsableState.Never)]
			public snapsdownloader m_snapsdownloader;

			// Token: 0x04000E67 RID: 3687
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Upload m_Upload;

			// Token: 0x04000E68 RID: 3688
			[EditorBrowsable(EditorBrowsableState.Never)]
			public WebViewMonitor m_WebViewMonitor;

			// Token: 0x04000E69 RID: 3689
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Win_Users m_Win_Users;
		}

		// Token: 0x020000D8 RID: 216
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyWebServices
		{
			// Token: 0x06000A6F RID: 2671 RVA: 0x00006801 File Offset: 0x00004A01
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000A70 RID: 2672 RVA: 0x0000680F File Offset: 0x00004A0F
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000A71 RID: 2673 RVA: 0x0000686F File Offset: 0x00004A6F
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x06000A72 RID: 2674 RVA: 0x00006823 File Offset: 0x00004A23
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x06000A73 RID: 2675 RVA: 0x0000687B File Offset: 0x00004A7B
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return new T();
				}
				return instance;
			}

			// Token: 0x06000A74 RID: 2676 RVA: 0x0000688C File Offset: 0x00004A8C
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000A75 RID: 2677 RVA: 0x0000207B File Offset: 0x0000027B
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyWebServices()
			{
			}
		}

		// Token: 0x020000D9 RID: 217
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00006895 File Offset: 0x00004A95
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000A77 RID: 2679 RVA: 0x0000207B File Offset: 0x0000027B
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x04000E6D RID: 3693
			[ThreadStatic]
			[CompilerGenerated]
			private static T m_ThreadStaticValue;
		}
	}
}
