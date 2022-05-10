using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Production
{
    public abstract class DistributionStrategy : IDistributionStrategy
    {
        static List<IDistributionStrategy> GetAllStrategys()
        {
            return new List<IDistributionStrategy>() { new EvenDistributionStrartegy()};
        }

        public abstract void Distribute(Resource resource, List<Recipe> recipes);


        public abstract string GetName();
    }
}
