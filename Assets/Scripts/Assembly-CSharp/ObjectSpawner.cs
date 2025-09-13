using UnityEngine;

[DisallowMultipleComponent]
public class ObjectSpawner : MonoBehaviour
{
	[SerializeField]
	private GameObject[] randomPlaces;

	[SerializeField]
	private GameObject[] allPadlockCodes;

	[SerializeField]
	private GameObject[] allBatteries;

	[SerializeField]
	private GameObject[] allPaintingPieces;

	[SerializeField]
	private GameObject[] allBooks;

	[SerializeField]
	private GameObject[] allTeddies;

	[SerializeField]
	private GameObject[] allGasoline;

	[SerializeField]
	private Transform coffinItem;

	[SerializeField]
	private Transform numberBoard;

	[SerializeField]
	private Transform grandpaVase;

	[SerializeField]
	private Transform[] coffinSpots;

	[SerializeField]
	private Transform[] numberBoardSpots;

	[SerializeField]
	private Transform[] grandpaVaseSpots;

	[SerializeField]
	private Mesh[] boardNumbers;

	[SerializeField]
	private Material coffinMatDark;

	public static int CurrentRandomPlace { get; private set; }

	public static int CurrentCoffin { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
