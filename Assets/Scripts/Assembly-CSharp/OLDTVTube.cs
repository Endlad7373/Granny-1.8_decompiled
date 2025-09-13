using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class OLDTVTube : FilterBehavior
{
	public delegate void RepaintAction();

	public Texture scanlinePattern;

	public bool scanlineCountAuto;

	public int scanlineCount;

	public float scanlineBrightMin;

	public float scanlineBrightMax;

	public Texture mask;

	public Texture reflex;

	public float reflexMagnetude;

	public float radialDistortion;

	public event RepaintAction WantRepaint
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Repaint()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
