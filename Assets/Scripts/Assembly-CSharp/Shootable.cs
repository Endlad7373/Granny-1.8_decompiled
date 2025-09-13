using UnityEngine;
using UnityEngine.Events;

public class Shootable : MonoBehaviour
{
	[SerializeField]
	private bool withCrossbow;

	[SerializeField]
	private bool withShotgun;

	[SerializeField]
	private bool withGasoline;

	[SerializeField]
	private bool onlyOnce;

	[SerializeField]
	private bool alive;

	[SerializeField]
	private UnityEvent onShot;

	[SerializeField]
	private UnityEvent onCrossbow;

	[SerializeField]
	private UnityEvent onShotgun;

	[SerializeField]
	private UnityEvent onGasoline;

	[SerializeField]
	private UnityEvent onGrandpa;

	public void HitWithCrossbow(bool fresh)
	{
	}

	public bool HitWithShotgun(float dist)
	{
		return false;
	}

	public void HitWithGasoline()
	{
	}

	public void HitWithShotgunGrandpa()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
