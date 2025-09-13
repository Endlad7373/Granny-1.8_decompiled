using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class ActiveToggleEvents : MonoBehaviour
{
	[SerializeField]
	private UnityEvent onEnable;

	[SerializeField]
	private UnityEvent onDisable;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
