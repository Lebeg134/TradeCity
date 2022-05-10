using Lebeg134.Module.Resources;
using Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Production
{
    interface IDistributionStrategy
    {
        void Distribute(Resource resource, List<Recipe> recipes);
        string GetName();
    }
}
