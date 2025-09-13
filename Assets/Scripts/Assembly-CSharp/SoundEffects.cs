using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class SoundEffects : MonoBehaviour
{
	private static SoundEffects instance;

	private AudioSource audio;

	private void Awake()
	{
	}

	public static void PlayAudioClip(AudioClip clip, float vol = 1f)
	{
	}

	public void PlayAudioClipEvent(AudioClip clip)
	{
	}
}
