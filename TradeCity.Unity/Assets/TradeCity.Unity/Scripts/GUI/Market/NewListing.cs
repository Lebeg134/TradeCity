using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Market;
using TradeCity.Engine.Resources;
using TradeCity.Units.Resources.Common;
using TradeCity.Unity.Scripts.GUI.ResourceDispalys;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    public class NewListing : MonoBehaviour
    {
        [SerializeField] private Button sellOneButton;
        [SerializeField] private Button sellAllButton;
        [SerializeField] private Button createListingButton;
        [SerializeField] private Dropdown _resourceDropdown;
        [SerializeField] private ResourceDisplayScript valueDisplay;
        [SerializeField] private ResourceDisplayScript forDisplay;
        [SerializeField] private InputField amountInput;
        [SerializeField] private InputField aboveInput;

        private ResourceSelector _resourceSelector;

        private void Awake()
        {
            this.CheckSerializedField(sellOneButton, nameof(sellOneButton));
            this.CheckSerializedField(sellAllButton, nameof(sellAllButton));
            this.CheckSerializedField(createListingButton, nameof(createListingButton));
            this.CheckSerializedField(_resourceDropdown, nameof(_resourceDropdown));
            this.CheckSerializedField(valueDisplay, nameof(valueDisplay));
            this.CheckSerializedField(forDisplay, nameof(forDisplay));
            this.CheckSerializedField(amountInput, nameof(amountInput));
            this.CheckSerializedField(aboveInput, nameof(aboveInput));

            _resourceSelector = _resourceDropdown.GetComponent<ResourceSelector>();
            if (_resourceSelector == null) throw new MissingComponentException();

            _resourceDropdown.onValueChanged.AddListener((var) => UpdateResourceDisplay());
            amountInput.onValueChanged.AddListener((var) => UpdateResourceDisplay());
            aboveInput.onValueChanged.AddListener((var) => UpdateResourceDisplay());

            _resourceDropdown.onValueChanged.AddListener((var) => UpdateButtons());
            amountInput.onValueChanged.AddListener((var) => UpdateButtons());
            aboveInput.onValueChanged.AddListener((var) => UpdateButtons());
        }

        private void Start()
        {
            UpdateButtons();
            sellOneButton.onClick.AddListener(() =>
                GetListing(false)?.Complete()
            );
            sellAllButton.onClick.AddListener(() =>
                GetListing(false)?.CompleteAll()
            );
            createListingButton.onClick.AddListener(() =>
                SpMarket.Instance.RegisterListing(GetListing(true))
            );
        }

        void UpdateButtons()
        {
            bool resValid = _resourceSelector.selected != null;
            sellOneButton.interactable = resValid && int.Parse(amountInput.text) > 0;
            sellAllButton.interactable = resValid && int.Parse(amountInput.text) > 0;
            createListingButton.interactable = resValid && int.Parse(amountInput.text) > 0 && int.Parse(aboveInput.text) > 0;
        }

        private void UpdateResourceDisplay()
        {
            var res = _resourceSelector.selected;
            var money = new Money(0);
            int amount;
            if (res != null)
            {
                amount = int.Parse(amountInput.text);
                if (amount > 0)
                {
                    money = new Money(GetListing(false).GetValue());
                    res = res.GetNewResource(amount);
                }
            }
            valueDisplay.Watched = money;
            forDisplay.Watched = res;
        }

        private SpListing GetListing(bool autoListing)
        {
            Resource res = _resourceSelector.selected;
            int amount = int.Parse(amountInput.text);
            int above = 0;
            if (autoListing)
                int.TryParse(aboveInput.text, out above);
            return new(res.GetNewResource(amount), above);
        }
    }
}
