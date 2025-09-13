using UnityEngine;
using UnityEngine.AI;

public class Sauna : MonoBehaviour
{
	public static Sauna Instance;

	[SerializeField]
	private Animation door;

	[SerializeField]
	private Animation bar;

	[SerializeField]
	private AudioSource doorSfx;

	[SerializeField]
	private AudioSource barSfx;

	[SerializeField]
	private AudioSource leverSfx;

	[SerializeField]
	private AudioClip openDoor;

	[SerializeField]
	private AudioClip closeDoor;

	[SerializeField]
	private AudioClip breakBar;

	[SerializeField]
	private Transform grannyCome;

	[SerializeField]
	private Transform grandpaCome;

	[SerializeField]
	private Rigidbody barPhysics;

	[SerializeField]
	private GameObject barNoise;

	[SerializeField]
	private GameObject box;

	[SerializeField]
	private GameObject steamObj;

	[SerializeField]
	private GameObject hide;

	[SerializeField]
	private GameObject carver;

	[SerializeField]
	private Transform lever;

	[SerializeField]
	private Vector3 rotOn;

	[SerializeField]
	private Vector3 rotOff;

	[SerializeField]
	private ParticleSystem steam;

	[SerializeField]
	private NavMeshObstacle doorCarve;

	private float damage;

	private bool switchOn;

	private bool inGarage;

	private bool doorOpen;

	public bool Locked { get; private set; }

	public bool SteamOn { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	public void Struggle()
	{
	}

	public void UseBar()
	{
	}

	public void UseLever()
	{
	}

	public void PlayerGarageTrigger(bool inside)
	{
	}

	public void Reset()
	{
	}

	public void UseDoor()
	{
	}

	private void ResetBar()
	{
	}

	public bool EnemyStopWaiting()
	{
		return false;
	}
}
