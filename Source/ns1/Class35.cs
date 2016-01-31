using System;

namespace ns1
{
	[Attribute0( = true,  = true,  = true)]
	internal class Class35
	{
		internal static byte[] byte_0;

		public static bool smethod_0(byte[] byte_1)
		{
			bool result;
			lock (Class15.object_0)
			{
				if (new Class15().method_10(null, typeof(Class34), null, true, false, false, false, "", "", byte_1, false, true, false) != null)
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
			Class35.byte_0 = new byte[0];
			lock (Class15.object_0)
			{
				new Class15().method_10(null, typeof(Class34), null, true, false, false, false, "", "", byte_1, false, false, true);
			}
			return Class35.byte_0;
		}

		static Class35()
		{
			Class35.byte_0 = new byte[0];
		}
	}
}
