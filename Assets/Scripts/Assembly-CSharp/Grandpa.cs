using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[DisallowMultipleComponent]
public class Grandpa : EnemyAI
{
	[Serializable]
	private struct GunplayData
	{
		public float shootDelay;

		public float shootSpeed;

		public Vector2 inaccuracy;
	}

	[Header("Grandpa only")]
	[SerializeField]
	private GameObject redEyes;

	[SerializeField]
	private AudioClip[] callout;

	[SerializeField]
	private string voiceAlertGranny;

	[SerializeField]
	private GameObject[] canes;

	[SerializeField]
	private GameObject shotgun;

	[SerializeField]
	private GameObject sleepingBody;

	[SerializeField]
	private GameObject sleepingShotgun;

	[SerializeField]
	private GameObject pickUpShotgun;

	[SerializeField]
	private GameObject body;

	[SerializeField]
	private GameObject blindBody;

	[SerializeField]
	private GameObject muzzleSmoke;

	[SerializeField]
	private GameObject impact;

	[SerializeField]
	private GameObject sleepingMesh;

	[SerializeField]
	private AudioSource reloadShotgun;

	[SerializeField]
	private AudioSource shootSound;

	[SerializeField]
	private AudioSource snoring;

	[SerializeField]
	private ParticleSystem sleepingZs;

	[SerializeField]
	private GunplayData[] gunplayData;

	[SerializeField]
	private Material blackEyes;

	[SerializeField]
	private Transform shotgunBarrel;

	[SerializeField]
	private Transform shootAt;

	[SerializeField]
	private Transform gunLight;

	[SerializeField]
	private Transform couchRagdollPos;

	[SerializeField]
	private LayerMask shotCheckLayers;

	[SerializeField]
	private LayerMask bulletLayers;

	[SerializeField]
	private Animation sleepingAnim;

	private GunplayData gunStats;

	private bool sleeping;

	private bool called;

	private bool shooting;

	private bool aiming;

	private float sleepingTimer;

	private float beforeShootTimer;

	private float afterShootTimer;

	private Material eyeMat;

	private Vector3 shootFrom;

	public static Grandpa Instance { get; private set; }

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	protected override void Update()
	{
	}

	protected override void LateUpdate()
	{
	}

	protected override void Respawn(bool start = false)
	{
	}

	public void PickUpShotgun()
	{
	}

	public override void Hear(Vector3 testPos)
	{
	}

	protected override void SearchOver()
	{
	}

	protected override void SpecialWaypointAction()
	{
	}

	private void Sleep(bool sleep)
	{
	}

	public void ShotgunTaken()
	{
	}

	protected override void ResetEnemyState()
	{
	}

	protected override bool IsAngry()
	{
		return false;
	}

	protected override void SeePlayer()
	{
	}

	protected override void LostPlayer()
	{
	}

	public override void Blind(bool blinded)
	{
	}

	protected override void Attack(bool under = false)
	{
	}

	protected override float HowLongFollow()
	{
		return 0f;
	}

	protected override bool ForceStare()
	{
		return false;
	}

	protected override void ExtraUpdate()
	{
	}

	private void Shoot()
	{
	}

	public void Aim(bool aim)
	{
	}

	public void Fire()
	{
	}

	public override void Tranquilize()
	{
	}

	protected override EnemyRagdoll Ragdoll(bool more, bool freeze = false)
	{
		return null;
	}

	protected override void CallToBody()
	{
	}

	protected override bool ExtraLostCheck()
	{
		return false;
	}
}
