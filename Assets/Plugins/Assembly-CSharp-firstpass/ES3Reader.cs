using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using ES3Types;

public abstract class ES3Reader : IDisposable
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ES3ReaderPropertyEnumerator
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ES3ReaderPropertyEnumerator _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public ES3Reader reader;

		public ES3ReaderPropertyEnumerator(ES3Reader reader)
		{
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__2))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ES3ReaderRawEnumerator
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ES3ReaderRawEnumerator _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__2(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public ES3Reader reader;

		public ES3ReaderRawEnumerator(ES3Reader reader)
		{
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__2))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	public ES3Settings settings;

	protected int serializationDepth;

	internal string overridePropertiesName;

	public virtual ES3ReaderPropertyEnumerator Properties => null;

	internal virtual ES3ReaderRawEnumerator RawEnumerator => null;

	internal abstract int Read_int();

	internal abstract float Read_float();

	internal abstract bool Read_bool();

	internal abstract char Read_char();

	internal abstract decimal Read_decimal();

	internal abstract double Read_double();

	internal abstract long Read_long();

	internal abstract ulong Read_ulong();

	internal abstract byte Read_byte();

	internal abstract sbyte Read_sbyte();

	internal abstract short Read_short();

	internal abstract ushort Read_ushort();

	internal abstract uint Read_uint();

	internal abstract string Read_string();

	internal abstract byte[] Read_byteArray();

	internal abstract long Read_ref();

	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract string ReadPropertyName();

	protected abstract Type ReadKeyPrefix(bool ignore = false);

	protected abstract void ReadKeySuffix();

	internal abstract byte[] ReadElement(bool skip = false);

	public abstract void Dispose();

	internal virtual bool Goto(string key)
	{
		return false;
	}

	internal virtual bool StartReadObject()
	{
		return false;
	}

	internal virtual void EndReadObject()
	{
	}

	internal abstract bool StartReadDictionary();

	internal abstract void EndReadDictionary();

	internal abstract bool StartReadDictionaryKey();

	internal abstract void EndReadDictionaryKey();

	internal abstract void StartReadDictionaryValue();

	internal abstract bool EndReadDictionaryValue();

	internal abstract bool StartReadCollection();

	internal abstract void EndReadCollection();

	internal abstract bool StartReadCollectionItem();

	internal abstract bool EndReadCollectionItem();

	internal ES3Reader(ES3Settings settings, bool readHeaderAndFooter = true)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Skip()
	{
	}

	public virtual T Read<T>()
	{
		return default(T);
	}

	public virtual void ReadInto<T>(object obj)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public T ReadProperty<T>()
	{
		return default(T);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public T ReadProperty<T>(ES3Type type)
	{
		return default(T);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public long ReadRefProperty()
	{
		return 0L;
	}

	internal Type ReadType()
	{
		return null;
	}

	public object SetPrivateProperty(string name, object value, object objectContainingProperty)
	{
		return null;
	}

	public object SetPrivateField(string name, object value, object objectContainingField)
	{
		return null;
	}

	public virtual T Read<T>(string key)
	{
		return default(T);
	}

	public virtual T Read<T>(string key, T defaultValue)
	{
		return default(T);
	}

	public virtual void ReadInto<T>(string key, T obj) where T : class
	{
	}

	protected virtual void ReadObject<T>(object obj, ES3Type type)
	{
	}

	protected virtual T ReadObject<T>(ES3Type type)
	{
		return default(T);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual T Read<T>(ES3Type type)
	{
		return default(T);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void ReadInto<T>(object obj, ES3Type type)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal Type ReadTypeFromHeader<T>()
	{
		return null;
	}

	public static ES3Reader Create()
	{
		return null;
	}

	public static ES3Reader Create(string filePath)
	{
		return null;
	}

	public static ES3Reader Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	public static ES3Reader Create(ES3Settings settings)
	{
		return null;
	}

	public static ES3Reader Create(byte[] bytes)
	{
		return null;
	}

	public static ES3Reader Create(byte[] bytes, ES3Settings settings)
	{
		return null;
	}

	internal static ES3Reader Create(Stream stream, ES3Settings settings)
	{
		return null;
	}

	internal static ES3Reader Create(Stream stream, ES3Settings settings, bool readHeaderAndFooter)
	{
		return null;
	}
}
