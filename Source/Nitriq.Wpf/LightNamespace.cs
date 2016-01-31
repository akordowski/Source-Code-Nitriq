using Nitriq.Analysis.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nitriq.Wpf
{
	public class LightNamespace : IName
	{
		internal class Comparer : IEqualityComparer<LightNamespace>
		{
			public bool Equals(LightNamespace x, LightNamespace y)
			{
				return x.bfNamespace_0.Equals(y.bfNamespace_0);
			}

			public int GetHashCode(LightNamespace obj)
			{
				return obj.bfNamespace_0.GetHashCode();
			}
		}

		private BfNamespace bfNamespace_0;

		private LightCollection<LightType> lightCollection_0 = new LightCollection<LightType>(new LightType.Comparer());

		private LightCollection<object> lightCollection_1 = new LightCollection<object>();

		private string string_0;

		[CompilerGenerated]
		private static Func<LightType, int> func_0;

		public BfNamespace BaseNamespace
		{
			get
			{
				return this.bfNamespace_0;
			}
		}

		public string Name
		{
			get
			{
				return this.bfNamespace_0.FullName;
			}
		}

		public LightCollection<LightType> Types
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

		public LightCollection<object> Children
		{
			get
			{
				return this.lightCollection_1;
			}
			set
			{
				this.lightCollection_1 = value;
			}
		}

		public IEnumerable ChildWrapper
		{
			get
			{
				IEnumerable result;
				if (this.Children.Count > 0)
				{
					result = new List<LightCollection<object>>
					{
						this.lightCollection_1
					};
				}
				else if (this.lightCollection_0.Count > 0)
				{
					result = this.lightCollection_0;
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
				return this.ChildWrapper.Cast<object>().Count();
			}
		}

		public int TypeCount
		{
			get
			{
				return this.lightCollection_0.Count;
			}
		}

		public int ChildCount
		{
			get
			{
				IEnumerable<LightType> arg_23_0 = this.lightCollection_0;
				if (LightNamespace.func_0 == null)
				{
					LightNamespace.func_0 = new Func<LightType, int>(LightNamespace.smethod_0);
				}
				return arg_23_0.Sum(LightNamespace.func_0);
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

		public LightNamespace(BfNamespace namesp, string childType)
		{
			this.bfNamespace_0 = namesp;
			this.string_0 = childType;
		}

		[CompilerGenerated]
		private static int smethod_0(LightType lightType_0)
		{
			return lightType_0.ChildCount;
		}
	}
}
