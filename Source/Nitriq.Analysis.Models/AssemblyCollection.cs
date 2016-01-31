using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("AssemblyCollection: {Count}")]
	[Serializable]
	public class AssemblyCollection : BaseCollection<BfAssembly>
	{
		[CompilerGenerated]
		private static Comparison<BfAssembly> comparison_0;

		internal override void ClearHash()
		{
			base.ClearHash();
			List<BfAssembly> arg_29_0 = this._data;
			if (AssemblyCollection.comparison_0 == null)
			{
				AssemblyCollection.comparison_0 = new Comparison<BfAssembly>(AssemblyCollection.smethod_0);
			}
			arg_29_0.Sort(AssemblyCollection.comparison_0);
		}

		internal void method_8(BinaryReader binaryReader_0)
		{
			int num = binaryReader_0.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				BfAssembly bfAssembly = new BfAssembly();
				bfAssembly.vmethod_1(binaryReader_0);
				base.method_0(bfAssembly);
			}
		}

		internal void method_9(BfCache bfCache_0)
		{
			int[] ids = this._ids;
			for (int i = 0; i < ids.Length; i++)
			{
				int index = ids[i];
				this._data.Add(bfCache_0.Assemblies[index]);
			}
			this._ids = null;
			this._hash = null;
		}

		public override string ToString()
		{
			return "AssemblyCollection: " + this.Count<BfAssembly>() + " items";
		}

		[CompilerGenerated]
		private static int smethod_0(BfAssembly bfAssembly_0, BfAssembly bfAssembly_1)
		{
			return bfAssembly_0.Name.CompareTo(bfAssembly_1.Name);
		}
	}
}
