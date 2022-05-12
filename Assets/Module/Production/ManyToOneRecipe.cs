using Lebeg134.Module.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Lebeg134.Module.Production
{
    class ManyToOneRecipe : Recipe
    {
        List<Resource> from;
        Resource to;
        public ManyToOneRecipe(List<Resource> from, Resource to, int limit):base(limit)
        {
            this.from = from;
            foreach (Resource res in from)
            {
                input.Add(res.GetNewResource(0));
            }
            this.to = to;
        }
        public override int AddResource(Resource resource)
        {
            foreach(Resource res in from)
            {
                if (resource.GetType() == from.GetType())
                {
                    int subtract = res.GetStock() * Limit;
                    if (subtract > resource.GetStock())
                        subtract = resource.GetStock();
                    resource.Spend(subtract);
                    input += resource.GetNewResource(subtract);
                    return subtract;
                }
            }
            return 0;
        }

        protected override void Process()
        {
            List<int> num = new List<int>();
            var zipped = input.Zip(from, (inp, frm) => new
            {
                inpt = inp,
                from = frm
            });
            foreach (var line in zipped)
            {
                num.Add(line.inpt.GetStock() / line.from.GetStock());
            }
            int craft = num.Min();
            foreach(var line in zipped)
            {
                line.inpt.Spend(craft * line.from.GetStock());
            }
            Debug.Log("Produced: " + to.GetStock() * craft + " " + to.GetName());
            output.Add(to.GetNewResource(craft * to.GetStock()));
        }
    }
}
