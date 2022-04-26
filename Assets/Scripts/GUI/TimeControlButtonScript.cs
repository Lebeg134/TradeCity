using Lebeg134.Module.TimeManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControlButtonScript : MonoBehaviour
{
    public Sprite play;
    public Sprite pause;
    public Color playColor;
    public Color pauseColor;
    public Image icon;
    public Button button;
    Clock clock;
    // Start is called before the first frame update
    void Start()
    {
        clock = Clock.Instance;
        button.onClick.AddListener(() => Toggle());
    }

    // Update is called once per frame
    void Update()
    {
        UpdateVisuals();
    }
    void Toggle()
    {
        clock.toggle();
    }
    void UpdateVisuals()
    {
        if (clock.isEnabled())
        {
            icon.sprite = pause;
            button.image.color = pauseColor;
        }
        else
        {
            icon.sprite = play;
            button.image.color = playColor;
        }
    }
}
