using Lebeg134.Module.Resources;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Module.Production
{
    public abstract class Recipe
    {
        public string Name { get; set; }
        private List<Resource> input;
        private List<Resource> output;

        public void AddResource(Resource resource)
        {
            input += resource;
        }
        protected abstract void Process();
        public List<Resource> Produce()
        {
            Process();
            return output;
        }
    }
}
