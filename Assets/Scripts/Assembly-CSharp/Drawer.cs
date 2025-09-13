using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class Drawer : Interactable
{
	private enum DrawerState
	{
		Closed = 0,
		Moving = 1,
		Opened = 2
	}

	[SerializeField]
	private Vector3 openPos;

	[SerializeField]
	private float openTime;

	[SerializeField]
	private float closeTime;

	[SerializeField]
	private AudioClip openSfx;

	[SerializeField]
	private AudioClip closeSfx;

	private AudioSource audio;

	private DrawerState state;

	private void Awake()
	{
	}

	private void Move()
	{
	}

	public void ForceClose()
	{
	}
}
