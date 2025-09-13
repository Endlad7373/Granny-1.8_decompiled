using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using com.ootii.Actors.BoneControllers;

public class Cutscenes : MonoBehaviour
{
	private enum GameOver
	{
		Basement = 0,
		Guillotine = 1,
		Car = 2,
		Attic = 3,
		Spider = 4
	}

	[CompilerGenerated]
	private sealed class _003C_GameOverScene1_003Ed__92 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Cutscenes _003C_003E4__this;

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
		public _003C_GameOverScene1_003Ed__92(int _003C_003E1__state)
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
	private sealed class _003C_GameOverScene2_003Ed__93 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Cutscenes _003C_003E4__this;

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
		public _003C_GameOverScene2_003Ed__93(int _003C_003E1__state)
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
	private sealed class _003C_GameOverScene3_003Ed__94 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Cutscenes _003C_003E4__this;

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
		public _003C_GameOverScene3_003Ed__94(int _003C_003E1__state)
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
	private sealed class _003C_GameOverScene4_003Ed__95 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Cutscenes _003C_003E4__this;

		private BearTrap _003CcurrBearTrap_003E5__2;

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
		public _003C_GameOverScene4_003Ed__95(int _003C_003E1__state)
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
	private sealed class _003C_GameOverScene5_003Ed__96 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Cutscenes _003C_003E4__this;

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
		public _003C_GameOverScene5_003Ed__96(int _003C_003E1__state)
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
	private sealed class _003C_GameOverEnding_003Ed__97 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Cutscenes _003C_003E4__this;

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
		public _003C_GameOverEnding_003Ed__97(int _003C_003E1__state)
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
	private sealed class _003C_FrontDoorEscape_003Ed__100 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Cutscenes _003C_003E4__this;

		private float _003CwaitTime_003E5__2;

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
		public _003C_FrontDoorEscape_003Ed__100(int _003C_003E1__state)
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
	private sealed class _003C_CarEscape_003Ed__102 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Cutscenes _003C_003E4__this;

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
		public _003C_CarEscape_003Ed__102(int _003C_003E1__state)
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
	private sealed class _003C_PipeEscape_003Ed__104 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Cutscenes _003C_003E4__this;

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
		public _003C_PipeEscape_003Ed__104(int _003C_003E1__state)
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

	private static Cutscenes instance;

	[SerializeField]
	private Animation grannyAnim;

	[SerializeField]
	private Animation grandpaAnim;

	[SerializeField]
	private BoneController grannyStare;

	[SerializeField]
	private BoneController grandpaStare;

	[SerializeField]
	private GameObject gameOverText;

	[SerializeField]
	private GameObject theEndText;

	[SerializeField]
	private GameObject practiceText;

	[SerializeField]
	[Header("Front Door Escape")]
	private Animation frontDoorCam;

	[SerializeField]
	private Transform grannyFrontDoorPos;

	[SerializeField]
	private Transform grannyPorchPos;

	[SerializeField]
	private Transform grannyWoodsPos;

	[SerializeField]
	private Transform grandpaFrontDoorPos;

	[SerializeField]
	private Transform grandpaPorchPos;

	[SerializeField]
	private Transform grandpaWoodsPos;

	[SerializeField]
	private Transform teddyFallPos;

	[SerializeField]
	private GameObject teddy;

	[SerializeField]
	private GameObject snoring;

	[SerializeField]
	private GameObject theEndDisplay;

	[SerializeField]
	private GameObject practiceDisplay;

	[SerializeField]
	private AudioClip openDoorAndRun;

	[SerializeField]
	private AudioClip frontDoorMusic;

	[SerializeField]
	private Renderer grannyEyes;

	[SerializeField]
	private Shader foggyShader;

	[SerializeField]
	[Header("Car Escape")]
	private GameObject plywoodWall;

	[SerializeField]
	private GameObject plywoodWallBroken;

	[SerializeField]
	private Animation tunnelCam;

	[SerializeField]
	private AudioClip carMusic;

	[SerializeField]
	private Transform enemiesGarage;

	[SerializeField]
	private Transform grannyGaragePos;

	[SerializeField]
	private Transform grandpaGaragePos;

	[SerializeField]
	[Header("Pipe Escape")]
	private AudioSource escapeSpiderCellarMusic;

	[SerializeField]
	private Animation pipeCam;

	[SerializeField]
	private GameObject grannyPipe;

	[SerializeField]
	private AudioClip grandpaSigh;

	[SerializeField]
	[Header("Game Over #1")]
	private Transform grannyStairsPos;

	[SerializeField]
	private Transform basementDoor;

	[SerializeField]
	private Transform grannyBasementPos;

	[SerializeField]
	private Transform grannyLookAt;

