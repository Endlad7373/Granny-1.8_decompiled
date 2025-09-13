using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "localPosition", "localRotation", "localScale", "parent", "siblingIndex" })]
	public class ES3Type_Transform : ES3ComponentType
	{
		public static int countRead;

		public static ES3Type Instance;

		public ES3Type_Transform()
			: base(null)
		{
		}

		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
}
