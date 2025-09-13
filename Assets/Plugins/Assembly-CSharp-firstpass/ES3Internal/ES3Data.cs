using System;
using ES3Types;

namespace ES3Internal
{
	public struct ES3Data
	{
		public ES3Type type;

		public byte[] bytes;

		public ES3Data(Type type, byte[] bytes)
		{
			this.type = null;
			this.bytes = null;
		}

		public ES3Data(ES3Type type, byte[] bytes)
		{
			this.type = null;
			this.bytes = null;
		}
	}
}
