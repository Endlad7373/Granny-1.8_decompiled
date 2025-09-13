using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class PuzzleGeneric : Interactable
{
	public string itemNeeded;

	[SerializeField]
	private string failText;

	[SerializeField]
	private bool containsPartOfName;

	[SerializeField]
	private UnityEvent onItemUsed;

	[SerializeField]
	private UnityEvent onFail;

	private void Awake()
	{
	}

	public void SimulateSolution()
	{
	}
}
