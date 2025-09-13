using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class Menu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_Open_003Ed__65 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Menu _003C_003E4__this;

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
		public _003C_Open_003Ed__65(int _003C_003E1__state)
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
	private sealed class _003C_ChangeMenus_003Ed__74 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Menu _003C_003E4__this;

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
		public _003C_ChangeMenus_003Ed__74(int _003C_003E1__state)
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
	private sealed class _003C_Load_003Ed__86 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Menu _003C_003E4__this;

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
		public _003C_Load_003Ed__86(int _003C_003E1__state)
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
	private sealed class _003C_ReadStory_003Ed__107 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public Menu _003C_003E4__this;

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
		public _003C_ReadStory_003Ed__107(int _003C_003E1__state)
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

	[Header("Enemies")]
	[SerializeField]
	private Transform granny;

	[SerializeField]
	private Transform grannyPos;

	[SerializeField]
	private Transform grandpa;

	[SerializeField]
	private Transform grandpaPos;

	[SerializeField]
	private Transform backyardPos;

	[SerializeField]
	private Transform camHolder;

	[SerializeField]
	private Transform fridgeDoor;

	[SerializeField]
	private GameObject slendrina;

	[SerializeField]
	private GameObject motorLock;

	[SerializeField]
	private Animation grannyAnim;

	[SerializeField]
	private Animation bearTrap;

	[SerializeField]
	private Animation organicTrap;

	[SerializeField]
	private Camera cam;

	[SerializeField]
	private CanvasRenderer blackScreen;

	[SerializeField]
	private PostProcessProfile postProcessing;

	[SerializeField]
	private PostProcessLayer camPost;

	[SerializeField]
	private GameObject title;

	[SerializeField]
	private GameObject options;

	[SerializeField]
	private GameObject gameOptions;

	[SerializeField]
	private GameObject story;

	[SerializeField]
	private GameObject grandpaText;

	[SerializeField]
	private GameObject avOptions;

	[SerializeField]
	private GameObject continueButton;

	[SerializeField]
	private GameObject loading;

	[SerializeField]
	private GameObject fpsSettings;

	[SerializeField]
	private Toggle darkerToggle;

	[SerializeField]
	private Toggle extraLocksToggle;

	[SerializeField]
	private Toggle nightmareToggle;

	[SerializeField]
	private Toggle grannyToggle;

	[SerializeField]
	private Toggle randomizeToggle;

	[SerializeField]
	private Toggle grandpaToggle;

	[SerializeField]
	private Toggle momSpiderToggle;

	[SerializeField]
	private Toggle crouchToggle;

	[SerializeField]
	private Toggle aoToggle;

	[SerializeField]
	private Toggle blurToggle;

	[SerializeField]
	private Toggle colorToggle;

	[SerializeField]
	private Toggle chromaticAberrationToggle;

	[SerializeField]
	private Toggle vignetteToggle;

	[SerializeField]
	private Toggle vsyncToggle;

	[SerializeField]
	private TMP_Dropdown difficultyDropdown;

	[SerializeField]
	private TMP_Dropdown musicDropdown;

	[SerializeField]
	private TMP_Dropdown grandpaDropdown;

	[SerializeField]
	private TMP_Dropdown qualityDropdown;

	[SerializeField]
	private TMP_Dropdown nightmareDropdown;

	[SerializeField]
	private Slider volumeSlider;

	[SerializeField]
	private Slider sensitivitySlider;

	[SerializeField]
	private Slider fovSlider;

	[SerializeField]
	private Slider fpsSlider;

	[SerializeField]
	private TextMeshProUGUI difficultyText;

	[SerializeField]
	private TextMeshProUGUI fovText;

	[SerializeField]
	private TextMeshProUGUI fpsText;

	[SerializeField]
	private TextMeshProUGUI tipText;

	[SerializeField]
	private RectTransform gameSettingsBar;

	[SerializeField]
	private AudioSource music;

	[SerializeField]
	private MenuNightmare[] nmObjs;

	private bool trapped;

	private bool canClick;

	private bool fridgeOpened;

	private AmbientOcclusion ao;

	private ColorGrading cg;

	private DepthOfField df;

	private AudioSource audio;

	private int[] framerates;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003C_Open_003Ed__65))]
	private IEnumerator<float> _Open()
	{
		return null;
	}

	private void MECUpdate()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshPost()
	{
	}

	private void RefreshGameOptions()
	{
	}

	private void RefreshAudioVisualOptions()
	{
	}

	private void RefreshInfoBox()
	{
	}

	public void ClickBearTrap()
	{
	}

	public void ClickPlay()
	{
	}

	[IteratorStateMachine(typeof(_003C_ChangeMenus_003Ed__74))]
	private IEnumerator<float> _ChangeMenus()
	{
		return null;
	}

	public void ClickQuit()
	{
	}

	private void FadeBlackScreen(float alpha, float dur)
	{
	}

	public void ChangeDifficulty()
	{
	}

	public void ToggleDarker()
	{
	}

	public void ToggleExtraLocks()
	{
	}

	public void ToggleNightmare()
	{
	}

	public void ChangeNightmare()
	{
	}

	public void ToggleRandomize()
	{
	}

	public void ChangeMusic()
	{
	}

	public void ToggleGranny()
	{
	}

	public void StartGame()
	{
	}

	[IteratorStateMachine(typeof(_003C_Load_003Ed__86))]
	private IEnumerator<float> _Load()
	{
		return null;
	}

	private void ChangeScene()
	{
	}

	public void ToggleGrandpa()
	{
	}

	public void ChangeGrandpaWeapon()
	{
	}

	public void ToggleMomSpider()
	{
	}

	public void SwitchAudioVisual(bool av)
	{
	}

	public void ChangeVolume()
	{
	}

	public void ChangeSensitivity()
	{
	}

	public void ChangeFOV()
	{
	}

	public void ToggleCrouch()
	{
	}

	public void ChangeQuality()
	{
	}

	public void ToggleAmbientOcclusion()
	{
	}

	public void ToggleMotionBlur()
	{
	}

	public void ToggleColorGrading()
	{
	}

	public void ToggleChromaticAberration()
	{
	}

	public void ToggleVignette()
	{
	}

	public void ChangeFPS()
	{
	}

	public void ToggleVSync()
	{
	}

	public void RefreshScreenSettings()
	{
	}

	private void RefreshTips()
	{
	}

	public void ContinueToStory()
	{
	}

	[IteratorStateMachine(typeof(_003C_ReadStory_003Ed__107))]
	private IEnumerator<float> _ReadStory()
	{
		return null;
	}

	public void GrannyHear()
	{
	}
}
