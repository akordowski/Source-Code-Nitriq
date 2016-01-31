using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class Class0
{
	[Flags]
	private enum Enum0
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

	static Class0()
	{
		Class0.byte_0 = new byte[0];
		Class0.byte_1 = new byte[0];
		Class0.byte_2 = new byte[0];
		Class0.byte_3 = new byte[0];
		Class0.intptr_0 = IntPtr.Zero;
		Class0.intptr_1 = IntPtr.Zero;
		Class0.string_0 = new string[0];
		Class0.int_0 = new int[0];
		Class0.int_1 = 1;
		Class0.bool_0 = false;
		Class0.sortedList_0 = new SortedList();
		Class0.int_2 = 0;
		Class0.long_0 = 0L;
	}

	private void leHifFIJCLsZtKEFfM1i()
	{
	}

	static bool smethod_0(int int_3)
	{
		if (Class0.byte_1.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class0).Assembly.GetManifestResourceStream("d277d053-9168-4e88-bac2-7a30bc5d8083"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 124;
			array2[0] = 200;
			array2[0] = 45;
			array2[0] = 144;
			array2[0] = 155;
			array2[0] = 217;
			array2[1] = 33;
			array2[1] = 128;
			array2[1] = 158;
			array2[1] = 74;
			array2[1] = 137;
			array2[1] = 172;
			array2[2] = 154;
			array2[2] = 129;
			array2[2] = 126;
			array2[2] = 116;
			array2[2] = 66;
			array2[3] = 100;
			array2[3] = 155;
			array2[3] = 138;
			array2[3] = 112;
			array2[4] = 118;
			array2[4] = 96;
			array2[4] = 232;
			array2[5] = 156;
			array2[5] = 105;
			array2[5] = 127;
			array2[5] = 65;
			array2[6] = 135;
			array2[6] = 104;
			array2[6] = 68;
			array2[6] = 130;
			array2[6] = 110;
			array2[6] = 150;
			array2[7] = 69;
			array2[7] = 115;
			array2[7] = 42;
			array2[7] = 236;
			array2[8] = 216;
			array2[8] = 134;
			array2[8] = 220;
			array2[8] = 159;
			array2[9] = 67;
			array2[9] = 109;
			array2[9] = 135;
			array2[9] = 131;
			array2[10] = 177;
			array2[10] = 123;
			array2[10] = 207;
			array2[10] = 98;
			array2[10] = 127;
			array2[11] = 184;
			array2[11] = 136;
			array2[11] = 116;
			array2[11] = 111;
			array2[12] = 164;
			array2[12] = 114;
			array2[12] = 218;
			array2[13] = 107;
			array2[13] = 129;
			array2[13] = 117;
			array2[13] = 212;
			array2[13] = 79;
			array2[13] = 122;
			array2[14] = 124;
			array2[14] = 135;
			array2[14] = 110;
			array2[14] = 85;
			array2[14] = 84;
			array2[14] = 207;
			array2[15] = 150;
			array2[15] = 68;
			array2[15] = 147;
			array2[16] = 54;
			array2[16] = 152;
			array2[16] = 150;
			array2[16] = 54;
			array2[16] = 241;
			array2[17] = 204;
			array2[17] = 48;
			array2[17] = 104;
			array2[17] = 149;
			array2[18] = 130;
			array2[18] = 125;
			array2[18] = 87;
			array2[18] = 98;
			array2[18] = 110;
			array2[18] = 10;
			array2[19] = 132;
			array2[19] = 184;
			array2[19] = 186;
			array2[19] = 12;
			array2[20] = 92;
			array2[20] = 192;
			array2[20] = 206;
			array2[21] = 155;
			array2[21] = 62;
			array2[21] = 164;
			array2[21] = 185;
			array2[21] = 148;
			array2[21] = 38;
			array2[22] = 93;
			array2[22] = 128;
			array2[22] = 200;
			array2[22] = 213;
			array2[22] = 119;
			array2[22] = 78;
			array2[23] = 191;
			array2[23] = 165;
			array2[23] = 75;
			array2[23] = 56;
			array2[23] = 174;
			array2[23] = 68;
			array2[24] = 156;
			array2[24] = 131;
			array2[24] = 181;
			array2[25] = 139;
			array2[25] = 154;
			array2[25] = 36;
			array2[25] = 136;
			array2[25] = 21;
			array2[26] = 126;
			array2[26] = 141;
			array2[26] = 113;
			array2[26] = 151;
			array2[26] = 165;
			array2[27] = 167;
			array2[27] = 126;
			array2[27] = 94;
			array2[27] = 16;
			array2[28] = 130;
			array2[28] = 109;
			array2[28] = 199;
			array2[28] = 140;
			array2[28] = 194;
			array2[29] = 93;
			array2[29] = 117;
			array2[29] = 105;
			array2[29] = 153;
			array2[29] = 69;
			array2[30] = 97;
			array2[30] = 170;
			array2[30] = 125;
			array2[30] = 105;
			array2[30] = 179;
			array2[30] = 148;
			array2[31] = 146;
			array2[31] = 116;
			array2[31] = 87;
			array2[31] = 197;
			array2[31] = 170;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 124;
			array3[0] = 128;
			array3[0] = 210;
			array3[1] = 45;
			array3[1] = 94;
			array3[1] = 159;
			array3[1] = 103;
			array3[1] = 45;
			array3[2] = 151;
			array3[2] = 104;
			array3[2] = 39;
			array3[3] = 59;
			array3[3] = 172;
			array3[3] = 250;
			array3[4] = 96;
			array3[4] = 126;
			array3[4] = 154;
			array3[4] = 57;
			array3[4] = 66;
			array3[5] = 89;
			array3[5] = 109;
			array3[5] = 163;
			array3[6] = 132;
			array3[6] = 170;
			array3[6] = 116;
			array3[6] = 164;
			array3[7] = 73;
			array3[7] = 103;
			array3[7] = 131;
			array3[8] = 93;
			array3[8] = 156;
			array3[8] = 92;
			array3[8] = 140;
			array3[8] = 116;
			array3[8] = 241;
			array3[9] = 106;
			array3[9] = 96;
			array3[9] = 209;
			array3[10] = 118;
			array3[10] = 162;
			array3[10] = 146;
			array3[10] = 243;
			array3[10] = 164;
			array3[10] = 253;
			array3[11] = 146;
			array3[11] = 133;
			array3[11] = 94;
			array3[11] = 4;
			array3[12] = 84;
			array3[12] = 96;
			array3[12] = 106;
			array3[12] = 123;
			array3[12] = 141;
			array3[12] = 137;
			array3[13] = 160;
			array3[13] = 166;
			array3[13] = 136;
			array3[13] = 210;
			array3[13] = 146;
			array3[13] = 233;
			array3[14] = 136;
			array3[14] = 112;
			array3[14] = 149;
			array3[14] = 128;
			array3[14] = 200;
			array3[15] = 164;
			array3[15] = 56;
			array3[15] = 167;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class0).Assembly.GetName().GetPublicKeyToken();
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
			Class0.byte_1 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
		}
		if (Class0.byte_0.Length == 0)
		{
			Class0.byte_0 = Class0.smethod_6(Class0.smethod_5(typeof(Class0).Assembly).ToString());
		}
		int num = 0;
		try
		{
			num = BitConverter.ToInt32(new byte[]
			{
				Class0.byte_1[int_3],
				Class0.byte_1[int_3 + 1],
				Class0.byte_1[int_3 + 2],
				Class0.byte_1[int_3 + 3]
			}, 0);
		}
		catch
		{
		}
		try
		{
			if (Class0.byte_0[num] == 128)
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
		if (Class0.byte_2.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class0).Assembly.GetManifestResourceStream("ee14c771-992d-4267-812a-4097f8ba690b"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 181;
			array2[0] = 188;
			array2[0] = 229;
			array2[1] = 104;
			array2[1] = 149;
			array2[1] = 71;
			array2[2] = 97;
			array2[2] = 158;
			array2[2] = 98;
			array2[3] = 156;
			array2[3] = 61;
			array2[3] = 215;
			array2[3] = 180;
			array2[3] = 87;
			array2[4] = 110;
			array2[4] = 130;
			array2[4] = 89;
			array2[4] = 45;
			array2[4] = 67;
			array2[4] = 129;
			array2[5] = 142;
			array2[5] = 42;
			array2[5] = 106;
			array2[5] = 150;
			array2[5] = 185;
			array2[6] = 169;
			array2[6] = 148;
			array2[6] = 89;
			array2[6] = 62;
			array2[7] = 136;
			array2[7] = 86;
			array2[7] = 196;
			array2[7] = 153;
			array2[7] = 170;
			array2[8] = 88;
			array2[8] = 127;
			array2[8] = 144;
			array2[8] = 132;
			array2[8] = 136;
			array2[9] = 98;
			array2[9] = 106;
			array2[9] = 123;
			array2[9] = 237;
			array2[10] = 106;
			array2[10] = 133;
			array2[10] = 110;
			array2[10] = 149;
			array2[10] = 161;
			array2[11] = 74;
			array2[11] = 112;
			array2[11] = 111;
			array2[11] = 159;
			array2[11] = 131;
			array2[11] = 71;
			array2[12] = 151;
			array2[12] = 84;
			array2[12] = 108;
			array2[12] = 90;
			array2[13] = 132;
			array2[13] = 55;
			array2[13] = 85;
			array2[13] = 152;
			array2[13] = 180;
			array2[13] = 153;
			array2[14] = 146;
			array2[14] = 114;
			array2[14] = 196;
			array2[14] = 105;
			array2[15] = 94;
			array2[15] = 111;
			array2[15] = 75;
			array2[15] = 161;
			array2[15] = 211;
			array2[15] = 113;
			array2[16] = 135;
			array2[16] = 148;
			array2[16] = 123;
			array2[16] = 90;
			array2[16] = 239;
			array2[16] = 99;
			array2[17] = 5;
			array2[17] = 84;
			array2[17] = 206;
			array2[18] = 157;
			array2[18] = 88;
			array2[18] = 249;
			array2[19] = 162;
			array2[19] = 104;
			array2[19] = 56;
			array2[19] = 120;
			array2[19] = 126;
			array2[19] = 215;
			array2[20] = 151;
			array2[20] = 136;
			array2[20] = 37;
			array2[21] = 99;
			array2[21] = 136;
			array2[21] = 116;
			array2[21] = 159;
			array2[21] = 227;
			array2[22] = 189;
			array2[22] = 74;
			array2[22] = 34;
			array2[23] = 156;
			array2[23] = 144;
			array2[23] = 177;
			array2[24] = 199;
			array2[24] = 161;
			array2[24] = 115;
			array2[24] = 103;
			array2[24] = 97;
			array2[24] = 227;
			array2[25] = 169;
			array2[25] = 142;
			array2[25] = 66;
			array2[26] = 115;
			array2[26] = 124;
			array2[26] = 105;
			array2[26] = 155;
			array2[26] = 35;
			array2[27] = 123;
			array2[27] = 110;
			array2[27] = 140;
			array2[27] = 132;
			array2[27] = 207;
			array2[28] = 96;
			array2[28] = 122;
			array2[28] = 137;
			array2[28] = 59;
			array2[29] = 134;
			array2[29] = 137;
			array2[29] = 133;
			array2[29] = 73;
			array2[30] = 151;
			array2[30] = 121;
			array2[30] = 185;
			array2[30] = 155;
			array2[31] = 166;
			array2[31] = 141;
			array2[31] = 49;
			array2[31] = 131;
			array2[31] = 81;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 124;
			array3[0] = 123;
			array3[0] = 81;
			array3[1] = 43;
			array3[1] = 210;
			array3[1] = 100;
			array3[1] = 134;
			array3[2] = 150;
			array3[2] = 176;
			array3[2] = 13;
			array3[3] = 115;
			array3[3] = 136;
			array3[3] = 198;
			array3[3] = 166;
			array3[4] = 199;
			array3[4] = 126;
			array3[4] = 136;
			array3[4] = 112;
			array3[4] = 155;
			array3[4] = 173;
			array3[5] = 183;
			array3[5] = 120;
			array3[5] = 182;
			array3[5] = 35;
			array3[5] = 57;
			array3[6] = 140;
			array3[6] = 84;
			array3[6] = 124;
			array3[6] = 205;
			array3[7] = 232;
			array3[7] = 90;
			array3[7] = 97;
			array3[7] = 104;
			array3[7] = 6;
			array3[7] = 107;
			array3[8] = 202;
			array3[8] = 147;
			array3[8] = 144;
			array3[8] = 65;
			array3[9] = 98;
			array3[9] = 104;
			array3[9] = 194;
			array3[9] = 109;
			array3[9] = 39;
			array3[10] = 163;
			array3[10] = 145;
			array3[10] = 75;
			array3[10] = 68;
			array3[11] = 95;
			array3[11] = 111;
			array3[11] = 219;
			array3[12] = 108;
			array3[12] = 84;
			array3[12] = 59;
			array3[13] = 97;
			array3[13] = 100;
			array3[13] = 40;
			array3[14] = 76;
			array3[14] = 146;
			array3[14] = 154;
			array3[14] = 101;
			array3[14] = 1;
			array3[15] = 165;
			array3[15] = 95;
			array3[15] = 92;
			array3[15] = 163;
			array3[15] = 141;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class0).Assembly.GetName().GetPublicKeyToken();
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
			Class0.byte_2 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
		}
		int num = BitConverter.ToInt32(Class0.byte_2, int_3);
		try
		{
			byte[] array5 = new byte[num];
			Array.Copy(Class0.byte_2, int_3 + 4, array5, 0, num);
			return Encoding.Unicode.GetString(array5, 0, array5.Length);
		}
		catch
		{
		}
		return "";
	}

	static string smethod_2(int int_3)
	{
		if (Class0.byte_3.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class0).Assembly.GetManifestResourceStream("ee14c771-992d-4267-812a-4097f8ba690b"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 181;
			array2[0] = 188;
			array2[0] = 229;
			array2[1] = 104;
			array2[1] = 149;
			array2[1] = 71;
			array2[2] = 97;
			array2[2] = 158;
			array2[2] = 98;
			array2[3] = 156;
			array2[3] = 61;
			array2[3] = 215;
			array2[3] = 180;
			array2[3] = 87;
			array2[4] = 110;
			array2[4] = 130;
			array2[4] = 89;
			array2[4] = 45;
			array2[4] = 67;
			array2[4] = 129;
			array2[5] = 142;
			array2[5] = 42;
			array2[5] = 106;
			array2[5] = 150;
			array2[5] = 185;
			array2[6] = 169;
			array2[6] = 148;
			array2[6] = 89;
			array2[6] = 62;
			array2[7] = 136;
			array2[7] = 86;
			array2[7] = 196;
			array2[7] = 153;
			array2[7] = 170;
			array2[8] = 88;
			array2[8] = 127;
			array2[8] = 144;
			array2[8] = 132;
			array2[8] = 136;
			array2[9] = 98;
			array2[9] = 106;
			array2[9] = 123;
			array2[9] = 237;
			array2[10] = 106;
			array2[10] = 133;
			array2[10] = 110;
			array2[10] = 149;
			array2[10] = 161;
			array2[11] = 74;
			array2[11] = 112;
			array2[11] = 111;
			array2[11] = 159;
			array2[11] = 131;
			array2[11] = 71;
			array2[12] = 151;
			array2[12] = 84;
			array2[12] = 108;
			array2[12] = 90;
			array2[13] = 132;
			array2[13] = 55;
			array2[13] = 85;
			array2[13] = 152;
			array2[13] = 180;
			array2[13] = 153;
			array2[14] = 146;
			array2[14] = 114;
			array2[14] = 196;
			array2[14] = 105;
			array2[15] = 94;
			array2[15] = 111;
			array2[15] = 75;
			array2[15] = 161;
			array2[15] = 211;
			array2[15] = 113;
			array2[16] = 135;
			array2[16] = 148;
			array2[16] = 123;
			array2[16] = 90;
			array2[16] = 239;
			array2[16] = 99;
			array2[17] = 5;
			array2[17] = 84;
			array2[17] = 206;
			array2[18] = 157;
			array2[18] = 88;
			array2[18] = 249;
			array2[19] = 162;
			array2[19] = 104;
			array2[19] = 56;
			array2[19] = 120;
			array2[19] = 126;
			array2[19] = 215;
			array2[20] = 151;
			array2[20] = 136;
			array2[20] = 37;
			array2[21] = 99;
			array2[21] = 136;
			array2[21] = 116;
			array2[21] = 159;
			array2[21] = 227;
			array2[22] = 189;
			array2[22] = 74;
			array2[22] = 34;
			array2[23] = 156;
			array2[23] = 144;
			array2[23] = 177;
			array2[24] = 199;
			array2[24] = 161;
			array2[24] = 115;
			array2[24] = 103;
			array2[24] = 97;
			array2[24] = 227;
			array2[25] = 169;
			array2[25] = 142;
			array2[25] = 66;
			array2[26] = 115;
			array2[26] = 124;
			array2[26] = 105;
			array2[26] = 155;
			array2[26] = 35;
			array2[27] = 123;
			array2[27] = 110;
			array2[27] = 140;
			array2[27] = 132;
			array2[27] = 207;
			array2[28] = 96;
			array2[28] = 122;
			array2[28] = 137;
			array2[28] = 59;
			array2[29] = 134;
			array2[29] = 137;
			array2[29] = 133;
			array2[29] = 73;
			array2[30] = 151;
			array2[30] = 121;
			array2[30] = 185;
			array2[30] = 155;
			array2[31] = 166;
			array2[31] = 141;
			array2[31] = 49;
			array2[31] = 131;
			array2[31] = 81;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 124;
			array3[0] = 123;
			array3[0] = 81;
			array3[1] = 43;
			array3[1] = 210;
			array3[1] = 100;
			array3[1] = 134;
			array3[2] = 150;
			array3[2] = 176;
			array3[2] = 13;
			array3[3] = 115;
			array3[3] = 136;
			array3[3] = 198;
			array3[3] = 166;
			array3[4] = 199;
			array3[4] = 126;
			array3[4] = 136;
			array3[4] = 112;
			array3[4] = 155;
			array3[4] = 173;
			array3[5] = 183;
			array3[5] = 120;
			array3[5] = 182;
			array3[5] = 35;
			array3[5] = 57;
			array3[6] = 140;
			array3[6] = 84;
			array3[6] = 124;
			array3[6] = 205;
			array3[7] = 232;
			array3[7] = 90;
			array3[7] = 97;
			array3[7] = 104;
			array3[7] = 6;
			array3[7] = 107;
			array3[8] = 202;
			array3[8] = 147;
			array3[8] = 144;
			array3[8] = 65;
			array3[9] = 98;
			array3[9] = 104;
			array3[9] = 194;
			array3[9] = 109;
			array3[9] = 39;
			array3[10] = 163;
			array3[10] = 145;
			array3[10] = 75;
			array3[10] = 68;
			array3[11] = 95;
			array3[11] = 111;
			array3[11] = 219;
			array3[12] = 108;
			array3[12] = 84;
			array3[12] = 59;
			array3[13] = 97;
			array3[13] = 100;
			array3[13] = 40;
			array3[14] = 76;
			array3[14] = 146;
			array3[14] = 154;
			array3[14] = 101;
			array3[14] = 1;
			array3[15] = 165;
			array3[15] = 95;
			array3[15] = 92;
			array3[15] = 163;
			array3[15] = 141;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class0).Assembly.GetName().GetPublicKeyToken();
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
			Class0.byte_3 = memoryStream.ToArray();
			if (Class0.byte_3.Length > 0)
			{
				Class0.string_0 = new string[Class0.byte_3.Length / 4 + 1];
				Class0.int_0 = new int[Class0.byte_3.Length / 4 + 1];
			}
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
			Assembly assembly = typeof(Class0).Assembly;
			Class0.int_2 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt32();
			Class0.long_0 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
		}
		int num = int_3 / 4;
		if (Class0.int_0[num] > 0)
		{
			return ((string[])Class0.string_0)[Class0.int_0[num]];
		}
		int num2 = BitConverter.ToInt32(Class0.byte_3, int_3);
		if (Class0.intptr_0 == IntPtr.Zero)
		{
			Class0.intptr_0 = Class0.OpenProcess(16u, 1, (uint)Process.GetCurrentProcess().Id);
		}
		byte[] array5 = new byte[4];
		if (IntPtr.Size == 4)
		{
			Class0.ReadProcessMemory(Class0.intptr_0, new IntPtr(Class0.int_2 + num2), array5, 4u, out Class0.intptr_1);
		}
		else
		{
			Class0.ReadProcessMemory(Class0.intptr_0, new IntPtr(Class0.long_0 + (long)num2), array5, 4u, out Class0.intptr_1);
		}
		int num3 = BitConverter.ToInt32(array5, 0);
		array5 = new byte[num3];
		if (IntPtr.Size == 4)
		{
			Class0.ReadProcessMemory(Class0.intptr_0, new IntPtr(Class0.int_2 + num2 + 4), array5, Convert.ToUInt32(num3), out Class0.intptr_1);
		}
		else
		{
			Class0.ReadProcessMemory(Class0.intptr_0, new IntPtr(Class0.long_0 + (long)num2 + 4L), array5, Convert.ToUInt32(num3), out Class0.intptr_1);
		}
		byte[] array6 = Class0.smethod_7(array5);
		string @string = Encoding.Unicode.GetString(array6, 0, array6.Length);
		Class0.int_0[num] = Class0.int_1;
		((string[])Class0.string_0)[Class0.int_1] = @string;
		Class0.int_1++;
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
		if (!Class0.bool_0)
		{
			Class0.bool_0 = true;
			BinaryReader binaryReader = new BinaryReader(typeof(Class0).Assembly.GetManifestResourceStream("17821e8f-b9b6-4f35-849b-254960e63287"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 124;
			array2[0] = 141;
			array2[0] = 96;
			array2[0] = 197;
			array2[1] = 156;
			array2[1] = 149;
			array2[1] = 100;
			array2[1] = 129;
			array2[1] = 127;
			array2[2] = 166;
			array2[2] = 18;
			array2[2] = 140;
			array2[2] = 92;
			array2[2] = 173;
			array2[2] = 159;
			array2[3] = 122;
			array2[3] = 54;
			array2[3] = 21;
			array2[3] = 114;
			array2[3] = 90;
			array2[3] = 116;
			array2[4] = 195;
			array2[4] = 169;
			array2[4] = 51;
			array2[4] = 77;
			array2[4] = 184;
			array2[4] = 167;
			array2[5] = 127;
			array2[5] = 120;
			array2[5] = 101;
			array2[5] = 254;
			array2[6] = 163;
			array2[6] = 176;
			array2[6] = 144;
			array2[6] = 160;
			array2[6] = 110;
			array2[7] = 51;
			array2[7] = 155;
			array2[7] = 84;
			array2[7] = 163;
			array2[8] = 104;
			array2[8] = 101;
			array2[8] = 130;
			array2[8] = 100;
			array2[8] = 175;
			array2[9] = 206;
			array2[9] = 116;
			array2[9] = 75;
			array2[9] = 147;
			array2[9] = 162;
			array2[9] = 170;
			array2[10] = 162;
			array2[10] = 200;
			array2[10] = 242;
			array2[11] = 158;
			array2[11] = 174;
			array2[11] = 53;
			array2[12] = 160;
			array2[12] = 116;
			array2[12] = 170;
			array2[12] = 150;
			array2[13] = 88;
			array2[13] = 89;
			array2[13] = 215;
			array2[14] = 142;
			array2[14] = 153;
			array2[14] = 164;
			array2[14] = 127;
			array2[14] = 130;
			array2[14] = 172;
			array2[15] = 117;
			array2[15] = 95;
			array2[15] = 172;
			array2[15] = 93;
			array2[16] = 112;
			array2[16] = 148;
			array2[16] = 158;
			array2[16] = 86;
			array2[16] = 252;
			array2[17] = 109;
			array2[17] = 149;
			array2[17] = 82;
			array2[17] = 53;
			array2[18] = 129;
			array2[18] = 154;
			array2[18] = 197;
			array2[18] = 139;
			array2[18] = 151;
			array2[19] = 165;
			array2[19] = 146;
			array2[19] = 144;
			array2[19] = 90;
			array2[19] = 181;
			array2[20] = 111;
			array2[20] = 130;
			array2[20] = 114;
			array2[20] = 67;
			array2[20] = 53;
			array2[21] = 138;
			array2[21] = 75;
			array2[21] = 106;
			array2[21] = 108;
			array2[21] = 208;
			array2[22] = 92;
			array2[22] = 168;
			array2[22] = 94;
			array2[22] = 110;
			array2[22] = 39;
			array2[23] = 124;
			array2[23] = 67;
			array2[23] = 198;
			array2[24] = 117;
			array2[24] = 146;
			array2[24] = 87;
			array2[24] = 190;
			array2[24] = 106;
			array2[24] = 17;
			array2[25] = 7;
			array2[25] = 109;
			array2[25] = 63;
			array2[25] = 195;
			array2[25] = 105;
			array2[26] = 110;
			array2[26] = 84;
			array2[26] = 25;
			array2[27] = 117;
			array2[27] = 103;
			array2[27] = 119;
			array2[27] = 11;
			array2[28] = 133;
			array2[28] = 72;
			array2[28] = 108;
			array2[28] = 110;
			array2[29] = 151;
			array2[29] = 130;
			array2[29] = 181;
			array2[29] = 147;
			array2[29] = 96;
			array2[29] = 205;
			array2[30] = 118;
			array2[30] = 116;
			array2[30] = 96;
			array2[30] = 197;
			array2[31] = 170;
			array2[31] = 33;
			array2[31] = 124;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 124;
			array3[0] = 144;
			array3[0] = 56;
			array3[1] = 55;
			array3[1] = 97;
			array3[1] = 90;
			array3[1] = 145;
			array3[1] = 186;
			array3[2] = 224;
			array3[2] = 129;
			array3[2] = 95;
			array3[3] = 160;
			array3[3] = 146;
			array3[3] = 77;
			array3[3] = 211;
			array3[3] = 106;
			array3[3] = 243;
			array3[4] = 141;
			array3[4] = 163;
			array3[4] = 169;
			array3[5] = 144;
			array3[5] = 114;
			array3[5] = 114;
			array3[5] = 110;
			array3[5] = 139;
			array3[5] = 243;
			array3[6] = 102;
			array3[6] = 132;
			array3[6] = 157;
			array3[7] = 87;
			array3[7] = 169;
			array3[7] = 204;
			array3[7] = 132;
			array3[7] = 167;
			array3[8] = 96;
			array3[8] = 78;
			array3[8] = 223;
			array3[8] = 124;
			array3[9] = 110;
			array3[9] = 165;
			array3[9] = 137;
			array3[9] = 95;
			array3[9] = 97;
			array3[10] = 150;
			array3[10] = 144;
			array3[10] = 88;
			array3[10] = 60;
			array3[11] = 136;
			array3[11] = 127;
			array3[11] = 163;
			array3[11] = 92;
			array3[11] = 86;
			array3[11] = 91;
			array3[12] = 76;
			array3[12] = 130;
			array3[12] = 88;
			array3[12] = 163;
			array3[12] = 29;
			array3[13] = 222;
			array3[13] = 130;
			array3[13] = 148;
			array3[13] = 164;
			array3[13] = 100;
			array3[13] = 46;
			array3[14] = 118;
			array3[14] = 151;
			array3[14] = 150;
			array3[14] = 32;
			array3[15] = 211;
			array3[15] = 154;
			array3[15] = 166;
			array3[15] = 126;
			array3[15] = 129;
			array3[15] = 232;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class0).Assembly.GetName().GetPublicKeyToken();
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
			Assembly assembly = typeof(Class0).Assembly;
			intptr_ = Class0.OpenProcess(56u, 1, (uint)Process.GetCurrentProcess().Id);
			Class0.int_2 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt32();
			Class0.long_0 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
			IntPtr zero = IntPtr.Zero;
			int num = binaryReader.ReadInt32();
			binaryReader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				if (IntPtr.Size == 4)
				{
					Class0.WriteProcessMemory(intptr_, new IntPtr(Class0.int_2 + binaryReader.ReadInt32()), BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out zero);
				}
				else
				{
					Class0.WriteProcessMemory(intptr_, new IntPtr(Class0.long_0 + (long)binaryReader.ReadInt32()), BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out zero);
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
					Class0.sortedList_0[num3] = num2;
				}
				if (IntPtr.Size == 4)
				{
					Class0.WriteProcessMemory(intptr_, new IntPtr(Class0.int_2 + num2), byte_, Convert.ToUInt32(num4), out zero);
				}
				else
				{
					Class0.WriteProcessMemory(intptr_, new IntPtr(Class0.long_0 + (long)num2), byte_, Convert.ToUInt32(num4), out zero);
				}
			}
			int metadataToken = new StackFrame(1).GetMethod().MetadataToken;
			object obj = Class0.sortedList_0[metadataToken];
			if (obj != null)
			{
				if (IntPtr.Size == 4)
				{
					Class0.WriteProcessMemory(intptr_, new IntPtr(Class0.int_2 + (int)obj), new byte[]
					{
						255,
						255,
						255,
						255
					}, 4u, out zero);
				}
				else
				{
					Class0.WriteProcessMemory(intptr_, new IntPtr(Class0.long_0 + (long)((int)obj)), new byte[]
					{
						255,
						255,
						255,
						255
					}, 4u, out zero);
				}
				Class0.sortedList_0.Remove(metadataToken);
			}
			StackFrame stackFrame = new StackFrame(2);
			if (stackFrame.GetMethod() != null)
			{
				int metadataToken2 = stackFrame.GetMethod().MetadataToken;
				object obj2 = Class0.sortedList_0[metadataToken2];
				if (obj2 != null)
				{
					if (IntPtr.Size == 4)
					{
						Class0.WriteProcessMemory(intptr_, new IntPtr(Class0.int_2 + (int)obj2), new byte[]
						{
							255,
							255,
							255,
							255
						}, 4u, out zero);
					}
					else
					{
						Class0.WriteProcessMemory(intptr_, new IntPtr(Class0.long_0 + (long)((int)obj2)), new byte[]
						{
							255,
							255,
							255,
							255
						}, 4u, out zero);
					}
					Class0.sortedList_0.Remove(metadataToken2);
				}
			}
			Class0.CloseHandle(intptr_);
			return;
		}
		StackFrame stackFrame2 = new StackFrame(1);
		int metadataToken3 = stackFrame2.GetMethod().MetadataToken;
		object obj3 = Class0.sortedList_0[metadataToken3];
		if (obj3 != null)
		{
			IntPtr intptr_2 = IntPtr.Zero;
			intptr_2 = Class0.OpenProcess(56u, 1, (uint)Process.GetCurrentProcess().Id);
			IntPtr zero2 = IntPtr.Zero;
			if (IntPtr.Size == 4)
			{
				Class0.WriteProcessMemory(intptr_2, new IntPtr(Class0.int_2 + (int)obj3), new byte[]
				{
					255,
					255,
					255,
					255
				}, 4u, out zero2);
			}
			else
			{
				Class0.WriteProcessMemory(intptr_2, new IntPtr(Class0.long_0 + (long)((int)obj3)), new byte[]
				{
					255,
					255,
					255,
					255
				}, 4u, out zero2);
			}
			Class0.sortedList_0.Remove(metadataToken3);
			Class0.CloseHandle(intptr_2);
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
			182,
			201,
			146,
			182,
			61,
			136,
			83,
			112,
			241,
			194,
			50,
			87,
			154,
			55,
			93,
			111,
			23,
			57,
			63,
			142,
			19,
			225,
			159,
			165,
			87,
			9,
			117,
			83,
			52,
			191,
			25,
			137
		};
		rijndael.IV = new byte[]
		{
			50,
			47,
			125,
			246,
			49,
			149,
			189,
			55,
			155,
			187,
			170,
			199,
			72,
			136,
			41,
			92
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
