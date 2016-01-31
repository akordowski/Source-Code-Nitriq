using Mono.Cecil;
using System;
using System.Diagnostics;
using System.IO;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("Event: {Name}")]
	[Serializable]
	public class BfEvent : BfMember, IHaveUniqueName, IBfEvent
	{
		[Flags]
		public enum EventBools : byte
		{
			None = 0,
			IsPublic = 1,
			IsInternal = 2,
			IsProtected = 4,
			IsPrivate = 8,
			IsStatic = 16
		}

		private int int_0;

		[NonSerialized]
		private EventDefinition eventDefinition_0;

		private BfType bfType_0;

		private BfEvent.EventBools eventBools_0;

		public int EventId
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

		public BfType EventType
		{
			get
			{
				return this.bfType_0;
			}
		}

		public bool IsPublic
		{
			get
			{
				return (byte)(this.eventBools_0 & BfEvent.EventBools.IsPublic) == 1;
			}
			private set
			{
				if (value)
				{
					this.eventBools_0 |= BfEvent.EventBools.IsPublic;
				}
				else
				{
					this.eventBools_0 &= ~BfEvent.EventBools.IsPublic;
				}
			}
		}

		public bool IsInternal
		{
			get
			{
				return (byte)(this.eventBools_0 & BfEvent.EventBools.IsInternal) == 2;
			}
			private set
			{
				if (value)
				{
					this.eventBools_0 |= BfEvent.EventBools.IsInternal;
				}
				else
				{
					this.eventBools_0 &= ~BfEvent.EventBools.IsInternal;
				}
			}
		}

		public bool IsProtected
		{
			get
			{
				return (byte)(this.eventBools_0 & BfEvent.EventBools.IsProtected) == 4;
			}
			private set
			{
				if (value)
				{
					this.eventBools_0 |= BfEvent.EventBools.IsProtected;
				}
				else
				{
					this.eventBools_0 &= ~BfEvent.EventBools.IsProtected;
				}
			}
		}

		public bool IsPrivate
		{
			get
			{
				return (byte)(this.eventBools_0 & BfEvent.EventBools.IsPrivate) == 8;
			}
			private set
			{
				if (value)
				{
					this.eventBools_0 |= BfEvent.EventBools.IsPrivate;
				}
				else
				{
					this.eventBools_0 &= ~BfEvent.EventBools.IsPrivate;
				}
			}
		}

		public bool IsStatic
		{
			get
			{
				return (byte)(this.eventBools_0 & BfEvent.EventBools.IsStatic) == 16;
			}
			private set
			{
				if (value)
				{
					this.eventBools_0 |= BfEvent.EventBools.IsStatic;
				}
				else
				{
					this.eventBools_0 &= ~BfEvent.EventBools.IsStatic;
				}
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

		public override string ToString()
		{
			return "IEvent: " + this.FullName;
		}

		internal BfEvent(BfCache cache, EventDefinition eventDef, BfType type) : base(cache, eventDef, type)
		{
			this.eventDefinition_0 = eventDef;
			this.int_0 = this._cache.method_21();
			this.bfType_0 = this._cache.method_7(this.eventDefinition_0.EventType);
			this._typesUsed.method_1(this.bfType_0);
			this._typesUsed.method_2(this._cache.method_8(this.eventDefinition_0.EventType));
			this._typesUsed.ClearHash();
			this.IsInternal = this.eventDefinition_0.AddMethod.IsAssembly;
			this.IsProtected = this.eventDefinition_0.AddMethod.IsFamily;
			this.IsPrivate = this.eventDefinition_0.AddMethod.IsPrivate;
			this.IsPublic = this.eventDefinition_0.AddMethod.IsPublic;
			this.IsStatic = this.eventDefinition_0.AddMethod.IsStatic;
			this._cache.Events.method_1(this);
		}

		internal BfEvent()
		{
		}

		internal void method_0()
		{
			this.eventDefinition_0 = null;
		}

		internal override void vmethod_0(BinaryWriter writer)
		{
			base.vmethod_0(writer);
			writer.Write(this.int_0);
			writer.Write((byte)this.eventBools_0);
			writer.Write(this.bfType_0.Id);
		}

		internal override void vmethod_1(BinaryReader reader)
		{
			base.vmethod_1(reader);
			this.int_0 = reader.ReadInt32();
			this.eventBools_0 = (BfEvent.EventBools)reader.ReadByte();
			this.bfType_0 = new BfType
			{
				Id = reader.ReadInt32()
			};
		}

		internal override void vmethod_2(BfCache cache)
		{
			base.vmethod_2(cache);
			this.bfType_0 = cache.Types[this.bfType_0.Id];
		}
	}
}
