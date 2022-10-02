using AutSoft.UnitySupplements.EventBus;
using Injecter;
using TradeCity.Engine.Session;

namespace TradeCity.Unity.Scripts.GUI.ResourceDisplays
{
    public class LivePlayerResourceDisplay : LiveResourceDisplay
    {
        [Inject] private IEventBus _eventBus;

        protected override void Awake()
        {
            base.Awake();
            //_eventBus.Subscribe();
        }

        protected override void Start()
        {
            if (Resource != null)
                Watched = Player.CurrentPlayer.GetRes(ConvertToRes(Resource));
            UpdateVisuals();
        }
    }
}
