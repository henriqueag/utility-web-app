using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SalesManager.Domain.Builders;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Validators;
using static SalesManager.Domain.Entities.Customer;

namespace SalesManager.Domain;

public static class Module
{
    public static void RegisterDomainServices(this IServiceCollection services)
    {
        services.AddTransient<ICustomerBuilder, CustomerBuilder>();
        services.AddTransient<IValidator<Customer>, CustomerValidator>();
    }
}
