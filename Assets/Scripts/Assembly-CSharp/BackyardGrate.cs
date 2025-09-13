using UnityEngine;

public class BackyardGrate : MonoBehaviour
{
	[SerializeField]
	private TweenGeneric tween;

	[SerializeField]
	private AudioSource slide;

	[SerializeField]
	private BoxCollider coll;

	[SerializeField]
	private PlayAudioNoOverlap rattle;

	public void Use()
	{
	}
}
