using MediatR;
using SalesManager.Application.Dtos;

namespace SalesManager.Application.Queries.GetAllCustomers;

public record GetCustomerQuery : IRequest<CustomerDetailedData>
{
    public GetCustomerQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; init; }
}