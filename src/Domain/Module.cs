using Domain.Builders;
using Domain.Entities;
using Domain.Validators;
using Microsoft.Extensions.DependencyInjection;
using static Domain.Entities.Customer;

namespace Domain;

public static class Module
{
    public static void RegisterDomainServices(this IServiceCollection services)
    {
        services.AddTransient<ICustomerBuilder, CustomerBuilder>();
        services.AddTransient<IValidator<Customer>, CustomerValidator>();
    }
}
