using System.Collections.Generic;
using TradeCity.Engine.Market;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Unity.Scripts.GUI.ResourceDispalys;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    public class ResourceSelectorScript : MonoBehaviour
    {
        public Resource selected;
        public Dropdown dropdown;
        List<string> options = GetOptions();
        // Start is called before the first frame update
        void Start()
        {
            dropdown.captionText.text = "Select Resource...";
            dropdown.ClearOptions();
            dropdown.AddOptions(options);
            dropdown.onValueChanged.AddListener((int i) =>
                {
                    selected = ResourceDisplayScript.ConvertToRes(options[i]);
                    dropdown.captionText.text = selected.GetName();
                    dropdown.Hide();
                }
            );
        }

        private static List<string> GetOptions()
        {
            List<string> options = new List<string>();
            foreach (Resource res in SessionGenerator.GetResourceList())
            {
                if (res is ISellable && res.GetName() != "Money")
                    options.Add(res.GetName());
            }
            return options;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
