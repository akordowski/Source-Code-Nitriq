using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Nitriq.Wpf
{
	public class RibbonIconProvider
	{
		private ImageSource imageSource_0;

		private ImageSource imageSource_1;

		private ImageSource imageSource_2;

		private ImageSource imageSource_3;

		private ImageSource imageSource_4;

		private ImageSource imageSource_5;

		private ImageSource imageSource_6;

		public ImageSource New
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

		public ImageSource Save
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

		public ImageSource Open
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

		public ImageSource Execute
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

		public ImageSource Import
		{
			get
			{
				return this.imageSource_4;
			}
			set
			{
				this.imageSource_4 = value;
			}
		}

		public ImageSource Export
		{
			get
			{
				return this.imageSource_5;
			}
			set
			{
				this.imageSource_5 = value;
			}
		}

		public ImageSource Reanalyze
		{
			get
			{
				return this.imageSource_6;
			}
			set
			{
				this.imageSource_6 = value;
			}
		}

		public RibbonIconProvider()
		{
			try
			{
				this.imageSource_0 = this.method_0("filenew.png");
				this.imageSource_1 = this.method_0("filesave.png");
				this.imageSource_2 = this.method_0("fileopen.png");
				this.imageSource_3 = this.method_0("1rightarrow.png");
				this.imageSource_4 = this.method_0("fileimport.png");
				this.imageSource_5 = this.method_0("fileexport.png");
				this.imageSource_6 = this.method_0("exec.png");
			}
			catch (Exception)
			{
			}
		}

		private ImageSource method_0(string string_0)
		{
			ImageSource result;
			if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\CrystalIcons\\32x32\\" + string_0))
			{
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.UriSource = new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\CrystalIcons\\32x32\\" + string_0, UriKind.Absolute);
				bitmapImage.EndInit();
				result = bitmapImage;
			}
			else
			{
				BitmapImage bitmapImage = new BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.StreamSource = Application.GetResourceStream(new Uri("CrystalIcons/32x32/" + string_0, UriKind.RelativeOrAbsolute)).Stream;
				bitmapImage.EndInit();
				result = bitmapImage;
			}
			return result;
		}
	}
}
