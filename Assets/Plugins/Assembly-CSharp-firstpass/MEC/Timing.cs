using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace MEC
{
	public class Timing : MonoBehaviour
	{
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			public Segment seg;

			public int i;

			public bool Equals(ProcessIndex other)
			{
				return false;
			}

			public override bool Equals(object other)
			{
				return false;
			}

			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return false;
			}

			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_EOFPumpWatcher_003Ed__132 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

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
			public _003C_EOFPumpWatcher_003Ed__132(int _003C_003E1__state)
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
		private sealed class _003C_EOFPump_003Ed__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Timing _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003C_EOFPump_003Ed__133(int _003C_003E1__state)
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
		private sealed class _003C_StartWhenDone_003Ed__275 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public CoroutineHandle handle;

			public IEnumerator<float> proc;

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
			public _003C_StartWhenDone_003Ed__275(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_StartWhenDone_003Ed__280 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public AsyncOperation operation;

			public IEnumerator<float> pausedProc;

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
			public _003C_StartWhenDone_003Ed__280(int _003C_003E1__state)
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
		private sealed class _003C_StartWhenDone_003Ed__282 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public CustomYieldInstruction operation;

			public IEnumerator<float> pausedProc;

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
			public _003C_StartWhenDone_003Ed__282(int _003C_003E1__state)
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
		private sealed class _003C_StartWhenDone_003Ed__287 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Func<bool> evaluatorFunc;

			public bool continueOn;

			public IEnumerator<float> pausedProc;

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
			public _003C_StartWhenDone_003Ed__287(int _003C_003E1__state)
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
		private sealed class _003C_InjectDelay_003Ed__288 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public float waitTime;

			public IEnumerator<float> proc;

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
			public _003C_InjectDelay_003Ed__288(int _003C_003E1__state)
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
		private sealed class _003C_DelayedCall_003Ed__313 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public float delay;

			public GameObject cancelWith;

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
			public _003C_DelayedCall_003Ed__313(int _003C_003E1__state)
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
		private sealed class _003C_WatchCall_003Ed__334 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public float timeframe;

			public CoroutineHandle handle;

			public Action onDone;

			public GameObject gObject;

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
			public _003C_WatchCall_003Ed__334(int _003C_003E1__state)
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
		private sealed class _003C_CallContinuously_003Ed__335 : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public float period;

			public GameObject gObject;

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
			public _003C_CallContinuously_003Ed__335(int _003C_003E1__state)
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
		private sealed class _003C_WatchCall_003Ed__352<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public float timeframe;

			public CoroutineHandle handle;

			public Action<T> onDone;

			public GameObject gObject;

			public T reference;

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
			public _003C_WatchCall_003Ed__352(int _003C_003E1__state)
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
		private sealed class _003C_CallContinuously_003Ed__353<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private float _003C_003E2__current;

			public Timing _003C_003E4__this;

			public float period;

			public GameObject gObject;

			public Action<T> action;

			public T reference;

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
			public _003C_CallContinuously_003Ed__353(int _003C_003E1__state)
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

		[Tooltip("How quickly the SlowUpdate segment ticks.")]
		public float TimeBetweenSlowUpdateCalls;

		[Tooltip("How much data should be sent to the profiler window when it's open.")]
		public DebugInfoType ProfilerDebugAmount;

		[Tooltip("When using manual timeframe, should it run automatically after the update loop or only when TriggerManualTimframeUpdate is called.")]
		public bool AutoTriggerManualTimeframe;

		[Tooltip("A count of the number of Update coroutines that are currently running.")]
		[Space(12f)]
		public int UpdateCoroutines;

		[Tooltip("A count of the number of FixedUpdate coroutines that are currently running.")]
		public int FixedUpdateCoroutines;

		[Tooltip("A count of the number of LateUpdate coroutines that are currently running.")]
		public int LateUpdateCoroutines;

		[Tooltip("A count of the number of SlowUpdate coroutines that are currently running.")]
		public int SlowUpdateCoroutines;

		[Tooltip("A count of the number of RealtimeUpdate coroutines that are currently running.")]
		public int RealtimeUpdateCoroutines;

		[Tooltip("A count of the number of EditorUpdate coroutines that are currently running.")]
		public int EditorUpdateCoroutines;

		[Tooltip("A count of the number of EditorSlowUpdate coroutines that are currently running.")]
		public int EditorSlowUpdateCoroutines;

		[Tooltip("A count of the number of EndOfFrame coroutines that are currently running.")]
		public int EndOfFrameCoroutines;

		[Tooltip("A count of the number of ManualTimeframe coroutines that are currently running.")]
		public int ManualTimeframeCoroutines;

		[NonSerialized]
		public float localTime;

		[NonSerialized]
		public float deltaTime;

		public Func<float, float> SetManualTimeframeTime;

		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		public const float WaitForOneFrame = float.NegativeInfinity;

		private static object _tmpRef;

		private static int _tmpInt;

		private static bool _tmpBool;

		private static Segment _tmpSegment;

		private static CoroutineHandle _tmpHandle;

		private int _currentUpdateFrame;

		private int _currentLateUpdateFrame;

		private int _currentSlowUpdateFrame;

		private int _currentRealtimeUpdateFrame;

		private int _currentEndOfFrameFrame;

		private int _nextUpdateProcessSlot;

		private int _nextLateUpdateProcessSlot;

		private int _nextFixedUpdateProcessSlot;

		private int _nextSlowUpdateProcessSlot;

		private int _nextRealtimeUpdateProcessSlot;

		private int _nextEditorUpdateProcessSlot;

		private int _nextEditorSlowUpdateProcessSlot;

		private int _nextEndOfFrameProcessSlot;

		private int _nextManualTimeframeProcessSlot;

		private int _lastUpdateProcessSlot;

		private int _lastLateUpdateProcessSlot;

		private int _lastFixedUpdateProcessSlot;

		private int _lastSlowUpdateProcessSlot;

		private int _lastRealtimeUpdateProcessSlot;

		private int _lastEndOfFrameProcessSlot;

		private int _lastManualTimeframeProcessSlot;

		private float _lastUpdateTime;

		private float _lastLateUpdateTime;

		private float _lastFixedUpdateTime;

		private float _lastSlowUpdateTime;

		private float _lastRealtimeUpdateTime;

		private float _lastEndOfFrameTime;

		private float _lastManualTimeframeTime;

		private float _lastSlowUpdateDeltaTime;

		private float _lastEditorUpdateDeltaTime;

		private float _lastEditorSlowUpdateDeltaTime;

		private float _lastManualTimeframeDeltaTime;

		private ushort _framesSinceUpdate;

		private ushort _expansions;

		[SerializeField]
		[HideInInspector]
		private byte _instanceID;

		private bool _EOFPumpRan;

		private static readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> Links;

		private static readonly WaitForEndOfFrame EofWaitObject;

		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		private readonly HashSet<CoroutineHandle> _allWaiting;

		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		private readonly Dictionary<CoroutineHandle, string> _processTags;

		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		private readonly Dictionary<CoroutineHandle, int> _processLayers;

		private readonly Dictionary<int, HashSet<CoroutineHandle>> _layeredProcesses;

		private IEnumerator<float>[] UpdateProcesses;

		private IEnumerator<float>[] LateUpdateProcesses;

		private IEnumerator<float>[] FixedUpdateProcesses;

		private IEnumerator<float>[] SlowUpdateProcesses;

		private IEnumerator<float>[] RealtimeUpdateProcesses;

		private IEnumerator<float>[] EditorUpdateProcesses;

		private IEnumerator<float>[] EditorSlowUpdateProcesses;

		private IEnumerator<float>[] EndOfFrameProcesses;

		private IEnumerator<float>[] ManualTimeframeProcesses;

		private bool[] UpdatePaused;

		private bool[] LateUpdatePaused;

		private bool[] FixedUpdatePaused;

		private bool[] SlowUpdatePaused;

		private bool[] RealtimeUpdatePaused;

		private bool[] EditorUpdatePaused;

		private bool[] EditorSlowUpdatePaused;

		private bool[] EndOfFramePaused;

		private bool[] ManualTimeframePaused;

		private bool[] UpdateHeld;

		private bool[] LateUpdateHeld;

		private bool[] FixedUpdateHeld;

		private bool[] SlowUpdateHeld;

		private bool[] RealtimeUpdateHeld;

		private bool[] EditorUpdateHeld;

		private bool[] EditorSlowUpdateHeld;

		private bool[] EndOfFrameHeld;

		private bool[] ManualTimeframeHeld;

		private CoroutineHandle _eofWatcherHandle;

		private const ushort FramesUntilMaintenance = 64;

		private const int ProcessArrayChunkSize = 64;

		private const int InitialBufferSizeLarge = 256;

		private const int InitialBufferSizeMedium = 64;

		private const int InitialBufferSizeSmall = 8;

		private static Timing[] ActiveInstances;

		private static Timing _instance;

		public static float LocalTime => 0f;

		public static float DeltaTime => 0f;

		public static Thread MainThread { get; private set; }

		public static CoroutineHandle CurrentCoroutine => default(CoroutineHandle);

		public CoroutineHandle currentCoroutine { get; private set; }

		public static Timing Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event Action OnPreExecute
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void InitializeInstanceID()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		public void TriggerManualTimeframeUpdate()
		{
		}

		private bool OnEditorStart()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003C_EOFPumpWatcher_003Ed__132))]
		private IEnumerator<float> _EOFPumpWatcher()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_EOFPump_003Ed__133))]
		private IEnumerator _EOFPump()
		{
			return null;
		}

		private void RemoveUnused()
		{
		}

		private void EditorRemoveUnused()
		{
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int layer, bool layerHasValue, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		public static int KillCoroutines()
		{
			return 0;
		}

		public int KillCoroutinesOnInstance()
		{
			return 0;
		}

		public static int KillCoroutines(CoroutineHandle handle)
		{
			return 0;
		}

		public static int KillCoroutines(params CoroutineHandle[] handles)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return 0;
		}

		public static int KillCoroutines(GameObject gameObj)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(GameObject gameObj)
		{
			return 0;
		}

		public static int KillCoroutines(int layer)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(int layer)
		{
			return 0;
		}

		public static int KillCoroutines(string tag)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(string tag)
		{
			return 0;
		}

		public static int KillCoroutines(GameObject gameObj, string tag)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return 0;
		}

		public static int KillCoroutines(int layer, string tag)
		{
			return 0;
		}

		public int KillCoroutinesOnInstance(int layer, string tag)
		{
			return 0;
		}

		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		public static float WaitForSeconds(float waitTime)
		{
			return 0f;
		}

		public float WaitForSecondsOnInstance(float waitTime)
		{
			return 0f;
		}

		private bool UpdateTimeValues(Segment segment)
		{
			return false;
		}

		private float GetSegmentTime(Segment segment)
		{
			return 0f;
		}

		public static int PauseCoroutines()
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance()
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return 0;
		}

		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return 0;
		}

		public static int PauseCoroutines(params CoroutineHandle[] handles)
		{
			return 0;
		}

		public static int PauseCoroutines(GameObject gameObj)
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(GameObject gameObj)
		{
			return 0;
		}

		public static int PauseCoroutines(int layer)
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(int layer)
		{
			return 0;
		}

		public static int PauseCoroutines(string tag)
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(string tag)
		{
			return 0;
		}

		public static int PauseCoroutines(GameObject gameObj, string tag)
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return 0;
		}

		public static int PauseCoroutines(int layer, string tag)
		{
			return 0;
		}

		public int PauseCoroutinesOnInstance(int layer, string tag)
		{
			return 0;
		}

		public static int ResumeCoroutines()
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance()
		{
			return 0;
		}

		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return 0;
		}

		public static int ResumeCoroutines(params CoroutineHandle[] handles)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(IEnumerable<CoroutineHandle> handles)
		{
			return 0;
		}

		public static int ResumeCoroutines(GameObject gameObj)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(GameObject gameObj)
		{
			return 0;
		}

		public static int ResumeCoroutines(int layer)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(int layer)
		{
			return 0;
		}

		public static int ResumeCoroutines(string tag)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(string tag)
		{
			return 0;
		}

		public static int ResumeCoroutines(GameObject gameObj, string tag)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return 0;
		}

		public static int ResumeCoroutines(int layer, string tag)
		{
			return 0;
		}

		public int ResumeCoroutinesOnInstance(int layer, string tag)
		{
			return 0;
		}

		public static string GetTag(CoroutineHandle handle)
		{
			return null;
		}

		public static int? GetLayer(CoroutineHandle handle)
		{
			return null;
		}

		public static string GetDebugName(CoroutineHandle handle)
		{
			return null;
		}

		public static Segment GetSegment(CoroutineHandle handle)
		{
			return default(Segment);
		}

		public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
		{
			return false;
		}

		public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
		{
			return false;
		}

		public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
		{
			return false;
		}

		public static bool RemoveTag(CoroutineHandle handle)
		{
			return false;
		}

		public static bool RemoveLayer(CoroutineHandle handle)
		{
			return false;
		}

		public static bool IsRunning(CoroutineHandle handle)
		{
			return false;
		}

		public static bool IsAliveAndPaused(CoroutineHandle handle)
		{
			return false;
		}

		private void AddTagOnInstance(string tag, CoroutineHandle handle)
		{
		}

		private void AddLayerOnInstance(int layer, CoroutineHandle handle)
		{
		}

		private void RemoveTagOnInstance(CoroutineHandle handle)
		{
		}

		private void RemoveLayerOnInstance(CoroutineHandle handle)
		{
		}

		private void RemoveGraffiti(CoroutineHandle handle)
		{
		}

		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return false;
		}

		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		private bool Nullify(CoroutineHandle handle)
		{
			return false;
		}

		private bool Nullify(ProcessIndex coindex)
		{
			return false;
		}

		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			return false;
		}

		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			return false;
		}

		private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
		{
			return null;
		}

		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return false;
		}

		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return false;
		}

		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine)
		{
			return 0f;
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
		{
			return 0f;
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
		{
			return 0f;
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return 0f;
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
		{
			return 0f;
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return 0f;
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return 0f;
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return 0f;
		}

		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return 0f;
		}

		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return 0f;
		}

		public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
		{
		}

		public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
		{
		}

		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
		}

		[IteratorStateMachine(typeof(_003C_StartWhenDone_003Ed__275))]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return false;
		}

		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static float WaitUntilDone(AsyncOperation operation)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003C_StartWhenDone_003Ed__280))]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003C_StartWhenDone_003Ed__282))]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		public static float WaitUntilTrue(Func<bool> evaluatorFunc)
		{
			return 0f;
		}

		private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static float WaitUntilFalse(Func<bool> evaluatorFunc)
		{
			return 0f;
		}

		private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_StartWhenDone_003Ed__287))]
		private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_InjectDelay_003Ed__288))]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
		{
			return null;
		}

		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return false;
		}

		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return false;
		}

		public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
		{
			return 0;
		}

		public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
		{
			return 0;
		}

		[Obsolete("Use Timing.CurrentCoroutine instead.", false)]
		public static float GetMyHandle(Action<CoroutineHandle> reciever)
		{
			return 0f;
		}

		private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
		{
			return null;
		}

		public static float SwitchCoroutine(Segment newSegment)
		{
			return 0f;
		}

		private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static float SwitchCoroutine(Segment newSegment, string newTag)
		{
			return 0f;
		}

		private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static float SwitchCoroutine(Segment newSegment, int newLayer)
		{
			return 0f;
		}

		private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
		{
			return 0f;
		}

		private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static float SwitchCoroutine(string newTag)
		{
			return 0f;
		}

		private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static float SwitchCoroutine(int newLayer)
		{
			return 0f;
		}

		private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static float SwitchCoroutine(int newLayer, string newTag)
		{
			return 0f;
		}

		private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[IteratorStateMachine(typeof(_003C_DelayedCall_003Ed__313))]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, Action onDone = null)
		{
			return default(CoroutineHandle);
		}

		[IteratorStateMachine(typeof(_003C_WatchCall_003Ed__334))]
		private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_CallContinuously_003Ed__335))]
		private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
		{
			return null;
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null)
		{
			return default(CoroutineHandle);
		}

		[IteratorStateMachine(typeof(_003C_WatchCall_003Ed__352<>))]
		private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003C_CallContinuously_003Ed__353<>))]
		private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(string methodName)
		{
		}

		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopAllCoroutines()
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Obsolete("Just.. no.", true)]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static void print(object message)
		{
		}
	}
}
