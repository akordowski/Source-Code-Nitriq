using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Nitriq.Analysis.Models
{
	[Serializable]
	public abstract class BaseCollection<T> : BaseClearHash, IEnumerable, IEnumerable<T> where T : BfSerializable
	{
		private static List<BaseClearHash> list_0;

		protected List<T> _data = new List<T>();

		protected HashSet<T> _hash = new HashSet<T>();

		protected int[] _ids;

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

		public static void ClearAllHashes()
		{
			foreach (BaseClearHash current in BaseCollection<T>.list_0)
			{
				current.ClearHash();
			}
			BaseCollection<T>.list_0.Clear();
		}

		internal BaseCollection()
		{
			BaseCollection<T>.list_0.Add(this);
		}

		internal override void ClearHash()
		{
			this._hash = null;
		}

		internal void method_0(T item)
		{
			if (item != null)
			{
				this._data.Add(item);
			}
		}

		internal void method_1(T item)
		{
			if (item != null && this._hash.Add(item))
			{
				this._data.Add(item);
			}
		}

		internal void method_2(IEnumerable<T> items)
		{
			foreach (T current in items)
			{
				this.method_1(current);
			}
		}

		internal void method_3(T item)
		{
			if (this._hash.Remove(item))
			{
				this._data.Remove(item);
			}
		}

		internal void method_4(BinaryWriter binaryWriter_0)
		{
			binaryWriter_0.Write(this.Count);
			foreach (T current in ((IEnumerable<T>)this))
			{
				current.vmethod_0(binaryWriter_0);
			}
		}

		internal void method_5(BinaryWriter binaryWriter_0)
		{
			binaryWriter_0.Write(this.Count);
			foreach (T current in ((IEnumerable<T>)this))
			{
				binaryWriter_0.Write(current.Id);
			}
		}

		internal void method_6(BinaryReader binaryReader_0)
		{
			this._ids = new int[binaryReader_0.ReadInt32()];
			for (int i = 0; i < this._ids.Length; i++)
			{
				this._ids[i] = binaryReader_0.ReadInt32();
			}
		}

		internal void method_7(BfCache bfCache_0)
		{
			foreach (T current in ((IEnumerable<T>)this))
			{
				current.vmethod_2(bfCache_0);
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

		static BaseCollection()
		{
			BaseCollection<T>.list_0 = new List<BaseClearHash>();
		}
	}
}
