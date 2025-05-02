using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Eagle_Spy
{
	// Token: 0x02000020 RID: 32
	public class AsyncLock
	{
		// Token: 0x06000223 RID: 547 RVA: 0x0000276B File Offset: 0x0000096B
		public AsyncLock()
		{
			this.m_semaphore = new SemaphoreSlim(1, 1);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00013C40 File Offset: 0x00011E40
		[DebuggerStepThrough]
		public Task<IDisposable> LockAsync()
		{
			AsyncLock.VB_0024StateMachine_2_LockAsync vb_0024StateMachine_2_LockAsync = new AsyncLock.VB_0024StateMachine_2_LockAsync();
			vb_0024StateMachine_2_LockAsync._0024VB_0024Me = this;
			vb_0024StateMachine_2_LockAsync._0024State = -1;
			vb_0024StateMachine_2_LockAsync._0024Builder = AsyncTaskMethodBuilder<IDisposable>.Create();
			vb_0024StateMachine_2_LockAsync._0024Builder.Start<AsyncLock.VB_0024StateMachine_2_LockAsync>(ref vb_0024StateMachine_2_LockAsync);
			return vb_0024StateMachine_2_LockAsync._0024Builder.Task;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002780 File Offset: 0x00000980
		public void Release()
		{
			this.m_semaphore.Release();
		}

		// Token: 0x040000C7 RID: 199
		private SemaphoreSlim m_semaphore;

		// Token: 0x02000021 RID: 33
		private class Releaser : IDisposable
		{
			// Token: 0x06000226 RID: 550 RVA: 0x0000278E File Offset: 0x0000098E
			public Releaser(AsyncLock @lock)
			{
				this.m_lock = @lock;
			}

			// Token: 0x06000227 RID: 551 RVA: 0x0000279D File Offset: 0x0000099D
			public void Dispose()
			{
				if (this.m_lock != null)
				{
					this.m_lock.Release();
					this.m_lock = null;
				}
			}

			// Token: 0x06000228 RID: 552 RVA: 0x000027B9 File Offset: 0x000009B9
			void IDisposable.Dispose()
			{
				this.Dispose();
			}

			// Token: 0x040000C8 RID: 200
			private AsyncLock m_lock;
		}
	}
}
