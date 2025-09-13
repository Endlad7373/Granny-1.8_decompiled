using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class Bird : MonoBehaviour
{
	private enum State
	{
		Cage = 0,
		Eating = 1,
		Dodge = 2,
		Dead = 3
	}

	[CompilerGenerated]
	private sealed class _003C_Attack_003Ed__23 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Bird _003C_003E4__this;

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
		public _003C_Attack_003Ed__23(int _003C_003E1__state)
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
	private sealed class _003C_Eat_003Ed__31 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Bird _003C_003E4__this;

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
		public _003C_Eat_003Ed__31(int _003C_003E1__state)
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

	private State state;

	[SerializeField]
	private Animation anim;

	[SerializeField]
	private Vector3 eatPos;

	[SerializeField]
	private Vector3 alertPos;

	[SerializeField]
	private SingleUseDoor cageDoor;

	[SerializeField]
	private AudioClip attackSound;

	[SerializeField]
	private AudioClip eatSound;

	[SerializeField]
	private Collider[] colliders;

	[SerializeField]
	private GameObject feathers;

	[SerializeField]
	private GameObject seed;

	[SerializeField]
	private GameObject seedSpot;

	private Item reward;

	private bool attacking;

	private bool exploded;

	private bool dodged;

	private bool dontAnger;

	private bool peppered;

	private Vector3 cagePos;

	private AudioSource audio;

	private void Awake()
	{
	}

	public void SetReward(Item item)
	{
	}

	public void TryGrab()
	{
	}

	[IteratorStateMachine(typeof(_003C_Attack_003Ed__23))]
	private IEnumerator<float> _Attack()
	{
		return null;
	}

	private void ToggleGrabbable(bool canGrab)
	{
	}

	private bool IsCageOpen()
	{
		return false;
	}

	private void ForceOpenCage()
	{
	}

	public void Explode()
	{
	}

	public void Shoot()
	{
	}

	public void Hurt()
	{
	}

	public void Feed()
	{
	}

	[IteratorStateMachine(typeof(_003C_Eat_003Ed__31))]
	private IEnumerator<float> _Eat()
	{
		return null;
	}

	public void GrandpaKilled()
	{
	}

	public bool PepperHit()
	{
		return false;
	}
}
