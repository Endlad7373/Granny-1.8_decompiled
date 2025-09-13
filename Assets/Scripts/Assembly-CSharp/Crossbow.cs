using UnityEngine;

[DisallowMultipleComponent]
public class Crossbow : MonoBehaviour
{
	private static Crossbow instance;

	[SerializeField]
	private GameObject limbUnloaded;

	[SerializeField]
	private GameObject limbLoaded;

	[SerializeField]
	private Transform dart;

	[SerializeField]
	private Transform shootFrom;

	[SerializeField]
	private Transform confirmRay;

	[SerializeField]
	private AudioClip loadSfx;

	[SerializeField]
	private AudioClip shootSfx;

	[SerializeField]
	private LayerMask targetLayers;

	private bool reloaded;

	private void Awake()
	{
	}

	public static void Reload()
	{
	}

	public static bool IsReloaded()
	{
		return false;
	}

	public static void Unload(Transform dropAt, float force)
	{
	}

	public static void Shoot()
	{
	}
}
