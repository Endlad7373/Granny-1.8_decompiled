using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	public class ES3Type_byteArray : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_byteArray()
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
