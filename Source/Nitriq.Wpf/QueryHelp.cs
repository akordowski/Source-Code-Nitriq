using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Nitriq.Wpf
{
	public class QueryHelp : Window, IComponentConnector
	{
		internal WebBrowser webBrowser_0;

		private bool bool_0;

		public QueryHelp()
		{
			this.InitializeComponent();
			base.Loaded += new RoutedEventHandler(this.QueryHelp_Loaded);
		}

		private void QueryHelp_Loaded(object sender, RoutedEventArgs e)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Nitriq.Wpf.Resources.QueryEditorHelp.html");
			this.webBrowser_0.NavigateToStream(manifestResourceStream);
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/queryhelp.xaml", UriKind.Relative);
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
				this.webBrowser_0 = (WebBrowser)target;
			}
		}
	}
}
