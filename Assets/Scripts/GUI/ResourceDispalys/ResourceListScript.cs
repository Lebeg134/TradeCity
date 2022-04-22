using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResourceListScript : ListScript<Resource>
{
    protected override ICollection<Resource> GetCollection()
    {
        List<Resource> ret = new List<Resource>();
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
        newListItem.GetComponent<ResourceDisplayScript>().resource = item.GetName();
    }
}
