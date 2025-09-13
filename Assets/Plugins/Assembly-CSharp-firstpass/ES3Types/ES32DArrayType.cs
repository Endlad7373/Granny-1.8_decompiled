using System;

namespace ES3Types
{
	public class ES32DArrayType : ES3CollectionType
	{
		public ES32DArrayType(Type type)
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode unityObjectType)
		{
		}

		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		public override object Read(ES3Reader reader)
		{
			return null;
		}

		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		public override void ReadInto(ES3Reader reader, object obj)
		{
		}
	}
}
