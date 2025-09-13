using System;
using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	public class ES3HashSetType : ES3CollectionType
	{
		public ES3HashSetType(Type type)
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
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
