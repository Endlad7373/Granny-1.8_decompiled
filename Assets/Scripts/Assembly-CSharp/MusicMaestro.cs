using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[DisallowMultipleComponent]
public class MusicMaestro : MonoBehaviour
{
	public enum Music
	{
		Normal = 0,
		Chase = 1,
		SpiderCellar = 2,
		SpiderChase = 3,
		Heartbeat = 4
	}

	[Serializable]
	public class MusicTrack
	{
		public Music music;

		public AudioSource musicHolder;

		public float maxVolume;

		public float fadeSpeed;
	}

	[CompilerGenerated]
	private sealed class _003C_MusicReturnTimer_003Ed__29 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public MusicMaestro _003C_003E4__this;

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
		public _003C_MusicReturnTimer_003Ed__29(int _003C_003E1__state)
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

	private static MusicMaestro instance;

	public static bool killed;

	public static bool noMusic;

	[SerializeField]
	private MusicTrack[] musicDefs;

	[SerializeField]
	private AudioClip nightmareMusic;

	[SerializeField]
	private AudioClip nightmareChaseMusic;

	[SerializeField]
	private AudioClip momSpiderJumpscare;

	[SerializeField]
	private AudioClip oldChaseMusic;

	[SerializeField]
	private AudioClip seeMom;

	private Dictionary<Music, MusicTrack> allMusic;

	private Dictionary<Music, float> targetVolumes;

	private bool metMomSpider;

	private bool fadeAll;

	private float fadeAllTimer;

	private AudioSource audio;

	public static bool OldMusic { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public void MeetMomSpider()
	{
	}

	public static void PlayTrackOnce(AudioClip track, float vol = 1f)
	{
	}

	public static void FadeAllMusic(bool fade)
	{
	}

	public static void FadeAllMusicFor(float time)
	{
	}

	private void SetFadeMusicTimer(float time)
	{
	}

	[IteratorStateMachine(typeof(_003C_MusicReturnTimer_003Ed__29))]
	private IEnumerator<float> _MusicReturnTimer()
	{
		return null;
	}

	public void SeeMom()
	{
	}

	public static void EarlyMomSpider()
	{
	}
}
