using System;
using System.Collections.Generic;

namespace Nitriq.Analysis.Models
{
	[Serializable]
	public class BfDictionary<TKey, TValue>
	{
		private SortedDictionary<TKey, TValue> sortedDictionary_0;

		public int Count
		{
			get
			{
				return this.sortedDictionary_0.Count;
			}
		}

		public TValue this[TKey key]
		{
			get
			{
				return this.sortedDictionary_0[key];
			}
		}

		public BfDictionary()
		{
			this.sortedDictionary_0 = new SortedDictionary<TKey, TValue>();
		}

		public BfDictionary(IComparer<TKey> comparer)
		{
			this.sortedDictionary_0 = new SortedDictionary<TKey, TValue>(comparer);
		}

		internal void method_0(TKey key, TValue value)
		{
			if (!this.sortedDictionary_0.ContainsKey(key))
			{
				this.sortedDictionary_0.Add(key, value);
			}
		}

		internal void method_1(TKey key)
		{
			this.sortedDictionary_0.Remove(key);
		}

		public bool Contains(TKey key)
		{
			return this.sortedDictionary_0.ContainsKey(key);
		}

		public bool ContainsKey(TKey key)
		{
			return this.sortedDictionary_0.ContainsKey(key);
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			return this.sortedDictionary_0.TryGetValue(key, out value);
		}
	}
}
