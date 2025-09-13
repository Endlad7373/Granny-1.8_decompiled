using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "center", "size", "enabled", "isTrigger", "contactOffset", "sharedMaterial" })]
	public class ES3Type_BoxCollider : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_BoxCollider()
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
