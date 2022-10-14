using Application.Dtos.Customer;

namespace Application.Queries.GetAllCustomers;

public record GetAllCustomersQuery(string FullName) : IRequest<IEnumerable<CustomerDetailedData>>
{
}