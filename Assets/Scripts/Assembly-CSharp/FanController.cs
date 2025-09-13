using UnityEngine;

[DisallowMultipleComponent]
public class FanController : MonoBehaviour
{
	[SerializeField]
	private Transform fan;

	[SerializeField]
	private float spinSpeed;

	[SerializeField]
	private float stopSpeed;

	[SerializeField]
	private AudioClip fingerInFan;

	private float startSpeed;

	private float angle;

	private AudioSource fanSound;

	private Item reward;

	private bool hurt;

	private bool stop;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public void SetReward(Item item)
	{
	}

	public void TryGrab()
	{
	}

	public void CutWire()
	{
	}
}
