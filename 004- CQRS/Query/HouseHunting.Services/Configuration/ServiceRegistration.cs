using HouseHunting.Query.BIZ.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HouseHunting.Query.BIZ.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterBusinessServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IHouseHuntingServices, HouseHuntingServices>();
            serviceCollection.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return serviceCollection;
        }
    }
}
