#nullable enable
using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Missions;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Missions
{
    public class MissionListItem : MonoBehaviour
    {
        [SerializeField] private Slider _progressBar = default!;
        [SerializeField] private Button _claimButton = default!;
        [SerializeField] private Text _text = default!;

        private Mission? _watched;

        private void Awake()
        {
            this.CheckSerializedField(_progressBar, nameof(_progressBar));
            this.CheckSerializedField(_claimButton, nameof(_claimButton));
            this.CheckSerializedField(_text, nameof(_text));
        }

        private void Update()
        {
            if (_watched != null)
                UpdateVisuals();
        }

        public void SetWatched(Mission mission)
        {
            _watched = mission;
            mission.OnAchievement += UpdateButton;
            _text.text = _watched.Text;
            _claimButton.onClick.RemoveAllListeners();
            _claimButton.onClick.AddListener(ClaimClick);
            UpdateButton();
            UpdateVisuals();
        }

        private void ClaimClick()
        {
            _watched?.Claim();
            UpdateButton();
        }

        private void UpdateButton()
        {
            if (_watched?.IsClaimed ?? false)
            {
                _claimButton.interactable = false;
                _claimButton.GetComponentInChildren<Text>().text = "Claimed";
            }
            else
            {
                _claimButton.interactable = _watched?.IsAchieved ?? false;
            }
            _claimButton.Select();
        }

        private void UpdateVisuals()
        {
            if (_watched?.IsAchieved ?? false)
            {
                _progressBar.value = 1;
            }
            else
            {
                _progressBar.value = _watched?.CheckStatus() ?? 0;
            }
            UpdateButton();
        }
    }
}
