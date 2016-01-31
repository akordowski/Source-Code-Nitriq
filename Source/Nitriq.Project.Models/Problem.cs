using System;
using System.ComponentModel;
using System.Threading;

namespace Nitriq.Project.Models
{
	public class Problem : INotifyPropertyChanged
	{
		private string string_0;

		private RuleStatus ruleStatus_0;

		private int? nullable_0;

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

		public string Description
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
					this.method_0("Description");
				}
			}
		}

		public RuleStatus ProblemType
		{
			get
			{
				return this.ruleStatus_0;
			}
			set
			{
				if (this.ruleStatus_0 != value)
				{
					this.ruleStatus_0 = value;
					this.method_0("ProblemType");
				}
			}
		}

		public int? LineNumber
		{
			get
			{
				return this.nullable_0;
			}
			set
			{
				if (this.nullable_0 != value)
				{
					this.nullable_0 = value;
					this.method_0("LineNumber");
				}
			}
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
