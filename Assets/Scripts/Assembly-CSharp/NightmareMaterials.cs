using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Renderer))]
public class NightmareMaterials : MonoBehaviour
{
	[SerializeField]
	private Material[] nightmareMaterials;

	private void Start()
	{
	}
}
