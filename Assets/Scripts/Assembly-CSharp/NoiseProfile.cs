using UnityEngine;

public class NoiseProfile : MonoBehaviour
{
	public enum NoiseMaterial
	{
		Normal = 0,
		Grass = 1,
		Water = 2
	}

	public NoiseMaterial noiseMaterial;

	public bool alerts;

	public float floorLevel;
}
