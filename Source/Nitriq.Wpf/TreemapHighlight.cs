using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Nitriq.Wpf
{
	public class TreemapHighlight : Image
	{
		private DrawingContext drawingContext_0;

		private TreemapHost treemapHost_0;

		private Brush brush_0 = new SolidColorBrush(Color.FromArgb(128, 0, 0, 255));

		public TreemapHost TreemapHost
		{
			get
			{
				return this.treemapHost_0;
			}
			set
			{
				this.treemapHost_0 = value;
			}
		}

		public Brush Brush
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

		public void HighlightItems(IEnumerable<object> baseObjects)
		{
			DrawingVisual drawingVisual = new DrawingVisual();
			this.drawingContext_0 = drawingVisual.RenderOpen();
			foreach (object current in baseObjects)
			{
				TreeItem treeItem = this.TreemapHost.FindTreeItem(current);
				if (treeItem != null)
				{
					this.drawingContext_0.DrawRectangle(this.brush_0, null, new Rect
					{
						X = treeItem.Bounds.X,
						Y = treeItem.Bounds.Y,
						Width = treeItem.Bounds.Width,
						Height = treeItem.Bounds.Height
					});
				}
			}
			this.drawingContext_0.Close();
			this.drawingContext_0 = null;
			Matrix transformToDevice = PresentationSource.FromVisual(Application.Current.MainWindow).CompositionTarget.TransformToDevice;
			double dpiX = transformToDevice.M11 * 96.0;
			double dpiY = transformToDevice.M22 * 96.0;
			if (this.TreemapHost.DesiredWidth == 0.0 || this.TreemapHost.DesiredHeight == 0.0)
			{
				base.Source = null;
			}
			else
			{
				RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap(Convert.ToInt32(this.TreemapHost.DesiredWidth), Convert.ToInt32(this.TreemapHost.DesiredHeight), dpiX, dpiY, PixelFormats.Default);
				renderTargetBitmap.Render(drawingVisual);
				base.Source = renderTargetBitmap;
			}
		}

		public void ClearHighlighting()
		{
			base.Source = null;
		}
	}
}
