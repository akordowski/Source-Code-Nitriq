using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("MethodCollection: {Count}")]
	[Serializable]
	public class MethodCollection : BaseCollection<BfMethod>
	{
		[CompilerGenerated]
		private static Comparison<BfMethod> comparison_0;

		public MethodCollection NameIs(string name)
		{
			MethodCollection methodCollection = new MethodCollection();
			methodCollection.method_2(from method in this
			where method.Name == name
			select method);
			return methodCollection;
		}

		public MethodCollection FullNameIs(string name)
		{
			MethodCollection methodCollection = new MethodCollection();
			methodCollection.method_2(from method in this
			where method.FullName == name
			select method);
			return methodCollection;
		}

		internal override void ClearHash()
		{
			base.ClearHash();
			List<BfMethod> arg_29_0 = this._data;
			if (MethodCollection.comparison_0 == null)
			{
				MethodCollection.comparison_0 = new Comparison<BfMethod>(MethodCollection.smethod_0);
			}
			arg_29_0.Sort(MethodCollection.comparison_0);
		}

		internal void method_8(BinaryReader binaryReader_0)
		{
			int num = binaryReader_0.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				BfMethod bfMethod = new BfMethod();
				bfMethod.vmethod_1(binaryReader_0);
				base.method_0(bfMethod);
			}
		}

		internal void method_9(BfCache bfCache_0)
		{
			int[] ids = this._ids;
			for (int i = 0; i < ids.Length; i++)
			{
				int index = ids[i];
				this._data.Add(bfCache_0.Methods[index]);
			}
			this._ids = null;
			this._hash = null;
		}

		public override string ToString()
		{
			return "MethodCollection: " + this.Count<BfMethod>() + " items";
		}

		[CompilerGenerated]
		private static int smethod_0(BfMethod bfMethod_0, BfMethod bfMethod_1)
		{
			return bfMethod_0.Name.CompareTo(bfMethod_1.Name);
		}
	}
}
