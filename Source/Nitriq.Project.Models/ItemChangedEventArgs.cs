using System;

namespace Nitriq.Project.Models
{
	public class ItemChangedEventArgs<T> : EventArgs
	{
		private T gparam_0;

		private string string_0;

		public T Item
		{
			get
			{
				return this.gparam_0;
			}
			set
			{
				this.gparam_0 = value;
			}
		}

		public string PropertyName
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}
	}
}
