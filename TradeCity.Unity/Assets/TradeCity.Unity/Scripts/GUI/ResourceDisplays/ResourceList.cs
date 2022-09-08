using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class ResourceList : SimpleList<Resource>
    {
        protected override ICollection<Resource> GetCollection()
        {
            List<Resource> ret = new();
            foreach (Resource res in SessionGenerator.GetResourceList())
            {
                switch (res.GetName())
                {
                    case "Money":
                    case "Electricity":
                    case "Water":
                    case "Workforce":
                        continue;
                }
                ret.Add(res);
            }
            return ret;
        }

        protected override void ProcessListItem(Resource item, GameObject newListItem)
        {
            newListItem.GetComponent<ResourceDisplay>().Resource = item.GetName();
        }
    }
}
