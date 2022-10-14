namespace Domain.Interfaces.Builders;

public interface IEntityBuilder<out TEntity>
{
    TEntity Build();
}