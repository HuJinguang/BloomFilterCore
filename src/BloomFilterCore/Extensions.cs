/********************************************************************
 * Decompiled from https://www.nuget.org/packages/BloomFilter/ and	*
 * recompiled as .NET Standard.										*
 *																	*
 * Original creator is Graham Henry									*
 ********************************************************************/

using System;
using System.Collections;

namespace BloomFilterCore
{
  internal static class Ext
  {
    internal static bool GetValueFromHash(this BitArray THIS, int hash)
    {
      return THIS.Get(Math.Abs(hash) % THIS.Length);
    }

    internal static void SetValueFromHash(this BitArray THIS, int hash)
    {
      THIS.Set(Math.Abs(hash) % THIS.Length, true);
    }
  }
}
