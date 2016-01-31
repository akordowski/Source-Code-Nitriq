using Nitriq.Project.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Nitriq.Wpf
{
	public class RuleTemplateSelector : DataTemplateSelector
	{
		private DataTemplate dataTemplate_0;

		private DataTemplate dataTemplate_1;

		public DataTemplate RuleTemplate
		{
			get
			{
				return this.dataTemplate_0;
			}
			set
			{
				this.dataTemplate_0 = value;
			}
		}

		public DataTemplate RuleCategoryTemplate
		{
			get
			{
				return this.dataTemplate_1;
			}
			set
			{
				this.dataTemplate_1 = value;
			}
		}

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			DataTemplate result;
			if (item is Rule)
			{
				result = this.RuleTemplate;
			}
			else if (item is RuleCategory)
			{
				result = this.RuleCategoryTemplate;
			}
			else
			{
				result = base.SelectTemplate(item, container);
			}
			return result;
		}
	}
}
