using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Market;
using TradeCity.Units.Resources.Common;
using TradeCity.Unity.Scripts.GUI.ResourceDispalys;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    public class ListingItemVisual : MonoBehaviour
    {
        [SerializeField] private ResourceDisplay ListingSubject = default!;
        [SerializeField] private ResourceDisplay MoneyDisplay = default!;
        [SerializeField] private ResourceDisplay AboveDisplay = default!;
        [SerializeField] private Button CancelButton = default!;

        public SpListing watched;

        private void Awake()
        {
            this.CheckSerializedField(ListingSubject, nameof(ListingSubject));
            this.CheckSerializedField(MoneyDisplay, nameof(MoneyDisplay));
            this.CheckSerializedField(AboveDisplay, nameof(AboveDisplay));

            CancelButton.onClick.AddListener(OnClick);
        }

        private void Start()
        {
            ListingSubject.Watched = watched.Sell;
            MoneyDisplay.Watched = new Money(watched.GetValue());
            AboveDisplay.Watched = watched.Sell.GetNewResource(watched.Above);
        }

        private void OnDestroy()
        {
            CancelButton.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            SpMarket.Instance.RemoveListing(watched);
        }
    }
}
