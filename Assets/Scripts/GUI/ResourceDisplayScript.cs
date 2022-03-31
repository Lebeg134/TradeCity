using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ResourceDisplayScript : MonoBehaviour
{
    string[] options = getOptions();
    [Dropdown("options")]
    public string resource;
    Resource watched;
    public Text display;
    public Text name;
    public Image icon;
    Player player;

    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        watched = ConvertToRes(resource);
        name.text = watched.getName();
    }

    // Update is called once per frame
    void Update()
    {
        if (display!=null && display.text !=null)
            display.text = num++.ToString();
        if (num >= 999999)
            num = 0;
    }

    static string[] getOptions()
    {
        List<Resource> reslist =SessionGenerator.GetResourceList();
        List<string> strlist = new List<string>();
        foreach(Resource res in reslist)
        {
            strlist.Add(res.getName());
        }
        return strlist.ToArray();
    }
    static Resource ConvertToRes(string name)
    {
        foreach (Resource res in SessionGenerator.GetResourceList())
        {
            if (res.getName() == name)
                return res;
        }
        return null;
    }
}
