using System;

namespace Nitriq.Analysis.Models
{
	public static class Logger
	{
		public static bool Info;

		public static bool Debug;

		public static bool Warning;

		public static bool Error;

		public static bool Critical;

		public static bool ShowId;

		private static string string_0;

		public static string InfoLogData
		{
			get
			{
				return Logger.string_0;
			}
			private set
			{
				Logger.string_0 = value;
			}
		}

		private static void smethod_0(string string_1, string string_2, LogLevel logLevel_0)
		{
			if (logLevel_0 == LogLevel.Error && Logger.Error)
			{
				Logger.string_0 = Logger.string_0 + string_2 + "\r\n";
			}
		}

		public static void LogInfo(string message)
		{
			Logger.smethod_0("", message, LogLevel.Info);
		}

		public static void LogDebug(string id, string message)
		{
			Logger.smethod_0(id, message, LogLevel.Debug);
		}

		public static void LogWarning(string id, string message)
		{
			Logger.smethod_0(id, message, LogLevel.Warning);
		}

		public static void LogError(string message)
		{
			Logger.smethod_0("", message, LogLevel.Error);
		}

		static Logger()
		{
			Logger.Info = true;
			Logger.Debug = true;
			Logger.Warning = true;
			Logger.Error = true;
			Logger.Critical = true;
			Logger.ShowId = true;
			Logger.string_0 = "";
		}
	}
}
