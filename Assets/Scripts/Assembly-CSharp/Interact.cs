using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Camera))]
[DisallowMultipleComponent]
public class Interact : MonoBehaviour
{
	private static Interact instance;

	[SerializeField]
	private Transform caster;

	[SerializeField]
	private GameObject screenDot;

	[SerializeField]
	private GameObject interactRing;

	[SerializeField]
	private GameObject bearTrapButton;

	[SerializeField]
	private float range;

	[SerializeField]
	private LayerMask layers;

	[SerializeField]
	private LayerMask bearTrapLayers;

	[SerializeField]
	private TextMeshProUGUI itemText;

	[SerializeField]
	private TextMeshProUGUI examineText;

	[SerializeField]
	private TextMeshProUGUI notifText;

	[SerializeField]
	private AudioSource disarming;

	[SerializeField]
	private Image bearTrapBar;

	private Camera camera;

	private float examineTimer;

	private float notifTimer;

	private bool holding;

	[SerializeField]
	private HoldInteractable holdInteractable;

	private float removeTrapTimer;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public static void Examine(string comment)
	{
	}

	public static void Notify(string message)
	{
	}

	private void Release(bool forget = true)
	{
	}
}
