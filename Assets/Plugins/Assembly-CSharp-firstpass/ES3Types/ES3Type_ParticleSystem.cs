using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[]
	{
		"time", "hideFlags", "collision", "colorBySpeed", "colorOverLifetime", "emission", "externalForces", "forceOverLifetime", "inheritVelocity", "lights",
		"limitVelocityOverLifetime", "main", "noise", "rotatonBySpeed", "rotationOverLifetime", "shape", "sizeBySpeed", "sizeOverLifetime", "subEmitters", "textureSheetAnimation",
		"trails", "trigger", "useAutoRandomSeed", "velocityOverLifetime", "isPaused", "isPlaying", "isStopped"
	})]
	public class ES3Type_ParticleSystem : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_ParticleSystem()
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
