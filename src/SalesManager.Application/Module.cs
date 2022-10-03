using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace SalesManager.Application;

public static class Module
{
    public static void RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(typeof(Module));
        services.AddAutoMapper(typeof(Module));
    }
}
