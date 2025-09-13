using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
public class PlayerTriggerStay : MonoBehaviour
{
	[SerializeField]
	private UnityEvent onStay;

	[SerializeField]
	private UnityEvent onLeave;

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
