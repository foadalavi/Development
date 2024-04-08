using Librarian.Application.Contracts.Persistence;
using Librarian.Persistence.Contexts;
using Librarian.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Librarian.Persistence.Configurations
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LibrarianDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LibrarianConnectionString"))
            );

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IMemberRepository,MemberRepository>();
            return services;
        }
    }
}
