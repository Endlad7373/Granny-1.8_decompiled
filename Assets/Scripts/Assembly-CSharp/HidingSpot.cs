using UnityEngine;

public class HidingSpot : MonoBehaviour
{
	public Sprite hideIn;

	public Sprite hideOut;

	public bool attackUnder;

	public Transform cam;

	public Transform leavePt;

	public Transform lid;

	public AudioClip getIn;

	public AudioClip getOut;

	[SerializeField]
	private float startX;

	[SerializeField]
	private float delay;

	[SerializeField]
	private float lidOpen;

	[SerializeField]
	private float lidClosed;

	[SerializeField]
	private float lidTime;

	private bool usable;

	private bool caught;

	private Vector3 stare;

	private float camX;

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public bool IsUsable()
	{
		return false;
	}

	public void Use()
	{
	}

	public void EnemyFound(Vector3 enemyPos)
	{
	}

	public void ForceLeave()
	{
	}
}
