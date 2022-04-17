using Assets.Scripts.GUI.VisualUpdaters;
using JHP4SD.Lebeg134.Module.Resources;
using JHP4SD.Lebeg134.Module.Structures;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OwnedlandVisualSript : MonoBehaviour
{
    public Land watched;
    public Image sprite;
    public Text nameText;
    public GameObject produceDisplay;

    void Start()
    {
        nameText.text = watched.getName();
        produceDisplay.GetComponent<ResourceDisplayScript>().watched = watched.getProduce()[0]; //TODO if produces more than one!

        var loadedSprite = Resources.Load<Sprite>(watched.GetResourcepath());
        if (loadedSprite != null)
            sprite.sprite = loadedSprite;
    }
    void Update()
    {
        
    }
}
