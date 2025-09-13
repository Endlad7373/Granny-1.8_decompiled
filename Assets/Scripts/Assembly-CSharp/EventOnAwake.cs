using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class EventOnAwake : MonoBehaviour
{
	[SerializeField]
	private UnityEvent onAwake;

	private void Awake()
	{
	}
}
