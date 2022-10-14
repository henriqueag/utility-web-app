using Application.Dtos.Customer;
using Domain.Interfaces.Builders;

namespace Application.Extensions;

public static class CustomerBuilderExtensions
{
    public static ICustomerBuilder FromCustomerData(this ICustomerBuilder builder, CustomerData data)
    {
        return builder
            .WithFullName(data.FullName)
            .WithBirthDate(data.BirthDate)
            .WithPhone(data.Phone)
            .WithEmail(data.Email);
    }
}