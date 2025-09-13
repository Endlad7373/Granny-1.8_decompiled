using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
public class GuillotineController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_UseGuillotine_003Ed__13 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public GuillotineController _003C_003E4__this;

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
		public _003C_UseGuillotine_003Ed__13(int _003C_003E1__state)
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
	private Animation guillotine;

	[SerializeField]
	private AudioSource guillotineSound;

	[SerializeField]
	private AudioSource bladeLand;

	[SerializeField]
	private GameObject lever;

	[SerializeField]
	private GameObject melonSpot;

	[SerializeField]
	private GameObject melon;

	[SerializeField]
	private GameObject melonPieces;

	[SerializeField]
	private Transform noiseSpot;

	[SerializeField]
	private Vector3 noisePosGrandpa;

	private GameObject reward;

	public void SetReward(GameObject item)
	{
	}

	public void PullLever()
	{
	}

	public void GuillotineAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003C_UseGuillotine_003Ed__13))]
	private IEnumerator<float> _UseGuillotine()
	{
		return null;
	}
}
