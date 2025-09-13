using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[DisallowMultipleComponent]
public class Granny : EnemyAI
{
	[SerializeField]
	[Header("Granny only")]
	private Renderer redEyes;

	[SerializeField]
	private GameObject eyelids;

	[SerializeField]
	private AudioClip scream;

	[SerializeField]
	private ParticleSystem dishesSteam;

	[SerializeField]
	private AudioSource sink;

	[SerializeField]
	private Transform bearTrapPoint;

	[SerializeField]
	private GameObject bearTrap;

	[SerializeField]
	private GameObject organicTrap;

	[SerializeField]
	private LayerMask bearTrapSightMask;

	[SerializeField]
	private LayerMask bearTrapScanMask;

	private bool droppingBeartrap;

	public static Granny Instance { get; private set; }

	protected override void Awake()
	{
	}

	protected override void LateUpdate()
	{
	}

	protected override void Respawn(bool start = false)
	{
	}

	protected override float WaitAtTargetTime()
	{
		return 0f;
	}

	private void WashDishes(bool doing)
	{
	}

	protected override void SpecialWaypointAction()
	{
	}

	protected override void ResetEnemyState()
	{
	}

	protected override bool IsAngry()
	{
		return false;
	}

	protected override void SearchOver()
	{
	}

	private void DropBearTrap()
	{
	}

	protected override bool TempPauseWalk()
	{
		return false;
	}

	public override void Blind(bool blinded)
	{
	}

	protected override bool ForceNotStare()
	{
		return false;
	}

	protected override void Attack(bool under = false)
	{
	}

	protected override EnemyRagdoll Ragdoll(bool more, bool freeze = false)
	{
		return null;
	}

	protected override void CallToBody()
	{
	}
}
