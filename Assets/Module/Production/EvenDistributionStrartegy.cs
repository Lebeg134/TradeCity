using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Production
{
    class EvenDistributionStrartegy : DistributionStrategy
    {
        public override void Distribute(Resource resource, List<Recipe> inputs)
        {
            int amount = resource.GetStock() / inputs.Count();
            foreach(Recipe recipe in inputs)
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
