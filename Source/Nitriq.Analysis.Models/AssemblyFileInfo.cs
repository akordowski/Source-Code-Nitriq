using System;

namespace Nitriq.Analysis.Models
{
	public class AssemblyFileInfo
	{
		private string string_0;

		private string string_1;

		private string string_2;

		public string Name
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public string Version
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		public string Path
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}
	}
}
