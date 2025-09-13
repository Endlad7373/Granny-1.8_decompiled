using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
public class Slendrina : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_Disappear_003Ed__26 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Slendrina _003C_003E4__this;

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
		public _003C_Disappear_003Ed__26(int _003C_003E1__state)
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
	private sealed class _003C_BehindCar_003Ed__31 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Slendrina _003C_003E4__this;

		private bool _003Cpractice_003E5__2;

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
		public _003C_BehindCar_003Ed__31(int _003C_003E1__state)
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
	private Transform target;

	[SerializeField]
	private float[] killSpeeds;

	[SerializeField]
	private Renderer[] fadeMats;

	[SerializeField]
	private Transform hideSpot;

	[SerializeField]
	private Transform disappearSpot;

	[SerializeField]
	private Transform dropSpot;

	[SerializeField]
	private Transform pipeSpot;

	[SerializeField]
	private Transform porchSpot;

	[SerializeField]
	private Transform carSpot;

	[SerializeField]
	private Transform garageSpot;

	[SerializeField]
	private GameObject reward;

	[SerializeField]
	private GameObject goneText;

	[SerializeField]
	private GameObject teddy;

	[SerializeField]
	private AudioClip theme;

	[SerializeField]
	private ParticleSystem steam;

	private Color[] fadeColors;

	private Color[] fadeColors2;

	private bool facePlayer;

	public static Slendrina Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECLateUpdate()
	{
	}

	public void Disappear()
	{
	}

	[IteratorStateMachine(typeof(_003C_Disappear_003Ed__26))]
	private IEnumerator<float> _Disappear()
	{
		return null;
	}

	public void ChangeAlpha(bool visible, float dur)
	{
	}

	private void HoldTeddy(bool dark)
	{
	}

	public void FrontDoorEscape()
	{
	}

	public void CarEscape()
	{
	}

	[IteratorStateMachine(typeof(_003C_BehindCar_003Ed__31))]
	private IEnumerator<float> _BehindCar()
	{
		return null;
	}

	public void PipeEscape()
	{
	}
}
