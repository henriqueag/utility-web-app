using Domain.Interfaces.Contracts;

namespace Domain.Entities;

public abstract class BaseEntity : IHasUniqueKey, IHasCreatedTime, IHasUpdatedTime
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; protected set; }

    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}
