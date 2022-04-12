using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JHP4SD.Lebeg134.Module.TimeManager;
using JHP4SD.Lebeg134.Module.Session;

public class BacckToMenuScript : MonoBehaviour
{
    public Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(()=> Click());
    }

    private void Click()
    {
        Clock.Instance.pause();
        Session.save();
        SceneManager.LoadScene(sceneName: "GameScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
