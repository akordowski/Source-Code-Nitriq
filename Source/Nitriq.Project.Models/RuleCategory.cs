using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;

namespace Nitriq.Project.Models
{
	[Serializable]
	public class RuleCategory : INotifyPropertyChanged
	{
		private string string_0;

		private BindingCollection<RuleCategory> bindingCollection_0 = new BindingCollection<RuleCategory>();

		private BindingCollection<Rule> bindingCollection_1 = new BindingCollection<Rule>();

		private ObservableCollection<object> observableCollection_0 = new ObservableCollection<object>();

		private RuleStatus ruleStatus_0 = RuleStatus.None;

		private bool? nullable_0;

		private bool bool_0 = false;

		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		[CompilerGenerated]
		private static Func<object, bool> func_0;

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
					this.method_10("Name");
				}
			}
		}

		public BindingCollection<RuleCategory> RuleCategories
		{
			get
			{
				return this.bindingCollection_0;
			}
		}

		public BindingCollection<Rule> Rules
		{
			get
			{
				return this.bindingCollection_1;
			}
		}

		[XmlIgnore]
		public ObservableCollection<object> ItemCollection
		{
			get
			{
				return this.observableCollection_0;
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
					this.method_10("Status");
				}
			}
		}

		[XmlIgnore]
		public bool? Active
		{
			get
			{
				return this.nullable_0;
			}
			set
			{
				if (this.nullable_0 != value)
				{
					this.method_7(value);
				}
			}
		}

		public RuleCategory()
		{
			this.bindingCollection_0.ItemChanged += new EventHandler<ItemChangedEventArgs<RuleCategory>>(this.method_1);
			this.bindingCollection_0.CollectionChanged += new NotifyCollectionChangedEventHandler(this.bindingCollection_0_CollectionChanged);
			this.bindingCollection_1.ItemChanged += new EventHandler<ItemChangedEventArgs<Rule>>(this.method_0);
			this.bindingCollection_1.CollectionChanged += new NotifyCollectionChangedEventHandler(this.bindingCollection_1_CollectionChanged);
		}

		private void bindingCollection_1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Add)
			{
				foreach (object current in e.NewItems)
				{
					this.method_5(current);
				}
			}
			if (e.Action == NotifyCollectionChangedAction.Remove)
			{
				foreach (object current in e.OldItems)
				{
					this.method_6(current);
				}
			}
			this.method_2();
		}

		private void method_0(object sender, ItemChangedEventArgs<Rule> e)
		{
			this.method_2();
		}

		private void bindingCollection_0_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == NotifyCollectionChangedAction.Add)
			{
				foreach (object current in e.NewItems)
				{
					this.method_5(current);
				}
			}
			if (e.Action == NotifyCollectionChangedAction.Remove)
			{
				foreach (object current in e.OldItems)
				{
					this.method_6(current);
				}
			}
			this.method_2();
		}

		private void method_1(object sender, ItemChangedEventArgs<RuleCategory> e)
		{
			this.method_2();
		}

		private void method_2()
		{
			if (!this.bool_0)
			{
				this.method_3();
				this.method_4();
			}
		}

		private void method_3()
		{
			if (!this.bool_0)
			{
				bool flag = true;
				bool flag2 = true;
				foreach (RuleCategory current in this.bindingCollection_0)
				{
					if (current.Active == true)
					{
						flag2 = false;
					}
					else if (current.Active == false)
					{
						flag = false;
					}
					else if (!current.Active.HasValue)
					{
						flag2 = false;
						flag = false;
					}
				}
				foreach (Rule current2 in this.bindingCollection_1)
				{
					if (current2.Active)
					{
						flag2 = false;
					}
					else if (!current2.Active)
					{
						flag = false;
					}
				}
				if (!flag && !flag2)
				{
					this.nullable_0 = null;
					this.method_10("Active");
				}
				else if (flag)
				{
					this.nullable_0 = new bool?(true);
					this.method_10("Active");
				}
				else if (flag2)
				{
					this.nullable_0 = new bool?(false);
					this.method_10("Active");
				}
			}
		}

		private void method_4()
		{
			if (!this.bool_0)
			{
				RuleStatus ruleStatus = RuleStatus.None;
				foreach (RuleCategory current in this.bindingCollection_0)
				{
					if (!(current.Active == false) && ruleStatus < current.Status)
					{
						ruleStatus = current.Status;
					}
				}
				foreach (Rule current2 in this.bindingCollection_1)
				{
					if (current2.Active && ruleStatus < current2.Status)
					{
						ruleStatus = current2.Status;
					}
				}
				if (this.ruleStatus_0 != ruleStatus)
				{
					this.ruleStatus_0 = ruleStatus;
					this.method_10("Status");
				}
			}
		}

		private void method_5(object object_0)
		{
			if (object_0 is Rule)
			{
				this.observableCollection_0.Add((Rule)object_0);
			}
			if (object_0 is RuleCategory)
			{
				IEnumerable<object> arg_50_0 = this.observableCollection_0;
				if (RuleCategory.func_0 == null)
				{
					RuleCategory.func_0 = new Func<object, bool>(RuleCategory.smethod_0);
				}
				Rule rule = (Rule)arg_50_0.FirstOrDefault(RuleCategory.func_0);
				if (rule == null)
				{
					this.observableCollection_0.Add(object_0);
				}
				else
				{
					int index = this.observableCollection_0.IndexOf(rule);
					this.observableCollection_0.Insert(index, object_0);
				}
			}
		}

		private void method_6(object object_0)
		{
			this.observableCollection_0.Remove(object_0);
		}

		private void method_7(bool? active)
		{
			try
			{
				this.bool_0 = true;
				if (!active.HasValue)
				{
					throw new Exception("Cannot set to intermediate");
				}
				foreach (RuleCategory current in this.bindingCollection_0)
				{
					current.method_7(active);
				}
				foreach (Rule current2 in this.bindingCollection_1)
				{
					current2.Active = active.Value;
				}
				this.bool_0 = false;
				this.nullable_0 = active;
				this.method_10("Active");
				this.method_2();
			}
			finally
			{
				this.bool_0 = false;
			}
		}

		public void Remove(RuleCategory removeThis)
		{
			foreach (RuleCategory current in this.bindingCollection_0)
			{
				current.Remove(removeThis);
			}
			this.bindingCollection_0.Remove(removeThis);
		}

		public void Remove(Rule removeThis)
		{
			foreach (RuleCategory current in this.bindingCollection_0)
			{
				current.Remove(removeThis);
			}
			this.bindingCollection_1.Remove(removeThis);
		}

		internal IEnumerable<Rule> method_8()
		{
			RuleCategory.<RulesEnumerator>d__2 <RulesEnumerator>d__ = new RuleCategory.<RulesEnumerator>d__2(-2);
			<RulesEnumerator>d__.<>4__this = this;
			return <RulesEnumerator>d__;
		}

		internal IEnumerable<RuleCategory> method_9()
		{
			RuleCategory.<RuleCategoryEnumerator>d__e <RuleCategoryEnumerator>d__e = new RuleCategory.<RuleCategoryEnumerator>d__e(-2);
			<RuleCategoryEnumerator>d__e.<>4__this = this;
			return <RuleCategoryEnumerator>d__e;
		}

		public bool ContainsInTree(RuleCategory childCategory)
		{
			bool result;
			if (childCategory == this)
			{
				result = true;
			}
			else
			{
				foreach (RuleCategory current in this.bindingCollection_0)
				{
					if (current.ContainsInTree(childCategory))
					{
						result = true;
						return result;
					}
				}
				result = false;
			}
			return result;
		}

		private void method_10(string string_1)
		{
			if (this.propertyChangedEventHandler_0 != null)
			{
				this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(string_1));
			}
		}

		[CompilerGenerated]
		private static bool smethod_0(object object_0)
		{
			return object_0 is Rule;
		}
	}
}
