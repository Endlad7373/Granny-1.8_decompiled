using UnityEngine;

[DisallowMultipleComponent]
public class Freezedoll : EnemyRagdoll
{
	[SerializeField]
	[Header("Ice Stuff")]
	private AudioSource breakSound;

	[SerializeField]
	private Rigidbody[] rbs;

	[SerializeField]
	private GameObject[] colls;

	[SerializeField]
	private Collider bodyColl;

	private bool broken;

	private void Awake()
	{
	}

	protected override void Fade()
	{
	}

	public void Break()
	{
	}
}
