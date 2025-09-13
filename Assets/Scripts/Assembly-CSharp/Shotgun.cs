using UnityEngine;

[DisallowMultipleComponent]
public class Shotgun : MonoBehaviour
{
	private static Shotgun instance;

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
	private AudioClip unloadedSfx;

	[SerializeField]
	private AudioClip loadedSfx;

	[SerializeField]
	private AudioClip loadSfx;

	[SerializeField]
	private AudioClip shootSfx;

	[SerializeField]
	private LayerMask targetLayers;

	[SerializeField]
	private GameObject muzzleSmoke;

	[SerializeField]
	private GameObject impactSmoke;

	[SerializeField]
	private GameObject flash;

	private bool reloaded;

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

	public static void Shoot()
	{
	}

	private void EjectCasing()
	{
	}
}
