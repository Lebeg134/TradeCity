using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
