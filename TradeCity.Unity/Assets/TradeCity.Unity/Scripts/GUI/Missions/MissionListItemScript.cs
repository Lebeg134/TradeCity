using TradeCity.Engine.Missions;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Missions
{
    public class MissionListItemScript : MonoBehaviour
    {
        public Slider progressBar;
        public Button claimButton;
        public Text text;
        Mission watched;
        private void Awake()
        {
        
        }
        public void Update()
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
            watched.Claim();
            UpdateButton();
        }
        private void UpdateButton()
        {
            if (watched.IsClaimed)
            {
                claimButton.interactable = false;
                claimButton.GetComponentInChildren<Text>().text = "Claimed";
            }
            else
            {
                claimButton.interactable = watched.IsAchieved;
            }
            claimButton.Select();
        }

        void UpdateVisuals()
        {
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
}
