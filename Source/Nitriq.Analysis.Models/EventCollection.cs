using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("EventCollection: {Count}")]
	[Serializable]
	public class EventCollection : BaseCollection<BfEvent>
	{
		[CompilerGenerated]
		private static Comparison<BfEvent> comparison_0;

		public EventCollection NameIs(string name)
		{
			EventCollection eventCollection = new EventCollection();
			eventCollection.method_2(from ev in this
			where ev.Name == name
			select ev);
			return eventCollection;
		}

		internal override void ClearHash()
		{
			base.ClearHash();
			List<BfEvent> arg_29_0 = this._data;
			if (EventCollection.comparison_0 == null)
			{
				EventCollection.comparison_0 = new Comparison<BfEvent>(EventCollection.smethod_0);
			}
			arg_29_0.Sort(EventCollection.comparison_0);
		}

		internal void method_8(BinaryReader binaryReader_0)
		{
			int num = binaryReader_0.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				BfEvent bfEvent = new BfEvent();
				bfEvent.vmethod_1(binaryReader_0);
				base.method_0(bfEvent);
			}
		}

		internal void method_9(BfCache bfCache_0)
		{
			int[] ids = this._ids;
			for (int i = 0; i < ids.Length; i++)
			{
				int index = ids[i];
				this._data.Add(bfCache_0.Events[index]);
			}
			this._ids = null;
			this._hash = null;
		}

		public override string ToString()
		{
			return "EventCollection: " + this.Count<BfEvent>() + " items";
		}

		[CompilerGenerated]
		private static int smethod_0(BfEvent bfEvent_0, BfEvent bfEvent_1)
		{
			return bfEvent_0.Name.CompareTo(bfEvent_1.Name);
		}
	}
}
