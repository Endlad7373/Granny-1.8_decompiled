using System.IO;

namespace ES3Internal
{
	internal class ES3PlayerPrefsStream : MemoryStream
	{
		private string path;

		private bool append;

		private bool isWriteStream;

		private bool isDisposed;

		public ES3PlayerPrefsStream(string path)
		{
		}

		public ES3PlayerPrefsStream(string path, int bufferSize, bool append = false)
		{
		}

		private static byte[] GetData(string path, bool isWriteStream)
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
