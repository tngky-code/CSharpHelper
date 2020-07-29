using System.Runtime.InteropServices;

namespace MultiMonitorHelper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LUID
    {
        public uint LowPart;
        public uint HighPart;
    }
}
