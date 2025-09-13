using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu(null)]
public class FilterBehavior : MonoBehaviour
{
	public Shader shader;

	private Material _Material;

	protected Material material => null;

	protected virtual void Start()
	{
	}

	protected virtual void OnDisable()
	{
	}
}
