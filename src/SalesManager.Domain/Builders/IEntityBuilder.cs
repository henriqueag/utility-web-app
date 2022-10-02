namespace SalesManager.Domain.Builders;

public interface IEntityBuilder<out TEntity>
{
    TEntity Build();
}
