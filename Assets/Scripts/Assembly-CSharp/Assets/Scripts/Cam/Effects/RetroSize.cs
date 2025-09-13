using UnityEngine;

namespace Assets.Scripts.Cam.Effects
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Custom/Retro Size")]
	public class RetroSize : MonoBehaviour
	{
		[Header("Resolution")]
		public int horizontalResolution;

		public int verticalResolution;

		public void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}
	}
}
