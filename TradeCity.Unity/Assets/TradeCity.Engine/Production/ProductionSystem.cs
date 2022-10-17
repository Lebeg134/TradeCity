using System;
using System.Collections.Generic;
using System.Linq;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Engine.Structures.Interfaces;

namespace TradeCity.Engine.Production
{
    [Serializable]
    public class ProductionSystem : IProductionSystem
    {
        private readonly List<Resource> _outBuffer = new();
        private readonly Player _owner;

        public ProductionSystem(Player owner, IDistributionStrategy distributionStrategy)
        {
            _owner = owner;
            DistStrategy = distributionStrategy;
        }

        private IDistributionStrategy DistStrategy { get; set; }

        public void Produce(List<IProducer> producers)
        {
            List<Recipe> recipes = new();
            foreach (var producer in producers.Where(producer => producer is not Building { IsOn: false }))
                recipes.AddRange(producer.Recipes);

            foreach (var playerRes in _owner.GetAllRes()) DistributeResources(playerRes, recipes);

            _outBuffer.Clear();
            foreach (var resList in recipes.Select(recipe => recipe.Produce()))
            {
                _outBuffer.AddRange(resList);
                resList.Clear();
            }
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
            return (from recipe in recipes
                from res in recipe.Input
                where res.GetType() == resource.GetType()
                select res.GetStock()).Sum();
        }

        public void GatherProducts()
        {
            _owner.GiveRes(_outBuffer);
        }
    }
}