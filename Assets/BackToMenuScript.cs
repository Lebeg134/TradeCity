using JHP4SD.Lebeg134.Module.Session;
using JHP4SD.Lebeg134.Module.TimeManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => 
        {
            Clock.Instance.pause();
            Session.save();
            SceneManager.LoadScene(sceneName: "MainMenu"); 
        });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
