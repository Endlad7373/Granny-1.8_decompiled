using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[]
	{
		"velocity", "angularVelocity", "drag", "angularDrag", "mass", "useGravity", "maxDepenetrationVelocity", "isKinematic", "freezeRotation", "constraints",
		"collisionDetectionMode", "centerOfMass", "inertiaTensorRotation", "inertiaTensor", "detectCollisions", "position", "rotation", "interpolation", "solverIterations", "sleepThreshold",
		"maxAngularVelocity", "solverVelocityIterations"
	})]
	[Preserve]
	public class ES3Type_Rigidbody : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_Rigidbody()
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
