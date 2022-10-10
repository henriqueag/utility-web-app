using Application.Dtos;

namespace Application.Queries.GetAllCustomers;

public record GetAllCustomersQuery(string FullName) : IRequest<IEnumerable<CustomerDetailedData>>
{
}