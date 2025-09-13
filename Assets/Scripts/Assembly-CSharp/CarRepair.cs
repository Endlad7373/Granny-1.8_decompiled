using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CarRepair : MonoBehaviour
{
	[SerializeField]
	private GameObject sparkPlug;

	[SerializeField]
	private GameObject enginePart;

	[SerializeField]
	private GameObject carBattery;

	[SerializeField]
	private GameObject garageDoorHandle;

	[SerializeField]
	private GameObject gasolineSpot;

	[SerializeField]
	private GameObject gauge;

	[SerializeField]
	private GameObject carKey;

	[SerializeField]
	private GameObject headlights;

	[SerializeField]
	private GameObject sparkPlugFake;

	[SerializeField]
	private Transform fuelTankCover;

	[SerializeField]
	private Transform distPoint;

	[SerializeField]
	private Animation garageDoor;

	[SerializeField]
	private Animation head;

	[SerializeField]
	private AudioSource garageDoorSound;

	[SerializeField]
	private AudioSource garageDoorLockedSound;

	[SerializeField]
	private AudioSource pouring;

	[SerializeField]
	private AudioSource engine;

	[SerializeField]
	private AudioSource driveForward;

	[SerializeField]
	private AudioSource driveBack;

	[SerializeField]
	private AudioSource escape;

	[SerializeField]
	private Image bar;

	[SerializeField]
	private TextMeshProUGUI carText;

	[SerializeField]
	private AudioClip engineOn;

	[SerializeField]
	private AudioClip engineOff;

	[SerializeField]
	private AudioClip frontCrash;

	[SerializeField]
	private AudioClip frontCrashDoor;

	[SerializeField]
	private AudioClip backCrash;

	[SerializeField]
	private Animation car;

	[SerializeField]
	private Renderer carMesh;

	[SerializeField]
	private Renderer plywoodWall;

	[SerializeField]
	private Texture plywoodWallWeak;

	[SerializeField]
	private Texture plywoodWallBreaking;

	[SerializeField]
	private Rigidbody trunk;

	[SerializeField]
	private FurnitureDoor hood;

	[SerializeField]
	private ParticleSystem dust;

	[SerializeField]
	private PuzzleGeneric[] screwObjs;

	private int screws;

	private int damage;

	private float fuel;

	private bool garageDoorUnlocked;

	private bool garageDoorOpen;

	private bool coverSlid;

	private bool running;

	private bool moved;

	private bool backed;

	private bool gameOver;

	private Vector3 startPos;

	private Quaternion startRot;

	public static CarRepair Instance { get; private set; }

	public static bool CanScrew { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public void Screw(Transform screw)
	{
	}

	public void OpenGarageDoor()
	{
	}

	public void UnlockGarageDoor()
	{
	}

	public void Pour()
	{
	}

	public void Release()
	{
	}

	public void TryStart()
	{
	}

	public void FuelHUDOn()
	{
	}

	public void FuelHUDOff()
	{
	}

	public void UseCarDoor()
	{
	}

	public void StartCar()
	{
	}

	private void StopCar()
	{
	}

	private void CarLights()
	{
	}

	private void RefreshText()
	{
	}

	public static bool IsRunning()
	{
		return false;
	}

	public static bool IsMoving()
	{
		return false;
	}

	private void Drive()
	{
	}

	public void FrontCrash()
	{
	}

	public void BackCrash()
	{
	}

	public bool CanLeaveCar()
	{
		return false;
	}

	public void ForceFixCar()
	{
	}
}
