using UnityEngine;

public class BellTrap : MonoBehaviour
{
	[SerializeField]
	private Animation bell;

	[SerializeField]
	private AudioSource ring;

	[SerializeField]
	private Transform noise;

	private bool cooldown;

	public void Ring()
	{
	}
}
