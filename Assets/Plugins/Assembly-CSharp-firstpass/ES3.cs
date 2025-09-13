using System;
using ES3Types;
using UnityEngine;

public class ES3
{
	public enum Location
	{
		File = 0,
		PlayerPrefs = 1,
		InternalMS = 2,
		Resources = 3,
		Cache = 4
	}

	public enum Directory
	{
		PersistentDataPath = 0,
		DataPath = 1
	}

	public enum EncryptionType
	{
		None = 0,
		AES = 1
	}

	public enum CompressionType
	{
		None = 0,
		Gzip = 1
	}

	public enum Format
	{
		JSON = 0
	}

	public enum ReferenceMode
	{
		ByRef = 0,
		ByValue = 1,
		ByRefAndValue = 2
	}

	public static void Save(string key, object value)
	{
	}

	public static void Save(string key, object value, string filePath)
	{
	}

	public static void Save(string key, object value, string filePath, ES3Settings settings)
	{
	}

	public static void Save(string key, object value, ES3Settings settings)
	{
	}

	public static void Save<T>(string key, T value)
	{
	}

	public static void Save<T>(string key, T value, string filePath)
	{
	}

	public static void Save<T>(string key, T value, string filePath, ES3Settings settings)
	{
	}

	public static void Save<T>(string key, T value, ES3Settings settings)
	{
	}

	public static void SaveRaw(byte[] bytes)
	{
	}

	public static void SaveRaw(byte[] bytes, string filePath)
	{
	}

	public static void SaveRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	public static void SaveRaw(byte[] bytes, ES3Settings settings)
	{
	}

	public static void SaveRaw(string str)
	{
	}

	public static void SaveRaw(string str, string filePath)
	{
	}

	public static void SaveRaw(string str, string filePath, ES3Settings settings)
	{
	}

	public static void SaveRaw(string str, ES3Settings settings)
	{
	}

	public static void AppendRaw(byte[] bytes)
	{
	}

	public static void AppendRaw(byte[] bytes, string filePath, ES3Settings settings)
	{
	}

	public static void AppendRaw(byte[] bytes, ES3Settings settings)
	{
	}

	public static void AppendRaw(string str)
	{
	}

	public static void AppendRaw(string str, string filePath)
	{
	}

	public static void AppendRaw(string str, string filePath, ES3Settings settings)
	{
	}

	public static void AppendRaw(string str, ES3Settings settings)
	{
	}

	public static void SaveImage(Texture2D texture, string imagePath)
	{
	}

	public static void SaveImage(Texture2D texture, string imagePath, ES3Settings settings)
	{
	}

	public static void SaveImage(Texture2D texture, ES3Settings settings)
	{
	}

	public static void SaveImage(Texture2D texture, int quality, string imagePath)
	{
	}

	public static void SaveImage(Texture2D texture, int quality, string imagePath, ES3Settings settings)
	{
	}

	public static void SaveImage(Texture2D texture, int quality, ES3Settings settings)
	{
	}

	public static object Load(string key)
	{
		return null;
	}

	public static object Load(string key, string filePath)
	{
		return null;
	}

	public static object Load(string key, string filePath, ES3Settings settings)
	{
		return null;
	}

	public static object Load(string key, ES3Settings settings)
	{
		return null;
	}

	public static object Load(string key, object defaultValue)
	{
		return null;
	}

	public static object Load(string key, string filePath, object defaultValue)
	{
		return null;
	}

	public static object Load(string key, string filePath, object defaultValue, ES3Settings settings)
	{
		return null;
	}

	public static object Load(string key, object defaultValue, ES3Settings settings)
	{
		return null;
	}

	public static T Load<T>(string key)
	{
		return default(T);
	}

	public static T Load<T>(string key, string filePath)
	{
		return default(T);
	}

	public static T Load<T>(string key, string filePath, ES3Settings settings)
	{
		return default(T);
	}

	public static T Load<T>(string key, ES3Settings settings)
	{
		return default(T);
	}

	public static T Load<T>(string key, T defaultValue)
	{
		return default(T);
	}

	public static T Load<T>(string key, string filePath, T defaultValue)
	{
		return default(T);
	}

