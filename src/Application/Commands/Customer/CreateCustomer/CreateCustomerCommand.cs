using Application.Dtos.Customer;

namespace Application.Commands.CreateCustomer;

public record CreateCustomerCommand : CustomerData, IRequest<Guid>
{
    public string Cpf { get; init; }
}
