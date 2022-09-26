using Microsoft.EntityFrameworkCore;
using SalesManager.Api.Domain.Repository;
using SalesManager.Api.Presentation.UnitOfWork;
using SalesManager.Api.Provider.EntityFramework.SqlServer;
using SalesManager.Api.Provider.EntityFramework.SqlServer.Repository;

namespace SalesManager.SalesManager.Api.Runtime.Host.IoC;

public static class NativeInjectorConfig
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<SqlServerDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("Default")
                .Replace("{AttachDBFilename}", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SalesManager.mdf"));

            options.UseSqlServer(connectionString);
        });

        services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        services.AddTransient<IUnitOfWork>(sp => sp.GetRequiredService<SqlServerDbContext>());
    }
}
