using System.IO;

namespace ES3Internal
{
	public abstract class EncryptionAlgorithm
	{
		public abstract byte[] Encrypt(byte[] bytes, string password, int bufferSize);

		public abstract byte[] Decrypt(byte[] bytes, string password, int bufferSize);

		public abstract void Encrypt(Stream input, Stream output, string password, int bufferSize);

		public abstract void Decrypt(Stream input, Stream output, string password, int bufferSize);

		protected static void CopyStream(Stream input, Stream output, int bufferSize)
		{
		}
	}
}
