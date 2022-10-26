using System;
using System.Collections.Generic;
using System.Linq;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Production
{
    [Serializable]
    public class PriorityDistributionStrategy : DistributionStrategy
    {
        public override void Distribute(Resource resource, List<Recipe> recipes)
        {
            Dictionary<RecipePriority, List<Recipe>> recDict = new();
            foreach (var recipe in recipes)
            {
                if (!recDict.Keys.Contains(recipe.InputPriority)) recDict.Add(recipe.InputPriority, new List<Recipe>());
                recDict[recipe.InputPriority].Add(recipe);
            }

            foreach (var key in recDict.Keys)
                foreach (var recipe in recDict[key])
                    try
                    {
                        recipe.AddResource(resource);
                    }
                    catch
                    {
                        break;
                    }
        }

        public override string GetName()
        {
            return "Priority Distribution";
        }
    }
}