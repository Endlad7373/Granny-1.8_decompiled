using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
public class LandingNoise : MonoBehaviour
{
	public enum Alert
	{
		DontAlert = 0,
		Normal = 1,
		ForceAlert = 2
	}

	public bool inWater;

	public bool loud;

	public Alert alert;

	[SerializeField]
	private UnityEvent onLand;

	[SerializeField]
	private AudioClip splash;

	private AudioSource audio;

	private AudioSourceRandom rand;

	private bool ignoreWater;

	private bool dontOverlap;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
