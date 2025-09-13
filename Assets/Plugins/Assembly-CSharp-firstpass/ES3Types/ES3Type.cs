using System;
using System.ComponentModel;
using ES3Internal;
using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class ES3Type
	{
		public const string typeFieldName = "__type";

		public ES3Member[] members;

		public Type type;

		public bool isPrimitive;

		public bool isValueType;

		public bool isCollection;

		public bool isDictionary;

		public bool isTuple;

		public bool isEnum;

		public bool isES3TypeUnityObject;

		public bool isReflectedType;

		public bool isUnsupported;

		public int priority;

		protected ES3Type(Type type)
		{
		}

		public abstract void Write(object obj, ES3Writer writer);

		public abstract object Read<T>(ES3Reader reader);

		public virtual void ReadInto<T>(ES3Reader reader, object obj)
		{
		}

		protected bool WriteUsingDerivedType(object obj, ES3Writer writer)
		{
			return false;
		}

		protected void ReadUsingDerivedType<T>(ES3Reader reader, object obj)
		{
		}

		internal string ReadPropertyName(ES3Reader reader)
		{
			return null;
		}

		protected void WriteProperties(object obj, ES3Writer writer)
		{
		}

		protected object ReadProperties(ES3Reader reader, object obj)
		{
			return null;
		}

		protected void GetMembers(bool safe)
		{
		}

		protected void GetMembers(bool safe, string[] memberNames)
		{
		}
	}
}
