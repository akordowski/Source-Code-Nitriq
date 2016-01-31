using System;

namespace System.Linq.Dynamic
{
	public class DynamicProperty
	{
		private string string_0;

		private Type type_0;

		public string Name
		{
			get
			{
				return this.string_0;
			}
		}

		public Type Type
		{
			get
			{
				return this.type_0;
			}
		}

		public DynamicProperty(string name, Type type)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.string_0 = name;
			this.type_0 = type;
		}
	}
}
