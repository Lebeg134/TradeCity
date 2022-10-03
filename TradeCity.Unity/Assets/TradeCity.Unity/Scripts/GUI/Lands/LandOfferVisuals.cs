using AutSoft.UnitySupplements.Vitamins;
using System.Linq;
using TMPro;
using TradeCity.Engine.Session;
using TradeCity.Engine.Structures;
using TradeCity.Units.Resources.Common;
using TradeCity.Unity.Scripts.GUI.ResourceDisplays;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class LandOfferVisuals : MonoBehaviour
    {
        private readonly string[] _options = GetOptions();
        [Dropdown("_options")] [SerializeField]
        private const string Target = default!;

        [SerializeField] private Image _sprite = default!;
        [SerializeField] private TMP_Text _buildingName = default!;
        [SerializeField] private Button _buildButton = default!;
        [SerializeField] private CostResourceDisplay _costDisplay = default!;

        public Land Watched;
        public int Price = 1000;
        private static string[] GetOptions()
        {
            return SessionGenerator.GetAllLands().Select(land => land.GetName()).ToArray();
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
            Watched ??= ConvertStringToLand(Target);
            _buildingName.text = Watched.GetName();
            _costDisplay.Watched = new Money(Price);

            var loadedSprite = Resources.Load<Sprite>(Watched.GetResourcePath());
            if (loadedSprite != null)
                _sprite.sprite = loadedSprite;

            _buildButton.onClick.AddListener(OnClick);

        }

        private void OnClick()
        {
            if (!Player.CurrentPlayer.CheckResource(new Money(Price))) return;
            Player.CurrentPlayer.SubRes(new Money(Price));
            Player.CurrentPlayer.GiveStructure(Watched);
            Session.Instance.Offers.Remove(Watched);
            var newPrice = Price * 2;
            Session.Instance.Offers.Add(Watched.GetNew(), newPrice);
            gameObject.GetComponentInParent<AvailableLandsList>().Refresh();
        }

        private void Update()
        {
            _buildButton.interactable = Player.CurrentPlayer.CheckResource(new Money(Price));
        }

        private static Land ConvertStringToLand(string name)
        {
            return SessionGenerator.GetAllLands().FirstOrDefault(land => land.GetName() == name);
        }
    }
}
