using Microsoft.Win32;
using Nitriq.Analysis.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Nitriq.Wpf
{
	public class AssemblyPicker : Window, IComponentConnector
	{
		private AssemblyPickerViewModel assemblyPickerViewModel_0;

		private System.Threading.Timer timer_0;

		private bool bool_0;

		[CompilerGenerated]
		private static Func<AssemblyFileInfo, bool> func_0;

		[CompilerGenerated]
		private static Func<AssemblyFileInfo, bool> func_1;

		public ObservableCollection<AssemblyFileInfo> Assemblies
		{
			get
			{
				return this.assemblyPickerViewModel_0.Assemblies;
			}
		}

		public AssemblyPicker()
		{
			this.InitializeComponent();
			this.assemblyPickerViewModel_0 = new AssemblyPickerViewModel();
			base.DataContext = this.assemblyPickerViewModel_0;
			base.Loaded += new RoutedEventHandler(this.AssemblyPicker_Loaded);
		}

		public AssemblyPicker(List<string> files) : this()
		{
			this.method_2(files);
		}

		private void AssemblyPicker_Loaded(object sender, RoutedEventArgs e)
		{
			if (this.assemblyPickerViewModel_0.Assemblies.Count == 0)
			{
				this.timer_0 = new System.Threading.Timer(new TimerCallback(this.method_0), null, 1, -1);
			}
		}

		private void method_0(object object_0)
		{
			this.method_1();
		}

		private void method_1()
		{
			Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
			openFileDialog.Title = "Pick One or More .Net Assemblies or Executables";
			openFileDialog.Filter = ".Net Assembly or Executable (*.dll,*.exe)|*.dll;*.exe";
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Multiselect = true;
			IEnumerable<AssemblyFileInfo> arg_52_0 = this.assemblyPickerViewModel_0.Assemblies;
			if (AssemblyPicker.func_0 == null)
			{
				AssemblyPicker.func_0 = new Func<AssemblyFileInfo, bool>(AssemblyPicker.smethod_0);
			}
			IEnumerable<AssemblyFileInfo> enumerable = arg_52_0.Where(AssemblyPicker.func_0);
			if (enumerable.Count() > 0)
			{
				openFileDialog.InitialDirectory = Path.GetDirectoryName(enumerable.Last<AssemblyFileInfo>().Path);
			}
			if (openFileDialog.ShowDialog() == true)
			{
				this.method_2(openFileDialog.FileNames);
			}
		}

		private void method_2(IEnumerable<string> files)
		{
			foreach (string current in files)
			{
				if (!(current.Trim() == ""))
				{
					try
					{
						string a = Path.GetExtension(current).ToLower();
						AssemblyFileInfo fileInfo;
						if (a == ".exe" || a == ".dll")
						{
							fileInfo = new AssemblyFileInfo
							{
								Path = current,
								Name = Path.GetFileNameWithoutExtension(current),
								Version = FileVersionInfo.GetVersionInfo(current).FileVersion
							};
						}
						else
						{
							fileInfo = new AssemblyFileInfo
							{
								Path = current,
								Name = "Search Directory",
								Version = "N/A"
							};
						}
						base.Dispatcher.Invoke(new Action(delegate
						{
							this.assemblyPickerViewModel_0.Assemblies.Add(fileInfo);
						}), new object[0]);
					}
					catch (Exception)
					{
						System.Windows.MessageBox.Show("Problem loading file: " + current);
					}
				}
			}
		}

		private void method_3(object sender, RoutedEventArgs e)
		{
			bool arg_3D_0;
			if (Class13.smethod_0())
			{
				IEnumerable<AssemblyFileInfo> arg_2F_0 = this.assemblyPickerViewModel_0.Assemblies;
				if (AssemblyPicker.func_1 == null)
				{
					AssemblyPicker.func_1 = new Func<AssemblyFileInfo, bool>(AssemblyPicker.smethod_1);
				}
				arg_3D_0 = (arg_2F_0.Count(AssemblyPicker.func_1) <= 1);
			}
			else
			{
				arg_3D_0 = true;
			}
			if (!arg_3D_0)
			{
				System.Windows.MessageBox.Show("Nitriq Free Edition only allows you to analyze a single assembly, please remove all but one assembly. Nitriq Pro has no restrictions and can be purchased at www.nitriq.com", "Feature Not Available", MessageBoxButton.OK, MessageBoxImage.Asterisk);
			}
			else
			{
				base.DialogResult = new bool?(true);
			}
		}

		private void method_4(object sender, RoutedEventArgs e)
		{
			this.method_1();
		}

		private void method_5(object sender, RoutedEventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = false;
			folderBrowserDialog.Description = "Pick Search Directory\r\nThe Silverlight Install Location is typically:\r\n[Program Files]\\Microsoft Silverlight\\[version]";
			folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
			folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
			if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				this.method_2(new List<string>
				{
					folderBrowserDialog.SelectedPath
				});
			}
		}

		[DebuggerNonUserCode]
		public void InitializeComponent()
		{
			if (!this.bool_0)
			{
				this.bool_0 = true;
				Uri resourceLocator = new Uri("/Nitriq.Wpf;component/assemblypicker.xaml", UriKind.Relative);
				System.Windows.Application.LoadComponent(this, resourceLocator);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), DebuggerNonUserCode]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				((System.Windows.Controls.Button)target).Click += new RoutedEventHandler(this.method_4);
				break;
			case 2:
				((System.Windows.Controls.Button)target).Click += new RoutedEventHandler(this.method_5);
				break;
			case 3:
				((System.Windows.Controls.Button)target).Click += new RoutedEventHandler(this.method_3);
				break;
			default:
				this.bool_0 = true;
				break;
			}
		}

		[CompilerGenerated]
		private static bool smethod_0(AssemblyFileInfo assemblyFileInfo_0)
		{
			return assemblyFileInfo_0.Name != "Search Directory";
		}

		[CompilerGenerated]
		private static bool smethod_1(AssemblyFileInfo assemblyFileInfo_0)
		{
			return assemblyFileInfo_0.Name != "Search Directory" && assemblyFileInfo_0.Version != "N/A";
		}
	}
}
