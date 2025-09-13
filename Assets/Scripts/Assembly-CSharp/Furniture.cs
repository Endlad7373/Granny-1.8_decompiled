using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody))]
public class Furniture : MonoBehaviour
{
	[SerializeField]
	private UnityEvent onReset;

	[SerializeField]
	private Vector3 overridePos;

	[SerializeField]
	private Vector3 overrideRot;

	private Vector3 startPos;

	private Quaternion startRot;

	private bool kinematic;

	private Rigidbody rb;

	private Shootable shootable;

	private void Awake()
	{
	}

	public void Queue()
	{
	}

	public void Respawn()
	{
	}
}
