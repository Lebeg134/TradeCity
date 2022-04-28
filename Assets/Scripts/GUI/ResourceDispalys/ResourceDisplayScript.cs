using Lebeg134.Module.Resources;
using Lebeg134.Module.Session;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceDisplayScript : MonoBehaviour
{
    string[] options = GetOptions().ToArray();
    [Dropdown("options")]
    public string resource;
    public Resource Watched
    {
        get
        {
            return _watched;
        }
        set
        {
            _watched = value;
            OnWatchedChanged();

        }
    }
    protected virtual void OnWatchedChanged()
    {
        UpdateVisuals();
    }
    Resource _watched;
    public Text display;
    public Text resName;
    public Image icon;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        if (Watched == null)
            Watched = ConvertToRes(resource);
        UpdateVisuals();
    }

    // Update is called once per frame
    protected virtual void Update()
    {

    }

    protected virtual void UpdateVisuals()
    {
        if (Watched == null) return;
        resName.text = Watched.GetName();
        display.text = Watched.Amount().ToString();
        LoadSprite();
    }
    protected void LoadSprite()
    {
        var loadedSprite = Resources.Load<Sprite>(Watched.GetResourcepath());
        if (loadedSprite != null)
            icon.sprite = loadedSprite;
    }

    public static List<string> GetOptions()
    {
        List<Resource> reslist = SessionGenerator.GetResourceList();
        List<string> strlist = new List<string>();
        foreach (Resource res in reslist)
        {
            strlist.Add(res.GetName());
        }
        return strlist;
    }
    public static Resource ConvertToRes(string name)
    {
        foreach (Resource res in SessionGenerator.GetResourceList())
        {
            if (res.GetName() == name)
                return res;
        }
        return null;
    }
}
