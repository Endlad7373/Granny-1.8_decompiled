using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	public class ES3Type_EventSystem : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_EventSystem()
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
