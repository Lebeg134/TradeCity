using System.Collections.Generic;
using System.Linq;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Production
{
    public class EvenDistributionStrartegy : DistributionStrategy
    {
        public override void Distribute(Resource resource, List<Recipe> inputs)
        {
            var amount = resource.GetStock() / inputs.Count();
            foreach (var recipe in inputs)
            {
                resource.Spend(recipe.AddResource(resource.GetNewResource(amount)));
            }
        }

        public override string GetName()
        {
            return "Even distribution";
        }

    }
}
