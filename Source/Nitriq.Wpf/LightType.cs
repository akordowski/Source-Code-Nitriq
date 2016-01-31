using Nitriq.Analysis.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Nitriq.Wpf
{
	public class LightType : IName
	{
		internal class Comparer : IEqualityComparer<LightType>
		{
			public bool Equals(LightType x, LightType y)
			{
				return x.bfType_0.Equals(y.bfType_0);
			}

			public int GetHashCode(LightType obj)
			{
				return obj.bfType_0.GetHashCode();
			}
		}

		private BfType bfType_0;

		private string string_0;

		private LightCollection<object> lightCollection_0 = new LightCollection<object>();

		public BfType BaseType
		{
			get
			{
				return this.bfType_0;
			}
		}

		public string Name
		{
			get
			{
				return this.bfType_0.Name;
			}
		}

		public string ChildType
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public LightCollection<object> Children
		{
			get
			{
				return this.lightCollection_0;
			}
			set
			{
				this.lightCollection_0 = value;
			}
		}

		public int ChildCount
		{
			get
			{
				return this.lightCollection_0.Count;
			}
		}

		public IEnumerable ChildWrapper
		{
			get
			{
				IEnumerable result;
				if (this.lightCollection_0.Count > 0)
				{
					result = new List<LightCollection<object>>
					{
						this.lightCollection_0
					};
				}
				else
				{
					result = null;
				}
				return result;
			}
		}

		public int ChildWrapperCount
		{
			get
			{
				int result;
				if (this.ChildWrapper == null)
				{
					result = 0;
				}
				else
				{
					result = this.ChildWrapper.Cast<object>().Count();
				}
				return result;
			}
		}

		public LightType(BfType type, string childType)
		{
			this.bfType_0 = type;
			this.string_0 = childType;
		}
	}
}
