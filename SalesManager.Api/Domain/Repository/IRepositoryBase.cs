using SalesManager.Api.Domain.Contracts;

namespace SalesManager.Api.Domain.Repository;

public interface IRepositoryBase<TEntity> where TEntity : class, IHasUniqueKey
{
    Task<IReadOnlyCollection<TEntity>> GetAll(CancellationToken cancellationToken);
    Task<TEntity> GetById(Guid id, CancellationToken cancellationToken);
    Task Create(TEntity entity, CancellationToken cancellationToken);
    Task Delete(TEntity entity);
    Task Update(TEntity entity);
}
