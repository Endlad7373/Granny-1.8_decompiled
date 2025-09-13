using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[]
	{
		"texture", "uvRect", "onCullStateChanged", "maskable", "color", "raycastTarget", "useLegacyMeshGeneration", "material", "useGUILayout", "enabled",
		"hideFlags"
	})]
	public class ES3Type_RawImage : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_RawImage()
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
