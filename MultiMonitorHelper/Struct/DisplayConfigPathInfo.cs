using MultiMonitorHelper.Enum;
using System.Runtime.InteropServices;


namespace MultiMonitorHelper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigPathInfo
    {
        public DisplayConfigPathSourceInfo sourceInfo;
        public DisplayConfigPathTargetInfo targetInfo;
        public DisplayConfigFlags flags;
    }
}
