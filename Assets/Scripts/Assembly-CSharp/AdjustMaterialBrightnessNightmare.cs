using UnityEngine;

public class AdjustMaterialBrightnessNightmare : AdjustMaterialBrightness
{
	[SerializeField]
	private Material[] nightmareMaterials;

	private bool texSwapped;

	public override void RefreshBrightness(bool inDark)
	{
	}
}
