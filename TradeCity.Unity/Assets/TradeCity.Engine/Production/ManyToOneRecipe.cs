using System;
using System.Collections.Generic;
using System.Linq;
using TradeCity.Engine.Resources;

namespace TradeCity.Engine.Production
{
    [Serializable]
    public class ManyToOneRecipe : Recipe
    {
        private readonly List<Resource> _from;
        private readonly Resource _to;

        public ManyToOneRecipe(List<Resource> from, Resource to, int limit) : base(limit)
        {
            _from = from;
            foreach (var res in from) _input.Add(res.GetNewResource(0));
            _to = to;
        }

        public override int AddResource(Resource resource)
        {
            foreach (var res in _from)
                if (resource.GetType() == res.GetType())
                {
                    var subtract = res.GetStock() * Limit - Resource.GetStock(Input, res);
                    if (subtract < 0) return 0; //if limit gets lower somehow this is needed
                    if (subtract > resource.GetStock())
                        subtract = resource.GetStock();
                    Resource.Transfer(_input, resource, subtract);
                    return subtract;
                }

            return 0;
        }

        protected override void Process()
        {
            var zipped = _input.Zip(_from, (inp, frm) => new
            {
                inpt = inp,
                from = frm
            });
            var num = zipped.Select(line => line.inpt.GetStock() / line.from.GetStock()).ToList();
            var craft = num.Min();
            foreach (var line in zipped) line.inpt.Spend(craft * line.from.GetStock());
            _output.Add(_to.GetNewResource(craft * _to.GetStock()));
        }
    }
}