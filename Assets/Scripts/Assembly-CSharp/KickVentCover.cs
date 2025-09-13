using UnityEngine;

[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
public class KickVentCover : MonoBehaviour
{
	[SerializeField]
	private float pushPower;

	[SerializeField]
	private GameObject landingNoise;

	private bool byPlayer;

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Kick()
	{
	}
}
