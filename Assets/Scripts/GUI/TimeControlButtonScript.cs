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
    public Button button;
    bool paused = true;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(()=> Toggle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Toggle()
    {
        paused = !paused;
        if (paused)
        {
            //button.gameObject.GetComponent<Sprite>().texture.
        }
        else
        {
            
        }
    }
}
