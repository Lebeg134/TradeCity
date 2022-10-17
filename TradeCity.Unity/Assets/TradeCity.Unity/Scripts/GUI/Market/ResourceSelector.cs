using AutSoft.UnitySupplements.Vitamins;
using System.Collections.Generic;
using TradeCity.Engine.Market;
using TradeCity.Engine.Resources;
using TradeCity.Engine.Session;
using TradeCity.Unity.Scripts.GUI.ResourceDisplays;
using UnityEngine;
using UnityEngine.UI;

namespace TradeCity.Unity.Scripts.GUI.Market
{
    public class ResourceSelector : MonoBehaviour
    {
        [SerializeField] private Dropdown _dropdown = default!;

        public Resource Selected;

        private readonly List<string> _options = GetOptions();

        private void Awake()
        {
            this.CheckSerializedField(_dropdown, nameof(_dropdown));
        }

        private void Start()
        {
            _dropdown.captionText.text = "Select Resource...";
            _dropdown.ClearOptions();
            _dropdown.AddOptions(_options);
            _dropdown.onValueChanged.AddListener((int i) =>
                {
                    Selected = ResourceDisplay.ConvertToRes(_options[i]);
                    _dropdown.captionText.text = Selected.GetName();
                    _dropdown.Hide();
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
