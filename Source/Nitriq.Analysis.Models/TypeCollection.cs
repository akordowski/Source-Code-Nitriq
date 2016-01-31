using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("TypeCollection: {Count}")]
	[Serializable]
	public class TypeCollection : BaseCollection<BfType>
	{
		[CompilerGenerated]
		private static Comparison<BfType> comparison_0;

		internal override void ClearHash()
		{
			base.ClearHash();
			List<BfType> arg_29_0 = this._data;
			if (TypeCollection.comparison_0 == null)
			{
				TypeCollection.comparison_0 = new Comparison<BfType>(TypeCollection.smethod_0);
			}
			arg_29_0.Sort(TypeCollection.comparison_0);
		}

		public TypeCollection NameIs(string name)
		{
			TypeCollection typeCollection = new TypeCollection();
			typeCollection.method_2(from type in this
			where type.Name == name
			select type);
			return typeCollection;
		}

		public TypeCollection FullNameIs(string name)
		{
			TypeCollection typeCollection = new TypeCollection();
			typeCollection.method_2(from type in this
			where type.FullName == name
			select type);
			return typeCollection;
		}

		internal void method_8(BinaryReader binaryReader_0)
		{
			int num = binaryReader_0.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				BfType bfType = new BfType();
				bfType.vmethod_1(binaryReader_0);
				base.method_0(bfType);
			}
		}

		internal void method_9(BfCache bfCache_0)
		{
			int[] ids = this._ids;
			for (int i = 0; i < ids.Length; i++)
			{
				int index = ids[i];
				this._data.Add(bfCache_0.Types[index]);
			}
			this._ids = null;
			this._hash = null;
		}

		public override string ToString()
		{
			return "TypeCollection: " + this.Count<BfType>() + " items";
		}

		[CompilerGenerated]
		private static int smethod_0(BfType bfType_0, BfType bfType_1)
		{
			return bfType_0.Name.CompareTo(bfType_1.Name);
		}
	}
}
