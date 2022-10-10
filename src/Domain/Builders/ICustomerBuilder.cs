using Domain.Entities;

namespace Domain.Builders;

public interface ICustomerBuilder : IEntityBuilder<Customer>
{
    ICustomerBuilder WithFullName(string fullName);
    ICustomerBuilder WithCpf(string cpf);
    ICustomerBuilder WithBirthDate(DateTime birthDate);
    ICustomerBuilder WithPhone(string phone);
    ICustomerBuilder WithEmail(string email);
    ICustomerBuilder WithIsActive(bool isActive);
}