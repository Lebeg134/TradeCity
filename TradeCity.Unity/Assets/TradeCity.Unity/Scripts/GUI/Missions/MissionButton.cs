using AutSoft.UnitySupplements.Vitamins;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Missions
{
    public class MissionButton : MonoBehaviour
    {
        [SerializeField] private ScrollRect scrollView;
        [SerializeField] private Button missionButton;

        private bool isShown = false;

        private void Awake()
        {
            this.CheckSerializedField(scrollView, nameof(scrollView));
            this.CheckSerializedField(missionButton, nameof(missionButton));

            missionButton.onClick.AddListener(OnClick);
        }

        private void OnDestroy()
        {
            missionButton.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            isShown = !isShown;
            scrollView.gameObject.SetActive(isShown);
        }
    }
}
