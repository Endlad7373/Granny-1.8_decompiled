using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[] { "colorKeys", "alphaKeys", "mode" })]
	[Preserve]
	public class ES3Type_LayerMask : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_LayerMask()
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
