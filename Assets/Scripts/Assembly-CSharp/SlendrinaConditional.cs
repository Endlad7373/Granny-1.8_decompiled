using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class SlendrinaConditional : MonoBehaviour
{
	[SerializeField]
	private GameObject playhouseKey;

	[SerializeField]
	private UnityEvent noSlendrina;

	[SerializeField]
	private UnityEvent slendrina;

	private void Start()
	{
	}
}
