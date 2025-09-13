using UnityEngine;

[DisallowMultipleComponent]
public class FrontDoorLocks : MonoBehaviour
{
	[Header("Plank")]
	[SerializeField]
	private Rigidbody plank;

	[SerializeField]
	private AudioSource nailsLeft;

	[SerializeField]
	private AudioSource nailsRight;

	[SerializeField]
	private AudioClip pullNail;

	[SerializeField]
	private HingeJoint plankHolder;

	[SerializeField]
	[Header("Alarm Box")]
	private GameObject wireCut;

	[SerializeField]
	private GameObject wireBasementCut;

	[SerializeField]
	[Header("Padlock")]
	private Rigidbody padlockBar;

	[SerializeField]
	[Header("Digital Padlock")]
	private Transform digitalPadlockBar;

	[SerializeField]
	[Header("Battery")]
	private GameObject batteryLock;

	[SerializeField]
	private GameObject battery;

	[SerializeField]
	private GameObject batterySpot;

	[SerializeField]
	private Transform batterySwitch;

	[Header("Motor Lock")]
	[SerializeField]
	private Transform motorLockSwitch;

	[SerializeField]
	private Transform motorLockBar;

	private int nails;

	private bool motorLockOpen;

	public void OpenFrontDoor()
	{
	}

	public void PullNail()
	{
	}

	public void OpenMotorLock()
	{
	}

	public void PullBatterySwitch()
	{
	}
}
