using System;

namespace ES3Internal
{
	public class ES3Member
	{
		public string name;

		public Type type;

		public bool isProperty;

		public ES3Reflection.ES3ReflectedMember reflectedMember;

		public bool useReflection;

		public ES3Member(string name, Type type, bool isProperty)
		{
		}

		public ES3Member(ES3Reflection.ES3ReflectedMember reflectedMember)
		{
		}
	}
}
