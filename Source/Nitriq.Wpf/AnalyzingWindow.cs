using Nitriq.Analysis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Nitriq.Wpf
{
	public class AnalyzingWindow : Window, IComponentConnector
	{
		private IEnumerable<AssemblyFileInfo> ienumerable_0;

		private Thread thread_0;

		private Exception exception_0;

		private BfCache bfCache_0;

		private bool bool_0 = false;

		private bool bool_1;

		[CompilerGenerated]
		private static Func<KeyValuePair<string, AssemblyTuple>, bool> func_0;

		public Exception CaughtException
		{
			get
			{
				return this.exception_0;
			}
			set
			{
				this.exception_0 = value;
			}
		}

		public AnalyzingWindow(IEnumerable<AssemblyFileInfo> assemblies)
		{
			this.InitializeComponent();
			this.ienumerable_0 = assemblies;
			base.Loaded += new RoutedEventHandler(this.AnalyzingWindow_Loaded);
		}

		private void AnalyzingWindow_Loaded(object sender, RoutedEventArgs e)
		{
			this.thread_0 = new Thread(new ThreadStart(this.method_5));
			this.thread_0.Start();
		}

		private void method_0()
		{
			this.method_3(true);
			base.Close();
		}

		internal BfCache method_1()
		{
			return this.bfCache_0;
		}

		internal bool method_2()
		{
			return this.bool_0;
		}

		internal void method_3(bool value)
		{
			this.bool_0 = value;
		}

		private void method_4(object sender, RoutedEventArgs e)
		{
			this.thread_0.Abort();
			base.Close();
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_1)
			{
				this.bool_1 = true;
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/analyzingwindow.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			if (connectionId != 1)
			{
				this.bool_1 = true;
			}
			else
			{
				((Button)target).Click += new RoutedEventHandler(this.method_4);
			}
		}

		[CompilerGenerated]
		private void method_5()
		{
			try
			{
				Dictionary<string, AssemblyTuple> dictionary = BfCache.smethod_1(this.ienumerable_0);
				if (Class13.smethod_0())
				{
					IEnumerable<KeyValuePair<string, AssemblyTuple>> arg_35_0 = dictionary;
					if (AnalyzingWindow.func_0 == null)
					{
						AnalyzingWindow.func_0 = new Func<KeyValuePair<string, AssemblyTuple>, bool>(AnalyzingWindow.smethod_0);
					}
					if (arg_35_0.Where(AnalyzingWindow.func_0).Any<KeyValuePair<string, AssemblyTuple>>())
					{
						throw new NitriqException("MergedAssemblies", "Nitriq Free Edition does not allow you analyze assemblies with more than one module (the assembly was probably merged). Nitriq Pro has no restrictions and can be purchased at www.nitriq.com");
					}
				}
				this.bfCache_0 = new BfCache(dictionary);
				base.Dispatcher.Invoke(new Action(this.method_0), new object[0]);
			}
			catch (Exception caughtException)
			{
				this.CaughtException = caughtException;
				base.Dispatcher.Invoke(new Action(this.method_0), new object[0]);
			}
		}

		[CompilerGenerated]
		private static bool smethod_0(KeyValuePair<string, AssemblyTuple> a)
		{
			return a.Value.IsCoreAssembly && a.Value.Assembly.Modules.Count > 1;
		}
	}
}
