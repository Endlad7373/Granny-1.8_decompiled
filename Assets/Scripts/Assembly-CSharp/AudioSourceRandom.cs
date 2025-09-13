using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class AudioSourceRandom : MonoBehaviour
{
	[SerializeField]
	private AudioClip[] clips;

	private AudioSource audio;

	private void Awake()
	{
	}

	public void Play()
	{
	}

	public void PlayOneShot()
	{
	}
}
