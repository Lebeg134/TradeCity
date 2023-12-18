using System.Collections.Generic;
using TradeCity.Engine.Production;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Structures.Interfaces
{
    public interface IProducer
    {
        List<Recipe> Recipes { get; }
        //void PutResources(List<Resource> resources);
        //List<Resource> GetProduce();
    }
}