using System;
using System.Collections.Generic;
using System.Text;

namespace MultiMonitorHelper.Enum
{
    [Flags]
    public enum DisplayConfigModeInfoType : uint
    {
        Zero = 0,

        Source = 1,
        Target = 2,
    }
}
