namespace Domain.Builders;

public interface IEntityBuilder<out TEntity>
{
    TEntity Build();
}