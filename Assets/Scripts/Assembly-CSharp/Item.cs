using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(MaterialBrightnessCoordinator))]
[DisallowMultipleComponent]
public class Item : Interactable
{
	public string itemName;

	[HideInInspector]
	public bool cantGrab;

	[HideInInspector]
	public UnityEvent onGrabFail;

	private void Awake()
	{
	}
}
