using Application.Dtos.Customer;

namespace Application.Commands.UpdateCustomer;

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