using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Xml.Serialization;

namespace Nitriq.Project.Models
{
	public class Rule : DependencyObject, INotifyPropertyChanged
	{
		private string string_0;

		private string string_1;

		private string string_2;

		private RuleStatus ruleStatus_0;

		private bool bool_0;

		private QueryResults queryResults_0 = new QueryResults();

		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		[CompilerGenerated]
		private static Func<Problem, bool> func_0;

		[CompilerGenerated]
		private static Func<Problem, bool> func_1;

		[CompilerGenerated]
		private static Func<Problem, bool> func_2;

		[CompilerGenerated]
		private static Func<Problem, bool> func_3;

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

		[XmlAttribute]
		public string Name
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
					this.method_0("Name");
				}
			}
		}

		public string Description
		{
			get
			{
				return this.string_1;
			}
			set
			{
				if (this.string_1 != value)
				{
					this.string_1 = value;
					this.method_0("Description");
				}
			}
		}

		public string Code
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
					this.method_0("Code");
				}
			}
		}

		[XmlIgnore]
		public RuleStatus Status
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
					this.method_0("Status");
				}
			}
		}

		[XmlAttribute]
		public bool Active
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
					this.method_0("Active");
				}
			}
		}

		[XmlIgnore]
		public QueryResults QueryResults
		{
			get
			{
				return this.queryResults_0;
			}
			set
			{
				if (this.queryResults_0 != value)
				{
					this.queryResults_0 = value;
					this.method_0("QueryResults");
				}
			}
		}

		public void CalculateStatus()
		{
			this.Status = RuleStatus.Good;
			IEnumerable<Problem> arg_30_0 = this.QueryResults.Problems;
			if (Rule.func_0 == null)
			{
				Rule.func_0 = new Func<Problem, bool>(Rule.smethod_0);
			}
			if (arg_30_0.Where(Rule.func_0).Count<Problem>() > 0)
			{
				this.Status = RuleStatus.Warning;
			}
			IEnumerable<Problem> arg_72_0 = this.QueryResults.Problems;
			if (Rule.func_1 == null)
			{
				Rule.func_1 = new Func<Problem, bool>(Rule.smethod_1);
			}
			if (arg_72_0.Where(Rule.func_1).Count<Problem>() > 0)
			{
				this.Status = RuleStatus.Error;
			}
			IEnumerable<Problem> arg_B4_0 = this.QueryResults.Problems;
			if (Rule.func_2 == null)
			{
				Rule.func_2 = new Func<Problem, bool>(Rule.smethod_2);
			}
			if (arg_B4_0.Where(Rule.func_2).Count<Problem>() > 0)
			{
				this.Status = RuleStatus.CompileError;
			}
			IEnumerable<Problem> arg_F6_0 = this.QueryResults.Problems;
			if (Rule.func_3 == null)
			{
				Rule.func_3 = new Func<Problem, bool>(Rule.smethod_3);
			}
			if (arg_F6_0.Where(Rule.func_3).Count<Problem>() > 0)
			{
				this.Status = RuleStatus.RuntimeError;
			}
		}

		public void FireQueryResultsChanged()
		{
			this.method_0("QueryResults");
		}

		private void method_0(string string_3)
		{
			if (this.propertyChangedEventHandler_0 != null)
			{
				this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(string_3));
			}
		}

		[CompilerGenerated]
		private static bool smethod_0(Problem problem_0)
		{
			return problem_0.ProblemType == RuleStatus.Warning;
		}

		[CompilerGenerated]
		private static bool smethod_1(Problem problem_0)
		{
			return problem_0.ProblemType == RuleStatus.Error;
		}

		[CompilerGenerated]
		private static bool smethod_2(Problem problem_0)
		{
			return problem_0.ProblemType == RuleStatus.CompileError;
		}

		[CompilerGenerated]
		private static bool smethod_3(Problem problem_0)
		{
			return problem_0.ProblemType == RuleStatus.RuntimeError;
		}
	}
}
