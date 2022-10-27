using AutSoft.UnitySupplements.Vitamins;
using System.Collections.Generic;
using System.Linq;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
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
        [Inject] private ISessionService _sessionService;

        [SerializeField] private Dropdown _dropdown = default!;

        public Resource Selected;

        private List<string> _options;

        private void Awake()
        {
            _sessionService = EngineCore.InjectSessionService();
            this.CheckSerializedField(_dropdown, nameof(_dropdown));
        }

        private void Start()
        {
            _options = GetOptions();
            _dropdown.captionText.text = "Select Resource...";
            _dropdown.ClearOptions();
            _dropdown.AddOptions(_options);
            _dropdown.onValueChanged.AddListener((int i) =>
                {
                    Selected = ConvertToRes(_options[i]);
                    _dropdown.captionText.text = Selected.GetName();
                    _dropdown.Hide();
                }
            );
        }

        private Resource ConvertToRes(string option)
        {
            return _sessionService.GetResourceList().First((resource => resource.GetName() == option));
        }

        private List<string> GetOptions()
        {
            List<string> list = new List<string>();
            foreach (var res in _sessionService.GetResourceList())
            {
                if (res is ISellable && res.GetName() != "Money") list.Add(res.GetName());
            }

            return list;
        }
    }
}
