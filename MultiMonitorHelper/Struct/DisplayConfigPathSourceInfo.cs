using MultiMonitorHelper.Enum;
using System.Runtime.InteropServices;

namespace MultiMonitorHelper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigPathSourceInfo
    {
        public LUID adapterId;
        public uint id;
        public uint modeInfoIdx;

        public DisplayConfigSourceStatus statusFlags;
    }
}
