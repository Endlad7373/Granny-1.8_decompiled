using UnityEngine;

public class PlankOverHole : MonoBehaviour
{
	private static PlankOverHole instance;

	[SerializeField]
	private GameObject highlight;

	[SerializeField]
	private GameObject breakTrigger;

	[SerializeField]
	private GameObject stopEnemies;

	private bool noText;

	private bool hammered;

	private bool timer;

	private bool placed;

	private void Awake()
	{
	}

	public void StandOverHole()
	{
	}

	public void ApproachHole()
	{
	}

	public void WalkAway()
	{
	}

	public void PlankHammered()
	{
	}

	public void PlankPlaced()
	{
	}

	public static bool EnemyShouldBreak()
	{
		return false;
	}
}
