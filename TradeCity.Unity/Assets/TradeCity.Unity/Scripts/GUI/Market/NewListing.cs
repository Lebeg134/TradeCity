using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Market;
using TradeCity.Engine.Resources;
using TradeCity.Units.Resources.Common;
using TradeCity.Unity.Scripts.GUI.ResourceDisplays;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    public class NewListing : MonoBehaviour
    {
        [SerializeField] private Button _sellOneButton = default!;
        [SerializeField] private Button _sellAllButton = default!;
        [SerializeField] private Button _createListingButton = default!;
        [SerializeField] private Dropdown _resourceDropdown = default!;
        [SerializeField] private ResourceDisplay _valueDisplay = default!;
        [SerializeField] private ResourceDisplay _forDisplay = default!;
        [SerializeField] private InputField _amountInput = default!;
        [SerializeField] private InputField _aboveInput = default!;

        private ResourceSelector _resourceSelector;

        private void Awake()
        {
            this.CheckSerializedField(_sellOneButton, nameof(_sellOneButton));
            this.CheckSerializedField(_sellAllButton, nameof(_sellAllButton));
            this.CheckSerializedField(_createListingButton, nameof(_createListingButton));
            this.CheckSerializedField(_resourceDropdown, nameof(_resourceDropdown));
            this.CheckSerializedField(_valueDisplay, nameof(_valueDisplay));
            this.CheckSerializedField(_forDisplay, nameof(_forDisplay));
            this.CheckSerializedField(_amountInput, nameof(_amountInput));
            this.CheckSerializedField(_aboveInput, nameof(_aboveInput));

            _resourceSelector = _resourceDropdown.GetComponent<ResourceSelector>();
            if (_resourceSelector == null) throw new MissingComponentException();

            _resourceDropdown.onValueChanged.AddListener((var) => UpdateResourceDisplay());
            _amountInput.onValueChanged.AddListener((var) => UpdateResourceDisplay());
            _aboveInput.onValueChanged.AddListener((var) => UpdateResourceDisplay());

            _resourceDropdown.onValueChanged.AddListener((var) => UpdateButtons());
            _amountInput.onValueChanged.AddListener((var) => UpdateButtons());
            _aboveInput.onValueChanged.AddListener((var) => UpdateButtons());
        }

        private void Start()
        {
            UpdateButtons();
            _sellOneButton.onClick.AddListener(() =>
                GetListing(false)?.Complete()
            );
            _sellAllButton.onClick.AddListener(() =>
                GetListing(false)?.CompleteAll()
            );
            _createListingButton.onClick.AddListener(() =>
                SpMarket.Instance.RegisterListing(GetListing(true))
            );
        }

        private void UpdateButtons()
        {
            bool resValid = _resourceSelector.Selected != null;
            _sellOneButton.interactable = resValid && int.Parse(_amountInput.text) > 0;
            _sellAllButton.interactable = resValid && int.Parse(_amountInput.text) > 0;
            _createListingButton.interactable = resValid && int.Parse(_amountInput.text) > 0 && int.Parse(_aboveInput.text) > 0;
        }

        private void UpdateResourceDisplay()
        {
            Resource res = _resourceSelector.Selected;
            Money money = new(0);
            int amount;
            if (res != null)
            {
                amount = int.Parse(_amountInput.text);
                if (amount > 0)
                {
                    money = new Money(GetListing(false).GetValue());
                    res = res.GetNewResource(amount);
                }
            }
            _valueDisplay.Watched = money;
            _forDisplay.Watched = res;
        }

        private SpListing GetListing(bool autoListing)
        {
            Resource res = _resourceSelector.Selected;
            int amount = int.Parse(_amountInput.text);
            int above = 0;
            if (autoListing)
                int.TryParse(_aboveInput.text, out above);
            return new(res.GetNewResource(amount), above);
        }
    }
}