	[SerializeField]
	private Transform grandpaBasementPos1;

	[SerializeField]
	private Transform grandpaBasementPos2;

	[SerializeField]
	private Transform grandpaBasementPos3;

	[SerializeField]
	private Transform grandpaLookAt;

	[SerializeField]
	private Animation basementHead;

	[SerializeField]
	private AudioClip basementMusic;

	[SerializeField]
	private AudioClip basementMusicOld;

	[Header("Game Over #2")]
	[SerializeField]
	private Transform grannyGuillotinePos;

	[SerializeField]
	private Transform grandpaGuillotinePos;

	[SerializeField]
	private Animation guillotineHead;

	[SerializeField]
	private GameObject melon;

	[SerializeField]
	private AudioClip guillotineMusic;

	[SerializeField]
	private AudioClip sliceHead;

	[SerializeField]
	private GuillotineController guillotine;

	[Header("Game Over #3")]
	[SerializeField]
	private Transform grannyCarPos;

	[SerializeField]
	private Transform grandpaCarPos;

	[SerializeField]
	private Animation carHead;

	[SerializeField]
	private Animation car;

	[SerializeField]
	private AudioSource carBack;

	[SerializeField]
	private AudioSource carForward;

	[SerializeField]
	private AudioSource grannyLaughCar;

	[SerializeField]
	private AudioClip carCrash;

	[SerializeField]
	private Renderer windshield;

	[Header("Game Over #4")]
	[SerializeField]
	private Transform grannyAtticPos;

	[SerializeField]
	private Transform grandpaAtticPos;

	[SerializeField]
	private GameObject plank;

	[SerializeField]
	private Animation fallingHead;

	[SerializeField]
	private AudioSource grannyLaughAttic;

	[SerializeField]
	private AudioClip atticMusic;

	[SerializeField]
	private AudioClip smack;

	[SerializeField]
	private AudioClip land;

	[SerializeField]
	private PlayerTrigger breakFloor;

	[SerializeField]
	private BearTrap bearTrap;

	[SerializeField]
	private BearTrap organicTrap;

	[SerializeField]
	[Header("Game Over #5")]
	private Transform grannySpiderPos;

	[SerializeField]
	private Transform grandpaSpiderPos;

	[SerializeField]
	private Transform spiderCageCover;

	[SerializeField]
	private Transform spiderPos1;

	[SerializeField]
	private Transform spiderPos2;

	[SerializeField]
	private Transform spiderPos3;

	[SerializeField]
	private GameObject spiderCoverNoise;

	[SerializeField]
	private Animation spiderAnim;

	[SerializeField]
	private Animation fedHead;

	[SerializeField]
	private AudioSource fan;

	[SerializeField]
	private AudioSource grannyLaughSpider;

	[SerializeField]
	private AudioSource grannyClickButton;

	[SerializeField]
	private AudioSource spiderWake;

	[SerializeField]
	private AudioSource spiderSteps;

	[SerializeField]
	private AudioClip spiderBite;

	[SerializeField]
	private AudioClip spiderOver;

	private void Awake()
	{
	}

	public static void StartGameOver()
	{
	}

	[IteratorStateMachine(typeof(_003C_GameOverScene1_003Ed__92))]
	private IEnumerator<float> _GameOverScene1()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003C_GameOverScene2_003Ed__93))]
	private IEnumerator<float> _GameOverScene2()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003C_GameOverScene3_003Ed__94))]
	private IEnumerator<float> _GameOverScene3()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003C_GameOverScene4_003Ed__95))]
	private IEnumerator<float> _GameOverScene4()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003C_GameOverScene5_003Ed__96))]
	private IEnumerator<float> _GameOverScene5()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003C_GameOverEnding_003Ed__97))]
	private IEnumerator<float> _GameOverEnding()
	{
		return null;
	}

	private void AdjustFog(bool dense)
	{
	}

	public static void FrontDoorEscape()
	{
	}

	[IteratorStateMachine(typeof(_003C_FrontDoorEscape_003Ed__100))]
	private IEnumerator<float> _FrontDoorEscape()
	{
		return null;
	}

	public static void CarEscape()
	{
	}

	[IteratorStateMachine(typeof(_003C_CarEscape_003Ed__102))]
	private IEnumerator<float> _CarEscape()
	{
		return null;
	}

	public static void PipeEscape()
	{
	}

	[IteratorStateMachine(typeof(_003C_PipeEscape_003Ed__104))]
	private IEnumerator<float> _PipeEscape()
	{
		return null;
	}

	private void ReparentEnemyForScene(Transform enemy, Transform spot)
	{
	}

	public static bool MuteForGameOver()
	{
		return false;
	}
}
