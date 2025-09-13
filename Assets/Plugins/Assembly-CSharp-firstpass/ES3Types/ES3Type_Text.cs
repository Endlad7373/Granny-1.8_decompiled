using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[]
	{
		"font", "text", "supportRichText", "resizeTextForBestFit", "resizeTextMinSize", "resizeTextMaxSize", "alignment", "alignByGeometry", "fontSize", "horizontalOverflow",
		"verticalOverflow", "lineSpacing", "fontStyle", "onCullStateChanged", "maskable", "color", "raycastTarget", "material", "useGUILayout", "enabled",
		"tag", "name", "hideFlags"
	})]
	public class ES3Type_Text : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_Text()
			: base(null)
		{
		}

		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
}
