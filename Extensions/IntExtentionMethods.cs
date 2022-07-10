using System;

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
}
