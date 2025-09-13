using System;
using ES3Internal;
using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	public class ES3TupleType : ES3Type
	{
		public ES3Type[] es3Types;

		public Type[] types;

		protected ES3Reflection.ES3ReflectedMethod readMethod;

		protected ES3Reflection.ES3ReflectedMethod readIntoMethod;

		public ES3TupleType(Type type)
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer)
		{
		}

		public void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode)
		{
		}

		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}
	}
}
