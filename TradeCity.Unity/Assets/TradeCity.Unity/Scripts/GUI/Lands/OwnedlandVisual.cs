using AutSoft.UnitySupplements.Vitamins;
using TradeCity.Engine.Structures;
using TradeCity.Unity.Scripts.GUI.ResourceDispalys;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class OwnedlandVisual : MonoBehaviour
    {
        public Land watched;
        [SerializeField] private Image sprite;
        [SerializeField] private Text nameText;
        [SerializeField] private GameObject produceDisplay;

        private void Awake()
        {
            this.CheckSerializedField(sprite, nameof(sprite));
            this.CheckSerializedField(nameText, nameof(nameText));
            this.CheckSerializedField(produceDisplay, nameof(produceDisplay));
        }

        private void Start()
        {
            nameText.text = watched.GetName();
            produceDisplay.GetComponent<ResourceDisplayScript>().Watched = watched.GetProduce()[0]; //TODO if produces more than one!

            var loadedSprite = Resources.Load<Sprite>(watched.GetResourcepath());
            if (loadedSprite != null)
                sprite.sprite = loadedSprite;
        }
    }
}
