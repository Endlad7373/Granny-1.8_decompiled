using UnityEngine;
using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "filterMode", "anisoLevel", "wrapMode", "mipMapBias", "rawTextureData" })]
	public class ES3Type_Texture2D : ES3UnityObjectType
	{
		public static ES3Type Instance;

		public ES3Type_Texture2D()
			: base(null)
		{
		}

		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		protected bool IsReadable(Texture2D instance)
		{
			return false;
		}
	}
}
