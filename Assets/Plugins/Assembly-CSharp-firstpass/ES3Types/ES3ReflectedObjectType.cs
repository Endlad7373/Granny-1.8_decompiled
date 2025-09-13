using System;
using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	internal class ES3ReflectedObjectType : ES3ObjectType
	{
		public ES3ReflectedObjectType(Type type)
			: base(null)
		{
		}

		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}
	}
}
