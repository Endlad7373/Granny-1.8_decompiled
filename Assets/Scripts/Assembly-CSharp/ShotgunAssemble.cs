using UnityEngine;

public class ShotgunAssemble : MonoBehaviour
{
	private static ShotgunAssemble instance;

	[SerializeField]
	private GameObject piece1;

	[SerializeField]
	private GameObject piece2;

	[SerializeField]
	private GameObject piece3;

	[SerializeField]
	private GameObject shotgun;

	[SerializeField]
	private GameObject ammo1;

	[SerializeField]
	private GameObject ammo2;

	[SerializeField]
	private GameObject blueprint;

	private void Awake()
	{
	}

	public void PlaceShotgunPart()
	{
	}

	public static void PlaceMoreAmmo()
	{
	}

	public static void PlaceGrandpaAmmo()
	{
	}
}
