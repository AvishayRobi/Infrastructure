using System;

namespace WallaShops.Utils
{
  public static class IntExtensionMethods
  {
    public static void Times(this int count, Action action)
    {
      for (int i = 0; i < count; i++)
      {
        action();
      }
    }
}
