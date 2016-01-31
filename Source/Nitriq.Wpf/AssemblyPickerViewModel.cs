using Nitriq.Analysis.Models;
using System;
using System.Collections.ObjectModel;

namespace Nitriq.Wpf
{
	public class AssemblyPickerViewModel
	{
		private ObservableCollection<AssemblyFileInfo> observableCollection_0 = new ObservableCollection<AssemblyFileInfo>();

		public ObservableCollection<AssemblyFileInfo> Assemblies
		{
			get
			{
				return this.observableCollection_0;
			}
		}
	}
}
