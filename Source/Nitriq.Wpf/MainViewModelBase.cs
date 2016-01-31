using Microsoft.CSharp;
using Nitriq.Analysis.Models;
using Nitriq.Project.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace Nitriq.Wpf
{
	public class MainViewModelBase : INotifyPropertyChanged
	{
		private EventHandler eventHandler_0;

		private bool bool_0;

		private bool bool_1 = true;

		private bool bool_2;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private int int_6;

		private int int_7;

		private int int_8;

		private int int_9;

		private int int_10;

		private int int_11;

		private int int_12;

		private BfCache bfCache_0;

		private bool bool_3;

		private int int_13 = 0;

		private List<string> list_0;

		private List<AssemblyFileInfo> list_1;

		private static string string_0;

		private LightWrapper lightWrapper_0;

		private IEnumerable ienumerable_0;

		private string string_1 = "";

		private RuleSet ruleSet_0;

		private ObservableCollection<Rule> observableCollection_0 = new ObservableCollection<Rule>();

		private Rule rule_0;

		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		[CompilerGenerated]
		private static Func<BfAssembly, bool> func_0;

		[CompilerGenerated]
		private static Func<BfType, bool> func_1;

		[CompilerGenerated]
		private static Func<BfType, BfNamespace> func_2;

		[CompilerGenerated]
		private static Func<BfType, bool> func_3;

		[CompilerGenerated]
		private static Func<BfMethod, bool> func_4;

		[CompilerGenerated]
		private static Func<BfField, bool> func_5;

		[CompilerGenerated]
		private static Func<BfEvent, bool> func_6;

		[CompilerGenerated]
		private static Func<BfMethod, bool> func_7;

		[CompilerGenerated]
		private static Func<BfMethod, int> func_8;

		[CompilerGenerated]
		private static Func<BfAssembly, bool> func_9;

		[CompilerGenerated]
		private static Func<BfType, bool> func_10;

		[CompilerGenerated]
		private static Func<BfType, BfNamespace> func_11;

		[CompilerGenerated]
		private static Func<BfType, bool> func_12;

		[CompilerGenerated]
		private static Func<BfMethod, bool> func_13;

		[CompilerGenerated]
		private static Func<BfField, bool> func_14;

		[CompilerGenerated]
		private static Func<BfEvent, bool> func_15;

		public event EventHandler CurrentRuleRan
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

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

		public bool AssemblyTop
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 != value && value)
				{
					this.bool_0 = value;
					this.bool_1 = false;
					this.bool_2 = false;
					this.FirePropertyChanged("AssemblyTop");
					this.FirePropertyChanged("NamespaceTop");
					this.FirePropertyChanged("TypeTop");
					if (this.method_16() != null)
					{
						this.CurrentCodeTreeItemsSource = this.method_16().Assemblies;
					}
				}
			}
		}

		public bool NamespaceTop
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				if (this.bool_1 != value && value)
				{
					this.bool_0 = false;
					this.bool_1 = true;
					this.bool_2 = false;
					this.FirePropertyChanged("AssemblyTop");
					this.FirePropertyChanged("NamespaceTop");
					this.FirePropertyChanged("TypeTop");
					if (this.method_16() != null)
					{
						this.CurrentCodeTreeItemsSource = this.method_16().Namespaces;
					}
				}
			}
		}

		public bool TypeTop
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				if (this.bool_2 != value && value)
				{
					this.bool_0 = false;
					this.bool_1 = false;
					this.bool_2 = true;
					this.FirePropertyChanged("AssemblyTop");
					this.FirePropertyChanged("NamespaceTop");
					this.FirePropertyChanged("TypeTop");
					if (this.method_16() != null)
					{
						this.CurrentCodeTreeItemsSource = this.method_16().Types;
					}
				}
			}
		}

		public int CoreAssemblies
		{
			get
			{
				return this.int_0;
			}
			private set
			{
				if (this.int_0 != value)
				{
					this.int_0 = value;
					this.FirePropertyChanged("CoreAssemblies");
				}
			}
		}

		public int CoreNamespaces
		{
			get
			{
				return this.int_1;
			}
			private set
			{
				if (this.int_1 != value)
				{
					this.int_1 = value;
					this.FirePropertyChanged("CoreNamespaces");
				}
			}
		}

		public int CoreTypes
		{
			get
			{
				return this.int_2;
			}
			private set
			{
				if (this.int_2 != value)
				{
					this.int_2 = value;
					this.FirePropertyChanged("CoreTypes");
				}
			}
		}

		public int CoreMethods
		{
			get
			{
				return this.int_3;
			}
			private set
			{
				if (this.int_3 != value)
				{
					this.int_3 = value;
					this.FirePropertyChanged("CoreMethods");
				}
			}
		}

		public int CoreFields
		{
			get
			{
				return this.int_4;
			}
			private set
			{
				if (this.int_4 != value)
				{
					this.int_4 = value;
					this.FirePropertyChanged("CoreFields");
				}
			}
		}

		public int CoreEvents
		{
			get
			{
				return this.int_5;
			}
			private set
			{
				if (this.int_5 != value)
				{
					this.int_5 = value;
					this.FirePropertyChanged("CoreEvents");
				}
			}
		}

		public int CoreLineCount
		{
			get
			{
				return this.int_6;
			}
			set
			{
				if (this.int_6 != value)
				{
					this.int_6 = value;
					this.FirePropertyChanged("CoreLineCount");
				}
			}
		}

		public int NonCoreAssemblies
		{
			get
			{
				return this.int_7;
			}
			private set
			{
				if (this.int_7 != value)
				{
					this.int_7 = value;
					this.FirePropertyChanged("NonCoreAssemblies");
				}
			}
		}

		public int NonCoreNamespaces
		{
			get
			{
				return this.int_8;
			}
			private set
			{
				if (this.int_8 != value)
				{
					this.int_8 = value;
					this.FirePropertyChanged("NonCoreNamespaces");
				}
			}
		}

		public int NonCoreTypes
		{
			get
			{
				return this.int_9;
			}
			private set
			{
				if (this.int_9 != value)
				{
					this.int_9 = value;
					this.FirePropertyChanged("NonCoreTypes");
				}
			}
		}

		public int NonCoreMethods
		{
			get
			{
				return this.int_10;
			}
			private set
			{
				if (this.int_10 != value)
				{
					this.int_10 = value;
					this.FirePropertyChanged("NonCoreMethods");
				}
			}
		}

		public int NonCoreFields
		{
			get
			{
				return this.int_11;
			}
			private set
			{
				if (this.int_11 != value)
				{
					this.int_11 = value;
					this.FirePropertyChanged("NonCoreFields");
				}
			}
		}

		public int NonCoreEvents
		{
			get
			{
				return this.int_12;
			}
			private set
			{
				if (this.int_12 != value)
				{
					this.int_12 = value;
					this.FirePropertyChanged("NonCoreEvents");
				}
			}
		}

		public bool HaveSavedProject
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				if (this.bool_3 != value)
				{
					this.bool_3 = value;
					this.FirePropertyChanged("HaveSavedProject");
				}
			}
		}

		public bool HaveRulesChanged
		{
			get
			{
				return this.int_13 != this.method_7();
			}
		}

		public List<string> Files
		{
			get
			{
				return this.list_0;
			}
			set
			{
				this.list_0 = value;
				this.FirePropertyChanged("SaveAvailable");
			}
		}

		public bool SaveAvailable
		{
			get
			{
				return this.list_0 != null && this.list_0.Count > 0;
			}
		}

		public IEnumerable CurrentCodeTreeItemsSource
		{
			get
			{
				return this.ienumerable_0;
			}
			set
			{
				if (this.ienumerable_0 != value)
				{
					this.ienumerable_0 = value;
					this.FirePropertyChanged("CurrentCodeTreeItemsSource");
				}
			}
		}

		public string Status
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
					this.FirePropertyChanged("Status");
				}
			}
		}

		public RuleSet RuleSet
		{
			get
			{
				return this.ruleSet_0;
			}
			set
			{
				if (this.ruleSet_0 != value)
				{
					this.ruleSet_0 = value;
					this.FirePropertyChanged("RuleSet");
					this.int_13 = this.method_7();
				}
			}
		}

		public ObservableCollection<Rule> OpenRules
		{
			get
			{
				return this.observableCollection_0;
			}
		}

		public Rule CurrentRule
		{
			get
			{
				return this.rule_0;
			}
			set
			{
				if (this.rule_0 != value)
				{
					this.rule_0 = value;
					this.FirePropertyChanged("CurrentRule");
					this.rule_0.FireQueryResultsChanged();
					this.method_17(new LightWrapper(this.rule_0.QueryResults.Results, this.bfCache_0));
				}
			}
		}

		internal void method_0(string string_2)
		{
			this.method_1(string_2, true);
		}

		internal void method_1(string string_2, bool bool_4)
		{
			try
			{
				if (LicenseData.smethod_0())
				{
					throw new Exception("Nitriq Free Edition does not allow to import or export query files");
				}
				string xml;
				using (StreamReader streamReader = new StreamReader(string_2))
				{
					xml = streamReader.ReadToEnd();
				}
				this.RuleSet = Util.FromXml<RuleSet>(xml);
			}
			catch (Exception ex)
			{
				if (bool_4)
				{
					throw new Exception("There was a problem loading " + string_2 + ". Loading default queries instead");
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Nitriq.Wpf.myQueries.nq");
				string xml;
				using (StreamReader streamReader = new StreamReader(manifestResourceStream))
				{
					xml = streamReader.ReadToEnd();
				}
				this.RuleSet = Util.FromXml<RuleSet>(xml);
				Logger.LogWarning("ViewModelImportRules", ex.ToString());
			}
		}

		internal void method_2(string string_2)
		{
			this.method_3(string_2, this.RuleSet);
		}

		internal void method_3(string string_2, RuleSet ruleSet_1)
		{
			if (LicenseData.smethod_0())
			{
				throw new Exception("Nitriq Free Edition does not allow to import or export query files");
			}
			try
			{
				string value = Util.ConvertToXml(ruleSet_1);
				using (StreamWriter streamWriter = new StreamWriter(string_2))
				{
					streamWriter.Write(value);
				}
				this.int_13 = this.method_7();
			}
			catch (Exception ex)
			{
				Logger.LogWarning("ExportRules", ex.ToString());
			}
		}

		private void method_4()
		{
			IEnumerable<BfAssembly> arg_29_0 = this.method_5().Assemblies;
			if (MainViewModelBase.func_0 == null)
			{
				MainViewModelBase.func_0 = new Func<BfAssembly, bool>(MainViewModelBase.smethod_0);
			}
			this.CoreAssemblies = arg_29_0.Where(MainViewModelBase.func_0).Count();
			IEnumerable<BfType> arg_61_0 = this.method_5().Types;
			if (MainViewModelBase.func_1 == null)
			{
				MainViewModelBase.func_1 = new Func<BfType, bool>(MainViewModelBase.smethod_1);
			}
			IEnumerable<BfType> arg_83_0 = arg_61_0.Where(MainViewModelBase.func_1);
			if (MainViewModelBase.func_2 == null)
			{
				MainViewModelBase.func_2 = new Func<BfType, BfNamespace>(MainViewModelBase.smethod_2);
			}
			this.CoreNamespaces = arg_83_0.Select(MainViewModelBase.func_2).Distinct<BfNamespace>().Count();
			IEnumerable<BfType> arg_C0_0 = this.method_5().Types;
			if (MainViewModelBase.func_3 == null)
			{
				MainViewModelBase.func_3 = new Func<BfType, bool>(MainViewModelBase.smethod_3);
			}
			this.CoreTypes = arg_C0_0.Where(MainViewModelBase.func_3).Count();
			IEnumerable<BfMethod> arg_F8_0 = this.method_5().Methods;
			if (MainViewModelBase.func_4 == null)
			{
				MainViewModelBase.func_4 = new Func<BfMethod, bool>(MainViewModelBase.smethod_4);
			}
			this.CoreMethods = arg_F8_0.Where(MainViewModelBase.func_4).Count();
			IEnumerable<BfField> arg_130_0 = this.method_5().Fields;
			if (MainViewModelBase.func_5 == null)
			{
				MainViewModelBase.func_5 = new Func<BfField, bool>(MainViewModelBase.smethod_5);
			}
			this.CoreFields = arg_130_0.Where(MainViewModelBase.func_5).Count();
			IEnumerable<BfEvent> arg_168_0 = this.method_5().Events;
			if (MainViewModelBase.func_6 == null)
			{
				MainViewModelBase.func_6 = new Func<BfEvent, bool>(MainViewModelBase.smethod_6);
			}
			this.CoreEvents = arg_168_0.Where(MainViewModelBase.func_6).Count();
			IEnumerable<BfMethod> arg_1A0_0 = this.method_5().Methods;
			if (MainViewModelBase.func_7 == null)
			{
				MainViewModelBase.func_7 = new Func<BfMethod, bool>(MainViewModelBase.smethod_7);
			}
			IEnumerable<BfMethod> arg_1C2_0 = arg_1A0_0.Where(MainViewModelBase.func_7);
			if (MainViewModelBase.func_8 == null)
			{
				MainViewModelBase.func_8 = new Func<BfMethod, int>(MainViewModelBase.smethod_8);
			}
			this.CoreLineCount = arg_1C2_0.Select(MainViewModelBase.func_8).Sum();
			IEnumerable<BfAssembly> arg_1FA_0 = this.method_5().Assemblies;
			if (MainViewModelBase.func_9 == null)
			{
				MainViewModelBase.func_9 = new Func<BfAssembly, bool>(MainViewModelBase.smethod_9);
			}
			this.NonCoreAssemblies = arg_1FA_0.Where(MainViewModelBase.func_9).Count();
			IEnumerable<BfType> arg_232_0 = this.method_5().Types;
			if (MainViewModelBase.func_10 == null)
			{
				MainViewModelBase.func_10 = new Func<BfType, bool>(MainViewModelBase.smethod_10);
			}
			IEnumerable<BfType> arg_254_0 = arg_232_0.Where(MainViewModelBase.func_10);
			if (MainViewModelBase.func_11 == null)
			{
				MainViewModelBase.func_11 = new Func<BfType, BfNamespace>(MainViewModelBase.smethod_11);
			}
			this.NonCoreNamespaces = arg_254_0.Select(MainViewModelBase.func_11).Distinct<BfNamespace>().Count();
			IEnumerable<BfType> arg_291_0 = this.method_5().Types;
			if (MainViewModelBase.func_12 == null)
			{
				MainViewModelBase.func_12 = new Func<BfType, bool>(MainViewModelBase.smethod_12);
			}
			this.NonCoreTypes = arg_291_0.Where(MainViewModelBase.func_12).Count();
			IEnumerable<BfMethod> arg_2C9_0 = this.method_5().Methods;
			if (MainViewModelBase.func_13 == null)
			{
				MainViewModelBase.func_13 = new Func<BfMethod, bool>(MainViewModelBase.smethod_13);
			}
			this.NonCoreMethods = arg_2C9_0.Where(MainViewModelBase.func_13).Count();
			IEnumerable<BfField> arg_301_0 = this.method_5().Fields;
			if (MainViewModelBase.func_14 == null)
			{
				MainViewModelBase.func_14 = new Func<BfField, bool>(MainViewModelBase.smethod_14);
			}
			this.NonCoreFields = arg_301_0.Where(MainViewModelBase.func_14).Count();
			IEnumerable<BfEvent> arg_339_0 = this.method_5().Events;
			if (MainViewModelBase.func_15 == null)
			{
				MainViewModelBase.func_15 = new Func<BfEvent, bool>(MainViewModelBase.smethod_15);
			}
			this.NonCoreEvents = arg_339_0.Where(MainViewModelBase.func_15).Count();
		}

		internal BfCache method_5()
		{
			return this.bfCache_0;
		}

		internal void method_6(BfCache value)
		{
			if (this.bfCache_0 != value)
			{
				this.bfCache_0 = value;
				this.FirePropertyChanged("Cache");
				this.method_4();
				this.ClearRuleResultsAndStatuses();
				this.HaveSavedProject = false;
			}
		}

		private int method_7()
		{
			string text = Util.ConvertToXml(this.RuleSet);
			return text.GetHashCode();
		}

		private int method_8(string string_2, int int_14)
		{
			int hashCode;
			if (string_2 == null)
			{
				hashCode = "".GetHashCode();
			}
			else
			{
				hashCode = string_2.GetHashCode();
			}
			return (hashCode << int_14 | hashCode >> 32 - int_14 % 32) + int_14;
		}

		internal virtual void ClearRuleResultsAndStatuses()
		{
			foreach (Rule current in this.ruleSet_0.RulesEnumerator())
			{
				current.QueryResults = new QueryResults();
				current.Status = RuleStatus.None;
			}
			this.CurrentCodeTreeItemsSource = null;
		}

		internal List<AssemblyFileInfo> method_9()
		{
			return this.list_1;
		}

		internal void method_10(List<AssemblyFileInfo> value)
		{
			this.list_1 = value;
		}

		private void method_11(bool bool_4)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(bool_4, null);
			}
		}

		internal void method_12(RuleCategory ruleCategory_0)
		{
			foreach (RuleCategory current in ruleCategory_0.RuleCategories)
			{
				this.method_12(current);
			}
			foreach (Rule current2 in ruleCategory_0.Rules)
			{
				if (current2.Active)
				{
					this.method_14(current2, true);
				}
			}
		}

		static MainViewModelBase()
		{
			MainViewModelBase.string_0 = Assembly.GetExecutingAssembly().Location;
		}

		internal void method_13(Rule rule_1)
		{
			this.method_14(rule_1, false);
		}

		internal void method_14(Rule rule_1, bool bool_4)
		{
			if (rule_1 != null)
			{
				rule_1.QueryResults.Problems = new ObservableCollection<Problem>();
				rule_1.QueryResults.Output = "";
				string code = rule_1.Code;
				List<string> list = new List<string>
				{
					"CodeDom",
					"IO",
					"Net",
					"Media",
					"Reflection",
					"Runtime",
					"Security",
					"Threading",
					"Web",
					"Windows"
				};
				Builder builder = new Builder("|");
				foreach (string current in list)
				{
					builder.Append(string.Concat(new string[]
					{
						"^(?<namespace>System\\.",
						current,
						")\\.|[\\s;:!{}()[\\]](?<namespace>System\\.",
						current,
						")\\."
					}));
				}
				MatchCollection matchCollection = Regex.Matches(code, builder.ToString());
				if (matchCollection.Count > 0)
				{
					string description = "It looks like you're trying to use a class in the \"" + matchCollection[0].Groups["namespace"].Value + "\" namespace.\r\nWe can't let you complete the query because of security concerns, sorry.\r\nIf you believe you've received this message erroneously please contact support@nitriq.com with the text of your query";
					ObservableCollection<Problem> observableCollection = new ObservableCollection<Problem>();
					observableCollection.Add(new Problem
					{
						Description = description,
						ProblemType = RuleStatus.CompileError
					});
					rule_1.QueryResults.Problems = observableCollection;
					rule_1.QueryResults.Results = null;
					rule_1.QueryResults.Description = "The query \"" + rule_1.Name + "\" had a compile time error";
				}
				else
				{
					string text = "\r\n\t\t\t\t            using System;\r\n\t\t\t\t            using System.Collections;   \r\n                            using System.Collections.Generic;         \r\n\t\t\t\t            using System.Linq;\r\n\t\t\t\t            using System.Text;\r\n\t\t\t\t            using System.Text.RegularExpressions;\r\n\t\t\t\t            using Nitriq.Analysis.Models;\r\n\t\t\t\t            \r\n\t\t\t\t            namespace Runner\r\n\t\t\t\t            {\r\n\t\t\t\t                public static class ExtensionMethods\r\n\t\t\t\t                {\r\n\t\t\t\t                    public static int Count(this IEnumerable enumerable)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        if (enumerable == null)\r\n\t\t\t\t                            return 0;\r\n\r\n\t\t\t\t                        int count = 0;\r\n\r\n\t\t\t\t                        foreach (object obj in enumerable)\r\n\t\t\t\t                            count++;\r\n\r\n\t\t\t\t                        return count;\r\n\t\t\t\t                    }\r\n\r\n                                    public static List<object> ToList(this IEnumerable enumerable)\r\n                                    {\r\n                                        List<object> list = new List<object>();\r\n                                        foreach (object obj in enumerable)\r\n                                        {\r\n                                            list.Add(obj);\r\n                                        }\r\n                                        return list;\r\n                                    }\r\n\r\n\t\t\t\t                }\r\n\r\n\t\t\t\t                public class RunnerClass\r\n\t\t\t\t                {\r\n\t\t\t\t                    //public BfCache _cache;\r\n\t\t\t\t                    \r\n\t\t\t\t                    public void ConsoleWrite(object message)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        ConsoleWrite(message.ToString());\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    public void ConsoleWriteLine(object message)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        ConsoleWriteLine(message.ToString());\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    public void ConsoleWrite(string message)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        _debug(message);\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    public void ConsoleWriteLine(string message)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        _debug(message + \"\\r\\n\");\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    public void Warn(bool condition, string message)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        if (condition)\r\n\t\t\t\t                            _warn(message);\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    public void Error(bool condition, string message)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        if (condition)\r\n\t\t\t\t                            _error(message);\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    public void Warn(IEnumerable results, int resultsCount)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        if (results.Count() > resultsCount)\r\n\t\t\t\t                            _warn(\"More than \" + resultsCount + \" results were returned\");\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    public void Error(IEnumerable results, int resultsCount)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        if (results.Count() > resultsCount)\r\n\t\t\t\t                            _error(\"More than \" + resultsCount + \" results were returned\");\r\n\t\t\t\t                    }\r\n\r\n                                    /*\r\n\t\t\t\t                    public void Warn(bool condition)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        if (condition)\r\n\t\t\t\t                            _warnNoMsg();\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    public void Error(bool condition)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        if (condition)\r\n\t\t\t\t                            _errorNoMsg();\r\n\t\t\t\t                    }\r\n                                    */\r\n\r\n\t\t\t\t                    Action<string> _debug;\r\n\t\t\t\t                    Action<string> _warn;\r\n\t\t\t\t                    Action<string> _error;\r\n\t\t\t\t                    Action _warnNoMsg;\r\n\t\t\t\t                    Action _errorNoMsg;\r\n\r\n\t\t\t\t                    public RunnerClass(BfCache cache, Action<string> debug, Action<string> warn, Action<string> error, Action warnNoMsg, Action errorNoMsg)\r\n\t\t\t\t                    {\r\n\t\t\t\t                        //_cache = cache;\r\n\t\t\t\t                        _assemblies = cache.Assemblies;\r\n\t\t\t\t                        _namespaces = cache.Namespaces;\r\n\t\t\t\t                        _types = cache.Types;\r\n\t\t\t\t                        _methods = cache.Methods;\r\n\t\t\t\t                        _fields = cache.Fields;\r\n\t\t\t\t                        _events = cache.Events;\r\n\r\n\t\t\t\t                        _debug = debug;\r\n\t\t\t\t                        _warn = warn;\r\n\t\t\t\t                        _error = error;\r\n\t\t\t\t                        _warnNoMsg = warnNoMsg;   \r\n\t\t\t\t                        _errorNoMsg = errorNoMsg;\r\n\t\t\t\t                    }   \r\n\r\n\r\n\t\t\t\t                    private AssemblyCollection _assemblies;\r\n\t\t\t\t                    public AssemblyCollection Assemblies\r\n\t\t\t\t                    {\r\n\t\t\t\t                        get { return _assemblies; }\r\n\t\t\t\t                        set { _assemblies = value; }\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    private NamespaceCollection _namespaces;\r\n\t\t\t\t                    public NamespaceCollection Namespaces\r\n\t\t\t\t                    {\r\n\t\t\t\t                        get { return _namespaces; }\r\n\t\t\t\t                        set { _namespaces = value; }\r\n\t\t\t\t                    }\r\n\t\t\t\t                    \r\n\t\t\t\t                    private TypeCollection _types;\r\n\t\t\t\t                    public TypeCollection Types\r\n\t\t\t\t                    {\r\n\t\t\t\t                        get { return _types; }\r\n\t\t\t\t                        set { _types = value; }\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    private MethodCollection _methods;\r\n\t\t\t\t                    public MethodCollection Methods\r\n\t\t\t\t                    {\r\n\t\t\t\t                        get { return _methods; }\r\n\t\t\t\t                        set { _methods = value; }\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    private FieldCollection _fields;\r\n\t\t\t\t                    public FieldCollection Fields\r\n\t\t\t\t                    {\r\n\t\t\t\t                        get { return _fields; }\r\n\t\t\t\t                        set { _fields = value; }\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    private EventCollection _events;\r\n\t\t\t\t                    public EventCollection Events\r\n\t\t\t\t                    {\r\n\t\t\t\t                        get { return _events; }\r\n\t\t\t\t                        set { _events = value; }\r\n\t\t\t\t                    }\r\n\r\n\t\t\t\t                    public object RunMethod()\r\n\t\t\t\t                    {\r\n\t\t\t\t                        \r\n\t\t\t\t                        ";
					int count = Regex.Matches(text, "\\r\\n").Count;
					string text2 = text + code + "\r\n\t\t\t\t                        \r\n                                        return results.ToList();\r\n                                        \r\n\t\t\t\t                    }\r\n\t\t\t\t                }\r\n\t\t\t\t            }\r\n\r\n\t\t\t\t            ";
					CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider(new Dictionary<string, string>
					{
						{
							"CompilerVersion",
							"v3.5"
						}
					});
					CompilerParameters compilerParameters = new CompilerParameters();
					compilerParameters.ReferencedAssemblies.Add(MainViewModelBase.string_0);
					compilerParameters.ReferencedAssemblies.Add("System.dll");
					compilerParameters.ReferencedAssemblies.Add("System.Data.Linq.dll");
					compilerParameters.ReferencedAssemblies.Add("System.Core.dll");
					compilerParameters.ReferencedAssemblies.Add("WindowsBase.dll");
					compilerParameters.ReferencedAssemblies.Add("PresentationCore.dll");
					compilerParameters.ReferencedAssemblies.Add("PresentationFramework.dll");
					Stopwatch stopwatch = Stopwatch.StartNew();
					CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
					{
						text2
					});
					stopwatch.Stop();
					if (compilerResults.Errors.Count != 0)
					{
						rule_1.QueryResults.Problems = this.method_18(compilerResults.Errors, count);
						rule_1.QueryResults.Results = null;
						rule_1.Status = RuleStatus.CompileError;
						if (!bool_4)
						{
							this.Status = string.Concat(new object[]
							{
								"The query \"",
								rule_1.Name,
								"\" had ",
								rule_1.QueryResults.Problems,
								" compilation errors"
							});
							this.method_17(new LightWrapper(rule_1.QueryResults.Results, this.bfCache_0));
						}
						this.method_11(false);
					}
					else
					{
						stopwatch = Stopwatch.StartNew();
						Assembly compiledAssembly = compilerResults.CompiledAssembly;
						Type type = compiledAssembly.GetType("Runner.RunnerClass");
						string text3 = "You don't have any analyzed assemblies loaded";
						try
						{
							ConstructorInfo constructor = type.GetConstructor(new Type[]
							{
								typeof(BfCache),
								typeof(Action<string>),
								typeof(Action<string>),
								typeof(Action<string>),
								typeof(Action),
								typeof(Action)
							});
							Action<string> action = delegate(string message)
							{
								QueryResults expr_0B = rule_1.QueryResults;
								expr_0B.Output += message;
							};
							Action<string> action2 = delegate(string message)
							{
								rule_1.QueryResults.Problems.Add(new Problem
								{
									Description = message,
									ProblemType = RuleStatus.Warning
								});
							};
							Action<string> action3 = delegate(string message)
							{
								rule_1.QueryResults.Problems.Add(new Problem
								{
									Description = message,
									ProblemType = RuleStatus.Error
								});
							};
							Action action4 = delegate
							{
								rule_1.QueryResults.Problems.Add(new Problem
								{
									Description = string.Concat(new object[]
									{
										"\"",
										rule_1.Name,
										"\" returned ",
										rule_1.QueryResults.Results.Count(),
										" results"
									}),
									ProblemType = RuleStatus.Warning
								});
							};
							Action action5 = delegate
							{
								rule_1.QueryResults.Problems.Add(new Problem
								{
									Description = string.Concat(new object[]
									{
										"\"",
										rule_1.Name,
										"\" returned ",
										rule_1.QueryResults.Results.Count(),
										" results"
									}),
									ProblemType = RuleStatus.RuntimeError
								});
							};
							if (this.bfCache_0 == null)
							{
								throw new Exception(text3);
							}
							object obj = constructor.Invoke(new object[]
							{
								this.bfCache_0,
								action,
								action2,
								action3,
								action4,
								action5
							});
							MethodInfo method = type.GetMethod("RunMethod");
							rule_1.QueryResults.Results = (IEnumerable)method.Invoke(obj, null);
							if (rule_1.QueryResults.ResultCount != 0 && rule_1.QueryResults.IdPropertyName == null)
							{
								rule_1.QueryResults.Problems.Add(new Problem
								{
									ProblemType = RuleStatus.Warning,
									Description = "This query's results type does not contain a TypeId, MethodId, FieldId, EventId, AssemblyId or NamespaceId.\r\nWithout one of these fields, Nitriq is unable to generate the CodeTree, nor is it able to highlight the results in the TreeMap"
								});
							}
							if (!bool_4)
							{
								this.method_17(new LightWrapper(rule_1.QueryResults.Results, this.bfCache_0));
							}
							rule_1.QueryResults.Description = string.Concat(new object[]
							{
								"The query \"",
								rule_1.Name,
								"\" has a successfully completed with ",
								rule_1.QueryResults.Results.Cast<object>().Count(),
								" items"
							});
							if (rule_1 == this.CurrentRule)
							{
								this.method_11(true);
							}
						}
						catch (Exception ex)
						{
							ObservableCollection<Problem> observableCollection = new ObservableCollection<Problem>();
							Problem problem = new Problem
							{
								Description = ex.ToString(),
								ProblemType = RuleStatus.RuntimeError
							};
							if (ex.Message == text3)
							{
								problem.Description = text3;
							}
							observableCollection.Add(problem);
							rule_1.QueryResults.Problems = observableCollection;
							rule_1.QueryResults.Results = null;
							rule_1.QueryResults.Description = "The query \"" + rule_1.Name + "\" had a runtime error";
							if (rule_1 == this.CurrentRule)
							{
								this.method_11(false);
							}
						}
						rule_1.CalculateStatus();
						this.FirePropertyChanged("CurrentRule");
						if (!bool_4)
						{
							this.Status = rule_1.QueryResults.Description;
						}
						stopwatch.Stop();
					}
				}
			}
		}

		internal void method_15()
		{
			this.method_13(this.CurrentRule);
		}

		internal LightWrapper method_16()
		{
			return this.lightWrapper_0;
		}

		internal void method_17(LightWrapper value)
		{
			if (this.lightWrapper_0 != value)
			{
				this.lightWrapper_0 = value;
				this.FirePropertyChanged("CodeWrapper");
				if (this.bool_0)
				{
					this.CurrentCodeTreeItemsSource = this.lightWrapper_0.Assemblies;
				}
				if (this.bool_1)
				{
					this.CurrentCodeTreeItemsSource = this.lightWrapper_0.Namespaces;
				}
				if (this.bool_2)
				{
					this.CurrentCodeTreeItemsSource = this.lightWrapper_0.Types;
				}
			}
		}

		private ObservableCollection<Problem> method_18(CompilerErrorCollection compilerErrorCollection_0, int int_14)
		{
			ObservableCollection<Problem> observableCollection = new ObservableCollection<Problem>();
			ObservableCollection<Problem> result;
			foreach (CompilerError compilerError in compilerErrorCollection_0)
			{
				Problem problem = new Problem();
				if (compilerError.ErrorText == "The name 'results' does not exist in the current context")
				{
					problem.Description = "All queries must be assigned to a variable named \"results\"";
					problem.ProblemType = RuleStatus.CompileError;
					observableCollection.Add(problem);
					result = observableCollection;
					return result;
				}
				problem.Description = compilerError.ErrorText;
				problem.LineNumber = new int?(compilerError.Line - int_14);
				problem.ProblemType = RuleStatus.CompileError;
				observableCollection.Add(problem);
			}
			result = observableCollection;
			return result;
		}

		public void DeleteCategory(RuleCategory removeThis)
		{
			while (removeThis.RuleCategories.Count > 0)
			{
				this.DeleteCategory(removeThis.RuleCategories[0]);
			}
			foreach (Rule current in removeThis.Rules)
			{
				this.observableCollection_0.Remove(current);
			}
			this.ruleSet_0.Remove(removeThis);
		}

		public void DeleteRule(Rule removeThis)
		{
			this.observableCollection_0.Remove(removeThis);
			this.ruleSet_0.Remove(removeThis);
		}

		protected void FirePropertyChanged(string propertyName)
		{
			if (this.propertyChangedEventHandler_0 != null)
			{
				this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		[CompilerGenerated]
		private static bool smethod_0(BfAssembly bfAssembly_0)
		{
			return bfAssembly_0.IsCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_1(BfType bfType_0)
		{
			return bfType_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static BfNamespace smethod_2(BfType bfType_0)
		{
			return bfType_0.Namespace;
		}

		[CompilerGenerated]
		private static bool smethod_3(BfType bfType_0)
		{
			return bfType_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_4(BfMethod bfMethod_0)
		{
			return bfMethod_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_5(BfField bfField_0)
		{
			return bfField_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_6(BfEvent bfEvent_0)
		{
			return bfEvent_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_7(BfMethod bfMethod_0)
		{
			return bfMethod_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static int smethod_8(BfMethod bfMethod_0)
		{
			return bfMethod_0.PhysicalLineCount;
		}

		[CompilerGenerated]
		private static bool smethod_9(BfAssembly bfAssembly_0)
		{
			return !bfAssembly_0.IsCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_10(BfType bfType_0)
		{
			return !bfType_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static BfNamespace smethod_11(BfType bfType_0)
		{
			return bfType_0.Namespace;
		}

		[CompilerGenerated]
		private static bool smethod_12(BfType bfType_0)
		{
			return !bfType_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_13(BfMethod bfMethod_0)
		{
			return !bfMethod_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_14(BfField bfField_0)
		{
			return !bfField_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private static bool smethod_15(BfEvent bfEvent_0)
		{
			return !bfEvent_0.IsInCoreAssembly;
		}
	}
}
