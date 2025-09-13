using System;
using System.ComponentModel;

[Serializable]
[EditorBrowsable(EditorBrowsableState.Never)]
public class ES3SerializableSettings : ES3Settings
{
	public ES3SerializableSettings()
	{
	}

	public ES3SerializableSettings(bool applyDefaults)
	{
	}

	public ES3SerializableSettings(string path)
	{
	}

	public ES3SerializableSettings(string path, ES3.Location location)
	{
	}
}
