using MediatR;

namespace SalesManager.Application.Commands.DeleteCustomer;

public record DeleteCustomerCommand : IRequest<Unit>
{
    public DeleteCustomerCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; init; }
}