using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("BfType: {FullName}")]
	[Serializable]
	public class BfType : BfSerializable, IBfType, IHaveUniqueName
	{
		[Flags]
		private enum TypeBools : short
		{

		}

		private int int_0;

		private BfCache bfCache_0;

		private BfType bfType_0;

		private FieldCollection fieldCollection_0 = new FieldCollection();

		private MethodCollection methodCollection_0 = new MethodCollection();

		private EventCollection eventCollection_0 = new EventCollection();

		private TypeCollection typeCollection_0 = new TypeCollection();

		private TypeCollection typeCollection_1 = new TypeCollection();

		private TypeCollection typeCollection_2 = new TypeCollection();

		private TypeCollection typeCollection_3 = new TypeCollection();

		[NonSerialized]
		private TypeDefinition typeDefinition_0;

		private bool bool_0 = false;

		private bool bool_1 = false;

		private BfType.TypeBools typeBools_0;

		private BfAssembly bfAssembly_0;

		private string string_0;

		private int int_1;

		private string string_1;

		private BfNamespace bfNamespace_0;

		[CompilerGenerated]
		private static Func<BfType, bool> func_0;

		[CompilerGenerated]
		private static Func<BfMethod, int> func_1;

		[CompilerGenerated]
		private static Func<BfMethod, int> func_2;

		[CompilerGenerated]
		private static Func<BfMethod, int> func_3;

		[CompilerGenerated]
		private static Func<BfMethod, int> func_4;

		[CompilerGenerated]
		private static Func<BfMethod, int> func_5;

		public int TypeId
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

		public BfType BaseType
		{
			get
			{
				return this.bfType_0;
			}
		}

		public FieldCollection Fields
		{
			get
			{
				return this.fieldCollection_0;
			}
		}

		public MethodCollection Methods
		{
			get
			{
				return this.methodCollection_0;
			}
		}

		public EventCollection Events
		{
			get
			{
				return this.eventCollection_0;
			}
		}

		public TypeCollection Interfaces
		{
			get
			{
				return this.typeCollection_0;
			}
		}

		public TypeCollection TypesUsing
		{
			get
			{
				return this.typeCollection_1;
			}
		}

		public TypeCollection TypesUsed
		{
			get
			{
				return this.typeCollection_2;
			}
		}

		public TypeCollection DerivedTypes
		{
			get
			{
				return this.typeCollection_3;
			}
		}

		public BfAssembly Assembly
		{
			get
			{
				return this.bfAssembly_0;
			}
		}

		public string FullName
		{
			get
			{
				return ((this.bfNamespace_0 == null) ? "" : (this.bfNamespace_0.FullName + ".")) + this.string_1;
			}
		}

		public int GenericParameterCount
		{
			get
			{
				return this.int_1;
			}
		}

		public bool IsAbstract
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)1) == 1;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)1;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-2);
				}
			}
		}

		public bool IsClass
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)2) == 2;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)2;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-3);
				}
			}
		}

		public bool IsDelegate
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)16384) == 16384;
			}
			internal set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)16384;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-16385);
				}
			}
		}

		public bool IsEnum
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)4) == 4;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)4;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-5);
				}
			}
		}

		public bool IsInCoreAssembly
		{
			get
			{
				return this.bfAssembly_0.IsCoreAssembly;
			}
		}

		public bool IsInterface
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)16) == 16;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)16;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-17);
				}
			}
		}

		public bool IsInternal
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)64) == 64;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)64;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-65);
				}
			}
		}

		public bool IsNested
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)2048) == 2048;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)2048;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-2049);
				}
			}
		}

		public bool IsPrivate
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)1024) == 1024;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)1024;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-1025);
				}
			}
		}

		public bool IsProtected
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)128) == 128;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)128;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-129);
				}
			}
		}

		public bool IsProtectedAndInternal
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)512) == 512;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)512;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-513);
				}
			}
		}

		public bool IsProtectedOrInternal
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)256) == 256;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)256;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-257);
				}
			}
		}

		public bool IsPublic
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)4096) == 4096;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)4096;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-4097);
				}
			}
		}

		public bool IsSealed
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)8192) == 8192;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)8192;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-8193);
				}
			}
		}

		public bool IsStatic
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)32) == 32;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)32;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-33);
				}
			}
		}

		public bool IsValueType
		{
			get
			{
				return (short)(this.typeBools_0 & (BfType.TypeBools)8) == 8;
			}
			private set
			{
				if (value)
				{
					this.typeBools_0 |= (BfType.TypeBools)8;
				}
				else
				{
					this.typeBools_0 &= (BfType.TypeBools)(-9);
				}
			}
		}

		public string Name
		{
			get
			{
				return this.string_1;
			}
		}

		public BfNamespace Namespace
		{
			get
			{
				return this.bfNamespace_0;
			}
		}

		public string UniqueName
		{
			get
			{
				return this.FullName;
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

		public int PhysicalLineCount
		{
			get
			{
				IEnumerable<BfMethod> arg_23_0 = this.methodCollection_0;
				if (BfType.func_1 == null)
				{
					BfType.func_1 = new Func<BfMethod, int>(BfType.smethod_1);
				}
				return arg_23_0.Sum(BfType.func_1);
			}
		}

		public int LogicalLineCount
		{
			get
			{
				IEnumerable<BfMethod> arg_23_0 = this.methodCollection_0;
				if (BfType.func_2 == null)
				{
					BfType.func_2 = new Func<BfMethod, int>(BfType.smethod_2);
				}
				return arg_23_0.Sum(BfType.func_2);
			}
		}

		public int CommentLineCount
		{
			get
			{
				IEnumerable<BfMethod> arg_23_0 = this.methodCollection_0;
				if (BfType.func_3 == null)
				{
					BfType.func_3 = new Func<BfMethod, int>(BfType.smethod_3);
				}
				return arg_23_0.Sum(BfType.func_3);
			}
		}

		public int Cyclomatic
		{
			get
			{
				IEnumerable<BfMethod> arg_23_0 = this.methodCollection_0;
				if (BfType.func_4 == null)
				{
					BfType.func_4 = new Func<BfMethod, int>(BfType.smethod_4);
				}
				return arg_23_0.Sum(BfType.func_4);
			}
		}

		public int ILCount
		{
			get
			{
				IEnumerable<BfMethod> arg_23_0 = this.methodCollection_0;
				if (BfType.func_5 == null)
				{
					BfType.func_5 = new Func<BfMethod, int>(BfType.smethod_5);
				}
				return arg_23_0.Sum(BfType.func_5);
			}
		}

		public double PercentComment
		{
			get
			{
				return (this.CommentLineCount == 0 || this.PhysicalLineCount == 0) ? 0.0 : (100.0 * (double)this.CommentLineCount / (double)this.PhysicalLineCount);
			}
		}

		public int InheritanceDepth
		{
			get
			{
				int result;
				if (this.bfType_0 == null)
				{
					result = 0;
				}
				else
				{
					result = this.bfType_0.InheritanceDepth + 1;
				}
				return result;
			}
		}

		public override string ToString()
		{
			return "IType: " + this.FullName;
		}

		internal BfType(BfCache cache, TypeDefinition type, BfAssembly assembly)
		{
			this.typeDefinition_0 = type;
			this.bfCache_0 = cache;
			this.string_1 = this.typeDefinition_0.Name;
			this.bfAssembly_0 = assembly;
			this.bfNamespace_0 = cache.method_13(this);
			this.IsClass = this.typeDefinition_0.IsClass;
			this.IsEnum = this.typeDefinition_0.IsEnum;
			this.IsValueType = this.typeDefinition_0.IsValueType;
			this.IsInterface = this.typeDefinition_0.IsInterface;
			if (this.typeDefinition_0.IsNestedAssembly)
			{
				this.IsNested = true;
				this.IsInternal = true;
			}
			if (this.typeDefinition_0.IsNestedFamily)
			{
				this.IsNested = true;
				this.IsProtected = true;
			}
			if (this.typeDefinition_0.IsNestedFamilyAndAssembly)
			{
				this.IsNested = true;
				this.IsProtectedAndInternal = true;
			}
			if (this.typeDefinition_0.IsNestedFamilyOrAssembly)
			{
				this.IsNested = true;
				this.IsProtectedOrInternal = true;
			}
			if (this.typeDefinition_0.IsNestedPrivate)
			{
				this.IsNested = true;
				this.IsPrivate = true;
			}
			if (this.typeDefinition_0.IsNestedPublic)
			{
				this.IsNested = true;
				this.IsPublic = true;
			}
			this.IsInternal = this.typeDefinition_0.IsNotPublic;
			this.IsPublic = this.typeDefinition_0.IsPublic;
			if (this.typeDefinition_0.IsSealed && this.typeDefinition_0.IsAbstract)
			{
				this.IsStatic = true;
			}
			else
			{
				this.IsSealed = this.typeDefinition_0.IsSealed;
				this.IsAbstract = this.typeDefinition_0.IsAbstract;
			}
		}

		internal BfType()
		{
		}

		internal void method_1()
		{
			foreach (BfMethod current in ((IEnumerable<BfMethod>)this.methodCollection_0))
			{
				current.method_0();
			}
			foreach (BfEvent current2 in ((IEnumerable<BfEvent>)this.eventCollection_0))
			{
				current2.method_0();
			}
			foreach (BfField current3 in ((IEnumerable<BfField>)this.fieldCollection_0))
			{
				current3.method_1();
			}
			this.typeDefinition_0 = null;
		}

		internal TypeDefinition method_2()
		{
			return this.typeDefinition_0;
		}

		internal bool method_3()
		{
			return this.bool_0;
		}

		internal void method_4()
		{
			if (this.bool_0)
			{
				Logger.LogWarning("Type.Populate1", "populate got called more than once");
			}
			else
			{
				this.bool_0 = true;
				if (this.IsInCoreAssembly)
				{
					this.bfType_0 = this.bfCache_0.method_7(this.typeDefinition_0.BaseType);
					if (this.bfType_0 != null && this.bfType_0.FullName != "System.Object")
					{
						this.bfType_0.DerivedTypes.method_1(this);
					}
					foreach (TypeReference typeReference_ in this.typeDefinition_0.Interfaces)
					{
						BfType bfType = this.bfCache_0.method_7(typeReference_);
						this.typeCollection_0.method_1(bfType);
						bfType.DerivedTypes.method_1(this);
					}
					foreach (FieldDefinition fieldDef in this.typeDefinition_0.Fields)
					{
						BfField item = new BfField(this.bfCache_0, fieldDef, this);
						this.fieldCollection_0.method_1(item);
					}
					foreach (MethodDefinition methodDef in this.typeDefinition_0.Methods)
					{
						BfMethod bfMethod = new BfMethod(this.bfCache_0, methodDef, this);
						this.methodCollection_0.method_1(bfMethod);
						this.bfAssembly_0.method_5().Add(bfMethod.UniqueName, bfMethod);
					}
					foreach (MethodDefinition methodDef in this.typeDefinition_0.Constructors)
					{
						BfMethod bfMethod = new BfMethod(this.bfCache_0, methodDef, this);
						this.methodCollection_0.method_1(bfMethod);
						this.bfAssembly_0.method_5().Add(bfMethod.UniqueName, bfMethod);
					}
					foreach (EventDefinition eventDef in this.typeDefinition_0.Events)
					{
						BfEvent item2 = new BfEvent(this.bfCache_0, eventDef, this);
						this.eventCollection_0.method_1(item2);
					}
					this.int_1 = this.typeDefinition_0.GenericParameters.Count;
					this.method_6();
					this.typeCollection_0.ClearHash();
					this.fieldCollection_0.ClearHash();
					this.methodCollection_0.ClearHash();
					this.eventCollection_0.ClearHash();
				}
			}
		}

		internal void method_5()
		{
			this.method_7();
		}

		internal void method_6()
		{
		}

		private void method_7()
		{
			if (!this.bool_1)
			{
				this.bool_1 = true;
				IEnumerable<BfType> arg_3D_0 = this.bfCache_0.Types;
				if (BfType.func_0 == null)
				{
					BfType.func_0 = new Func<BfType, bool>(BfType.smethod_0);
				}
				BfType bfType = arg_3D_0.Where(BfType.func_0).First<BfType>();
				if (this.bfType_0 != null && this.bfType_0 != bfType)
				{
					this.bfType_0.method_5();
					this.method_9(this.bfType_0);
					this.method_8(this.bfType_0.TypesUsed);
				}
				foreach (BfType current in ((IEnumerable<BfType>)this.typeCollection_0))
				{
					this.method_9(current);
				}
				foreach (BfField current2 in ((IEnumerable<BfField>)this.fieldCollection_0))
				{
					this.method_8(current2.TypesUsed);
				}
				foreach (BfMethod current3 in ((IEnumerable<BfMethod>)this.methodCollection_0))
				{
					this.method_8(current3.TypesUsed);
				}
				foreach (BfEvent current4 in ((IEnumerable<BfEvent>)this.eventCollection_0))
				{
					this.method_8(current4.TypesUsed);
				}
				this.typeCollection_2.ClearHash();
			}
		}

		private void method_8(IEnumerable<BfType> types)
		{
			foreach (BfType current in types)
			{
				this.method_9(current);
			}
		}

		private void method_9(BfType bfType_1)
		{
			if (bfType_1 != null)
			{
				if (this.bfAssembly_0.IsCoreAssembly)
				{
					this.typeCollection_2.method_1(bfType_1);
				}
				bfType_1.TypesUsing.method_1(this);
			}
		}

		internal override void vmethod_0(BinaryWriter writer)
		{
			writer.Write((short)this.typeBools_0);
			writer.Write(this.bool_0);
			writer.Write(this.bool_1);
			writer.Write(this.int_0);
			writer.Write(this.string_1);
			writer.Write(this.int_1);
			writer.Write((this.bfType_0 != null) ? this.bfType_0.Id : -1);
			this.fieldCollection_0.method_5(writer);
			this.methodCollection_0.method_5(writer);
			this.eventCollection_0.method_5(writer);
			this.typeCollection_0.method_5(writer);
			this.typeCollection_1.method_5(writer);
			this.typeCollection_2.method_5(writer);
			this.typeCollection_3.method_5(writer);
			writer.Write((this.bfAssembly_0 != null) ? this.bfAssembly_0.Id : -1);
			writer.Write((this.bfNamespace_0 != null) ? this.bfNamespace_0.Id : -1);
		}

		internal override void vmethod_1(BinaryReader reader)
		{
			this.typeBools_0 = (BfType.TypeBools)reader.ReadInt16();
			this.bool_0 = reader.ReadBoolean();
			this.bool_1 = reader.ReadBoolean();
			this.int_0 = reader.ReadInt32();
			this.string_1 = reader.ReadString();
			this.int_1 = reader.ReadInt32();
			this.bfType_0 = new BfType
			{
				Id = reader.ReadInt32()
			};
			this.fieldCollection_0.method_6(reader);
			this.methodCollection_0.method_6(reader);
			this.eventCollection_0.method_6(reader);
			this.typeCollection_0.method_6(reader);
			this.typeCollection_1.method_6(reader);
			this.typeCollection_2.method_6(reader);
			this.typeCollection_3.method_6(reader);
			this.bfAssembly_0 = new BfAssembly
			{
				Id = reader.ReadInt32()
			};
			this.bfNamespace_0 = new BfNamespace
			{
				Id = reader.ReadInt32()
			};
		}

		internal override void vmethod_2(BfCache cache)
		{
			this.bfType_0 = ((this.bfType_0.Id == -1) ? null : cache.Types[this.bfType_0.Id]);
			this.fieldCollection_0.method_9(cache);
			this.methodCollection_0.method_9(cache);
			this.eventCollection_0.method_9(cache);
			this.typeCollection_0.method_9(cache);
			this.typeCollection_1.method_9(cache);
			this.typeCollection_2.method_9(cache);
			this.typeCollection_3.method_9(cache);
			this.bfAssembly_0 = ((this.bfAssembly_0.Id == -1) ? null : cache.Assemblies[this.bfAssembly_0.Id]);
			this.bfNamespace_0 = ((this.bfNamespace_0.Id == -1) ? null : cache.Namespaces[this.bfNamespace_0.Id]);
		}

		[CompilerGenerated]
		private static bool smethod_0(BfType bfType_1)
		{
			return bfType_1.FullName == "System.Object";
		}

		[CompilerGenerated]
		private static int smethod_1(BfMethod bfMethod_0)
		{
			return bfMethod_0.PhysicalLineCount;
		}

		[CompilerGenerated]
		private static int smethod_2(BfMethod bfMethod_0)
		{
			return bfMethod_0.LogicalLineCount;
		}

		[CompilerGenerated]
		private static int smethod_3(BfMethod bfMethod_0)
		{
			return bfMethod_0.CommentLineCount;
		}

		[CompilerGenerated]
		private static int smethod_4(BfMethod bfMethod_0)
		{
			return bfMethod_0.Cyclomatic;
		}

		[CompilerGenerated]
		private static int smethod_5(BfMethod bfMethod_0)
		{
			return bfMethod_0.ILCount;
		}
	}
}
