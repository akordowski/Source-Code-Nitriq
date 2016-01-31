using System;

namespace Nitriq.Analysis.Models
{
	public class NitriqException : Exception
	{
		private string string_0;

		public string Name
		{
			get
			{
				return this.string_0;
			}
		}

		public NitriqException(string name, string message) : base(message)
		{
			this.string_0 = name;
		}
	}
}
