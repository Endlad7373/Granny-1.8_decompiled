using UnityEngine;
using UnityEngine.Events;

public class HoldInteractable : Interactable
{
	public UnityEvent onHold;

	[SerializeField]
	private UnityEvent onRelease;

	public GameObject icon;

	private void Start()
	{
	}

	public void Release(bool disableIcon = true)
	{
	}
}
