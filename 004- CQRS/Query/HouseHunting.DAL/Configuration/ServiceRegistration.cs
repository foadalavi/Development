using Microsoft.Extensions.DependencyInjection;

namespace HouseHunting.Query.DAL.Configuration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterDalServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IRepository, Repository>();
            return serviceCollection;
        }
    }
}
