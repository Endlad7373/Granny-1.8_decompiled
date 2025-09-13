using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MEC
{
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		[CompilerGenerated]
		private sealed class _003C_OnDestroy_003Ed__32 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public CoroutineHandle watched;

			public Action action;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003C_OnDestroy_003Ed__32(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_OnDestroy_003Ed__33 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public CoroutineHandle watched;

			public IEnumerator<float> action;

			float IEnumerator<float>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0f;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003C_OnDestroy_003Ed__33(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const byte ReservedSpace = 15;

		private static readonly int[] NextIndex;

		private readonly int _id;

		public byte Key => 0;

		public string Tag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int? Layer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Segment Segment
		{
			get
			{
				return default(Segment);
			}
			set
			{
			}
		}

		public bool IsRunning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsAliveAndPaused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsValid => false;

		public CoroutineHandle(byte ind)
		{
			_id = 0;
		}

		public CoroutineHandle(CoroutineHandle other)
		{
			_id = 0;
		}

		public bool Equals(CoroutineHandle other)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return false;
		}

		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public CoroutineHandle OnDestroy(Action action, Segment segment = Segment.Update)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle OnDestroy(IEnumerator<float> action, Segment segment = Segment.Update)
		{
			return default(CoroutineHandle);
		}

		[IteratorStateMachine(typeof(_003C_OnDestroy_003Ed__32))]
		private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, Action action)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_OnDestroy_003Ed__33))]
		private static IEnumerator<float> _OnDestroy(CoroutineHandle watched, IEnumerator<float> action)
		{
			return null;
		}
	}
}
