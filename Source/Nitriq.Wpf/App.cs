using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Threading;

namespace Nitriq.Wpf
{
	[LicenseProvider(typeof(Class15))]
	public class App : Application, IStyleConnector
	{
		private class Exception0 : Exception
		{
		}

		public static string InitialProject;

		private EventHandler eventHandler_0;

		private bool bool_0;

		public event EventHandler ItemDoubleClicked
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

		public App()
		{
			LicenseManager.Validate(typeof(App));
			base..ctor();
			base.Startup += new StartupEventHandler(this.App_Startup);
		}

		private void App_Startup(object sender, StartupEventArgs e)
		{
			if (e.Args.Length == 1 && e.Args[0].ToLowerInvariant().EndsWith(".nitriqproj") && File.Exists(e.Args[0]))
			{
				App.InitialProject = e.Args[0];
			}
		}

		private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			if (!(e.Exception is App.Exception0))
			{
				string str = App.smethod_0(e.Exception);
				MessageBox.Show("Nitriq has encountered an unhandled exception. We'd really appreciate it if you could email \"[install dir]\\" + str + "\" to support@nitriq.com", "Unhandled Exception", MessageBoxButton.OK, MessageBoxImage.Hand);
			}
		}

		internal static string smethod_0(Exception exception_0)
		{
			string text = "exception " + DateTime.Now.ToString("yyyyMMdd HH mm ss") + ".log";
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.Write(exception_0.ToString());
			}
			return text;
		}

		private void method_0(object sender, MouseButtonEventArgs e)
		{
			if (e.ClickCount == 2 && this.eventHandler_0 != null)
			{
				this.eventHandler_0(((Image)sender).DataContext, null);
				e.Handled = true;
			}
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				base.DispatcherUnhandledException += new DispatcherUnhandledExceptionEventHandler(this.App_DispatcherUnhandledException);
				base.StartupUri = new Uri("Window1.xaml", UriKind.Relative);
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/app.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Image)target).AddHandler(Mouse.MouseDownEvent, new MouseButtonEventHandler(this.method_0));
				break;
			case 2:
				((Image)target).AddHandler(Mouse.MouseDownEvent, new MouseButtonEventHandler(this.method_0));
				break;
			case 3:
				((Image)target).AddHandler(Mouse.MouseDownEvent, new MouseButtonEventHandler(this.method_0));
				break;
			case 4:
				((Image)target).AddHandler(Mouse.MouseDownEvent, new MouseButtonEventHandler(this.method_0));
				break;
			case 5:
				((Image)target).AddHandler(Mouse.MouseDownEvent, new MouseButtonEventHandler(this.method_0));
				break;
			case 6:
				((Image)target).AddHandler(Mouse.MouseDownEvent, new MouseButtonEventHandler(this.method_0));
				break;
			}
		}

		[DebuggerNonUserCode, STAThread]
		public static void Main()
		{
			LicenseManager.Validate(typeof(App));
			App app = new App();
			app.InitializeComponent();
			app.Run();
		}
	}
}
