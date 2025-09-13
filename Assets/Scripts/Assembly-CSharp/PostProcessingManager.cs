using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[DisallowMultipleComponent]
public class PostProcessingManager : MonoBehaviour
{
	private static PostProcessingManager instance;

	[SerializeField]
	private PostProcessProfile profile;

	[SerializeField]
	private PostProcessLayer[] layers;

	private static bool motionBlur;

	private static bool ambientOcclusion;

	private static bool colorGrading;

	private static bool vignette;

	private static bool chromaticAberration;

	private static MotionBlur mb;

	private static AmbientOcclusion ao;

	private static ColorGrading cg;

	private static Vignette vg;

	private static ChromaticAberration ca;

	private bool inDark;

	private bool cutscene;

	private float biteTimer;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public static void RefreshDarkness()
	{
	}

	public static void Die()
	{
	}

	public static void WakeUp()
	{
	}

	public static void SwitchPerspective()
	{
	}

	public static void RatBite()
	{
	}
}
