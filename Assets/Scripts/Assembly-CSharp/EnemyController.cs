using TMPro;
using UnityEngine;

[DisallowMultipleComponent]
public class EnemyController : MonoBehaviour
{
	public bool arrivedAtPrison;

	[SerializeField]
	private GameObject allGranny;

	[SerializeField]
	private GameObject allMomSpider;

	[SerializeField]
	private GameObject allGrandpa;

	[SerializeField]
	private GameObject allRats;

	[SerializeField]
	private GameObject allMom;

	[SerializeField]
	private GameObject brokenFloorSight;

	[SerializeField]
	private GameObject grannyNote;

	[SerializeField]
	private GameObject book;

	[SerializeField]
	private GameObject spiderKey;

	[SerializeField]
	private Transform hangingMom;

	[SerializeField]
	private Transform momHangPoint;

	[SerializeField]
	private Transform[] grannySpawnPoints;

	[SerializeField]
	private Transform[] grandpaSpawnPoints;

	[SerializeField]
	private Renderer[] momBody;

	[SerializeField]
	private float momFadeTime;

	[SerializeField]
	private float[] respawnTimer;

	[SerializeField]
	private float[] respawnTimerMore;

	[SerializeField]
	private string[] respawnTimerText;

	[SerializeField]
	private string[] respawnTimerMoreText;

	[SerializeField]
	private TextMeshProUGUI grannyGoneText;

	[SerializeField]
	private TextMeshProUGUI grandpaGoneText;

	[SerializeField]
	private AudioSource spiderKeyNoise;

	private float angryTimer;

	private float momFadeAmount;

	private float grannyTimer;

	private float grandpaTimer;

	private bool cellarFound;

	private bool petKilled;

	private bool grannyNotAngry;

	private bool grandpaNotAngry;

	private bool grannyDead;

	private bool grandpaDead;

	public static EnemyController Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void MECUpdate()
	{
	}

	public bool IsAngry()
	{
		return false;
	}

	public void MomFade()
	{
	}

	public Transform GetValidGrannySpawnPoint(bool start = false)
	{
		return null;
	}

	public Transform GetValidGrandpaSpawnPoint(bool start = false)
	{
		return null;
	}

	public void FindCellar()
	{
	}

	public void KillPet()
	{
	}

	public void ResetAnger()
	{
	}

	public void KillGranny()
	{
	}

	public void KillGrandpa()
	{
	}

	public void StunMomSpider()
	{
	}

	public void TeddyDelivered()
	{
	}

	public bool IsGrannyAngry()
	{
		return false;
	}

	public bool IsGrandpaAngry()
	{
		return false;
	}

	public void PlayerDie()
	{
	}

	public float GetRespawnTime(bool more)
	{
		return 0f;
	}

	public void GrannyDie(bool more)
	{
	}

	public void GrandpaDie(bool more)
	{
	}

	public void DeleteAllRagdolls()
	{
	}

	public void DespawnMom()
	{
	}
}
