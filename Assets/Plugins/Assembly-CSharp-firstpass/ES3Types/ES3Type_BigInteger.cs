using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[] { "bytes" })]
	[Preserve]
	public class ES3Type_BigInteger : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_BigInteger()
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
