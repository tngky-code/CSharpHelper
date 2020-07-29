using System.Runtime.InteropServices;

namespace MultiMonitorHelper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigRational
    {
        public uint numerator;
        public uint denominator;
    }
}
