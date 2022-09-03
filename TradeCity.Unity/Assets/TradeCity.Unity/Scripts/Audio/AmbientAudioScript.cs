using UnityEngine;

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
        screenNavigator.GetComponent<MenuController>().OnScreenChanged += OnScreenChange;
    }
    void OnScreenChange(ActiveScreen activeScreen)
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