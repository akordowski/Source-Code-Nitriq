using System;
using System.Text.RegularExpressions;

namespace Nitriq.Analysis.Models
{
	public static class ExtensionMethods
	{
		private static RegexOptions regexOptions_0;

		private static RegexOptions regexOptions_1;

		public static bool Like(this string searchString, string regexPattern, bool ignoreCase)
		{
			bool result;
			if (ignoreCase)
			{
				result = Regex.IsMatch(searchString, regexPattern, ExtensionMethods.regexOptions_0);
			}
			else
			{
				result = Regex.IsMatch(searchString, regexPattern, ExtensionMethods.regexOptions_1);
			}
			return result;
		}

		public static bool Like(this string searchString, string regexPattern)
		{
			return searchString.Like(regexPattern, true);
		}

		public static double Round(this double number, int digits)
		{
			return Math.Round(number, digits);
		}

		static ExtensionMethods()
		{
			ExtensionMethods.regexOptions_0 = (RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
			ExtensionMethods.regexOptions_1 = RegexOptions.IgnorePatternWhitespace;
		}
	}
}
