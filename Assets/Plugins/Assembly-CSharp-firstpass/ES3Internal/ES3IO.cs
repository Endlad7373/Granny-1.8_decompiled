using System;

namespace ES3Internal
{
	public static class ES3IO
	{
		public enum ES3FileMode
		{
			Read = 0,
			Write = 1,
			Append = 2
		}

		internal static readonly string persistentDataPath;

		internal static readonly string dataPath;

		internal const string backupFileSuffix = ".bac";

		internal const string temporaryFileSuffix = ".tmp";

		public static DateTime GetTimestamp(string filePath)
		{
			return default(DateTime);
		}

		public static string GetExtension(string path)
		{
			return null;
		}

		public static void DeleteFile(string filePath)
		{
		}

		public static bool FileExists(string filePath)
		{
			return false;
		}

		public static void MoveFile(string sourcePath, string destPath)
		{
		}

		public static void CopyFile(string sourcePath, string destPath)
		{
		}

		public static void MoveDirectory(string sourcePath, string destPath)
		{
		}

		public static void CreateDirectory(string directoryPath)
		{
		}

		public static bool DirectoryExists(string directoryPath)
		{
			return false;
		}

		public static string GetDirectoryPath(string path, char seperator = '/')
		{
			return null;
		}

		public static bool UsesForwardSlash(string path)
		{
			return false;
		}

		public static string CombinePathAndFilename(string directoryPath, string fileOrDirectoryName)
		{
			return null;
		}

		public static string[] GetDirectories(string path, bool getFullPaths = true)
		{
			return null;
		}

		public static void DeleteDirectory(string directoryPath)
		{
		}

		public static string[] GetFiles(string path, bool getFullPaths = true)
		{
			return null;
		}

		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		public static void WriteAllBytes(string path, byte[] bytes)
		{
		}

		public static void CommitBackup(ES3Settings settings)
		{
		}
	}
}
