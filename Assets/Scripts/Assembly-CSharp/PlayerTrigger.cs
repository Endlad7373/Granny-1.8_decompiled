using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
public class PlayerTrigger : MonoBehaviour
{
	[SerializeField]
	private UnityEvent onTriggered;

	private void OnTriggerEnter(Collider other)
	{
	}

	public void SimulatePlayer(bool disable)
	{
	}
}
