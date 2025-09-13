using UnityEngine;

[DisallowMultipleComponent]
public class GateCrank : MonoBehaviour
{
	[SerializeField]
	private Transform gate;

	[SerializeField]
	private Transform wheelCrank;

	[SerializeField]
	private float gateRaised;

	[SerializeField]
	private float crankTime;

	[SerializeField]
	private Vector3 crankAngle;

	public void CrankGate()
	{
	}
}
