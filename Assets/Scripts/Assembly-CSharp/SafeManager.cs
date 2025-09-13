using UnityEngine;

[DisallowMultipleComponent]
public class SafeManager : MonoBehaviour
{
	[SerializeField]
	private Transform safeDoor;

	[SerializeField]
	private Vector3 openAngle;

	[SerializeField]
	private float openTime;

	private GameObject reward;

	public void SetReward(GameObject item)
	{
	}

	public void UnlockSafe()
	{
	}
}
