using AutSoft.UnitySupplements.EventBus;
using AutSoft.UnitySupplements.Vitamins;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Unity.Scripts.GUI.Lands;
using UnityEngine;

namespace TradeCity.Unity.Scripts.World_Elements.Lands
{
    public class LandManager: MonoBehaviour
    {
        [Inject] private IEventBus _eventBus;

        [SerializeField] private LandBuyPanel _landBuyPanel = default!;

        private void Awake()
        {
            _eventBus = EngineCore.InjectEventBus();

            this.CheckSerializedField(_landBuyPanel, nameof(_landBuyPanel));



            _eventBus.SubscribeWeak<CampaignLandPrefab.LandClicked>(this, OnLandClicked);
        }

        private void OnLandClicked(CampaignLandPrefab.LandClicked message)
        {
            var player = message.Player;
            var land = message.Land;

            if (player.HasStructure(land))
            {
                //TODO highlight in Land list
                return;
            }

            _landBuyPanel.Display(land);
        }
    }
}