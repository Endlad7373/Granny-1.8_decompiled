using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "type", "mode", "dampen", "dampenMultiplier", "bounce", "bounceMultiplier", "lifetimeLoss", "lifetimeLossMultiplier", "minKillSpeed",
		"maxKillSpeed", "collidesWith", "enableDynamicColliders", "maxCollisionShapes", "quality", "voxelSize", "radiusScale", "sendCollisionMessages"
	})]
	public class ES3Type_CollisionModule : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_CollisionModule()
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer)
		{
		}

		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
