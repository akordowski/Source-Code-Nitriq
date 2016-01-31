using System;
using System.Diagnostics;
using System.IO;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("BfNamespace: {FullName}")]
	[Serializable]
	public class BfNamespace : BfSerializable, IBfNamespace
	{
		private BfCache bfCache_0;

		private string string_0;

		private string string_1;

		private int int_0;

		private NamespaceCollection namespaceCollection_0 = new NamespaceCollection();

		private TypeCollection typeCollection_0 = new TypeCollection();

		private int int_1;

		public string BaseName
		{
			get
			{
				return this.string_0;
			}
		}

		public string FullName
		{
			get
			{
				return this.string_1;
			}
		}

		public int Level
		{
			get
			{
				return this.int_0;
			}
		}

		public NamespaceCollection Namespaces
		{
			get
			{
				return this.namespaceCollection_0;
			}
		}

		public TypeCollection Types
		{
			get
			{
				return this.typeCollection_0;
			}
			internal set
			{
				this.typeCollection_0 = value;
			}
		}

		public int NamespaceId
		{
			get
			{
				return this.int_1;
			}
			internal set
			{
				this.int_1 = value;
			}
		}

		internal override int Id
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public override string ToString()
		{
			return "INamespace: " + this.FullName;
		}

		internal BfNamespace(BfCache cache, string fullname)
		{
			this.bfCache_0 = cache;
			string[] array = fullname.Split(new char[]
			{
				'.'
			});
			this.string_0 = array[array.Length - 1];
			this.string_1 = fullname;
			if (fullname == "")
			{
				this.int_0 = 0;
			}
			else
			{
				this.int_0 = array.Length;
			}
			this.int_1 = cache.method_16();
		}

		internal BfNamespace()
		{
		}

		internal override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.int_1);
			writer.Write(this.string_0);
			writer.Write(this.string_1);
			writer.Write(this.int_0);
			this.namespaceCollection_0.method_5(writer);
			this.typeCollection_0.method_5(writer);
		}

		internal override void vmethod_1(BinaryReader reader)
		{
			this.int_1 = reader.ReadInt32();
			this.string_0 = reader.ReadString();
			this.string_1 = reader.ReadString();
			this.int_0 = reader.ReadInt32();
			this.namespaceCollection_0.method_6(reader);
			this.typeCollection_0.method_6(reader);
		}

		internal override void vmethod_2(BfCache cache)
		{
			this.namespaceCollection_0.method_9(cache);
			this.typeCollection_0.method_9(cache);
		}
	}
}
