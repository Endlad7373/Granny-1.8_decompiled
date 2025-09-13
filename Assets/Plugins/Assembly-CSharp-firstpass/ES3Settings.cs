using System;
using System.ComponentModel;
using System.Text;
using UnityEngine;

public class ES3Settings : ICloneable
{
	private static ES3Settings _defaults;

	private static ES3Defaults _defaultSettingsScriptableObject;

	private const string defaultSettingsPath = "ES3/ES3Defaults";

	private static ES3Settings _unencryptedUncompressedSettings;

	private static readonly string[] resourcesExtensions;

	[SerializeField]
	private ES3.Location _location;

	public string path;

	public ES3.EncryptionType encryptionType;

	public ES3.CompressionType compressionType;

	public string encryptionPassword;

	public ES3.Directory directory;

	public ES3.Format format;

	public bool prettyPrint;

	public int bufferSize;

	public Encoding encoding;

	public bool saveChildren;

	public bool postprocessRawCachedData;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool typeChecking;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool safeReflection;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public ES3.ReferenceMode memberReferenceMode;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public ES3.ReferenceMode referenceMode;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public int serializationDepthLimit;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public string[] assemblyNames;

	public static ES3Defaults defaultSettingsScriptableObject => null;

	public static ES3Settings defaultSettings => null;

	internal static ES3Settings unencryptedUncompressedSettings => null;

	public ES3.Location location
	{
		get
		{
			return default(ES3.Location);
		}
		set
		{
		}
	}

	public string FullPath => null;

	public ES3Settings(string path = null, ES3Settings settings = null)
	{
	}

	public ES3Settings(string path, params Enum[] enums)
	{
	}

	public ES3Settings(params Enum[] enums)
	{
	}

	public ES3Settings(ES3.EncryptionType encryptionType, string encryptionPassword)
	{
	}

	public ES3Settings(string path, ES3.EncryptionType encryptionType, string encryptionPassword, ES3Settings settings = null)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public ES3Settings(bool applyDefaults)
	{
	}

	private static bool IsAbsolute(string path)
	{
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public object Clone()
	{
		return null;
	}

	private void CopyInto(ES3Settings newSettings)
	{
	}
}
