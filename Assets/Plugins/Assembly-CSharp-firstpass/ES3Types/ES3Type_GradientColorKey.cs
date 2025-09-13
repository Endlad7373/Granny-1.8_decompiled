using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "color", "time" })]
	public class ES3Type_GradientColorKey : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_GradientColorKey()
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
