using System;
using System.Collections.Generic;

namespace TradeCity.Engine.Market
{
    [Serializable]
    public struct ItemLog
    {
        private readonly List<double> _virtualLog;
        private readonly List<double> _sellLog;
        private readonly List<int> _buyLog;
    }
}