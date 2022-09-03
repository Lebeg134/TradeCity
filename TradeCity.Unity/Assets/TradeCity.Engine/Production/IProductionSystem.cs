using Lebeg134.Module.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebeg134.Module.Production
{
    interface IProductionSystem
    {
        void Produce(List<IProducer> producers);
    }
}
