using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class OverlayManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_BloodScreenFade_003Ed__18 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public OverlayManager _003C_003E4__this;

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
		public _003C_BloodScreenFade_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003C_BloodScreenDeathFade_003Ed__21 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public OverlayManager _003C_003E4__this;

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
		public _003C_BloodScreenDeathFade_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003C_FrostFade_003Ed__26 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public OverlayManager _003C_003E4__this;

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
		public _003C_FrostFade_003Ed__26(int _003C_003E1__state)
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

	public static OverlayManager Instance;

	[SerializeField]
	private GameObject overlays;

	[SerializeField]
	private Image blackScreen;

	[SerializeField]
	private Image bloodScreen;

	[SerializeField]
	private Image bloodScreenDeath;

	[SerializeField]
	private Image frostScreen;

	[SerializeField]
	private GameObject bloodScreenExtra;

	[SerializeField]
	private GameObject spiderBite;

	[SerializeField]
	private GameObject bloodScreenNew;

	private CanvasRenderer blackScreenCR;

	private CanvasRenderer bloodScreenCR;

	private CanvasRenderer bloodScreenDeathCR;

	private CanvasRenderer frostScreenCR;

	private float bloodScreenTimer;

	private float bloodScreenMin;

	private float bloodScreenDeathTimer;

	private void Awake()
	{
	}

	public void HurtBloodScreen()
	{
	}

	[IteratorStateMachine(typeof(_003C_BloodScreenFade_003Ed__18))]
	private IEnumerator<float> _BloodScreenFade()
	{
		return null;
	}

	public void Day4()
	{
	}

	public void DieBloodScreen()
	{
	}

	[IteratorStateMachine(typeof(_003C_BloodScreenDeathFade_003Ed__21))]
	private IEnumerator<float> _BloodScreenDeathFade()
	{
		return null;
	}

	public void FadeBlackScreen(float to, float dur)
	{
	}

	public void AddExtraBlood()
	{
	}

	public void SpiderBite()
	{
	}

	public void Freeze()
	{
	}

	[IteratorStateMachine(typeof(_003C_FrostFade_003Ed__26))]
	private IEnumerator<float> _FrostFade()
	{
		return null;
	}

	public void DisableAllOverlays()
	{
	}

	public void RagdollBlood(bool enable)
	{
	}
}
