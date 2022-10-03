using MediatR;
using SalesManager.Application.Dtos;

namespace SalesManager.Application.Commands.UpdateCustomer;

public record UpdateCustomerCommand : IRequest<Unit>
{
    public UpdateCustomerCommand(Guid id, CustomerData data)
    {
        Id = id;
        Data = data;
    }

    public Guid Id { get; init; }
    public CustomerData Data { get; init; }
}