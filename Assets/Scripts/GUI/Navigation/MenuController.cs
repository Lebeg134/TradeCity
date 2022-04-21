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

    public ActiveScreen active
    {
        get
        {
            return _active;
        }
        set
        {
            _active = value;
            onScreenChanged.Invoke(value);
        }
    }
    ActiveScreen _active;
    public delegate void ActiveChanged(ActiveScreen newScreen);
    public event ActiveChanged onScreenChanged;
    // Start is called before the first frame update
    void Start()
    {
        cityButton.onClick.AddListener(() => SwitchTo(ActiveScreen.CITY));
        mapButton.onClick.AddListener(() => SwitchTo(ActiveScreen.MAP));
        marketButton.onClick.AddListener(() => SwitchTo(ActiveScreen.MARKET));
        active = ActiveScreen.CITY;
        SwitchTo(active);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // Switch to given screen
    void SwitchTo(ActiveScreen screen)
    {
        if (active != screen) 
            active = screen;
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
