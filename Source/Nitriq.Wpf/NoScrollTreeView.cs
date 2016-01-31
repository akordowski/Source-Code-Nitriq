using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Nitriq.Wpf
{
	public class NoScrollTreeView : TreeView
	{
		public class NoScrollTreeViewItem : TreeViewItem
		{
			private bool bool_0;

			public bool AllowBringIntoView
			{
				get
				{
					return this.bool_0;
				}
				set
				{
					this.bool_0 = value;
				}
			}

			public NoScrollTreeViewItem()
			{
				RequestBringIntoViewEventHandler value = new RequestBringIntoViewEventHandler(this.method_0);
				base.RequestBringIntoView += value;
			}

			protected override DependencyObject GetContainerForItemOverride()
			{
				return new NoScrollTreeView.NoScrollTreeViewItem();
			}

			[CompilerGenerated]
			private void method_0(object sender, RequestBringIntoViewEventArgs e)
			{
				if (!this.AllowBringIntoView)
				{
					e.Handled = true;
				}
			}
		}

		protected override DependencyObject GetContainerForItemOverride()
		{
			return new NoScrollTreeView.NoScrollTreeViewItem();
		}

		protected override void OnMouseDoubleClick(MouseButtonEventArgs e)
		{
			base.OnMouseDoubleClick(e);
		}
	}
}
