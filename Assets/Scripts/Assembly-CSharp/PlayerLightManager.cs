using UnityEngine;

public class PlayerLightManager : MonoBehaviour
{
	public static PlayerLightManager Instance;

	[SerializeField]
	private GameObject flashlight;

	[SerializeField]
	private Light fillLight;

	[SerializeField]
	private AudioClip flashlightOn;

	[SerializeField]
	private AudioClip flashlightOff;

	private bool nightVision;

	public bool InDark { get; private set; }

	public bool HasFlashlight { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Refresh(bool incapacitated)
	{
	}

	private void ToggleFlashlight(bool mute)
	{
	}

	public static void PickUpFlashlight()
	{
	}
}
