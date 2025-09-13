using UnityEngine;

public class PepperSpray : MonoBehaviour
{
	private static PepperSpray instance;

	[SerializeField]
	private int doses;

	[SerializeField]
	private ParticleSystem spray;

	[SerializeField]
	private AudioSource spraySound;

	[SerializeField]
	private SprayHit hitter;

	private bool spraying;

	private void Awake()
	{
	}

	public void SprayPepper()
	{
	}

	public static bool IsNotEmpty()
	{
		return false;
	}
}
