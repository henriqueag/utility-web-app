using FluentValidation;
using SalesManager.Domain.Entities;
using System.Text.RegularExpressions;
using FluentValidation.Validators;

namespace SalesManager.Domain.Validators;

public class CustomerValidator : AbstractValidator<Customer>
{
    #region Constants Code Error
    private const string FullNameRequired = "customer-full-name.required-property";
    private const string FullNameMinimumLength = "customer-full-name.minimum-length";
    private const string FullNameMaximumLength = "customer-full-name.maximum-length";
    private const string CpfRequired = "customer-cpf.required-property";
    private const string CpfFormat = "customer-cpf.format-not-valid";
    private const string PhoneRequired = "customer-cpf.required-property";
    private const string EmailMaximumLength = "customer-email.maximum-length";
    private const string EmailFormat = "customer-email.format-not-valid";
    #endregion

    public CustomerValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty()
            .WithErrorCode(FullNameRequired)
            .WithMessage("O nome completo é obrigatório");

        RuleFor(x => x.FullName)
            .MinimumLength(Customer.FullNameMinLength)
            .WithErrorCode(FullNameMinimumLength)
            .WithMessage($"O nome completo deve ter o tamanho mínimo de {Customer.FullNameMinLength} caracteres");

        RuleFor(x => x.FullName)
            .MaximumLength(Customer.FullNameMaxLength)
            .WithErrorCode(FullNameMaximumLength)
            .WithMessage($"O nome completo deve ter o tamanho máximo de {Customer.FullNameMaxLength} caracteres");

        RuleFor(x => x.Cpf)
            .NotEmpty()
            .WithErrorCode(CpfRequired)
            .WithMessage("O CPF é obrigatório");

        RuleFor(x => x.Cpf)
            .Must(x => ValidateCpf(x))
            .WithErrorCode(CpfFormat)
            .WithMessage("O CPF informado é inválido");

        RuleFor(x => x.Phone)
            .NotEmpty()
            .WithErrorCode(PhoneRequired)
            .WithMessage("O telefone é obrigatório");

        RuleFor(x => x.Email)
            .MaximumLength(Customer.EmailMaxLength)
            .WithErrorCode(EmailMaximumLength)
            .WithMessage($"O email deve ter o tamanho máximo de {Customer.EmailMaxLength} caracteres");

        RuleFor(x => x.Email)
            .EmailAddress(EmailValidationMode.AspNetCoreCompatible)
            .WithErrorCode(EmailFormat)
            .WithMessage("O formato do email informado é inválido");
    }

    private static bool ValidateCpf(string cpf)
    {
        var hasMask = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$").IsMatch(cpf);
        if (hasMask)
            cpf = cpf.Replace(".", "").Replace("-", "");

        var hasValidFormat = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$|\d{11}").IsMatch(cpf);
        var hasRepeatedSequence = new Regex("1{11}|2{11}|3{11}|4{11}|5{11}|6{11}|7{11}|8{11}|9{11}|0{11}").IsMatch(cpf);

        if (!hasValidFormat || hasRepeatedSequence)
        {
            return false;
        }

        int digitOne;
        int digitTwo;

        int adder = 0;
        int multiplier = 10;

        for (int i = 0; i < cpf.Length - 2; i++)
        {
            var value = Convert.ToInt32(cpf[i].ToString());
            adder += value * multiplier;
            multiplier--;
        }

        adder = 11 - (adder % 11);
        digitOne = adder >= 10 ? 0 : adder;

        adder = 0;
        multiplier = 11;

        for (int i = 0; i < cpf.Length - 1; i++)
        {
            int valor = Convert.ToInt32(cpf[i].ToString());
            adder += valor * multiplier;
            multiplier--;
        }

        adder = 11 - (adder % 11);
        digitTwo = adder >= 10 ? 0 : adder;

        return cpf.Substring(cpf.Length - 2, 1) == digitOne.ToString()
            && cpf.Substring(cpf.Length - 1, 1) == digitTwo.ToString();
    }
}
