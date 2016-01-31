using System;

namespace System.Linq.Dynamic
{
	public sealed class ParseException : Exception
	{
		private int int_0;

		public int Position
		{
			get
			{
				return this.int_0;
			}
		}

		public ParseException(string message, int position) : base(message)
		{
			this.int_0 = position;
		}

		public override string ToString()
		{
			return string.Format("{0} (at index {1})", this.Message, this.int_0);
		}
	}
}
