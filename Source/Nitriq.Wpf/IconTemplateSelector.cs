using Nitriq.Analysis.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Nitriq.Wpf
{
	public class IconTemplateSelector : DataTemplateSelector
	{
		private DataTemplate dataTemplate_0;

		private DataTemplate dataTemplate_1;

		private DataTemplate dataTemplate_2;

		private DataTemplate dataTemplate_3;

		private DataTemplate dataTemplate_4;

		private DataTemplate dataTemplate_5;

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

		public DataTemplate MethodTemplate
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

		public DataTemplate EventTemplate
		{
			get
			{
				return this.dataTemplate_4;
			}
			set
			{
				this.dataTemplate_4 = value;
			}
		}

		public DataTemplate FieldTemplate
		{
			get
			{
				return this.dataTemplate_5;
			}
			set
			{
				this.dataTemplate_5 = value;
			}
		}

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			DataTemplate result;
			if (item is BfAssembly)
			{
				result = this.AssemblyTemplate;
			}
			else if (item is BfNamespace)
			{
				result = this.NamespaceTemplate;
			}
			else if (item is BfType)
			{
				result = this.TypeTemplate;
			}
			else if (item is BfMethod)
			{
				result = this.MethodTemplate;
			}
			else if (item is BfField)
			{
				result = this.FieldTemplate;
			}
			else if (item is BfEvent)
			{
				result = this.EventTemplate;
			}
			else
			{
				result = null;
			}
			return result;
		}
	}
}
