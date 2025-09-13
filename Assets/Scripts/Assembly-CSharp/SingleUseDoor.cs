using UnityEngine;

[DisallowMultipleComponent]
public class SingleUseDoor : Interactable
{
	[SerializeField]
	private Vector3 openRot;

	[SerializeField]
	private float openTime;

	private void Awake()
	{
	}

	private void Move()
	{
	}
}
