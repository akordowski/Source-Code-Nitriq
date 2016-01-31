using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Nitriq.Wpf
{
	public class TreemapHost : Image
	{
		private enum Enum2
		{

		}

		private const double double_0 = 30.0;

		private const double double_1 = 180.0;

		private const double double_2 = 0.09759;

		private const double double_3 = 0.19518;

		private const double double_4 = 0.9759;

		private DrawingContext drawingContext_0;

		private TreeItem treeItem_0;

		private Dictionary<object, TreeItem> dictionary_0 = new Dictionary<object, TreeItem>();

		private double double_5;

		private double double_6;

		private static Brush[] brush_0;

		private int int_0 = 0;

		public TreeItem Root
		{
			get
			{
				return this.treeItem_0;
			}
		}

		public double DesiredHeight
		{
			get
			{
				return this.double_5;
			}
			set
			{
				this.double_5 = value;
			}
		}

		public double DesiredWidth
		{
			get
			{
				return this.double_6;
			}
			set
			{
				this.double_6 = value;
			}
		}

		private void method_0(TreeItem treeItem_1)
		{
			foreach (TreeItem current in treeItem_1.method_4())
			{
				this.method_0(current);
			}
			if (treeItem_1.BaseObject != null)
			{
				if (!this.dictionary_0.ContainsKey(treeItem_1.BaseObject))
				{
					this.dictionary_0.Add(treeItem_1.BaseObject, treeItem_1);
				}
				else
				{
					Console.WriteLine(treeItem_1.BaseObject.ToString() + " multiple refs");
				}
			}
		}

		public TreeItem FindTreeItem(object baseObject)
		{
			TreeItem result = null;
			this.dictionary_0.TryGetValue(baseObject, out result);
			return result;
		}

		public void MakeCushionTreeMap(TreeItem root, double width, double height)
		{
			this.DesiredWidth = width;
			this.DesiredHeight = height;
			this.treeItem_0 = root;
			this.dictionary_0.Clear();
			this.method_0(this.treeItem_0);
			root.Bounds = new Rect
			{
				Width = width,
				Height = height
			};
			DrawingVisual drawingVisual = new DrawingVisual();
			this.drawingContext_0 = drawingVisual.RenderOpen();
			this.method_1(root, new TreeSurface(), 0.5);
			this.drawingContext_0.Close();
			this.drawingContext_0 = null;
			Matrix transformToDevice = PresentationSource.FromVisual(Application.Current.MainWindow).CompositionTarget.TransformToDevice;
			double dpiX = transformToDevice.M11 * 96.0;
			double dpiY = transformToDevice.M22 * 96.0;
			RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap(Convert.ToInt32(width), Convert.ToInt32(height), dpiX, dpiY, PixelFormats.Default);
			renderTargetBitmap.Render(drawingVisual);
			base.Source = renderTargetBitmap;
		}

		private void method_1(TreeItem treeItem_1, TreeSurface treeSurface_0, double double_7)
		{
			Rect bounds = treeItem_1.Bounds;
			double num = treeItem_1.Size / bounds.Area();
			double num2 = treeItem_1.Size;
			int i = 0;
			while (i < treeItem_1.method_1())
			{
				TreemapHost.Enum2 @enum = (bounds.Width >= bounds.Height) ? ((TreemapHost.Enum2)0) : ((TreemapHost.Enum2)1);
				double num3 = (@enum == (TreemapHost.Enum2)1) ? bounds.Width : bounds.Height;
				double double_8 = num3 * num3 * num;
				int num4 = i;
				int num5 = i;
				double num6 = 0.0;
				double size = treeItem_1.method_2(num4).Size;
				double num7 = 1.7976931348623157E+308;
				num5 = TreemapHost.smethod_0(treeItem_1, num5, double_8, size, ref num7, ref num6);
				double num8 = (@enum == (TreemapHost.Enum2)1) ? bounds.Height : bounds.Width;
				if (num6 < num2)
				{
					num8 = (double)((int)(num6 / num2 * num8));
				}
				Rect rect = default(Rect);
				double num9 = TreemapHost.smethod_1(bounds, @enum, num8, ref rect);
				this.method_2(treeItem_1, treeSurface_0, double_7, bounds, @enum, num3, num4, num5, num6, ref rect, ref num9);
				TreemapHost.smethod_2(ref bounds, @enum, num8);
				num2 -= num6;
				i += num5 - num4;
				if (bounds.Width <= 0.0 || bounds.Height <= 0.0)
				{
					if (i < treeItem_1.method_1())
					{
						treeItem_1.method_2(i).Bounds = default(Rect);
					}
					return;
				}
			}
		}

		private static int smethod_0(TreeItem treeItem_1, int int_1, double double_7, double double_8, ref double double_9, ref double double_10)
		{
			int result;
			while (int_1 < treeItem_1.method_1())
			{
				double size = treeItem_1.method_2(int_1).Size;
				if (size != 0.0)
				{
					double num = double_10 + size;
					double num2 = num * num;
					double val = double_7 * double_8 / num2;
					double val2 = num2 / double_7 / size;
					double num3 = Math.Max(val, val2);
					if (num3 <= double_9)
					{
						double_10 += size;
						int_1++;
						double_9 = num3;
						continue;
					}
					result = int_1;
				}
				else
				{
					int_1 = treeItem_1.method_1();
					result = int_1;
				}
				return result;
			}
			result = int_1;
			return result;
		}

		private static double smethod_1(Rect rect_0, TreemapHost.Enum2 enum2_0, double double_7, ref Rect rect_1)
		{
			double result;
			if (enum2_0 == (TreemapHost.Enum2)1)
			{
				rect_1.Y = rect_0.Y;
				rect_1.Height = double_7;
				result = rect_0.X;
			}
			else
			{
				rect_1.X = rect_0.X;
				rect_1.Width = double_7;
				result = rect_0.Y;
			}
			return result;
		}

		private static void smethod_2(ref Rect rect_0, TreemapHost.Enum2 enum2_0, double double_7)
		{
			if (enum2_0 == (TreemapHost.Enum2)1)
			{
				rect_0.Y += double_7;
				rect_0.Height -= double_7;
			}
			else
			{
				rect_0.X += double_7;
				rect_0.Width -= double_7;
			}
		}

		private void method_2(TreeItem treeItem_1, TreeSurface treeSurface_0, double double_7, Rect rect_0, TreemapHost.Enum2 enum2_0, double double_8, int int_1, int int_2, double double_9, ref Rect rect_1, ref double double_10)
		{
			for (int i = int_1; i < int_2; i++)
			{
				double num = treeItem_1.method_2(i).Size / double_9;
				double num2 = double_10 + num * double_8;
				bool flag;
				if (flag = (i == int_2 - 1 || treeItem_1.method_2(i + 1).Size == 0.0))
				{
					num2 = ((enum2_0 == (TreemapHost.Enum2)1) ? (rect_0.X + double_8) : (rect_0.Y + double_8));
				}
				if (enum2_0 == (TreemapHost.Enum2)1)
				{
					rect_1.X = double_10;
					rect_1.Width = num2 - double_10;
				}
				else
				{
					rect_1.Y = double_10;
					rect_1.Height = num2 - double_10;
				}
				this.method_3(treeItem_1.method_2(i), ref rect_1, treeSurface_0, double_7 * 0.75);
				if (flag)
				{
					break;
				}
				double_10 = num2;
			}
		}

		private void method_3(TreeItem treeItem_1, ref Rect rect_0, TreeSurface treeSurface_0, double double_7)
		{
			treeItem_1.Bounds = rect_0;
			TreeSurface treeSurface_ = new TreeSurface();
			treeSurface_ = treeSurface_0.Clone();
			this.method_7(rect_0, treeSurface_, double_7);
			if (treeItem_1.method_6())
			{
				this.method_1(treeItem_1, treeSurface_, double_7);
			}
			else
			{
				this.method_8(treeItem_1.Bounds, treeSurface_);
			}
		}

		public double GetShortestSide()
		{
			return (base.Width < base.Height) ? base.Width : base.Height;
		}

		private void method_4(List<TreeItem> items, List<TreeItem> row, double double_7)
		{
			if (items.Count == 0)
			{
				this.method_5(row);
			}
			else
			{
				TreeItem item = items[0];
				List<TreeItem> list = new List<TreeItem>(row);
				list.Add(item);
				List<TreeItem> list2 = new List<TreeItem>(items);
				list2.RemoveAt(0);
				double num = this.method_6(row, double_7);
				double num2 = this.method_6(list, double_7);
				if (row.Count == 0 || num > num2)
				{
					this.method_4(list2, list, double_7);
				}
				else
				{
					this.method_5(row);
					this.method_4(items, new List<TreeItem>(), this.GetShortestSide());
				}
			}
		}

		private void method_5(List<TreeItem> row)
		{
		}

		private double method_6(List<TreeItem> row, double double_7)
		{
			double result;
			if (row.Count == 0)
			{
				result = 0.0;
			}
			else
			{
				double num = 0.0;
				double num2 = 1.7976931348623157E+308;
				double num3 = 0.0;
				foreach (TreeItem current in row)
				{
					num = Math.Max(num, current.RealArea);
					num2 = Math.Min(num2, current.RealArea);
					num3 += current.RealArea;
				}
				if (num2 == 1.7976931348623157E+308)
				{
					num2 = 0.0;
				}
				double val = double_7 * double_7 * num / (num3 * num3);
				double val2 = num3 * num3 / (double_7 * double_7 * num2);
				result = Math.Max(val, val2);
			}
			return result;
		}

		private void method_7(Rect rect_0, TreeSurface treeSurface_0, double double_7)
		{
			if (rect_0.Width > 0.0)
			{
				treeSurface_0.X1 += 4.0 * double_7 * (rect_0.Right + rect_0.Left) / (rect_0.Right - rect_0.Left);
				treeSurface_0.X2 -= 4.0 * double_7 / (rect_0.Right - rect_0.Left);
			}
			if (rect_0.Height > 0.0)
			{
				treeSurface_0.Y1 += 4.0 * double_7 * (rect_0.Bottom + rect_0.Top) / (rect_0.Bottom - rect_0.Top);
				treeSurface_0.Y2 -= 4.0 * double_7 / (rect_0.Bottom - rect_0.Top);
			}
		}

		public TreeItem FindItemByPoint(Point point)
		{
			TreeItem result;
			if (this.treeItem_0 == null)
			{
				result = null;
			}
			else
			{
				result = this.FindItemByPoint(this.treeItem_0, point);
			}
			return result;
		}

		public TreeItem FindItemByPoint(TreeItem item, Point point)
		{
			TreeItem result;
			if (!item.Bounds.Contains(point))
			{
				result = null;
			}
			else
			{
				TreeItem treeItem = null;
				if (item.method_5())
				{
					treeItem = item;
				}
				else
				{
					for (int i = 0; i < item.method_1(); i++)
					{
						TreeItem treeItem2 = item.method_2(i);
						if (treeItem2.Bounds.Contains(point))
						{
							treeItem = this.FindItemByPoint(treeItem2, point);
							break;
						}
					}
				}
				if (treeItem == null)
				{
					treeItem = item;
				}
				result = treeItem;
			}
			return result;
		}

		static TreemapHost()
		{
			TreemapHost.brush_0 = new Brush[256];
			for (int i = 0; i < 256; i++)
			{
				byte b = (byte)i;
				TreemapHost.brush_0[i] = new SolidColorBrush(Color.FromArgb(255, b, b, b));
				TreemapHost.brush_0[i].Freeze();
			}
		}

		private void method_8(Rect rect_0, TreeSurface treeSurface_0)
		{
			int num = (int)Math.Round(rect_0.X);
			int num2 = (int)Math.Round(rect_0.Right);
			int num3 = (int)Math.Round(rect_0.Y);
			int num4 = (int)Math.Round(rect_0.Bottom);
			for (int i = num; i < num2; i++)
			{
				for (int j = num3; j < num4; j++)
				{
					double num5 = -(2.0 * treeSurface_0.X2 * ((double)i + 0.5) + treeSurface_0.X1);
					double num6 = -(2.0 * treeSurface_0.Y2 * ((double)j + 0.5) + treeSurface_0.Y1);
					double num7 = (num5 * 0.09759 + num6 * 0.19518 + 0.9759) / Math.Sqrt(num5 * num5 + num6 * num6 + 1.0);
					if (num7 > 1.0)
					{
						num7 = 1.0;
					}
					this.method_9((double)i, (double)j, 30.0 + Math.Max(0.0, 180.0 * num7));
				}
			}
		}

		private void method_9(double double_7, double double_8, double double_9)
		{
			int num = (int)double_9;
			this.drawingContext_0.DrawRectangle(TreemapHost.brush_0[num], null, new Rect
			{
				X = double_7,
				Y = double_8,
				Width = 1.0,
				Height = 1.0
			});
			this.int_0++;
		}
	}
}
