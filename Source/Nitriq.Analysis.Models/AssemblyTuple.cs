using Mono.Cecil;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace Nitriq.Analysis.Models
{
	[DebuggerDisplay("AssemblyTuple: {Assembly.Name.Name}")]
	public class AssemblyTuple : INotifyPropertyChanged
	{
		private AssemblyDefinition assemblyDefinition_0;

		private bool bool_0;

		private string string_0;

		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		public AssemblyDefinition Assembly
		{
			get
			{
				return this.assemblyDefinition_0;
			}
			set
			{
				if (this.assemblyDefinition_0 != value)
				{
					this.assemblyDefinition_0 = value;
					string name = this.Assembly.Name.Name;
					this.IsCoreAssembly = (!name.StartsWith("System") && !name.StartsWith("Microsoft") && !name.StartsWith("PresentationFramework") && !name.StartsWith("Mono") && !name.StartsWith("ActiproSoftware") && !name.StartsWith("Telerik") && !name.StartsWith("DevExpress") && !name.StartsWith("Infragistics") && !name.StartsWith("Xceed") && !name.StartsWith("ComponentOne") && !name.StartsWith("FarPoint") && !name.StartsWith("Janus") && !name.StartsWith("Aspose") && !name.StartsWith("SyncFusion") && !name.StartsWith("Sybase") && !name.StartsWith("Oracle") && !name.StartsWith("MySQL") && !name.StartsWith("PostgreSQL") && !name.StartsWith("VistaDB") && !(name == "ISymWrapper") && !(name == "UIAutomationClient") && !(name == "WPFToolkit") && !(name == "mscorlib") && !(name == "WindowsBase") && !(name == "PresentationCore") && !(name == "UIAutomationTypes") && !(name == "UIAutomationProvider") && !(name == "ReachFramework") && !(name == "PresentationUI") && !(name == "PresentationCFFRasterizer") && !(name == "Accessibility"));
					this.method_0("Assembly");
				}
			}
		}

		public bool IsCoreAssembly
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value)
				{
					this.bool_0 = value;
					this.method_0("IsFrameworkAssembly");
				}
			}
		}

		public string Directory
		{
			get
			{
				return this.string_0;
			}
			set
			{
				if (this.string_0 != value)
				{
					this.string_0 = value;
					this.method_0("Directory");
				}
			}
		}

		public AssemblyTuple(AssemblyDefinition assembly)
		{
			this.Assembly = assembly;
		}

		private void method_0(string string_1)
		{
			if (this.propertyChangedEventHandler_0 != null)
			{
				this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(string_1));
			}
		}
	}
}
