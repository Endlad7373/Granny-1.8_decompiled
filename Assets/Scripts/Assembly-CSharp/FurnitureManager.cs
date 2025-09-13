using System.Collections.Generic;
using UnityEngine;

public class FurnitureManager : MonoBehaviour
{
	[SerializeField]
	private Furniture[] allFurniture;

	private List<Furniture> queue;

	private float resetTimer;

	private bool reset;

	public static FurnitureManager Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public void ResetAll(bool force = false)
	{
	}

	public void Queue(Furniture other)
	{
	}

	public void ResetTimer()
	{
	}
}
