using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "alpha", "time" })]
	public class ES3Type_GradientAlphaKey : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_GradientAlphaKey()
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
