using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Pdb;
using System;
using System.Collections.Generic;
using System.IO;

namespace Nitriq.Analysis.Models
{
	[Serializable]
	public class BfAssembly : BfSerializable, IBfAssembly
	{
		private int int_0;

		private BfCache bfCache_0;

		private ISymbolReader isymbolReader_0;

		[NonSerialized]
		private AssemblyDefinition assemblyDefinition_0;

		private Dictionary<string, BfType> dictionary_0 = new Dictionary<string, BfType>();

		private Dictionary<string, BfMethod> dictionary_1 = new Dictionary<string, BfMethod>();

		private string string_0;

		private NamespaceCollection namespaceCollection_0 = new NamespaceCollection();

		private string string_1;

		private bool bool_0;

		public int AssemblyId
		{
			get
			{
				return this.int_0;
			}
			internal set
			{
				this.int_0 = value;
			}
		}

		public string Version
		{
			get
			{
				return this.string_0;
			}
		}

		public NamespaceCollection Namespaces
		{
			get
			{
				return this.namespaceCollection_0;
			}
		}

		public string Name
		{
			get
			{
				return this.string_1;
			}
		}

		public bool IsCoreAssembly
		{
			get
			{
				return this.bool_0;
			}
		}

		internal override int Id
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public override string ToString()
		{
			return "IAssembly: " + this.Name;
		}

		internal BfAssembly(BfCache cache, AssemblyDefinition assemblyDef, bool isCoreAssembly, string rootDirectory)
		{
			this.int_0 = cache.method_15();
			this.assemblyDefinition_0 = assemblyDef;
			this.string_1 = assemblyDef.Name.Name;
			this.bool_0 = isCoreAssembly;
			this.string_0 = this.assemblyDefinition_0.Name.Version.ToString();
			try
			{
				PdbFactory pdbFactory = new PdbFactory();
				string text = Path.Combine(rootDirectory, this.assemblyDefinition_0.Name.Name + ".dll");
				if (System.IO.File.Exists(text))
				{
					this.isymbolReader_0 = pdbFactory.CreateReader(null, text);
				}
				text = Path.Combine(rootDirectory, this.assemblyDefinition_0.Name.Name + ".exe");
				if (System.IO.File.Exists(text))
				{
					this.isymbolReader_0 = pdbFactory.CreateReader(null, text);
				}
			}
			catch (Exception ex)
			{
				Logger.LogWarning("AssemblyConstructor", "Something went wrong " + ex.ToString());
			}
		}

		internal BfAssembly()
		{
		}

		internal void method_1()
		{
			this.assemblyDefinition_0 = null;
			if (this.isymbolReader_0 != null)
			{
				this.isymbolReader_0.Dispose();
				this.isymbolReader_0 = null;
			}
			this.dictionary_0 = null;
			this.dictionary_1 = null;
		}

		internal ISymbolReader method_2()
		{
			return this.isymbolReader_0;
		}

		internal AssemblyDefinition method_3()
		{
			return this.assemblyDefinition_0;
		}

		internal Dictionary<string, BfType> method_4()
		{
			return this.dictionary_0;
		}

		internal Dictionary<string, BfMethod> method_5()
		{
			return this.dictionary_1;
		}

		internal override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.int_0);
			writer.Write(this.string_1);
			writer.Write(this.bool_0);
			this.namespaceCollection_0.method_5(writer);
		}

		internal override void vmethod_1(BinaryReader reader)
		{
			this.int_0 = reader.ReadInt32();
			this.string_1 = reader.ReadString();
			this.bool_0 = reader.ReadBoolean();
			this.namespaceCollection_0.method_6(reader);
		}

		internal override void vmethod_2(BfCache cache)
		{
			this.namespaceCollection_0.method_9(cache);
		}
	}
}
