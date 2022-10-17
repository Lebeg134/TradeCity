using AutSoft.UnitySupplements.Vitamins;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Missions
{
    public class MissionButton : MonoBehaviour
    {
        [SerializeField] private ScrollRect _scrollView = default!;
        [SerializeField] private Button _missionButton = default!;

        private bool _isShown = false;

        private void Awake()
        {
            this.CheckSerializedField(_scrollView, nameof(_scrollView));
            this.CheckSerializedField(_missionButton, nameof(_missionButton));

            _missionButton.onClick.AddListener(OnClick);
        }

        private void OnDestroy()
        {
            _missionButton.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            _isShown = !_isShown;
            _scrollView.gameObject.SetActive(_isShown);
        }
    }
}
