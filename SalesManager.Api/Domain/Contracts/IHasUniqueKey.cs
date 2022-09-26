namespace SalesManager.Api.Domain.Contracts
{
    public interface IHasUniqueKey
    {
        public Guid Id { get; }
    }
}
