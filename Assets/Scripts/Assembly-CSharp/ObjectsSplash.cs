using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
public class ObjectsSplash : MonoBehaviour
{
	[SerializeField]
	private AudioClip splash;

	[SerializeField]
	private LayerMask layers;

	private void OnTriggerEnter(Collider other)
	{
	}
}
