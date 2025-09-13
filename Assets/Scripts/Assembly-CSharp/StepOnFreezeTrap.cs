using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
public class StepOnFreezeTrap : MonoBehaviour
{
	[SerializeField]
	private FreezeTrap freezeTrap;

	private void OnTriggerEnter(Collider other)
	{
	}
}
