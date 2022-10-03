using SalesManager.Domain.Contracts;
using SalesManager.Domain.Repository;

namespace SalesManager.Provider.EntityFramework.Repositories;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class, IHasUniqueKey
{
    private readonly SqlServerDbContext _context;

    public RepositoryBase(SqlServerDbContext context)
    {
        _context = context;
    }

    public async Task Create(TEntity entity, CancellationToken cancellationToken)
    {
        await _context.AddAsync(entity, cancellationToken);
    }

    public Task Delete(TEntity entity)
    {
        _context.Remove(entity);
        return Task.CompletedTask;
    }

    public async Task<IReadOnlyCollection<TEntity>> GetAll(CancellationToken cancellationToken)
    {
        return await _context.Set<TEntity>()
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<TEntity> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Set<TEntity>()
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task Update(TEntity entity)
    {
        _context.Update(entity);
        return Task.CompletedTask;
    }
}