using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nitriq.Analysis.Models
{
	[Serializable]
	public class File
	{
		[NonSerialized]
		private Document document_0;

		private string string_0;

		[NonSerialized]
		private string[] string_1;

		private string string_2;

		private string string_3;

		public string Language
		{
			get
			{
				return this.string_2;
			}
		}

		public string FullFileName
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		public File(Document document)
		{
			this.document_0 = document;
			this.string_3 = document.Url;
			if (document.Language == DocumentLanguage.CSharp)
			{
				this.string_2 = "C#";
			}
			else if (document.Language == DocumentLanguage.Basic)
			{
				this.string_2 = "VB";
			}
			else
			{
				this.string_0 = "Invalid Code Type. Only C# and VB will be parsed";
			}
			List<string> list = new List<string>();
			list.Add("");
			try
			{
				if (!System.IO.File.Exists(this.string_3))
				{
					this.string_0 = "File Doesn't Exist";
				}
				else
				{
					using (StreamReader streamReader = new StreamReader(this.string_3))
					{
						while (!streamReader.EndOfStream)
						{
							list.Add(streamReader.ReadLine());
						}
						this.string_1 = list.ToArray();
					}
				}
			}
			catch (Exception ex)
			{
				this.string_0 = ex.ToString();
			}
		}

		internal bool method_0()
		{
			return this.string_0 != null;
		}

		internal string method_1()
		{
			return this.string_0;
		}

		internal string[] method_2()
		{
			return this.string_1;
		}

		internal string method_3(SequencePoint sequencePoint_0)
		{
			string result;
			if (sequencePoint_0.StartLine == sequencePoint_0.EndLine)
			{
				result = this.string_1[sequencePoint_0.StartLine].Substring(sequencePoint_0.StartColumn - 1, sequencePoint_0.EndColumn - sequencePoint_0.StartColumn);
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(this.string_1[sequencePoint_0.StartLine - 1].Substring(sequencePoint_0.StartColumn - 1));
				for (int i = sequencePoint_0.StartLine + 1; i < sequencePoint_0.EndLine; i++)
				{
					stringBuilder.Append(this.string_1[i]);
				}
				stringBuilder.Append(this.string_1[sequencePoint_0.EndLine].Substring(0, sequencePoint_0.EndColumn - 1));
				result = stringBuilder.ToString();
			}
			return result;
		}

		internal bool method_4(SequencePoint sequencePoint_0)
		{
			return sequencePoint_0.StartLine == sequencePoint_0.EndLine && sequencePoint_0.EndColumn - sequencePoint_0.StartColumn == 1 && this.string_1.Length > sequencePoint_0.StartLine && this.string_1[sequencePoint_0.StartLine].Length > sequencePoint_0.StartColumn - 1 && this.string_1[sequencePoint_0.StartLine].Substring(sequencePoint_0.StartColumn - 1, 1) == "{";
		}

		internal bool method_5(SequencePoint sequencePoint_0)
		{
			return sequencePoint_0.StartLine == sequencePoint_0.EndLine && sequencePoint_0.EndColumn - sequencePoint_0.StartColumn == 1 && this.string_1.Length > sequencePoint_0.StartLine && this.string_1[sequencePoint_0.StartLine].Length > sequencePoint_0.StartColumn - 1 && this.string_1[sequencePoint_0.StartLine].Substring(sequencePoint_0.StartColumn - 1, 1) == "}";
		}

		internal string method_6(SequencePoint sequencePoint_0, SequencePoint sequencePoint_1)
		{
			string result;
			if (sequencePoint_0.StartLine == sequencePoint_1.EndLine)
			{
				if (this.string_1.Length <= sequencePoint_0.StartLine)
				{
					result = "";
				}
				else
				{
					result = this.string_1[sequencePoint_0.StartLine].Substring(sequencePoint_0.StartColumn - 1, sequencePoint_1.EndColumn - sequencePoint_0.StartColumn);
				}
			}
			else if (this.string_1.Length <= sequencePoint_1.EndLine)
			{
				result = "";
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine(this.string_1[sequencePoint_0.StartLine].Substring(sequencePoint_0.StartColumn - 1));
				for (int i = sequencePoint_0.StartLine + 1; i < sequencePoint_1.EndLine; i++)
				{
					stringBuilder.AppendLine(this.string_1[i]);
				}
				stringBuilder.Append(this.string_1[sequencePoint_1.EndLine].Substring(0, sequencePoint_1.EndColumn - 1));
				result = stringBuilder.ToString();
			}
			return result;
		}

		internal string method_7(SequencePoint sequencePoint_0, SequencePoint sequencePoint_1)
		{
			string result;
			if (sequencePoint_0.EndLine == sequencePoint_1.StartLine)
			{
				result = this.string_1[sequencePoint_0.EndLine].Substring(sequencePoint_0.EndColumn - 1, sequencePoint_1.StartColumn - sequencePoint_0.EndColumn);
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine(this.string_1[sequencePoint_0.EndLine].Substring(sequencePoint_0.EndColumn - 1));
				for (int i = sequencePoint_0.EndLine + 1; i < sequencePoint_1.StartLine; i++)
				{
					stringBuilder.AppendLine(this.string_1[i]);
				}
				stringBuilder.Append(this.string_1[sequencePoint_1.StartLine].Substring(0, sequencePoint_1.StartColumn - 1));
				result = stringBuilder.ToString();
			}
			return result;
		}
	}
}
