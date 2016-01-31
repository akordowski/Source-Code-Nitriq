using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Nitriq.Wpf
{
	public class PropertyQuickInfoProvider : IContentProvider
	{
		private string string_0;

		private string string_1;

		private string string_2;

		public string Name
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

		public string PropertyType
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		public string Summary
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		public object GetContent()
		{
			StackPanel stackPanel = new StackPanel
			{
				MaxWidth = 400.0
			};
			StackPanel stackPanel2 = new StackPanel
			{
				Orientation = Orientation.Horizontal
			};
			stackPanel2.Children.Add(new TextBlock
			{
				Text = this.string_1,
				Foreground = Brushes.Black
			});
			stackPanel2.Children.Add(new TextBlock
			{
				Text = " ",
				Foreground = Brushes.Black
			});
			stackPanel2.Children.Add(new TextBlock
			{
				Text = this.string_0,
				Foreground = Brushes.Black
			});
			stackPanel.Children.Add(stackPanel2);
			stackPanel.Children.Add(new TextBlock
			{
				Text = this.string_2,
				TextWrapping = TextWrapping.Wrap,
				Foreground = Brushes.Black,
				FontSize = 12.0
			});
			return stackPanel;
		}
	}
}
