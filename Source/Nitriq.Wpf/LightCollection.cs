using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Nitriq.Wpf
{
	public class LightCollection<T> : IEnumerable, IEnumerable<T>
	{
		protected List<T> _data = new List<T>();

		protected HashSet<T> _hash = new HashSet<T>();

		public int Count
		{
			get
			{
				return this._data.Count;
			}
		}

		public T this[int index]
		{
			get
			{
				return this._data[index];
			}
		}

		internal static void smethod_0()
		{
		}

		internal LightCollection()
		{
		}

		public LightCollection(IEqualityComparer<T> comparer)
		{
			this._hash = new HashSet<T>(comparer);
		}

		internal void method_0()
		{
			this._hash = null;
		}

		internal void method_1(Comparison<T> comparison)
		{
			this._data.Sort(comparison);
		}

		internal T method_2(T item)
		{
			T result;
			if (item == null)
			{
				result = default(T);
			}
			else if (this._hash.Add(item))
			{
				this._data.Add(item);
				result = item;
			}
			else
			{
				result = this._hash.First((T t) => this._hash.Comparer.Equals(item, t));
			}
			return result;
		}

		internal void method_3(T item)
		{
			if (this._hash.Remove(item))
			{
				this._data.Remove(item);
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this._data.GetEnumerator();
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return this._data.GetEnumerator();
		}
	}
}
