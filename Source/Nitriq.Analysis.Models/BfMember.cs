using Mono.Cecil;
using System;
using System.IO;

namespace Nitriq.Analysis.Models
{
	[Serializable]
	public abstract class BfMember : BfSerializable
	{
		protected BfCache _cache;

		protected BfType _type;

		protected string _name;

		protected string _fullName;

		protected TypeCollection _typesUsed = new TypeCollection();

		public virtual BfType Type
		{
			get
			{
				return this._type;
			}
		}

		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		public virtual string FullName
		{
			get
			{
				return this._fullName;
			}
		}

		public virtual TypeCollection TypesUsed
		{
			get
			{
				return this._typesUsed;
			}
		}

		public virtual bool IsInCoreAssembly
		{
			get
			{
				return this._type.Assembly.IsCoreAssembly;
			}
		}

		internal BfMember()
		{
		}

		internal BfMember(BfCache cache, MemberReference memberRef, BfType type)
		{
			this._name = memberRef.Name;
			this._fullName = type.FullName + "." + this._name;
			this._cache = cache;
			this._type = type;
		}

		internal override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this._name);
			writer.Write(this._fullName);
			writer.Write((this._type != null) ? this._type.Id : -1);
			this._typesUsed.method_5(writer);
		}

		internal override void vmethod_1(BinaryReader reader)
		{
			this._name = reader.ReadString();
			this._fullName = reader.ReadString();
			this._type = new BfType
			{
				Id = reader.ReadInt32()
			};
			this._typesUsed.method_6(reader);
		}

		internal override void vmethod_2(BfCache cache)
		{
			this._type = ((this._type.Id == -1) ? null : cache.Types[this._type.Id]);
			this._typesUsed.method_9(cache);
		}
	}
}
