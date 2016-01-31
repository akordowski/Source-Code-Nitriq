using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("NamespaceCollection: {Count}")]
	[Serializable]
	public class NamespaceCollection : BaseCollection<BfNamespace>
	{
		[CompilerGenerated]
		private static Comparison<BfNamespace> comparison_0;

		internal override void ClearHash()
		{
			base.ClearHash();
			List<BfNamespace> arg_29_0 = this._data;
			if (NamespaceCollection.comparison_0 == null)
			{
				NamespaceCollection.comparison_0 = new Comparison<BfNamespace>(NamespaceCollection.smethod_0);
			}
			arg_29_0.Sort(NamespaceCollection.comparison_0);
		}

		internal void method_8(BinaryReader binaryReader_0)
		{
			int num = binaryReader_0.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				BfNamespace bfNamespace = new BfNamespace();
				bfNamespace.vmethod_1(binaryReader_0);
				base.method_0(bfNamespace);
			}
		}

		internal void method_9(BfCache bfCache_0)
		{
			int[] ids = this._ids;
			for (int i = 0; i < ids.Length; i++)
			{
				int index = ids[i];
				this._data.Add(bfCache_0.Namespaces[index]);
			}
			this._ids = null;
			this._hash = null;
		}

		public override string ToString()
		{
			return "NamespaceCollection: " + this.Count<BfNamespace>() + " items";
		}

		[CompilerGenerated]
		private static int smethod_0(BfNamespace bfNamespace_0, BfNamespace bfNamespace_1)
		{
			return bfNamespace_0.FullName.CompareTo(bfNamespace_1.FullName);
		}
	}
}
