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
        button.onClick.AddListener(() => OnClick());
    }

    private void OnClick()
    {
        try
        {
            Session.Load();
            SceneManager.LoadScene(sceneName: "GameScene");
            Session.Instance.Start();
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
        button.interactable = Session.SaveExists();
    }
}
