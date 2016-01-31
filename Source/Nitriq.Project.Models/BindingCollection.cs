using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Nitriq.Project.Models
{
	public class BindingCollection<T> : ObservableCollection<T> where T : INotifyPropertyChanged
	{
		private EventHandler<ItemChangedEventArgs<T>> eventHandler_0;

		[CompilerGenerated]
		private static EventHandler<ItemChangedEventArgs<T>> eventHandler_1;

		public event EventHandler<ItemChangedEventArgs<T>> ItemChanged
		{
			add
			{
				EventHandler<ItemChangedEventArgs<T>> eventHandler = this.eventHandler_0;
				EventHandler<ItemChangedEventArgs<T>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ItemChangedEventArgs<T>> value2 = (EventHandler<ItemChangedEventArgs<T>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<ItemChangedEventArgs<T>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<ItemChangedEventArgs<T>> eventHandler = this.eventHandler_0;
				EventHandler<ItemChangedEventArgs<T>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<ItemChangedEventArgs<T>> value2 = (EventHandler<ItemChangedEventArgs<T>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<ItemChangedEventArgs<T>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		public BindingCollection()
		{
			if (BindingCollection<T>.eventHandler_1 == null)
			{
				BindingCollection<T>.eventHandler_1 = new EventHandler<ItemChangedEventArgs<T>>(BindingCollection<T>.smethod_0);
			}
			this.eventHandler_0 = BindingCollection<T>.eventHandler_1;
			base..ctor();
		}

		protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
			IEnumerator enumerator;
			switch (e.Action)
			{
			case NotifyCollectionChangedAction.Add:
				enumerator = e.NewItems.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						INotifyPropertyChanged notifyPropertyChanged = (INotifyPropertyChanged)enumerator.Current;
						notifyPropertyChanged.PropertyChanged += new PropertyChangedEventHandler(this.method_0);
					}
					goto IL_163;
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
				goto IL_C2;
			case NotifyCollectionChangedAction.Move:
				goto IL_163;
			case NotifyCollectionChangedAction.Reset:
				goto IL_158;
			default:
				goto IL_163;
			}
			enumerator = e.OldItems.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					INotifyPropertyChanged notifyPropertyChanged = (INotifyPropertyChanged)enumerator.Current;
					notifyPropertyChanged.PropertyChanged -= new PropertyChangedEventHandler(this.method_0);
				}
				goto IL_163;
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			IL_C2:
			enumerator = e.NewItems.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					INotifyPropertyChanged notifyPropertyChanged = (INotifyPropertyChanged)enumerator.Current;
					notifyPropertyChanged.PropertyChanged += new PropertyChangedEventHandler(this.method_0);
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			enumerator = e.OldItems.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					INotifyPropertyChanged notifyPropertyChanged = (INotifyPropertyChanged)enumerator.Current;
					notifyPropertyChanged.PropertyChanged -= new PropertyChangedEventHandler(this.method_0);
				}
				goto IL_163;
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			IL_158:
			throw new Exception("Reset is not a valid option");
			IL_163:
			base.OnCollectionChanged(e);
		}

		private void method_0(object sender, PropertyChangedEventArgs e)
		{
			this.eventHandler_0(this, new ItemChangedEventArgs<T>
			{
				Item = (T)((object)sender),
				PropertyName = e.PropertyName
			});
		}

		[CompilerGenerated]
		private static void smethod_0(object sender, ItemChangedEventArgs<T> e)
		{
		}
	}
}
