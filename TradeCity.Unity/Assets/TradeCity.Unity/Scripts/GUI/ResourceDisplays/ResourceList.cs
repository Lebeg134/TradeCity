using System.Collections;
using System.Collections.Generic;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class ResourceList : SimpleList<Resource, ResourceDisplay>
    {
        protected override IEnumerable<Resource> GetCollection()
        {
            List<Resource> ret = new();
            foreach (var res in SessionGenerator.GetResourceList())
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

        protected override void ProcessListItem(Resource item, ResourceDisplay newListItem)
        {
            newListItem.GetComponent<ResourceDisplay>().Resource = item.GetName();
        }
    }
}
