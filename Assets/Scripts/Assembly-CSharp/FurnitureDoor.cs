using UnityEngine;
using UnityEngine.AI;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class FurnitureDoor : Interactable
{
	private enum FurnitureState
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
	private int openLayer;

	[SerializeField]
	private int closeLayer;

	private AudioSource audio;

	private NavMeshObstacle nav;

	private FurnitureState state;

	private void Awake()
	{
	}

	private void Move()
	{
	}

	public void ForceClose()
	{
	}

	public bool IsClosed()
	{
		return false;
	}

	public void ForceOpen()
	{
	}
}
