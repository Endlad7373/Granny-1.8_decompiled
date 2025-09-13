using UnityEngine;

public class AmbienceController : MonoBehaviour
{
	public enum Zone
	{
		House = 0,
		Attic = 1,
		Backyard = 2,
		Sewer = 3
	}

	private static AmbienceController instance;

	private Zone currZone;

	[SerializeField]
	private float[] maxVolume;

	[SerializeField]
	private float maxFadeSpeed;

	[SerializeField]
	private AudioSource[] zoneAmbiences;

	[SerializeField]
	[Header("Misc. Sounds")]
	private AudioSource fanSound;

	[SerializeField]
	private AudioSource spiderSteps;

	[SerializeField]
	private AudioSource[] houseSounds;

	[SerializeField]
	private AudioSource[] sewerSounds;

	[SerializeField]
	[Header("Spider Cellar Traps")]
	private Transform trapHolder;

	[SerializeField]
	private Transform bearTrap;

	[SerializeField]
	private Transform organicTrap;

	[SerializeField]
	private Transform[] trap1Spots;

	[SerializeField]
	private Transform[] trap2Spots;

	[SerializeField]
	private Transform[] trap3Spots;

	[SerializeField]
	private Transform[] trap4Spots;

	private float[] targetVolumes;

	private bool fadeAll;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public static void ForceChangeZone(Zone zone)
	{
	}

	public void ChangeZone(int zone)
	{
	}

	public void FadeAll()
	{
	}

	public static bool InZone(Zone zone)
	{
		return false;
	}

	public static bool RecentlyInZone(Zone zone)
	{
		return false;
	}

	public static void FadeAll(bool fade)
	{
	}
}
