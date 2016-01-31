using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Nitriq.Wpf
{
	public static class Util
	{
		public static T DeepCopy<T>(T item)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			MemoryStream memoryStream = new MemoryStream();
			binaryFormatter.Serialize(memoryStream, item);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			T result = (T)((object)binaryFormatter.Deserialize(memoryStream));
			memoryStream.Close();
			return result;
		}

		public static string ConvertToXml(object item)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(item.GetType());
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				xmlSerializer.Serialize(memoryStream, item);
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				@string = uTF8Encoding.GetString(memoryStream.ToArray());
			}
			return @string;
		}

		public static T FromXml<T>(string xml)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
			T result;
			using (StringReader stringReader = new StringReader(xml))
			{
				result = (T)((object)xmlSerializer.Deserialize(stringReader));
			}
			return result;
		}
	}
}
