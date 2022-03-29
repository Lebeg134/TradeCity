using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Session;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ResourceDisplayScript : MonoBehaviour
{
    
    public Player player;
    public Text display;
    public Image icon;


    static string[] resources = getOptions();
    static int selected = 0;
    static List<Resource> reslist = SessionGenerator.GetResourceList();
    public Resource watched = reslist[ EditorGUILayout.Popup("Resource", selected, resources)];
    // Start is called before the first frame update
    void Start()
    {
        //icon.texture.LoadImage();
    }

    // Update is called once per frame
    void Update()
    {
        display.text = player.getRes(watched).ToString();
    }

    static string[] getOptions()
    {
        List<Resource> reslist =SessionGenerator.GetResourceList();
        List<string> strlist = new List<string>();
        foreach(Resource res in reslist)
        {
            strlist.Add(res.ToString());
        }
        return strlist.ToArray();
    }
}
