using System;

namespace IntelliLock.Licensing
{
	[Attribute0(
 = true, 
 = true, 
 = true)]
	internal class License_DeActivator
	{
		internal static string string_0;

		public static bool smethod_0()
		{
			Class1.ShowMessage("Method \"DeactivateLicenseViaLicenseServer()\" blocked. DEMO MODE!");
			return false;
		}

		public static bool smethod_1()
		{
			Class1.ShowMessage("Method \"ReactivateLicenseViaLicenseServer()\" blocked. DEMO MODE!");
			return false;
		}

		public static string smethod_2()
		{
			string result;
			lock (Class1.object_0)
			{
				License_DeActivator.string_0 = "";
				new Class1().method_10(null, typeof(License_DeActivator), null, true, false, true, false, "", "", null, false, false, false);
				EvaluationMonitor.smethod_0().method_1((LicenseStatus)8);
				EvaluationMonitor.smethod_0().method_3((LicenseStatus)8);
				EvaluationMonitor.smethod_0().method_5((LicenseStatus)8);
				result = License_DeActivator.string_0;
			}
			return result;
		}

		public static string smethod_3(bool bool_0, bool bool_1, bool bool_2, bool bool_3, bool bool_4, bool bool_5)
		{
			string result;
			lock (Class1.object_0)
			{
				License_DeActivator.string_0 = "";
				new Class1().method_10(null, typeof(License_DeActivator), null, true, false, true, false, Class1.smethod_3(bool_0, bool_1, bool_2, bool_3, bool_4, bool_5), "", null, false, false, false);
				EvaluationMonitor.smethod_0().method_1((LicenseStatus)8);
				EvaluationMonitor.smethod_0().method_3((LicenseStatus)8);
				EvaluationMonitor.smethod_0().method_5((LicenseStatus)8);
				result = License_DeActivator.string_0;
			}
			return result;
		}

		public static bool smethod_4(string string_1)
		{
			bool result;
			lock (Class1.object_0)
			{
				if (new Class1().method_10(null, typeof(License_DeActivator), null, true, false, false, true, string_1, "", null, false, false, false) != null)
				{
					EvaluationMonitor.smethod_0().method_1((LicenseStatus)9);
					EvaluationMonitor.smethod_0().method_3((LicenseStatus)9);
					EvaluationMonitor.smethod_0().method_5((LicenseStatus)9);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		static License_DeActivator()
		{
			License_DeActivator.string_0 = "";
		}
	}
}
