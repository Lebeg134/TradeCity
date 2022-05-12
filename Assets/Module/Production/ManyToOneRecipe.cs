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
                if (resource.GetType() == res.GetType())
                {
                    Debug.Log("Adding " + res.GetName());
                    int subtract = res.GetStock() * Limit-input.Find((r) => r.GetType() == res.GetType()).GetStock();
                    if (subtract < 0) return 0; //if limit gets lower somehow this is needed
                    if (subtract > resource.GetStock())
                        subtract = resource.GetStock();
                    resource.Spend(subtract);
                    input += resource.GetNewResource(subtract);
                    Debug.Log("Added " + subtract);
                    return subtract;
                }
            }
            return 0;
        }

        protected override void Process()
        {
            string inBuffer = "Resources in: ";
            foreach (Resource resource in input)
            {
                inBuffer += resource.GetStock() + " " + resource.GetName() + ", ";
            }
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
            Debug.Log(craft);
            foreach(var line in zipped)
            {
                line.inpt.Spend(craft * line.from.GetStock());
                Debug.Log("Spent: " + craft * line.from.GetStock() + " " + line.from.GetName());
            }
            Debug.Log(inBuffer);
            Debug.Log("Produced: " + to.GetStock() * craft + " " + to.GetName());
            output.Add(to.GetNewResource(craft * to.GetStock()));
        }
    }
}
