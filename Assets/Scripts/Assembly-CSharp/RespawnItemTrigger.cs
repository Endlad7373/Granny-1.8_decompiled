using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
public class RespawnItemTrigger : MonoBehaviour
{
	[SerializeField]
	private Transform respawnPos;

	[SerializeField]
	private string[] filter;

	private void OnTriggerEnter(Collider other)
	{
	}
}
