using SalesManager.Domain.Entities;
using SalesManager.Domain.Exceptions;
using SalesManager.Domain.Repository;

namespace SalesManager.Provider.EntityFramework.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly SqlServerDbContext _context;

    public CustomerRepository(SqlServerDbContext context)
    {
        _context = context;
    }

    public async Task<Customer> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Set<Customer>()
            .AsNoTracking()
            .Include(x => x.SalesOrders)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task Delete(Customer customer)
    {
        if (customer.SalesOrders.Any())
        {
            throw new UserFriendlyException("customer-repository.not-allowed-deletion",
                "Não é permitido a exclusão de cadastro de cliente que possui vendas relacionadas");
        }

        _context.Remove(customer);

        return Task.CompletedTask;
    }
}