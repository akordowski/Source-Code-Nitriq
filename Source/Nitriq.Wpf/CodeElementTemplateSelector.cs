using Nitriq.Analysis.Models;
using System;
using System.CodeDom.Compiler;
using System.Windows;
using System.Windows.Controls;

namespace Nitriq.Wpf
{
	public class CodeElementTemplateSelector : DataTemplateSelector
	{
		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			DataTemplate result;
			if (item == null)
			{
				result = null;
			}
			else
			{
				FrameworkElement frameworkElement = container as FrameworkElement;
				Type[] interfaces = item.GetType().GetInterfaces();
				int i = 0;
				while (i < interfaces.Length)
				{
					Type type = interfaces[i];
					if (!(type.Name == "IEnumerable`1"))
					{
						i++;
					}
					else
					{
						Type type2 = type.GetGenericArguments()[0];
						if (type2 == typeof(BfMethod))
						{
							result = (DataTemplate)frameworkElement.FindResource("MethodTemplate");
							return result;
						}
						if (type2 == typeof(BfField))
						{
							result = (DataTemplate)frameworkElement.FindResource("FieldTemplate");
							return result;
						}
						result = (DataTemplate)frameworkElement.FindResource("GenericGridTemplate");
						return result;
					}
				}
				if (item.GetType() == typeof(CompilerErrorCollection))
				{
					result = (DataTemplate)frameworkElement.FindResource("ErrorTemplate");
				}
				else
				{
					result = null;
				}
			}
			return result;
		}
	}
}
