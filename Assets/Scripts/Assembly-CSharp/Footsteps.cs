using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class Footsteps : MonoBehaviour
{
	[SerializeField]
	private AudioClip[] steps;

	[SerializeField]
	private AudioClip[] grassSteps;

	[SerializeField]
	private AudioClip[] waterSteps;

	[SerializeField]
	private AudioClip[] stickySteps;

	[SerializeField]
	private float[] volumes;

	[SerializeField]
	private Transform rayOrigin;

	[SerializeField]
	private LayerMask layers;

	private AudioSource audio;

	private bool sticky;

	private NoiseProfile.NoiseMaterial floorMat;

	private Dictionary<NoiseProfile.NoiseMaterial, AudioClip[]> allSteps;

	private void Awake()
	{
	}

	private void step()
	{
	}

	public bool InWater()
	{
		return false;
	}
}
