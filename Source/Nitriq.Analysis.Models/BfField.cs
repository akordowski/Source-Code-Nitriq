using Mono.Cecil;
using System;
using System.Diagnostics;
using System.IO;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("Field: {Name}")]
	[Serializable]
	public class BfField : BfMember, IHaveUniqueName, IBfField
	{
		[Flags]
		public enum FieldBools : byte
		{
			None = 0,
			IsPublic = 1,
			IsInternal = 2,
			IsProtected = 4,
			IsProtectedOrInternal = 8,
			IsProtectedAndInternal = 16,
			IsPrivate = 32,
			IsStatic = 64,
			IsConstant = 128
		}

		private int int_0;

		[NonSerialized]
		private FieldDefinition fieldDefinition_0;

		private BfType bfType_0;

		private string string_0;

		private MethodCollection methodCollection_0 = new MethodCollection();

		private MethodCollection methodCollection_1 = new MethodCollection();

		private BfField.FieldBools fieldBools_0;

		public int FieldId
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

		public override BfType Type
		{
			get
			{
				return base.Type;
			}
		}

		public override string Name
		{
			get
			{
				return base.Name;
			}
		}

		public override string FullName
		{
			get
			{
				return base.FullName;
			}
		}

		public override TypeCollection TypesUsed
		{
			get
			{
				return base.TypesUsed;
			}
		}

		public override bool IsInCoreAssembly
		{
			get
			{
				return base.IsInCoreAssembly;
			}
		}

		public BfType FieldType
		{
			get
			{
				return this.bfType_0;
			}
		}

		public string UniqueName
		{
			get
			{
				return this.string_0;
			}
		}

		public MethodCollection SetByMethods
		{
			get
			{
				return this.methodCollection_0;
			}
		}

		public MethodCollection GotByMethods
		{
			get
			{
				return this.methodCollection_1;
			}
		}

		public bool IsPublic
		{
			get
			{
				return (byte)(this.fieldBools_0 & BfField.FieldBools.IsPublic) == 1;
			}
			private set
			{
				if (value)
				{
					this.fieldBools_0 |= BfField.FieldBools.IsPublic;
				}
				else
				{
					this.fieldBools_0 &= ~BfField.FieldBools.IsPublic;
				}
			}
		}

		public bool IsInternal
		{
			get
			{
				return (byte)(this.fieldBools_0 & BfField.FieldBools.IsInternal) == 2;
			}
			private set
			{
				if (value)
				{
					this.fieldBools_0 |= BfField.FieldBools.IsInternal;
				}
				else
				{
					this.fieldBools_0 &= ~BfField.FieldBools.IsInternal;
				}
			}
		}

		public bool IsProtected
		{
			get
			{
				return (byte)(this.fieldBools_0 & BfField.FieldBools.IsProtected) == 4;
			}
			private set
			{
				if (value)
				{
					this.fieldBools_0 |= BfField.FieldBools.IsProtected;
				}
				else
				{
					this.fieldBools_0 &= ~BfField.FieldBools.IsProtected;
				}
			}
		}

		public bool IsProtectedOrInternal
		{
			get
			{
				return (byte)(this.fieldBools_0 & BfField.FieldBools.IsProtectedOrInternal) == 8;
			}
			private set
			{
				if (value)
				{
					this.fieldBools_0 |= BfField.FieldBools.IsProtectedOrInternal;
				}
				else
				{
					this.fieldBools_0 &= ~BfField.FieldBools.IsProtectedOrInternal;
				}
			}
		}

		public bool IsProtectedAndInternal
		{
			get
			{
				return (byte)(this.fieldBools_0 & BfField.FieldBools.IsProtectedAndInternal) == 16;
			}
			private set
			{
				if (value)
				{
					this.fieldBools_0 |= BfField.FieldBools.IsProtectedAndInternal;
				}
				else
				{
					this.fieldBools_0 &= ~BfField.FieldBools.IsProtectedAndInternal;
				}
			}
		}

		public bool IsPrivate
		{
			get
			{
				return (byte)(this.fieldBools_0 & BfField.FieldBools.IsPrivate) == 32;
			}
			private set
			{
				if (value)
				{
					this.fieldBools_0 |= BfField.FieldBools.IsPrivate;
				}
				else
				{
					this.fieldBools_0 &= ~BfField.FieldBools.IsPrivate;
				}
			}
		}

		public bool IsStatic
		{
			get
			{
				return (byte)(this.fieldBools_0 & BfField.FieldBools.IsStatic) == 64;
			}
			private set
			{
				if (value)
				{
					this.fieldBools_0 |= BfField.FieldBools.IsStatic;
				}
				else
				{
					this.fieldBools_0 &= ~BfField.FieldBools.IsStatic;
				}
			}
		}

		public bool IsConstant
		{
			get
			{
				return (byte)(this.fieldBools_0 & BfField.FieldBools.IsConstant) == 128;
			}
			private set
			{
				if (value)
				{
					this.fieldBools_0 |= BfField.FieldBools.IsConstant;
				}
				else
				{
					this.fieldBools_0 &= ~BfField.FieldBools.IsConstant;
				}
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
			return "IField: " + this.FullName;
		}

		internal FieldDefinition method_0()
		{
			return this.fieldDefinition_0;
		}

		internal BfField(BfCache cache, FieldDefinition fieldDef, BfType type) : base(cache, fieldDef, type)
		{
			this.fieldDefinition_0 = fieldDef;
			this.int_0 = cache.method_20();
			this.IsInternal = this.fieldDefinition_0.IsAssembly;
			this.IsProtected = this.fieldDefinition_0.IsFamily;
			this.IsProtectedAndInternal = this.fieldDefinition_0.IsFamilyAndAssembly;
			this.IsProtectedOrInternal = this.fieldDefinition_0.IsFamilyOrAssembly;
			this.IsPrivate = this.fieldDefinition_0.IsPrivate;
			this.IsPublic = this.fieldDefinition_0.IsPublic;
			this.IsStatic = this.fieldDefinition_0.IsStatic;
			this.IsConstant = this.fieldDefinition_0.HasConstant;
			this.bfType_0 = this._cache.method_7(this.fieldDefinition_0.FieldType);
			this._typesUsed.method_1(this.bfType_0);
			this._typesUsed.method_2(this._cache.method_8(this.fieldDefinition_0.FieldType));
			this._typesUsed.ClearHash();
			this.string_0 = BfCache.smethod_2(this.fieldDefinition_0.DeclaringType);
		}

		internal BfField()
		{
		}

		internal void method_1()
		{
			this.fieldDefinition_0 = null;
		}

		internal override void vmethod_0(BinaryWriter writer)
		{
			base.vmethod_0(writer);
			writer.Write(this.int_0);
			writer.Write(this.string_0);
			writer.Write((byte)this.fieldBools_0);
			writer.Write((this.bfType_0 != null) ? this.bfType_0.Id : -1);
			this.methodCollection_0.method_5(writer);
			this.methodCollection_1.method_5(writer);
		}

		internal override void vmethod_1(BinaryReader reader)
		{
			base.vmethod_1(reader);
			this.int_0 = reader.ReadInt32();
			this.string_0 = reader.ReadString();
			this.fieldBools_0 = (BfField.FieldBools)reader.ReadByte();
			this.bfType_0 = new BfType
			{
				Id = reader.ReadInt32()
			};
			this.methodCollection_0.method_6(reader);
			this.methodCollection_1.method_6(reader);
		}

		internal override void vmethod_2(BfCache cache)
		{
			base.vmethod_2(cache);
			this.bfType_0 = ((this.bfType_0.Id == -1) ? null : cache.Types[this.bfType_0.Id]);
			this.methodCollection_0.method_9(cache);
			this.methodCollection_1.method_9(cache);
		}
	}
}
