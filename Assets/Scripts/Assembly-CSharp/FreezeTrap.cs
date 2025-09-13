using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Renderer))]
[DisallowMultipleComponent]
public class FreezeTrap : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_TriggerOnPlayer_003Ed__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public FreezeTrap _003C_003E4__this;

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
		public _003C_TriggerOnPlayer_003Ed__9(int _003C_003E1__state)
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

	[SerializeField]
	private Texture texOn;

	[SerializeField]
	private Texture texOff;

	[SerializeField]
	private ParticleSystem frost;

	private bool canActivate;

	private bool activated;

	private bool ignorePlayer;

	private Renderer rend;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003C_TriggerOnPlayer_003Ed__9))]
	private IEnumerator<float> _TriggerOnPlayer()
	{
		return null;
	}

	public void Land()
	{
	}

	public void StepOn(GameObject other)
	{
	}

	private void Activate(bool toActivate)
	{
	}
}
