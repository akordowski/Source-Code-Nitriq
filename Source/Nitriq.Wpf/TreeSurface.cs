using System;
using System.Diagnostics;

namespace Nitriq.Wpf
{
	[DebuggerDisplay("TreeSurface: ({X1}, {Y1}) - ({X2}, {Y2})")]
	public class TreeSurface
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double double_0;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double double_1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double double_2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double double_3;

		public double X1
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

		public double X2
		{
			get
			{
				return this.double_1;
			}
			set
			{
				this.double_1 = value;
			}
		}

		public double Y1
		{
			get
			{
				return this.double_2;
			}
			set
			{
				this.double_2 = value;
			}
		}

		public double Y2
		{
			get
			{
				return this.double_3;
			}
			set
			{
				this.double_3 = value;
			}
		}

		public double this[Dir dir, int degree]
		{
			get
			{
				double result;
				if (dir == Dir.X)
				{
					if (degree == 1)
					{
						result = this.double_0;
					}
					else
					{
						result = this.double_1;
					}
				}
				else if (degree == 1)
				{
					result = this.double_2;
				}
				else
				{
					result = this.double_3;
				}
				return result;
			}
			set
			{
				if (dir == Dir.X)
				{
					if (degree == 1)
					{
						this.double_0 = value;
					}
					else
					{
						this.double_1 = value;
					}
				}
				else if (degree == 1)
				{
					this.double_2 = value;
				}
				else
				{
					this.double_3 = value;
				}
			}
		}

		public TreeSurface Clone()
		{
			return new TreeSurface
			{
				X1 = this.X1,
				X2 = this.X2,
				Y1 = this.Y1,
				Y2 = this.Y2
			};
		}
	}
}
