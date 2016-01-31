using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace Nitriq.Wpf
{
	public class RenameCategory : Window, IComponentConnector
	{
		private string string_0;

		private bool bool_0;

		internal TextBox textBox_0;

		private bool bool_1;

		public string CategoryName
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		public bool ClickedOk
		{
			get
			{
				return this.bool_0;
			}
		}

		public RenameCategory(string categoryName)
		{
			this.InitializeComponent();
			this.textBox_0.Text = categoryName;
			base.Loaded += new RoutedEventHandler(this.RenameCategory_Loaded);
		}

		private void RenameCategory_Loaded(object sender, RoutedEventArgs e)
		{
			this.textBox_0.SelectAll();
			this.textBox_0.Focus();
		}

		private void method_0(object sender, RoutedEventArgs e)
		{
			this.method_1();
		}

		private void method_1()
		{
			this.bool_0 = true;
			this.string_0 = this.textBox_0.Text;
			base.Close();
		}

		private void method_2(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		private void method_3(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Return)
			{
				this.method_1();
			}
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_1)
			{
				this.bool_1 = true;
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/renamecategory.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.textBox_0 = (TextBox)target;
				this.textBox_0.AddHandler(Keyboard.KeyUpEvent, new KeyEventHandler(this.method_3));
				break;
			case 2:
				((Button)target).Click += new RoutedEventHandler(this.method_0);
				break;
			case 3:
				((Button)target).Click += new RoutedEventHandler(this.method_2);
				break;
			default:
				this.bool_1 = true;
				break;
			}
		}
	}
}
