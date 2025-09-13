using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[] { "mode", "curveMultiplier", "curveMax", "curveMin", "constantMax", "constantMin", "constant", "curve" })]
	[Preserve]
	public class ES3Type_MinMaxCurve : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_MinMaxCurve()
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer)
		{
		}

		[Preserve]
		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		[Preserve]
		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
