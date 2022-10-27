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
            get
            {
                EnsureObject();
                return _instance;
            }
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

        private static void EnsureObject()
        {
            _instance ??= new EngineCore();
        }

        public static void RegisterTickable(ITickable tickable)
        {
            EnsureObject();
            ((IClock)CompositionRoot.ServiceProvider!.GetService(typeof(IClock))).Register(tickable);
        }

        public static void RemoveTickable(ITickable tickable)
        {
            EnsureObject();
            ((IClock)CompositionRoot.ServiceProvider!.GetService(typeof(IClock))).Remove(tickable);
        }

        public static IEventBus InjectEventBus()
        {
            EnsureObject();
            return (IEventBus)CompositionRoot.ServiceProvider!.GetService(typeof(IEventBus));
        }

        public static IClock InjectClock()
        {
            EnsureObject();
            return (IClock)CompositionRoot.ServiceProvider!.GetService(typeof(IClock));
        }

        public static IPlayerService InjectPlayerService()
        {
            EnsureObject();
            return (IPlayerService)CompositionRoot.ServiceProvider!.GetService(typeof(IPlayerService));
        }

        public static ISessionService InjectSessionService()
        {
            EnsureObject();
            return (ISessionService)CompositionRoot.ServiceProvider!.GetService(typeof(ISessionService));
        }
    }
}
