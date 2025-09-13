using UnityEngine;

[DisallowMultipleComponent]
public class MaterialBrightnessCoordinator : MonoBehaviour
{
	public bool startDark;

	[SerializeField]
	private AdjustMaterialBrightness[] allRenderers;

	private void Start()
	{
	}

	public void RefreshBrightness(bool inDark)
	{
	}
}
