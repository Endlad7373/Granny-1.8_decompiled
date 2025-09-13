using UnityEngine;

public class NoiseAlerts : MonoBehaviour
{
	public static NoiseAlerts Instance { get; private set; }

	private void Awake()
	{
	}

	public void CreateNoiseAlert(Vector3 pos, bool loud = false, Vector3? altPos = null)
	{
	}
}
