using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;
using System.Collections.Generic;

namespace Lebeg134.Module.Production
{
    public class ProductionSystem: IProductionSystem
    {
        private Player owner;
        private List<Resource> outBuffer;
        IDistributionStrategy DistStrategy { get; set; }
        public ProductionSystem(Player owner, IDistributionStrategy distributionStrategy)
        {
            this.owner = owner;
            DistStrategy = distributionStrategy;
        }
        private void DistributeResources(Resource resource, List<Recipe> recipes)
        {
            if (owner.HasResource(resource.GetNewResource(SumResFromRecipes(resource, recipes))))
                DistributionStrategy.DistributeDefault(resource, recipes);
            else
                DistStrategy.Distribute(resource, recipes);
        }
        private int SumResFromRecipes(Resource resource, List<Recipe> recipes)
        {
            int amount = 0;
            foreach (Recipe recipe in recipes)
            {
                foreach (Resource res in recipe.Input)
                {
                    if(res.GetType() == resource.GetType())
                    {
                        amount += res.GetStock();
                    }
                }
            }
            return amount;
        }

        public void GatherProducts()
        {
            owner.GiveRes(outBuffer);
        }

        public void Produce(List<IProducer> producers)
        {
            List<Recipe> recipes = new List<Recipe>();
            foreach (IProducer producer in producers)
            {
                recipes.AddRange(producer.Recipes);
            }

            foreach (Resource playerRes in owner.GetAllRes())
            {
                DistributeResources(playerRes, recipes);
            }

            outBuffer.Clear();
            foreach (Recipe recipe in recipes)
            {
                outBuffer.AddRange(recipe.Produce());
            }

        }
    }
}
