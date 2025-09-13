using System.IO;

namespace ES3Internal
{
	internal class ES3ResourcesStream : MemoryStream
	{
		public bool Exists => false;

		public ES3ResourcesStream(string path)
		{
		}

		private static byte[] GetData(string path)
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
