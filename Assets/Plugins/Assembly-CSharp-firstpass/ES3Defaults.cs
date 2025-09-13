using UnityEngine;

public class ES3Defaults : ScriptableObject
{
	[SerializeField]
	public ES3SerializableSettings settings;

	public bool addMgrToSceneAutomatically;

	public bool autoUpdateReferences;

	public bool addAllPrefabsToManager;

	public int collectDependenciesDepth;

	public bool logDebugInfo;

	public bool logWarnings;

	public bool logErrors;
}
