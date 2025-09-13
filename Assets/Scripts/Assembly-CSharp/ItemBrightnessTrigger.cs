using UnityEngine;

[RequireComponent(typeof(Collider))]
[DisallowMultipleComponent]
public class ItemBrightnessTrigger : MonoBehaviour
{
	[SerializeField]
	private bool dark;

	private void OnTriggerEnter(Collider other)
	{
	}
}
