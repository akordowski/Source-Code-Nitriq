using Nitriq.Analysis.Models;
using Nitriq.Project.Models;
using Nitriq.Wpf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace Nitriq.Console
{
	[LicenseProvider(typeof(Class1))]
	internal class ConsoleMain
	{
		[CompilerGenerated]
		private static Func<string, bool> func_0;

		[CompilerGenerated]
		private static Func<string, bool> func_1;

		[CompilerGenerated]
		private static Func<string, bool> func_2;

		[CompilerGenerated]
		private static Func<string, bool> func_3;

		[CompilerGenerated]
		private static Func<AssemblyFileInfo, string> func_4;

		private static int Main(string[] args)
		{
			LicenseManager.Validate(typeof(ConsoleMain));
			int result;
			try
			{
				if (ConsoleMain.func_0 == null)
				{
					ConsoleMain.func_0 = new Func<string, bool>(ConsoleMain.smethod_4);
				}
				IEnumerable<string> source = args.Where(ConsoleMain.func_0);
				if (source.Count<string>() == 0)
				{
					Console.WriteLine("Error: No Nitriq Project File (*.nitriqProj) was supplied as an argument");
					result = 1;
				}
				else if (source.Count<string>() > 1)
				{
					Console.WriteLine("Error: More than one Nitriq Project File (*.nitriqProj) was supplied as an argument");
					result = 1;
				}
				else
				{
					string text = source.First<string>();
					if (!System.IO.File.Exists(text))
					{
						Console.WriteLine("Error: Nitriq Project File (*.nitriqProj) does not exist: " + text);
						result = 1;
					}
					else
					{
						if (ConsoleMain.func_1 == null)
						{
							ConsoleMain.func_1 = new Func<string, bool>(ConsoleMain.smethod_5);
						}
						IEnumerable<string> source2 = args.Where(ConsoleMain.func_1);
						if (source2.Count<string>() == 0)
						{
							Console.WriteLine("Error: No Nitriq Query File (*.nq) was supplied as an argument");
							result = 1;
						}
						else if (source2.Count<string>() > 1)
						{
							Console.WriteLine("Error: More than one Nitriq Queries File (*.nq) was supplied as an argument");
							result = 1;
						}
						else
						{
							string text2 = source2.First<string>();
							if (!System.IO.File.Exists(text2))
							{
								Console.WriteLine("Error: Nitriq Queries File (*.nq) does not exist: " + text2);
								result = 1;
							}
							else
							{
								if (ConsoleMain.func_2 == null)
								{
									ConsoleMain.func_2 = new Func<string, bool>(ConsoleMain.smethod_6);
								}
								IEnumerable<string> source3 = args.Where(ConsoleMain.func_2);
								if (source3.Count<string>() == 0)
								{
									Console.WriteLine("Error: No Output File (*.html) was supplied as an argument");
									result = 1;
								}
								else if (source3.Count<string>() > 1)
								{
									Console.WriteLine("Error: More than one Output File (*.html) was supplied as an argument");
									result = 1;
								}
								else
								{
									string path = source3.First<string>();
									if (ConsoleMain.func_3 == null)
									{
										ConsoleMain.func_3 = new Func<string, bool>(ConsoleMain.smethod_7);
									}
									bool flag = args.Where(ConsoleMain.func_3).Any<string>();
									StringBuilder stringBuilder = new StringBuilder();
									StringBuilder stringBuilder2 = new StringBuilder("<ul id=\"toc\">\r\n");
									MainViewModelBase mainViewModelBase = new MainViewModelBase();
									mainViewModelBase.method_0(text2);
									IEnumerable<AssemblyFileInfo> enumerable = ConsoleMain.smethod_1(text);
									MainViewModelBase arg_211_0 = mainViewModelBase;
									IEnumerable<AssemblyFileInfo> arg_207_0 = enumerable;
									if (ConsoleMain.func_4 == null)
									{
										ConsoleMain.func_4 = new Func<AssemblyFileInfo, string>(ConsoleMain.smethod_8);
									}
									arg_211_0.Files = new List<string>(arg_207_0.Select(ConsoleMain.func_4));
									mainViewModelBase.method_10(new List<AssemblyFileInfo>(enumerable));
									Dictionary<string, AssemblyTuple> nameToAssemblyTuple = BfCache.smethod_1(enumerable);
									mainViewModelBase.method_6(new BfCache(nameToAssemblyTuple));
									int num = 0;
									int num2 = 0;
									foreach (Rule current in mainViewModelBase.RuleSet.RulesEnumerator())
									{
										if (current.Active)
										{
											mainViewModelBase.method_14(current, true);
											if (current.QueryResults.Problems.Count > 0)
											{
												stringBuilder.AppendLine(string.Concat(new string[]
												{
													"<h2><a name=\"",
													current.Name,
													"\" />The Query \"",
													current.Name,
													"\" has the following problems: </h2>"
												}));
											}
											else
											{
												stringBuilder.AppendLine(string.Concat(new string[]
												{
													"<h2><a name=\"",
													current.Name,
													"\" />The Query \"",
													current.Name,
													"\" returned the following results: </h2>"
												}));
											}
											RuleStatus ruleStatus = RuleStatus.Good;
											foreach (Problem current2 in current.QueryResults.Problems)
											{
												if (current2.ProblemType == RuleStatus.Warning)
												{
													num++;
													stringBuilder.AppendLine("<h3>Warning: " + ConsoleMain.smethod_0(current2.Description) + "</h3>");
													if (ruleStatus == RuleStatus.Good)
													{
														ruleStatus = RuleStatus.Warning;
													}
												}
												else if (current2.ProblemType == RuleStatus.Error)
												{
													num2++;
													stringBuilder.AppendLine("<h3>Error: " + ConsoleMain.smethod_0(current2.Description) + "</h3>");
													if (ruleStatus == RuleStatus.Good || ruleStatus == RuleStatus.Warning)
													{
														ruleStatus = RuleStatus.Error;
													}
												}
												else if (current2.ProblemType == RuleStatus.CompileError)
												{
													num2++;
													stringBuilder.AppendLine("<h3>Compile Error:</h3>");
													stringBuilder.AppendLine(ConsoleMain.smethod_0(current2.Description));
													if (ruleStatus == RuleStatus.Good || ruleStatus == RuleStatus.Warning)
													{
														ruleStatus = RuleStatus.Error;
													}
												}
												else if (current2.ProblemType == RuleStatus.RuntimeError)
												{
													num2++;
													stringBuilder.AppendLine("<h3>Runtime Error:</h3>");
													stringBuilder.AppendLine(ConsoleMain.smethod_0(current2.Description));
													if (ruleStatus == RuleStatus.Good || ruleStatus == RuleStatus.Warning)
													{
														ruleStatus = RuleStatus.Error;
													}
												}
											}
											if (ruleStatus == RuleStatus.Good)
											{
												stringBuilder2.AppendLine(string.Concat(new string[]
												{
													"<li><a href=\"#",
													current.Name,
													"\" ><div class=\"good\"  >",
													current.Name,
													"</div></a></li>"
												}));
											}
											else if (ruleStatus == RuleStatus.Warning)
											{
												stringBuilder2.AppendLine(string.Concat(new string[]
												{
													"<li><a href=\"#",
													current.Name,
													"\" ><div class=\"warning\" >",
													current.Name,
													"</div></a></li>"
												}));
											}
											else if (ruleStatus == RuleStatus.Error)
											{
												stringBuilder2.AppendLine(string.Concat(new string[]
												{
													"<li><a href=\"#",
													current.Name,
													"\" ><div class=\"error\" >",
													current.Name,
													"</div></a></li>"
												}));
											}
											string value = ConsoleMain.smethod_2(current.QueryResults.Results);
											stringBuilder.AppendLine(value);
											stringBuilder.AppendLine("<br />");
											stringBuilder.AppendLine("<br />");
										}
									}
									stringBuilder2.AppendLine("</ul>");
									using (StreamWriter streamWriter = new StreamWriter(path))
									{
										streamWriter.WriteLine("<html>");
										streamWriter.WriteLine("<head><title>Nitriq Query Results</title>");
										streamWriter.Write("\r\n<style type=\"text/css\">\r\nbody\r\n{\r\n\tcursor: default;\r\n\tfont: 0.8em 'Trebuchet MS' , 'Lucida Sans Unicode' , 'Lucida Grande' , 'Lucida' , Arial, Verdana, sans-serif;\r\n\tpadding: 0;\r\n\tmargin: 0;\r\n}\r\n#header {\r\n\tbackground: #d43c11 url(data:image/png;base64,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%3D%3D) no-repeat scroll left top;\r\n\tpadding: 1px 12px;\r\n}\r\n#page {\r\n\tmargin: 1em;\r\n}\r\ntable\r\n{\r\n    border-collapse: collapse;\r\n    border-spacing: 2px;\r\n    display: table;\r\n    margin-bottom: 20px;\r\n    margin-top: 0;\r\n    border-color: rgb(204, 204, 204);\r\n    font-size: 1.0em;\r\n}\r\nthead {\r\n\tbackground: black;\r\n\tcolor: white;\r\n\tpadding: 6px;\r\n}\r\nh1\r\n{\r\n\tfont-family: \"Century Gothic\",\"Apple Gothic\",\"Lucida Grande\",Helvetica,Arial,Verdana,sans-serif; \r\n\tcolor: #481f00;\r\n\ttext-shadow: 0px 1px 0px #eea706;}\r\nh2\r\n{\r\n\tfont-family: \"Century Gothic\",\"Apple Gothic\",\"Lucida Grande\",Helvetica,Arial,Verdana,sans-serif; \r\n\tfont-size: 1.8em;\r\n\tcolor: Black;\r\n\tmargin-bottom: 5px;\r\n\tpadding: 0;\r\n}\r\n\r\nh3\r\n{\r\n\tfont-family: \"Century Gothic\",\"Apple Gothic\",\"Lucida Grande\",Helvetica,Arial,Verdana,sans-serif; \r\n\tfont-size: 1.3em;\r\n\tcolor: Red;\r\n\tmargin-bottom: 10px;\r\n}\r\n\r\ntd\r\n{\r\n\tvertical-align:top;\t\r\n    padding: 2px 6px;\r\n}\r\nthead td {\r\n\tpadding: 4px 6px;\r\n}\r\n\r\ntd.numeric\r\n{\r\n\ttext-align: right;\r\n}\r\n#toc {\r\n\tlist-style: none;\r\n\tmargin: 0;\r\n\tpadding: 0;\r\n    width: 450px;\r\n}\r\n/*\r\n#toc a {\r\n\tmargin-left: 20px;\r\n\tpadding-left: 20px;\r\n    font-size: 1.0em;\r\n    vertical-align:middle;\r\n}\r\n\r\n\r\n#toc a {\r\n\tmargin-left: 20px;\r\n\tpadding-left: 20px;\r\n\tbackground: transparent url('good.png') no-repeat scroll left 5px;\r\n}\r\n\r\n#toc a.warning {\r\n\tbackground: transparent url('warning.png') no-repeat scroll left 5px;\r\n\r\n#toc a.problem {\r\n\tbackground: transparent url('error.png') no-repeat scroll left 5px;\r\n*/\r\n\r\ndiv.good\r\n{\r\n\tmargin-left: 20px;\r\n\tpadding-bottom: 4px;\r\n\tpadding-top: 3px;\r\n\tpadding-left: 20px;\r\n\tbackground: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAACK0lEQVQ4jaWSXUhTYRjH/+/O3uPOOfs4W2oRRGI0jPYRStaIjMS6SyQoC+kD0rqJwAjqqo+bbpLoQorIhjaShIqRLUtzdaHDDywpmzZ0NIS0rDV1tg87e7uQRMps1R+em+fh91z8+RHGGP4nqr8FhFqi/ucHopNI8qip23RQbplfMsbSGuEGpOVn5P72wVZ2wLmXqXbhIWMMJJ0OhGtEMoRk363DjbaGrjqMJcchJw1wP3jcPP8gq5FfBkZyJyoSvQthfT2RMob0PldVo83lv4nWTx5wMYpZLw0mZqIFKgDQ1JJM80d7YEPY0SHVk+0/4JX3Ja32ndHnOn7b1jTegF7aAS3VIeyJDUenI5Zoy2xEnX1RzC4WS/zVpdWmqBLFpCfiWXFXs1MStT10SNdZc+SyrfnzPQzS1xATOvibQiMklbImnrA4AHCKTK4XlTgKPwjviSwaUZCXT/u8A+UI0apzlWfNL+M9CHBvoEwR9DsDQS5LscbvzMEA5koUyjRP83av2movtPP5uo2ghIeBGjGovMII3mL6ywye1XQH+U1JS/ioElvYkRoAYu54CVemaoOMIrb5G2/m1yHMTWCCG4MyBXRcfRHMqchcP1A8GsdPmbdKcad20D2qdllv2mLcZswQiIDUJPD8UlfQccJqebS28xd4UZEy9qnbyntLExfCp1nuqZzhk18rNUsJtuhSd0j0rjm/uq+OXRH+ZOhvD8fi+2k6iqel8lL5Dvo2ZEkd1D8WAAAAAElFTkSuQmCC) no-repeat scroll left 5px;\r\n}\r\n\r\ndiv.warning\r\n{\r\n\tmargin-left: 20px;\r\n\tpadding-bottom: 4px;\r\n\tpadding-top: 3px;\r\n\tpadding-left: 20px;\r\n\tbackground: url(data:image/png;base64,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) no-repeat scroll left 5px;\r\n}\r\n\r\ndiv.error\r\n{\r\n\tmargin-left: 20px;\r\n\tpadding-bottom: 4px;\r\n\tpadding-top: 3px;\r\n\tpadding-left: 20px;\r\n\tbackground: url(data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAADKklEQVQ4jW2T208cdRxHz292Z3aGhQK7LBcxmkDLpYKNtqEJrrQl8aFqo6kmXtun/gO+a4x4SRsf1BBsTZqo6ENNTDS2WjGa2lIwVlqsEMrFsrUBuwvLpTA7y+zszNenGkXP8/mct48SETZzqvKuttqW5mTplrIG8QO1nsnMplM3Lj5vL45tdtU/Ax9FYy0d3Xvf2Lqn64DR2mxwKw3FIgQ++YWsNzU0fGbkwsWXj7hrE/8JfFpZu+/Rx/efitXUVOM4gAIJQABNga6DofNn6o/sN98OPHfEXv7+70BfZMvWg8nO4TrTStiLi6SBezSFbpWgEIqBMGeY1KytYlXF+X1lZfn0pZGHXirmJjWA+xJVb5VnFhOzV0aZaWoifLyXqXictau/sXZ1jGuRCOpoD9PNTcxdHqVu9XasMVZ5DIBjymqZqKx1fwlbMtjUJrZti4jIcjotlx/YLSNtD0p2bl5ERGzHkUst98uvYVN+Lot5PcpsC+0P6QeNYvHJMc/FWV/F0sIk9u7BLC3FPPAYFS88S+zuegRIHX2bma++IOV5BMVAyyIToWRIf7ogkrwZBCjfZ/H8OTQ7h7lzF6FoCZppks/lmHn1NUbf7OG2H7CEhg/kUBPhHCilYBofF0UCGD9zlujhQ+gVFSBC0baZODvACmCjmCMgD7iElFYQuZ5QijggBJjb22k60YcTCuHk8zgbG+QEGt/vRd+xkxw+BYQSpfAgpeX8YFDXNK8NofXeBna9+w45Q8dxC7h9xyn09pH3CqwpofPkSXbv6GAbQrnSio7Iee0DcSev+/6X7bpFeXaByE/DhEwTq/8T1nvfY72vF+vDjzGipXg/fIebmqRd05kXvj4h7rgSEQ6rSGOXFRnuKBSql0SIdT0MP54jCmiAg8C+brKDQ5QVi1zR9aVBz+/sF3caEUFEeFEZyf6S8ls3jajMgzh6iUisRqSqTlyzTDIgN0KW9BvRzCFldN/Z/etMzyhjW2sk8vojlvXE9upqc0t9PQQB6wsLTKczGwM5+/R4wXvlM3Gn/veNd3hKRVriYT0ZN60GEZ+VQmF2yfOGPhf32mb3L9WplnZ5n/+WAAAAAElFTkSuQmCC) no-repeat scroll left 5px;\r\n}\r\n\r\nimg\r\n{\r\n    border:0 none;\r\n}\r\n\r\nimg.statusIcon\r\n{\r\n    margin-right: 5px;\r\n}\r\n\r\n}\r\n\r\n</style>\r\n\r\n");
										streamWriter.WriteLine("</head>");
										streamWriter.WriteLine("<body>");
										streamWriter.WriteLine("<div id=\"header\"><h1>Nitriq Console Edition Results</h1></div>");
										streamWriter.WriteLine("<div id=\"page\">");
										streamWriter.WriteLine(stringBuilder2.ToString());
										streamWriter.WriteLine(stringBuilder.ToString());
										streamWriter.WriteLine("</div>");
										streamWriter.WriteLine("</body></html>");
									}
									if (num2 > 0 || (flag && num > 0))
									{
										Console.WriteLine("Nitriq Analysis Completed with Analysis Errors");
										result = 1;
									}
									else
									{
										Console.WriteLine("Nitriq Analysis Completed");
										result = 0;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Exception: " + ex.ToString());
				result = 1;
			}
			return result;
		}

		private static string smethod_0(string string_0)
		{
			return string_0.Replace("\r\n", "<br />").Replace("\n", "<br />").Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");
		}

		private static IEnumerable<AssemblyFileInfo> smethod_1(string string_0)
		{
			List<string> list = new List<string>();
			using (StreamReader streamReader = new StreamReader(string_0))
			{
				while (!streamReader.EndOfStream)
				{
					string text = streamReader.ReadLine();
					if (text.Trim() != "")
					{
						list.Add(text.Trim());
					}
				}
			}
			List<AssemblyFileInfo> list2 = new List<AssemblyFileInfo>();
			foreach (string text in list)
			{
				string text;
				string a = Path.GetExtension(text).ToLower();
				AssemblyFileInfo item;
				if (a == ".exe" || a == ".dll")
				{
					item = new AssemblyFileInfo
					{
						Path = text,
						Name = Path.GetFileNameWithoutExtension(text),
						Version = FileVersionInfo.GetVersionInfo(text).FileVersion
					};
				}
				else
				{
					item = new AssemblyFileInfo
					{
						Path = text,
						Name = "Search Directory",
						Version = "N/A"
					};
				}
				list2.Add(item);
			}
			return list2;
		}

		public static string smethod_2(IEnumerable ienumerable_0)
		{
			string result;
			if (ienumerable_0 == null || ienumerable_0.Count() == 0)
			{
				result = "No Results to display";
			}
			else
			{
				Type type = ienumerable_0.First().GetType();
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("<table border=\"1\">");
				PropertyInfo[] properties = type.GetProperties();
				stringBuilder.AppendLine("<tr><thead>");
				PropertyInfo[] array = properties;
				for (int i = 0; i < array.Length; i++)
				{
					PropertyInfo propertyInfo = array[i];
					stringBuilder.Append("<td><b>");
					stringBuilder.Append(propertyInfo.Name);
					stringBuilder.AppendLine("</b></td>");
				}
				stringBuilder.AppendLine("</thead></tr>");
				stringBuilder.AppendLine();
				foreach (object current in ienumerable_0)
				{
					stringBuilder.AppendLine("<tr>");
					if (current.GetType() != type)
					{
						stringBuilder.AppendLine("<td>Cannot display this item because it is of a different type than the first item in the IEnumerable</td></tr>");
					}
					else
					{
						array = properties;
						for (int i = 0; i < array.Length; i++)
						{
							PropertyInfo propertyInfo = array[i];
							Type type2 = current.GetType();
							PropertyInfo property = type2.GetProperty(propertyInfo.Name);
							if (ConsoleMain.smethod_3(property.PropertyType))
							{
								stringBuilder.Append("<td class=\"numeric\">");
							}
							else
							{
								stringBuilder.Append("<td>");
							}
							string value = Convert.ToString(property.GetValue(current, null));
							stringBuilder.Append(value);
							stringBuilder.Append("</td>");
						}
						stringBuilder.AppendLine("</tr>");
					}
				}
				stringBuilder.AppendLine("</table>");
				result = stringBuilder.ToString();
			}
			return result;
		}

		private static bool smethod_3(Type type_0)
		{
			return type_0 == typeof(double) || type_0 == typeof(int) || type_0 == typeof(float) || type_0 == typeof(decimal) || type_0 == typeof(short) || type_0 == typeof(long) || type_0 == typeof(byte);
		}

		public ConsoleMain()
		{
			LicenseManager.Validate(typeof(ConsoleMain));
			base..ctor();
		}

		[CompilerGenerated]
		private static bool smethod_4(string string_0)
		{
			return string_0.EndsWith(".nitriqProj");
		}

		[CompilerGenerated]
		private static bool smethod_5(string string_0)
		{
			return string_0.EndsWith(".nq");
		}

		[CompilerGenerated]
		private static bool smethod_6(string string_0)
		{
			return string_0.EndsWith(".html");
		}

		[CompilerGenerated]
		private static bool smethod_7(string string_0)
		{
			return string_0.ToLowerInvariant() == "/warnaserror";
		}

		[CompilerGenerated]
		private static string smethod_8(AssemblyFileInfo assemblyFileInfo_0)
		{
			return assemblyFileInfo_0.Path;
		}
	}
}
