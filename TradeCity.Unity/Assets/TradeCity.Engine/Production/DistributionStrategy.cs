using System;
using System.Collections.Generic;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Production
{
    [Serializable]
    public abstract class DistributionStrategy : IDistributionStrategy
    {
        public abstract void Distribute(Resource resource, List<Recipe> recipes);

        public abstract string GetName();

        public static List<IDistributionStrategy> GetAllStrategies()
        {
            return new List<IDistributionStrategy> { new EvenDistributionStrategy() };
        }

        public static void DistributeDefault(Resource resource, List<Recipe> recipes)
        {
            foreach (var recipe in recipes) recipe.AddResource(resource);
        }
    }
}