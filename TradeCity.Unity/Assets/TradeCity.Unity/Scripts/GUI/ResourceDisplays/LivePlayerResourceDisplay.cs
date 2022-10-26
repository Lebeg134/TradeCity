using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Core;
using TradeCity.Engine.Core.Interfaces;
using TradeCity.Engine.Session;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class LivePlayerResourceDisplay : LiveResourceDisplay
    {
        [Inject] private IPlayerService _playerService;
        [Inject] private IEventBus _eventBus;

        protected override void Awake()
        {
            base.Awake();
            _playerService = EngineCore.InjectPlayerService();
            _eventBus = EngineCore.InjectEventBus();
            //_eventBus.Subscribe();
        }

        protected override void Start()
        {
            if (Resource != null && _playerService.CurrentPlayer != null)
                Watched = _playerService.CurrentPlayer.GetRes(ConvertToRes(Resource));
            UpdateVisuals();
        }
    }
}
