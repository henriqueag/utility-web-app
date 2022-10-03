using SalesManager.Api.Filters;
using SalesManager.Application;
using SalesManager.Domain;
using SalesManager.Provider.EntityFramework;

namespace SalesManager.Api.IoC;

public static class NativeInjectorConfig
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.RegisterDomainServices();
        services.RegisterApplicationServices();
        services.RegisterProviderServices(configuration);
        
        services.AddMvc(options =>
        {
            options.Filters.Add<UserFriendlyExceptionFilter>();
        });        
    }
}
