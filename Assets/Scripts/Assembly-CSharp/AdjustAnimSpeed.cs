using UnityEngine;

[RequireComponent(typeof(Animation))]
public class AdjustAnimSpeed : MonoBehaviour
{
	[SerializeField]
	private string anim;

	[SerializeField]
	private float mult;

	private void Awake()
	{
	}
}
