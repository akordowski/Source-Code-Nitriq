using System;
using System.IO;

namespace Nitriq.Analysis.Models
{
	public abstract class BfSerializable
	{
		internal abstract int Id
		{
			get;
			set;
		}

		internal abstract void vmethod_0(BinaryWriter writer);

		internal abstract void vmethod_1(BinaryReader reader);

		internal abstract void vmethod_2(BfCache cache);
	}
}
