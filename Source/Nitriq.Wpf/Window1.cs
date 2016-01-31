using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Serialization;
using ActiproSoftware.Windows.Controls.Ribbon.Controls;
using Microsoft.Win32;
using Microsoft.Windows.Controls;
using Nitriq.Analysis.Models;
using Nitriq.Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace Nitriq.Wpf
{
	public class Window1 : Window, IComponentConnector, IStyleConnector, IHasPanel
	{
		private BfCache bfCache_0;

		private ToolWindow toolWindow_0;

		private MainViewModel mainViewModel_0 = new MainViewModel();

		private ContainerHelper containerHelper_0 = new ContainerHelper();

		private IconTemplateSelector iconTemplateSelector_0;

		private DataTemplate dataTemplate_0;

		private bool bool_0 = true;

		private AssemblyCollection assemblyCollection_0;

		private NamespaceCollection namespaceCollection_0;

		private TypeCollection typeCollection_0;

		private MethodCollection methodCollection_0;

		private FieldCollection fieldCollection_0;

		private EventCollection eventCollection_0;

		private Panel panel_0;

		private Point point_0 = default(Point);

		private bool bool_1 = false;

		internal ActiproSoftware.Windows.Controls.Ribbon.Controls.Button button_0;

		internal ActiproSoftware.Windows.Controls.Ribbon.Controls.Button button_1;

		internal ActiproSoftware.Windows.Controls.Ribbon.Controls.Button button_2;

		internal Group group_0;

		internal TextBlock textBlock_0;

		internal DockSite dockSite_0;

		internal ToolWindow toolWindow_1;

		internal DockPanel dockPanel_0;

		internal NoScrollTreeView noScrollTreeView_0;

		internal DockSite dockSite_1;

		internal ToolWindowContainer toolWindowContainer_0;

		internal ToolWindow toolWindow_2;

		internal ToolWindow toolWindow_3;

		internal ToolWindow toolWindow_4;

		internal Border border_0;

		internal TreeView treeView_0;

		internal ToolWindow toolWindow_5;

		internal ToolWindow toolWindow_6;

		internal System.Windows.Controls.TextBox textBox_0;

		internal ToolWindow toolWindow_7;

		internal TreemapControl treemapControl_0;

		private bool bool_2;

		[CompilerGenerated]
		private static Func<BfType, int> func_0;

		[CompilerGenerated]
		private static Func<BfMethod, int> func_1;

		[CompilerGenerated]
		private static Func<AssemblyFileInfo, string> func_2;

		[CompilerGenerated]
		private static Func<BfMethod, bool> func_3;

		[CompilerGenerated]
		private static Func<BfMethod, string> func_4;

		[CompilerGenerated]
		private static Action<BfType, TreeItem> action_0;

		[CompilerGenerated]
		private static Action<BfType, TreeItem> action_1;

		[CompilerGenerated]
		private static Action<BfType, TreeItem> action_2;

		[CompilerGenerated]
		private static Action<BfType, TreeItem> action_3;

		[CompilerGenerated]
		private static Func<BfType, bool> func_5;

		[CompilerGenerated]
		private static Func<BfType, bool> func_6;

		public AssemblyCollection Assemblies
		{
			get
			{
				return this.assemblyCollection_0;
			}
			set
			{
				this.assemblyCollection_0 = value;
			}
		}

		public NamespaceCollection Namespaces
		{
			get
			{
				return this.namespaceCollection_0;
			}
			set
			{
				this.namespaceCollection_0 = value;
			}
		}

		public TypeCollection Types
		{
			get
			{
				return this.typeCollection_0;
			}
			set
			{
				this.typeCollection_0 = value;
			}
		}

		public MethodCollection Methods
		{
			get
			{
				return this.methodCollection_0;
			}
			set
			{
				this.methodCollection_0 = value;
			}
		}

		public FieldCollection Fields
		{
			get
			{
				return this.fieldCollection_0;
			}
			set
			{
				this.fieldCollection_0 = value;
			}
		}

		public EventCollection Events
		{
			get
			{
				return this.eventCollection_0;
			}
			set
			{
				this.eventCollection_0 = value;
			}
		}

		public Panel Panel
		{
			get
			{
				return null;
			}
		}

		public Window1()
		{
			this.InitializeComponent();
			base.Loaded += new RoutedEventHandler(this.Window1_Loaded);
			((App)Application.Current).ItemDoubleClicked += new EventHandler(this.method_0);
			this.mainViewModel_0.CurrentRuleRan += new EventHandler(this.mainViewModel_0_CurrentRuleRan);
			this.toolWindow_7.GotFocus += new RoutedEventHandler(this.toolWindow_3_GotFocus);
			this.toolWindow_4.GotFocus += new RoutedEventHandler(this.toolWindow_3_GotFocus);
			this.toolWindow_3.GotFocus += new RoutedEventHandler(this.toolWindow_3_GotFocus);
			base.Closing += new CancelEventHandler(this.Window1_Closing);
		}

		private void Window1_Closing(object sender, CancelEventArgs e)
		{
			if (this.bool_0)
			{
				if (!this.mainViewModel_0.HaveSavedProject && this.mainViewModel_0.method_5() != null)
				{
					MessageBoxResult messageBoxResult = MessageBox.Show("You have not saved the current project, do you want to save before you close Nitriq?", "Save Project Before Closing?", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
					if (messageBoxResult == MessageBoxResult.Yes)
					{
						this.method_11(null, null);
					}
					else if (messageBoxResult == MessageBoxResult.Cancel)
					{
						e.Cancel = true;
						return;
					}
				}
				if (!Class13.smethod_0() && this.mainViewModel_0.HaveRulesChanged)
				{
					MessageBoxResult messageBoxResult = MessageBox.Show("You have unsaved changes to your queries, do you want to export your queries before you close Nitriq?", "Export Unsaved Queries Before Closing?", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
					if (messageBoxResult == MessageBoxResult.Yes)
					{
						this.method_39(null, null);
					}
					else if (messageBoxResult == MessageBoxResult.Cancel)
					{
						e.Cancel = true;
					}
				}
			}
		}

		private void toolWindow_3_GotFocus(object sender, RoutedEventArgs e)
		{
			if (sender == this.toolWindow_7 || sender == this.toolWindow_4 || sender == this.toolWindow_3)
			{
				this.toolWindow_0 = (ToolWindow)sender;
			}
		}

		private void mainViewModel_0_CurrentRuleRan(object sender, EventArgs e)
		{
			if ((bool)sender)
			{
				if (this.toolWindow_0 == null)
				{
					this.toolWindow_4.Activate(true);
				}
				else if (!this.toolWindow_0.IsSelected)
				{
					this.toolWindow_0.Activate(true);
				}
			}
			else if (!this.toolWindow_5.IsSelected)
			{
				this.toolWindow_5.Activate(true);
			}
		}

		private void method_0(object sender, EventArgs e)
		{
			if (sender is BfAssembly)
			{
				BfAssembly assembly = sender as BfAssembly;
				IEnumerable<object> baseObjects = (from t in this.mainViewModel_0.method_5().Types
				where t.Assembly == assembly
				select t).Cast<object>();
				this.treemapControl_0.ActivateItems(baseObjects, true);
			}
			else
			{
				this.treemapControl_0.ActivateItem(sender);
			}
		}

		private void Window1_Loaded(object sender, RoutedEventArgs e)
		{
			base.Left = 5.0;
			base.Top = 5.0;
			this.treemapControl_0.PopupContentTemplate = this.mainViewModel_0.TreemapPopupTemplate;
			CodeTreeTemplateSelector codeTreeTemplateSelector = (CodeTreeTemplateSelector)this.border_0.Resources["CodeTreeTemplateSelector"];
			codeTreeTemplateSelector.AssemblyTemplate = (DataTemplate)this.border_0.Resources["LightAssemblyTemplate"];
			codeTreeTemplateSelector.NamespaceTemplate = (DataTemplate)this.border_0.Resources["LightNamespaceTemplate"];
			codeTreeTemplateSelector.TypeTemplate = (DataTemplate)this.border_0.Resources["LightTypeTemplate"];
			codeTreeTemplateSelector.DetailsTemplate = (DataTemplate)this.border_0.Resources["LightDetailsTemplate"];
			this.iconTemplateSelector_0 = (IconTemplateSelector)base.Resources["IconTemplateSelector"];
			this.dataTemplate_0 = (DataTemplate)base.Resources["IconProviderTemplate"];
			this.mainViewModel_0.RuleEditorTemplate = (DataTemplate)base.Resources["RuleEditorTemplate"];
			base.DataContext = this.mainViewModel_0;
			this.containerHelper_0 = new ContainerHelper();
			this.containerHelper_0.ChildTemplate = this.mainViewModel_0.RuleEditorTemplate;
			this.containerHelper_0.ChildCollection = this.mainViewModel_0.OpenRules;
			this.containerHelper_0.DockSite = this.dockSite_1;
			this.mainViewModel_0.PropertyChanged += new PropertyChangedEventHandler(this.mainViewModel_0_PropertyChanged);
			this.mainViewModel_0.method_1(this.method_1(), false);
			this.method_3();
			if (App.InitialProject != null)
			{
				this.method_13(App.InitialProject);
			}
		}

		private string method_1()
		{
			string result;
			if (Class13.smethod_0())
			{
				result = null;
			}
			else
			{
				string path = this.method_2();
				string text = Path.Combine(path, "myQueries.nq");
				if (!System.IO.File.Exists(text))
				{
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Nitriq.Wpf.myQueries.nq");
					string value;
					using (StreamReader streamReader = new StreamReader(manifestResourceStream))
					{
						value = streamReader.ReadToEnd();
					}
					using (StreamWriter streamWriter = new StreamWriter(text))
					{
						streamWriter.Write(value);
					}
				}
				result = text;
			}
			return result;
		}

		private string method_2()
		{
			string result;
			try
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				string text = Path.Combine(folderPath, "nitriq");
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				result = text;
			}
			catch
			{
				result = null;
			}
			return result;
		}

		private void method_3()
		{
			try
			{
				using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("dock.site", FileMode.OpenOrCreate))
				{
					if (isolatedStorageFileStream.Length == 0L)
					{
						this.method_4();
					}
					else
					{
						DockSiteLayoutSerializer dockSiteLayoutSerializer = new DockSiteLayoutSerializer();
						dockSiteLayoutSerializer.LoadFromStream(isolatedStorageFileStream, this.dockSite_0);
					}
				}
			}
			catch (Exception)
			{
				this.method_4();
			}
			this.toolWindow_1.Title = "Queries";
		}

		private void method_4()
		{
			try
			{
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Nitriq.Wpf.Resources.dock.site");
				DockSiteLayoutSerializer dockSiteLayoutSerializer = new DockSiteLayoutSerializer();
				dockSiteLayoutSerializer.LoadFromStream(manifestResourceStream, this.dockSite_0);
			}
			catch (Exception)
			{
			}
		}

		private void mainViewModel_0_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "CurrentRule")
			{
				this.method_49();
			}
			else if (e.PropertyName == "TreemapPopupTemplate")
			{
				this.treemapControl_0.PopupContentTemplate = this.mainViewModel_0.TreemapPopupTemplate;
			}
		}

		private void method_5(TreeViewItem treeViewItem_0)
		{
			foreach (TreeViewItem treeViewItem in ((IEnumerable)treeViewItem_0.Items))
			{
				treeViewItem.IsExpanded = true;
				this.method_5(treeViewItem);
			}
		}

		internal Panel method_6()
		{
			return this.panel_0;
		}

		public void Chart<T>(IEnumerable<T> data, Func<T, string> xFunc, Func<T, double> yFunc)
		{
		}

		public void Grid(IEnumerable data)
		{
		}

		private void method_7(object sender, EventArgs e)
		{
		}

		public void ClearMainPanel()
		{
		}

		private void method_8(object sender, RoutedEventArgs e)
		{
			this.mainViewModel_0.method_15();
		}

		private void method_9()
		{
			Window1.<>c__DisplayClass8 <>c__DisplayClass = new Window1.<>c__DisplayClass8();
			Window1.<>c__DisplayClass8 arg_24_0 = <>c__DisplayClass;
			if (Window1.func_0 == null)
			{
				Window1.func_0 = new Func<BfType, int>(Window1.smethod_2);
			}
			arg_24_0.lcom = Window1.func_0;
			from type in this.bfCache_0.Types
			where <>c__DisplayClass.lcom(type) > 1
			select new
			{
				FullName = type.FullName,
				LCOM = <>c__DisplayClass.lcom(type)
			};
		}

		private void method_10(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.F5)
			{
				this.method_8(null, null);
			}
		}

		private void method_11(object sender, RoutedEventArgs e)
		{
			if (this.mainViewModel_0.method_5() == null)
			{
				MessageBox.Show("There are no analyzed assemblies loaded", "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
			}
			else
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Title = "Save Nitriq Project";
				saveFileDialog.DefaultExt = "nitriqProj";
				saveFileDialog.Filter = "Nitriq Project (*.nitriqProj)|*.nitriqProj";
				saveFileDialog.InitialDirectory = this.method_2();
				if (saveFileDialog.ShowDialog() == true)
				{
					using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
					{
						foreach (string current in this.mainViewModel_0.Files)
						{
							streamWriter.WriteLine(current);
						}
					}
					this.mainViewModel_0.Status = "Project has been successfully saved";
					this.mainViewModel_0.HaveSavedProject = true;
				}
			}
		}

		private void method_12(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Load Nitriq Project";
			openFileDialog.DefaultExt = "nitriqProj";
			openFileDialog.Filter = "Nitriq Project (*.nitriqProj)|*.nitriqProj";
			openFileDialog.InitialDirectory = this.method_2();
			if (openFileDialog.ShowDialog() == true)
			{
				this.method_13(openFileDialog.FileName);
			}
		}

		private void method_13(string string_0)
		{
			List<string> list = new List<string>();
			using (StreamReader streamReader = new StreamReader(string_0))
			{
				while (!streamReader.EndOfStream)
				{
					list.Add(streamReader.ReadLine());
				}
			}
			AssemblyPicker assemblyPicker = new AssemblyPicker(list);
			if (assemblyPicker.ShowDialog() == true)
			{
				this.method_16(assemblyPicker.Assemblies);
			}
		}

		private void method_14()
		{
			DataTemplate dataTemplate = new DataTemplate();
			FrameworkElementFactory frameworkElementFactory = new FrameworkElementFactory(typeof(IconProvider));
			frameworkElementFactory.SetValue(IconProvider.CacheProperty, this.mainViewModel_0.method_5());
			dataTemplate.VisualTree = frameworkElementFactory;
			this.dataTemplate_0 = dataTemplate;
		}

		private void method_15(object sender, RoutedEventArgs e)
		{
			AssemblyPicker assemblyPicker = new AssemblyPicker();
			if (assemblyPicker.ShowDialog() == true)
			{
				this.method_16(assemblyPicker.Assemblies);
			}
		}

		private void method_16(IEnumerable<AssemblyFileInfo> assemblies)
		{
			AnalyzingWindow analyzingWindow = new AnalyzingWindow(assemblies);
			analyzingWindow.ShowDialog();
			this.textBox_0.Text = Logger.InfoLogData;
			if (analyzingWindow.method_2())
			{
				if (analyzingWindow.CaughtException != null)
				{
					if (analyzingWindow.CaughtException is NitriqException && ((NitriqException)analyzingWindow.CaughtException).Name == "NotManagedAssembly")
					{
						MessageBox.Show("We had a problem analyzing the assemblies\r\n" + analyzingWindow.CaughtException.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
					}
					else if (analyzingWindow.CaughtException is NitriqException && ((NitriqException)analyzingWindow.CaughtException).Name == "CantResolve")
					{
						MessageBox.Show(analyzingWindow.CaughtException.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
					}
					else if (analyzingWindow.CaughtException is NitriqException && ((NitriqException)analyzingWindow.CaughtException).Name == "MergedAssemblies")
					{
						MessageBox.Show(analyzingWindow.CaughtException.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
					}
					else
					{
						string str = App.smethod_0(analyzingWindow.CaughtException);
						MessageBox.Show("We had a problem analyzing the assemblies\r\nWe'd really appreciate it if you could email \"[install dir]\\" + str + "\" to support@nitriq.com\r\n" + analyzingWindow.CaughtException.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
					}
				}
				else
				{
					this.mainViewModel_0.method_6(analyzingWindow.method_1());
					MainViewModelBase arg_1A4_0 = this.mainViewModel_0;
					if (Window1.func_2 == null)
					{
						Window1.func_2 = new Func<AssemblyFileInfo, string>(Window1.smethod_4);
					}
					arg_1A4_0.Files = new List<string>(assemblies.Select(Window1.func_2));
					this.mainViewModel_0.method_10(new List<AssemblyFileInfo>(assemblies));
					this.mainViewModel_0.Status = "Analysis Successful";
					this.method_14();
					this.method_48(null, null);
					this.method_17();
				}
			}
			else
			{
				this.mainViewModel_0.Status = "Analysis Cancelled";
			}
		}

		private void method_17()
		{
			IEnumerable<BfMethod> arg_2D_0 = this.mainViewModel_0.method_5().Methods;
			if (Window1.func_3 == null)
			{
				Window1.func_3 = new Func<BfMethod, bool>(Window1.smethod_5);
			}
			IEnumerable<BfMethod> arg_4F_0 = arg_2D_0.Where(Window1.func_3);
			if (Window1.func_4 == null)
			{
				Window1.func_4 = new Func<BfMethod, string>(Window1.smethod_6);
			}
			IEnumerable<string> enumerable = arg_4F_0.Select(Window1.func_4).Distinct<string>();
			if (enumerable.Count() > 0)
			{
				string text = "Nitriq has calculated some methods in the below assembly(s) to have negative physical line counts. This typically indicates that the assembly and/or pdb files being analyzed are out of sync with the source files. For best results, analyze the assemblies in the bin/debug directory and perform the analysis right after performing a build of the assemblies.\r\n\r\n";
				Builder builder = new Builder("\r\n");
				foreach (string current in enumerable)
				{
					builder.Append(current);
				}
				text += builder;
				MessageBox.Show(text, "Source Code Not In Sync", MessageBoxButton.OK, MessageBoxImage.Exclamation);
			}
		}

		private void method_18(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed && !this.bool_1)
			{
				Point position = e.GetPosition(null);
				if (Math.Abs(position.X - this.point_0.X) > SystemParameters.MinimumHorizontalDragDistance || Math.Abs(position.Y - this.point_0.Y) > SystemParameters.MinimumVerticalDragDistance)
				{
					this.method_20(sender, e);
				}
			}
		}

		private void method_19(object sender, MouseButtonEventArgs e)
		{
			this.point_0 = e.GetPosition(null);
		}

		private void method_20(object sender, MouseEventArgs e)
		{
			this.bool_1 = true;
			Panel panel = (Panel)sender;
			object dataContext = panel.DataContext;
			DataObject data = new DataObject(dataContext.GetType(), dataContext);
			DragDrop.DoDragDrop((DependencyObject)sender, data, DragDropEffects.Move);
			this.bool_1 = false;
		}

		private void method_21(object sender, MouseEventArgs e)
		{
			Panel panel = (Panel)sender;
			object dataContext = panel.DataContext;
			GiveFeedbackEventHandler value = new GiveFeedbackEventHandler(this.method_22);
			((FrameworkElement)sender).GiveFeedback += value;
			this.bool_1 = true;
			DataObject data = new DataObject(dataContext.GetType(), dataContext);
			DragDrop.DoDragDrop((FrameworkElement)sender, data, DragDropEffects.Move);
			((FrameworkElement)sender).GiveFeedback -= value;
			this.bool_1 = false;
		}

		private void method_22(object sender, GiveFeedbackEventArgs e)
		{
			try
			{
				Mouse.SetCursor(Cursors.Hand);
				e.UseDefaultCursors = false;
				e.Handled = true;
			}
			finally
			{
			}
		}

		private void method_23(object sender, DragEventArgs e)
		{
			RuleSet ruleSet = this.mainViewModel_0.RuleSet;
			Panel panel = (Panel)sender;
			if (panel.DataContext is RuleCategory)
			{
				RuleCategory ruleCategory = (RuleCategory)panel.DataContext;
				bool flag = Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl);
				if (e.Data.GetDataPresent(typeof(RuleCategory)))
				{
					RuleCategory ruleCategory2 = (RuleCategory)e.Data.GetData(typeof(RuleCategory));
					if (ruleCategory2.ContainsInTree(ruleCategory))
					{
						panel.Background = Brushes.Transparent;
						return;
					}
					if (ruleCategory2 != ruleCategory)
					{
						if (flag)
						{
							ruleCategory.RuleCategories.Add(Util.DeepCopy<RuleCategory>(ruleCategory2));
						}
						else
						{
							ruleSet.Remove(ruleCategory2);
							ruleCategory.RuleCategories.Add(ruleCategory2);
						}
					}
				}
				else if (e.Data.GetDataPresent(typeof(Rule)))
				{
					Rule rule = (Rule)e.Data.GetData(typeof(Rule));
					if (flag)
					{
						ruleCategory.Rules.Add(Util.DeepCopy<Rule>(rule));
					}
					else
					{
						ruleSet.Remove(rule);
						ruleCategory.Rules.Add(rule);
					}
				}
			}
			panel.Background = Brushes.Transparent;
		}

		private void method_24(object sender, DragEventArgs e)
		{
			Panel panel = (Panel)sender;
			if (panel.DataContext is RuleCategory)
			{
				if (e.Data.GetDataPresent(typeof(RuleCategory)))
				{
					RuleCategory ruleCategory = (RuleCategory)e.Data.GetData(typeof(RuleCategory));
					if (ruleCategory.ContainsInTree(panel.DataContext as RuleCategory))
					{
						panel.Background = Brushes.Pink;
					}
					else
					{
						panel.Background = Brushes.LightGreen;
					}
				}
				else
				{
					panel.Background = Brushes.LightGreen;
				}
			}
			else if (panel.DataContext is Rule)
			{
				panel.Background = Brushes.Pink;
			}
		}

		private void method_25(object sender, DragEventArgs e)
		{
			Panel panel = (Panel)sender;
			panel.Background = Brushes.Transparent;
		}

		private void method_26(object sender, DockingWindowContextMenuEventArgs e)
		{
			RoutedEventHandler routedEventHandler = null;
			Window1.<>c__DisplayClass16 <>c__DisplayClass = new Window1.<>c__DisplayClass16();
			<>c__DisplayClass.e = e2;
			<>c__DisplayClass.<>4__this = this;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			foreach (object current in ((IEnumerable)<>c__DisplayClass.e.ContextMenu.Items))
			{
				if (current is MenuItem)
				{
					MenuItem menuItem = current as MenuItem;
					string a = menuItem.Header.ToString();
					if (a == "New Horizontal Tab Group" || a == "New Vertical Tab Group" || a == "Float" || a == "Dock")
					{
						menuItem.Visibility = Visibility.Collapsed;
					}
					if (a == "Close")
					{
						flag = true;
					}
					if (a == "Close All")
					{
						flag2 = true;
					}
					if (a == "Close All But This")
					{
						flag2 = true;
					}
				}
				else if (current is FrameworkElement)
				{
					((FrameworkElement)current).Visibility = Visibility.Collapsed;
				}
			}
			if (!flag2 && flag)
			{
				MenuItem menuItem2 = new MenuItem();
				menuItem2.Header = "Close All";
				MenuItem arg_167_0 = menuItem2;
				if (routedEventHandler == null)
				{
					routedEventHandler = new RoutedEventHandler(this.method_60);
				}
				arg_167_0.Click += routedEventHandler;
				<>c__DisplayClass.e.ContextMenu.Items.Add(menuItem2);
			}
			if (!flag3 && flag)
			{
				MenuItem menuItem2 = new MenuItem();
				menuItem2.Header = "Close All But This";
				menuItem2.Click += delegate(object sender, RoutedEventArgs e)
				{
					Window1.<>c__DisplayClass16.Class12 @class = new Window1.<>c__DisplayClass16.Class12();
					@class.<>c__DisplayClass16_0 = <>c__DisplayClass;
					@class.rule_0 = (<>c__DisplayClass.e.Window.DataContext as Rule);
					if (@class.rule_0 != null)
					{
						<>c__DisplayClass.<>4__this.mainViewModel_0.OpenRules.RemoveWhere(new Func<Rule, bool>(@class.method_0));
					}
				};
				<>c__DisplayClass.e.ContextMenu.Items.Add(menuItem2);
			}
		}

		protected void RulesTreeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (this.noScrollTreeView_0.SelectedItem is Rule)
			{
				Rule rule = (Rule)this.noScrollTreeView_0.SelectedItem;
				if (!this.mainViewModel_0.OpenRules.Contains(rule))
				{
					this.mainViewModel_0.OpenRules.Add(rule);
				}
				else
				{
					this.mainViewModel_0.CurrentRule = rule;
					foreach (DocumentWindow current in this.dockSite_1.DocumentWindows)
					{
						if (current.DataContext == this.mainViewModel_0.CurrentRule)
						{
							current.Activate(true);
						}
					}
				}
			}
		}

		private void method_27(object sender, DockingWindowEventArgs e)
		{
			Console.WriteLine("Window Activated: " + e.Window.Title);
			this.mainViewModel_0.CurrentRule = (e.Window.DataContext as Rule);
		}

		private void method_28(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Delete)
			{
				if (this.noScrollTreeView_0.SelectedItem is RuleCategory)
				{
					this.method_35(this.noScrollTreeView_0.SelectedItem as RuleCategory);
				}
				else if (this.noScrollTreeView_0.SelectedItem is Rule)
				{
					this.method_36(this.noScrollTreeView_0.SelectedItem as Rule);
				}
			}
		}

		private void method_29(object sender, RoutedEventArgs e)
		{
			RuleCategory ruleCategory_ = (RuleCategory)((FrameworkElement)sender).Tag;
			this.mainViewModel_0.method_12(ruleCategory_);
		}

		private void method_30(object sender, RoutedEventArgs e)
		{
			RuleCategory ruleCategory = (RuleCategory)((FrameworkElement)sender).Tag;
			Rule item = new Rule
			{
				Active = true,
				Code = "var results = ",
				Name = "New Rule"
			};
			ruleCategory.Rules.Add(item);
			this.mainViewModel_0.OpenRules.Add(item);
		}

		private void method_31(object sender, RoutedEventArgs e)
		{
			RuleCategory ruleCategory = (RuleCategory)((FrameworkElement)sender).Tag;
			RuleCategory ruleCategory2 = new RuleCategory
			{
				Name = "New Rule Category"
			};
			if (Window1.smethod_0(ruleCategory2))
			{
				ruleCategory.RuleCategories.Add(ruleCategory2);
				Thread.Sleep(500);
				this.SetSelectedItem(ruleCategory2);
			}
		}

		private void method_32(object sender, RoutedEventArgs e)
		{
			RuleCategory ruleCategory = new RuleCategory
			{
				Name = "New Root Rule Category"
			};
			if (Window1.smethod_0(ruleCategory))
			{
				this.mainViewModel_0.RuleSet.RuleCategories.Add(ruleCategory);
				this.SetSelectedItem(ruleCategory);
			}
		}

		private void method_33(object sender, RoutedEventArgs e)
		{
			Rule rule_ = (Rule)((FrameworkElement)sender).Tag;
			this.method_36(rule_);
		}

		private void method_34(object sender, RoutedEventArgs e)
		{
			RuleCategory ruleCategory_ = (RuleCategory)((FrameworkElement)sender).Tag;
			this.method_35(ruleCategory_);
		}

		private void method_35(RuleCategory ruleCategory_0)
		{
			if (MessageBox.Show("Are you sure you want to delete the category \"" + ruleCategory_0.Name + "\"?", "Delete Category?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
			{
				this.mainViewModel_0.DeleteCategory(ruleCategory_0);
			}
		}

		private void method_36(Rule rule_0)
		{
			if (MessageBox.Show("Are you sure you want to delete the Rule \"" + rule_0.Name + "\"?", "Delete Rule?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
			{
				this.mainViewModel_0.DeleteRule(rule_0);
			}
		}

		internal void method_37(object sender, RoutedEventArgs e)
		{
			RuleCategory ruleCategory = ((FrameworkElement)sender).Tag as RuleCategory;
			Window1.smethod_0(ruleCategory);
			this.SetSelectedItem(ruleCategory);
		}

		private static bool smethod_0(RuleCategory ruleCategory_0)
		{
			RenameCategory renameCategory = new RenameCategory(ruleCategory_0.Name);
			renameCategory.ShowDialog();
			bool result;
			if (renameCategory.ClickedOk)
			{
				ruleCategory_0.Name = renameCategory.CategoryName;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		public void SetSelectedItem(object item)
		{
			try
			{
				NoScrollTreeView.NoScrollTreeViewItem noScrollTreeViewItem = this.noScrollTreeView_0.ItemContainerGenerator.ContainerFromItem(item) as NoScrollTreeView.NoScrollTreeViewItem;
				if (noScrollTreeViewItem != null)
				{
					try
					{
						noScrollTreeViewItem.AllowBringIntoView = true;
						noScrollTreeViewItem.Focus();
					}
					finally
					{
						noScrollTreeViewItem.AllowBringIntoView = false;
					}
				}
			}
			catch
			{
			}
		}

		private void method_38(object sender, ExecuteRoutedEventArgs e)
		{
			if (Class13.smethod_0())
			{
				MessageBox.Show("Nitriq Free Edition does not allow you to import query files. Nitriq Pro has no restrictions and can be purchased at www.nitriq.com/GetPro", "Feature Not Available", MessageBoxButton.OK, MessageBoxImage.Asterisk);
			}
			else
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Import Nitriq Queries";
				openFileDialog.DefaultExt = "nq";
				openFileDialog.Filter = "Nitriq Queries (*.nq)|*.nq";
				openFileDialog.InitialDirectory = this.method_2();
				if (openFileDialog.ShowDialog() == true)
				{
					this.mainViewModel_0.method_0(openFileDialog.FileName);
				}
			}
		}

		private void method_39(object sender, ExecuteRoutedEventArgs e)
		{
			if (Class13.smethod_0())
			{
				MessageBox.Show("Nitriq Free Edition does not allow you to export query files. Nitriq Pro has no restrictions and can be purchased at www.nitriq.com/GetPro", "Feature Not Available", MessageBoxButton.OK, MessageBoxImage.Asterisk);
			}
			else
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Title = "Export Nitriq Queries";
				saveFileDialog.DefaultExt = "nq";
				saveFileDialog.Filter = "Nitriq Queries (*.nq)|*.nq";
				saveFileDialog.InitialDirectory = this.method_2();
				if (saveFileDialog.ShowDialog() == true)
				{
					this.mainViewModel_0.method_2(saveFileDialog.FileName);
				}
			}
		}

		private void method_40(object sender, ExecuteRoutedEventArgs e)
		{
			this.method_11(null, null);
		}

		private void method_41(object sender, ExecuteRoutedEventArgs e)
		{
			this.method_12(null, null);
		}

		private void method_42(object sender, ExecuteRoutedEventArgs e)
		{
			this.method_16(this.mainViewModel_0.method_9());
		}

		private void method_43(object sender, ExecuteRoutedEventArgs e)
		{
			this.method_15(null, null);
		}

		private void method_44(object sender, ToolTipEventArgs e)
		{
		}

		private void method_45(object sender, MouseEventArgs e)
		{
			this.mainViewModel_0.CurrentRule.QueryResults.CurrentItem = ((FrameworkElement)e.OriginalSource).DataContext;
		}

		private void method_46(object sender, EventArgs e)
		{
			DataGrid dataGrid = sender as DataGrid;
			if (dataGrid != null && dataGrid.ItemsSource != null)
			{
				dataGrid.Columns.Clear();
				object obj = dataGrid.ItemsSource.OfType<object>().FirstOrDefault<object>();
				if (obj != null)
				{
					PropertyInfo[] properties = obj.GetType().GetProperties();
					PropertyInfo[] array = properties;
					for (int i = 0; i < array.Length; i++)
					{
						PropertyInfo propertyInfo = array[i];
						if (propertyInfo.PropertyType == typeof(int) && (string.Compare(propertyInfo.Name, "MethodId", true) == 0 || string.Compare(propertyInfo.Name, "FieldId", true) == 0 || string.Compare(propertyInfo.Name, "EventId", true) == 0 || string.Compare(propertyInfo.Name, "TypeId", true) == 0 || string.Compare(propertyInfo.Name, "NamespaceId", true) == 0 || string.Compare(propertyInfo.Name, "AssemblyId", true) == 0))
						{
							dataGrid.Columns.Add(new DataGridTemplateColumn
							{
								IsReadOnly = true,
								CellTemplate = this.dataTemplate_0
							});
						}
						else if (Window1.smethod_1(propertyInfo.PropertyType))
						{
							dataGrid.Columns.Add(new DataGridTextColumn
							{
								Header = propertyInfo.Name,
								IsReadOnly = true,
								Binding = new Binding(propertyInfo.Name)
								{
									Mode = BindingMode.OneWay
								}
							});
						}
					}
				}
			}
		}

		private static bool smethod_1(Type type_0)
		{
			return type_0 == typeof(string) || type_0 == typeof(int) || type_0 == typeof(double) || type_0 == typeof(bool) || type_0 == typeof(float) || type_0 == typeof(decimal) || type_0 == typeof(short) || type_0 == typeof(long) || type_0 == typeof(byte);
		}

		private void method_47(object sender, MouseButtonEventArgs e)
		{
			BindingOperations.GetBinding((DependencyObject)sender, TextBlock.TextProperty);
		}

		private void method_48(object sender, RoutedEventArgs e)
		{
			Func<object, double> func = null;
			Func<object, double> func2 = null;
			Func<object, double> func3 = null;
			Func<object, double> func4 = null;
			try
			{
				if (this.mainViewModel_0.method_5() != null)
				{
					this.mainViewModel_0.BuildTreemapPopupTemplate();
					TreeItem treeItem = new TreeItem();
					Dictionary<object, string> dictionary = new Dictionary<object, string>();
					Dictionary<object, string> dictionary2 = new Dictionary<object, string>();
					if (Window1.action_0 == null)
					{
						Window1.action_0 = new Action<BfType, TreeItem>(Window1.smethod_7);
					}
					Action<BfType, TreeItem> action = Window1.action_0;
					if (this.mainViewModel_0.CurrentTreemapMetric.Level == "Method")
					{
						if (Window1.action_1 == null)
						{
							Window1.action_1 = new Action<BfType, TreeItem>(Window1.smethod_8);
						}
						action = Window1.action_1;
					}
					else if (this.mainViewModel_0.CurrentTreemapMetric.Level == "Field")
					{
						if (Window1.action_2 == null)
						{
							Window1.action_2 = new Action<BfType, TreeItem>(Window1.smethod_9);
						}
						action = Window1.action_2;
					}
					else if (this.mainViewModel_0.CurrentTreemapMetric.Level == "Event")
					{
						if (Window1.action_3 == null)
						{
							Window1.action_3 = new Action<BfType, TreeItem>(Window1.smethod_10);
						}
						action = Window1.action_3;
					}
					if (Window1.func_5 == null)
					{
						Window1.func_5 = new Func<BfType, bool>(Window1.smethod_11);
					}
					Func<BfType, bool> func5 = Window1.func_5;
					if (this.mainViewModel_0.TreemapHideNonCoreAssemblies)
					{
						if (Window1.func_6 == null)
						{
							Window1.func_6 = new Func<BfType, bool>(Window1.smethod_12);
						}
						func5 = Window1.func_6;
					}
					foreach (BfNamespace current in ((IEnumerable<BfNamespace>)this.mainViewModel_0.method_5().Namespaces))
					{
						if (current.Types.Count != 0)
						{
							dictionary.Add(current, current.FullName);
							TreeItem treeItem2 = new TreeItem
							{
								BaseObject = current
							};
							treeItem.method_3(treeItem2);
							foreach (BfType current2 in ((IEnumerable<BfType>)current.Types))
							{
								if (func5(current2))
								{
									if (!dictionary2.ContainsKey(current2))
									{
										dictionary2.Add(current2, current2.Name);
									}
									TreeItem treeItem3 = new TreeItem
									{
										BaseObject = current2
									};
									treeItem2.method_3(treeItem3);
									action(current2, treeItem3);
								}
							}
						}
					}
					if (this.mainViewModel_0.CurrentTreemapMetric.Level == "Type")
					{
						TreeItem arg_2A6_0 = treeItem;
						if (func == null)
						{
							func = new Func<object, double>(this.method_61);
						}
						arg_2A6_0.CalculateSize(func);
					}
					else if (this.mainViewModel_0.CurrentTreemapMetric.Level == "Method")
					{
						TreeItem arg_2E3_0 = treeItem;
						if (func2 == null)
						{
							func2 = new Func<object, double>(this.method_62);
						}
						arg_2E3_0.CalculateSize(func2);
					}
					else if (this.mainViewModel_0.CurrentTreemapMetric.Level == "Field")
					{
						TreeItem arg_31D_0 = treeItem;
						if (func3 == null)
						{
							func3 = new Func<object, double>(this.method_63);
						}
						arg_31D_0.CalculateSize(func3);
					}
					else if (this.mainViewModel_0.CurrentTreemapMetric.Level == "Event")
					{
						TreeItem arg_357_0 = treeItem;
						if (func4 == null)
						{
							func4 = new Func<object, double>(this.method_64);
						}
						arg_357_0.CalculateSize(func4);
					}
					this.treemapControl_0.MakeCushionTreeMap(treeItem);
					this.treemapControl_0.LabelItems(dictionary, dictionary2, true);
					this.method_49();
				}
			}
			catch (Exception ex)
			{
				Logger.LogWarning("RefreshTreemap_Click", ex.ToString());
			}
		}

		private void method_49()
		{
			if (this.mainViewModel_0.method_5() != null && this.mainViewModel_0.CurrentRule != null && this.mainViewModel_0.CurrentRule.QueryResults != null)
			{
				HashSet<int> resultIds = this.mainViewModel_0.CurrentRule.QueryResults.ResultIds;
				IEnumerable enumerable = null;
				string text = (this.mainViewModel_0.CurrentRule.QueryResults.IdPropertyName ?? "").ToUpperInvariant();
				if (text != null)
				{
					if (!(text == "ASSEMBLYID"))
					{
						if (!(text == "NAMESPACEID"))
						{
							if (!(text == "TYPEID"))
							{
								if (!(text == "EVENTID"))
								{
									if (!(text == "METHODID"))
									{
										if (text == "FIELDID")
										{
											enumerable = this.mainViewModel_0.method_5().Fields;
										}
									}
									else
									{
										enumerable = this.mainViewModel_0.method_5().Methods;
									}
								}
								else
								{
									enumerable = this.mainViewModel_0.method_5().Events;
								}
							}
							else
							{
								enumerable = this.mainViewModel_0.method_5().Types;
							}
						}
						else
						{
							enumerable = this.mainViewModel_0.method_5().Namespaces;
						}
					}
					else
					{
						enumerable = this.mainViewModel_0.method_5().Assemblies;
					}
				}
				List<object> list = new List<object>();
				if (enumerable == null)
				{
					this.treemapControl_0.ClearHighlighting();
					this.treemapControl_0.ClearActive();
				}
				else
				{
					this.treemapControl_0.ClearActive();
					foreach (BfSerializable bfSerializable in enumerable)
					{
						if (resultIds.Contains(bfSerializable.Id))
						{
							list.Add(bfSerializable);
						}
					}
					this.treemapControl_0.HighlightItems(list, true);
				}
			}
		}

		private void method_50(object sender, ExecuteRoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Save Tool Window Layout";
			saveFileDialog.DefaultExt = "site";
			saveFileDialog.Filter = "Dock Site (*.site)|*.site";
			saveFileDialog.RestoreDirectory = true;
			if (saveFileDialog.ShowDialog() == true)
			{
				DockSiteLayoutSerializer dockSiteLayoutSerializer = new DockSiteLayoutSerializer();
				dockSiteLayoutSerializer.SaveToFile(saveFileDialog.FileName, this.dockSite_0);
			}
		}

		private void method_51(object sender, ExecuteRoutedEventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Title = "Save Tool Window Layout";
				openFileDialog.DefaultExt = "site";
				openFileDialog.Filter = "Dock Site (*.site)|*.site";
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == true)
				{
					DockSiteLayoutSerializer dockSiteLayoutSerializer = new DockSiteLayoutSerializer();
					dockSiteLayoutSerializer.LoadFromFile(openFileDialog.FileName, this.dockSite_0);
				}
			}
			catch (Exception ex)
			{
				Logger.LogWarning("DeserializeDockSite", ex.ToString());
			}
		}

		private void method_52(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.F5)
			{
				this.mainViewModel_0.method_15();
			}
		}

		private void method_53(object sender, ExecuteRoutedEventArgs e)
		{
			this.method_8(null, null);
		}

		private void method_54(object sender, DataGridAutoGeneratingColumnEventArgs e)
		{
			e.Cancel = true;
		}

		private void method_55(object sender, ExecuteRoutedEventArgs e)
		{
		}

		private void method_56(object sender, CancelEventArgs e)
		{
			using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("dock.site", FileMode.Create))
			{
				DockSiteLayoutSerializer dockSiteLayoutSerializer = new DockSiteLayoutSerializer();
				dockSiteLayoutSerializer.SaveToStream(isolatedStorageFileStream, this.dockSite_0);
			}
		}

		private void method_57(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.F8 && Keyboard.Modifiers == (ModifierKeys.Alt | ModifierKeys.Control))
			{
				if (this.group_0.Visibility == Visibility.Collapsed)
				{
					this.group_0.Visibility = Visibility.Visible;
				}
				else
				{
					this.group_0.Visibility = Visibility.Collapsed;
				}
				e.Handled = true;
			}
			e.Handled = false;
		}

		private void method_58(object sender, MouseButtonEventArgs e)
		{
			QueryHelp queryHelp = new QueryHelp();
			queryHelp.Show();
		}

		public void GoProButton_Click(object sender, RoutedEventArgs e)
		{
			Process.Start(new ProcessStartInfo("http://www.nitriq.com/GetPro"));
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_2)
			{
				this.bool_2 = true;
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/window1.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
			}
		}

		[DebuggerNonUserCode]
		internal Delegate method_59(Type type_0, string string_0)
		{
			return Delegate.CreateDelegate(type_0, this, string_0);
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((Window1)target).AddHandler(Keyboard.KeyUpEvent, new KeyEventHandler(this.method_52));
				((Window1)target).Closing += new CancelEventHandler(this.method_56);
				((Window1)target).KeyUp += new KeyEventHandler(this.method_57);
				return;
			case 3:
				this.button_0 = (ActiproSoftware.Windows.Controls.Ribbon.Controls.Button)target;
				this.button_0.Click += new EventHandler<ExecuteRoutedEventArgs>(this.method_43);
				return;
			case 4:
				((ActiproSoftware.Windows.Controls.Ribbon.Controls.Button)target).Click += new EventHandler<ExecuteRoutedEventArgs>(this.method_41);
				return;
			case 5:
				((ActiproSoftware.Windows.Controls.Ribbon.Controls.Button)target).Click += new EventHandler<ExecuteRoutedEventArgs>(this.method_40);
				return;
			case 6:
				((ActiproSoftware.Windows.Controls.Ribbon.Controls.Button)target).Click += new EventHandler<ExecuteRoutedEventArgs>(this.method_42);
				return;
			case 7:
				this.button_1 = (ActiproSoftware.Windows.Controls.Ribbon.Controls.Button)target;
				this.button_1.Click += new EventHandler<ExecuteRoutedEventArgs>(this.method_38);
				return;
			case 8:
				this.button_2 = (ActiproSoftware.Windows.Controls.Ribbon.Controls.Button)target;
				this.button_2.Click += new EventHandler<ExecuteRoutedEventArgs>(this.method_39);
				return;
			case 9:
				((ActiproSoftware.Windows.Controls.Ribbon.Controls.Button)target).Click += new EventHandler<ExecuteRoutedEventArgs>(this.method_53);
				return;
			case 10:
				this.group_0 = (Group)target;
				return;
			case 11:
				((ActiproSoftware.Windows.Controls.Ribbon.Controls.Button)target).Click += new EventHandler<ExecuteRoutedEventArgs>(this.method_50);
				return;
			case 12:
				((System.Windows.Controls.Button)target).Click += new RoutedEventHandler(this.GoProButton_Click);
				return;
			case 13:
				this.textBlock_0 = (TextBlock)target;
				return;
			case 14:
				this.dockSite_0 = (DockSite)target;
				return;
			case 15:
				this.toolWindow_1 = (ToolWindow)target;
				return;
			case 16:
				this.dockPanel_0 = (DockPanel)target;
				return;
			case 17:
				((MenuItem)target).Click += new RoutedEventHandler(this.method_32);
				return;
			case 27:
				this.noScrollTreeView_0 = (NoScrollTreeView)target;
				this.noScrollTreeView_0.AddHandler(Keyboard.KeyUpEvent, new KeyEventHandler(this.method_28));
				return;
			case 28:
				this.dockSite_1 = (DockSite)target;
				this.dockSite_1.WindowContextMenu += new EventHandler<DockingWindowContextMenuEventArgs>(this.method_26);
				this.dockSite_1.WindowActivated += new EventHandler<DockingWindowEventArgs>(this.method_27);
				return;
			case 29:
				this.toolWindowContainer_0 = (ToolWindowContainer)target;
				return;
			case 30:
				this.toolWindow_2 = (ToolWindow)target;
				return;
			case 31:
				this.toolWindow_3 = (ToolWindow)target;
				return;
			case 32:
				((DataGrid)target).AutoGeneratedColumns += new EventHandler(this.method_46);
				((DataGrid)target).AutoGeneratingColumn += new EventHandler<DataGridAutoGeneratingColumnEventArgs>(this.method_54);
				return;
			case 33:
				this.toolWindow_4 = (ToolWindow)target;
				return;
			case 34:
				this.border_0 = (Border)target;
				return;
			case 36:
				this.treeView_0 = (TreeView)target;
				return;
			case 37:
				this.toolWindow_5 = (ToolWindow)target;
				return;
			case 38:
				this.toolWindow_6 = (ToolWindow)target;
				return;
			case 39:
				this.textBox_0 = (System.Windows.Controls.TextBox)target;
				return;
			case 40:
				this.toolWindow_7 = (ToolWindow)target;
				return;
			case 41:
				((System.Windows.Controls.Button)target).Click += new RoutedEventHandler(this.method_48);
				return;
			case 42:
				this.treemapControl_0 = (TreemapControl)target;
				return;
			}
			this.bool_2 = true;
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId != 2)
			{
				switch (connectionId)
				{
				case 18:
					((System.Windows.Controls.StackPanel)target).PreviewMouseLeftButtonDown += new MouseButtonEventHandler(this.method_19);
					((System.Windows.Controls.StackPanel)target).PreviewMouseMove += new MouseEventHandler(this.method_18);
					((System.Windows.Controls.StackPanel)target).DragEnter += new DragEventHandler(this.method_24);
					((System.Windows.Controls.StackPanel)target).DragLeave += new DragEventHandler(this.method_25);
					((System.Windows.Controls.StackPanel)target).Drop += new DragEventHandler(this.method_23);
					break;
				case 19:
					((MenuItem)target).Click += new RoutedEventHandler(this.method_33);
					break;
				case 20:
					((System.Windows.Controls.StackPanel)target).PreviewMouseLeftButtonDown += new MouseButtonEventHandler(this.method_19);
					((System.Windows.Controls.StackPanel)target).PreviewMouseMove += new MouseEventHandler(this.method_18);
					((System.Windows.Controls.StackPanel)target).DragEnter += new DragEventHandler(this.method_24);
					((System.Windows.Controls.StackPanel)target).DragLeave += new DragEventHandler(this.method_25);
					((System.Windows.Controls.StackPanel)target).Drop += new DragEventHandler(this.method_23);
					break;
				case 21:
					((MenuItem)target).Click += new RoutedEventHandler(this.method_30);
					break;
				case 22:
					((MenuItem)target).Click += new RoutedEventHandler(this.method_32);
					break;
				case 23:
					((MenuItem)target).Click += new RoutedEventHandler(this.method_31);
					break;
				case 24:
					((MenuItem)target).Click += new RoutedEventHandler(this.method_34);
					break;
				case 25:
					((MenuItem)target).Click += new RoutedEventHandler(this.method_37);
					break;
				case 26:
					((MenuItem)target).Click += new RoutedEventHandler(this.method_29);
					break;
				case 35:
					((DataGrid)target).AutoGeneratedColumns += new EventHandler(this.method_46);
					break;
				}
			}
			else
			{
				((TextBlock)target).MouseLeftButtonUp += new MouseButtonEventHandler(this.method_58);
			}
		}

		[CompilerGenerated]
		private static int smethod_2(BfType bfType_0)
		{
			int arg_3F_0 = bfType_0.Methods.Count;
			IEnumerable<BfMethod> arg_2E_0 = bfType_0.Methods;
			if (Window1.func_1 == null)
			{
				Window1.func_1 = new Func<BfMethod, int>(Window1.smethod_3);
			}
			return (arg_3F_0 - arg_2E_0.Sum(Window1.func_1) / bfType_0.Fields.Count) * (bfType_0.Methods.Count - 1);
		}

		[CompilerGenerated]
		private static int smethod_3(BfMethod bfMethod_0)
		{
			return bfMethod_0.FieldSets.Count + bfMethod_0.FieldGets.Count;
		}

		[CompilerGenerated]
		private static string smethod_4(AssemblyFileInfo assemblyFileInfo_0)
		{
			return assemblyFileInfo_0.Path;
		}

		[CompilerGenerated]
		private static bool smethod_5(BfMethod bfMethod_0)
		{
			return bfMethod_0.PhysicalLineCount < 0;
		}

		[CompilerGenerated]
		private static string smethod_6(BfMethod bfMethod_0)
		{
			return bfMethod_0.Type.Assembly.Name;
		}

		[CompilerGenerated]
		private void method_60(object sender, RoutedEventArgs e)
		{
			while (this.mainViewModel_0.OpenRules.Count > 0)
			{
				this.mainViewModel_0.OpenRules.RemoveAt(0);
			}
		}

		[CompilerGenerated]
		private static void smethod_7(BfType bfType_0, TreeItem treeItem_0)
		{
		}

		[CompilerGenerated]
		private static void smethod_8(BfType bfType_0, TreeItem treeItem_0)
		{
			foreach (BfMethod current in ((IEnumerable<BfMethod>)bfType_0.Methods))
			{
				TreeItem treeItem_ = new TreeItem
				{
					BaseObject = current
				};
				treeItem_0.method_3(treeItem_);
			}
		}

		[CompilerGenerated]
		private static void smethod_9(BfType bfType_0, TreeItem treeItem_0)
		{
			foreach (BfField current in ((IEnumerable<BfField>)bfType_0.Fields))
			{
				TreeItem treeItem_ = new TreeItem
				{
					BaseObject = current
				};
				treeItem_0.method_3(treeItem_);
			}
		}

		[CompilerGenerated]
		private static void smethod_10(BfType bfType_0, TreeItem treeItem_0)
		{
			foreach (BfEvent current in ((IEnumerable<BfEvent>)bfType_0.Events))
			{
				TreeItem treeItem_ = new TreeItem
				{
					BaseObject = current
				};
				treeItem_0.method_3(treeItem_);
			}
		}

		[CompilerGenerated]
		private static bool smethod_11(BfType bfType_0)
		{
			return true;
		}

		[CompilerGenerated]
		private static bool smethod_12(BfType bfType_0)
		{
			return bfType_0.IsInCoreAssembly;
		}

		[CompilerGenerated]
		private double method_61(object object_0)
		{
			return (object_0 is BfType) ? this.mainViewModel_0.CurrentTreemapMetric.Function(object_0) : 0.0;
		}

		[CompilerGenerated]
		private double method_62(object object_0)
		{
			return (object_0 is BfMethod) ? this.mainViewModel_0.CurrentTreemapMetric.Function(object_0) : 0.0;
		}

		[CompilerGenerated]
		private double method_63(object object_0)
		{
			return (object_0 is BfField) ? this.mainViewModel_0.CurrentTreemapMetric.Function(object_0) : 0.0;
		}

		[CompilerGenerated]
		private double method_64(object object_0)
		{
			return (object_0 is BfEvent) ? this.mainViewModel_0.CurrentTreemapMetric.Function(object_0) : 0.0;
		}
	}
}
