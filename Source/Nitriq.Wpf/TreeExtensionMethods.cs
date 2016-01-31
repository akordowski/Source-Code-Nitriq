using System;
using System.Windows;

namespace Nitriq.Wpf
{
	public static class TreeExtensionMethods
	{
		public static double Area(this Rect rect)
		{
			return rect.Width * rect.Height;
		}
	}
}
