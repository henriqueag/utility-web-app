using SalesManager.Application.UnitOfWork;
using SalesManager.Domain.Repository;
using SalesManager.Provider.EntityFramework;
using SalesManager.Provider.EntityFramework.Repositories;

namespace SalesManager.Api.IoC;

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
