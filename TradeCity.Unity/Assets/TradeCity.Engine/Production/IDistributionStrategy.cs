using System.Collections.Generic;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Production
{
    public interface IDistributionStrategy
    {
        void Distribute(Resource resource, List<Recipe> recipes);
        string GetName();
    }
}
