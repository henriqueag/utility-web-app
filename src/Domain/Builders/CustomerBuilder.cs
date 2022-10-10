using Domain.Builders;
using Domain.Exceptions;
using Domain.ValueObjects;

namespace Domain.Entities;

public partial class Customer
{
    public class CustomerBuilder : ICustomerBuilder
    {
        private const string _errorCode = "customer-builder.customer-build-failed";
        private const string _errorMessage = $"Falha na construção do objeto do tipo {nameof(Customer)}";

        private readonly Customer _customer;
        private readonly IValidator<Customer> _validator;

        public CustomerBuilder(IValidator<Customer> validator)
        {
            _customer = new();
            _validator = validator;
        }

        public ICustomerBuilder WithFullName(string fullName)
        {
            _customer.FullName = fullName;
            return this;
        }

        public ICustomerBuilder WithCpf(string cpf)
        {
            _customer.Cpf = cpf;
            return this;
        }

        public ICustomerBuilder WithBirthDate(DateTime birthDate)
        {
            _customer.BirthDate = birthDate;
            return this;
        }

        public ICustomerBuilder WithPhone(string phone)
        {
            _customer.Phone = phone;
            return this;
        }

        public ICustomerBuilder WithEmail(string email)
        {
            _customer.Email = email;
            return this;
        }

        public ICustomerBuilder WithIsActive(bool isActive)
        {
            _customer.IsActive = isActive;
            return this;
        }

        public Customer Build()
        {
            var validationResult = _validator.Validate(_customer);

            var errors = validationResult.Errors;

            if (errors.Any())
            {
                var detailedErrors = errors.Select(x => new ErrorMessageWithDetails
                {
                    Code = x.ErrorCode,
                    Message = x.ErrorMessage
                });

                throw new UserFriendlyException(_errorCode, _errorMessage, detailedErrors);
            }

            return _customer;
        }
    }
}