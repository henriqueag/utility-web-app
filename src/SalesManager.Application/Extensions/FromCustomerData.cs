using SalesManager.Application.Dtos;
using SalesManager.Domain.Builders;
using SalesManager.Domain.Entities;

namespace SalesManager.Application.Extensions;

public static class CustomerBuilderExtensions
{
    public static ICustomerBuilder FromCustomerData(this ICustomerBuilder builder, CustomerData data)
    {
        return builder
            .WithErrorCode("customer-build-failed")
            .WithErrorMessage($"Falha na construção do objeto do tipo {nameof(Customer)}")
            .WithFullName(data.FullName)
            .WithBirthDate(data.BirthDate)
            .WithPhone(data.Phone)
            .WithEmail(data.Email);
    }
}
