using SalesManager.Domain.Entities;

namespace SalesManager.Domain.Builders;

public interface ICustomerBuilder : IEntityBuilder<Customer>
{
    ICustomerBuilder WithErrorCode(string errorCode);
    ICustomerBuilder WithErrorMessage(string errorMessage);
    ICustomerBuilder WithFullName(string fullName);
    ICustomerBuilder WithCpf(string cpf);
    ICustomerBuilder WithBirthDate(DateTime birthDate);
    ICustomerBuilder WithPhone(string phone);
    ICustomerBuilder WithEmail(string email);
    ICustomerBuilder WithIsActive(bool isActive);
}