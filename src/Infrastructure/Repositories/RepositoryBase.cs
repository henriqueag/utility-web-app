using Domain.Interfaces.Contracts;
using Domain.Interfaces.Repository;
using Infrastructure.DataContext;

namespace Infrastructure.Repositories;

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

    public Task Delete(TEntity entity, CancellationToken cancellationToken)
    {
        return Task.Run(() => _context.Remove(entity), cancellationToken);
    }

    public Task Update(TEntity entity, CancellationToken cancellationToken)
    {
        return Task.Run(() => _context.Update(entity), cancellationToken);
    }

    public async Task<IQueryable<TEntity>> GetAll(CancellationToken cancellationToken)
    {
        var query = _context.Set<TEntity>()
            .AsNoTracking();

        return await Task.Run(() => query, cancellationToken);
    }

    public async Task<TEntity> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await _context.Set<TEntity>()
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}