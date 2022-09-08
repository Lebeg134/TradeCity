using AutSoft.UnitySupplements.Vitamins;
using System.Collections.Generic;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Unity.Scripts.GUI.ResourceDisplays;
using TradeCity.Unity.Scripts.GUI.VisualUpdaters;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class LandOfferVisuals : MonoBehaviour
    {

        private readonly string[] _options = GetOptions();
        [Dropdown("_options")]
        [SerializeField] private string _target;

        [SerializeField] private Image _sprite = default!;
        [SerializeField] private Text _buildingName = default!;
        [SerializeField] private Button _buildButton = default!;
        [SerializeField] private GameObject _costDisplay = default!;

        public Land Watched;
        public int Price = 1000;
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
            this.CheckSerializedField(_sprite, nameof(_sprite));
            this.CheckSerializedField(_buildingName, nameof(_buildingName));
            this.CheckSerializedField(_buildButton, nameof(_buildButton));
            this.CheckSerializedField(_costDisplay, nameof(_costDisplay));
        }
        private void Start()
        {
            if (Watched == null)
            {
                Watched = ConvertStringToLand(_target);
            }
            _buildingName.text = Watched.GetName();
            _costDisplay.GetComponent<ResourceDisplay>().Watched = new Money(Price);

            Sprite loadedSprite = Resources.Load<Sprite>(Watched.GetResourcepath());
            if (loadedSprite != null)
                _sprite.sprite = loadedSprite;

            _buildButton.onClick.AddListener(() => OnClick());

        }

        private void OnClick()
        {
            if (Player.CurrentPlayer.CheckResource(new Money(Price)))
            {
                Player.CurrentPlayer.SubRes(new Money(Price));
                Player.CurrentPlayer.GiveStructure(Watched);
                Session.Instance.Offers.Remove(Watched);
                int newPrice = Price * 2;
                Session.Instance.Offers.Add(Watched.GetNew(), newPrice);
                gameObject.GetComponentInParent<AvailableLandsList>().Refresh();
                gameObject.GetComponentInParent<VisualUpdater>().VisualUpdate();
            }
        }

        private void Update()
        {
            _buildButton.interactable = Player.CurrentPlayer.CheckResource(new Money(Price));
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
