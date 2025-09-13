using UnityEngine;

[DisallowMultipleComponent]
public class DifficultySystem : MonoBehaviour
{
	public enum Difficulty
	{
		Easy = 1,
		Normal = 2,
		Hard = 3,
		Extreme = 4,
		Impossible = 5
	}

	public enum Weapon
	{
		Cane = 0,
		Shotgun = 1
	}

	[SerializeField]
	private GameObject creakingFloors;

	[SerializeField]
	private GameObject bonusDayOpportunity;

	[SerializeField]
	private GameObject digitalPadlock;

	[SerializeField]
	private GameObject battery;

	[SerializeField]
	private GameObject motorLock;

	[SerializeField]
	private GameObject barriersExtreme;

	[SerializeField]
	private GameObject barriersImpossible;

	[SerializeField]
	private GameObject[] removeOnImpossible;

	[SerializeField]
	private NoiseOnActivate microwaveSparks;

	[SerializeField]
	private TransformEvent flashlight;

	[SerializeField]
	private Light flashlightBulb;

	public static Difficulty CurrentDifficulty { get; private set; }

	public static bool Fog { get; private set; }

	public static bool ExtraLocks { get; private set; }

	public static bool Nightmare { get; private set; }

	public static bool OldNightmare { get; private set; }

	public static bool Granny { get; private set; }

	public static bool Grandpa { get; private set; }

	public static Weapon GrandpaWeapon { get; private set; }

	public static bool Randomize { get; private set; }

	public static bool MomSpider { get; private set; }

	public static bool Slendrina { get; private set; }

	public static bool Classic { get; private set; }

	public static bool Flashlight { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static void GetGameSettings()
	{
	}
}
