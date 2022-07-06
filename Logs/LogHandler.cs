using System;
using WallaShops.Utils;

namespace WallaShops.Common.Logs.BL
{
  public static class LogHandler
  {
    public static void WriteToConsoleIfDebugMode(string message)
    {
      bool isDebugMode = WSGeneralUtils.GetAppSettingsBoolean("DebugMode", "false") || System.Diagnostics.Debugger.IsAttached;

      if (isDebugMode)
      {
        Console.WriteLine(message);
        Console.ReadLine();
      }
    }
  }
}
