using AutSoft.UnitySupplements.EventBus;
using SimpleInjector;
using TradeCity.Engine.TimeManager;

namespace TradeCity.Engine.Core
{
    public class EngineCore
    {
        private static EngineCore _instance;
        public static EngineCore Instance
        {
            get { return _instance ??= new EngineCore(); }
        }

        private readonly Container _container;

        private EngineCore()
        {
            _container = new Container();

            //Register services here
            _container.Register<IEventBus, SimpleEventBus>();
            _container.Register<IClock, Clock>(); //TODO possible Error!

            _container.Verify();
        }

        public void RegisterTickable(ITickable tickable) => _container.GetInstance<IClock>().Register(tickable);

        public void RemoveTickable(ITickable tickable) => _container.GetInstance<IClock>().Remove(tickable);

        public IEventBus InjectEventBus() => _container.GetInstance<IEventBus>();

        public IClock InjectClock() => _container.GetInstance<IClock>();
    }
}
