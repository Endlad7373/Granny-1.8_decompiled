using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "numTilesX", "numTilesY", "animation", "useRandomRow", "frameOverTime", "frameOverTimeMultiplier", "startFrame", "startFrameMultiplier", "cycleCount",
		"rowIndex", "uvChannelMask", "flipU", "flipV"
	})]
	public class ES3Type_TextureSheetAnimationModule : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_TextureSheetAnimationModule()
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
