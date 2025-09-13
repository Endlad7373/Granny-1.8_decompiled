using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[]
	{
		"additionalVertexStreams", "enabled", "shadowCastingMode", "receiveShadows", "sharedMaterials", "lightmapIndex", "realtimeLightmapIndex", "lightmapScaleOffset", "motionVectorGenerationMode", "realtimeLightmapScaleOffset",
		"lightProbeUsage", "lightProbeProxyVolumeOverride", "probeAnchor", "reflectionProbeUsage", "sortingLayerName", "sortingLayerID", "sortingOrder"
	})]
	public class ES3Type_MeshRenderer : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_MeshRenderer()
			: base(null)
		{
		}

		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
}
