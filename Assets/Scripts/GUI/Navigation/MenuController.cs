using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ActiveScreen
{
    CITY,
    MAP,
    MARKET
}
public class MenuController : MonoBehaviour
{
    public Canvas city;
    public Canvas map;
    public Canvas market;
    public Button cityButton;
    public Button mapButton;
    public Button marketButton;

    public ActiveScreen Active
    {
        get
        {
            return _active;
        }
        set
        {
            _active = value;
            OnScreenChanged.Invoke(value);
        }
    }
    //this should actually only be used through Property
    private ActiveScreen _active;
    public delegate void ActiveChanged(ActiveScreen newScreen);
    public event ActiveChanged OnScreenChanged;
    // Start is called before the first frame update
    void Start()
    {
        cityButton.onClick.AddListener(() => SwitchTo(ActiveScreen.CITY));
        mapButton.onClick.AddListener(() => SwitchTo(ActiveScreen.MAP));
        marketButton.onClick.AddListener(() => SwitchTo(ActiveScreen.MARKET));
        Active = ActiveScreen.CITY;
        SwitchTo(Active);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Switch to given screen
    void SwitchTo(ActiveScreen screen)
    {
        if (Active != screen) 
            Active = screen;
        switch (screen)
        {
            case ActiveScreen.CITY:
                city.enabled = true;
                map.enabled = false;
                market.enabled = false;
                break;
            case ActiveScreen.MAP:
                city.enabled = false;
                map.enabled = true;
                market.enabled = false;
                break;
            case ActiveScreen.MARKET:
                city.enabled = false;
                map.enabled = false;
                market.enabled = true;
                break;
        }
    }
}
