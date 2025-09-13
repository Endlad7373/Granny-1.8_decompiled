using UnityEngine;

[DisallowMultipleComponent]
public class ScrewsCounter : MonoBehaviour
{
	[SerializeField]
	private Rigidbody panel;

	[SerializeField]
	private Rigidbody panelBackyard;

	[SerializeField]
	private Animation panelSpiderCellar;

	[SerializeField]
	private GameObject rewardBackyard;

	private GameObject reward;

	private GameObject rewardSpiderCellar;

	private int screws;

	private int screwsBackyard;

	private int screwsSpiderCellar;

	public void SetReward(GameObject item)
	{
	}

	public void Unscrew()
	{
	}

	private void OpenCompartment()
	{
	}

	public void UnscrewBackyard(Transform screw)
	{
	}

	private void OpenCompartmentBackyard()
	{
	}

	public void SetRewardSpiderCellar(GameObject item)
	{
	}

	public void UnscrewSpiderCellar(Transform screw)
	{
	}

	private void OpenCompartmentSpiderCellar()
	{
	}
}
