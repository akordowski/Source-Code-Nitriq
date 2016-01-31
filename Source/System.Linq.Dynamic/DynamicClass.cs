using System;
using System.Reflection;
using System.Text;

namespace System.Linq.Dynamic
{
	public abstract class DynamicClass
	{
		public override string ToString()
		{
			PropertyInfo[] properties = base.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{");
			for (int i = 0; i < properties.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(properties[i].Name);
				stringBuilder.Append("=");
				stringBuilder.Append(properties[i].GetValue(this, null));
			}
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}
	}
}
