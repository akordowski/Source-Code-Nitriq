using System;
using System.Diagnostics;

namespace Nitriq.Analysis.Models
{
	public class StopwatchWriter : IDisposable
	{
		private Stopwatch stopwatch_0 = new Stopwatch();

		private string string_0;

		public StopwatchWriter(string text)
		{
			this.string_0 = text + " - ";
			this.stopwatch_0.Start();
		}

		public void Dispose()
		{
			this.stopwatch_0.Stop();
			Console.WriteLine("stopw: " + this.string_0 + this.stopwatch_0.ElapsedMilliseconds);
		}
	}
}
