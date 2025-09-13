using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[DisallowMultipleComponent]
public class Spider : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_Killing_003Ed__41 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Spider _003C_003E4__this;

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
		public _003C_Killing_003Ed__41(int _003C_003E1__state)
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
	private Animation anim;

	[SerializeField]
	private GameObject meat;

	[SerializeField]
	private GameObject meatSpot;

	[SerializeField]
	private GameObject cageButton;

	[SerializeField]
	private Transform nestPos;

	[SerializeField]
	private Transform stuckPos;

	[SerializeField]
	private Transform foodPos;

	[SerializeField]
	private Transform playerPos;

	[SerializeField]
	private AudioSource audio;

	[SerializeField]
	private AudioSource moving;

	[SerializeField]
	private AudioClip hiss;

	[SerializeField]
	private AudioClip bite;

	[SerializeField]
	private AudioClip die;

	private NavMeshAgent nav;

	private Transform target;

	private bool chasing;

	private bool dead;

	private bool trapped;

	private bool stuck;

	private bool eating;

	private bool seenPlayer;

	private bool attacking;

	private bool explode;

	private bool dontAnger;

	private bool dontHiss;

	public static Spider Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	private void MECLateUpdate()
	{
	}

	public void CloseCage()
	{
	}

	public void Feed()
	{
	}

	private void SetTarget(Transform newTarget)
	{
	}

	public void PlayerEnter()
	{
	}

	public void PlayerLeave()
	{
	}

	private void ReturnHome()
	{
	}

	public void Die()
	{
	}

	public void Kill()
	{
	}

	[IteratorStateMachine(typeof(_003C_Killing_003Ed__41))]
	private IEnumerator<float> _Killing()
	{
		return null;
	}

	public void Reset()
	{
	}

	private bool InHome()
	{
		return false;
	}

	public void Explode()
	{
	}

	private void OnDisable()
	{
	}

	public void GrandpaKilled()
	{
	}

	public bool IsAlive()
	{
		return false;
	}
}
