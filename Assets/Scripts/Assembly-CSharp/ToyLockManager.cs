using UnityEngine;

[DisallowMultipleComponent]
public class ToyLockManager : MonoBehaviour
{
	[SerializeField]
	private Animation toyLock;

	[SerializeField]
	private GameObject cogwheel1;

	[SerializeField]
	private GameObject cogwheel2;

	[SerializeField]
	private GameObject cogwheelsSpot;

	private GameObject reward;

	public void SetReward(GameObject item)
	{
	}

	public void PlaceCogwheel()
	{
	}
}
