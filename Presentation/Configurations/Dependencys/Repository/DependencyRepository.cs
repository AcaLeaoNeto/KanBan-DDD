using Domain.Interfaces.Repository;
using Infrastructure.Repository;

namespace Presentation.Configurations.Dependencys.Repository
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection DependencyRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryBoard, RepositoryBoard>();
            services.AddScoped<IRepositoryTask, RepositoryTask>();

            return services;
        }
    }
}
