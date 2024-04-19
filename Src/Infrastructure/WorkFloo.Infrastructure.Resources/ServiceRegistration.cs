using Microsoft.Extensions.DependencyInjection;
using WorkFloo.Application.Interfaces;
using WorkFloo.Infrastructure.Resources.Services;

namespace WorkFloo.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static void AddResourcesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITranslator, Translator>();
        }
    }
}
