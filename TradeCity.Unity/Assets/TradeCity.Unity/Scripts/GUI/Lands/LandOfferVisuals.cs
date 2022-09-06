using AutSoft.UnitySupplements.Vitamins;
using System.Collections.Generic;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Unity.Scripts.GUI.ResourceDispalys;
using TradeCity.Unity.Scripts.GUI.VisualUpdaters;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class LandOfferVisuals : MonoBehaviour
    {

        private string[] options = GetOptions();
        [Dropdown("options")]
        public string target;

        [SerializeField] private Image sprite;
        [SerializeField] private Text buildingName;
        [SerializeField] private Button buildButton;
        [SerializeField] private GameObject costDisplay;

        public Land watched;
        public int price = 1000;
        private static string[] GetOptions()
        {

            List<string> options = new();
            foreach (Land land in SessionGenerator.GetAllLands())
            {
                options.Add(land.GetName());
            }
            return options.ToArray();
        }


        private void Awake()
        {
            this.CheckSerializedField(sprite, nameof(sprite));
            this.CheckSerializedField(buildingName, nameof(buildingName));
            this.CheckSerializedField(buildButton, nameof(buildButton));
            this.CheckSerializedField(costDisplay, nameof(costDisplay));
        }
        private void Start()
        {
            if (watched == null)
            {
                watched = ConvertStringToLand(target);
            }
            buildingName.text = watched.GetName();
            costDisplay.GetComponent<ResourceDisplay>().Watched = new Money(price);

            var loadedSprite = Resources.Load<Sprite>(watched.GetResourcepath());
            if (loadedSprite != null)
                sprite.sprite = loadedSprite;

            buildButton.onClick.AddListener(() => OnClick());

        }

        private void OnClick()
        {
            if (Player.CurrentPlayer.CheckResource(new Money(price)))
            {
                Player.CurrentPlayer.SubRes(new Money(price));
                Player.CurrentPlayer.GiveStructure(watched);
                Session.Instance.Offers.Remove(watched);
                int newPrice = price * 2;
                Session.Instance.Offers.Add(watched.GetNew(), newPrice);
                gameObject.GetComponentInParent<AvailableLandsList>().Refresh();
                gameObject.GetComponentInParent<VisualUpdater>().VisualUpdate();
            }
        }

        private void Update()
        {
            buildButton.interactable = Player.CurrentPlayer.CheckResource(new Money(price));
        }
        private Land ConvertStringToLand(string name)
        {
            foreach (Land land in SessionGenerator.GetAllLands())
            {
                if (land.GetName() == name)
                    return land;
            }
            return null;
        }
    }
}
