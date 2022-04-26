using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Lebeg134.Module.Session;

public class StartGameScript : MonoBehaviour
{
    public Button newGameBtn;
    // Start is called before the first frame update
    void Start()
    {
        newGameBtn.onClick.AddListener(() => StartGame());
    }

    private void StartGame()
    {
        SceneManager.LoadScene(sceneName: "GameScene");
        Session session = SessionGenerator.GenerateStandard();
        session.start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
