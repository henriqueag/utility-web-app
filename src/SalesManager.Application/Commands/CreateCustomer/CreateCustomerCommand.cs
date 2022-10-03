using MediatR;
using SalesManager.Application.Dtos;

namespace SalesManager.Application.Commands.CreateCustomer;

public record CreateCustomerCommand : CustomerData, IRequest<Guid>
{
    public string Cpf { get; init; }
}
