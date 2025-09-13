using UnityEngine;
using UnityEngine.AI;
using com.ootii.Actors.BoneControllers;

[DisallowMultipleComponent]
[RequireComponent(typeof(NavMeshAgent))]
public class MomSpider : MonoBehaviour
{
	private enum State
	{
		Idle = 0,
		Meet = 1,
		Roam = 2,
		Chase = 3,
		Attack = 4,
		Stunned = 5
	}

	[Header("Model")]
	[SerializeField]
	private Animation anim;

	[Header("Values")]
	[SerializeField]
	private float[] chaseSpeeds;

	[SerializeField]
	[Header("Values")]
	private float[] sightRanges;

	[SerializeField]
	private float startSpeed;

	[SerializeField]
	private float waitTime;

	[SerializeField]
	private float chaseTime;

	[SerializeField]
	[Header("Audio")]
	private AnimationCurve footfallRolloff;

	[SerializeField]
	private AudioSource footsteps;

	[SerializeField]
	private AudioSource breathing;

	[SerializeField]
	private AudioSource screaming;

	[SerializeField]
	private AudioClip hurt;

	[SerializeField]
	private AudioClip killMusic;

	[Header("Sight")]
	[SerializeField]
	private Camera eyes;

	[SerializeField]
	private LayerMask sightLayers;

	[SerializeField]
	private LayerMask attackLayers;

	[SerializeField]
	private LayerMask floorLayers;

	[Header("World Points")]
	[SerializeField]
	private Transform[] waypoints;

	[SerializeField]
	private Transform playerPos;

	[SerializeField]
	private Transform chaseTarget;

	[SerializeField]
	private Transform sightTarget;

	[SerializeField]
	private Transform headHolder;

	[SerializeField]
	private Transform lookAt;

	[SerializeField]
	private Transform mouth;

	[SerializeField]
	private Transform endingSpot;

	[SerializeField]
	private Transform lookOutTunnel;

	[SerializeField]
	private Transform waypointBeyondGate;

	[SerializeField]
	private Transform waypointOtherRamp;

	[SerializeField]
	private GameObject gateCarve;

	[SerializeField]
	private Renderer body;

	[SerializeField]
	private Texture[] bodyTex;

	private State state;

	private NavMeshAgent nav;

	private BoneController headTilt;

	private Transform target;

	private float wanderSpeed;

	private float timeAtDest;

	private float chaseSpeed;

	private float sightRange;

	private float chaseTimer;

	private float playerSafeCooldown;

	private float hearSpeed;

	private int lastWaypoint;

	private bool isActive;

	private bool hasSeenOrScreamed;

	private bool refreshWhileSafe;

	private Vector3 defaultTarget;

	public static MomSpider Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	private void MECLateUpdate()
	{
	}

	public void Activate()
	{
	}

	public void PlayerLeaveSpiderCellar()
	{
	}

	private bool OnASlope()
	{
		return false;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void StartChase(bool scream = true)
	{
	}

	private void EndChase()
	{
	}

	private void NewWaypoint()
	{
	}

	private void ToggleActive(bool active)
	{
	}

	public void PlayerStaySafe()
	{
	}

	private void AdjustSpeed(float speed)
	{
	}

	private void Attack()
	{
	}

	public void ResetAfterAttack()
	{
	}

	public void Hurt()
	{
	}

	public void Escape()
	{
	}

	public bool PlayChaseMusic()
	{
		return false;
	}

	public void RefreshSightRange()
	{
	}

	private void FinalizeAudioCues()
	{
	}

	public void BreathFade()
	{
	}

	public void Hear(Vector3 pos)
	{
	}

	private void RefreshBodyTexture()
	{
	}

	public void RefreshWhileSafe(bool forceRefresh)
	{
	}
}
