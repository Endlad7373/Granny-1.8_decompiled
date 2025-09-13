using UnityEngine;

public class GrannyRagdoll : EnemyRagdoll
{
	[SerializeField]
	private Renderer hair;

	[SerializeField]
	private Shader fader;

	protected override void Fade()
	{
	}
}
