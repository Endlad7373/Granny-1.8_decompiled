using UnityEngine;

public class Zoning : MonoBehaviour
{
	public enum Area
	{
		Unknown = 0,
		SecondFloor = 1,
		FirstFloor = 2,
		Basement = 3,
		Cellar = 4,
		Attic = 5,
		Backyard = 6,
		OldHouse = 7,
		SpiderCellar = 8
	}

	private static Zoning instance;

	[SerializeField]
	private Transform player;

	[SerializeField]
	private Footsteps playerSteps;

	private void Awake()
	{
	}

	public static Area GetPlayerArea()
	{
		return default(Area);
	}
}
