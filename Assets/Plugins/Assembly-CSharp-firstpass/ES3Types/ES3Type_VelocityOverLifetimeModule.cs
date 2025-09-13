using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "enabled", "x", "y", "z", "xMultiplier", "yMultiplier", "zMultiplier", "space" })]
	public class ES3Type_VelocityOverLifetimeModule : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_VelocityOverLifetimeModule()
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

		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
