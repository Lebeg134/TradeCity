using Lebeg134.Module.Session;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinueButtonScript : MonoBehaviour
{
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        UpdateVisuals();
        button.onClick.AddListener(() => onClick());
    }

    private void onClick()
    {
        try
        {
            Session.load();
            SceneManager.LoadScene(sceneName: "GameScene");
            Session.Instance.start();
        }
        catch (Exception)
        {
            button.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateVisuals();
    }
    void UpdateVisuals()
    {
        button.interactable = Session.saveExists();
    }
}
