using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public class PauseMenu : MonoBehaviour
{
	[HideInInspector]
	public bool cantPause;

	[SerializeField]
	private GameObject pauseMenu;

	[SerializeField]
	private GameObject quitMenu;

	[SerializeField]
	private Toggle musicToggle;

	[SerializeField]
	private Slider volumeSlider;

	[SerializeField]
	private Slider sensSlider;

	[SerializeField]
	private AudioSource[] untimedSounds;

	[SerializeField]
	private GameObject[] hideWhenPaused;

	private AudioSource audio;

	public static PauseMenu Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	private void TogglePause()
	{
	}

	public void ToggleMusic()
	{
	}

	public void ChangeVolume()
	{
	}

	public void ChangeSensitivity()
	{
	}

	public void ReturnToMenu()
	{
	}

	public void ClickResume()
	{
	}

	public void ClickMainMenu(bool quitting)
	{
	}
}
