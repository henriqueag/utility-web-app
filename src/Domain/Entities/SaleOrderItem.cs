using Domain.Interfaces.Contracts;

namespace Domain.Entities;

public class SaleOrderItem : IHasUniqueKey
{
    private SaleOrderItem() { }

    public SaleOrderItem(Product product, int quantity, decimal unitAmount)
    {
        Id = Guid.NewGuid();
        Product = product;
        Quantity = quantity;
        UnitAmount = unitAmount;
    }

    public Guid Id { get; private set; }
    public Guid SaleOrderId { get; private set; }
    public SaleOrder SaleOrder { get; private set; }
    public Guid ProductId { get; private set; }
    public Product Product { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitAmount { get; private set; }
}
