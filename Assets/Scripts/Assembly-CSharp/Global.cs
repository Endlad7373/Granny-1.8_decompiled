using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Global : MonoBehaviour
{
	private static Global instance;

	public static readonly string[] VERSIONS;

	[SerializeField]
	private GameObject psx;

	[SerializeField]
	private GameObject vhs;

	private static Dictionary<string, AssetBundle> assets;

	public static bool Christmas { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public static AssetBundle GetAssetBundle(string name)
	{
		return null;
	}

	public static void UnloadAssetBundle(string name, bool unloadAll = true)
	{
	}
}
