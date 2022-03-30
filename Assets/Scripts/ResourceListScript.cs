using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceListScript : MonoBehaviour
{
    public GameObject ResourceDisplayPrefab;
    public GameObject Content;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Resource res in SessionGenerator.GetResourceList())
        {
            switch (res.getName())
            {
                case "Money":
                case "Electricity":
                    continue;
            }
            GameObject listItem = Instantiate(ResourceDisplayPrefab);
            listItem.transform.SetParent(Content.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
