using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RemoteCloset : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_StayTimer_003Ed__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public RemoteCloset _003C_003E4__this;

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
		public _003C_StayTimer_003Ed__15(int _003C_003E1__state)
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

	private static RemoteCloset instance;

	[SerializeField]
	private AudioClip useRemote;

	[SerializeField]
	private GameObject reward;

	[SerializeField]
	private GameObject remoteSpot;

	[SerializeField]
	private GameObject remoteTrigger;

	[SerializeField]
	private DoorGeneric door;

	[SerializeField]
	private Transform bar;

	[SerializeField]
	private Vector3 openPos;

	[SerializeField]
	private AudioSource unlock;

	[SerializeField]
	private WiredLight lamp;

	private float stayTimer;

	private void Awake()
	{
	}

	public void StayNearDoor()
	{
	}

	public void UseRemote()
	{
	}

	public void Unlock()
	{
	}

	[IteratorStateMachine(typeof(_003C_StayTimer_003Ed__15))]
	private IEnumerator<float> _StayTimer()
	{
		return null;
	}

	public static bool DoorIsLocked()
	{
		return false;
	}
}
