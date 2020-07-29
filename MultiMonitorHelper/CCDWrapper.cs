using System;
using System.Runtime.InteropServices;
using MultiMonitorHelper.Enum;
using MultiMonitorHelper.Struct;

namespace MultiMonitorHelper
{
    public class CCDWrapper
    {
        [DllImport("User32.dll")]
        public static extern StatusCode GetDisplayConfigBufferSizes(
            QueryDisplayFlags flags,
            out int numPathArrayElements,
            out int numModeInfoArrayElements);

        [DllImport("User32.dll")]
        public static extern StatusCode QueryDisplayConfig(
            QueryDisplayFlags flags,
            ref int numPathArrayElements,
            [Out] DisplayConfigPathInfo[] pathInfoArray,
            ref int modeInfoArrayElements,
            [Out] DisplayConfigModeInfo[] modeInfoArray,
            IntPtr topologyId = default(IntPtr)
        );

        [DllImport("User32.dll")]
        public static extern StatusCode QueryDisplayConfig(
            QueryDisplayFlags flags,
            ref int numPathArrayElements,
            [Out] DisplayConfigPathInfo[] pathInfoArray,
            ref int modeInfoArrayElements,
            [Out] DisplayConfigModeInfo[] modeInfoArray,
            out DisplayConfigTopologyId topologyId
        );
    }
}
