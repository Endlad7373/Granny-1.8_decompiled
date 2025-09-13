using System;
using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	internal class ES3ReflectedScriptableObjectType : ES3ScriptableObjectType
	{
		public ES3ReflectedScriptableObjectType(Type type)
			: base(null)
		{
		}

		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
		}

		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
		}
	}
}
