using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Market;
using TradeCity.Units.Resources.Common;
using TradeCity.Unity.Scripts.GUI.ResourceDisplays;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    public class ListingItemVisual : MonoBehaviour
    {
        [SerializeField] private ResourceDisplay _listingSubject = default!;
        [SerializeField] private ResourceDisplay _moneyDisplay = default!;
        [SerializeField] private ResourceDisplay _aboveDisplay = default!;
        [SerializeField] private Button _cancelButton = default!;

        public SpListing Watched;

        private void Awake()
        {
            this.CheckSerializedField(_listingSubject, nameof(_listingSubject));
            this.CheckSerializedField(_moneyDisplay, nameof(_moneyDisplay));
            this.CheckSerializedField(_aboveDisplay, nameof(_aboveDisplay));

            _cancelButton.onClick.AddListener(OnClick);
        }

        private void Start()
        {
            _listingSubject.Watched = Watched.Sell;
            _moneyDisplay.Watched = new Money(Watched.GetValue());
            _aboveDisplay.Watched = Watched.Sell.GetNewResource(Watched.Above);
        }

        private void OnDestroy()
        {
            _cancelButton.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            SpMarket.Instance.RemoveListing(Watched);
        }
    }
}
