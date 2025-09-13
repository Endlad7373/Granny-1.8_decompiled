using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "x", "y", "z" })]
	public class ES3Type_Vector3Int : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_Vector3Int()
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer)
		{
		}

		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
}
