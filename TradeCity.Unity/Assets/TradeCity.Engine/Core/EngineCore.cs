using AutSoft.UnitySupplements.EventBus;
using Injecter;
using Microsoft.Extensions.DependencyInjection;
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
        
        private EngineCore()
        {

            IServiceCollection services = new ServiceCollection();

            services.AddLogging();
            services.AddEventBus();
            services.AddSingleton<IClock, Clock>();


            CompositionRoot.ServiceProvider = services.BuildServiceProvider();
        }

        public static void RegisterTickable(ITickable tickable) => ((IClock)CompositionRoot.ServiceProvider!.GetService(typeof(IClock))).Register(tickable);

        public static void RemoveTickable(ITickable tickable) => ((IClock)CompositionRoot.ServiceProvider!.GetService(typeof(IClock))).Remove(tickable);

        public static IEventBus InjectEventBus() => (IEventBus)CompositionRoot.ServiceProvider!.GetService(typeof(IEventBus));

        public static IClock InjectClock() => (IClock)CompositionRoot.ServiceProvider!.GetService(typeof(IClock));
    }
}
