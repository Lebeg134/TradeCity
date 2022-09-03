using System.Collections.Generic;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Market
{
    public interface ISellable : IEqualityComparer<ISellable>
    {
        double GetValue();
        void SimulatePrice();
        Resource GetNewResource(int amount);
        int GetStock();
    }
}
