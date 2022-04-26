using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmbientAudioScript : MonoBehaviour
{
    public GameObject screenNavigator;
    AudioSource audioSource;
    public AudioClip cityAmbient;
    public AudioClip mapAmbient;
    public AudioClip marketAmbient;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        screenNavigator.GetComponent<MenuController>().OnScreenChanged += onScreenChange;
    }
    void onScreenChange(ActiveScreen activeScreen)
    {

        switch (activeScreen)
        {
            case ActiveScreen.CITY:
                audioSource.clip = cityAmbient;
                break;
            case ActiveScreen.MAP:
                audioSource.clip = mapAmbient;
                break;
            case ActiveScreen.MARKET:
                audioSource.clip = marketAmbient;
                break;
                
        }
        audioSource.Play();
    }
}