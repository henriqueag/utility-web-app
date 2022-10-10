using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class Module
{
    public static void RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(typeof(Module));
        services.AddAutoMapper(typeof(Module));
    }
}
