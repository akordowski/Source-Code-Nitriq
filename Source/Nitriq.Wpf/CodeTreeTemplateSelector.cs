using System;
using System.Windows;
using System.Windows.Controls;

namespace Nitriq.Wpf
{
	public class CodeTreeTemplateSelector : DataTemplateSelector
	{
		private DataTemplate dataTemplate_0;

		private DataTemplate dataTemplate_1;

		private DataTemplate dataTemplate_2;

		private DataTemplate dataTemplate_3;

		public DataTemplate AssemblyTemplate
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

		public DataTemplate NamespaceTemplate
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

		public DataTemplate TypeTemplate
		{
			get
			{
				return this.dataTemplate_2;
			}
			set
			{
				this.dataTemplate_2 = value;
			}
		}

		public DataTemplate DetailsTemplate
		{
			get
			{
				return this.dataTemplate_3;
			}
			set
			{
				this.dataTemplate_3 = value;
			}
		}

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			DataTemplate result;
			if (item is LightAssembly)
			{
				result = this.AssemblyTemplate;
			}
			else if (item is LightNamespace)
			{
				result = this.NamespaceTemplate;
			}
			else if (item is LightType)
			{
				result = this.TypeTemplate;
			}
			else
			{
				result = this.DetailsTemplate;
			}
			return result;
		}
	}
}
