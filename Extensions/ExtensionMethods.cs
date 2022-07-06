using System;
using System.Collections.Generic;

namespace WallaShops.Utils
{
  public static class ExtensionMethods
  {
    public static void Times(this int count, Action action)
    {
      for (int i = 0; i < count; i++)
      {
        action();
      }
    }

    public static void ApplyEach<T>(this IEnumerable<T> enumeration, Action<T> action)
    {
      foreach (T item in enumeration)
      {
        action(item);
      }
    }
  }
}
