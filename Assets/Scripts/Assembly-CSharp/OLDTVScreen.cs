using UnityEngine;

[ExecuteInEditMode]
public class OLDTVScreen : FilterBehavior
{
	public float screenSaturation;

	public Texture chromaticAberrationPattern;

	public float chromaticAberrationMagnetude;

	public Texture noisePattern;

	public float noiseMagnetude;

	public Texture staticPattern;

	public Texture staticMask;

	public float staticVertical;

	public float staticMagnetude;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
