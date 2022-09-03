﻿using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Production
{
    public class SimpleRecipe : Recipe
    {
        private readonly Resource from, to;


        /// <summary>
        /// Constructor of simple custom recipes where the two Resources define the ratio between convertion
        /// </summary>
        /// <param name="from">Input requirement of the Recipe</param>
        /// <param name="to">Output of the recipe</param>
        /// <param name="limit">Default number of times recipe can be crafted in a period</param>
        public SimpleRecipe(Resource from, Resource to, int limit) : base(limit)
        {
            this.from = from;
            input.Add(from.GetNewResource(0));
            this.to = to;
            output.Add(to.GetNewResource(0));

        }
        public override int AddResource(Resource resource)
        {
            if (resource.GetType() == from.GetType())
            {
                int subtract = from.GetStock() * Limit;
                if (subtract > resource.GetStock())
                    subtract = resource.GetStock();
                Resource.Transfer(input, resource, subtract);
                return subtract;
            }
            else return 0;
        }

        protected override void Process()
        {
            Resource resource = input.Find((res) => res.GetType() == from.GetType());
            int num = resource.GetStock() / from.GetStock();
            if (num > Limit)
                Limit = num;
            resource.Spend(num * from.GetStock());
            output.Add(to.GetNewResource(to.GetStock() * num));
        }
    }
}
