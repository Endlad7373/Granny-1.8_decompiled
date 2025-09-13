using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
public class EnemyTrigger : MonoBehaviour
{
	[SerializeField]
	private UnityEvent onTriggered;

	[SerializeField]
	private UnityEvent onGranny;

	[SerializeField]
	private UnityEvent onGrandpa;

	private void OnTriggerEnter(Collider other)
	{
	}
}
