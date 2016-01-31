using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Nitriq.Wpf
{
	public class TreemapControl : UserControl, IComponentConnector
	{
		private Brush brush_0 = new SolidColorBrush(Color.FromArgb(128, 0, 0, 255));

		private Brush brush_1 = new SolidColorBrush(Color.FromArgb(128, 255, 0, 0));

		private Brush brush_2 = Brushes.OrangeRed;

		private IEnumerable<object> ienumerable_0 = new List<object>();

		private IEnumerable<object> ienumerable_1 = new List<object>();

		private Dictionary<object, string> dictionary_0 = new Dictionary<object, string>();

		private Dictionary<object, string> dictionary_1 = new Dictionary<object, string>();

		private DispatcherTimer dispatcherTimer_0 = new DispatcherTimer
		{
			Interval = new TimeSpan(0, 0, 0, 0, 750),
			IsEnabled = false
		};

		private int int_0 = 0;

		internal Popup popup_0;

		internal ContentControl contentControl_0;

		internal TreemapHost treemapHost_0;

		internal TreemapHighlight treemapHighlight_0;

		internal Canvas canvas_0;

		internal Canvas canvas_1;

		internal Canvas canvas_2;

		private bool bool_0;

		public DataTemplate PopupContentTemplate
		{
			get
			{
				return this.contentControl_0.ContentTemplate;
			}
			set
			{
				this.contentControl_0.ContentTemplate = value;
			}
		}

		public DataTemplateSelector PopupContentTemplateSelector
		{
			get
			{
				return this.contentControl_0.ContentTemplateSelector;
			}
			set
			{
				this.contentControl_0.ContentTemplateSelector = value;
			}
		}

		public Brush HighlightBrush
		{
			get
			{
				return this.brush_0;
			}
			set
			{
				this.brush_0 = value;
			}
		}

		public Brush ActiveBrush
		{
			get
			{
				return this.brush_1;
			}
			set
			{
				this.brush_1 = value;
			}
		}

		public Brush LabelBrush
		{
			get
			{
				return this.brush_2;
			}
			set
			{
				this.brush_2 = value;
			}
		}

		public TreemapControl()
		{
			this.InitializeComponent();
			this.dispatcherTimer_0.Tick += new EventHandler(this.dispatcherTimer_0_Tick);
			this.treemapHighlight_0.TreemapHost = this.treemapHost_0;
		}

		private void canvas_2_MouseLeave(object sender, MouseEventArgs e)
		{
			this.popup_0.IsOpen = false;
		}

		private void canvas_2_MouseEnter(object sender, MouseEventArgs e)
		{
			if (this.popup_0.DataContext != null)
			{
				this.popup_0.IsOpen = true;
			}
		}

		private void canvas_2_MouseMove(object sender, MouseEventArgs e)
		{
			Point position = e.GetPosition(this.treemapHost_0);
			TreeItem treeItem = this.treemapHost_0.FindItemByPoint(position);
			if (treeItem != null)
			{
				this.popup_0.DataContext = treeItem;
				this.popup_0.PlacementRectangle = new Rect(position.X, position.Y + 20.0, 1.0, 1.0);
			}
		}

		private void canvas_2_MouseDown(object sender, MouseButtonEventArgs e)
		{
		}

		public void MakeCushionTreeMap(TreeItem root)
		{
			this.ClearHighlighting();
			this.ClearLabeling();
			this.treemapHost_0.MakeCushionTreeMap(root, base.ActualWidth, base.ActualHeight);
		}

		public void HighlightItems(IEnumerable<object> baseObjects)
		{
			this.HighlightItems(baseObjects, false);
		}

		public void HighlightItems(IEnumerable<object> baseObjects, bool clearHighlighting)
		{
			if (clearHighlighting)
			{
				this.ClearHighlighting();
			}
			this.ienumerable_0 = baseObjects;
			this.treemapHighlight_0.HighlightItems(baseObjects);
		}

		public void ActivateItem(object obj)
		{
			this.ActivateItems(new List<object>
			{
				obj
			}, true);
		}

		public void ActivateItems(IEnumerable<object> baseObjects, bool clearHighlighting)
		{
			if (clearHighlighting)
			{
				this.ClearActive();
			}
			this.ienumerable_1 = baseObjects;
			foreach (object current in baseObjects)
			{
				TreeItem treeItem = this.treemapHost_0.FindTreeItem(current);
				if (treeItem != null)
				{
					Rectangle element = new Rectangle
					{
						Width = treeItem.Bounds.Width,
						Height = treeItem.Bounds.Height,
						Fill = this.brush_1
					};
					Canvas.SetTop(element, treeItem.Bounds.Y);
					Canvas.SetLeft(element, treeItem.Bounds.X);
					this.canvas_1.Children.Add(element);
				}
			}
		}

		public void LabelItems(Dictionary<object, string> baseObjectToLabel)
		{
			this.LabelItems(baseObjectToLabel, new Dictionary<object, string>(), false);
		}

		public void LabelItems(Dictionary<object, string> baseObjectToLabel, Dictionary<object, string> baseObjectToLabel2, bool clearLabeling)
		{
			if (clearLabeling)
			{
				this.ClearLabeling();
			}
			this.dictionary_0 = baseObjectToLabel;
			this.dictionary_1 = baseObjectToLabel2;
			Thickness padding = new Thickness(4.0);
			Dictionary<object, TextBlock> dictionary = new Dictionary<object, TextBlock>();
			DropShadowEffect effect = new DropShadowEffect
			{
				BlurRadius = 3.0,
				ShadowDepth = 0.0,
				Opacity = 1.0,
				Color = Colors.White
			};
			int num = 24;
			Size size = new Size(10.0, 10.0);
			Rect finalRect = new Rect(size);
			new SolidColorBrush(Color.FromArgb(128, 128, 0, 128));
			foreach (object current in baseObjectToLabel.Keys)
			{
				TreeItem treeItem = this.treemapHost_0.FindTreeItem(current);
				if (treeItem != null && (treeItem.Bounds.Width >= 70.0 && treeItem.Bounds.Height >= 30.0))
				{
					TextBlock textBlock = new TextBlock
					{
						MaxWidth = treeItem.Bounds.Width,
						MaxHeight = (double)num,
						Foreground = Brushes.Black,
						Text = baseObjectToLabel[current],
						FontWeight = FontWeights.Bold,
						FontSize = 16.0,
						Effect = effect,
						Padding = padding,
						TextWrapping = TextWrapping.NoWrap,
						TextTrimming = TextTrimming.None
					};
					textBlock.Measure(size);
					textBlock.Arrange(finalRect);
					dictionary.Add(current, textBlock);
					Canvas.SetTop(textBlock, treeItem.Bounds.Y);
					Canvas.SetLeft(textBlock, treeItem.Bounds.X);
					this.canvas_2.Children.Add(textBlock);
				}
			}
			foreach (object current in baseObjectToLabel2.Keys)
			{
				TreeItem treeItem = this.treemapHost_0.FindTreeItem(current);
				if (treeItem != null && (treeItem.Bounds.Width >= 50.0 && treeItem.Bounds.Height >= 30.0))
				{
					TextBlock textBlock = new TextBlock
					{
						MaxWidth = treeItem.Bounds.Width,
						Height = 20.0,
						Foreground = Brushes.Black,
						Text = baseObjectToLabel2[current],
						FontSize = 13.0,
						Effect = effect,
						Padding = padding,
						TextWrapping = TextWrapping.NoWrap,
						TextTrimming = TextTrimming.None
					};
					double num2 = treeItem.Bounds.Y;
					if (dictionary.ContainsKey(treeItem.method_0().BaseObject))
					{
						TextBlock textBlock2 = dictionary[treeItem.method_0().BaseObject];
						double num3 = Canvas.GetTop(textBlock2) + textBlock2.ActualHeight;
						if (this.method_0(textBlock2, treeItem.Bounds))
						{
							num2 = num3 - 5.0;
							if (num2 + textBlock.Height > treeItem.Bounds.Bottom)
							{
								continue;
							}
						}
					}
					Canvas.SetTop(textBlock, num2);
					Canvas.SetLeft(textBlock, treeItem.Bounds.X);
					this.canvas_2.Children.Add(textBlock);
				}
			}
		}

		private bool method_0(TextBlock textBlock_0, Rect rect_0)
		{
			double top = Canvas.GetTop(textBlock_0);
			double left = Canvas.GetLeft(textBlock_0);
			double val = left + textBlock_0.ActualWidth;
			double val2 = top + textBlock_0.ActualHeight;
			double num = Math.Max(left, rect_0.X);
			double num2 = Math.Max(top, rect_0.Y);
			double num3 = Math.Min(val, rect_0.Right);
			double num4 = Math.Min(val2, rect_0.Bottom);
			return num <= num3 && num2 <= num4;
		}

		public void ClearActive()
		{
			this.canvas_1.Children.Clear();
		}

		public void ClearHighlighting()
		{
			this.canvas_0.Children.Clear();
			this.treemapHighlight_0.ClearHighlighting();
		}

		public void ClearLabeling()
		{
			this.canvas_2.Children.Clear();
		}

		internal void method_1(object sender, SizeChangedEventArgs e)
		{
			this.dispatcherTimer_0.IsEnabled = true;
			this.dispatcherTimer_0.Stop();
			this.dispatcherTimer_0.Start();
		}

		private void dispatcherTimer_0_Tick(object sender, EventArgs e)
		{
			this.dispatcherTimer_0.IsEnabled = false;
			Console.WriteLine("TICK" + this.int_0++);
			if (this.treemapHost_0.Root != null)
			{
				this.treemapHost_0.MakeCushionTreeMap(this.treemapHost_0.Root, base.ActualWidth, base.ActualHeight);
				this.HighlightItems(this.ienumerable_0, true);
				this.ActivateItems(this.ienumerable_1, true);
				this.LabelItems(this.dictionary_0, this.dictionary_1, true);
			}
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/treemapcontrol.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[DebuggerNonUserCode]
		internal Delegate method_2(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((TreemapControl)target).SizeChanged += new SizeChangedEventHandler(this.method_1);
				break;
			case 2:
				this.popup_0 = (Popup)target;
				break;
			case 3:
				this.contentControl_0 = (ContentControl)target;
				break;
			case 4:
				this.treemapHost_0 = (TreemapHost)target;
				break;
			case 5:
				this.treemapHighlight_0 = (TreemapHighlight)target;
				break;
			case 6:
				this.canvas_0 = (Canvas)target;
				break;
			case 7:
				this.canvas_1 = (Canvas)target;
				break;
			case 8:
				this.canvas_2 = (Canvas)target;
				this.canvas_2.MouseDown += new MouseButtonEventHandler(this.canvas_2_MouseDown);
				this.canvas_2.MouseMove += new MouseEventHandler(this.canvas_2_MouseMove);
				this.canvas_2.MouseEnter += new MouseEventHandler(this.canvas_2_MouseEnter);
				this.canvas_2.MouseLeave += new MouseEventHandler(this.canvas_2_MouseLeave);
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}
	}
}
