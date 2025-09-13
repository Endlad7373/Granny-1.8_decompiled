using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	public abstract class ES3CollectionType : ES3Type
	{
		public ES3Type elementType;

		public abstract object Read(ES3Reader reader);

		public abstract void ReadInto(ES3Reader reader, object obj);

		public abstract void Write(object obj, ES3Writer writer, ES3.ReferenceMode memberReferenceMode);

		public ES3CollectionType(Type type)
			: base(null)
		{
		}

		public ES3CollectionType(Type type, ES3Type elementType)
			: base(null)
		{
		}

		[Preserve]
		public override void Write(object obj, ES3Writer writer)
		{
		}

		protected virtual bool ReadICollection<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
			return false;
		}

		protected virtual void ReadICollectionInto<T>(ES3Reader reader, ICollection<T> collection, ES3Type elementType)
		{
		}

		[Preserve]
		protected virtual void ReadICollectionInto(ES3Reader reader, ICollection collection, ES3Type elementType)
		{
		}
	}
}
