using MediatR;
using SalesManager.Application.Dtos;

namespace SalesManager.Application.Queries.GetAllCustomers;

public record GetAllCustomersQuery : IRequest<IEnumerable<CustomerDetailedData>>
{
}