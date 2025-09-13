using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[DisallowMultipleComponent]
public class PushRigidbodies : MonoBehaviour
{
	[SerializeField]
	private float power;

	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}
}
