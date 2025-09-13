using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class Inventory : MonoBehaviour
{
	[Serializable]
	public class InventoryItem
	{
		public string name;

		public GameObject handheldItem;

		public GameObject droppedItem;

		public AudioClip pickUp;

		public Transform dropAt;

		public string action;

		public UnityEvent onUse;
	}

	[SerializeField]
	private float dropForce;

	[SerializeField]
	private GameObject dropText;

	[SerializeField]
	private TextMeshProUGUI actionText;

	[SerializeField]
	private AudioClip pickUpFlashlight;

	[SerializeField]
	private Image ammo1;

	[SerializeField]
	private Image ammo2;

	[SerializeField]
	private Sprite ammoEmpty;

	[SerializeField]
	private Sprite ammoLoaded;

	[SerializeField]
	private InventoryItem[] itemDefs;

	private Dictionary<string, InventoryItem> allItems;

	private InventoryItem currItem;

	private bool melonInspected;

	private GameObject shotgun2;

	private Transform teddy;

	[SerializeField]
	private Transform[] teddyPoints;

	[HideInInspector]
	public Vector3 plankSize;

	public static Inventory Instance { get; private set; }

	private void Awake()
	{
	}

	public static bool PickUp(string name)
	{
		return false;
	}

	public static void Drop()
	{
	}

	public static string GetCleanName(string itemName)
	{
		return null;
	}

	public void PickUpFlashlight()
	{
	}

	public static string GetHeldItem()
	{
		return null;
	}

	public static void UseItem()
	{
	}

	private void RemoveItem(bool drop)
	{
	}

	public static void RefreshHeldItemBrightness()
	{
	}

	public static void RefreshHeldItemText()
	{
	}

	public static void ItemAction()
	{
	}

	public void TakeShotgunFromGrandpa()
	{
	}

	public static void RespawnItems()
	{
	}

	public static void DropWeaponsOnly()
	{
	}

	public static void GasDetonation()
	{
	}
}
