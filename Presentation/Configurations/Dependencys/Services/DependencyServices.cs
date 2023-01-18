namespace Presentation.Configurations.Dependencys.Services
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection DependencyServices(this IServiceCollection services)
        {
            services.AddScoped<IBoardServices, BoardServices>();
            services.AddScoped<ITaskServices, TaskServices>();

            return services;
        }
    }
}
