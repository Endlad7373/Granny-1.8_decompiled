using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class WallSpider : MonoBehaviour
{
	[SerializeField]
	private Animation animHolder;

	[SerializeField]
	private Transform[] spots;

	[SerializeField]
	private float speed;

	[SerializeField]
	private Vector2 waitTime;

	private AudioSource audio;

	private Transform target;

	private void Awake()
	{
	}

	private void Move()
	{
	}
}
