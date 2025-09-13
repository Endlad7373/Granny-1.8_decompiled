using System;
using System.IO;

namespace ES3Internal
{
	public class ES3JSONReader : ES3Reader
	{
		private const char endOfStreamChar = '\uffff';

		public StreamReader baseReader;

		internal ES3JSONReader(Stream stream, ES3Settings settings, bool readHeaderAndFooter = true)
			: base(null, readHeaderAndFooter: false)
		{
		}

		public override string ReadPropertyName()
		{
			return null;
		}

		protected override Type ReadKeyPrefix(bool ignoreType = false)
		{
			return null;
		}

		protected override void ReadKeySuffix()
		{
		}

		internal override bool StartReadObject()
		{
			return false;
		}

		internal override void EndReadObject()
		{
		}

		internal override bool StartReadDictionary()
		{
			return false;
		}

		internal override void EndReadDictionary()
		{
		}

		internal override bool StartReadDictionaryKey()
		{
			return false;
		}

		internal override void EndReadDictionaryKey()
		{
		}

		internal override void StartReadDictionaryValue()
		{
		}

		internal override bool EndReadDictionaryValue()
		{
			return false;
		}

		internal override bool StartReadCollection()
		{
			return false;
		}

		internal override void EndReadCollection()
		{
		}

		internal override bool StartReadCollectionItem()
		{
			return false;
		}

		internal override bool EndReadCollectionItem()
		{
			return false;
		}

		private void ReadString(StreamWriter writer, bool skip = false)
		{
		}

		internal override byte[] ReadElement(bool skip = false)
		{
			return null;
		}

		private char ReadOrSkipChar(StreamWriter writer, bool skip)
		{
			return '\0';
		}

		private char ReadCharIgnoreWhitespace(bool ignoreTrailingWhitespace = true)
		{
			return '\0';
		}

		private bool ReadNullOrCharIgnoreWhitespace(char expectedChar)
		{
			return false;
		}

		private char ReadCharIgnoreWhitespace(char expectedChar)
		{
			return '\0';
		}

		private bool ReadQuotationMarkOrNullIgnoreWhitespace()
		{
			return false;
		}

		private char PeekCharIgnoreWhitespace(char expectedChar)
		{
			return '\0';
		}

		private char PeekCharIgnoreWhitespace()
		{
			return '\0';
		}

		private void SkipWhiteSpace()
		{
		}

		private void SkipOpeningBraceOfFile()
		{
		}

		private static bool IsWhiteSpace(char c)
		{
			return false;
		}

		private static bool IsOpeningBrace(char c)
		{
			return false;
		}

		private static bool IsEndOfValue(char c)
		{
			return false;
		}

		private static bool IsTerminator(char c)
		{
			return false;
		}

		private static bool IsQuotationMark(char c)
		{
			return false;
		}

		private static bool IsEndOfStream(char c)
		{
			return false;
		}

		private string GetValueString()
		{
			return null;
		}

		internal override string Read_string()
		{
			return null;
		}

		internal override long Read_ref()
		{
			return 0L;
		}

		internal override char Read_char()
		{
			return '\0';
		}

		internal override float Read_float()
		{
			return 0f;
		}

		internal override int Read_int()
		{
			return 0;
		}

		internal override bool Read_bool()
		{
			return false;
		}

		internal override decimal Read_decimal()
		{
			return default(decimal);
		}

		internal override double Read_double()
		{
			return 0.0;
		}

		internal override long Read_long()
		{
			return 0L;
		}

		internal override ulong Read_ulong()
		{
			return 0uL;
		}

		internal override uint Read_uint()
		{
			return 0u;
		}

		internal override byte Read_byte()
		{
			return 0;
		}

		internal override sbyte Read_sbyte()
		{
			return 0;
		}

		internal override short Read_short()
		{
			return 0;
		}

		internal override ushort Read_ushort()
		{
			return 0;
		}

		internal override byte[] Read_byteArray()
		{
			return null;
		}

		public override void Dispose()
		{
		}
	}
}
