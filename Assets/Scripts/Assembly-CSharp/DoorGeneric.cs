using UnityEngine;

[RequireComponent(typeof(Animation))]
[RequireComponent(typeof(AudioSource))]
[DisallowMultipleComponent]
public class DoorGeneric : Interactable
{
	private enum DoorState
	{
		Closed = 0,
		Moving = 1,
		Opened = 2
	}

	public bool locked;

	public bool enemiesCanUnlock;

	public bool relock;

	[SerializeField]
	private string openAnim;

	[SerializeField]
	private string closeAnim;

	[SerializeField]
	private string lockedAnim;

	[SerializeField]
	private AudioClip openSfx;

	[SerializeField]
	private AudioClip closeSfx;

	[SerializeField]
	private AudioClip lockedSfx;

	[SerializeField]
	private AudioClip unlockedSfx;

	[SerializeField]
	private float openDur;

	[SerializeField]
	private float closeDur;

	[SerializeField]
	private float lockedDur;

	[SerializeField]
	private int movingLayer;

	[SerializeField]
	private int staticLayer;

	private AudioSource audio;

	private Animation anim;

	private DoorState state;

	private float openAnimLength;

	private float closeAnimLength;

	private bool enemyJustUnlocked;

	private bool enemyUnlockSound;

	private void Awake()
	{
	}

	private void Move()
	{
	}

	private void OpenDoor()
	{
	}

	private void FinishMoving()
	{
	}

	private void FinishOpening()
	{
	}

	private void FinishClosing()
	{
	}

	public void Unlock(bool enemy = false)
	{
	}

	public void EnemyUse()
	{
	}

	public void EnemyUnlock()
	{
	}

	public void EnemyOpen()
	{
	}

	public void ForceClose()
	{
	}

	public bool CanHideBehind()
	{
		return false;
	}

	public bool EnemyStopWaiting()
	{
		return false;
	}
}
