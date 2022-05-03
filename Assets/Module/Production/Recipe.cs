using Lebeg134.Module.Resources;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Module.Production
{
    internal class Recipe: ITickable
    {
        public string Name { get; set; }
        private List<Resource> input;
        private List<Resource> output;

        public void AddResource(Resource resource)
        {
            
        }
        public Resource Produce()
        {

        }

        public void Tick()
        {
            throw new NotImplementedException();
        }

        public void Register()
        {
            Clock.Instance.Register(this);
        }
    }
}
