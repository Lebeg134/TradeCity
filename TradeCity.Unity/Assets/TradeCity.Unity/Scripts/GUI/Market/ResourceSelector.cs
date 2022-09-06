using AutSoft.UnitySupplements.Vitamins;
using System.Collections.Generic;
using TradeCity.Engine.Market;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Unity.Scripts.GUI.ResourceDispalys;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    public class ResourceSelector : MonoBehaviour
    {
        [SerializeField] private Dropdown dropdown;

        public Resource selected;

        private readonly List<string> options = GetOptions();

        private void Awake()
        {
            this.CheckSerializedField(dropdown, nameof(dropdown));
        }

        private void Start()
        {
            dropdown.captionText.text = "Select Resource...";
            dropdown.ClearOptions();
            dropdown.AddOptions(options);
            dropdown.onValueChanged.AddListener((int i) =>
                {
                    selected = ResourceDisplay.ConvertToRes(options[i]);
                    dropdown.captionText.text = selected.GetName();
                    dropdown.Hide();
                }
            );
        }

        private static List<string> GetOptions()
        {
            List<string> options = new();
            foreach (Resource res in SessionGenerator.GetResourceList())
            {
                if (res is ISellable && res.GetName() != "Money")
                    options.Add(res.GetName());
            }
            return options;
        }
    }
}
