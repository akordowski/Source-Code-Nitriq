using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Nitriq.Wpf
{
	public class StatusIconProvider
	{
		private ImageSource imageSource_0;

		private ImageSource imageSource_1;

		private ImageSource imageSource_2;

		private ImageSource imageSource_3;

		public ImageSource Good
		{
			get
			{
				return this.imageSource_0;
			}
			set
			{
				this.imageSource_0 = value;
			}
		}

		public ImageSource Warning
		{
			get
			{
				return this.imageSource_1;
			}
			set
			{
				this.imageSource_1 = value;
			}
		}

		public ImageSource Error
		{
			get
			{
				return this.imageSource_2;
			}
			set
			{
				this.imageSource_2 = value;
			}
		}

		public ImageSource Reload
		{
			get
			{
				return this.imageSource_3;
			}
			set
			{
				this.imageSource_3 = value;
			}
		}

		public StatusIconProvider()
		{
			try
			{
				this.imageSource_0 = this.method_0("button_ok.png");
				this.imageSource_1 = this.method_0("messagebox_warning.png");
				this.imageSource_2 = this.method_0("messagebox_critical.png");
				this.imageSource_3 = this.method_0("reload.png");
			}
			catch (Exception)
			{
			}
		}

		private ImageSource method_0(string string_0)
		{
			ImageSource result;
			if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CrystalIcons\\16x16\\" + string_0))
			{
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.UriSource = new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\CrystalIcons\\16x16\\" + string_0, UriKind.Absolute);
				bitmapImage.EndInit();
				result = bitmapImage;
			}
			else
			{
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.StreamSource = Application.GetResourceStream(new Uri("CrystalIcons/16x16/" + string_0, UriKind.RelativeOrAbsolute)).Stream;
				bitmapImage.EndInit();
				result = bitmapImage;
			}
			return result;
		}
	}
}
