using FluentValidation;
using MediatR;
using SalesManager.Api.Filters;
using SalesManager.Application.UnitOfWork;
using SalesManager.Domain.Builders;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Repository;
using SalesManager.Domain.Validators;
using SalesManager.Provider.EntityFramework;
using SalesManager.Provider.EntityFramework.Repositories;
using static SalesManager.Domain.Entities.Customer;

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


        services.AddMvc(options =>
        {
            options.Filters.Add<UserFriendlyExceptionFilter>();
        });

        services.AddMediatR(typeof(Application.Commands.CreateCustomerCommand.CreateCustomerCommand));
        services.AddTransient<IValidator<Customer>, CustomerValidator>();
        services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
        services.AddTransient<IUnitOfWork>(sp => sp.GetRequiredService<SqlServerDbContext>());
        services.AddTransient<ICustomerBuilder, CustomerBuilder>();
    }
}
