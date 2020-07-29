using MultiMonitorHelper.Enum;
using MultiMonitorHelper.Struct;
using System;

namespace MultiMonitorHelper
{
    public class DisplayModelHelper
    {
        public static DisplayConfigTopologyId GetCurrentMode(QueryDisplayFlags pathType= QueryDisplayFlags.DatabaseCurrent)
        {
            DisplayConfigTopologyId topologyId = DisplayConfigTopologyId.Zero;
            int numPathArrayElements;
            int numModeInfoArrayElements;

            var status = CCDWrapper.GetDisplayConfigBufferSizes(
                pathType,
                out numPathArrayElements,
                out numModeInfoArrayElements);

            if (status != StatusCode.Success)
            {
                // TODO; POSSIBLY HANDLE SOME OF THE CASES.
                var reason = string.Format("GetDisplayConfigBufferSizesFailed() failed. Status: {0}", status);
                throw new Exception(reason);
            }

            var pathInfoArray = new DisplayConfigPathInfo[numPathArrayElements];
            var modeInfoArray = new DisplayConfigModeInfo[numModeInfoArrayElements];

            var queryDisplayStatus = pathType == QueryDisplayFlags.DatabaseCurrent ?
                CCDWrapper.QueryDisplayConfig(
                pathType,
                ref numPathArrayElements, pathInfoArray,
                ref numModeInfoArrayElements, modeInfoArray, out topologyId) :
                CCDWrapper.QueryDisplayConfig(
                pathType,
                ref numPathArrayElements, pathInfoArray,
                ref numModeInfoArrayElements, modeInfoArray);

            if (queryDisplayStatus != StatusCode.Success)
            {
                // TODO; POSSIBLY HANDLE SOME OF THE CASES.
                var reason = string.Format("QueryDisplayConfig() failed. Status: {0}", queryDisplayStatus);
                throw new Exception(reason);
            }

            return topologyId;
        }
    }
}
