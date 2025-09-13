using System.IO;

namespace ES3Internal
{
	public class UnbufferedCryptoStream : MemoryStream
	{
		private readonly Stream stream;

		private readonly bool isReadStream;

		private string password;

		private int bufferSize;

		private EncryptionAlgorithm alg;

		private bool disposed;

		public UnbufferedCryptoStream(Stream stream, bool isReadStream, string password, int bufferSize, EncryptionAlgorithm alg)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
