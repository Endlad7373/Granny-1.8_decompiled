using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "center", "size" })]
	public class ES3Type_Bounds : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_Bounds()
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
