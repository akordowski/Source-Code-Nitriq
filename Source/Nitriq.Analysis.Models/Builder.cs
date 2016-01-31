using System;
using System.Text;

namespace Nitriq.Analysis.Models
{
	public class Builder
	{
		private string string_0;

		private StringBuilder stringBuilder_0 = new StringBuilder();

		private bool bool_0 = true;

		public Builder() : this(", ")
		{
		}

		public Builder(string delimiter)
		{
			this.string_0 = delimiter;
		}

		public void Clear()
		{
			this.stringBuilder_0.Remove(0, this.stringBuilder_0.Length);
			this.bool_0 = true;
		}

		public void Append(object obj)
		{
			this.Append(obj.ToString());
		}

		public void Append(string text)
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
			}
			else
			{
				this.stringBuilder_0.Append(this.string_0);
			}
			this.stringBuilder_0.Append(text.ToString());
		}

		public override string ToString()
		{
			return this.stringBuilder_0.ToString();
		}
	}
}
