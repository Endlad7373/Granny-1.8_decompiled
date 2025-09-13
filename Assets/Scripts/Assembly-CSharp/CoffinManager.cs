using UnityEngine;

[DisallowMultipleComponent]
public class CoffinManager : MonoBehaviour
{
	[SerializeField]
	private Transform[] coffins;

	[SerializeField]
	private Transform[] coffinLids;

	[SerializeField]
	private GameObject coffinItem;

	[SerializeField]
	private GameObject bomb;

	[SerializeField]
	private GameObject flash;

	[Header("Animation")]
	[SerializeField]
	private Vector3 openRot;

	[SerializeField]
	private Vector3 restRot;

	[SerializeField]
	private float openSpeed;

	[SerializeField]
	private float restSpeed;

	public void OpenCoffin(int num)
	{
	}
}
