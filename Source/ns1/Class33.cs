using System;

namespace ns1
{
	[Attribute0( = true,  = true,  = true)]
	internal class Class33
	{
		private static Class32 class32_0;

		public static Class32 smethod_0()
		{
			return Class33.class32_0;
		}

		public static void smethod_1(Class32 class32_1)
		{
			Class33.class32_0 = class32_1;
		}

		public static byte[] smethod_2()
		{
			return Class15.byte_0;
		}

		public static void smethod_3(string string_0)
		{
			lock (Class15.object_0)
			{
				new Class15().method_10(null, typeof(Class34), null, true, true, false, false, "", string_0, null, false, false, false);
			}
		}

		public static void smethod_4(byte[] byte_0)
		{
			lock (Class15.object_0)
			{
				new Class15().method_10(null, typeof(Class34), null, true, true, false, false, "", "", byte_0, false, false, false);
			}
		}

		static Class33()
		{
			Class33.class32_0 = new Class32();
		}
	}
}
