using System;
using System.Collections.Generic;

namespace System.Linq.Dynamic
{
	public class ComparerWrapper<T> : IComparer<T>
	{
		private Func<T, T, int> func_0;

		public ComparerWrapper(Func<T, T, int> comparer)
		{
			this.func_0 = comparer;
		}

		public int Compare(T x, T y)
		{
			return this.func_0(x, y);
		}
	}
}
