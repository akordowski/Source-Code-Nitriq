using System;
using System.Collections.Generic;

namespace Nitriq.Analysis.Models
{
	[Serializable]
	public class MethodDetails
	{
		private BfMethod bfMethod_0;

		private BfMethod bfMethod_1;

		private List<object> list_0;

		private List<object> list_1;

		private File file_0;

		private int int_0;

		public BfMethod Caller
		{
			get
			{
				return this.bfMethod_0;
			}
			internal set
			{
				this.bfMethod_0 = value;
			}
		}

		public BfMethod Callee
		{
			get
			{
				return this.bfMethod_1;
			}
			internal set
			{
				this.bfMethod_1 = value;
			}
		}

		public List<object> CallerGenericParams
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
			}
		}

		public List<object> CalleeGenericParams
		{
			get
			{
				return this.list_1;
			}
			set
			{
				this.list_1 = value;
			}
		}

		public File File
		{
			get
			{
				return this.file_0;
			}
		}

		public int LineNumber
		{
			get
			{
				return this.int_0;
			}
		}

		internal MethodDetails()
		{
		}
	}
}
