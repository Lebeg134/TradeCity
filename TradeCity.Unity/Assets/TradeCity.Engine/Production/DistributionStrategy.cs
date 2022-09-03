using System.Collections.Generic;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Production
{
    public abstract class DistributionStrategy : IDistributionStrategy
    {
        public static List<IDistributionStrategy> GetAllStrategys()
        {
            return new List<IDistributionStrategy> { new EvenDistributionStrartegy() };
        }
        public static void DistributeDefault(Resource resource, List<Recipe> recipes)
        {
            foreach (Recipe recipe in recipes)
            {
                recipe.AddResource(resource);
            }
        }


        public abstract void Distribute(Resource resource, List<Recipe> recipes);


        public abstract string GetName();
    }
}
