using Lebeg134.Module.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Production
{
    public class PriorityDistributionStrategy : DistributionStrategy
    {
        public override void Distribute(Resource resource, List<Recipe> recipes)
        {
            Dictionary<RecipePriority, List<Recipe>> recDict = new Dictionary<RecipePriority, List<Recipe>>();
            foreach (Recipe recipe in recipes)
            {
                if (!recDict.Keys.Contains(recipe.InputPriority))
                {
                    recDict.Add(recipe.InputPriority, new List<Recipe>());
                }
                recDict[recipe.InputPriority].Add(recipe);
            }
            foreach (var key in recDict.Keys)
            {
                foreach (Recipe recipe in recDict[key])
                {
                    try
                    {
                        recipe.AddResource(resource);
                    }
                    catch
                    {
                        break;
                    }
                }
            }
        }

        public override string GetName()
        {
            return "Priority Distribution";
        }
    }
}
