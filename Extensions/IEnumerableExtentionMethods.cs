using System;
using System.Collections.Generic;

namespace WallaShops.Utils
{
  public static class IEnumerableExtentionMethods
  {
    public static void ApplyEach<T>(this IEnumerable<T> enumeration, Action<T> action)
    {
      foreach (T item in enumeration)
      {
        action(item);
      }
    }
    
    public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
    {
      return new HashSet<T>(source);
    }
  }
}
