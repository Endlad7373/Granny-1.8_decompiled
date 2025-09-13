using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "filterMode", "anisoLevel", "wrapMode", "mipMapBias", "rawTextureData" })]
	public class ES3Type_Texture : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_Texture()
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer)
		{
		}

		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
}
