using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Renderer))]
public class AdjustMaterialBrightness : MonoBehaviour
{
	[SerializeField]
	[Range(0f, 1f)]
	private float[] brightness;

	protected Renderer rend;

	private Color[] colors;

	private Color itemBlack;

	private void Awake()
	{
	}

	protected void Init()
	{
	}

	public virtual void RefreshBrightness(bool inDark)
	{
	}

	public void IsHandheldItem()
	{
	}
}
