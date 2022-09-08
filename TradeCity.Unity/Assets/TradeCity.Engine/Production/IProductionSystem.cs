using System.Collections.Generic;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Production
{
    public interface IProductionSystem
    {
        void Produce(List<IProducer> producers);
    }
}