using System;

namespace Nitriq.Analysis.Models
{
	[Serializable]
	public class RefDetail
	{
		private File file_0;

		private int int_0;

		public File File
		{
			get
			{
				return this.file_0;
			}
			internal set
			{
				this.file_0 = value;
			}
		}

		public int LineNumber
		{
			get
			{
				return this.int_0;
			}
			internal set
			{
				this.int_0 = value;
			}
		}
	}
}
