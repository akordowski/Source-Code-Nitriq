using Nitriq.Analysis.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Nitriq.Wpf
{
	public class LightAssembly : IName
	{
		internal class Comparer : IEqualityComparer<LightAssembly>
		{
			public bool Equals(LightAssembly x, LightAssembly y)
			{
				return x.bfAssembly_0.Equals(y.bfAssembly_0);
			}

			public int GetHashCode(LightAssembly obj)
			{
				return obj.bfAssembly_0.GetHashCode();
			}
		}

		private BfAssembly bfAssembly_0;

		private LightCollection<LightNamespace> lightCollection_0 = new LightCollection<LightNamespace>(new LightNamespace.Comparer());

		private LightCollection<object> lightCollection_1 = new LightCollection<object>();

		private string string_0;

		[CompilerGenerated]
		private static Func<LightNamespace, int> func_0;

		[CompilerGenerated]
		private static Func<LightNamespace, int> func_1;

		[CompilerGenerated]
		private static Func<LightType, int> func_2;

		public BfAssembly BaseAssembly
		{
			get
			{
				return this.bfAssembly_0;
			}
		}

		public string Name
		{
			get
			{
				return this.bfAssembly_0.Name;
			}
		}

		public LightCollection<LightNamespace> Namespaces
		{
			get
			{
				return this.lightCollection_0;
			}
		}

		public int NamespaceCount
		{
			get
			{
				return this.lightCollection_0.Count;
			}
		}

		public int TypeCount
		{
			get
			{
				IEnumerable<LightNamespace> arg_23_0 = this.lightCollection_0;
				if (LightAssembly.func_0 == null)
				{
					LightAssembly.func_0 = new Func<LightNamespace, int>(LightAssembly.smethod_0);
				}
				return arg_23_0.Sum(LightAssembly.func_0);
			}
		}

		public int ChildCount
		{
			get
			{
				IEnumerable<LightNamespace> arg_23_0 = this.lightCollection_0;
				if (LightAssembly.func_1 == null)
				{
					LightAssembly.func_1 = new Func<LightNamespace, int>(LightAssembly.smethod_1);
				}
				return arg_23_0.Sum(LightAssembly.func_1);
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

		public LightAssembly(BfAssembly assembly, string childType)
		{
			this.bfAssembly_0 = assembly;
			this.string_0 = childType;
		}

		[CompilerGenerated]
		private static int smethod_0(LightNamespace lightNamespace_0)
		{
			return lightNamespace_0.TypeCount;
		}

		[CompilerGenerated]
		private static int smethod_1(LightNamespace lightNamespace_0)
		{
			IEnumerable<LightType> arg_23_0 = lightNamespace_0.Types;
			if (LightAssembly.func_2 == null)
			{
				LightAssembly.func_2 = new Func<LightType, int>(LightAssembly.smethod_2);
			}
			return arg_23_0.Sum(LightAssembly.func_2);
		}

		[CompilerGenerated]
		private static int smethod_2(LightType lightType_0)
		{
			return lightType_0.ChildCount;
		}
	}
}
