using System.IO;

namespace ES3Internal
{
	public class AESEncryptionAlgorithm : EncryptionAlgorithm
	{
		private const int ivSize = 16;

		private const int keySize = 16;

		private const int pwIterations = 100;

		public override byte[] Encrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		public override byte[] Decrypt(byte[] bytes, string password, int bufferSize)
		{
			return null;
		}

		public override void Encrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}

		public override void Decrypt(Stream input, Stream output, string password, int bufferSize)
		{
		}
	}
}
