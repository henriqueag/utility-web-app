using FluentValidation;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Exceptions;

namespace SalesManager.Domain.Validators;

public class CustomerValidator : AbstractValidator<Customer>
{
    private const string RequiredErrorCode = "customer-full-name.required-property";
    private const string MinimumLengthErrorCode = "customer-full-name.minimum-length";
    private const string MaximumLengthErrorCode = "customer-full-name.maximum-length";

    public CustomerValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty()
            .WithErrorCode(RequiredErrorCode)
            .WithMessage("O nome completo é obrigatório");

        RuleFor(x => x.FullName)
            .MinimumLength(4)
            .WithErrorCode(MinimumLengthErrorCode)
            .WithMessage("O nome completo deve ter o tamanho mínimo de 4 caracteres");

        RuleFor(x => x.FullName)
            .MaximumLength(128)
            .WithErrorCode(MaximumLengthErrorCode)
            .WithMessage("O nome completo deve ter o tamanho maximo de 128 caracteres");
    }

    public new void Validate(Customer customer)
    {
        var validationResult = base.Validate(customer);

        var errors = validationResult.Errors;

        if (!errors.Any()) 
            return;

        var projectedErrors = errors.Select(x => new
        {
            x.ErrorCode,
            x.ErrorMessage
        } as object);

        throw new UserFriendlyException("customer-build-failed", $"Falha na construção do objeto do tipo {nameof(Customer)}", projectedErrors);
    }
}
