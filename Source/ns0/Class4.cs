using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;

namespace ns0
{
	internal class Class4 : IEquatable<Class4>
	{
		public DynamicProperty[] dynamicProperty_0;

		public int int_0;

		public Class4(IEnumerable<DynamicProperty> properties)
		{
			this.dynamicProperty_0 = properties.ToArray<DynamicProperty>();
			this.int_0 = 0;
			foreach (DynamicProperty current in properties)
			{
				this.int_0 ^= (current.Name.GetHashCode() ^ current.Type.GetHashCode());
			}
		}

		public override int GetHashCode()
		{
			return this.int_0;
		}

		public override bool Equals(object obj)
		{
			return obj is Class4 && this.Equals((Class4)obj);
		}

		public bool Equals(Class4 other)
		{
			bool result;
			if (this.dynamicProperty_0.Length != other.dynamicProperty_0.Length)
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < this.dynamicProperty_0.Length; i++)
				{
					if (this.dynamicProperty_0[i].Name != other.dynamicProperty_0[i].Name || this.dynamicProperty_0[i].Type != other.dynamicProperty_0[i].Type)
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			return result;
		}
	}
}
