using System;

namespace ns1
{
	[Attribute0( = true,  = true,  = true)]
	internal class Class34
	{
		internal static string string_0;

		public static bool smethod_0()
		{
			Class15.ShowMessage("Method \"DeactivateLicenseViaLicenseServer()\" blocked. DEMO MODE!");
			return false;
		}

		public static bool smethod_1()
		{
			Class15.ShowMessage("Method \"ReactivateLicenseViaLicenseServer()\" blocked. DEMO MODE!");
			return false;
		}

		public static string smethod_2()
		{
			string result;
			lock (Class15.object_0)
			{
				Class34.string_0 = "";
				new Class15().method_10(null, typeof(Class34), null, true, false, true, false, "", "", null, false, false, false);
				Class33.smethod_0().method_1((Enum6)8);
				Class33.smethod_0().method_3((Enum6)8);
				Class33.smethod_0().method_5((Enum6)8);
				result = Class34.string_0;
			}
			return result;
		}

		public static string smethod_3(bool bool_0, bool bool_1, bool bool_2, bool bool_3, bool bool_4, bool bool_5)
		{
			string result;
			lock (Class15.object_0)
			{
				Class34.string_0 = "";
				new Class15().method_10(null, typeof(Class34), null, true, false, true, false, Class15.smethod_3(bool_0, bool_1, bool_2, bool_3, bool_4, bool_5), "", null, false, false, false);
				Class33.smethod_0().method_1((Enum6)8);
				Class33.smethod_0().method_3((Enum6)8);
				Class33.smethod_0().method_5((Enum6)8);
				result = Class34.string_0;
			}
			return result;
		}

		public static bool smethod_4(string string_1)
		{
			bool result;
			lock (Class15.object_0)
			{
				if (new Class15().method_10(null, typeof(Class34), null, true, false, false, true, string_1, "", null, false, false, false) != null)
				{
					Class33.smethod_0().method_1((Enum6)9);
					Class33.smethod_0().method_3((Enum6)9);
					Class33.smethod_0().method_5((Enum6)9);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		static Class34()
		{
			Class34.string_0 = "";
		}
	}
}
