using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
public class PlankFall : MonoBehaviour
{
	[SerializeField]
	private Transform spot;

	[SerializeField]
	private float force;

	public void Push()
	{
	}
}
