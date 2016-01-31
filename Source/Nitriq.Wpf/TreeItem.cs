using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Nitriq.Wpf
{
	[DebuggerDisplay("TreeItem: {Size} - Children: {Children.Count}"), DefaultMember("Item")]
	public class TreeItem
	{
		private TreeItem treeItem_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private List<TreeItem> list_0 = new List<TreeItem>();

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Rect rect_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double double_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object object_0;

		[CompilerGenerated]
		private static Comparison<TreeItem> comparison_0;

		public double RealArea
		{
			get
			{
				return this.rect_0.Width * this.rect_0.Height;
			}
		}

		public Rect Bounds
		{
			get
			{
				return this.rect_0;
			}
			set
			{
				this.rect_0 = value;
			}
		}

		public double Size
		{
			get
			{
				return this.double_0;
			}
			set
			{
				this.double_0 = value;
			}
		}

		public object BaseObject
		{
			get
			{
				return this.object_0;
			}
			set
			{
				this.object_0 = value;
			}
		}

		internal TreeItem method_0()
		{
			return this.treeItem_0;
		}

		internal int method_1()
		{
			return this.list_0.Count;
		}

		internal TreeItem method_2(int index)
		{
			return this.list_0[index];
		}

		internal void method_3(TreeItem treeItem_1)
		{
			this.list_0.Add(treeItem_1);
			treeItem_1.treeItem_0 = this;
		}

		internal IEnumerable<TreeItem> method_4()
		{
			return this.list_0;
		}

		internal bool method_5()
		{
			return this.list_0.Count == 0;
		}

		internal bool method_6()
		{
			return this.list_0.Count > 0;
		}

		public double CalculateSize(Func<object, double> leafSizeFunction)
		{
			if (this.list_0.Count == 0)
			{
				this.double_0 = leafSizeFunction(this.object_0);
			}
			else
			{
				double num = 0.0;
				foreach (TreeItem current in this.list_0)
				{
					num += current.CalculateSize(leafSizeFunction);
				}
				List<TreeItem> arg_8E_0 = this.list_0;
				if (TreeItem.comparison_0 == null)
				{
					TreeItem.comparison_0 = new Comparison<TreeItem>(TreeItem.smethod_0);
				}
				arg_8E_0.Sort(TreeItem.comparison_0);
				this.double_0 = num;
			}
			return this.double_0;
		}

		[CompilerGenerated]
		private static int smethod_0(TreeItem treeItem_1, TreeItem treeItem_2)
		{
			return treeItem_2.Size.CompareTo(treeItem_1.Size);
		}
	}
}
