using System;
using UnityEngine;
using UnityEngine.AI;
using com.ootii.Actors.BoneControllers;

[DisallowMultipleComponent]
[RequireComponent(typeof(NavMeshAgent))]
public abstract class EnemyAI : MonoBehaviour
{
	[Serializable]
	protected struct SightData
	{
		public float sightRangeMax;

		public float sightRange;

		public float sightRangeMin;

		public float sightAngleMax;

		public float sightAngleMin;
	}

	[Header("Sight")]
	[SerializeField]
	protected Camera eyes;

	[SerializeField]
	protected Transform sightTarget;

	[SerializeField]
	protected Transform bumpTarget;

	[SerializeField]
	protected Transform doorRay;

	[SerializeField]
	protected LayerMask sightLayers;

	[SerializeField]
	protected LayerMask attackLayers;

	[SerializeField]
	protected LayerMask bumpLayers;

	[SerializeField]
	protected LayerMask pepperLayers;

	[SerializeField]
	protected LayerMask doorLayers;

	[SerializeField]
	protected SightData[] sightData;

	[SerializeField]
	[Header("Navigation")]
	protected Transform[] waypoints;

	[SerializeField]
	protected Transform chaseTarget;

	[SerializeField]
	protected Transform garageVent;

	[SerializeField]
	protected Transform oldHouseVent;

	[SerializeField]
	protected Transform prisonCell;

	[SerializeField]
	protected Transform saunaDoor;

	[SerializeField]
	protected Transform specialWaypoint;

	[SerializeField]
	protected float specialWeight;

	[SerializeField]
	protected float specialDistance;

	[SerializeField]
	protected float chaseDistance;

	[SerializeField]
	protected float saunaDistance;

	[SerializeField]
	protected float bedDistance;

	[Header("Values")]
	[SerializeField]
	protected float[] runSpeeds;

	[SerializeField]
	protected float[] angularSpeeds;

	[SerializeField]
	protected float[] memoryTimes;

	[SerializeField]
	protected float[] classicRunSpeeds;

	[SerializeField]
	protected float[] classicAngularSpeeds;

	[SerializeField]
	protected float classicWalkSpeed;

	[SerializeField]
	[Header("Animation")]
	protected Animation anim;

	[SerializeField]
	protected AudioSource voice;

	[SerializeField]
	protected string idleAnim;

	[SerializeField]
	protected string searchAnim;

	[SerializeField]
	protected string walkAnim;

	[SerializeField]
	protected string freezeAnim;

	[SerializeField]
	protected string pepperAnim;

	[SerializeField]
	protected string underAnim;

	[SerializeField]
	protected Transform lookTarget;

	[SerializeField]
	protected Transform lookDefault;

	[SerializeField]
	protected Transform pushSource;

	[SerializeField]
	protected Transform eyeLevelUnder;

	[SerializeField]
	protected EnemyRagdoll ragdoll;

	[SerializeField]
	protected EnemyRagdoll freezedoll;

	[Header("Audio")]
	[SerializeField]
	protected AudioClip[] voiceClips;

	[Header("Audio")]
	[SerializeField]
	protected AudioClip[] laughs;

	[SerializeField]
	protected AudioClip findUnderBed;

	protected NavMeshAgent nav;

	protected float walkSpeed;

	protected float runSpeed;

	protected float angularSpeed;

	protected float atWaypointTimer;

	protected float chaseTimer;

	protected float howLongFollow;

	protected float stoppingDistance;

	protected float blindTimer;

	protected float insideSauna;

	protected float saunaTimer;

	protected float sweatTimer;

	protected float doorTimer;

	protected float acceleration;

	protected float doorUnlockMemory;

	protected float hidingSpotTimer;

	protected int lastWaypoint;

	protected BoneController lookAt;

	protected Transform target;

	protected bool inactive;

	protected bool heard;

	protected bool isAnimating;

	protected bool seenPlayer;

	protected bool blind;

	protected bool wasAngry;

	protected bool forceHear;

	protected bool playerTooClose;

	protected bool bumpedPlayer;

	protected bool playerInLineOfSight;

	protected bool killed;

	protected bool hitByPepper;

	protected bool atSaunaDoor;

	protected bool sawHide;

	protected bool heardNoiseDuringChase;

	protected bool sceneRunning;

	protected bool attacking;

	protected bool nearTable;

	protected SightData sightStats;

	protected DoorGeneric door;

	protected Vector3 lastNoiseDuringChase;

	private float shakeDoorTime;

	private float unlockDoorTime;

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void LateUpdate()
	{
	}

	private void SetSpeed(float speed)
	{
	}

	protected virtual void Respawn(bool start = false)
	{
	}

	protected virtual void NewNav()
	{
	}

	public virtual void Hear(Vector3 testPos)
	{
	}

	protected virtual void SearchOver()
	{
	}

	protected abstract void SpecialWaypointAction();

	protected virtual float WaitAtTargetTime()
	{
		return 0f;
	}

	public void EndDay()
	{
	}

	public void StartDay()
	{
	}

	protected virtual void ResetEnemyState()
	{
	}

	public void Deactivate()
	{
	}

	protected abstract bool IsAngry();

	public bool IsAlive()
	{
		return false;
	}

	public bool PlayChaseMusic()
	{
		return false;
	}

	private void OnDisable()
	{
	}

	protected virtual bool TempPauseWalk()
	{
		return false;
	}

	protected virtual void SeePlayer()
	{
	}

	protected virtual void LostPlayer()
	{
	}

	public virtual void Blind(bool blinded)
	{
	}

	public void TeddyDelivered()
	{
	}

	public void StopAtPlanks()
	{
	}

	public void StopGoingToPrison()
	{
	}

	protected virtual void Attack(bool under = false)
	{
	}

	protected virtual bool ForceNotStare()
	{
		return false;
	}

	protected virtual float HowLongFollow()
	{
		return 0f;
	}

	public void TooClose(bool close)
	{
	}

	protected virtual bool ForceStare()
	{
		return false;
	}

	protected virtual void ExtraUpdate()
	{
	}

	public virtual void Tranquilize()
	{
	}

	protected virtual EnemyRagdoll Ragdoll(bool more, bool freeze = false)
	{
		return null;
	}

	public void GoneTimerOver()
	{
	}

	public virtual void Freeze()
	{
	}

	protected abstract void CallToBody();

	public virtual bool PepperHit()
	{
		return false;
	}

	public virtual void HeavyHit(bool push = false)
	{
	}

	protected bool TrappedInSauna()
	{
		return false;
	}

	public void InsideSauna()
	{
	}

	public bool IsInSauna()
	{
		return false;
	}

	protected bool LookingAtDoor()
	{
		return false;
	}

	public void AppearInCutscene()
	{
	}

	public void PlayerHide(bool hiding)
	{
	}

	protected virtual bool ExtraLostCheck()
	{
		return false;
	}

	public void StandNearTable(bool near)
	{
	}
}
