using Domain.Interfaces.Contracts;

namespace Domain.Interfaces.Repository;

public interface IRepositoryBase<TEntity> where TEntity : class, IHasUniqueKey
{
    Task<IQueryable<TEntity>> GetAll(CancellationToken cancellationToken);
    Task<TEntity> GetById(Guid id, CancellationToken cancellationToken);
    Task Create(TEntity entity, CancellationToken cancellationToken);
    Task Delete(TEntity entity, CancellationToken cancellationToken);
}