using UnityEngine;

[DisallowMultipleComponent]
public class CrankWell : MonoBehaviour
{
	[SerializeField]
	private Transform winch;

	[SerializeField]
	private Transform rope;

	[SerializeField]
	private Transform bucket;

	[SerializeField]
	private AudioSource cranking;

	private GameObject reward;

	private float cranked;

	private const float MAX_CRANK = 7.36108f;

	public void SetReward(GameObject item)
	{
	}

	public void Crank()
	{
	}

	public void Release()
	{
	}
}
