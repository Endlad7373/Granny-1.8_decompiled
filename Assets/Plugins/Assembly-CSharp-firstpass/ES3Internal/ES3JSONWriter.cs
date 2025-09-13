using System.IO;

namespace ES3Internal
{
	internal class ES3JSONWriter : ES3Writer
	{
		internal StreamWriter baseWriter;

		private bool isFirstProperty;

		public ES3JSONWriter(Stream stream, ES3Settings settings)
			: base(null, writeHeaderAndFooter: false, overwriteKeys: false)
		{
		}

		internal ES3JSONWriter(Stream stream, ES3Settings settings, bool writeHeaderAndFooter, bool mergeKeys)
			: base(null, writeHeaderAndFooter: false, overwriteKeys: false)
		{
		}

		internal override void WritePrimitive(int value)
		{
		}

		internal override void WritePrimitive(float value)
		{
		}

		internal override void WritePrimitive(bool value)
		{
		}

		internal override void WritePrimitive(decimal value)
		{
		}

		internal override void WritePrimitive(double value)
		{
		}

		internal override void WritePrimitive(long value)
		{
		}

		internal override void WritePrimitive(ulong value)
		{
		}

		internal override void WritePrimitive(uint value)
		{
		}

		internal override void WritePrimitive(byte value)
		{
		}

		internal override void WritePrimitive(sbyte value)
		{
		}

		internal override void WritePrimitive(short value)
		{
		}

		internal override void WritePrimitive(ushort value)
		{
		}

		internal override void WritePrimitive(char value)
		{
		}

		internal override void WritePrimitive(byte[] value)
		{
		}

		internal override void WritePrimitive(string value)
		{
		}

		internal override void WriteNull()
		{
		}

		private static bool CharacterRequiresEscaping(char c)
		{
			return false;
		}

		private void WriteCommaIfRequired()
		{
		}

		internal override void WriteRawProperty(string name, byte[] value)
		{
		}

		internal override void StartWriteFile()
		{
		}

		internal override void EndWriteFile()
		{
		}

		internal override void StartWriteProperty(string name)
		{
		}

		internal override void EndWriteProperty(string name)
		{
		}

		internal override void StartWriteObject(string name)
		{
		}

		internal override void EndWriteObject(string name)
		{
		}

		internal override void StartWriteCollection()
		{
		}

		internal override void EndWriteCollection()
		{
		}

		internal override void StartWriteCollectionItem(int index)
		{
		}

		internal override void EndWriteCollectionItem(int index)
		{
		}

		internal override void StartWriteDictionary()
		{
		}

		internal override void EndWriteDictionary()
		{
		}

		internal override void StartWriteDictionaryKey(int index)
		{
		}

		internal override void EndWriteDictionaryKey(int index)
		{
		}

		internal override void StartWriteDictionaryValue(int index)
		{
		}

		internal override void EndWriteDictionaryValue(int index)
		{
		}

		public override void Dispose()
		{
		}

		public void WriteNewlineAndTabs()
		{
		}
	}
}
