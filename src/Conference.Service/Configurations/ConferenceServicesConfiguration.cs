using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Conference.Service.Configurations
{
    public static class ConferenceServicesConfiguration
    {
        public static IServiceCollection RegisterConferenceServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}
