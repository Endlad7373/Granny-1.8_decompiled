using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class ElevatorController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_Reset_003Ed__25 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public ElevatorController _003C_003E4__this;

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
		public _003C_Reset_003Ed__25(int _003C_003E1__state)
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

	private static ElevatorController instance;

	[SerializeField]
	private float posUp;

	[SerializeField]
	private Transform door1;

	[SerializeField]
	private Transform door2;

	[SerializeField]
	private Transform button;

	[SerializeField]
	private float door1Closed;

	[SerializeField]
	private float door2Closed;

	[SerializeField]
	private float buttonPressed;

	[SerializeField]
	private float buttonPressDur;

	[SerializeField]
	private float buttonUnpressDur;

	[SerializeField]
	private AudioSource elevatorSound;

	[SerializeField]
	private AudioClip openDoors;

	[SerializeField]
	private AudioClip closeDoors;

	private bool moving;

	private bool up;

	private bool closed;

	private float door1Open;

	private float door2Open;

	private float buttonUnpressed;

	private float posDown;

	private AudioSource audio;

	private void Awake()
	{
	}

	public void UseDoors()
	{
	}

	public void UseElevator()
	{
	}

	public static void Reset()
	{
	}

	[IteratorStateMachine(typeof(_003C_Reset_003Ed__25))]
	private IEnumerator<float> _Reset()
	{
		return null;
	}

	public static void EnemyForceOpen()
	{
	}
}
