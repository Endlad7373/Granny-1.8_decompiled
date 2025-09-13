using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class DayCounter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_NewDay_003Ed__21 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public DayCounter _003C_003E4__this;

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
		public _003C_NewDay_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003C_EndDay_003Ed__23 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public DayCounter _003C_003E4__this;

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
		public _003C_EndDay_003Ed__23(int _003C_003E1__state)
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

	private static DayCounter instance;

	[SerializeField]
	private Animation playerInBed;

	[SerializeField]
	private Transform player;

	[SerializeField]
	private string[] bedAnims;

	[SerializeField]
	private GameObject bloodOnBed;

	[SerializeField]
	private GameObject spiderCellarTriggers;

	[SerializeField]
	private AudioClip dayBeat;

	[SerializeField]
	private AudioClip bedRustle;

	[SerializeField]
	private DoorGeneric[] allDoors;

	[SerializeField]
	private FurnitureDoor[] allFurnitureDoors;

	[SerializeField]
	private Drawer[] allDrawers;

	[SerializeField]
	private Image dayText;

	[SerializeField]
	private Sprite[] dayTexts;

	[SerializeField]
	private Sprite day5LastText;

	[SerializeField]
	private Sprite day6BonusText;

	private int day;

	private int maxDays;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static void BonusDayReward()
	{
	}

	private void NewDay()
	{
	}

	[IteratorStateMachine(typeof(_003C_NewDay_003Ed__21))]
	private IEnumerator<float> _NewDay()
	{
		return null;
	}

	public static void EndDay()
	{
	}

	[IteratorStateMachine(typeof(_003C_EndDay_003Ed__23))]
	private IEnumerator<float> _EndDay()
	{
		return null;
	}

	public static void Knockout(bool ragdolled, bool shot = false)
	{
	}
}
