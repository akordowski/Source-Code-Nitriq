using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Nitriq.Analysis.Models
{
	public static class Util
	{
		public static void SaveToDisk(object obj, string filename)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			using (StreamWriter streamWriter = new StreamWriter(filename))
			{
				binaryFormatter.Serialize(streamWriter.BaseStream, obj);
			}
		}

		public static T LoadFromDisk<T>(string filename)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			object obj;
			using (StreamReader streamReader = new StreamReader(filename))
			{
				obj = binaryFormatter.Deserialize(streamReader.BaseStream);
			}
			return (T)((object)obj);
		}

		public static string ToDelimitedList(this IEnumerable<string> list)
		{
			Builder builder = new Builder();
			foreach (string current in list)
			{
				builder.Append(current);
			}
			return builder.ToString();
		}
	}
}
