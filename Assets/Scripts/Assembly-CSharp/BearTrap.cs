using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animation))]
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Collider))]
public class BearTrap : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_Live_003Ed__12 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public BearTrap _003C_003E4__this;

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
		public _003C_Live_003Ed__12(int _003C_003E1__state)
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

	public bool permanent;

	public bool sprung;

	[SerializeField]
	private string openAnim;

	[SerializeField]
	private string liveAnim;

	[SerializeField]
	private Collider coll;

	[SerializeField]
	private AudioSource land;

	private AudioSource audio;

	private Animation anim;

	private float timer;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003C_Live_003Ed__12))]
	private IEnumerator<float> _Live()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Activate()
	{
	}

	public void Disarm()
	{
	}
}