	public static T Load<T>(string key, string filePath, T defaultValue, ES3Settings settings)
	{
		return default(T);
	}

	public static T Load<T>(string key, T defaultValue, ES3Settings settings)
	{
		return default(T);
	}

	public static void LoadInto<T>(string key, object obj) where T : class
	{
	}

	public static void LoadInto(string key, string filePath, object obj)
	{
	}

	public static void LoadInto(string key, string filePath, object obj, ES3Settings settings)
	{
	}

	public static void LoadInto(string key, object obj, ES3Settings settings)
	{
	}

	public static void LoadInto<T>(string key, T obj) where T : class
	{
	}

	public static void LoadInto<T>(string key, string filePath, T obj) where T : class
	{
	}

	public static void LoadInto<T>(string key, string filePath, T obj, ES3Settings settings) where T : class
	{
	}

	public static void LoadInto<T>(string key, T obj, ES3Settings settings) where T : class
	{
	}

	public static string LoadString(string key, string defaultValue, ES3Settings settings)
	{
		return null;
	}

	public static string LoadString(string key, string defaultValue, string filePath = null, ES3Settings settings = null)
	{
		return null;
	}

	public static byte[] LoadRawBytes()
	{
		return null;
	}

	public static byte[] LoadRawBytes(string filePath)
	{
		return null;
	}

	public static byte[] LoadRawBytes(string filePath, ES3Settings settings)
	{
		return null;
	}

	public static byte[] LoadRawBytes(ES3Settings settings)
	{
		return null;
	}

	public static string LoadRawString()
	{
		return null;
	}

	public static string LoadRawString(string filePath)
	{
		return null;
	}

	public static string LoadRawString(string filePath, ES3Settings settings)
	{
		return null;
	}

	public static string LoadRawString(ES3Settings settings)
	{
		return null;
	}

	public static Texture2D LoadImage(string imagePath)
	{
		return null;
	}

	public static Texture2D LoadImage(string imagePath, ES3Settings settings)
	{
		return null;
	}

	public static Texture2D LoadImage(ES3Settings settings)
	{
		return null;
	}

