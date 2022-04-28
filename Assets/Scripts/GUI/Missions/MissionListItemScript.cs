using Lebeg134.Module.Missions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionListItemScript : MonoBehaviour
{
    public Slider progressBar;
    public Button claimButton;
    public Text text;
    Mission watched;
    private void Awake()
    {
        UpdateVisuals();
    }
    public void Update()
    {
        UpdateVisuals();
    }
    public void SetWatched(Mission mission)
    {
        watched = mission;
        mission.OnAchievement += UpdateButton;
        text.text = watched.Text;
        claimButton.onClick.RemoveAllListeners();
        claimButton.onClick.AddListener(ClaimClick);
        UpdateButton();
        UpdateVisuals();
    }

    private void ClaimClick()
    {
        watched.Claim();
        UpdateButton();
    }
    private void UpdateButton()
    {
        if (watched.IsClaimed)
        {
            claimButton.interactable = false;
            claimButton.GetComponent<Text>().text = "Claimed";
        }
        else
        {
            claimButton.interactable = watched.IsAchieved;
        }
    }

    void UpdateVisuals()
    {
        if (watched == null) return;
        if (watched.IsAchieved)
        {
            progressBar.value = 1;
        }
        else
        {
            progressBar.value = watched.CheckStatus();
        }
        UpdateButton();
    }
}
