using UnityEngine;

[DisallowMultipleComponent]
public class EnemyRagdoll : MonoBehaviour
{
	public Rigidbody bone;

	public float timeLeft;

	[SerializeField]
	protected GameObject[] disable;

	[SerializeField]
	private Renderer[] fade;

	[SerializeField]
	private Material fadeMat;

	private bool fading;

	private void Update()
	{
	}

	protected virtual void Fade()
	{
	}
}
