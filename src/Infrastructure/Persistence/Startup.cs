using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence
{
    internal static class Startup
    {
        internal static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            return services
                .AddDbContext<FooContext>()
                .AddScoped<BooRepository>();
        }
    }
}
