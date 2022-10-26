using AutSoft.UnitySupplements.EventBus;
using Injecter;
using Microsoft.Extensions.DependencyInjection;
using TradeCity.Engine.Core.Interfaces;
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
            services.AddSingleton<IPlayerService, StandardPlayerService>();
            services.AddSingleton<ISessionService, StandardSessionService>();


            CompositionRoot.ServiceProvider = services.BuildServiceProvider();
        }

        public static void RegisterTickable(ITickable tickable) => ((IClock)CompositionRoot.ServiceProvider!.GetService(typeof(IClock))).Register(tickable);

        public static void RemoveTickable(ITickable tickable) => ((IClock)CompositionRoot.ServiceProvider!.GetService(typeof(IClock))).Remove(tickable);

        public static IEventBus InjectEventBus() => (IEventBus)CompositionRoot.ServiceProvider!.GetService(typeof(IEventBus));

        public static IClock InjectClock() => (IClock)CompositionRoot.ServiceProvider!.GetService(typeof(IClock));

        public static IPlayerService InjectPlayerService() => (IPlayerService)CompositionRoot.ServiceProvider!.GetService(typeof(IPlayerService));
        public static ISessionService InjectSessionService() => (ISessionService)CompositionRoot.ServiceProvider!.GetService(typeof(ISessionService));
    }
}
