using System.Collections.Generic;
using System.Linq;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Production
{
    public class ProductionSystem : IProductionSystem
    {
        private readonly Player _owner;
        private readonly List<Resource> _outBuffer = new();

        private IDistributionStrategy DistStrategy { get; set; }
        public ProductionSystem(Player owner, IDistributionStrategy distributionStrategy)
        {
            _owner = owner;
            DistStrategy = distributionStrategy;
        }
        private void DistributeResources(Resource resource, List<Recipe> recipes)
        {
            if (_owner.HasResource(resource.GetNewResource(SumResFromRecipes(resource, recipes))))
                DistributionStrategy.DistributeDefault(resource, recipes);
            else
                DistStrategy.Distribute(resource, recipes);
        }
        private int SumResFromRecipes(Resource resource, List<Recipe> recipes)
        {
            return (from recipe in recipes from res in recipe.Input where res.GetType() == resource.GetType() select res.GetStock()).Sum();
        }

        public void GatherProducts()
        {
            _owner.GiveRes(_outBuffer);
        }

        public void Produce(List<IProducer> producers)
        {
            List<Recipe> recipes = new();
            foreach (var producer in producers)
            {
                if (producer is Building building && !building.IsOn) continue;
                recipes.AddRange(producer.Recipes);
            }

            foreach (var playerRes in _owner.GetAllRes())
            {
                DistributeResources(playerRes, recipes);
            }

            _outBuffer.Clear();
            foreach (var recipe in recipes)
            {
                var reslist = recipe.Produce();
                _outBuffer.AddRange(reslist);
                reslist.Clear();
                //TODO Limit resources potencial bug!
            }

        }
    }
}
