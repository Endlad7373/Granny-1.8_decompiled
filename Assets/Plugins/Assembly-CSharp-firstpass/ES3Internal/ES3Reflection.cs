using System;
using System.Collections.Generic;
using System.Reflection;

namespace ES3Internal
{
	public static class ES3Reflection
	{
		public struct ES3ReflectedMember
		{
			private FieldInfo fieldInfo;

			private PropertyInfo propertyInfo;

			public bool isProperty;

			public bool IsNull => false;

			public string Name => null;

			public Type MemberType => null;

			public bool IsPublic => false;

			public bool IsProtected => false;

			public bool IsStatic => false;

			public ES3ReflectedMember(object fieldPropertyInfo)
			{
				fieldInfo = null;
				propertyInfo = null;
				isProperty = false;
			}

			public void SetValue(object obj, object value)
			{
			}

			public object GetValue(object obj)
			{
				return null;
			}
		}

		public class ES3ReflectedMethod
		{
			private MethodInfo method;

			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
			{
			}

			public ES3ReflectedMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes, BindingFlags bindingAttr)
			{
			}

			public object Invoke(object obj, object[] parameters = null)
			{
				return null;
			}
		}

		public const string memberFieldPrefix = "m_";

		public const string componentTagFieldName = "tag";

		public const string componentNameFieldName = "name";

		public static readonly string[] excludedPropertyNames;

		public static readonly Type serializableAttributeType;

		public static readonly Type serializeFieldAttributeType;

		public static readonly Type obsoleteAttributeType;

		public static readonly Type nonSerializedAttributeType;

		public static readonly Type es3SerializableAttributeType;

		public static readonly Type es3NonSerializableAttributeType;

		public static Type[] EmptyTypes;

		private static Assembly[] _assemblies;

		private static Assembly[] Assemblies => null;

		public static Type[] GetElementTypes(Type type)
		{
			return null;
		}

		public static List<FieldInfo> GetSerializableFields(Type type, List<FieldInfo> serializableFields = null, bool safe = true, string[] memberNames = null, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		public static List<PropertyInfo> GetSerializableProperties(Type type, List<PropertyInfo> serializableProperties = null, bool safe = true, string[] memberNames = null, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
		{
			return null;
		}

		public static bool TypeIsSerializable(Type type)
		{
			return false;
		}

		public static object CreateInstance(Type type)
		{
			return null;
		}

		public static object CreateInstance(Type type, params object[] args)
		{
			return null;
		}

		public static Array ArrayCreateInstance(Type type, int length)
		{
			return null;
		}

		public static Array ArrayCreateInstance(Type type, int[] dimensions)
		{
			return null;
		}

		public static Type MakeGenericType(Type type, Type genericParam)
		{
			return null;
		}

		public static ES3ReflectedMember[] GetSerializableMembers(Type type, bool safe = true, string[] memberNames = null)
		{
			return null;
		}

		public static ES3ReflectedMember GetES3ReflectedProperty(Type type, string propertyName)
		{
			return default(ES3ReflectedMember);
		}

		public static ES3ReflectedMember GetES3ReflectedMember(Type type, string fieldName)
		{
			return default(ES3ReflectedMember);
		}

		public static IList<T> GetInstances<T>()
		{
			return null;
		}

		public static IList<Type> GetDerivedTypes(Type derivedType)
		{
			return null;
		}

		public static bool IsAssignableFrom(Type a, Type b)
		{
			return false;
		}

		public static Type GetGenericTypeDefinition(Type type)
		{
			return null;
		}

		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		public static int GetArrayRank(Type type)
		{
			return 0;
		}

		public static string GetAssemblyQualifiedName(Type type)
		{
			return null;
		}

		public static ES3ReflectedMethod GetMethod(Type type, string methodName, Type[] genericParameters, Type[] parameterTypes)
		{
			return null;
		}

		public static bool TypeIsArray(Type type)
		{
			return false;
		}

		public static Type GetElementType(Type type)
		{
			return null;
		}

		public static bool IsAbstract(Type type)
		{
			return false;
		}

		public static bool IsInterface(Type type)
		{
			return false;
		}

		public static bool IsGenericType(Type type)
		{
			return false;
		}

		public static bool IsValueType(Type type)
		{
			return false;
		}

		public static bool IsEnum(Type type)
		{
			return false;
		}

		public static bool HasParameterlessConstructor(Type type)
		{
			return false;
		}

		public static ConstructorInfo GetParameterlessConstructor(Type type)
		{
			return null;
		}

		public static string GetShortAssemblyQualifiedName(Type type)
		{
			return null;
		}

		public static PropertyInfo GetProperty(Type type, string propertyName)
		{
			return null;
		}

		public static FieldInfo GetField(Type type, string fieldName)
		{
			return null;
		}

		public static MethodInfo[] GetMethods(Type type, string methodName)
		{
			return null;
		}

		public static bool IsPrimitive(Type type)
		{
			return false;
		}

		public static bool AttributeIsDefined(MemberInfo info, Type attributeType)
		{
			return false;
		}

		public static bool AttributeIsDefined(Type type, Type attributeType)
		{
			return false;
		}

		public static bool ImplementsInterface(Type type, Type interfaceType)
		{
			return false;
		}

		public static Type BaseType(Type type)
		{
			return null;
		}

		public static Type GetType(string typeString)
		{
			return null;
		}

		public static string GetTypeString(Type type)
		{
			return null;
		}
	}
}
