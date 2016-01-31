using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Nitriq.Wpf
{
	public static class ExtensionMethods
	{
		public static SolidColorBrush ChangeAlpha(this SolidColorBrush brush, byte alpha)
		{
			Color color = brush.Color;
			brush.Color = Color.FromArgb(alpha, color.R, color.G, color.B);
			return brush;
		}

		public static double TotalVert(this Thickness thickness)
		{
			return thickness.Top + thickness.Bottom;
		}

		public static double TotalHor(this Thickness thickness)
		{
			return thickness.Left + thickness.Right;
		}

		public static void RemoveWhere<T>(this ICollection<T> collection, Func<T, bool> removalPredicate)
		{
			T[] array = collection.Where(removalPredicate).ToArray<T>();
			T[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				T item = array2[i];
				collection.Remove(item);
			}
		}
	}
}
