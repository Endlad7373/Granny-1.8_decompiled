using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class CarTrunk : Interactable
{
	private enum TrunkState
	{
		Closed = 0,
		Moving = 1,
		Opened = 2
	}

	[SerializeField]
	private Vector3 openRot;

	[SerializeField]
	private Vector3 closeRot;

	[SerializeField]
	private float openTime;

	[SerializeField]
	private float closeTime;

	[SerializeField]
	private AudioClip openSfx;

	[SerializeField]
	private AudioClip closeSfx;

	[SerializeField]
	private AudioClip lockedSfx;

	[SerializeField]
	private GameObject reward;

	private AudioSource audio;

	private TrunkState state;

	private bool unlocked;

	private void Awake()
	{
	}

	private void Move()
	{
	}
}
