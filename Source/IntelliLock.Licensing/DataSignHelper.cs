using System;

namespace IntelliLock.Licensing
{
	[Attribute0(
 = true, 
 = true, 
 = true)]
	internal class DataSignHelper
	{
		internal static byte[] byte_0;

		public static bool smethod_0(byte[] byte_1)
		{
			bool result;
			lock (Class1.object_0)
			{
				if (new Class1().method_10(null, typeof(License_DeActivator), null, true, false, false, false, "", "", byte_1, false, true, false) != null)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		public static byte[] smethod_1(byte[] byte_1)
		{
			DataSignHelper.byte_0 = new byte[0];
			lock (Class1.object_0)
			{
				new Class1().method_10(null, typeof(License_DeActivator), null, true, false, false, false, "", "", byte_1, false, false, true);
			}
			return DataSignHelper.byte_0;
		}

		static DataSignHelper()
		{
			DataSignHelper.byte_0 = new byte[0];
		}
	}
}
