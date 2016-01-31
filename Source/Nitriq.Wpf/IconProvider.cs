using Nitriq.Analysis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Nitriq.Wpf
{
	public class IconProvider : UserControl, IComponentConnector, INotifyPropertyChanged
	{
		public static readonly DependencyProperty CacheProperty;

		[NonSerialized]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		internal ContentControl contentControl_0;

		private bool bool_0;

		[CompilerGenerated]
		private static Func<PropertyInfo, bool> func_0;

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

		public BfCache Cache
		{
			get
			{
				return (BfCache)base.GetValue(IconProvider.CacheProperty);
			}
			set
			{
				base.SetValue(IconProvider.CacheProperty, value);
			}
		}

		public IconProvider()
		{
			this.InitializeComponent();
			base.Loaded += new RoutedEventHandler(this.IconProvider_Loaded);
		}

		private void IconProvider_Loaded(object sender, RoutedEventArgs e)
		{
			if (base.DataContext == null)
			{
				Logger.LogWarning("IconProvider_Loaded", "this isn't right");
			}
			else
			{
				IEnumerable<PropertyInfo> arg_4F_0 = base.DataContext.GetType().GetProperties();
				if (IconProvider.func_0 == null)
				{
					IconProvider.func_0 = new Func<PropertyInfo, bool>(IconProvider.smethod_2);
				}
				PropertyInfo propertyInfo = arg_4F_0.FirstOrDefault(IconProvider.func_0);
				if (propertyInfo != null && this.Cache != null)
				{
					int num = (int)propertyInfo.GetGetMethod().Invoke(base.DataContext, null);
					if (num >= 0)
					{
						string text = propertyInfo.Name.ToLowerInvariant();
						string text2 = text;
						if (text2 != null)
						{
							if (!(text2 == "methodid"))
							{
								if (!(text2 == "fieldid"))
								{
									if (!(text2 == "eventid"))
									{
										if (!(text2 == "typeid"))
										{
											if (!(text2 == "namespaceid"))
											{
												if (text2 == "assemblyid" && this.Cache.Assemblies.Count > num)
												{
													this.contentControl_0.Content = this.Cache.Assemblies[num];
												}
											}
											else if (this.Cache.Namespaces.Count > num)
											{
												this.contentControl_0.Content = this.Cache.Namespaces[num];
											}
										}
										else if (this.Cache.Types.Count > num)
										{
											this.contentControl_0.Content = this.Cache.Types[num];
										}
									}
									else if (this.Cache.Events.Count > num)
									{
										this.contentControl_0.Content = this.Cache.Events[num];
									}
								}
								else if (this.Cache.Fields.Count > num)
								{
									this.contentControl_0.Content = this.Cache.Fields[num];
								}
							}
							else if (this.Cache.Methods.Count > num)
							{
								this.contentControl_0.Content = this.Cache.Methods[num];
							}
						}
					}
				}
			}
		}

		private static object smethod_0(DependencyObject dependencyObject_0, BfCache bfCache_0)
		{
			IconProvider iconProvider = dependencyObject_0 as IconProvider;
			object result;
			if (iconProvider != null)
			{
				result = iconProvider.OnCoerceCache((BfCache)bfCache_0);
			}
			else
			{
				result = bfCache_0;
			}
			return result;
		}

		private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			IconProvider iconProvider = dependencyObject_0 as IconProvider;
			if (iconProvider != null)
			{
				iconProvider.OnCacheChanged((BfCache)dependencyPropertyChangedEventArgs_0.OldValue, (BfCache)dependencyPropertyChangedEventArgs_0.NewValue);
			}
		}

		protected virtual BfCache OnCoerceCache(BfCache value)
		{
			return value;
		}

		protected virtual void OnCacheChanged(BfCache oldValue, BfCache newValue)
		{
		}

		private void method_0(string string_0)
		{
			if (this.propertyChangedEventHandler_0 != null)
			{
				this.propertyChangedEventHandler_0(this, new PropertyChangedEventArgs(string_0));
			}
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/iconprovider.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId != 1)
			{
				this.bool_0 = true;
			}
			else
			{
				this.contentControl_0 = (ContentControl)target;
			}
		}

		[CompilerGenerated]
		private static bool smethod_2(PropertyInfo propertyInfo_0)
		{
			return (string.Compare(propertyInfo_0.Name, "MethodId", true) == 0 || string.Compare(propertyInfo_0.Name, "FieldId", true) == 0 || string.Compare(propertyInfo_0.Name, "EventId", true) == 0 || string.Compare(propertyInfo_0.Name, "TypeId", true) == 0 || string.Compare(propertyInfo_0.Name, "NamespaceId", true) == 0 || string.Compare(propertyInfo_0.Name, "AssemblyId", true) == 0) && propertyInfo_0.PropertyType == typeof(int);
		}

		static IconProvider()
		{
			IconProvider.CacheProperty = DependencyProperty.Register("Cache", typeof(BfCache), typeof(IconProvider), new UIPropertyMetadata(null, new PropertyChangedCallback(IconProvider.smethod_1), new CoerceValueCallback(IconProvider.smethod_0)));
		}
	}
}
