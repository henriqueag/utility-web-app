using Domain.Entities;
using Domain.Repository;
using Infrastructure.DataContext;

namespace Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly SqlServerDbContext _context;

    public CustomerRepository(SqlServerDbContext context)
    {
        _context = context;
    }

    public async Task<Customer> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Set<Customer>()
            .Include(x => x.SalesOrders)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<Customer>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _context.Set<Customer>()
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task CreateAsync(Customer customer, CancellationToken cancellationToken)
    {
        await _context.Set<Customer>()
            .AddAsync(customer, cancellationToken);
    }

    public Task DeleteAsync(Customer customer, CancellationToken cancellationToken)
    {
        return Task.Run(() => _context.Remove(customer), cancellationToken);
    }
}