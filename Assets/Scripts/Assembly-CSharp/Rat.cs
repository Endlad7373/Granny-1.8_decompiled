using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(AudioSource))]
[DisallowMultipleComponent]
public class Rat : MonoBehaviour
{
	[SerializeField]
	private Animation anim;

	[SerializeField]
	private AudioClip bite;

	[SerializeField]
	private AudioClip hurt;

	private AudioSource audio;

	private NavMeshAgent nav;

	private float timer;

	private float moveTime;

	private bool cooldown;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	private void NewNav()
	{
	}

	private void Cooldown()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void Hurt()
	{
	}
}
