using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceSelectorScript : MonoBehaviour
{
    public Resource selected;
    public Dropdown dropdown;
    List<string> options = ResourceDisplayScript.getOptions();
    // Start is called before the first frame update
    void Start()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(options);
        dropdown.onValueChanged.AddListener((int i) =>
        {
            selected = ResourceDisplayScript.ConvertToRes(options[i]);
        }
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
