using System.Collections.Generic;

public static class SaveFiles
{
	private static ES3Settings playerPrefs;

	private static ES3Settings unlocks;

	private static bool initialized;

	private static bool schedulePrefs;

	private static bool scheduleUnlocks;

	private const string playerPrefsFile = "Config.es3";

	private const string unlocksFile = "Progress.es3";

	private static List<string> versions;

	private static void Init()
	{
	}

	public static void Write()
	{
	}

	public static bool ImpossibleUnlocked()
	{
		return false;
	}

	public static bool PresetsUnlocked()
	{
		return false;
	}

	public static bool MomSpiderUnlocked()
	{
		return false;
	}

	public static bool GrandpaUnlocked()
	{
		return false;
	}

	public static bool ShotgunUnlocked()
	{
		return false;
	}

	public static bool SlendrinaUnlocked()
	{
		return false;
	}

	public static bool FlashlightUnlocked()
	{
		return false;
	}

	public static bool ClassicUnlocked()
	{
		return false;
	}

	public static T PrefsLoad<T>(string key, T defaultValue)
	{
		return default(T);
	}

	public static void PrefsSave<T>(string key, T value)
	{
	}

	public static T UnlocksLoad<T>(string key, T defaultValue)
	{
		return default(T);
	}

	public static void UnlocksSave<T>(string key, T value)
	{
	}

	public static void BeatGame()
	{
	}
}
