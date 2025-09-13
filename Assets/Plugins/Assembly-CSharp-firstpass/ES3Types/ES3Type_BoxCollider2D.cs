using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[] { "size", "density", "isTrigger", "usedByEffector", "offset", "sharedMaterial", "enabled" })]
	[Preserve]
	public class ES3Type_BoxCollider2D : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_BoxCollider2D()
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
