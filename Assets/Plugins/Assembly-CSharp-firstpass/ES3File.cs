using System;
using System.Collections.Generic;
using System.ComponentModel;
using ES3Internal;

public class ES3File
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static Dictionary<string, ES3File> cachedFiles;

	public ES3Settings settings;

	private Dictionary<string, ES3Data> cache;

	private bool syncWithFile;

	private DateTime timestamp;

	public ES3File()
	{
	}

	public ES3File(string filePath)
	{
	}

	public ES3File(string filePath, ES3Settings settings)
	{
	}

	public ES3File(ES3Settings settings)
	{
	}

	public ES3File(bool syncWithFile)
	{
	}

	public ES3File(string filePath, bool syncWithFile)
	{
	}

	public ES3File(string filePath, ES3Settings settings, bool syncWithFile)
	{
	}

	public ES3File(ES3Settings settings, bool syncWithFile)
	{
	}

	public ES3File(byte[] bytes, ES3Settings settings = null)
	{
	}

	public void Sync()
	{
	}

	public void Sync(string filePath, ES3Settings settings = null)
	{
	}

	public void Sync(ES3Settings settings = null)
	{
	}

	public void Clear()
	{
	}

	public string[] GetKeys()
	{
		return null;
	}

	public void Save<T>(string key, T value)
	{
	}

	public void SaveRaw(byte[] bytes, ES3Settings settings = null)
	{
	}

	public void AppendRaw(byte[] bytes, ES3Settings settings = null)
	{
	}

	public object Load(string key)
	{
		return null;
	}

	public object Load(string key, object defaultValue)
	{
		return null;
	}

	public T Load<T>(string key)
	{
		return default(T);
	}

	public T Load<T>(string key, T defaultValue)
	{
		return default(T);
	}

	public void LoadInto<T>(string key, T obj) where T : class
	{
	}

	public byte[] LoadRawBytes()
	{
		return null;
	}

	public string LoadRawString()
	{
		return null;
	}

	internal byte[] GetBytes(ES3Settings settings = null)
	{
		return null;
	}

	public void DeleteKey(string key)
	{
	}

	public bool KeyExists(string key)
	{
		return false;
	}

	public int Size()
	{
		return 0;
	}

	public Type GetKeyType(string key)
	{
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static ES3File GetOrCreateCachedFile(ES3Settings settings)
	{
		return null;
	}

	internal static void CacheFile(ES3Settings settings)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void Store(ES3Settings settings = null)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void RemoveCachedFile(ES3Settings settings)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void CopyCachedFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static void DeleteKey(string key, ES3Settings settings)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static bool KeyExists(string key, ES3Settings settings)
	{
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static bool FileExists(ES3Settings settings)
	{
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	internal static string[] GetFiles()
	{
		return null;
	}

	internal static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}
}
