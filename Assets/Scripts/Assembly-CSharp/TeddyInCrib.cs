using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
public class TeddyInCrib : MonoBehaviour
{
	[SerializeField]
	private GameObject crib;

	[SerializeField]
	private Material fadeMat;

	[SerializeField]
	private ParticleSystem glow;

	private GameObject teddy;

	public static bool TeddyDelivered { get; private set; }

	private void Awake()
	{
	}

	public void ShakeCrib()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void DeliverTeddy(GameObject teddyItem)
	{
	}
}
