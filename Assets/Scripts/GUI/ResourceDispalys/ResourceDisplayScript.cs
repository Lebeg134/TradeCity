using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ResourceDisplayScript : MonoBehaviour
{
    string[] options = getOptions().ToArray();
    [Dropdown("options")]
    public string resource;
    public Resource watched
    {
        get
        {
            return _watched;
        }
        set
        {
            UpdateVisuals();
            _watched = value;
        }
    }
    Resource _watched;
    public Text display;
    public Text resName;
    public Image icon;
    Player player;

    int num = 0;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        if (watched == null)
            watched = ConvertToRes(resource);
        UpdateVisuals();

        var loadedSprite = Resources.Load<Sprite>(watched.GetResourcepath());
        if (loadedSprite != null)
            icon.sprite = loadedSprite;
    }

    // Update is called once per frame
    protected virtual void Update()
    {

    }

    protected virtual void UpdateVisuals()
    {
        resName!.text = watched!.getName();
        display!.text = watched!.amount().ToString();
    }

    public static List<string> getOptions()
    {
        List<Resource> reslist =SessionGenerator.GetResourceList();
        List<string> strlist = new List<string>();
        foreach(Resource res in reslist)
        {
            strlist.Add(res.getName());
        }
        return strlist;
    }
    public static Resource ConvertToRes(string name)
    {
        foreach (Resource res in SessionGenerator.GetResourceList())
        {
            if (res.getName() == name)
                return res;
        }
        return null;
    }
}
