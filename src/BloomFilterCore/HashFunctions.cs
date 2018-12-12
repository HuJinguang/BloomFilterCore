/********************************************************************
 * Decompiled from https://www.nuget.org/packages/BloomFilter/ and	*
 * recompiled as .NET Standard.										*
 *																	*
 * Original creator is Graham Henry									*
 ********************************************************************/

namespace BloomFilterCore
{
  public class HashFunctions
  {
    public static int HashString(string s)
    {
      int num1 = 0;
      for (int index = 0; index < s.Length; ++index)
      {
        int num2 = num1 + (int) s[index];
        int num3 = num2 + (num2 << 10);
        num1 = num3 ^ num3 >> 6;
      }
      int num4 = num1;
      int num5 = num4 + (num4 << 3);
      int num6 = num5 ^ num5 >> 11;
      return num6 + (num6 << 15);
    }

    public static int HashInt(int xi)
    {
      uint num1 = (uint) xi;
      int num2 = ~(int) num1 + ((int) num1 << 15);
      int num3 = (int) ((uint) num2 ^ (uint) num2 >> 12);
      int num4 = num3 + (num3 << 2);
      int num5 = (int) (((uint) num4 ^ (uint) num4 >> 4) * 2057U);
      return (int) ((uint) num5 ^ (uint) num5 >> 16);
    }
  }
}
