using AutSoft.UnitySupplements.EventBus;
using SimpleInjector;

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

            _container.Verify();
        }
    }
}
