using AutSoft.UnitySupplements.Vitamins;
using TMPro;
using TradeCity.Engine.Structures;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.CIty
{
    public class BuildingDetailsPanel : MonoBehaviour
    {
        [SerializeField] private TMP_Text _name;
        [SerializeField] private TMP_Text _description;
        [SerializeField] private Toggle _operating;
        [SerializeField] private TMP_Text _requirements;

        [SerializeField] private Button _closeButton;

        private Building _watched;
        private bool _operatingEnabled;
        private void Awake()
        {
            this.CheckSerializedField(_closeButton, nameof(_closeButton));

            _closeButton.onClick.AddListener(Hide);
            //TODO
        }

        public void SetWatched(Building watched)
        {
            _watched = watched;
            UpdatePanel();
        }

        private void Hide()
        {
            gameObject.SetActive(false);
            _watched = null;
        }

        private void UpdatePanel()
        {
            //TODO
        }
    }
}