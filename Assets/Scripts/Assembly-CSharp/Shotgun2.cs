using UnityEngine;

[DisallowMultipleComponent]
public class Shotgun2 : MonoBehaviour
{
	private static Shotgun2 instance;

	[SerializeField]
	private Animation anim;

	[SerializeField]
	private Transform aimRay;

	[SerializeField]
	private Transform barrel;

	[SerializeField]
	private Transform shell;

	[SerializeField]
	private Transform emptyShell;

	[SerializeField]
	private Transform lightHolder;

	[SerializeField]
	private AudioClip outSfx;

	[SerializeField]
	private AudioClip loadSfx;

	[SerializeField]
	private AudioClip shootSfx;

	[SerializeField]
	private AudioClip dryfire;

	[SerializeField]
	private LayerMask targetLayers;

	[SerializeField]
	private GameObject ammoL;

	[SerializeField]
	private GameObject ammoR;

	[SerializeField]
	private GameObject muzzleSmoke;

	[SerializeField]
	private GameObject impactSmoke;

	[SerializeField]
	private GameObject flash;

	private int ammo;

	private int casingsQueued;

	private void Awake()
	{
	}

	public static void PickUp()
	{
	}

	public static void Reload()
	{
	}

	public static bool IsReloaded()
	{
		return false;
	}

	public static bool NoMoreRoom()
	{
		return false;
	}

	public static void Shoot()
	{
	}

	private void EjectCasing()
	{
	}
}
