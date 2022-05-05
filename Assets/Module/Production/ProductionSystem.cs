using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;
using Lebeg134.Module.TimeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Module.Production
{
    public class ProductionSystem: ITickable
    {
        private Player owner;
        List<Resource> outBuffer;
        public ProductionSystem(Player owner)
        {
            this.owner = owner;
        }
        private void DistributeResources()
        {

        }
        private List<Building> GetConsumersOf(Resource resource)
        {
            return null;
        }
        private void GatherProducts()
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
