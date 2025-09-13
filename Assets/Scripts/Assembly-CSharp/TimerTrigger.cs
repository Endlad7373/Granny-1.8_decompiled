using UnityEngine;
using UnityEngine.Events;

public class TimerTrigger : MonoBehaviour
{
	[SerializeField]
	private float timer;

	[SerializeField]
	private UnityEvent onTriggered;

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public void FastForwardTo(float time)
	{
	}
}
