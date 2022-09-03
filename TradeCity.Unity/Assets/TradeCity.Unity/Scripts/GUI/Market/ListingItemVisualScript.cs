using TradeCity.Engine.Market;
using TradeCity.Units.Resources.Common;
using TradeCity.Unity.Scripts.GUI.ResourceDispalys;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    public class ListingItemVisualScript : MonoBehaviour
    {
        public GameObject ListingSubject;
        public GameObject MoneyDisplay;
        public GameObject AboveDisplay;
        public Button CancelButton;
        public SPListing watched;
        // Start is called before the first frame update
        void Start()
        {
            ListingSubject.GetComponent<ResourceDisplayScript>().Watched = watched.Sell;
            MoneyDisplay.GetComponent<ResourceDisplayScript>().Watched = new Money(watched.GetValue());
            AboveDisplay.GetComponent<ResourceDisplayScript>().Watched = watched.Sell.GetNewResource(watched.above);

            CancelButton.onClick.AddListener(() => OnClick()); ;
        }

        private void OnClick()
        {
            SPMarket.Instance.RemoveListing(watched);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
