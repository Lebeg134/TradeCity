using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Session;
using UnityEngine;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class CostResourceDisplay : ResourceDisplay
    {
        [Inject] private IPlayerService _playerService;
        [SerializeField] private const bool RedIfNotEnough = true;

        protected override void Awake()
        {
            base.Awake();
            _playerService = EngineCore.InjectPlayerService();
        }

        protected override void Update()
        {
            base.Update();
            if (Watched != null && RedIfNotEnough)
            {
                _icon.color = _playerService.CurrentPlayer.CheckResource(Watched) ?
                Color.white : Color.red;
            }
        }
    }
}
