using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Renderer))]
public class MenuNightmare : MonoBehaviour
{
	[SerializeField]
	private Texture[] tex;

	[SerializeField]
	private Texture[] nmTex;

	private Texture[] oldNmTex;

	[SerializeField]
	private string[] oldNmTexNames;

	private Renderer rend;

	public void InitOldNightmare()
	{
	}

	public void Refresh()
	{
	}
}
