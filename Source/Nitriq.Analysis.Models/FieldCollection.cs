using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("FieldCollection: {Count}")]
	[Serializable]
	public class FieldCollection : BaseCollection<BfField>
	{
		[CompilerGenerated]
		private static Comparison<BfField> comparison_0;

		public FieldCollection NameIs(string name)
		{
			FieldCollection fieldCollection = new FieldCollection();
			fieldCollection.method_2(from field in this
			where field.Name == name
			select field);
			return fieldCollection;
		}

		internal override void ClearHash()
		{
			base.ClearHash();
			List<BfField> arg_29_0 = this._data;
			if (FieldCollection.comparison_0 == null)
			{
				FieldCollection.comparison_0 = new Comparison<BfField>(FieldCollection.smethod_0);
			}
			arg_29_0.Sort(FieldCollection.comparison_0);
		}

		internal void method_8(BinaryReader binaryReader_0)
		{
			int num = binaryReader_0.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				BfField bfField = new BfField();
				bfField.vmethod_1(binaryReader_0);
				base.method_0(bfField);
			}
		}

		internal void method_9(BfCache bfCache_0)
		{
			int[] ids = this._ids;
			for (int i = 0; i < ids.Length; i++)
			{
				int index = ids[i];
				this._data.Add(bfCache_0.Fields[index]);
			}
			this._ids = null;
			this._hash = null;
		}

		public override string ToString()
		{
			return "FieldCollection: " + this.Count<BfField>() + " items";
		}

		[CompilerGenerated]
		private static int smethod_0(BfField bfField_0, BfField bfField_1)
		{
			return bfField_0.Name.CompareTo(bfField_1.Name);
		}
	}
}
