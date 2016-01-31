using ActiproSoftware.Windows.Controls.Docking;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Nitriq.Wpf
{
	public class ContainerHelper : DependencyObject
	{
		public static readonly DependencyProperty ChildCollectionProperty;

		public static readonly DependencyProperty ChildTemplateProperty;

		private DockSite dockSite_0;

		private ObservableCollection<DockingWindow> observableCollection_0 = new ObservableCollection<DockingWindow>();

		public IList ChildCollection
		{
			get
			{
				return (IList)base.GetValue(ContainerHelper.ChildCollectionProperty);
			}
			set
			{
				base.SetValue(ContainerHelper.ChildCollectionProperty, value);
			}
		}

		public DataTemplate ChildTemplate
		{
			get
			{
				return (DataTemplate)base.GetValue(ContainerHelper.ChildTemplateProperty);
			}
			set
			{
				base.SetValue(ContainerHelper.ChildTemplateProperty, value);
			}
		}

		public DockSite DockSite
		{
			get
			{
				return this.dockSite_0;
			}
			set
			{
				this.dockSite_0 = value;
				if (value != null)
				{
					this.dockSite_0.WindowClosed += new EventHandler<DockingWindowEventArgs>(this.method_1);
				}
			}
		}

		public ContainerHelper()
		{
			if (this.ChildCollection is INotifyCollectionChanged)
			{
				((INotifyCollectionChanged)this.ChildCollection).CollectionChanged += new NotifyCollectionChangedEventHandler(this.method_0);
			}
		}

		private static object smethod_0(DependencyObject dependencyObject_0, IList ilist_0)
		{
			ContainerHelper containerHelper = dependencyObject_0 as ContainerHelper;
			object result;
			if (containerHelper != null)
			{
				result = containerHelper.OnCoerceChildCollection((IList)ilist_0);
			}
			else
			{
				result = ilist_0;
			}
			return result;
		}

		private static void smethod_1(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			ContainerHelper containerHelper = dependencyObject_0 as ContainerHelper;
			if (containerHelper != null)
			{
				containerHelper.OnChildCollectionChanged((IList)dependencyPropertyChangedEventArgs_0.OldValue, (IList)dependencyPropertyChangedEventArgs_0.NewValue);
			}
		}

		protected virtual IList OnCoerceChildCollection(IList value)
		{
			return value;
		}

		protected virtual void OnChildCollectionChanged(IList oldValue, IList newValue)
		{
			Console.WriteLine("OnChildCollectionChanged ");
			if (oldValue is INotifyCollectionChanged)
			{
				((INotifyCollectionChanged)oldValue).CollectionChanged -= new NotifyCollectionChangedEventHandler(this.method_0);
			}
			if (newValue is INotifyCollectionChanged)
			{
				((INotifyCollectionChanged)newValue).CollectionChanged += new NotifyCollectionChangedEventHandler(this.method_0);
			}
		}

		private static object smethod_2(DependencyObject dependencyObject_0, DataTemplate dataTemplate_0)
		{
			ContainerHelper containerHelper = dependencyObject_0 as ContainerHelper;
			object result;
			if (containerHelper != null)
			{
				result = containerHelper.OnCoerceChildTemplate((DataTemplate)dataTemplate_0);
			}
			else
			{
				result = dataTemplate_0;
			}
			return result;
		}

		private static void smethod_3(DependencyObject dependencyObject_0, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs_0)
		{
			ContainerHelper containerHelper = dependencyObject_0 as ContainerHelper;
			if (containerHelper != null)
			{
				containerHelper.OnChildTemplateChanged((DataTemplate)dependencyPropertyChangedEventArgs_0.OldValue, (DataTemplate)dependencyPropertyChangedEventArgs_0.NewValue);
			}
		}

		protected virtual DataTemplate OnCoerceChildTemplate(DataTemplate value)
		{
			return value;
		}

		protected virtual void OnChildTemplateChanged(DataTemplate oldValue, DataTemplate newValue)
		{
		}

		private void method_0(object sender, NotifyCollectionChangedEventArgs e)
		{
			Console.WriteLine("ChildCollection_CollectionChanging " + e.Action);
			IEnumerator enumerator;
			switch (e.Action)
			{
			case NotifyCollectionChangedAction.Add:
				enumerator = e.NewItems.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object current = enumerator.Current;
						object obj = this.ChildTemplate.LoadContent();
						if (!(obj is Panel))
						{
							throw new Exception("The ChildTemplate MUST create a root node of type \"Panel\" (ex. Panel)");
						}
						DocumentWindow documentWindow = new DocumentWindow(this.dockSite_0);
						documentWindow.DataContext = current;
						documentWindow.Content = obj;
						documentWindow.CanAttach = new bool?(false);
						documentWindow.CanDockBottom = new bool?(false);
						documentWindow.CanDockTop = new bool?(false);
						documentWindow.CanDockLeft = new bool?(false);
						documentWindow.CanDockRight = new bool?(false);
						BindingOperations.SetBinding(documentWindow, DockingWindow.TitleProperty, new Binding("Name"));
						documentWindow.Activate(true);
						this.observableCollection_0.Add(documentWindow);
					}
					return;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
				break;
			case NotifyCollectionChangedAction.Remove:
				break;
			case NotifyCollectionChangedAction.Replace:
				goto IL_1AD;
			case NotifyCollectionChangedAction.Move:
				return;
			case NotifyCollectionChangedAction.Reset:
				throw new Exception("Rest Not Yet Supported");
			default:
				return;
			}
			enumerator = e.OldItems.GetEnumerator();
			try
			{
				object item;
				while (enumerator.MoveNext())
				{
					item = enumerator.Current;
					DockingWindow dockingWindow = (from dw in this.observableCollection_0
					where dw.DataContext == item
					select dw).FirstOrDefault<DockingWindow>();
					if (dockingWindow != null)
					{
						dockingWindow.Close();
					}
				}
				return;
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			IL_1AD:
			throw new Exception("Replace not yet supported");
		}

		private void method_1(object sender, DockingWindowEventArgs e)
		{
			Console.WriteLine("DockSite Closed " + e.Window.Title);
			try
			{
				this.observableCollection_0.Remove(e.Window);
				if (this.ChildCollection != null)
				{
					this.ChildCollection.Remove(e.Window.DataContext);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		static ContainerHelper()
		{
			ContainerHelper.ChildCollectionProperty = DependencyProperty.Register("ChildCollection", typeof(IList), typeof(ContainerHelper), new UIPropertyMetadata(null, new PropertyChangedCallback(ContainerHelper.smethod_1), new CoerceValueCallback(ContainerHelper.smethod_0)));
			ContainerHelper.ChildTemplateProperty = DependencyProperty.Register("ChildTemplate", typeof(DataTemplate), typeof(ContainerHelper), new UIPropertyMetadata(null, new PropertyChangedCallback(ContainerHelper.smethod_3), new CoerceValueCallback(ContainerHelper.smethod_2)));
		}
	}
}
