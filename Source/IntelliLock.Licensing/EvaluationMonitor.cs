using System;

namespace IntelliLock.Licensing
{
	[Attribute0(
 = true, 
 = true, 
 = true)]
	internal class EvaluationMonitor
	{
		private static License license_0;

		public static License smethod_0()
		{
			return EvaluationMonitor.license_0;
		}

		public static void smethod_1(License license_1)
		{
			EvaluationMonitor.license_0 = license_1;
		}

		public static byte[] smethod_2()
		{
			return Class1.byte_0;
		}

		public static void smethod_3(string string_0)
		{
			lock (Class1.object_0)
			{
				new Class1().method_10(null, typeof(License_DeActivator), null, true, true, false, false, "", string_0, null, false, false, false);
			}
		}

		public static void smethod_4(byte[] byte_0)
		{
			lock (Class1.object_0)
			{
				new Class1().method_10(null, typeof(License_DeActivator), null, true, true, false, false, "", "", byte_0, false, false, false);
			}
		}

		static EvaluationMonitor()
		{
			EvaluationMonitor.license_0 = new License();
		}
	}
}
