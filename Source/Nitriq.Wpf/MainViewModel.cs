using ns1;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Markup;
using System.Xml;

namespace Nitriq.Wpf
{
	public class MainViewModel : MainViewModelBase
	{
		private RibbonIconProvider ribbonIconProvider_0 = new RibbonIconProvider();

		private bool bool_4 = true;

		private string string_2 = "Namespace";

		private DataTemplate dataTemplate_0;

		private TreemapMetric treemapMetric_0;

		private TreemapMetricCollection treemapMetricCollection_0 = new TreemapMetricCollection();

		private DataTemplate dataTemplate_1;

		private string string_3;

		private string string_4;

		private string string_5;

		public RibbonIconProvider RibbonIcons
		{
			get
			{
				return this.ribbonIconProvider_0;
			}
		}

		public bool TreemapHideNonCoreAssemblies
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				if (this.bool_4 != value)
				{
					this.bool_4 = value;
					base.FirePropertyChanged("TreemapHideNonCoreAssemblies");
				}
			}
		}

		public string TopTreemapLevel
		{
			get
			{
				return this.string_2;
			}
			set
			{
				if (this.string_2 != value)
				{
					this.string_2 = value;
					base.FirePropertyChanged("TopTreemapLevel");
				}
			}
		}

		public DataTemplate TreemapPopupTemplate
		{
			get
			{
				return this.dataTemplate_0;
			}
			private set
			{
				if (this.dataTemplate_0 != value)
				{
					this.dataTemplate_0 = value;
					base.FirePropertyChanged("TreemapPopupTemplate");
				}
			}
		}

		public TreemapMetric CurrentTreemapMetric
		{
			get
			{
				return this.treemapMetric_0;
			}
			set
			{
				if (this.treemapMetric_0 != value)
				{
					this.treemapMetric_0 = value;
					base.FirePropertyChanged("CurrentTreemapMetric");
				}
			}
		}

		public TreemapMetricCollection TreemapMetrics
		{
			get
			{
				return this.treemapMetricCollection_0;
			}
		}

		public DataTemplate RuleEditorTemplate
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

		public string LicenseName
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		public string LicenseCompany
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		public string Version
		{
			get
			{
				return Assembly.GetExecutingAssembly().GetName().Version.ToString();
			}
		}

		public MainViewModel()
		{
			this.treemapMetric_0 = this.treemapMetricCollection_0.TypeMetrics[0];
			this.BuildTreemapPopupTemplate();
			try
			{
				if (Class33.smethod_0().method_0() == (Enum6)0)
				{
					string licenseName = null;
					string licenseCompany = null;
					if (!Class13.smethod_0())
					{
						licenseName = "Hank Rearden";
						licenseCompany = "Rearden Steel";
					}
					this.LicenseName = licenseName;
					this.LicenseCompany = licenseCompany;
				}
				if (Class33.smethod_0().method_0() == (Enum6)1)
				{
					string licenseName = Class33.smethod_0().method_50()["Name"].ToString();
					string licenseCompany = Class33.smethod_0().method_50()["Company"].ToString();
					this.LicenseName = licenseName;
					this.LicenseCompany = licenseCompany;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public void BuildTreemapPopupTemplate()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<DataTemplate xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\">");
			stringBuilder.AppendLine("  <Border BorderBrush=\"Black\" BorderThickness=\"1\" Background=\"#FFFFFFFF\" IsHitTestVisible=\"False\">");
			stringBuilder.AppendLine("      <StackPanel Orientation=\"Horizontal\" Margin=\"7\" IsHitTestVisible=\"False\">");
			stringBuilder.AppendLine(this.method_19());
			stringBuilder.AppendLine("        </StackPanel>");
			stringBuilder.AppendLine("  </Border>");
			stringBuilder.AppendLine("</DataTemplate>");
			using (StringReader stringReader = new StringReader(stringBuilder.ToString()))
			{
				XmlReader reader = XmlReader.Create(stringReader);
				this.TreemapPopupTemplate = (DataTemplate)XamlReader.Load(reader);
			}
		}

		private string method_19()
		{
			StringBuilder stringBuilder = new StringBuilder();
			string level = this.treemapMetric_0.Level;
			string name = this.treemapMetric_0.Name;
			stringBuilder.AppendLine("<StackPanel IsHitTestVisible=\"False\">");
			if (this.TopTreemapLevel == "Assembly")
			{
				if (level == "Method" || level == "Field" || level == "Event")
				{
					stringBuilder.AppendLine("<TextBlock Text=\"{Binding BaseObject.Type.Assembly.Name}\" />");
				}
				else
				{
					stringBuilder.AppendLine("<TextBlock Text=\"{Binding BaseObject.Assembly.Name}\" />");
				}
			}
			if (level == "Method" || level == "Field" || level == "Event")
			{
				stringBuilder.AppendLine("<StackPanel Orientation=\"Horizontal\" IsHitTestVisible=\"False\">");
				stringBuilder.AppendLine("  <TextBlock Text=\"{Binding BaseObject.Type.Namespace.FullName}\" />");
				stringBuilder.AppendLine("  <TextBlock Text=\".\" />");
				stringBuilder.AppendLine("  <TextBlock Text=\"{Binding BaseObject.Type.Name}\" FontWeight=\"Bold\"/>");
				stringBuilder.AppendLine("  <TextBlock Text=\"::\" />");
				stringBuilder.AppendLine("  <TextBlock Text=\"{Binding BaseObject.Name}\" FontWeight=\"Bold\" />");
				if (level == "Method")
				{
					stringBuilder.AppendLine("  <TextBlock Text=\"(...)\" FontWeight=\"Bold\" />");
				}
				stringBuilder.AppendLine("</StackPanel>");
			}
			else
			{
				stringBuilder.AppendLine("<StackPanel Orientation=\"Horizontal\">");
				stringBuilder.AppendLine("  <TextBlock Text=\"{Binding BaseObject.Namespace.FullName}\" />");
				stringBuilder.AppendLine("  <TextBlock Text=\".\" />");
				stringBuilder.AppendLine("  <TextBlock Text=\"{Binding BaseObject.Name}\" FontWeight=\"Bold\"/>");
				stringBuilder.AppendLine("</StackPanel>");
			}
			stringBuilder.AppendLine("<StackPanel Orientation=\"Horizontal\">");
			stringBuilder.AppendLine("  <TextBlock Text=\"" + name + ": \" />");
			stringBuilder.AppendLine("  <TextBlock Text=\"{Binding Size}\" FontWeight=\"Bold\" />");
			stringBuilder.AppendLine("</StackPanel>");
			stringBuilder.AppendLine("</StackPanel>");
			return stringBuilder.ToString();
		}
	}
}
