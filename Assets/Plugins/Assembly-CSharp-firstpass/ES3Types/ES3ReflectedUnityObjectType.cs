using System;
using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	internal class ES3ReflectedUnityObjectType : ES3UnityObjectType
	{
		public ES3ReflectedUnityObjectType(Type type)
			: base(null)
		{
		}

		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
}
