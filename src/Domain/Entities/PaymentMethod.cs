namespace Domain.Entities;

public class PaymentMethod : BaseEntity
{
    public const int DescriptionMaxLength = 128;

    private PaymentMethod() { }

    public PaymentMethod(string description, bool allowsDiscount)
    {
        Description = description;
        AllowsDiscount = allowsDiscount;
    }

    public string Description { get; private set; }
    public bool AllowsDiscount { get; private set; }
    public IReadOnlyCollection<SaleOrder> SalesOrders { get; set; }
}