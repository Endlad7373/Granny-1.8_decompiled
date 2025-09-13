using UnityEngine;

public class GrandpaRagdoll : EnemyRagdoll
{
	public GameObject cane;

	public GameObject shotgun;

	[SerializeField]
	private Transform shotgunPos;

	[SerializeField]
	private GameObject bodyColl;

	private void LateUpdate()
	{
	}

	protected override void Fade()
	{
	}

	public void Frozen()
	{
	}
}
