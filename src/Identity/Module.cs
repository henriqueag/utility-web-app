using Identity.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Identity;

public static class Module
{
    public static void RegisterIdentityServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IdentityDataContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("Identity")
                .Replace("{AttachDBFilename}", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Identity.mdf"));

            options.UseSqlServer(connectionString);
        });
    }
}
