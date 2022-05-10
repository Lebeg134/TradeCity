using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using Lebeg134.Module.Structures;
using System.Collections.Generic;

namespace Lebeg134.Module.Production
{
    public class ProductionSystem: IProductionSystem
    {
        private Player owner;
        List<Resource> outBuffer;
        public ProductionSystem(Player owner)
        {
            this.owner = owner;
        }
        private void DistributeResources(List<Recipe> recipes, Resource resource)
        {

        }
        public void GatherProducts()
        {

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
                DistributeResources(recipes, playerRes);
            }

            recipes.ForEach((recipe) => recipe.Produce());

            GatherProducts();
        }
    }
}
