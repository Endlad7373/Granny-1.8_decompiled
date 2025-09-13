using UnityEngine;

[ExecuteInEditMode]
public class cPrecision : MonoBehaviour
{
	private Material material;

	public int colorPrecision;

	public bool usePalette;

	public Texture2D palette;

	private void Awake()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
