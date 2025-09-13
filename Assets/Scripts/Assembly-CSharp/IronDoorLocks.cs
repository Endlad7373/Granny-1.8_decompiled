using UnityEngine;

[DisallowMultipleComponent]
public class IronDoorLocks : MonoBehaviour
{
	[SerializeField]
	private Transform doorLeft;

	[SerializeField]
	private Transform doorRight;

	[SerializeField]
	private Transform spinLock;

	[SerializeField]
	private Transform chainLeft;

	[SerializeField]
	private Transform chainRight;

	[SerializeField]
	private GameObject escape;

	[SerializeField]
	private AudioSource openDoors;

	private bool padlockBroken;

	private bool leverSpun;

	private bool chainCut;

	public void OpenIronDoors()
	{
	}

	public void BreakPadlock()
	{
	}

	public void SpinLever()
	{
	}

	public void CutChain()
	{
	}

	public void CheckLocks()
	{
	}

	public void EscapePipe()
	{
	}
}
