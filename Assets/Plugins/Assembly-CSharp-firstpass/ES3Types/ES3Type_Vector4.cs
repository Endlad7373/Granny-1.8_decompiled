using UnityEngine;
using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "x", "y", "z", "w" })]
	public class ES3Type_Vector4 : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_Vector4()
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

		public static bool Equals(Vector4 a, Vector4 b)
		{
			return false;
		}
	}
}
