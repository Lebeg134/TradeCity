using AutSoft.UnitySupplements.EventBus;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TradeCity.Unity.Scripts
{
    public  class Services
    {
        public static void ConfigureServices(HostBuilderContext builder, IServiceCollection services)
        {
            //var assemblies = new[] { typeof(AppInstaller).Assembly };

            //services.AddEventBus(assemblies);
        }
    }
}
