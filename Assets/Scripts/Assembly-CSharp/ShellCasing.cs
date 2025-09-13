using UnityEngine;

[RequireComponent(typeof(Renderer))]
[DisallowMultipleComponent]
public class ShellCasing : MonoBehaviour
{
	[SerializeField]
	private Renderer smoke;

	[SerializeField]
	private AnimationCurve fade;

	private float timeSinceStart;

	private float smokeBrightness;

	private bool cooled;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Cool()
	{
	}
}
