using System;
using System.Collections;

namespace Nitriq.Wpf
{
	public static class EnumerableExtensions
	{
		public static int Count(this IEnumerable enumerable)
		{
			int result;
			if (enumerable == null)
			{
				result = 0;
			}
			else
			{
				int num = 0;
				foreach (object arg_1F_0 in enumerable)
				{
					num++;
				}
				result = num;
			}
			return result;
		}

		public static object First(this IEnumerable enumerable)
		{
			IEnumerator enumerator = enumerable.GetEnumerator();
			object result;
			try
			{
				if (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					result = current;
					return result;
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			result = null;
			return result;
		}
	}
}
