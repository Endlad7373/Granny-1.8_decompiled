using UnityEngine;

[DisallowMultipleComponent]
public class SpecialDoorTweener : MonoBehaviour
{
	[SerializeField]
	private Transform specialDoor;

	[SerializeField]
	private Transform specialLock;

	[SerializeField]
	private GameObject carver;

	private GameObject reward;

	public void SetReward(GameObject item)
	{
	}

	public void UnlockSpecialDoor()
	{
	}
}
