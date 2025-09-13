using System.Collections.Generic;
using UnityEngine;

public class FoyerShelf : MonoBehaviour
{
	private static FoyerShelf instance;

	[SerializeField]
	private List<Rigidbody> rewards;

	private bool loose;

	private void Awake()
	{
	}

	public void AddReward(Rigidbody rb)
	{
	}

	public static void ItemsLoose()
	{
	}
}
