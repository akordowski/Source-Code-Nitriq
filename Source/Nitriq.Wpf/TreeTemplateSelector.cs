using Nitriq.Analysis.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Nitriq.Wpf
{
	public class TreeTemplateSelector : DataTemplateSelector
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
				Type type = item.GetType();
				if (type == typeof(BfMethod))
				{
					result = (DataTemplate)frameworkElement.FindResource("TreeBfMethodTemplate");
				}
				else if (type == typeof(BfField))
				{
					result = (DataTemplate)frameworkElement.FindResource("TreeBfFieldTemplate");
				}
				else if (type == typeof(BfEvent))
				{
					result = (DataTemplate)frameworkElement.FindResource("TreeBfEventTemplate");
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
