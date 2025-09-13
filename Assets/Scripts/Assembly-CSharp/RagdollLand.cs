using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Collider))]
public class RagdollLand : MonoBehaviour
{
	[SerializeField]
	[Tooltip("0 - Normal\n1 - Grass\n2 - Water")]
	private AudioClip[] noises;

	private AudioSource audio;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
