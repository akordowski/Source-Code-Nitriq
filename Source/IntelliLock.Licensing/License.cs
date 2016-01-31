using Microsoft.Win32;
using System;
using System.Collections;
using System.IO;
using System.Text;

namespace IntelliLock.Licensing
{
	[Attribute0(
 = true, 
 = true, 
 = true)]
	internal class License
	{
		private DateTime dateTime_0 = DateTime.Now;

		private bool bool_0;

		private bool bool_1;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private bool bool_2;

		private bool bool_3;

		private int int_5;

		private bool bool_4;

		private int int_6;

		private int int_7;

		private int int_8;

		private bool bool_5;

		private bool bool_6;

		private bool bool_7;

		private string string_0 = Class1.Class2.string_11;

		private SortedList sortedList_0 = new SortedList();

		private LicenseStatus licenseStatus_0;

		private LicenseStatus licenseStatus_1;

		private LicenseStatus licenseStatus_2;

		private LicenseLocation licenseLocation_0;

		private bool bool_8;

		private string string_1 = "http:\\\\";

		private bool bool_9;

		private bool bool_10;

		private bool bool_11;

		private bool bool_12;

		private bool bool_13;

		private bool bool_14;

		private bool bool_15;

		internal Class1.Class3 class3_0;

		internal License()
		{
		}

		public LicenseStatus method_0()
		{
			return this.licenseStatus_0;
		}

		public void method_1(LicenseStatus licenseStatus_3)
		{
			this.licenseStatus_0 = licenseStatus_3;
		}

		public LicenseStatus method_2()
		{
			return this.licenseStatus_1;
		}

		public void method_3(LicenseStatus licenseStatus_3)
		{
			this.licenseStatus_1 = licenseStatus_3;
		}

		public LicenseStatus method_4()
		{
			return this.licenseStatus_2;
		}

		public void method_5(LicenseStatus licenseStatus_3)
		{
			this.licenseStatus_2 = licenseStatus_3;
		}

		public LicenseLocation method_6()
		{
			return this.licenseLocation_0;
		}

		public void method_7(LicenseLocation licenseLocation_1)
		{
			this.licenseLocation_0 = licenseLocation_1;
		}

		public bool method_8()
		{
			return this.bool_8;
		}

		public void method_9(bool bool_16)
		{
			this.bool_8 = bool_16;
		}

		public string method_10()
		{
			return this.string_1;
		}

		public void method_11(string string_2)
		{
			this.string_1 = string_2;
		}

		public DateTime method_12()
		{
			return this.dateTime_0;
		}

		public void method_13(DateTime dateTime_1)
		{
			this.dateTime_0 = dateTime_1;
		}

		public bool method_14()
		{
			return this.bool_0;
		}

		public void method_15(bool bool_16)
		{
			this.bool_0 = bool_16;
		}

		public bool method_16()
		{
			return this.bool_1;
		}

		public void method_17(bool bool_16)
		{
			this.bool_1 = bool_16;
		}

		public int method_18()
		{
			return this.int_0;
		}

		public void method_19(int int_9)
		{
			this.int_0 = int_9;
		}

		public int method_20()
		{
			return this.int_1;
		}

		public void method_21(int int_9)
		{
			this.int_1 = int_9;
		}

		public int method_22()
		{
			return this.int_2;
		}

		public void method_23(int int_9)
		{
			this.int_2 = int_9;
		}

		public int method_24()
		{
			return this.int_4;
		}

		public void method_25(int int_9)
		{
			this.int_4 = int_9;
		}

		public bool method_26()
		{
			return this.bool_2;
		}

		public void method_27(bool bool_16)
		{
			this.bool_2 = bool_16;
		}

		public bool method_28()
		{
			return this.bool_3;
		}

		public void method_29(bool bool_16)
		{
			this.bool_3 = bool_16;
		}

		public int method_30()
		{
			return this.int_5;
		}

		public void method_31(int int_9)
		{
			this.int_5 = int_9;
		}

		public bool method_32()
		{
			return this.bool_4;
		}

		public void method_33(bool bool_16)
		{
			this.bool_4 = bool_16;
		}

		public int method_34()
		{
			return this.int_6;
		}

		public void method_35(int int_9)
		{
			this.int_6 = int_9;
		}

