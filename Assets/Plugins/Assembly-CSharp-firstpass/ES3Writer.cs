using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using ES3Types;
using UnityEngine;

public abstract class ES3Writer : IDisposable
{
	public ES3Settings settings;

	protected HashSet<string> keysToDelete;

	internal bool writeHeaderAndFooter;

	internal bool overwriteKeys;

	protected int serializationDepth;

	internal abstract void WriteNull();

	internal virtual void StartWriteFile()
	{
	}

	internal virtual void EndWriteFile()
	{
	}

	internal virtual void StartWriteObject(string name)
	{
	}

	internal virtual void EndWriteObject(string name)
	{
	}

	internal virtual void StartWriteProperty(string name)
	{
	}

	internal virtual void EndWriteProperty(string name)
	{
	}

	internal virtual void StartWriteCollection()
	{
	}

	internal virtual void EndWriteCollection()
	{
	}

	internal abstract void StartWriteCollectionItem(int index);

	internal abstract void EndWriteCollectionItem(int index);

	internal abstract void StartWriteDictionary();

	internal abstract void EndWriteDictionary();

	internal abstract void StartWriteDictionaryKey(int index);

	internal abstract void EndWriteDictionaryKey(int index);

	internal abstract void StartWriteDictionaryValue(int index);

	internal abstract void EndWriteDictionaryValue(int index);

	public abstract void Dispose();

	internal abstract void WriteRawProperty(string name, byte[] bytes);

	internal abstract void WritePrimitive(int value);

	internal abstract void WritePrimitive(float value);

	internal abstract void WritePrimitive(bool value);

	internal abstract void WritePrimitive(decimal value);

	internal abstract void WritePrimitive(double value);

	internal abstract void WritePrimitive(long value);

	internal abstract void WritePrimitive(ulong value);

	internal abstract void WritePrimitive(uint value);

	internal abstract void WritePrimitive(byte value);

	internal abstract void WritePrimitive(sbyte value);

	internal abstract void WritePrimitive(short value);

	internal abstract void WritePrimitive(ushort value);

	internal abstract void WritePrimitive(char value);

	internal abstract void WritePrimitive(string value);

	internal abstract void WritePrimitive(byte[] value);

	protected ES3Writer(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
	}

	internal virtual void Write(string key, Type type, byte[] value)
	{
	}

	public virtual void Write<T>(string key, object value)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Write(Type type, string key, object value)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Write(object value, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void Write(object value, ES3Type type, ES3.ReferenceMode memberReferenceMode = ES3.ReferenceMode.ByRef)
	{
	}

	internal virtual void WriteRef(UnityEngine.Object obj)
	{
	}

	public virtual void WriteProperty(string name, object value)
	{
	}

	public virtual void WriteProperty(string name, object value, ES3.ReferenceMode memberReferenceMode)
	{
	}

	public virtual void WriteProperty<T>(string name, object value)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void WriteProperty(string name, object value, ES3Type type)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void WriteProperty(string name, object value, ES3Type type, ES3.ReferenceMode memberReferenceMode)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void WritePropertyByRef(string name, UnityEngine.Object value)
	{
	}

	public void WritePrivateProperty(string name, object objectContainingProperty)
	{
	}

	public void WritePrivateField(string name, object objectContainingField)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivateProperty(string name, object objectContainingProperty, ES3Type type)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivateField(string name, object objectContainingField, ES3Type type)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivatePropertyByRef(string name, object objectContainingProperty)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WritePrivateFieldByRef(string name, object objectContainingField)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void WriteType(Type type)
	{
	}

	public static ES3Writer Create(string filePath, ES3Settings settings)
	{
		return null;
	}

	public static ES3Writer Create(ES3Settings settings)
	{
		return null;
	}

	internal static ES3Writer Create(ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys, bool append)
	{
		return null;
	}

	internal static ES3Writer Create(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool overwriteKeys)
	{
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected bool SerializationDepthLimitExceeded()
	{
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void MarkKeyForDeletion(string key)
	{
	}

	protected void Merge()
	{
	}

	protected void Merge(ES3Reader reader)
	{
	}

	public virtual void Save()
	{
	}

	public virtual void Save(bool overwriteKeys)
	{
	}
}
