using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "points", "pathCount", "paths", "density", "isTrigger", "usedByEffector", "offset", "sharedMaterial", "enabled" })]
	public class ES3Type_PolygonCollider2D : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_PolygonCollider2D()
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
