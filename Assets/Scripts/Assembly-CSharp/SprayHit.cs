using UnityEngine;

public class SprayHit : MonoBehaviour
{
	[SerializeField]
	private Bird crow;

	private bool grannyHit;

	private bool grandpaHit;

	private bool crowHit;

	public void Reset()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}
}
