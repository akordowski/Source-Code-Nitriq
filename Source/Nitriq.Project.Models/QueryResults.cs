using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Nitriq.Project.Models
{
	public class QueryResults : INotifyPropertyChanged
	{
		private IEnumerable ienumerable_0;

		private ObservableCollection<string> observableCollection_0 = new ObservableCollection<string>();

		private string string_0;

		private object object_0;

		private HashSet<int> hashSet_0 = new HashSet<int>();

		private ResultIdTypes resultIdTypes_0;

		private string string_1;

		private ObservableCollection<Problem> observableCollection_1 = new ObservableCollection<Problem>();

		private string string_2;

		private string string_3;

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

		public int ResultCount
		{
			get
			{
				int result;
				if (this.ienumerable_0 == null)
				{
					result = 0;
				}
				else
				{
					result = this.ienumerable_0.Cast<object>().Count<object>();
				}
				return result;
			}
		}

		public IEnumerable Results
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
					this.method_1("Results");
					this.method_0();
				}
			}
		}

		public ObservableCollection<string> AvailableWeights
		{
			get
			{
				return this.observableCollection_0;
			}
			set
			{
				if (this.observableCollection_0 != value)
				{
					this.observableCollection_0 = value;
					this.method_1("AvailableWeights");
				}
			}
		}

		public string CurrentWeightProperty
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
					this.method_1("CurrentWeightProperty");
				}
			}
		}

		public object CurrentItem
		{
			get
			{
				return this.object_0;
			}
			set
			{
				if (this.object_0 != value)
				{
					this.object_0 = value;
					this.method_1("CurrentItem");
				}
			}
		}

		public HashSet<int> ResultIds
		{
			get
			{
				return this.hashSet_0;
			}
			set
			{
				if (this.hashSet_0 != value)
				{
					this.hashSet_0 = value;
					this.method_1("ResultIds");
				}
			}
		}

		public ResultIdTypes ResultIdType
		{
			get
			{
				return this.resultIdTypes_0;
			}
			set
			{
				if (this.resultIdTypes_0 != value)
				{
					this.resultIdTypes_0 = value;
					this.method_1("ResultIdType");
				}
			}
		}

		public string IdPropertyName
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
					this.method_1("IdPropertyName");
				}
			}
		}

		public ObservableCollection<Problem> Problems
		{
			get
			{
				return this.observableCollection_1;
			}
			set
			{
				if (this.observableCollection_1 != value)
				{
					this.observableCollection_1 = value;
					this.method_1("Problems");
				}
			}
		}

		public string Output
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
					this.method_1("Output");
				}
			}
		}

		public string Description
		{
			get
			{
				return this.string_3;
			}
			set
			{
				if (this.string_3 != value)
				{
					this.string_3 = value;
					this.method_1("Description");
				}
			}
		}

		private void method_0()
		{
			this.AvailableWeights.Clear();
			this.CurrentWeightProperty = "";
			this.IdPropertyName = null;
			this.ResultIds = null;
			if (this.Results != null && this.Results.Cast<object>().Count<object>() > 0)
			{
				object obj = this.Results.Cast<object>().FirstOrDefault<object>();
				if (obj != null)
				{
					this.AvailableWeights.Clear();
					this.IdPropertyName = null;
					this.ResultIds = new HashSet<int>();
					PropertyInfo[] properties = obj.GetType().GetProperties();
					for (int i = 0; i < properties.Length; i++)
					{
						PropertyInfo propertyInfo = properties[i];
						string text = QueryResults.smethod_1(propertyInfo);
						if (QueryResults.smethod_2(propertyInfo.PropertyType) && text == null)
						{
							this.AvailableWeights.Add(propertyInfo.Name);
						}
						if (text != null)
						{
							this.IdPropertyName = text;
							this.ResultIds = new HashSet<int>();
							MethodInfo methodInfo = propertyInfo.GetAccessors().First<MethodInfo>();
							foreach (object current in this.Results)
							{
								this.hashSet_0.Add((int)methodInfo.Invoke(current, null));
							}
						}
					}
					if (!this.AvailableWeights.Contains(this.CurrentWeightProperty ?? ""))
					{
						this.CurrentWeightProperty = this.AvailableWeights.FirstOrDefault<string>();
					}
				}
			}
		}

		private static bool smethod_0(PropertyInfo propertyInfo_0)
		{
			string text = QueryResults.smethod_1(propertyInfo_0);
			return text != null;
		}

		private static string smethod_1(PropertyInfo propertyInfo_0)
		{
			string result;
			if (string.Compare(propertyInfo_0.Name, "MethodId", true) == 0)
			{
				result = "MethodId";
			}
			else if (string.Compare(propertyInfo_0.Name, "FieldId", true) == 0)
			{
				result = "FieldId";
			}
			else if (string.Compare(propertyInfo_0.Name, "EventId", true) == 0)
			{
				result = "EventId";
			}
			else if (string.Compare(propertyInfo_0.Name, "TypeId", true) == 0)
			{
				result = "TypeId";
			}
			else if (string.Compare(propertyInfo_0.Name, "NamespaceId", true) == 0)
			{
				result = "NamespaceId";
			}
			else if (string.Compare(propertyInfo_0.Name, "AssemblyId", true) == 0)
			{
				result = "AssemblyId";
			}
			else
			{
				result = null;
			}
			return result;
		}

		private static bool smethod_2(Type type_0)
		{
			return type_0 == typeof(double) || type_0 == typeof(int) || type_0 == typeof(float) || type_0 == typeof(decimal) || type_0 == typeof(short) || type_0 == typeof(long) || type_0 == typeof(byte);
		}

		private void method_1(string string_4)
		{
			if (this.propertyChangedEventHandler_0 != null)
			{
				this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(string_4));
			}
		}
	}
}
