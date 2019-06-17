using System;
using System.Runtime.InteropServices;
using Foundation;

namespace Bugly
{
    public enum BuglyLogLevel : ulong
    {
        Silent = 0,
        Error = 1,
        Warn = 2,
        Info = 3,
        Debug = 4,
        Verbose = 5
    }

    static class CFunctions
    {
        // extern void BLYLog (BuglyLogLevel level, NSString *format, ...) __attribute__((format(NSString, 2, 3)));
        [DllImport("__Internal")]
        static extern void BLYLog(BuglyLogLevel level, NSString format, IntPtr varArgs);

        // extern void BLYLogv (BuglyLogLevel level, NSString *format, va_list args) __attribute__((format(NSString, 2, 0)));
        [DllImport("__Internal")]
        static extern unsafe void BLYLogv(BuglyLogLevel level, NSString format, sbyte* args);
    }

}

