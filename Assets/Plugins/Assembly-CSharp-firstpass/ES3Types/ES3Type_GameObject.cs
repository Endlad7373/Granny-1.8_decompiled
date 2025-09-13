using System.Collections.Generic;
using ES3Internal;
using UnityEngine;
using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[] { "layer", "isStatic", "tag", "name", "hideFlags", "children", "components" })]
	[Preserve]
	public class ES3Type_GameObject : ES3UnityObjectType
	{
		private const string prefabPropertyName = "es3Prefab";

		private const string transformPropertyName = "transformID";

		public static ES3Type Instance;

		public bool saveChildren;

		public ES3Type_GameObject()
			: base(null)
		{
		}

		public override void WriteObject(object obj, ES3Writer writer, ES3.ReferenceMode mode)
		{
		}

		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}

		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		private void ReadComponents(ES3Reader reader, GameObject go)
		{
		}

		private GameObject CreateNewGameObject(ES3ReferenceMgrBase refMgr, long id)
		{
			return null;
		}

		public static List<GameObject> GetChildren(GameObject go)
		{
			return null;
		}

		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
}
