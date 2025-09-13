using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(PlayerTrigger))]
public class CreakingFloor : MonoBehaviour
{
	[Header("Difficulty Controls")]
	[SerializeField]
	private bool normal;

	[SerializeField]
	private bool extreme;

	[SerializeField]
	private bool impossible;

	[Header("Extreme")]
	[SerializeField]
	private Vector3 extPos;

	[SerializeField]
	private Vector3 extRot;

	[SerializeField]
	private Vector3 extSize;

	[Header("Impossible")]
	[SerializeField]
	private Vector3 impPos;

	[SerializeField]
	private Vector3 impRot;

	[SerializeField]
	private Vector3 impSize;

	private AudioSource audio;

	private bool creaked;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Creak()
	{
	}
}