		public int method_36()
		{
			return this.int_7;
		}

		public void method_37(int int_9)
		{
			this.int_7 = int_9;
		}

		public int method_38()
		{
			return this.int_8;
		}

		public void method_39(int int_9)
		{
			this.int_8 = int_9;
		}

		public bool method_40()
		{
			return this.bool_5;
		}

		public void method_41(bool bool_16)
		{
			this.bool_5 = bool_16;
		}

		public bool method_42()
		{
			return this.bool_6;
		}

		public void method_43(bool bool_16)
		{
			this.bool_6 = bool_16;
		}

		public string method_44()
		{
			try
			{
				lock (Class1.object_0)
				{
					Class1.smethod_5();
					Class1.Class3 @class = null;
					try
					{
						string str = Class1.Class2.string_0;
						string str2 = Class1.string_3 + "\\";
						RegistryKey registryKey = Registry.CurrentUser;
						if (Class1.smethod_0())
						{
							registryKey = Registry.LocalMachine;
						}
						RegistryKey registryKey2 = registryKey.OpenSubKey(str + str2, false);
						if (registryKey2 != null)
						{
							Class1.Class3 class2 = new Class1.Class3();
							class2.method_0((string)registryKey2.GetValue("1"), Class1.byte_1, Class1.byte_2);
							if (@class == null)
							{
								@class = class2;
							}
							if (class2.ulong_0 > @class.ulong_0)
							{
								@class = class2;
							}
						}
					}
					catch
					{
					}
					try
					{
						if (Class0.smethod_5(base.GetType().Assembly).ToString().Length > 0 && File.Exists(Class0.smethod_5(base.GetType().Assembly).ToString()))
						{
							Class1.Class3 class3 = new Class1.Class3();
							class3.method_0(Class1.smethod_8(Path.GetDirectoryName(Class0.smethod_5(base.GetType().Assembly).ToString()), Class1.string_2), Class1.byte_1, Class1.byte_2);
							if (@class == null)
							{
								@class = class3;
							}
							if (class3.ulong_0 > @class.ulong_0)
							{
								@class = class3;
							}
						}
					}
					catch
					{
					}
					try
					{
						if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class1.Class2.string_2 + Class1.string_2))
						{
							Class1.Class3 class4 = new Class1.Class3();
							class4.method_0(Encoding.Unicode.GetString(Class1.smethod_11(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class1.Class2.string_2 + Class1.string_2)), Class1.byte_1, Class1.byte_2);
							if (@class == null)
							{
								@class = class4;
							}
							if (class4.ulong_0 > @class.ulong_0)
							{
								@class = class4;
							}
						}
					}
					catch
					{
					}
					if (@class == null)
					{
						@class = new Class1.Class3();
					}
					return @class.string_0;
				}
			}
			catch
			{
			}
			return "";
		}

		public void method_45(string string_2)
		{
			try
			{
				lock (Class1.object_0)
				{
					Class1.smethod_5();
					Class1.Class3 @class = null;
					try
					{
						string str = Class1.Class2.string_0;
						string str2 = Class1.string_3 + "\\";
						RegistryKey registryKey = Registry.CurrentUser;
						if (Class1.smethod_0())
						{
							registryKey = Registry.LocalMachine;
						}
						RegistryKey registryKey2 = registryKey.OpenSubKey(str + str2, false);
						if (registryKey2 != null)
						{
							Class1.Class3 class2 = new Class1.Class3();
							class2.method_0((string)registryKey2.GetValue("1"), Class1.byte_1, Class1.byte_2);
							if (@class == null)
							{
								@class = class2;
							}
							if (class2.ulong_0 > @class.ulong_0)
							{
								@class = class2;
							}
						}
					}
					catch
					{
					}
					try
					{
						if (Class0.smethod_5(base.GetType().Assembly).ToString().Length > 0 && File.Exists(Class0.smethod_5(base.GetType().Assembly).ToString()))
						{
							Class1.Class3 class3 = new Class1.Class3();
							class3.method_0(Class1.smethod_8(Path.GetDirectoryName(Class0.smethod_5(base.GetType().Assembly).ToString()), Class1.string_2), Class1.byte_1, Class1.byte_2);
							if (@class == null)
							{
								@class = class3;
							}
							if (class3.ulong_0 > @class.ulong_0)
							{
								@class = class3;
							}
						}
					}
					catch
					{
					}
					try
					{
						if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class1.Class2.string_2 + Class1.string_2))
						{
							Class1.Class3 class4 = new Class1.Class3();
							class4.method_0(Encoding.Unicode.GetString(Class1.smethod_11(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class1.Class2.string_2 + Class1.string_2)), Class1.byte_1, Class1.byte_2);
							if (@class == null)
							{
								@class = class4;
							}
							if (class4.ulong_0 > @class.ulong_0)
							{
								@class = class4;
							}
						}
					}
					catch
					{
					}
					if (@class == null)
					{
						@class = new Class1.Class3();
					}
					@class.string_0 = string_2;
					try
					{
						string str3 = Class1.Class2.string_0;
						string str4 = Class1.string_3 + "\\";
						RegistryKey registryKey3 = Registry.CurrentUser;
						if (Class1.smethod_0())
						{
							registryKey3 = Registry.LocalMachine;
						}
						RegistryKey registryKey4;
						if (registryKey3.OpenSubKey(str3 + str4, false) == null)
						{
							registryKey3 = Registry.CurrentUser;
							if (Class1.smethod_0())
							{
								registryKey3 = Registry.LocalMachine;
							}
							registryKey4 = registryKey3.CreateSubKey(str3 + str4);
						}
						registryKey3 = Registry.CurrentUser;
						if (Class1.smethod_0())
						{
							registryKey3 = Registry.LocalMachine;
						}
						registryKey4 = registryKey3.OpenSubKey(str3 + str4, true);
						if (registryKey4 != null)
						{
							registryKey4.SetValue("1", @class.method_5(Class1.byte_1, Class1.byte_2));
							registryKey4.Close();
						}
					}
					catch
					{
					}
					try
					{
						if (Class0.smethod_5(base.GetType().Assembly).ToString().Length > 0 && File.Exists(Class0.smethod_5(base.GetType().Assembly).ToString()))
						{
							Class1.smethod_7(Path.GetDirectoryName(Class0.smethod_5(base.GetType().Assembly).ToString()), Class1.string_2, @class.method_5(Class1.byte_1, Class1.byte_2));
						}
					}
					catch
					{
					}
					try
					{
						FileStream fileStream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + Class1.Class2.string_2 + Class1.string_2, FileMode.Create, FileAccess.ReadWrite);
						byte[] bytes = Encoding.Unicode.GetBytes(@class.method_5(Class1.byte_1, Class1.byte_2));
						fileStream.Write(bytes, 0, bytes.Length);
						fileStream.Close();
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}

		public bool method_46()
		{
			return this.bool_7;
		}

		public void method_47(bool bool_16)
		{
			this.bool_7 = bool_16;
		}

		public string method_48()
		{
			return this.string_0;
		}

		public void method_49(string string_2)
		{
			this.string_0 = string_2;
		}

		public SortedList method_50()
		{
			return this.sortedList_0;
		}

		public void method_51(SortedList sortedList_1)
		{
			this.sortedList_0 = sortedList_1;
		}

		public bool method_52()
		{
			return this.bool_9;
		}

		public void method_53(bool bool_16)
		{
			this.bool_9 = bool_16;
		}

		public bool method_54()
		{
			return this.bool_10;
		}

		public void method_55(bool bool_16)
		{
			this.bool_10 = bool_16;
		}

		public bool method_56()
		{
			return this.bool_11;
		}

		public void method_57(bool bool_16)
		{
			this.bool_11 = bool_16;
		}

		public bool method_58()
		{
			return this.bool_12;
		}

		public void method_59(bool bool_16)
		{
			this.bool_12 = bool_16;
		}

		public bool method_60()
		{
			return this.bool_13;
		}

		public void method_61(bool bool_16)
		{
			this.bool_13 = bool_16;
		}

		public bool method_62()
		{
			return this.bool_14;
		}

		public void method_63(bool bool_16)
		{
			this.bool_14 = bool_16;
		}

		public bool method_64()
		{
			return this.bool_15;
		}

		public void method_65(bool bool_16)
		{
			this.bool_15 = bool_16;
		}

		public int method_66()
		{
			return this.int_3;
		}

		public void method_67(int int_9)
		{
			this.int_3 = int_9;
		}
	}
}
