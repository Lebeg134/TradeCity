/**
* @(#) ItemLog.cs
*/
using System;
using System.Collections.Generic;

namespace Lebeg134.Module.MarketNS
{
    [Serializable]
    struct ItemLog
    {
        List<double> virtualLog;
        List<double> sellLog;
        List<int> buyLog;
    }
}