	public static Texture2D LoadImage(byte[] bytes)
	{
		return null;
	}

	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType)
	{
		return null;
	}

	public static AudioClip LoadAudio(string audioFilePath, AudioType audioType, ES3Settings settings)
	{
		return null;
	}

	public static byte[] Serialize<T>(T value, ES3Settings settings = null)
	{
		return null;
	}

	internal static byte[] Serialize(object value, ES3Type type, ES3Settings settings = null)
	{
		return null;
	}

	public static T Deserialize<T>(byte[] bytes, ES3Settings settings = null)
	{
		return default(T);
	}

	internal static object Deserialize(ES3Type type, byte[] bytes, ES3Settings settings = null)
	{
		return null;
	}

	public static void DeserializeInto<T>(byte[] bytes, T obj, ES3Settings settings = null) where T : class
	{
	}

	public static void DeserializeInto<T>(ES3Type type, byte[] bytes, T obj, ES3Settings settings = null) where T : class
	{
	}

	public static byte[] EncryptBytes(byte[] bytes, string password = null)
	{
		return null;
	}

	public static byte[] DecryptBytes(byte[] bytes, string password = null)
	{
		return null;
	}

	public static string EncryptString(string str, string password = null)
	{
		return null;
	}

	public static string DecryptString(string str, string password = null)
	{
		return null;
	}

	public static byte[] CompressBytes(byte[] bytes)
	{
		return null;
	}

	public static byte[] DecompressBytes(byte[] bytes)
	{
		return null;
	}

	public static string CompressString(string str)
	{
		return null;
	}

	public static string DecompressString(string str)
	{
		return null;
	}

	public static void DeleteFile()
	{
	}

	public static void DeleteFile(string filePath)
	{
	}

	public static void DeleteFile(string filePath, ES3Settings settings)
	{
	}

	public static void DeleteFile(ES3Settings settings)
	{
	}

	public static void CopyFile(string oldFilePath, string newFilePath)
	{
	}

	public static void CopyFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	public static void CopyFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	public static void RenameFile(string oldFilePath, string newFilePath)
	{
	}

	public static void RenameFile(string oldFilePath, string newFilePath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	public static void RenameFile(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	public static void CopyDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	public static void CopyDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath)
	{
	}

	public static void RenameDirectory(string oldDirectoryPath, string newDirectoryPath, ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	public static void RenameDirectory(ES3Settings oldSettings, ES3Settings newSettings)
	{
	}

	public static void DeleteDirectory(string directoryPath)
	{
	}

	public static void DeleteDirectory(string directoryPath, ES3Settings settings)
	{
	}

	public static void DeleteDirectory(ES3Settings settings)
	{
	}

	public static void DeleteKey(string key)
	{
	}

	public static void DeleteKey(string key, string filePath)
	{
	}

	public static void DeleteKey(string key, string filePath, ES3Settings settings)
	{
	}

	public static void DeleteKey(string key, ES3Settings settings)
	{
	}

	public static bool KeyExists(string key)
	{
		return false;
	}

	public static bool KeyExists(string key, string filePath)
	{
		return false;
	}

	public static bool KeyExists(string key, string filePath, ES3Settings settings)
	{
		return false;
	}

	public static bool KeyExists(string key, ES3Settings settings)
	{
		return false;
	}

	public static bool FileExists()
	{
		return false;
	}

	public static bool FileExists(string filePath)
	{
		return false;
	}

	public static bool FileExists(string filePath, ES3Settings settings)
	{
		return false;
	}

	public static bool FileExists(ES3Settings settings)
	{
		return false;
	}

	public static bool DirectoryExists(string folderPath)
	{
		return false;
	}

	public static bool DirectoryExists(string folderPath, ES3Settings settings)
	{
		return false;
	}

	public static bool DirectoryExists(ES3Settings settings)
	{
		return false;
	}

	public static string[] GetKeys()
	{
		return null;
	}

	public static string[] GetKeys(string filePath)
	{
		return null;
	}

	public static string[] GetKeys(string filePath, ES3Settings settings)
	{
		return null;
	}

	public static string[] GetKeys(ES3Settings settings)
	{
		return null;
	}

	public static string[] GetFiles()
	{
		return null;
	}

	public static string[] GetFiles(string directoryPath)
	{
		return null;
	}

	public static string[] GetFiles(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	public static string[] GetFiles(ES3Settings settings)
	{
		return null;
	}

	public static string[] GetDirectories()
	{
		return null;
	}

	public static string[] GetDirectories(string directoryPath)
	{
		return null;
	}

	public static string[] GetDirectories(string directoryPath, ES3Settings settings)
	{
		return null;
	}

	public static string[] GetDirectories(ES3Settings settings)
	{
		return null;
	}

	public static void CreateBackup()
	{
	}

	public static void CreateBackup(string filePath)
	{
	}

	public static void CreateBackup(string filePath, ES3Settings settings)
	{
	}

	public static void CreateBackup(ES3Settings settings)
	{
	}

	public static bool RestoreBackup(string filePath)
	{
		return false;
	}

	public static bool RestoreBackup(string filePath, ES3Settings settings)
	{
		return false;
	}

	public static bool RestoreBackup(ES3Settings settings)
	{
		return false;
	}

	public static DateTime GetTimestamp()
	{
		return default(DateTime);
	}

	public static DateTime GetTimestamp(string filePath)
	{
		return default(DateTime);
	}

	public static DateTime GetTimestamp(string filePath, ES3Settings settings)
	{
		return default(DateTime);
	}

	public static DateTime GetTimestamp(ES3Settings settings)
	{
		return default(DateTime);
	}

	public static void StoreCachedFile()
	{
	}

	public static void StoreCachedFile(string filePath)
	{
	}

	public static void StoreCachedFile(string filePath, ES3Settings settings)
	{
	}

	public static void StoreCachedFile(ES3Settings settings)
	{
	}

	public static void CacheFile()
	{
	}

	public static void CacheFile(string filePath)
	{
	}

	public static void CacheFile(string filePath, ES3Settings settings)
	{
	}

	public static void CacheFile(ES3Settings settings)
	{
	}

	public static void Init()
	{
	}
}
