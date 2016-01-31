using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class Class14
{
	[Flags]
	private enum Enum3
	{

	}

	private static byte[] byte_0;

	private static byte[] byte_1;

	private static byte[] byte_2;

	private static byte[] byte_3;

	private static IntPtr intptr_0;

	private static IntPtr intptr_1;

	private static string[] string_0;

	private static int[] int_0;

	private static int int_1;

	private static bool bool_0;

	private static SortedList sortedList_0;

	private static int int_2;

	private static long long_0;

	static Class14()
	{
		Class14.byte_0 = new byte[0];
		Class14.byte_1 = new byte[0];
		Class14.byte_2 = new byte[0];
		Class14.byte_3 = new byte[0];
		Class14.intptr_0 = IntPtr.Zero;
		Class14.intptr_1 = IntPtr.Zero;
		Class14.string_0 = new string[0];
		Class14.int_0 = new int[0];
		Class14.int_1 = 1;
		Class14.bool_0 = false;
		Class14.sortedList_0 = new SortedList();
		Class14.int_2 = 0;
		Class14.long_0 = 0L;
	}

	private void leHifFIJCLsZtKEFfM1i()
	{
	}

	static bool smethod_0(int int_3)
	{
		if (Class14.byte_1.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class14).Assembly.GetManifestResourceStream("552aa579-b26a-42c6-927d-ada4908113cd"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 181;
			array2[0] = 122;
			array2[0] = 116;
			array2[0] = 131;
			array2[1] = 147;
			array2[1] = 98;
			array2[1] = 215;
			array2[2] = 166;
			array2[2] = 117;
			array2[2] = 156;
			array2[2] = 48;
			array2[2] = 253;
			array2[3] = 186;
			array2[3] = 105;
			array2[3] = 113;
			array2[3] = 199;
			array2[4] = 148;
			array2[4] = 183;
			array2[4] = 72;
			array2[4] = 171;
			array2[4] = 104;
			array2[4] = 72;
			array2[5] = 112;
			array2[5] = 196;
			array2[5] = 155;
			array2[6] = 154;
			array2[6] = 96;
			array2[6] = 23;
			array2[7] = 90;
			array2[7] = 132;
			array2[7] = 46;
			array2[8] = 160;
			array2[8] = 101;
			array2[8] = 169;
			array2[8] = 59;
			array2[8] = 100;
			array2[8] = 135;
			array2[9] = 26;
			array2[9] = 163;
			array2[9] = 55;
			array2[9] = 74;
			array2[9] = 31;
			array2[10] = 116;
			array2[10] = 153;
			array2[10] = 59;
			array2[10] = 147;
			array2[10] = 122;
			array2[10] = 111;
			array2[11] = 81;
			array2[11] = 103;
			array2[11] = 103;
			array2[11] = 228;
			array2[12] = 219;
			array2[12] = 152;
			array2[12] = 53;
			array2[13] = 196;
			array2[13] = 164;
			array2[13] = 116;
			array2[13] = 108;
			array2[13] = 147;
			array2[13] = 138;
			array2[14] = 8;
			array2[14] = 88;
			array2[14] = 139;
			array2[15] = 100;
			array2[15] = 108;
			array2[15] = 165;
			array2[15] = 97;
			array2[15] = 213;
			array2[16] = 134;
			array2[16] = 95;
			array2[16] = 153;
			array2[16] = 134;
			array2[16] = 157;
			array2[16] = 48;
			array2[17] = 140;
			array2[17] = 152;
			array2[17] = 126;
			array2[17] = 96;
			array2[17] = 22;
			array2[18] = 216;
			array2[18] = 120;
			array2[18] = 155;
			array2[18] = 142;
			array2[18] = 217;
			array2[18] = 33;
			array2[19] = 91;
			array2[19] = 116;
			array2[19] = 96;
			array2[19] = 194;
			array2[19] = 4;
			array2[20] = 67;
			array2[20] = 119;
			array2[20] = 214;
			array2[21] = 117;
			array2[21] = 136;
			array2[21] = 90;
			array2[21] = 122;
			array2[21] = 215;
			array2[22] = 79;
			array2[22] = 111;
			array2[22] = 139;
			array2[22] = 177;
			array2[23] = 63;
			array2[23] = 86;
			array2[23] = 130;
			array2[23] = 120;
			array2[23] = 138;
			array2[23] = 175;
			array2[24] = 113;
			array2[24] = 92;
			array2[24] = 173;
			array2[24] = 122;
			array2[24] = 166;
			array2[25] = 129;
			array2[25] = 95;
			array2[25] = 98;
			array2[25] = 162;
			array2[25] = 89;
			array2[25] = 191;
			array2[26] = 124;
			array2[26] = 166;
			array2[26] = 37;
			array2[27] = 84;
			array2[27] = 47;
			array2[27] = 83;
			array2[27] = 135;
			array2[27] = 66;
			array2[27] = 218;
			array2[28] = 121;
			array2[28] = 140;
			array2[28] = 82;
			array2[28] = 149;
			array2[28] = 140;
			array2[28] = 29;
			array2[29] = 171;
			array2[29] = 160;
			array2[29] = 55;
			array2[29] = 77;
			array2[29] = 111;
			array2[29] = 163;
			array2[30] = 152;
			array2[30] = 118;
			array2[30] = 152;
			array2[30] = 153;
			array2[31] = 94;
			array2[31] = 171;
			array2[31] = 89;
			array2[31] = 35;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 126;
			array3[0] = 161;
			array3[0] = 104;
			array3[1] = 31;
			array3[1] = 126;
			array3[1] = 148;
			array3[1] = 110;
			array3[1] = 173;
			array3[1] = 154;
			array3[2] = 122;
			array3[2] = 99;
			array3[2] = 86;
			array3[2] = 88;
			array3[2] = 88;
			array3[2] = 51;
			array3[3] = 168;
			array3[3] = 121;
			array3[3] = 39;
			array3[3] = 183;
			array3[3] = 148;
			array3[3] = 253;
			array3[4] = 102;
			array3[4] = 100;
			array3[4] = 100;
			array3[4] = 158;
			array3[4] = 21;
			array3[5] = 154;
			array3[5] = 204;
			array3[5] = 155;
			array3[5] = 168;
			array3[5] = 161;
			array3[6] = 160;
			array3[6] = 92;
			array3[6] = 203;
			array3[7] = 162;
			array3[7] = 157;
			array3[7] = 90;
			array3[7] = 20;
			array3[8] = 147;
			array3[8] = 127;
			array3[8] = 43;
			array3[9] = 98;
			array3[9] = 177;
			array3[9] = 127;
			array3[9] = 117;
			array3[10] = 154;
			array3[10] = 134;
			array3[10] = 205;
			array3[11] = 59;
			array3[11] = 172;
			array3[11] = 103;
			array3[11] = 170;
			array3[11] = 3;
			array3[12] = 134;
			array3[12] = 155;
			array3[12] = 88;
			array3[12] = 149;
			array3[12] = 216;
			array3[13] = 84;
			array3[13] = 138;
			array3[13] = 143;
			array3[13] = 115;
			array3[13] = 98;
			array3[13] = 139;
			array3[14] = 189;
			array3[14] = 88;
			array3[14] = 168;
			array3[14] = 136;
			array3[14] = 171;
			array3[15] = 187;
			array3[15] = 166;
			array3[15] = 209;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class14).Assembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array4[1] = publicKeyToken[0];
				array4[3] = publicKeyToken[1];
				array4[5] = publicKeyToken[2];
				array4[7] = publicKeyToken[3];
				array4[9] = publicKeyToken[4];
				array4[11] = publicKeyToken[5];
				array4[13] = publicKeyToken[6];
				array4[15] = publicKeyToken[7];
			}
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateDecryptor(rgbKey, array4);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			Class14.byte_1 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
		}
		if (Class14.byte_0.Length == 0)
		{
			Class14.byte_0 = Class14.smethod_6(Class14.smethod_5(typeof(Class14).Assembly).ToString());
		}
		int num = 0;
		try
		{
			num = BitConverter.ToInt32(new byte[]
			{
				Class14.byte_1[int_3],
				Class14.byte_1[int_3 + 1],
				Class14.byte_1[int_3 + 2],
				Class14.byte_1[int_3 + 3]
			}, 0);
		}
		catch
		{
		}
		try
		{
			if (Class14.byte_0[num] == 128)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	static string smethod_1(int int_3)
	{
		if (Class14.byte_2.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class14).Assembly.GetManifestResourceStream("15b96398-9597-4145-8e52-82e25906b4b2"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 126;
			array2[0] = 124;
			array2[0] = 146;
			array2[0] = 48;
			array2[1] = 152;
			array2[1] = 88;
			array2[1] = 254;
			array2[2] = 96;
			array2[2] = 27;
			array2[2] = 244;
			array2[3] = 102;
			array2[3] = 110;
			array2[3] = 124;
			array2[3] = 140;
			array2[4] = 98;
			array2[4] = 152;
			array2[4] = 174;
			array2[4] = 128;
			array2[5] = 185;
			array2[5] = 85;
			array2[5] = 173;
			array2[6] = 69;
			array2[6] = 147;
			array2[6] = 87;
			array2[6] = 86;
			array2[7] = 130;
			array2[7] = 124;
			array2[7] = 101;
			array2[8] = 109;
			array2[8] = 134;
			array2[8] = 157;
			array2[8] = 243;
			array2[9] = 132;
			array2[9] = 86;
			array2[9] = 47;
			array2[9] = 101;
			array2[9] = 197;
			array2[10] = 106;
			array2[10] = 135;
			array2[10] = 138;
			array2[10] = 182;
			array2[10] = 84;
			array2[10] = 214;
			array2[11] = 95;
			array2[11] = 140;
			array2[11] = 95;
			array2[11] = 92;
			array2[11] = 248;
			array2[12] = 157;
			array2[12] = 142;
			array2[12] = 11;
			array2[13] = 120;
			array2[13] = 62;
			array2[13] = 115;
			array2[13] = 138;
			array2[13] = 156;
			array2[13] = 145;
			array2[14] = 134;
			array2[14] = 138;
			array2[14] = 88;
			array2[14] = 164;
			array2[14] = 120;
			array2[14] = 105;
			array2[15] = 123;
			array2[15] = 112;
			array2[15] = 80;
			array2[15] = 122;
			array2[15] = 46;
			array2[16] = 165;
			array2[16] = 84;
			array2[16] = 132;
			array2[16] = 108;
			array2[16] = 108;
			array2[17] = 160;
			array2[17] = 143;
			array2[17] = 105;
			array2[17] = 94;
			array2[17] = 150;
			array2[17] = 166;
			array2[18] = 138;
			array2[18] = 90;
			array2[18] = 202;
			array2[19] = 162;
			array2[19] = 107;
			array2[19] = 186;
			array2[20] = 130;
			array2[20] = 128;
			array2[20] = 113;
			array2[20] = 148;
			array2[20] = 132;
			array2[20] = 165;
			array2[21] = 66;
			array2[21] = 171;
			array2[21] = 94;
			array2[21] = 194;
			array2[22] = 166;
			array2[22] = 155;
			array2[22] = 126;
			array2[22] = 121;
			array2[22] = 133;
			array2[22] = 14;
			array2[23] = 163;
			array2[23] = 106;
			array2[23] = 84;
			array2[23] = 195;
			array2[23] = 232;
			array2[24] = 154;
			array2[24] = 129;
			array2[24] = 142;
			array2[25] = 168;
			array2[25] = 153;
			array2[25] = 136;
			array2[25] = 94;
			array2[25] = 118;
			array2[25] = 131;
			array2[26] = 136;
			array2[26] = 102;
			array2[26] = 121;
			array2[27] = 150;
			array2[27] = 84;
			array2[27] = 102;
			array2[27] = 10;
			array2[28] = 141;
			array2[28] = 104;
			array2[28] = 120;
			array2[28] = 117;
			array2[29] = 145;
			array2[29] = 144;
			array2[29] = 85;
			array2[29] = 7;
			array2[30] = 84;
			array2[30] = 178;
			array2[30] = 157;
			array2[30] = 173;
			array2[30] = 88;
			array2[30] = 212;
			array2[31] = 75;
			array2[31] = 153;
			array2[31] = 139;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 126;
			array3[0] = 121;
			array3[0] = 222;
			array3[1] = 29;
			array3[1] = 163;
			array3[1] = 167;
			array3[1] = 120;
			array3[1] = 234;
			array3[2] = 31;
			array3[2] = 60;
			array3[2] = 72;
			array3[3] = 145;
			array3[3] = 150;
			array3[3] = 247;
			array3[4] = 74;
			array3[4] = 165;
			array3[4] = 164;
			array3[5] = 117;
			array3[5] = 104;
			array3[5] = 113;
			array3[5] = 136;
			array3[5] = 224;
			array3[6] = 227;
			array3[6] = 157;
			array3[6] = 222;
			array3[6] = 166;
			array3[6] = 45;
			array3[7] = 129;
			array3[7] = 93;
			array3[7] = 118;
			array3[7] = 175;
			array3[7] = 89;
			array3[7] = 24;
			array3[8] = 103;
			array3[8] = 136;
			array3[8] = 170;
			array3[8] = 142;
			array3[9] = 156;
			array3[9] = 85;
			array3[9] = 55;
			array3[9] = 167;
			array3[9] = 196;
			array3[9] = 179;
			array3[10] = 104;
			array3[10] = 92;
			array3[10] = 147;
			array3[10] = 85;
			array3[10] = 219;
			array3[11] = 170;
			array3[11] = 192;
			array3[11] = 121;
			array3[11] = 140;
			array3[11] = 27;
			array3[12] = 122;
			array3[12] = 94;
			array3[12] = 108;
			array3[12] = 155;
			array3[13] = 75;
			array3[13] = 122;
			array3[13] = 49;
			array3[13] = 86;
			array3[13] = 120;
			array3[13] = 112;
			array3[14] = 156;
			array3[14] = 126;
			array3[14] = 90;
			array3[14] = 153;
			array3[14] = 170;
			array3[14] = 100;
			array3[15] = 205;
			array3[15] = 156;
			array3[15] = 212;
			array3[15] = 112;
			array3[15] = 136;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class14).Assembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array4[1] = publicKeyToken[0];
				array4[3] = publicKeyToken[1];
				array4[5] = publicKeyToken[2];
				array4[7] = publicKeyToken[3];
				array4[9] = publicKeyToken[4];
				array4[11] = publicKeyToken[5];
				array4[13] = publicKeyToken[6];
				array4[15] = publicKeyToken[7];
			}
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateDecryptor(rgbKey, array4);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			Class14.byte_2 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
		}
		int num = BitConverter.ToInt32(Class14.byte_2, int_3);
		try
		{
			byte[] array5 = new byte[num];
			Array.Copy(Class14.byte_2, int_3 + 4, array5, 0, num);
			return Encoding.Unicode.GetString(array5, 0, array5.Length);
		}
		catch
		{
		}
		return "";
	}

	static string smethod_2(int int_3)
	{
		if (Class14.byte_3.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class14).Assembly.GetManifestResourceStream("15b96398-9597-4145-8e52-82e25906b4b2"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 126;
			array2[0] = 124;
			array2[0] = 146;
			array2[0] = 48;
			array2[1] = 152;
			array2[1] = 88;
			array2[1] = 254;
			array2[2] = 96;
			array2[2] = 27;
			array2[2] = 244;
			array2[3] = 102;
			array2[3] = 110;
			array2[3] = 124;
			array2[3] = 140;
			array2[4] = 98;
			array2[4] = 152;
			array2[4] = 174;
			array2[4] = 128;
			array2[5] = 185;
			array2[5] = 85;
			array2[5] = 173;
			array2[6] = 69;
			array2[6] = 147;
			array2[6] = 87;
			array2[6] = 86;
			array2[7] = 130;
			array2[7] = 124;
			array2[7] = 101;
			array2[8] = 109;
			array2[8] = 134;
			array2[8] = 157;
			array2[8] = 243;
			array2[9] = 132;
			array2[9] = 86;
			array2[9] = 47;
			array2[9] = 101;
			array2[9] = 197;
			array2[10] = 106;
			array2[10] = 135;
			array2[10] = 138;
			array2[10] = 182;
			array2[10] = 84;
			array2[10] = 214;
			array2[11] = 95;
			array2[11] = 140;
			array2[11] = 95;
			array2[11] = 92;
			array2[11] = 248;
			array2[12] = 157;
			array2[12] = 142;
			array2[12] = 11;
			array2[13] = 120;
			array2[13] = 62;
			array2[13] = 115;
			array2[13] = 138;
			array2[13] = 156;
			array2[13] = 145;
			array2[14] = 134;
			array2[14] = 138;
			array2[14] = 88;
			array2[14] = 164;
			array2[14] = 120;
			array2[14] = 105;
			array2[15] = 123;
			array2[15] = 112;
			array2[15] = 80;
			array2[15] = 122;
			array2[15] = 46;
			array2[16] = 165;
			array2[16] = 84;
			array2[16] = 132;
			array2[16] = 108;
			array2[16] = 108;
			array2[17] = 160;
			array2[17] = 143;
			array2[17] = 105;
			array2[17] = 94;
			array2[17] = 150;
			array2[17] = 166;
			array2[18] = 138;
			array2[18] = 90;
			array2[18] = 202;
			array2[19] = 162;
			array2[19] = 107;
			array2[19] = 186;
			array2[20] = 130;
			array2[20] = 128;
			array2[20] = 113;
			array2[20] = 148;
			array2[20] = 132;
			array2[20] = 165;
			array2[21] = 66;
			array2[21] = 171;
			array2[21] = 94;
			array2[21] = 194;
			array2[22] = 166;
			array2[22] = 155;
			array2[22] = 126;
			array2[22] = 121;
			array2[22] = 133;
			array2[22] = 14;
			array2[23] = 163;
			array2[23] = 106;
			array2[23] = 84;
			array2[23] = 195;
			array2[23] = 232;
			array2[24] = 154;
			array2[24] = 129;
			array2[24] = 142;
			array2[25] = 168;
			array2[25] = 153;
			array2[25] = 136;
			array2[25] = 94;
			array2[25] = 118;
			array2[25] = 131;
			array2[26] = 136;
			array2[26] = 102;
			array2[26] = 121;
			array2[27] = 150;
			array2[27] = 84;
			array2[27] = 102;
			array2[27] = 10;
			array2[28] = 141;
			array2[28] = 104;
			array2[28] = 120;
			array2[28] = 117;
			array2[29] = 145;
			array2[29] = 144;
			array2[29] = 85;
			array2[29] = 7;
			array2[30] = 84;
			array2[30] = 178;
			array2[30] = 157;
			array2[30] = 173;
			array2[30] = 88;
			array2[30] = 212;
			array2[31] = 75;
			array2[31] = 153;
			array2[31] = 139;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 126;
			array3[0] = 121;
			array3[0] = 222;
			array3[1] = 29;
			array3[1] = 163;
			array3[1] = 167;
			array3[1] = 120;
			array3[1] = 234;
			array3[2] = 31;
			array3[2] = 60;
			array3[2] = 72;
			array3[3] = 145;
			array3[3] = 150;
			array3[3] = 247;
			array3[4] = 74;
			array3[4] = 165;
			array3[4] = 164;
			array3[5] = 117;
			array3[5] = 104;
			array3[5] = 113;
			array3[5] = 136;
			array3[5] = 224;
			array3[6] = 227;
			array3[6] = 157;
			array3[6] = 222;
			array3[6] = 166;
			array3[6] = 45;
			array3[7] = 129;
			array3[7] = 93;
			array3[7] = 118;
			array3[7] = 175;
			array3[7] = 89;
			array3[7] = 24;
			array3[8] = 103;
			array3[8] = 136;
			array3[8] = 170;
			array3[8] = 142;
			array3[9] = 156;
			array3[9] = 85;
			array3[9] = 55;
			array3[9] = 167;
			array3[9] = 196;
			array3[9] = 179;
			array3[10] = 104;
			array3[10] = 92;
			array3[10] = 147;
			array3[10] = 85;
			array3[10] = 219;
			array3[11] = 170;
			array3[11] = 192;
			array3[11] = 121;
			array3[11] = 140;
			array3[11] = 27;
			array3[12] = 122;
			array3[12] = 94;
			array3[12] = 108;
			array3[12] = 155;
			array3[13] = 75;
			array3[13] = 122;
			array3[13] = 49;
			array3[13] = 86;
			array3[13] = 120;
			array3[13] = 112;
			array3[14] = 156;
			array3[14] = 126;
			array3[14] = 90;
			array3[14] = 153;
			array3[14] = 170;
			array3[14] = 100;
			array3[15] = 205;
			array3[15] = 156;
			array3[15] = 212;
			array3[15] = 112;
			array3[15] = 136;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class14).Assembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array4[1] = publicKeyToken[0];
				array4[3] = publicKeyToken[1];
				array4[5] = publicKeyToken[2];
				array4[7] = publicKeyToken[3];
				array4[9] = publicKeyToken[4];
				array4[11] = publicKeyToken[5];
				array4[13] = publicKeyToken[6];
				array4[15] = publicKeyToken[7];
			}
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateDecryptor(rgbKey, array4);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			Class14.byte_3 = memoryStream.ToArray();
			if (Class14.byte_3.Length > 0)
			{
				Class14.string_0 = new string[Class14.byte_3.Length / 4 + 1];
				Class14.int_0 = new int[Class14.byte_3.Length / 4 + 1];
			}
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
			Assembly assembly = typeof(Class14).Assembly;
			Class14.int_2 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt32();
			Class14.long_0 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
		}
		int num = int_3 / 4;
		if (Class14.int_0[num] > 0)
		{
			return ((string[])Class14.string_0)[Class14.int_0[num]];
		}
		int num2 = BitConverter.ToInt32(Class14.byte_3, int_3);
		if (Class14.intptr_0 == IntPtr.Zero)
		{
			Class14.intptr_0 = Class14.OpenProcess(16u, 1, (uint)Process.GetCurrentProcess().Id);
		}
		byte[] array5 = new byte[4];
		if (IntPtr.Size == 4)
		{
			Class14.ReadProcessMemory(Class14.intptr_0, new IntPtr(Class14.int_2 + num2), array5, 4u, out Class14.intptr_1);
		}
		else
		{
			Class14.ReadProcessMemory(Class14.intptr_0, new IntPtr(Class14.long_0 + (long)num2), array5, 4u, out Class14.intptr_1);
		}
		int num3 = BitConverter.ToInt32(array5, 0);
		array5 = new byte[num3];
		if (IntPtr.Size == 4)
		{
			Class14.ReadProcessMemory(Class14.intptr_0, new IntPtr(Class14.int_2 + num2 + 4), array5, Convert.ToUInt32(num3), out Class14.intptr_1);
		}
		else
		{
			Class14.ReadProcessMemory(Class14.intptr_0, new IntPtr(Class14.long_0 + (long)num2 + 4L), array5, Convert.ToUInt32(num3), out Class14.intptr_1);
		}
		byte[] array6 = Class14.smethod_7(array5);
		string @string = Encoding.Unicode.GetString(array6, 0, array6.Length);
		Class14.int_0[num] = Class14.int_1;
		((string[])Class14.string_0)[Class14.int_1] = @string;
		Class14.int_1++;
		return @string;
	}

	internal static string smethod_3(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	static void smethod_4()
	{
		if (!Class14.bool_0)
		{
			Class14.bool_0 = true;
			BinaryReader binaryReader = new BinaryReader(typeof(Class14).Assembly.GetManifestResourceStream("f3c46ed4-ca21-4eb8-b5e5-759b2c563d8c"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 126;
			array2[0] = 195;
			array2[0] = 42;
			array2[0] = 92;
			array2[1] = 144;
			array2[1] = 99;
			array2[1] = 44;
			array2[2] = 138;
			array2[2] = 135;
			array2[2] = 150;
			array2[2] = 148;
			array2[2] = 87;
			array2[2] = 41;
			array2[3] = 136;
			array2[3] = 136;
			array2[3] = 41;
			array2[4] = 104;
			array2[4] = 190;
			array2[4] = 161;
			array2[5] = 103;
			array2[5] = 116;
			array2[5] = 167;
			array2[5] = 179;
			array2[5] = 115;
			array2[5] = 15;
			array2[6] = 52;
			array2[6] = 86;
			array2[6] = 15;
			array2[7] = 110;
			array2[7] = 146;
			array2[7] = 84;
			array2[7] = 250;
			array2[8] = 121;
			array2[8] = 128;
			array2[8] = 86;
			array2[8] = 128;
			array2[8] = 130;
			array2[8] = 210;
			array2[9] = 85;
			array2[9] = 165;
			array2[9] = 104;
			array2[10] = 160;
			array2[10] = 220;
			array2[10] = 124;
			array2[10] = 203;
			array2[10] = 162;
			array2[11] = 75;
			array2[11] = 118;
			array2[11] = 96;
			array2[11] = 158;
			array2[11] = 89;
			array2[12] = 85;
			array2[12] = 101;
			array2[12] = 154;
			array2[12] = 123;
			array2[12] = 184;
			array2[13] = 84;
			array2[13] = 147;
			array2[13] = 88;
			array2[13] = 34;
			array2[13] = 73;
			array2[13] = 238;
			array2[14] = 72;
			array2[14] = 57;
			array2[14] = 198;
			array2[14] = 142;
			array2[14] = 106;
			array2[14] = 34;
			array2[15] = 153;
			array2[15] = 168;
			array2[15] = 106;
			array2[15] = 177;
			array2[15] = 183;
			array2[16] = 101;
			array2[16] = 178;
			array2[16] = 114;
			array2[16] = 164;
			array2[16] = 125;
			array2[16] = 119;
			array2[17] = 138;
			array2[17] = 61;
			array2[17] = 207;
			array2[17] = 149;
			array2[17] = 111;
			array2[17] = 164;
			array2[18] = 118;
			array2[18] = 122;
			array2[18] = 147;
			array2[18] = 10;
			array2[18] = 110;
			array2[18] = 145;
			array2[19] = 108;
			array2[19] = 136;
			array2[19] = 142;
			array2[19] = 209;
			array2[19] = 76;
			array2[20] = 184;
			array2[20] = 138;
			array2[20] = 159;
			array2[20] = 8;
			array2[21] = 102;
			array2[21] = 91;
			array2[21] = 176;
			array2[21] = 104;
			array2[21] = 138;
			array2[22] = 114;
			array2[22] = 84;
			array2[22] = 146;
			array2[22] = 122;
			array2[23] = 97;
			array2[23] = 68;
			array2[23] = 108;
			array2[23] = 120;
			array2[23] = 120;
			array2[23] = 85;
			array2[24] = 116;
			array2[24] = 102;
			array2[24] = 96;
			array2[24] = 172;
			array2[25] = 133;
			array2[25] = 34;
			array2[25] = 136;
			array2[25] = 179;
			array2[26] = 153;
			array2[26] = 128;
			array2[26] = 230;
			array2[27] = 147;
			array2[27] = 105;
			array2[27] = 163;
			array2[27] = 132;
			array2[27] = 111;
			array2[28] = 101;
			array2[28] = 143;
			array2[28] = 111;
			array2[28] = 100;
			array2[28] = 164;
			array2[28] = 212;
			array2[29] = 151;
			array2[29] = 86;
			array2[29] = 78;
			array2[29] = 141;
			array2[29] = 112;
			array2[29] = 117;
			array2[30] = 101;
			array2[30] = 87;
			array2[30] = 137;
			array2[30] = 120;
			array2[30] = 238;
			array2[31] = 110;
			array2[31] = 170;
			array2[31] = 204;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 126;
			array3[0] = 88;
			array3[0] = 25;
			array3[1] = 40;
			array3[1] = 172;
			array3[1] = 113;
			array3[2] = 165;
			array3[2] = 102;
			array3[2] = 126;
			array3[3] = 31;
			array3[3] = 178;
			array3[3] = 164;
			array3[3] = 113;
			array3[3] = 98;
			array3[3] = 123;
			array3[4] = 134;
			array3[4] = 153;
			array3[4] = 200;
			array3[4] = 25;
			array3[4] = 149;
			array3[4] = 134;
			array3[5] = 102;
			array3[5] = 186;
			array3[5] = 112;
			array3[5] = 70;
			array3[5] = 163;
			array3[5] = 77;
			array3[6] = 161;
			array3[6] = 115;
			array3[6] = 140;
			array3[6] = 117;
			array3[7] = 165;
			array3[7] = 132;
			array3[7] = 159;
			array3[7] = 29;
			array3[8] = 166;
			array3[8] = 54;
			array3[8] = 124;
			array3[8] = 104;
			array3[8] = 254;
			array3[9] = 148;
			array3[9] = 145;
			array3[9] = 190;
			array3[9] = 85;
			array3[9] = 80;
			array3[10] = 91;
			array3[10] = 151;
			array3[10] = 144;
			array3[10] = 149;
			array3[11] = 156;
			array3[11] = 151;
			array3[11] = 162;
			array3[11] = 126;
			array3[11] = 250;
			array3[12] = 116;
			array3[12] = 205;
			array3[12] = 108;
			array3[12] = 138;
			array3[12] = 100;
			array3[13] = 100;
			array3[13] = 145;
			array3[13] = 70;
			array3[13] = 101;
			array3[14] = 98;
			array3[14] = 149;
			array3[14] = 108;
			array3[14] = 133;
			array3[14] = 243;
			array3[15] = 106;
			array3[15] = 88;
			array3[15] = 141;
			array3[15] = 87;
			array3[15] = 159;
			array3[15] = 143;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class14).Assembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array4[1] = publicKeyToken[0];
				array4[3] = publicKeyToken[1];
				array4[5] = publicKeyToken[2];
				array4[7] = publicKeyToken[3];
				array4[9] = publicKeyToken[4];
				array4[11] = publicKeyToken[5];
				array4[13] = publicKeyToken[6];
				array4[15] = publicKeyToken[7];
			}
			ICryptoTransform transform = new RijndaelManaged
			{
				Mode = CipherMode.CBC
			}.CreateDecryptor(rgbKey, array4);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte[] buffer = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
			binaryReader = new BinaryReader(new MemoryStream(buffer));
			binaryReader.BaseStream.Position = 0L;
			IntPtr intptr_ = IntPtr.Zero;
			Assembly assembly = typeof(Class14).Assembly;
			intptr_ = Class14.OpenProcess(56u, 1, (uint)Process.GetCurrentProcess().Id);
			Class14.int_2 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt32();
			Class14.long_0 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
			IntPtr zero = IntPtr.Zero;
			int num = binaryReader.ReadInt32();
			binaryReader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				if (IntPtr.Size == 4)
				{
					Class14.WriteProcessMemory(intptr_, new IntPtr(Class14.int_2 + binaryReader.ReadInt32()), BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out zero);
				}
				else
				{
					Class14.WriteProcessMemory(intptr_, new IntPtr(Class14.long_0 + (long)binaryReader.ReadInt32()), BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out zero);
				}
			}
			while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L)
			{
				int num2 = binaryReader.ReadInt32();
				int num3 = binaryReader.ReadInt32();
				int num4 = binaryReader.ReadInt32();
				byte[] byte_ = binaryReader.ReadBytes(num4);
				if (num3 > 0)
				{
					Class14.sortedList_0[num3] = num2;
				}
				if (IntPtr.Size == 4)
				{
					Class14.WriteProcessMemory(intptr_, new IntPtr(Class14.int_2 + num2), byte_, Convert.ToUInt32(num4), out zero);
				}
				else
				{
					Class14.WriteProcessMemory(intptr_, new IntPtr(Class14.long_0 + (long)num2), byte_, Convert.ToUInt32(num4), out zero);
				}
			}
			int metadataToken = new StackFrame(1).GetMethod().MetadataToken;
			object obj = Class14.sortedList_0[metadataToken];
			if (obj != null)
			{
				if (IntPtr.Size == 4)
				{
					Class14.WriteProcessMemory(intptr_, new IntPtr(Class14.int_2 + (int)obj), new byte[]
					{
						255,
						255,
						255,
						255
					}, 4u, out zero);
				}
				else
				{
					Class14.WriteProcessMemory(intptr_, new IntPtr(Class14.long_0 + (long)((int)obj)), new byte[]
					{
						255,
						255,
						255,
						255
					}, 4u, out zero);
				}
				Class14.sortedList_0.Remove(metadataToken);
			}
			StackFrame stackFrame = new StackFrame(2);
			if (stackFrame.GetMethod() != null)
			{
				int metadataToken2 = stackFrame.GetMethod().MetadataToken;
				object obj2 = Class14.sortedList_0[metadataToken2];
				if (obj2 != null)
				{
					if (IntPtr.Size == 4)
					{
						Class14.WriteProcessMemory(intptr_, new IntPtr(Class14.int_2 + (int)obj2), new byte[]
						{
							255,
							255,
							255,
							255
						}, 4u, out zero);
					}
					else
					{
						Class14.WriteProcessMemory(intptr_, new IntPtr(Class14.long_0 + (long)((int)obj2)), new byte[]
						{
							255,
							255,
							255,
							255
						}, 4u, out zero);
					}
					Class14.sortedList_0.Remove(metadataToken2);
				}
			}
			Class14.CloseHandle(intptr_);
			return;
		}
		StackFrame stackFrame2 = new StackFrame(1);
		int metadataToken3 = stackFrame2.GetMethod().MetadataToken;
		object obj3 = Class14.sortedList_0[metadataToken3];
		if (obj3 != null)
		{
			IntPtr intptr_2 = IntPtr.Zero;
			intptr_2 = Class14.OpenProcess(56u, 1, (uint)Process.GetCurrentProcess().Id);
			IntPtr zero2 = IntPtr.Zero;
			if (IntPtr.Size == 4)
			{
				Class14.WriteProcessMemory(intptr_2, new IntPtr(Class14.int_2 + (int)obj3), new byte[]
				{
					255,
					255,
					255,
					255
				}, 4u, out zero2);
			}
			else
			{
				Class14.WriteProcessMemory(intptr_2, new IntPtr(Class14.long_0 + (long)((int)obj3)), new byte[]
				{
					255,
					255,
					255,
					255
				}, 4u, out zero2);
			}
			Class14.sortedList_0.Remove(metadataToken3);
			Class14.CloseHandle(intptr_2);
		}
	}

	internal static object smethod_5(object object_0)
	{
		object result;
		try
		{
			result = object_0.GetType().GetProperty("Location").GetValue(object_0, new object[0]).ToString();
		}
		catch
		{
			result = "";
		}
		return result;
	}

	[DllImport("kernel32.dll")]
	private static extern int WriteProcessMemory(IntPtr intptr_2, IntPtr intptr_3, [In] [Out] byte[] byte_4, uint uint_0, out IntPtr intptr_4);

	[DllImport("kernel32.dll")]
	private static extern int ReadProcessMemory(IntPtr intptr_2, IntPtr intptr_3, [In] [Out] byte[] byte_4, uint uint_0, out IntPtr intptr_4);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_0, int int_3, uint uint_1);

	[DllImport("kernel32.dll")]
	private static extern int CloseHandle(IntPtr intptr_2);

	private static byte[] smethod_6(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			long length = fileStream.Length;
			int i = (int)length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	private static byte[] smethod_7(byte[] byte_4)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = new byte[]
		{
			173,
			252,
			249,
			34,
			206,
			132,
			37,
			109,
			113,
			148,
			24,
			40,
			128,
			101,
			148,
			26,
			50,
			53,
			56,
			156,
			220,
			29,
			181,
			38,
			18,
			105,
			32,
			76,
			23,
			54,
			177,
			3
		};
		rijndael.IV = new byte[]
		{
			47,
			50,
			96,
			233,
			111,
			135,
			254,
			42,
			193,
			86,
			233,
			212,
			46,
			97,
			105,
			63
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_4, 0, byte_4.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	private byte[] method_0()
	{
		return null;
	}

	private byte[] method_1()
	{
		return null;
	}

	private byte[] method_2()
	{
		return null;
	}

	private byte[] method_3()
	{
		return null;
	}

	private byte[] method_4()
	{
		return null;
	}

	private byte[] method_5()
	{
		return null;
	}

	internal byte[] method_6()
	{
		return null;
	}

	internal byte[] method_7()
	{
		return null;
	}

	internal static string smethod_8(string string_1, string string_2)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_1);
		byte[] array = bytes;
		byte[] key = new byte[]
		{
			82,
			102,
			104,
			110,
			32,
			77,
			24,
			34,
			118,
			181,
			51,
			17,
			18,
			51,
			12,
			109,
			10,
			32,
			77,
			24,
			34,
			158,
			161,
			41,
			97,
			28,
			118,
			181,
			5,
			25,
			1,
			88
		};
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] iV = mD.ComputeHash(Encoding.Unicode.GetBytes(string_2));
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = key;
		rijndael.IV = iV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
		return Convert.ToBase64String(memoryStream.ToArray());
	}
}
