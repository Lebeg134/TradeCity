using AutSoft.UnitySupplements.Vitamins;
using TMPro;
using TradeCity.Engine.Structures;
using TradeCity.Unity.Scripts.GUI.ResourceDisplays;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class OwnedLandVisual : MonoBehaviour
    {
        public Land Watched;
        [SerializeField] private Image _sprite = default!;
        [SerializeField] private TMP_Text _nameText = default!;
        [SerializeField] private CostResourceDisplay _produceDisplay = default!;

        private void Awake()
        {
            this.CheckSerializedField(_sprite, nameof(_sprite));
            this.CheckSerializedField(_nameText, nameof(_nameText));
            this.CheckSerializedField(_produceDisplay, nameof(_produceDisplay));
        }

        private void Start()
        {
            _nameText.text = Watched.GetName();
            _produceDisplay.Watched = Watched.GetProduce()[0]; //TODO if produces more than one!

            var loadedSprite = Resources.Load<Sprite>(Watched.GetResourcepath());
            if (loadedSprite != null)
                _sprite.sprite = loadedSprite;
        }
    }
}
