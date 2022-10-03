using SalesManager.Domain.Entities;

namespace SalesManager.Domain.Repository;

public interface ICustomerRepository
{
    Task<Customer> GetById(Guid id, CancellationToken cancellationToken);
    Task Delete(Customer customer);
}
