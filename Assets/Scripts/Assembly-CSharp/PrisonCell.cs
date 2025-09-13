using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PrisonCell : MonoBehaviour
{
	[Serializable]
	private struct PrisonDoorSpring
	{
		public GameObject spring;

		public GameObject sparkle;

		public AudioSource screwing;

		public TimerTrigger timer;
	}

	[CompilerGenerated]
	private sealed class _003C_CameraBlink_003Ed__25 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public PrisonCell _003C_003E4__this;

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
		public _003C_CameraBlink_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003C_StayTimer_003Ed__29 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public PrisonCell _003C_003E4__this;

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
		public _003C_StayTimer_003Ed__29(int _003C_003E1__state)
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
	private Renderer lamp;

	[SerializeField]
	private AudioSource beep;

	[SerializeField]
	private Transform prisonDoor;

	[SerializeField]
	private Animation prisonDoorAnim;

	[SerializeField]
	private AudioSource prisonDoorSfx;

	[SerializeField]
	private GameObject insidePrisonTrigger;

	[SerializeField]
	private GameObject prisonDoorTrigger;

	[SerializeField]
	private Vector3 openRot;

	[SerializeField]
	private Vector3 closeRot;

	[SerializeField]
	private AudioClip openDoor;

	[SerializeField]
	private AudioClip closeDoor;

	[SerializeField]
	private AudioClip lockedDoor;

	[SerializeField]
	private PrisonDoorSpring spring1;

	[SerializeField]
	private PrisonDoorSpring spring2;

	private bool cameraOff;

	private float stayTimer;

	private int springs;

	public static PrisonCell Instance { get; private set; }

	private void Awake()
	{
	}

	public void EnterPrison()
	{
	}

	public void CameraOff(bool broken = false)
	{
	}

	[IteratorStateMachine(typeof(_003C_CameraBlink_003Ed__25))]
	private IEnumerator<float> _CameraBlink()
	{
		return null;
	}

	public void ResetPrison()
	{
	}

	public void PullSpring(int id)
	{
	}

	public void StandInPrison()
	{
	}

	[IteratorStateMachine(typeof(_003C_StayTimer_003Ed__29))]
	private IEnumerator<float> _StayTimer()
	{
		return null;
	}

	public static bool PlayerInPrison()
	{
		return false;
	}

	public void ShakeDoor()
	{
	}

	public void EnemyOpenDoor()
	{
	}
}
