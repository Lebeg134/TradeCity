#nullable enable
using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Missions;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Missions
{
    public class MissionListItem : MonoBehaviour
    {
        [SerializeField] private Slider progressBar;
        [SerializeField] private Button claimButton;
        [SerializeField] private Text text;

        private Mission? watched;

        private void Awake()
        {
            this.CheckSerializedField(progressBar, nameof(progressBar));
            this.CheckSerializedField(claimButton, nameof(claimButton));
            this.CheckSerializedField(text, nameof(text));
        }

        private void Update()
        {
            if (watched != null)
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
            watched?.Claim();
            UpdateButton();
        }

        private void UpdateButton()
        {
            if (watched?.IsClaimed ?? false)
            {
                claimButton.interactable = false;
                claimButton.GetComponentInChildren<Text>().text = "Claimed";
            }
            else
            {
                claimButton.interactable = watched?.IsAchieved ?? false;
            }
            claimButton.Select();
        }

        private void UpdateVisuals()
        {
            if (watched?.IsAchieved ?? false)
            {
                progressBar.value = 1;
            }
            else
            {
                progressBar.value = watched?.CheckStatus()?? 0;
            }
            UpdateButton();
        }
    }
}
