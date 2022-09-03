using TradeCity.Engine.Structures;
using TradeCity.Unity.Scripts.GUI.ResourceDispalys;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Lands
{
    public class OwnedlandVisualSript : MonoBehaviour
    {
        public Land watched;
        public Image sprite;
        public Text nameText;
        public GameObject produceDisplay;

        void Start()
        {
            nameText.text = watched.GetName();
            produceDisplay.GetComponent<ResourceDisplayScript>().Watched = watched.GetProduce()[0]; //TODO if produces more than one!

            var loadedSprite = Resources.Load<Sprite>(watched.GetResourcepath());
            if (loadedSprite != null)
                sprite.sprite = loadedSprite;
        }
        void Update()
        {

        }
    }
}
