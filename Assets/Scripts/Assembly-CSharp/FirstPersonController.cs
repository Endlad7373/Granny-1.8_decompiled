using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[DisallowMultipleComponent]
public class FirstPersonController : MonoBehaviour
{
	public bool noControl;

	public bool stuckInTrap;

	public bool isOutOfBounds;

	[SerializeField]
	private Transform cameraPivot;

	[SerializeField]
	private Transform cameraHolder;

	public Transform lookAt;

	public Transform lookTowards;

	[SerializeField]
	[Header("Speeds")]
	private float forwardSpeed;

	[SerializeField]
	private float sidestepSpeed;

	[SerializeField]
	private float backwardSpeed;

	[SerializeField]
	private float crawlSpeed;

	[SerializeField]
	private float gravityMult;

	[SerializeField]
	private float inAirMult;

	[Header("Measurements")]
	[SerializeField]
	private float standHeight;

	[SerializeField]
	private float crouchHeight;

	[SerializeField]
	private Vector3 standCenter;

	[SerializeField]
	private Vector3 crouchCenter;

	[SerializeField]
	private float camStandHeight;

	[SerializeField]
	private float camCrouchHeight;

	[Header("Miscellaneous")]
	[SerializeField]
	[Tooltip("Prevent the player from standing up if their head is blocked by these layers")]
	private LayerMask ceilingLayers;

	[SerializeField]
	private Transform elevator;

	[Header("Animations")]
	[SerializeField]
	private Animation camAnim;

	[SerializeField]
	private Animation camShakeAnim;

	[SerializeField]
	private AnimationCurve bobSpeed;

	[SerializeField]
	private string[] bobAnims;

	[Header("Audio")]
	[SerializeField]
	private AudioSource fallingWind;

	[SerializeField]
	private AudioSource landHard;

	[SerializeField]
	private AudioClip crouchDown;

	[SerializeField]
	private AudioClip standUp;

	[SerializeField]
	private AudioClip land;

	[SerializeField]
	private AudioClip landDeath;

	[SerializeField]
	private AudioClip waterSplash;

	public bool dead;

	public bool frozen;

	public bool stumbled;

	private CharacterController controller;

	public float pivotX;

	public float mouseSens;

	public float timeInAir;

	public float elevatorPos;

	public float inElevator;

	private Vector2 input;

	private Vector3 moveDir;

	private bool crouching;

	private bool crouchAnimating;

	private bool autoCrouch;

	private bool queueCrouch;

	private bool fallWillKill;

	private bool fellIntoWater;

	private bool fallDamage;

	private bool stoodFromFall;

	private bool rawInput;

	private int bobAnim;

	private CreakingFloor landCreak;

	private Sequence crouch;

	private Sequence stand;

	public static FirstPersonController Instance { get; private set; }

	private void Awake()
	{
	}

	private void InitializeSequences()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	private void Crouch(bool force = false)
	{
	}

	public float GetPlayerFeet()
	{
		return 0f;
	}

	private bool IsCeilingAbove()
	{
		return false;
	}

	public void ForceFall(bool kill)
	{
	}

	public void LandDead()
	{
	}

	public void LandHard()
	{
	}

	public void Limp()
	{
	}

	public void QueueCrouch()
	{
	}

	public void HitWater()
	{
	}

	public void ElevatorStay()
	{
	}

	public void Hurt()
	{
	}

	public void ResetMouse()
	{
	}

	private void IdleAnimation()
	{
	}

	private void OnDisable()
	{
	}

	public void WillCreakOnLand(CreakingFloor creak)
	{
	}

	public void Shoot()
	{
	}

	public bool IsInElevator()
	{
		return false;
	}

	public bool IsFalling()
	{
		return false;
	}

	public bool IsCrouching()
	{
		return false;
	}

	public void Uncrouch(bool force = false)
	{
	}

	public void ResetAirTime()
	{
	}

	public bool CanGetTrapped(float testHeight)
	{
		return false;
	}

	public bool FellOver()
	{
		return false;
	}

	public bool IsCeilingAboveSimple()
	{
		return false;
	}
}
