using System;
using System.Collections.Generic;
using System.Text;

namespace MultiMonitorHelper.Enum
{
    [Flags]
    public enum DisplayConfigFlags : uint
    {
        Zero = 0x0,
        PathActive = 0x00000001
    }
}
