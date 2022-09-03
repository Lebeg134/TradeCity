using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Production
{
    public class SimpleRecipe : Recipe
    {
        private readonly Resource _from, _to;


        /// <summary>
        /// Constructor of simple custom recipes where the two Resources define the ratio between convertion
        /// </summary>
        /// <param name="from">Input requirement of the Recipe</param>
        /// <param name="to">Output of the recipe</param>
        /// <param name="limit">Default number of times recipe can be crafted in a period</param>
        public SimpleRecipe(Resource from, Resource to, int limit) : base(limit)
        {
            _from = from;
            _input.Add(from.GetNewResource(0));
            _to = to;
            _output.Add(to.GetNewResource(0));

        }
        public override int AddResource(Resource resource)
        {
            if (resource.GetType() == _from.GetType())
            {
                int subtract = _from.GetStock() * Limit;
                if (subtract > resource.GetStock())
                    subtract = resource.GetStock();
                Resource.Transfer(_input, resource, subtract);
                return subtract;
            }

            return 0;
        }

        protected override void Process()
        {
            Resource resource = _input.Find(res => res.GetType() == _from.GetType());
            int num = resource.GetStock() / _from.GetStock();
            if (num > Limit)
                Limit = num;
            resource.Spend(num * _from.GetStock());
            _output.Add(_to.GetNewResource(_to.GetStock() * num));
        }
    }
}
